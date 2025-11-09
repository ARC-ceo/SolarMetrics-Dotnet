using System.ComponentModel.DataAnnotations;
using SolarMetrics.Web.Models;

namespace SolarMetrics.Web.ViewModels;

public class ClienteUpdateViewModel: ClienteCreateViewModel
    {
        [Required(ErrorMessage = "O ID é obrigatório")]
        public Guid Id { get; set; }
        
        // [StringLength(200, MinimumLength = 2, ErrorMessage = "Informe um nome válido")]
        //
        // [Required(ErrorMessage = "O nome é obrigatório")]
        // public string Nome { get; set; }
        //
        // [Required(ErrorMessage = "O email é obrigatório")]
        // [EmailAddress(ErrorMessage = "Formato de email inválido")]
        // [StringLength(200, ErrorMessage = "Informe um email válido")]
        // public string Email { get; set; }
        //     
        // [RegularExpression(@"^\d{10,11}$", ErrorMessage = "O telefone deve ter 10 ou 11 dígitos")]
        // public string Telefone { get; set; }
        //
        // [Required(ErrorMessage = "O tipo de usuário é obrigatório")]
        // [StringLength(50, MinimumLength = 3, ErrorMessage = "Informe um tipo de usuário válido")]
        // public string TipoUsuario { get; set; }

        public static Cliente ToEntity(ClienteUpdateViewModel dto)
        {
            return new Cliente
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Email = dto.Email,
                Telefone = dto.Telefone,
                TipoUsuario = dto.TipoUsuario
            };
        }
        
        public static ClienteUpdateViewModel ToResponse(Cliente cliente)
        {
            return new ClienteUpdateViewModel
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Email = cliente.Email,
                Telefone = cliente.Telefone,
                TipoUsuario = cliente.TipoUsuario
            };
        }
    }