using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Managment_DashBoard.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string EmployeeNo { get; set; }
        public string  FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NIC { get; set; }
        public DateTime DOB { get; set; }
        public long LandPhoneNo { get; set; }
        public long MobileNo { get; set; }
        public string Gender { get; set; }

    }
}
