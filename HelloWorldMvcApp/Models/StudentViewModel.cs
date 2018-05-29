using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMvcApp.Models
{
    public class StudentViewModel
    {
        public Student student { get; set; }
        public IEnumerable<StudentGender> studentGender { get; set; }

    }
}
