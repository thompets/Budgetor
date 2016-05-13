using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgetor.Classes.Data
{
    public class Bill
    {
        public int Id { get; set; }
        public Biller Biller { get; set; }
        public DateTime DueDate { get; set; }
        public double AmountDue { get; set; }
    }
}
