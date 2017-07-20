using SquareTeamsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SquareTeamsAPI.DataContracts
{
    public class UserResponse : Response
    {
        [DataMember]
        public User User { get; set; }
    }
}
