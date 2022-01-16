using System;
using System.Collections.Generic;

namespace DeliveryConcept.Api.Entities
{
    public partial class UserStatu
    {
        public UserStatu()
        {
            Users = new HashSet<User>();
        }

        public int UserStatusId { get; set; }
        public string Status { get; set; } = null!;
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
