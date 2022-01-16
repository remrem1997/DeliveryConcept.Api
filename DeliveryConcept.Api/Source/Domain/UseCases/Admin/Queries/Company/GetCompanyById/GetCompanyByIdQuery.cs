using AutoMapper;
using DeliveryConcept.Api.Entities;
using DeliveryConcept.Api.Source.Domain.BusinessRules;
using MediatR;

namespace DeliveryConcept.Api.Source.Domain.UseCases.Admin.Queries.Company.GetCompanyById
{
    public class GetCompanyByIdQuery : IRequest<GetCompanyByIdResult>
    {
        public int Id { get; }
        public GetCompanyByIdQuery(int id) => this.Id = id;
        private class GetCompanyByIdQueryHandler : IRequestHandler<GetCompanyByIdQuery, GetCompanyByIdResult>
        {
            private DataContext context;
            private IMapper mapper;

            public GetCompanyByIdQueryHandler(DataContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }
            public async Task<GetCompanyByIdResult> Handle(GetCompanyByIdQuery request, CancellationToken cancellationToken)
            {
                var company = await context.Companies.FindAsync(request.Id);
                if (company == null)
                {
                    throw new NotFoundException();
                }
                return mapper.Map<GetCompanyByIdResult>(company);
            }
        }
    }
}
