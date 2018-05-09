using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMvcApp.Models
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum EnrolledStatus
    {
        Yes,
        No
    }

    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        public Gender StudentGender { get; set; }
        public EnrolledStatus StudentEnrolled { get; set; }
    }


}
