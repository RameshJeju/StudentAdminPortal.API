using AutoMapper;
using StudentAdminPortal.API.DataModels;
//using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.DomainModels;
using StudentAdminPortal.API.Profiles.AfterMaps;
using DataModels= StudentAdminPortal.API.DataModels;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles:Profile
    {
       public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, DataModels.Student>()
                .ReverseMap();
            CreateMap<DataModels.Gender, DataModels.Gender>()
                .ReverseMap();
            CreateMap<DataModels.Address, DataModels.Address>()
                .ReverseMap();
            CreateMap<UpdateStudentRequest, DataModels.Student>()
                .AfterMap<UpdateStudentRequestAfterMap>();
            CreateMap<AddStudentRequest, DataModels.Student>()
                .AfterMap<AddStudentRequestAfterMap>();
        }

    }
}
