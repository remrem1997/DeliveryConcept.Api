namespace DeliveryConcept.Api.Source.Domain.UseCases.Admin.Command.Company.UpdateCompany
{
    public class UpdateCompanyDto
    {
        public string Name { get; set; } = null!;
        public string LogoUrl { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Description { get; set; }
        public int BranchId { get; set; }
    }
}
