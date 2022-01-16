using AutoMapper;

namespace DeliveryConcept.Api.Source.Domain.UseCases.Admin.Queries.Company.GetCompanyById
{
    public class GetCompanyByIdMapper : Profile
    {
        public GetCompanyByIdMapper()
        {
            CreateMap<Entities.Company, GetCompanyByIdResult>();
            CreateMap<GetCompanyByIdResult, Entities.Company>();
        }
    }
}
