using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double? Bonus { get; set; }

        public double Salary { get; set; }

        public string? Address { get; set; }

        public float HourRate { get; set; }


    }
}
