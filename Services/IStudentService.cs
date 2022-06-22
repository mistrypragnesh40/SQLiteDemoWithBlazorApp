using SQLiteDemoWithBlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemoWithBlazorApp.Services
{
    public interface IStudentService
    {
        Task<List<StudentModel>> GetAllStudent();
        Task<StudentModel> GetStudentByID(int StudentID);
        Task<int> AddStudent(StudentModel studentModel);
        Task<int> UpdateStudent(StudentModel studentModel);
        Task<int> DeleteStudent(StudentModel studentModel);
    }
}
