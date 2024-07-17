﻿using WebApplication1.Models;

namespace WebApplication1.BusinessLayer
{
    public interface IUpdateStudentDetails
    {
        Task<string> updatestudentdetails(Studentdetails studentdetails);
        Task<string> FetchStudentName(int rollNumber, int classroom);
    }
}
