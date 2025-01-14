﻿using AutoMapper;
using GamesShop.IdentityServer.Controllers.Account;
using GamesShop.IdentityServer.Entities;

namespace GamesShop.IdentityServer.Mapping
{
    public class MappingProfile : Profile
    {
        public override string ProfileName => "ModelsMappings";

        public MappingProfile()
        {
            CreateMap<RegisterUserModel, UserEntity>();
        }
    }
}
