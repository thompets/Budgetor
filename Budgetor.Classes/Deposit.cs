using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgetor.Classes.Data
{
    public class Deposit
    {
        public int Id { get; set; }
        public DepositType DepositType { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
