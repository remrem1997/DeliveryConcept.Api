using System;
using System.Collections.Generic;

namespace DeliveryConcept.Api.Entities
{
    public partial class BookingStatu
    {
        public BookingStatu()
        {
            Bookings = new HashSet<Booking>();
        }

        public int BookingStatusId { get; set; }
        public string Status { get; set; } = null!;

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
