using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Subject { get; set; }

        // Navigation property to related pupils
        public ICollection<TeacherPupil> TeacherPupils { get; set; }
    }
}
