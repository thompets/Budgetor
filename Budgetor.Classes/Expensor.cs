using System.ComponentModel.DataAnnotations;

namespace Budgetor.Classes
{
    public class Expensor
    {
        public int Id { get; set; }

        [Required]
        public ExpenseType ExpenseType { get; set; }
        public string Name { get; set; }
    }
}
