using System;
using System.Collections.Generic;

namespace DeliveryConcept.Api.Entities
{
    public partial class Booking
    {
        public long BookingId { get; set; }
        public int BookingStatusId { get; set; }
        public long CustomerId { get; set; }
        public string ReceiverName { get; set; } = null!;
        public string ReceiverNumber { get; set; } = null!;
        public int FareId { get; set; }
        public DateTime BookingDate { get; set; }
        public long RiderId { get; set; }
        public bool IsActive { get; set; }
        public string ReferenceNumber { get; set; } = null!;
        public string? ReceiptNumber { get; set; }
        public int BranchId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual BookingStatu BookingStatus { get; set; } = null!;
        public virtual Branch Branch { get; set; } = null!;
        public virtual User Customer { get; set; } = null!;
        public virtual Fare Fare { get; set; } = null!;
        public virtual User Rider { get; set; } = null!;
    }
}
