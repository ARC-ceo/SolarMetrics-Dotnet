using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using SolarMetrics.Web.Models;

namespace SolarMetrics.Web.ViewModels
{
    public class ClienteCreateViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Informe um nome válido")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        [StringLength(200, ErrorMessage = "Informe um email válido")]
        public string Email { get; set; }
        
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "O telefone deve ter 10 ou 11 dígitos")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "O tipo do usuario é obrigatório")]
        public string TipoUsuario { get; set; }

        public static Cliente ToEntity(ClienteCreateViewModel createViewModel)
        {
            return new Cliente
            {
                Nome = createViewModel.Nome,
                Email = createViewModel.Email,
                Telefone = createViewModel.Telefone,
                TipoUsuario = createViewModel.TipoUsuario
            };
        }
    }
}