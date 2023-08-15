using System.ComponentModel.DataAnnotations;

namespace VeritabaniProjesii.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        public int Age { get; set; }

        public string City { get; set; }
    }
}
