using  SocialClub.Framework.Api.Models.Register;
using creaworlds.Core.Framework.Enumerators.Responses;
using creaworlds.Core.Framework.Extensions;
using creaworlds.Core.Framework.Models.Requests;
using creaworlds.Core.Framework.Models.Responses;
using creaworlds.Core.Framework.Tools;
using System;
using System.Data;
using System.Linq;

namespace SocialClub.Framework.Api.Handlers.Register
{
    public static partial class Register
    {
        public static ResponseObject<RegData> Submit(RequestObject<RegSubmit> request)
        {
            var response = new ResponseObject<RegData>();

            if (RequestsExtensions.IsValid(request, response))
            {
                
                if (string.IsNullOrWhiteSpace(request.Content.Name))
                {
                    response.Configure(Codes.BadRequest, "Favor de especificar el nombre de la cuenta.", 1410);
                }
               
                else if (!request.Content.IsActive.HasValue)
                {
                    response.Configure(Codes.BadRequest, "Favor de especifica el estatus de la cuenta", 1414);
                }
                else
                {
                    using (var db = new DataBase())
                    {
                        try
                        {
                            db.AddParameter("request", SqlDbType.Xml, request.ToRequestEmpty());
                            db.AddParameter("content", SqlDbType.Xml, request.Content);
                            db.AddParameter("done", SqlDbType.Bit, ParameterDirection.Output);

                            db.FillDataTable(response, "SP_USUARIO_INSERTA", (dt) =>
                            {
                                if (Convert.ToBoolean(db.GetParameter("done")))
                                {
                                    response.Result = Common.Populate<RegData>(dt).First();
                                    response.CodeName = Codes.OK;
                                }
                                else
                                {
                                    response = Common.Populate<ResponseEmpty>(dt).First().ToResponseObject<RegData>();
                                }
                            });
                        }
                        catch (Exception ex)
                        {
                            response.ConfigureAndLog("Ha ocurrido un error al registrar una cuenta bancaría.", 1500, ex);
                        }
                    }
                }
            }

            return response;
        }
    }
}
