using RIRA.Core.Presentations;
using RIRA.Core.Presentations.Base;
using RIRA.Core.Repositories;
using RIRA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIRA.Core.Services.Interfaces
{
    public interface IUserService : IRepository<User, UserViewModel>
    {
        MessageViewModel AddUser(User entity,int creatorID=0);

    }
}
