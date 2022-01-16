using System;
using System.Collections.Generic;

namespace DeliveryConcept.Api.Entities
{
    public partial class MerchantStatu
    {
        public MerchantStatu()
        {
            Merchants = new HashSet<Merchant>();
        }

        public int MerchantStatusId { get; set; }
        public string Name { get; set; } = null!;
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Merchant> Merchants { get; set; }
    }
}
