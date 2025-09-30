using StudentsAPI.DTOs;
using StudentsAPI.Models.Other;

namespace StudentsAPI.Validation
{
    public class VerifyStudent : IVerifyStudent
    {
        public ValidationResultModel ValidCreateDTO(StudentCreateDTO? studentCreateDTO)
        {
            // checa se o objeto está nulo
            if (studentCreateDTO == null)
            {
                return new ValidationResultModel {
                    IsValid = false,
                    ErrorMessage = "Objeto nulo."
                };
            }
            // checa se o nome está nulo ou vazio
            else if (string.IsNullOrEmpty(studentCreateDTO.Name)
            && studentCreateDTO.Name.All(c => c == ' '))
            {
                return new ValidationResultModel {
                    IsValid = false,
                    ErrorMessage = "Nome inválido."
                };
            }
            // checa se a nota está entre 0 e 100
            else if (studentCreateDTO.Grade < 0 || studentCreateDTO.Grade > 100)
            {
                return new ValidationResultModel { 
                    IsValid = false,
                    ErrorMessage = "Nota fora do intervalo (0-100)."
                };
            }

            return new ValidationResultModel { 
                IsValid = true
            };
        }
    }
}
