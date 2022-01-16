using DeliveryConcept.Api.Entities;
using DeliveryConcept.Api.Source.Domain.BusinessRules;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DeliveryConcept.Api.Source.Domain.UseCases.Admin.Command.Company.DeleteCompany
{
    public class DeleteCompanyCommand : IRequest<int>
    {
        public int CompanyId { get; set; }
        public DeleteCompanyCommand(int companyId) => this.CompanyId = companyId;

        private class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand, int>
        {
            private readonly DataContext context;
            public DeleteCompanyCommandHandler(DataContext context) => this.context = context;

            public async Task<int> Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
            {
                var company = await context.Companies.SingleOrDefaultAsync(o => o.CompanyId == request.CompanyId);
                if (company == null)
                {
                    throw new NotFoundException();
                }

                company.IsDeleted = true;
                context.Companies.Update(company);
                await context.SaveChangesAsync();

                return company.CompanyId;
            }
        }
    }
}
