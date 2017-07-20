using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SquareTeamsAPI.Models;
using SquareTeamsService.Dao;
using System.Runtime.Serialization;
using SquareTeamsAPI.DataContracts;

namespace SquareTeamsAPI.Controllers
{
    [Route("api/[controller]")]
    public class LoginTrackController : Controller
    {

        // POST api/logintrack 
        // body: {"Email":"shudecek@gmail.com", "FirstName":"Stan","LastName":"hudecek"}
        [HttpPost]
        public object Post([FromBody]LoginTrackRequest loginTrackRequest)
        {
            int count = LoginTrackDao.LoginTrackInsert(loginTrackRequest.Email, loginTrackRequest.FirstName, loginTrackRequest.LastName);
            return new Response() { Count = count };
        }

    }





}
