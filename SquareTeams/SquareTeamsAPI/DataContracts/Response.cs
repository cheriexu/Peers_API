using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SquareTeamsAPI.DataContracts
{
    [DataContract]
    public class Response
    {
        bool isSuccess = true;
        string message = "ok";

        [DataMember]
        public bool IsSuccess
        {
            get { return isSuccess; }
            set { isSuccess = value; }
        }

        [DataMember]
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        [DataMember]
        public int Count { get; set; }


    }
}
