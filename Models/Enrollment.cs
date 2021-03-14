namespace ContosoUniversity.Models
{
    /* 
       tinfo200:[2021-03-10-dattr98-dykstra1]
       Enrollment entity.
       Contains the primary key of the data model.
       A method to set the definition for Grade vary from A to F 
       Get/set method for each properties and navigation properties based on the data model for Enrollment.
       When the end of quarter/semester, the enrollment will have to concluse by giving out grade to each student .
       After finish coding codes to Enrollments, create a class named Course.
     */
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        //tinfo200:[2021-03-10-dattr98-dykstra1] - Definition to Primary Key to EnrollmentID property
        public int EnrollmentID { get; set; }
        //tinfo200:[2021-03-10-dattr98-dykstra1] - Definition to Foreign Key that correspond with Course class
        public int CourseID { get; set; }
        //tinfo200:[2021-03-10-dattr98-dykstra1] - Instead name the property as ID like Student class, name StudentID to differentiate with CourseID
        //tinfo200:[2021-03-10-dattr98-dykstra1] - Definition to Foreign Key that correspond with Student class
        public int StudentID { get; set; }
        //tinfo200:[2021-03-10-dattr98-dykstra1] - ? after means the value can be set to null
        //tinfo200:[2021-03-10-dattr98-dykstra1] - Is a Primary Key because it's not sharing property with different class.
        public Grade? Grade { get; set; }

        //tinfo200:[2021-03-10-dattr98-dykstra1] - Navigate to Course class value.
        //tinfo200:[2021-03-10-dattr98-dykstra1] - Method navigates the primary key in Student class and intetpret it as a foreign key for this class.
        public Course Course { get; set; }
        //tinfo200:[2021-03-10-dattr98-dykstra1] - Nagivate to Student class values
        //tinfo200:[2021-03-10-dattr98-dykstra1] - Method navigates the primary key in Student class and intetpret it as a foreign key for this class.
        public Student Student { get; set; }
    }
}