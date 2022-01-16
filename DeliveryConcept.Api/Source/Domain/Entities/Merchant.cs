using System;
using System.Collections.Generic;

namespace DeliveryConcept.Api.Entities
{
    public partial class Merchant
    {
        public long MerchantId { get; set; }
        public string Name { get; set; } = null!;
        public int MerchantStatusId { get; set; }
        public string Address { get; set; } = null!;
        public string? Logo { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual MerchantStatu MerchantStatus { get; set; } = null!;
    }
}
