using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budgetor.Classes.Data
{
    public class Biller
    {
        public int Id { get; set; }
        public BillerType BillerType { get; set; }
        public string Name { get; set; }
    }
}
