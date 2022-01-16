using AutoMapper;

namespace DeliveryConcept.Api.Source.Domain.UseCases.Admin.Command.Company.CreateCompany
{
    public class CreateCompanyMapper : Profile
    {
        public CreateCompanyMapper()
        {
            CreateMap<Entities.Company, CreateCompanyDto>();
            CreateMap<CreateCompanyDto, Entities.Company>();
        }
    }
}
