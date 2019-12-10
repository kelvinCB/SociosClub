using System;
using System.Collections.Generic;
using System.Text;

namespace SocialClub.Framework.Api.Models.User
{
    public abstract class UserBase
    {
        public string ID { get; set; }
        public string FristName { get; set; }
        public string Apikey { get; set; }
    }
}
