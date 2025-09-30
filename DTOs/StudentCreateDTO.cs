using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsAPI.DTOs
{
    public class StudentCreateDTO
    {
        [Required]
        [StringLength(70)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "decimal(5,2)")]
        public decimal Grade { get; set; }
    }
}
