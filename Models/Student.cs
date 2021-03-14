using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    /* 
        tinfo200:[2021-03-10-dattr98-dykstra1]
        Student entity
        Student class has a one-to-many relationship to Enrollment class as one student can enroll to several classes.
        Get/set method for each properties and navigation properties based on the data model for Student.
        Create a new class names Enrollment after finish adding codes.
     */
    public class Student
    {


        //tinfo200:[2021-03-10-dattr98-dykstra1] - Follow the instruction data model, ID is one of the primary properites for Student class.
        public int ID { get; set; }

        //tinfo200:[2021-03-10-dattr98-dykstra1]- LastName is one of the primary properites for Student class.
        public string LastName { get; set; }

        //tinfo200:[2021-03-10-dattr98-dykstra1] - FirstMidName is one of the primary properites for Student class.
        public string FirstMidName { get; set; }

        //tinfo200:[2021-03-10-dattr98-dykstra1] - EnrollmentDate is one of the primary properites for Student class.
        public DateTime EnrollmentDate { get; set; }

        //tinfo200:[2021-03-10-dattr98-dykstra1] - A part of navigation property to get element from Enrollment class
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
