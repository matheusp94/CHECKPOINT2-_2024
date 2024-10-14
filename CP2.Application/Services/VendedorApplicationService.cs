using CP2.Application.Dtos;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using CP2.Domain.Interfaces.Dtos;

namespace CP2.Application.Services
{
    public class VendedorApplicationService : IVendedorApplicationService
    {
        private readonly IVendedorRepository _repository;

        public VendedorApplicationService(IVendedorRepository repository)
        {
            _repository = repository;
        }

        public VendedorEntity? DeletarDadosVendedor(int id)
        {
            return _repository.DeletarDados(id);
        }

        public IEnumerable<VendedorEntity> ObterTodosVendedores()
        {
            return _repository.ObterTodos();
        }

        public VendedorEntity? ObterVendedorPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public VendedorEntity? SalvarDadosVendedor(Domain.Interfaces.VendedorDto dto)
        {
            dto.Validate(); // Validação dos dados do DTO
            var vendedor = new VendedorEntity
            {
                CriadoEm = DateTime.Now // Defina outras propriedades conforme necessário
                // Preencha outras propriedades do vendedor com base no dto
            };

            _repository.Adicionar(vendedor); // Presumindo que você tenha um método de Adicionar no repositório
            return vendedor; // Retorna o vendedor criado
        }

        public VendedorEntity? EditarDadosVendedor(int id, Domain.Interfaces.VendedorDto dto)
        {
            dto.Validate(); // Validação dos dados do DTO
            var vendedorExistente = _repository.ObterPorId(id);

            if (vendedorExistente == null)
                return null; // ou lançar uma exceção, se preferir

            // Aqui você pode atualizar as propriedades do vendedorExistente com base nos dados do DTO
            // Por exemplo:
            // vendedorExistente.Nome = dto.Nome;
            // vendedorExistente.Endereco = dto.Endereco;

            _repository.Atualizar(vendedorExistente); // Presumindo que você tenha um método de Atualizar no repositório
            return vendedorExistente; // Retorna o vendedor atualizado
        }
    }
}
