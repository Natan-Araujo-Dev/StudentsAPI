namespace StudentsAPI.DTOs
{
    public class StudentGetDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Grade { get; set; }

        public char FirstUniqueLetter { get; set; }
    }
}
