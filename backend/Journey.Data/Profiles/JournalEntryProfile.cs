using AutoMapper;

namespace Journey.Data.Profiles
{
    public class JournalEntryProfile : Profile
    {
        public JournalEntryProfile()
        {
            CreateMap<Entities.JournalEntry, Models.JournalEntryDto>()               
                .ReverseMap()
                .ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}
