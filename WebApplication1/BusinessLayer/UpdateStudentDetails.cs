using WebApplication1.DataLayer;
using WebApplication1.Models;

namespace WebApplication1.BusinessLayer
{
    public class UpdateStudentDetails : IUpdateStudentDetails
    {
        private readonly IStudentdata _studentdata;

        public UpdateStudentDetails(IStudentdata studentdata)
        {
            _studentdata = studentdata;
        }

        public async Task<string> updatestudentdetails(Studentdetails studentdetails)
        {
            string response = await _studentdata.updatestudentdetails(studentdetails);
            return response;
        }

        public async Task<string> FetchStudentName(int rollNumber, int classroom)
        {
            return await _studentdata.FetchStudentName(rollNumber, classroom);
        }

        public async Task<string> FetchStudentNamebymf(string FatherName, string MotherName)
        {

            return await _studentdata.FetchStudentNamebymf(FatherName, MotherName);
        }

        public async Task<string> FetchStudentAdress(int clasroom) { 

            return await _studentdata.FetchStudentAdress(clasroom);

        }

        public async Task<string> UpdateEmployeeDetails(EmployeeDetails employeeDetails)
        {
            string response = await _studentdata.UpdateEmployeeDetails(employeeDetails);
            return response;
        }

        
        }

    }
        
    
