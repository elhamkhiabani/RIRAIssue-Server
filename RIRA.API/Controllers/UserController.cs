using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RIRA.Core.Presentations;
using RIRA.Core.Presentations.Base;
using RIRA.Core.Services.Interfaces;
using RIRA.Domain.Models;
using System.Text.Json;

namespace RIRA.API.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;
        public UserController( IUserService service)
        {
            _service = service;
        }


       
        [HttpGet]
        [Route("user/remove/{id}")]
        [AllowAnonymous]
        public MessageViewModel remove(int id)
        {
            var result = _service.Delete(id);
            return result;
        }

    
    


        [HttpGet]
        [Route("user/get/{id}")]
        [AllowAnonymous]
        public ResultViewModel<UserViewModel> get(int id)
        {
            var result = _service.GetByID(id);
            return result;
        }


        [HttpPost]
        [Route("user/add")]
        [AllowAnonymous]
        public MessageViewModel add(User entity)
        {
            var result = _service.AddUser(entity);
            return result;
        }


    }
}
