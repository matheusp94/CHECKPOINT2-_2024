using CP2.Domain.Entities;
using CP2.Domain.Interfaces.Dtos;

namespace CP2.Domain.Interfaces
{
    public interface IFornecedorApplicationService
    {
        FornecedorEntity? SalvarDadosFornecedor(FornecedorDto dto);
        FornecedorEntity? ObterFornecedorPorId(int id);
        IEnumerable<FornecedorEntity> ObterTodosFornecedores();
        FornecedorEntity? EditarDadosFornecedor(int id, FornecedorDto dto);
        FornecedorEntity? DeletarDadosFornecedor(int id);
    }

    public class FornecedorDto
    {
         public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime CriadoEm { get; set; }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}



