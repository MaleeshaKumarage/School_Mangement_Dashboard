using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Managment_DashBoard.Models
{
    public class Exam
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Mark { get; set; }
    }
}
