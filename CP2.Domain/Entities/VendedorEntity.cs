using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Domain.Entities
{
    [Table("Vendedores")] // Defina o nome da tabela no banco de dados
    public class VendedorEntity
    {
        [Key]
        public int Id { get; set; } // Identificador único do vendedor

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty; // Nome do vendedor

        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty; // Email do vendedor

        [MaxLength(15)]
        public string Telefone { get; set; } = string.Empty; // Telefone de contato do vendedor

        public DateTime DataNascimento { get; set; } // Data de nascimento do vendedor

        [MaxLength(200)]
        public string Endereco { get; set; } = string.Empty; // Endereço do vendedor

        public DateTime DataContratacao { get; set; } // Data de contratação do vendedor

        [Range(0, 100)]
        public decimal ComissaoPercentual { get; set; } // Percentual de comissão do vendedor

        [Range(0, double.MaxValue)]
        public decimal MetaMensal { get; set; } // Meta mensal do vendedor

        public DateTime CriadoEm { get; set; } = DateTime.UtcNow; // Data de criação do registro
    }
}
