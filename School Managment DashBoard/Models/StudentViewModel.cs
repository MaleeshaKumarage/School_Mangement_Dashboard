using MySqlDBConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School_Managment_DashBoard.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
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

        public StudentViewModel(int RegistrationNo, string FirstName, string MiddleName, string LastName, string Address_Line1, string Address_Line2, string Address_Line3, string Guardian_Name, long LandPhoneNo, long MobileNo, string DOB, string Gender)
        {
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

        public StudentViewModel()
        {
        }

        internal Student ToStudent()
        {
            return new Student()
            {

                RegistrationNo = this.RegistrationNo,
                FirstName = this.FirstName,
                MiddleName = this.MiddleName,
                LastName = this.LastName,
                Address_Line1 = this.Address_Line1,
                Address_Line2 = this.Address_Line2,
                Address_Line3 = this.Address_Line3,
                Guardian_Name = this.Guardian_Name,
                LandPhoneNo = this.LandPhoneNo,
                MobileNo = this.MobileNo,
                DOB = this.DOB,
                Gender = this.Gender,


            };
        }

        public List<StudentViewModel> ToStudentViewModel(List<Student> entity)
        {
            List<StudentViewModel> stdList = new List<StudentViewModel>();

            foreach (var student in entity)
            {
                stdList.Add(new StudentViewModel(
                    RegistrationNo = student.RegistrationNo,
                    FirstName = student.FirstName,
                    MiddleName = student.MiddleName,
                    LastName = student.LastName,
                    Address_Line1 = student.Address_Line1,
                    Address_Line2 = student.Address_Line2,
                    Address_Line3 = student.Address_Line3,
                    Guardian_Name = student.Guardian_Name,
                    LandPhoneNo = student.LandPhoneNo,
                    MobileNo = student.MobileNo,
                    DOB = student.DOB,
                    Gender = student.Gender
                    ));
            }
            return stdList;            
        }
    }





}
