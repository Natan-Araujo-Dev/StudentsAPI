using Microsoft.EntityFrameworkCore;
using StudentsAPI.ApiDbContext;
using StudentsAPI.Models.Entities;

namespace StudentsAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentsAPIDbContext _Db;

        public StudentService(IStudentsAPIDbContext Db)
        {
            _Db = Db;
        }

        public async Task<IEnumerable<StudentModel>> GetAsync()
        {
            var students = await _Db.Students.ToListAsync();

            return students;
        }

        public async Task<StudentModel> GetByIdAsync(int id)
        {
            var students = await _Db.Students.FirstOrDefaultAsync(s =>
                s.Id == id
            );

            return students;
        }

        public async Task PostAsync(StudentModel? student)
        {
            await _Db.AddAsync(student);

            await _Db.SaveChangesAsync();
        }
    }
}
