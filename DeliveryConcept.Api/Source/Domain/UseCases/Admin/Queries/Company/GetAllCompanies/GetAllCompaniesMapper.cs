using AutoMapper;

namespace DeliveryConcept.Api.Source.Domain.UseCases.Admin.Queries.Company.GetAllCompanies
{
    public class GetAllCompaniesMapper : Profile
    {
        public GetAllCompaniesMapper()
        {
            CreateMap<Entities.Company, GetAllCompaniesResult>();
            CreateMap<GetAllCompaniesResult, Entities.Company>();
        }
    }
}
