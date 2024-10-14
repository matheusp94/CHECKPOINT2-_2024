using CP2.Domain.Entities;

namespace CP2.Domain.Interfaces
{
    public interface IFornecedorRepository
    {
        FornecedorEntity? ObterPorId(int id);
        IEnumerable<FornecedorEntity> ObterTodos();
        FornecedorEntity SalvarDados(FornecedorEntity fornecedor);
        FornecedorEntity? EditarDados(int id, FornecedorEntity fornecedor);
        FornecedorEntity? DeletarDados(int id);

        // Novos métodos
        FornecedorEntity Adicionar(FornecedorEntity fornecedor);
        FornecedorEntity? Atualizar(int id, FornecedorEntity fornecedor);
        void Atualizar(FornecedorEntity fornecedorExistente);
    }
}
