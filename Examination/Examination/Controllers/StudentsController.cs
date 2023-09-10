using Dapper;
using Examination.Models.Database;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Examination.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IConfiguration _configuration;

        public StudentsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            var students = await connection.QueryAsync<Student>("select * from student");

            return View(students);
        }
    }
}
