using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemoWithBlazorApp.Models
{
    public class StudentModel
    {
        [PrimaryKey,AutoIncrement]
        public int StudentID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
    }
}
