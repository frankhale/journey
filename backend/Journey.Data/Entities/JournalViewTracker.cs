using System;

namespace Journey.Data.Entities
{
    public class JournalViewTracker : Entity
    {
        public Guid? JournalEntryId { get; set; }
        public Guid? ReplyId { get; set; }
    }
}
