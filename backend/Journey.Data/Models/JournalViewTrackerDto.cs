using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey.Data.Models
{
    public class JournalViewTrackerDto
    {
        public Guid? JournalEntryId { get; set; }
        public Guid? ReplyId { get; set; }
    }
}
