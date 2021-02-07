namespace Journey.Data.Models
{
    public class JournalEntryDto
    {
        public string Title { get; set; }        
        public string Body { get; set; }        
        public JournalStatusDto Status { get; set; }        
    }
}
