using System;
using System.ComponentModel.DataAnnotations;

namespace Budgetor.Classes
{
    public class Transaction
    {
        public int Id { get; set; }

        [Required]
        public TransactionType TransactionType { get; set; }

        public double AmountSpent { get; set; }
        public DateTime Date { get; set; }
    }
}