using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFASSS1.Entites
{
    internal class Course
    {
        public int Id { get; set; }
        public double Duration { get; set; }
        public string Name { get; set; }
        public string Descrepition { get; set; }
        public int Top_Id { get; set; }
    }
}
