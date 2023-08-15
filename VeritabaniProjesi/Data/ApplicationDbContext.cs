using Microsoft.EntityFrameworkCore;

using VeritabaniProjesii.Models; // Eğer Person modelini farklı bir isim alanında tanımladıysanız düzenlemeler yapın.
using VeritabaniProjesi.Data;

namespace VeritabaniProjesi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
    };
}
