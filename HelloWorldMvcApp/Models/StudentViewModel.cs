using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMvcApp.Models
{
    public class StudentViewModel
    {
        public Student student { get; set; }

        //This is going to be the drop down list - Type IEnumerable
        public IEnumerable<StudentGender> studentGender { get; set; }

    }
}
