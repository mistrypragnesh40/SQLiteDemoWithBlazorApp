using SQLite;
using SQLiteDemoWithBlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemoWithBlazorApp.Services
{
    public class StudentService : IStudentService
    {
        private SQLiteAsyncConnection _dbConnection;

        public StudentService()
        {
            SetUpDb();
        }

        private async void SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Student.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<StudentModel>();
            }
        }

        public async Task<int> AddStudent(StudentModel studentModel)
        {
            return await _dbConnection.InsertAsync(studentModel);
        }

        public async Task<int> DeleteStudent(StudentModel studentModel)
        {
            return await _dbConnection.DeleteAsync(studentModel);
        }
        public async Task<int> UpdateStudent(StudentModel studentModel)
        {
            return await _dbConnection.UpdateAsync(studentModel);
        }
        public async Task<List<StudentModel>> GetAllStudent()
        {
            return await _dbConnection.Table<StudentModel>().ToListAsync();
        }

        public async Task<StudentModel> GetStudentByID(int StudentID)
        {
            var student = await _dbConnection.QueryAsync<StudentModel>($"Select * From {nameof(StudentModel)} where StudentID={StudentID} ");
            return student.FirstOrDefault();
        }
    }
}
