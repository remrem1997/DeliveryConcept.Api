using System;
using System.Collections.Generic;

namespace DeliveryConcept.Api.Entities
{
    public partial class Fare
    {
        public Fare()
        {
            Bookings = new HashSet<Booking>();
        }

        public int FareId { get; set; }
        public string Name { get; set; } = null!;
        public decimal BaseFare { get; set; }
        public string TotalBaseKilometers { get; set; } = null!;
        public decimal? Surcharge { get; set; }
        public decimal PricePerKilometer { get; set; }
        public string RidersPercentage { get; set; } = null!;
        public string CompanyPercentage { get; set; } = null!;
        public bool? IsDefault { get; set; }
        public decimal? AllowedBalance { get; set; }
        public int FareTypeId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
