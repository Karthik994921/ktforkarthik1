namespace WebApplication1.Models
{
    public class Student
    {
        public int? rollno { get; set; }
        public string studentname { get; set; }
        public string fathername { get; set; }
        public string mothername { get; set; }
        public int? classroom { get; set; }
        public string address { get; set; }
        
    }
    public class Employee
    {

        public int? Employeeid { get; set; }
        public string Employeename { get; set; }
        public string Department { get; set; }

        public decimal? Salary { get; set; }


    }

}
