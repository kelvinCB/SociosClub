using System;
using System.Collections.Generic;
using System.Text;

namespace SocialClub.Framework.Api.Models.Register
{
   public abstract class RegBase 
    {
        
        public string Name { get; set; }
       
        public bool? IsActive { get; set;}
        public string Password { get; set; }
        public string UserName { get; set; }
        public string ID { get; set; }
        public string UserID { get; set; }




    }
}
