﻿using AutoMapper;
using InstagramClone.Application.DTOs.Identity;
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Application.Maps
{
    public class UserMap : Profile
    {
        public UserMap()
        {
            CreateMap<AppUser, GetUserDto>().ReverseMap();
        }
    }
}