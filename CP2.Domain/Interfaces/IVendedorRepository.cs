using CP2.Domain.Entities;

namespace CP2.Domain.Interfaces
{
    public interface IVendedorRepository
    {
        VendedorEntity? ObterPorId(int id);
        IEnumerable<VendedorEntity> ObterTodos();
        VendedorEntity SalvarDados(VendedorEntity vendedor);
        VendedorEntity? EditarDados(int id, VendedorEntity vendedor);
        VendedorEntity? DeletarDados(int id);

        // Novos métodos
        VendedorEntity Adicionar(VendedorEntity vendedor);
        VendedorEntity? Atualizar(int id, VendedorEntity vendedor);
        void Atualizar(VendedorEntity vendedorExistente);
    }
}
