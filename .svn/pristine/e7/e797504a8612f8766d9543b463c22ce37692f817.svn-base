using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SquareTeamsAPI.Models;
using SquareTeamsService.Dao;
using System.Runtime.Serialization;
using SquareTeamsAPI.DataContracts;
using SquareTeamsAPI.Dao;

namespace SquareTeamsAPI.Controllers
{


    [Route("api/[controller]")]
    public class UserController : Controller
    {


        // GET api/values/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
            var user = UserDao.UserGet(id);
            if (user != null)
                return new UserResponse()
                {
                    IsSuccess = true,
                    Count = 1,
                    Message = "ok",
                    User = user
                };
            else
                return new UserResponse()
                {
                    IsSuccess = true,
                    Count = 0,
                    Message = "not found",
                    User = null
                };
        }

        // GET api/values/email@email.com
        [HttpGet("{email}")]
        public object Get(string email)
        {
            var user = UserDao.UserGet(email);
            if (user != null)
                return new UserResponse()
                {
                    IsSuccess = true,
                    Count = 1,
                    Message = "ok",
                    User = user
                };
            else
                return new UserResponse()
                {
                    IsSuccess = true,
                    Count = 0,
                    Message = "not found",
                    User = null
                };
        }



        [HttpPost]
        public object Post([FromBody]UserModifyRequest userModifyRequest)
        {
            int count = UserDao.UserModify(userModifyRequest.Id, userModifyRequest.Email, userModifyRequest.FirstName, userModifyRequest.LastName);
            return new Response() { Count = count };
        
        }

    }


}
