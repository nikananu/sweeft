using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Pupil
    {
        public int PupilId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }

        // Navigation property to related teachers
        public ICollection<TeacherPupil> TeacherPupils { get; set; }
    

}
}
