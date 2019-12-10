using SocialClub.Framework.Api.Handlers.Register;
using SocialClub.Framework.Api.Models.Register;
using creaworlds.Core.Framework.Models.Requests;
using creaworlds.Core.Framework.Models.Responses;
using System.Web.Http;
using SocialClub.Framework.Api.Handlers.Register;



namespace Socios.Backend.Api.Controllers
{
    public class RegisterController : ApiController
    {
        [HttpPost]
        public ResponseObject<RegData> Submit(RequestObject<RegSubmit> request) => Register.Submit(request);

        [HttpPost]
        public ResponseObject<BankData[]> List(RequestEmpty request) => Register.List(request);

    }
}