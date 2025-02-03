using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class TeacherPupil
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int PupilId { get; set; }
        public Pupil Pupil { get; set; }
    }
}
