using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    /*
        tinfo200:[2021-03-10-dattr98-dykstra1]
        The Course entity.
        Contains foreign keys.
     */
    public class Course
    {
        // tinfo200:[2021-03-10-dattr98-dykstra1] - This method set CourseID not being generate by the database
        // tinfo200:[2021-03-10-dattr98-dykstra1] - CourseID is a foreign key and a relational entity to Enrollment class
                                                 // which means CourseID values prefers to the unique values on the primary key( Enrollment class)
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        //tinfo200:[2021-03-10-dattr98-dykstra1] - Definition to Foreign Key that corresponds with Enrolllment class
        public int CourseID { get; set; }
        //tinfo200:[2021-03-10-dattr98-dykstra1] - Definition to Primary Key that corresponds with Enrolllment class
        //tinfo200:[2021-03-10-dattr98-dykstra1] - Course titles exist primary in the Course class.
        public string Title { get; set; }
        //tinfo200:[2021-03-10-dattr98-dykstra1] - Definition to Primary Key that corresponds with Enrolllment class
        //tinfo200:[2021-03-10-dattr98-dykstra1] - Credits assocaite with CourseID and its titles.
        public int Credits { get; set; }
        // tinfo200:[2021-03-10-dattr98-dykstra1] - Definition to Foreign Key that corresponds with Student class
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
