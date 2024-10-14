using CP2.Domain.Entities;
using CP2.Domain.Interfaces.Dtos;


namespace CP2.Domain.Interfaces
{
    public interface IVendedorApplicationService
    {
        VendedorEntity? SalvarDadosVendedor(VendedorDto dto);
        VendedorEntity? ObterVendedorPorId(int id);
        IEnumerable<VendedorEntity> ObterTodosVendedores();
        VendedorEntity? EditarDadosVendedor(int id, VendedorDto dto);
        VendedorEntity? DeletarDadosVendedor(int id);
    }

    public class VendedorDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public DateTime DataContratacao { get; set; }
        public decimal ComissaoPercentual { get; set; }
        public decimal MetaMensal { get; set; }
        public DateTime CriadoEm { get; set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
