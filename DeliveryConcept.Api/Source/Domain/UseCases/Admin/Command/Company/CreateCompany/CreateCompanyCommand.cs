using AutoMapper;
using DeliveryConcept.Api.Entities;
using MediatR;

namespace DeliveryConcept.Api.Source.Domain.UseCases.Admin.Command.Company.CreateCompany
{
    public class CreateCompanyCommand : IRequest<int>
    {
        public CreateCompanyDto Dto { get; }
        public CreateCompanyCommand(CreateCompanyDto dto) => this.Dto = dto;    
        private class CreateCompanyCommandHandler : IRequestHandler<CreateCompanyCommand, int>
        {
            private DataContext context;
            private IMapper mapper;

            public CreateCompanyCommandHandler(DataContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<int> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
            {
                var company = mapper.Map<Entities.Company>(request.Dto);

                context.Companies.Add(company);
                await context.SaveChangesAsync();

                return company.CompanyId;
            }
        }
    }
}
