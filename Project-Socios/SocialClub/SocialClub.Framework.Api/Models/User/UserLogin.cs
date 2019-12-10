using System;
using System.Collections.Generic;
using System.Text;

namespace SocialClub.Framework.Api.Models.User
{
  public sealed  class UserLogin
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
