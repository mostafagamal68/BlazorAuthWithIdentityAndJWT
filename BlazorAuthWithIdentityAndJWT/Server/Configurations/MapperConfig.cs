using AutoMapper;
using BlazorAuthWithIdentityAndJWT.Server.Data;
using BlazorAuthWithIdentityAndJWT.Shared.Constants;
using BlazorAuthWithIdentityAndJWT.Shared.DTO;
using Microsoft.AspNetCore.Identity;

namespace BlazorAuthWithIdentityAndJWT.Server.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<User, UserForRegistrationDto>().ReverseMap();
            CreateMap<LoggedUser, User>().ReverseMap();
        }
    }
}
