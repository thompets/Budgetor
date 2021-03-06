using System.ComponentModel.DataAnnotations;

namespace Budgetor.Classes
{
    public class Biller
    {
        public int Id { get; set; }

        [Required]
        public BillerType BillerType { get; set; }

        public string Name { get; set; }
    }
}
