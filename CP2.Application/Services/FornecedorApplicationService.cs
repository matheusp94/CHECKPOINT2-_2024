using CP2.Application.Dtos;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using CP2.Domain.Interfaces.Dtos;

namespace CP2.Application.Services
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorApplicationService(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public FornecedorEntity? DeletarDadosFornecedor(int id)
        {
            return _repository.DeletarDados(id);
        }

        public FornecedorEntity? ObterFornecedorPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public FornecedorEntity? SalvarDadosFornecedor(Domain.Interfaces.FornecedorDto dto)
        {
            dto.Validate(); // Validação dos dados do DTO
            var fornecedor = new FornecedorEntity
            {
                CriadoEm = DateTime.Now // Defina outras propriedades conforme necessário
                // Preencha outras propriedades do fornecedor com base no dto
            };

            _repository.Adicionar(fornecedor); // Presumindo que você tenha um método de Adicionar no repositório
            return fornecedor; // Retorna o fornecedor criado
        }

        public FornecedorEntity? EditarDadosFornecedor(int id, Domain.Interfaces.FornecedorDto dto)
        {
            dto.Validate(); // Validação dos dados do DTO
            var fornecedorExistente = _repository.ObterPorId(id);

            if (fornecedorExistente == null)
                return null; // ou lançar uma exceção, se preferir

            // Aqui você pode atualizar as propriedades do fornecedorExistente com base nos dados do DTO
            // Por exemplo:
            // fornecedorExistente.Nome = dto.Nome;
            // fornecedorExistente.Endereco = dto.Endereco;

            _repository.Atualizar(fornecedorExistente); // Presumindo que você tenha um método de Atualizar no repositório
            return fornecedorExistente; // Retorna o fornecedor atualizado
        }

        public FornecedorEntity? SalvarDadosFornecedor(Domain.Interfaces.FornecedorDto dto) => throw new NotImplementedException();

        public IEnumerable<FornecedorEntity> ObterTodosFornecedores()
        {
            throw new NotImplementedException();
        }
    }
}
