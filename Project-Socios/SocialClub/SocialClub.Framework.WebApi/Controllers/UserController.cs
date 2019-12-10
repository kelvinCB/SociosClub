using SocialClub.Framework.Api.Models.User;
using creaworlds.Core.Framework.Models.Responses;
using System.Web.Http;
using UserHandler = SocialClub.Framework.Api.Handlers;

namespace SocialClub.Framework.WebApi.Controllers
{
    public class UserController :ApiController
    {
        [HttpPost]
        public ResponseObject<UserData> Login(UserLogin request) => UserHandler.User.Login(request);
    }
}