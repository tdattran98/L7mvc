using ContosoUniversity.Models;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    ///tinfo200:[2021-03-10-dattr98-dykstra1] - Adding data to the empty database 
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            //tinfo200:[2021-03-10-dattr98-dykstra1] - Innitialize the student database input with several properties, First Name, Last Name, and Enrollment Date.
            //tinfo200:[2021-03-10-dattr98-dykstra1] - Create a student array list
            var students = new Student[]
            {
            new Student{FirstMidName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            //tinfo200:[2021-03-10-dattr98-dykstra1] - create a foreach loop that add all the students to the database and commite the changes.
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            //tinfo200:[2021-03-10-dattr98-dykstra1] - Commite all the changes to the database.
            //tinfo200:[2021-03-11-dattr98-dykstra2] - connect to the dependency injection from the main program.
            context.SaveChanges();

            //tinfo200:[2021-03-10-dattr98-dykstra1] - Innitialize the school course database input with several properties, Course ID, Title, and Number of credits.
            //tinfo200:[2021-03-10-dattr98-dykstra1] - Create a course array list for the school
            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3},
            new Course{CourseID=4022,Title="Microeconomics",Credits=3},
            new Course{CourseID=4041,Title="Macroeconomics",Credits=3},
            new Course{CourseID=1045,Title="Calculus",Credits=4},
            new Course{CourseID=3141,Title="Trigonometry",Credits=4},
            new Course{CourseID=2021,Title="Composition",Credits=3},
            new Course{CourseID=2042,Title="Literature",Credits=4}
            };
            //tinfo200:[2021-03-10-dattr98-dykstra1] - create a foreach loop that add all the course info to the database.
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            //tinfo200:[2021-03-10-dattr98-dykstra1] - Commite all the changes to the database.
            //tinfo200:[2021-03-11-dattr98-dykstra2] - connect to the dependency injection from the main program.
            context.SaveChanges();

            //tinfo200:[2021-03-10-dattr98-dykstra1] - Innitialize the student enrollment info to database input with several properties, Student ID, Course ID, and Grade.
            //tinfo200:[2021-03-10-dattr98-dykstra1] - Create a array list for new students.
            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            //tinfo200:[2021-03-10-dattr98-dykstra1] - create a foreach loop that add all the new enrollment students info to the database
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            //tinfo200:[2021-03-10-dattr98-dykstra1] - Commite all the changes to the database.
            //tinfo200:[2021-03-11-dattr98-dykstra2] - Connect to the dependency injection from the main program.
            context.SaveChanges();
        }
    }
}