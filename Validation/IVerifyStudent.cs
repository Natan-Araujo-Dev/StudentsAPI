using StudentsAPI.DTOs;
using StudentsAPI.Models.Other;

namespace StudentsAPI.Validation
{
    public interface IVerifyStudent
    {
        public ValidationResultModel ValidCreateDTO(StudentCreateDTO studentCreateDTO);
    }
}
