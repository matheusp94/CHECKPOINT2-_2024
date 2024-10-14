using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CP2.Domain.Entities
{
    [Table("Fornecedores")] // Defina o nome da tabela no banco de dados
    public class FornecedorEntity
    {
        [Key]
        public int Id { get; set; } // Identificador único do fornecedor

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; } = string.Empty; // Nome do fornecedor

        [Required]
        [MaxLength(14)]
        public string CNPJ { get; set; } = string.Empty; // CNPJ do fornecedor

        [Required]
        [MaxLength(200)]
        public string Endereco { get; set; } = string.Empty; // Endereço do fornecedor

        [MaxLength(15)]
        public string Telefone { get; set; } = string.Empty; // Telefone de contato do fornecedor

        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty; // Email do fornecedor

        public DateTime CriadoEm { get; set; } = DateTime.UtcNow; // Data de criação do registro
    }
}
