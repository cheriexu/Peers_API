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
    public class TeamController : Controller
    {


        // GET api/team/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
            var team = TeamDao.TeamGet(id);
            if (team != null)
                return new TeamResponse()
                {
                    IsSuccess = true,
                    Count = 1,
                    Message = "ok",
                    Team = team
                };
            else
                return new TeamResponse()
                {
                    IsSuccess = true,
                    Count = 0,
                    Message = "not found",
                    Team = null
                };
        }

        // DELETE api/team/5
        [HttpDelete("{id}")]
        public object Delete(int id)
        {
            int resp = TeamDao.TeamDelete(id);
            return new Response()
            {
                IsSuccess = true,
                Count = resp
            };

        }


        // id=0 creates, otherwise modify
        // url: /api/team
        // post data: {"Id":0, "Name":"tech all stars"}



    [HttpPost]
        public object Post([FromBody]TeamModifyRequest teamModifyRequest)
        {
            int count = TeamDao.TeamModify(teamModifyRequest.Id, teamModifyRequest.Name);
            return new Response() { Count = count };

        }
        
    }


}
