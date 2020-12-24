using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24122020form
{
    public class Student
    {
        public string Name { get; set; }
        public DateTime Bday { get; set; }
        public double Avg { get; set; }
        public override string ToString()
        {
            return $"{Name,-10} {Bday.ToShortDateString()} {Avg:N2}";
        }
    }
}
