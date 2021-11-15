using AutoMapper;
using Domain;


namespace Application.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AppUser, AppUser>();
            CreateMap<Billables, Billables>();
            CreateMap<Crews, Crews>();
            CreateMap<Customer, Customer>();
            CreateMap<Job, Job>();
            CreateMap<Punch, Punch>();
        }
    }
}