using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Playground.Payments
{
    public class Payment:FullAuditedAggregateRoot<Guid>
    {
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public Guid CustomerId { get; set; }
    }
}
