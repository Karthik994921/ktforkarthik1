using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DataLayer
{
    public class Studentdata : IStudentdata
    {
        private readonly StudentDbContext _dbContext;
        public Studentdata(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<string> updatestudentdetails(Studentdetails studentdetails)
        {
            try
            {
                var getValue = await _dbContext.students
                .Where(x => x.rollno == studentdetails.rollno && x.classroom == studentdetails.classroom)
                .FirstOrDefaultAsync();
                if (getValue != null)
                {
                    getValue.rollno = studentdetails.rollno;
                    getValue.studentname = studentdetails.studentname;
                    getValue.fathername = studentdetails.fathername;
                    getValue.mothername = studentdetails.mothername;
                    getValue.address = studentdetails.address;
                    getValue.classroom = studentdetails.classroom;
                    var res = await _dbContext.SaveChangesAsync();
                    return "Details Updated";
                }
                else
                {
                    await _dbContext.students.AddAsync(new Student
                    {
                        rollno = studentdetails.rollno,
                        studentname = studentdetails.studentname,
                        fathername = studentdetails.fathername,
                        mothername = studentdetails.mothername,
                        address = studentdetails.address,
                        classroom = studentdetails.classroom
                    });
                    var res = await _dbContext.SaveChangesAsync();
                    return "Details Updated";
                }
            }
            catch (Exception ex)
            {
                return "An exception ocurred while updating the data: " + ex.Message;
            }
        }

        public async Task<string> FetchStudentName(int rollNumber, int classroom)
        {
            var student = await _dbContext.students
                .Where(x => x.rollno == rollNumber && x.classroom == classroom)
                .FirstOrDefaultAsync();

            return student?.studentname ?? "Student not found";
        }

        public async Task<string> FetchStudentNamebymf(string FatherName, string MotherName)
        {

            var stu = await _dbContext.students
            .Where(x => x.fathername == FatherName && x.mothername == MotherName)
            .FirstOrDefaultAsync();
            return stu?.studentname ?? "student not found";
        }

        public async Task<string> FetchStudentAdress(int classroom)
        {

            var adress = await _dbContext.students
            .Where(x => x.classroom == classroom)
            .FirstOrDefaultAsync();
            return adress?.address ?? "adress not found";
        }

        public async Task<string> UpdateEmployeeDetails(EmployeeDetails employeeDetails)
        {
            try
            {
                var existingEmployee = await _dbContext.Employees
                    .Where(x => x.Employeeid == employeeDetails.Employeeid)
                    .FirstOrDefaultAsync();

                if (existingEmployee != null)
                {
                    existingEmployee.Employeename = employeeDetails.Employeename;
                    existingEmployee.Department = employeeDetails.Department;
                    existingEmployee.Salary = employeeDetails.Salary;
                    await _dbContext.SaveChangesAsync();
                    return "Employee details updated.";
                }
                else
                {
                    await _dbContext.Employees.AddAsync(employeeDetails);
                    await _dbContext.SaveChangesAsync();
                    return "Employee details added.";
                }
            }
            catch (Exception ex)
            {
                return "An exception occurred while updating the employee data: " + ex.Message;
            }
        }

        
    }
}


