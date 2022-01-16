using System;
using System.Collections.Generic;

namespace DeliveryConcept.Api.Entities
{
    public partial class FareType
    {
        public int FareTypeId { get; set; }
        public string Type { get; set; } = null!;
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
