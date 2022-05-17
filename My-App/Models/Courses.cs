using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace My_App.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? grades { get; set; }
        public ICollection<Students>? Students{ get; set; }
    }
}
