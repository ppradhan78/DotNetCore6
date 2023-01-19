using System;

namespace ApsNetCore6.Models
{
    public class SessionModel
    {
        public Guid SessionId { get; set; }

        public string UserName
        {
            get;
            set;
        }
    }
}
