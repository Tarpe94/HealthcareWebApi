using AutoMapper;
using Models.EntityModels.Users;

namespace HealthcareWebApi.OutgoingDtos.OutgoingUser
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<User, OutgoingUserDto>();
        }
    }
}
