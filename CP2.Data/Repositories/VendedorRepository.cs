using CP2.Data.AppData;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CP2.Data.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationContext _context;

        public VendedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        // Obter um vendedor por ID
        public VendedorEntity? ObterPorId(int id)
        {
            return _context.Vendedor.Find(id);
        }

        // Obter todos os vendedores
        public IEnumerable<VendedorEntity> ObterTodos()
        {
            return _context.Vendedor.ToList();
        }

        // Salvar um novo vendedor
        public VendedorEntity SalvarDados(VendedorEntity vendedor)
        {
            _context.Vendedor.Add(vendedor);
            _context.SaveChanges();
            return vendedor;
        }

        // Adicionar um novo vendedor
        public VendedorEntity Adicionar(VendedorEntity vendedor)
        {
            _context.Vendedor.Add(vendedor);
            _context.SaveChanges();
            return vendedor;
        }

        // Atualizar um vendedor existente
        public VendedorEntity? Atualizar(int id, VendedorEntity vendedor)
        {
            var existingVendedor = ObterPorId(id);
            if (existingVendedor == null) return null;

            existingVendedor.Nome = vendedor.Nome;
            existingVendedor.Email = vendedor.Email;
            existingVendedor.Telefone = vendedor.Telefone;
            existingVendedor.DataNascimento = vendedor.DataNascimento;
            existingVendedor.Endereco = vendedor.Endereco;
            existingVendedor.DataContratacao = vendedor.DataContratacao;
            existingVendedor.ComissaoPercentual = vendedor.ComissaoPercentual;
            existingVendedor.MetaMensal = vendedor.MetaMensal;
            existingVendedor.CriadoEm = vendedor.CriadoEm;

            _context.SaveChanges();
            return existingVendedor;
        }

        // Editar um vendedor existente
        public VendedorEntity? EditarDados(int id, VendedorEntity vendedor)
        {
            return Atualizar(id, vendedor); // Reutilizando o método Atualizar
        }

        // Deletar um vendedor
        public VendedorEntity? DeletarDados(int id)
        {
            var vendedor = ObterPorId(id);
            if (vendedor == null) return null;

            _context.Vendedor.Remove(vendedor);
            _context.SaveChanges();
            return vendedor;
        }

        void IVendedorRepository.Atualizar(VendedorEntity vendedorExistente)
        {
            throw new NotImplementedException();
        }
    }
}
