using AutoMapper;
using RIRA.Core.Presentations;
using RIRA.Core.Presentations.Base;
using RIRA.Core.Repositories;
using RIRA.Core.Services.Interfaces;
using RIRA.Domain.Models;
using System.Linq.Expressions;


namespace RIRA.Core.Services
{
    public class UserService : Repository<User, UserViewModel>, IUserService 
    {
        private readonly IMapper _map;
        private readonly IServiceProvider _service;

        // سازنده
        public UserService(IServiceProvider service, IMapper map) :base(service)
        {
            _service = service;
            _map = map;
   
        }



        public  MessageViewModel AddUser(User entity,int creatorID=0)
        {
            MessageViewModel result = new MessageViewModel();
            try
            {
                Expression<Func<User, bool>> expression= x=>x.FirstName == entity.FirstName && x.LastName == entity.LastName && x.NID==entity.NID && x.IsDelete==false;
                var exist = GetAll(true,expression);
                if (exist.List.Count()>0)
                {
                    result = new MessageViewModel
                    {
                        ID = -1000,
                        Message = "Duplicate",
                        Status = "Error",
                        Value = ""
                    };
                    return result;
                }
                entity.IsActive = true;
                var message = Add(entity);
                result = message;
                return result;
            }
            catch (Exception ex)
            {
                result = new MessageViewModel
                {
                    ID = -1000,
                    Message = ex.Message,
                    Status = "Error",
                    Value = ""
                };
                return result;
            }
        }

    }
}
