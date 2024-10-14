using CP2.Data.AppData;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CP2.Data.Repositories
{
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly ApplicationContext _context;

        public FornecedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        // Obter um fornecedor por ID
        public FornecedorEntity? ObterPorId(int id)
        {
            return _context.Fornecedor.Find(id);
        }

        // Obter todos os fornecedores
        public IEnumerable<FornecedorEntity> ObterTodos()
        {
            return _context.Fornecedor.ToList();
        }

        // Salvar um novo fornecedor
        public FornecedorEntity SalvarDados(FornecedorEntity fornecedor)
        {
            _context.Fornecedor.Add(fornecedor);
            _context.SaveChanges();
            return fornecedor;
        }

        // Adicionar um novo fornecedor
        public FornecedorEntity Adicionar(FornecedorEntity fornecedor)
        {
            _context.Fornecedor.Add(fornecedor);
            _context.SaveChanges();
            return fornecedor;
        }

        // Atualizar um fornecedor existente
        public FornecedorEntity? Atualizar(int id, FornecedorEntity fornecedor)
        {
            var existingFornecedor = ObterPorId(id);
            if (existingFornecedor == null) return null;

            existingFornecedor.Nome = fornecedor.Nome;
            existingFornecedor.CNPJ = fornecedor.CNPJ;
            existingFornecedor.Endereco = fornecedor.Endereco;
            existingFornecedor.Telefone = fornecedor.Telefone;
            existingFornecedor.Email = fornecedor.Email;
            existingFornecedor.CriadoEm = fornecedor.CriadoEm;

            _context.SaveChanges();
            return existingFornecedor;
        }

        // Editar um fornecedor existente
        public FornecedorEntity? EditarDados(int id, FornecedorEntity fornecedor)
        {
            return Atualizar(id, fornecedor); // Você pode reutilizar o método Atualizar aqui
        }

        // Deletar um fornecedor
        public FornecedorEntity? DeletarDados(int id)
        {
            var fornecedor = ObterPorId(id);
            if (fornecedor == null) return null;

            _context.Fornecedor.Remove(fornecedor);
            _context.SaveChanges();
            return fornecedor;
        }

        public void Atualizar(FornecedorEntity fornecedorExistente)
        {
            throw new NotImplementedException();
        }
    }
}

