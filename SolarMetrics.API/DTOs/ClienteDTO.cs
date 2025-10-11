using System.ComponentModel.DataAnnotations;
using SolarMetrics.Infrastructure.Persistence.Entitites;

namespace SolarMetrics.DTOs
{
    public class ClienteDTO
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Informe um nome válido")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        [StringLength(200, ErrorMessage = "Informe um email válido")]
        public string Email { get; set; }
        
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "O telefone deve ter 10 ou 11 dígitos")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O tipo de usuário é obrigatório")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Informe um tipo de usuário válido")]
        public string TipoUsuario { get; set; }

        public static Cliente ToEntity(ClienteDTO dto)
        {
            return new Cliente
            {
                Nome = dto.Nome,
                Email = dto.Email,
                Telefone = dto.Telefone,
                TipoUsuario = dto.TipoUsuario
            };
        }
    }
}