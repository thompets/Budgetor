using System;
using System.ComponentModel.DataAnnotations;

namespace Budgetor.Classes
{
    public class Deposit
    {
        public int Id { get; set; }

        [Required]
        public DepositType DepositType { get; set; }
    }
}
