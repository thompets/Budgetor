using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Budgetor.Classes.Data
{
    public class Transaction
    {
        public int Id { get; set; }
        public TransactionType TransactionType { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}