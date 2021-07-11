using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public class CustomerBO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Status { get; set; }
        public TimeSpan Time { get; set; }
    }
}
