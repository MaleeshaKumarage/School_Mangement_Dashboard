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
        public Student(Guid Id, int RegistrationNo, string FirstName, string MiddleName, string LastName, string Address_Line1, string Address_Line2, string Address_Line3,string Guardian_Name,long LandPhoneNo, long MobileNo,string DOB,string Gender)
        {
            this.Id = Id;
            this.RegistrationNo = RegistrationNo;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Address_Line1 = Address_Line1;
            this.Address_Line2 = Address_Line2;
            this.Address_Line3 = Address_Line3;
            this.Guardian_Name = Guardian_Name;
            this.LandPhoneNo = LandPhoneNo;
            this.MobileNo = MobileNo;
            this.DOB = DOB;
            this.Gender = Gender;
    }
    }
}
