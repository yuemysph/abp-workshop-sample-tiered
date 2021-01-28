using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Playground.Customers
{
    public class Customer: FullAuditedEntity<Guid>
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
