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
                DOB =this.DOB,
                Gender = this.Gender,
               

            };
        }
    }
    internal static class CovidResourceEntityExtentions
    {
        public static StudentViewModel ToStudentViewModel(this Student entity)
        {
            return new StudentViewModel()
            {
               
                RegistrationNo = entity.RegistrationNo,
                FirstName = entity.FirstName,
                MiddleName = entity.MiddleName,
                LastName = entity.LastName,
                Address_Line1 = entity.Address_Line1,
                Address_Line2 = entity.Address_Line2,
                Address_Line3 = entity.Address_Line3,
                Guardian_Name = entity.Guardian_Name,
                LandPhoneNo = entity.LandPhoneNo,
                MobileNo = entity.MobileNo,
                DOB = entity.DOB,
                Gender = entity.Gender,
            };
        }
    }


}
