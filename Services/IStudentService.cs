using StudentsAPI.Models.Entities;

namespace StudentsAPI.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentModel>> GetAsync();

        Task<StudentModel> GetByIdAsync(int id);

        Task PostAsync(StudentModel studentCreateDTO);

    }
}
