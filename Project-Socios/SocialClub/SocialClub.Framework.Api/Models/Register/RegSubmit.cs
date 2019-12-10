

using System;

namespace SocialClub.Framework.Api.Models.Register
{
    public sealed class RegSubmit : RegBase
    {
  
     public string apellidos { get; set; }
     public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int Sexo { get; set; }
        public int Edad { get; set; }
        public string Afill { get; set; }
        public DateTime? fechaN { get; set; }
        public int TipoMembre { get; set; }
        public string PlaceWork { get; set; }
        public string DirOff { get; set; }
        public string TelOff { get; set; }
        

    }
}
