using System.ComponentModel.DataAnnotations;

namespace API.Data.DTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = @"O campo ""Usuário"" é obrigatório")]
        public string Username { get; set; }

        [Required(ErrorMessage = @"O campo ""Senha"" é obrigatório")]
        public string Password { get; set; }
    }
}
