using StudentsAPI.DTOs;

namespace StudentsAPI.Services
{
    public interface IFirstUniqueLetterService
    {
        public char GetFirstUniqueLetter(StudentCreateDTO studentCreateDTO);
    }
}
