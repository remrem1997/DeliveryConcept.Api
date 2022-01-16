using AutoMapper;

namespace DeliveryConcept.Api.Source.Domain.UseCases.Admin.Command.Company.UpdateCompany
{
    public class UpdateCompanyMapper : Profile
    {
        public UpdateCompanyMapper()
        {
            CreateMap<Entities.Company, UpdateCompanyDto>();
            CreateMap<UpdateCompanyDto, Entities.Company>();
        }
    }
}
