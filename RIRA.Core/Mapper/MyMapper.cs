using AutoMapper;
using RIRA.Core.Presentations;
using RIRA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIRA.Core.Mapper
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            CreateMap<User, UserViewModel>();

            CreateMap<UserViewModel,User>();



        }
    }
}
