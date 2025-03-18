using AutoMapper;
using HealthcareWebApi.OutgoingDtos.OutgoingUser;
using Models.EntityModels.Users;
using Shared.Interfaces;

namespace HealthcareWebApi.OutgoingDtos.Auth
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<ITokenResponse, LoginResponseDto>();
        }
    }
}
