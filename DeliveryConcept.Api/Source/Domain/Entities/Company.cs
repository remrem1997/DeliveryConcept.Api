using System;
using System.Collections.Generic;

namespace DeliveryConcept.Api.Entities
{
    public partial class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; } = null!;
        public string LogoUrl { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string? Description { get; set; }
        public int BranchId { get; set; }
        public bool IsDeleted { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Branch Branch { get; set; } = null!;
    }
}
