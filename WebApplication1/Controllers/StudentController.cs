using Microsoft.AspNetCore.Mvc;
using WebApplication1.BusinessLayer;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentController : Controller
    {
        private readonly IUpdateStudentDetails _updateStudentDetails;

        public StudentController(IUpdateStudentDetails updateStudentDetails)
        {
            _updateStudentDetails = updateStudentDetails;
        }

        [HttpPost]
        [ActionName("UpdateStudentDetails")]
        public async Task<string> UpdateStudentDetails(Studentdetails studentdetails)
        {
            string response = await _updateStudentDetails.updatestudentdetails(studentdetails);
            return response;
        }

        [HttpGet]
        [ActionName("FetchStudentName")]
        public async Task<string> FetchStudentName(int rollNumber, int classroom)
        {
            return await _updateStudentDetails.FetchStudentName(rollNumber, classroom);
        }

        [HttpGet]
        [ActionName("FetchStudentNamebymf")]
        public async Task<string> FetchStudentNamebymf(string FatherName, String MotherName) { 

            return await _updateStudentDetails.FetchStudentNamebymf(FatherName, MotherName);
        }

        [HttpGet]
        [ActionName("FetchStudentAdress")]
        public async Task<string> FetchStudentAdress(int clasroom) { 
            return await _updateStudentDetails.FetchStudentAdress(clasroom);
        }

        [HttpPost]
        [ActionName("UpdateEmployeeDetails")]
        public async Task<string> UpdateEmployeeDetails(EmployeeDetails employeeDetails)
        {
            string response = await _updateStudentDetails.UpdateEmployeeDetails(employeeDetails);
            return response;
        }
       


    }
}