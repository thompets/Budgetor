using System;
using System.ComponentModel.DataAnnotations;

namespace Budgetor.Classes
{
    public class Bill
    {
        public int Id { get; set; }

        [Required]
        public Biller Biller { get; set; }
    }
}
