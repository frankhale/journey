using System;

namespace Journey.Data.Models
{
    public class JournalReplyDto
    {
        public string Body { get; set; }
        public Guid JournalEntryId { get; set; }
    }
}
