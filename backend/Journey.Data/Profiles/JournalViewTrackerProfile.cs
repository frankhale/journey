using AutoMapper;

namespace Journey.Data.Profiles
{
    public class JournalViewTrackerProfile : Profile
    {
        public JournalViewTrackerProfile()
        {
            CreateMap<Entities.JournalViewTracker, Models.JournalViewTrackerDto>()
                .ReverseMap()
                .ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}
