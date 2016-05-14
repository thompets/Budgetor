using System.ComponentModel.DataAnnotations;

namespace Budgetor.Classes
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        public Expensor Expensor { get; set; }
    }
}
