using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Managment_DashBoard.Models
{
    public class ClassRoom
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public string Name { get; set; }
        public int ClassTeacherId { get; set; }
        public List<StudentViewModel> StudentList { get; set; }
    }
}
