using AutoMapper;
using DeliveryConcept.Api.Entities;
using DeliveryConcept.Api.Source.Domain.BusinessRules;
using MediatR;

namespace DeliveryConcept.Api.Source.Domain.UseCases.Admin.Command.Company.UpdateCompany
{
    public class UpdateCompanyCommand : IRequest<int>
    {
        public int CompanyId { get; set; }
        public UpdateCompanyDto Dto { get; }
        public UpdateCompanyCommand(int companyId, UpdateCompanyDto dto)
        {
            this.CompanyId = companyId;
            this.Dto = dto;
        }
        private class UpdateCompanyCommandHandler : IRequestHandler<UpdateCompanyCommand, int>
        {
            private DataContext context;
            private IMapper mapper;

            public UpdateCompanyCommandHandler(DataContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<int> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
            {
                var company = await context.Companies.FindAsync(request.CompanyId);
                if (company == null)
                {
                    throw new NotFoundException();
                }

                var entity = mapper.Map<Entities.Company>(request.Dto);
                context.Update(entity);
                await context.SaveChangesAsync();

                return company.CompanyId;

            }
        }
    }
}
