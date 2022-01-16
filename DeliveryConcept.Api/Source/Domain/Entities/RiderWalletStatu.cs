using System;
using System.Collections.Generic;

namespace DeliveryConcept.Api.Entities
{
    public partial class RiderWalletStatu
    {
        public RiderWalletStatu()
        {
            RiderWallets = new HashSet<RiderWallet>();
        }

        public int WalletStatusId { get; set; }
        public string Status { get; set; } = null!;
        public string? Operation { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<RiderWallet> RiderWallets { get; set; }
    }
}
