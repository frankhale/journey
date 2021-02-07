using System;

namespace Journey.Data.Models
{
    public class EntityDto
    {
        public Guid Id { get; set; }        
        public string UserName { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }        
    }
}
