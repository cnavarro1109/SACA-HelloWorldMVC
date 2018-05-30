using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Required]
        [MinLength(2)]
        [Display(Name = "Name")]
        public string StudentName { get; set; }

        //public Gender StudentGender { get; set; }

        //public EnrolledStatus StudentEnrolled { get; set; }

        [Display(Name = "Enrolled")]
        public bool Enrolled { get; set; }

        //Start: Foreign Key -----------------------

        [ForeignKey("StudentGender")]
        public int StudentGenderId { get; set; }

        //Foreign Key Defined
        public virtual StudentGender StudentGender { get; set; }

        //End: Foreign Key -----------------------

    }


}
