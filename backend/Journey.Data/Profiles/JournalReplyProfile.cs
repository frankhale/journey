using AutoMapper;

namespace Journey.Data.Profiles
{
    public class JournalReplyProfile : Profile
    {
        public JournalReplyProfile()
        {
            CreateMap<Entities.JournalReply, Models.JournalReplyDto>()
                .ReverseMap()
                .ForMember(x => x.Id, opt => opt.Ignore());
        }
    }
}
