using System;
using System.Collections.Generic;
using System.Text;

namespace SocialClub.Framework.Api.Models.Register
{
    public sealed  class BankData :RegBase
    {
        public string  Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public string Sexo { get; set; }
        public string TelefonoN { get; set; }
        public string LugarTrabajo { get; set; }
        public string Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DireccionOFF { get; set; }
        public string TelefonoOff { get; set; }
        public bool MembresiaAC { get; set; }



    }
}
