using System;
using System.Collections.Generic;

namespace DeliveryConcept.Api.Entities
{
    public partial class User
    {
        public User()
        {
            BookingCustomers = new HashSet<Booking>();
            BookingRiders = new HashSet<Booking>();
            Branches = new HashSet<Branch>();
        }

        public long UserId { get; set; }
        public string UserName { get; set; } = null!;
        public byte[] PasswordHash { get; set; } = null!;
        public byte[] PasswordSalt { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? ContactNumber { get; set; }
        public string? Address { get; set; }
        public int BranchId { get; set; }
        public int UserTypeId { get; set; }
        public int UserStatusId { get; set; }
        public int? FareId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Branch Branch { get; set; } = null!;
        public virtual UserStatu UserStatus { get; set; } = null!;
        public virtual UserType UserType { get; set; } = null!;
        public virtual ICollection<Booking> BookingCustomers { get; set; }
        public virtual ICollection<Booking> BookingRiders { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
    }
}
