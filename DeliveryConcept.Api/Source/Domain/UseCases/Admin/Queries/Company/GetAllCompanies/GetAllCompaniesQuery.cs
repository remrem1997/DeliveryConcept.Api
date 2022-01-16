using AutoMapper;
using DeliveryConcept.Api.Entities;
using DeliveryConcept.Api.Source.Domain.BusinessRules;
using DeliveryConcept.Api.Source.Infrastracture.Helpers.Paging;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DeliveryConcept.Api.Source.Domain.UseCases.Admin.Queries.Company.GetAllCompanies
{
    public class GetAllCompaniesQuery : IRequest<List<GetAllCompaniesResult>>
    {
        public CompanyParameters CompanyParameters { get; set; }
        public GetAllCompaniesQuery(CompanyParameters companyParameters) => this.CompanyParameters = companyParameters;
        private class GetAllCompaniesQueryHandler : IRequestHandler<GetAllCompaniesQuery, List<GetAllCompaniesResult>>
        {
            private DataContext context;
            private readonly IMapper mapper;
            public GetAllCompaniesQueryHandler(DataContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<List<GetAllCompaniesResult>> Handle(GetAllCompaniesQuery request, CancellationToken cancellationToken)
            {
                var companies = await context.Companies.ToListAsync();
                if (companies == null)
                {
                    throw new NotFoundException();
                }

                return mapper.Map<List<GetAllCompaniesResult>>(companies);

            }
        }
    }
}
