using System;
using System.Collections.Generic;
using System.Text;

namespace MySqlDBConnector
{
    public class Student
    {
        public Guid Id { get; set; }
        public int RegistrationNo { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address_Line1 { get; set; }
        public string Address_Line2 { get; set; }
        public string Address_Line3 { get; set; }
        public string Guardian_Name { get; set; }
        public long LandPhoneNo { get; set; }
        public long MobileNo { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }

        public Student()
        {
            Id = Guid.NewGuid();
        }
    }
}
