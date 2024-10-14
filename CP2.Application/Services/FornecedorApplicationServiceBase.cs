using CP2.Domain.Entities;
using CP2.Application.Dtos; // Corrigindo a referência para o namespace correto do FornecedorDto
using CP2.Domain.Interfaces; // Supondo que o repositório esteja aqui

namespace CP2.Application.Services
{
    public class FornecedorApplicationServiceBase
    {
        private readonly IFornecedorRepository _repository; // Certifique-se de que o repositório está injetado

        public FornecedorApplicationServiceBase(IFornecedorRepository repository)
        {
            _repository = repository;
        }

        public FornecedorEntity? SalvarDadosFornecedor(Domain.Interfaces.FornecedorDto dto) // Usando o DTO correto
        {
            dto.Validate(); // Validação dos dados do DTO

            var fornecedor = new FornecedorEntity
            {
                CriadoEm = DateTime.Now,
                // Defina outras propriedades conforme necessário, ex:
                Nome = dto.Nome,
                CNPJ = dto.CNPJ,
                Endereco = dto.Endereco,
                Telefone = dto.Telefone,
                Email = dto.Email
            };

            _repository.Adicionar(fornecedor); // Adiciona o fornecedor ao repositório
            return fornecedor; // Retorna o fornecedor criado
        }
    }
}
