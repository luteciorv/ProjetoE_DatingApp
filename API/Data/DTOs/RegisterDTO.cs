using System.ComponentModel.DataAnnotations;

namespace API.Data.DTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "O campo 'Usuário' é obrigatório")]
        public string Username { get; set; }

        [Required(ErrorMessage = "O campo 'Senha' é obrigatório")]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
    }
}
