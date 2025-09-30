using StudentsAPI.DTOs;

namespace StudentsAPI.Services
{
    public class FirstUniqueLetterService : IFirstUniqueLetterService
    {
        public char GetFirstUniqueLetter(StudentCreateDTO studentCreateDTO)
        {
            var name = studentCreateDTO.Name;

            if (string.IsNullOrEmpty(name))
            {
                return '-';
            }

            var counts = new Dictionary<char, int>();

            // Conta (case-insensitive). Ignora espaços.
            foreach (var ch in name)
            {
                // pula se pra próxima letra se for um espaço
                if (char.IsWhiteSpace(ch))
                    continue;
                
                var c = char.ToLowerInvariant(ch);

                counts[c] = counts.TryGetValue(c, out var v) ? v + 1 : 1;
            }

            // Encontra a primeira com contagem == 1
            foreach (var ch in name)
            {
                if (char.IsWhiteSpace(ch))
                    continue;

                var c = char.ToLowerInvariant(ch);

                if (counts[c] == 1)
                    return c;
            }

            return '-';
        }
    }
}
