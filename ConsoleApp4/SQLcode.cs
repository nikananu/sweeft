using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class SQLcode
    {
        /*/

        CREATE TABLE Teacher (
    TeacherID INT AUTO_INCREMENT PRIMARY KEY,
    სახელი VARCHAR(50) NOT NULL,
    გვარი VARCHAR(50) NOT NULL,
    სქესი ENUM('მამრობითი', 'მდედრობითი') NOT NULL,
    საგანი VARCHAR(100) NOT NULL
);

CREATE TABLE Pupil (
    PupilID INT AUTO_INCREMENT PRIMARY KEY,
    სახელი VARCHAR(50) NOT NULL,
    გვარი VARCHAR(50) NOT NULL,
    სქესი ENUM('მამრობითი', 'მდედრობითი') NOT NULL,
    კლასი VARCHAR(50) NOT NULL
);

CREATE TABLE TeacherPupil (
    TeacherID INT,
    PupilID INT,
    PRIMARY KEY (TeacherID, PupilID),
    FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID),
    FOREIGN KEY (PupilID) REFERENCES Pupil(PupilID)
);

        SELECT DISTINCT Teacher.სახელი, Teacher.გვარი
FROM Teacher
JOIN TeacherPupil ON Teacher.TeacherID = TeacherPupil.TeacherID
JOIN Pupil ON TeacherPupil.PupilID = Pupil.PupilID
WHERE Pupil.სახელი = 'გიორგი';





        /*/
    }
}
