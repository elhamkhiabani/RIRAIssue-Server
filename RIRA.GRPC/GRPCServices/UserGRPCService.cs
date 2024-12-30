using Grpc.Core;
using RIRA.Core.Services.Interfaces;
using RIRA.Domain.Models;
using RIRA.GRPC.Protos;

namespace RIRA.GRPC.GRPCServices
{
    public class UserGRPCService : UserAdd.UserAddBase
    {
        private readonly IUserService _service;
        public UserGRPCService(IUserService service) 
        {
            _service = service;
        }

        public override Task<userAddResponse> add(userAddRequest entity,ServerCallContext context)
        {
            User user = new User
            {
                ID = entity.ID,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                NID = entity.NID,
                BirthDate = entity.BirthDate,
                IsActive = entity.IsActive,
                CreatorID = entity.CreatorID,
                CreationDateTime = DateTime.Now,
                IsDelete = entity.IsDelete,
                ModifierDateTime = DateTime.Now,
                ModifierID = entity.ModifierID

            };
           var mess= _service.AddUser(user, 0);
            userAddResponse response = new userAddResponse
            {
                ID = mess.ID,
                Message = mess.Message,
                Status = mess.Status,
                Value = mess.Value
            };

            return Task.FromResult(response);
        }
    }
}
