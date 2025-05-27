using AutoMapper;
using Segundaria.DomainModels;
using DataModels = Segundaria.DataModels;

namespace Segundaria.Profiles
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<DataModels.Course, Course>().ReverseMap();
            CreateMap<DataModels.Degree, Degree>().ReverseMap();
            CreateMap<DataModels.Parent, Parent>().ReverseMap();
            CreateMap<DataModels.Section, Section>().ReverseMap();
            CreateMap<DataModels.Student, Student>().ReverseMap();
            CreateMap<DataModels.Teacher, Teacher>().ReverseMap();
            CreateMap<DataModels.Tuition, Tuition>().ReverseMap();
            CreateMap<DataModels.User, User>().ReverseMap();
        }
    }
    
}
