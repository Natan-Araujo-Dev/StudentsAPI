using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsAPI.Models.Entities
{
    public class StudentModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(70)]
        public string Name { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Grade { get; set; }

        public char FirstUniqueLetter { get; set; }
    }
}
