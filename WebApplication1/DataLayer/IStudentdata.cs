using WebApplication1.Models;

namespace WebApplication1.DataLayer
{
    public interface IStudentdata
    {
        Task<string> updatestudentdetails(Studentdetails studentdetails);

        


        Task<string> FetchStudentName (int rollNumber, int classroom);

        Task<string> FetchStudentNamebymf(string FatherName, string MotherName);

        Task<string> FetchStudentAdress (int clasroom);
        Task<string> UpdateEmployeeDetails(EmployeeDetails employeeDetails);

        Task<string> Fetchemployeename(string Department);







    }
}
