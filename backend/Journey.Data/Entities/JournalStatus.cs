using System;
using System.ComponentModel.DataAnnotations;

namespace Journey.Data.Entities
{
    public class JournalStatus
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
    }
}