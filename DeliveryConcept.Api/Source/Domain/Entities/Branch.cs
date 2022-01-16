using System;
using System.Collections.Generic;

namespace DeliveryConcept.Api.Entities
{
    public partial class Branch
    {
        public Branch()
        {
            Bookings = new HashSet<Booking>();
            Companies = new HashSet<Company>();
            Users = new HashSet<User>();
        }

        public int BranchId { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public string? Description { get; set; }
        public long? UserId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
