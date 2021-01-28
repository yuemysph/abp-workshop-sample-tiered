using System;
using System.Collections;
using System.Collections.Generic;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities.Auditing;

namespace Playground.Books
{
    [Audited]
    public class Book : AuditedAggregateRoot<Guid>
    { 
        public string Name { get; set; }

        public BookType Type { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }

        public Guid AuthorId { get; set; }

        public bool Availability { get; set; }

        public ICollection<RentalRecord> RentalRecords;

        internal void AddRentalRecord(RentalRecord rentalRecord)
        {
            RentalRecords.Add(rentalRecord);
        }


    }

   
    public class RentalRecord:FullAuditedEntity<Guid>
    {
        public Guid CustomerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid BookId { get; set; }
    }
}
