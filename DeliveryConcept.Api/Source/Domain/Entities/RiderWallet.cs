using System;
using System.Collections.Generic;

namespace DeliveryConcept.Api.Entities
{
    public partial class RiderWallet
    {
        public long WalletId { get; set; }
        public long RiderId { get; set; }
        public decimal CurrentPoints { get; set; }
        public int WalletStatusId { get; set; }
        public decimal PointsLoaded { get; set; }
        public decimal NegativeBalance { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual RiderWalletStatu WalletStatus { get; set; } = null!;
    }
}
