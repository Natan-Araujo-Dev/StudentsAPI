using Microsoft.AspNetCore.Mvc;
using StudentsAPI.DTOs;
using StudentsAPI.Models.Entities;
using StudentsAPI.Services;
using StudentsAPI.Validation;

namespace StudentsAPI.Controllers
{
    [Route("Students-API/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IVerifyStudent _verifyStudent;
        private readonly IFirstUniqueLetterService _firstUniqueLetterService;

        public StudentsController(IStudentService studentService, IVerifyStudent verifyStudent, IFirstUniqueLetterService firstUniqueLetterService)
        {
            _studentService = studentService;
            _verifyStudent = verifyStudent;
            _firstUniqueLetterService = firstUniqueLetterService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var students = await _studentService.GetAsync();

            if (students == null)
            {
                return NotFound("Nenhum estudante encotrado.");
            }

            return Ok(students);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var students = await _studentService.GetByIdAsync(id);

            if (students == null)
            {
                return NotFound("Nenhum estudante encotrado.");
            }

            return Ok(students);
        }

        [HttpPost]
        public async Task<IActionResult> Post(StudentCreateDTO? studentCreateDTO)
        {
            var validation = _verifyStudent.ValidCreateDTO(studentCreateDTO);

            if (!validation.IsValid)
            {
                return BadRequest(validation.ErrorMessage);
            }

            var newFirstUniqueLetter = _firstUniqueLetterService.GetFirstUniqueLetter(studentCreateDTO);

            var newStudent = new StudentModel
            {
                Name = studentCreateDTO.Name,
                Grade = studentCreateDTO.Grade,
                FirstUniqueLetter = newFirstUniqueLetter
            };

            await _studentService.PostAsync(newStudent);

            return Created("Criado.", newStudent);
        }
    }
}
