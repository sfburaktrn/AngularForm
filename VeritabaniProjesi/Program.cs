using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using VeritabaniProjesi.Data;
using VeritabaniProjesi.Controllers;
using VeritabaniProjesii.Models; // Person sınıfının ad alanı

namespace VeritabaniProjesi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // DbContext yapılandırması
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            var app = builder.Build();

            // PersonController'ı çağırmak ve cevabı döndürmek
            app.MapGet("/api/person", async context =>
            {
                using (var scope = app.Services.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    var controller = new PersonController(dbContext);
                    await controller.GetPeople();
                }
            });

            app.MapPost("/api/person", async context =>
            {
                using (var scope = app.Services.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                    var controller = new PersonController(dbContext);

                    // JSON verisini alarak PostPerson metoduna gönder
                    var person = await context.Request.ReadFromJsonAsync<Person>();
                    await controller.PostPerson(person);
                }
            });

            app.Run();
        }
    }
}
