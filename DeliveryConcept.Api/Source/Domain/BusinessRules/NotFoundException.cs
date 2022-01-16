using DeliveryConcept.Api.Source.Domain.BusinessRules.Base;
using System.Net;

namespace DeliveryConcept.Api.Source.Domain.BusinessRules
{
    public class NotFoundException : BusinessRulesException
    {
        private const string message = "Record Not Found.";
        public NotFoundException() : base(HttpStatusCode.NotFound, message) { }
    }
}
