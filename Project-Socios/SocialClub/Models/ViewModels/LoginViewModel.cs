using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SocialClub.Models
{
    [MetadataType(typeof(MetaData))]
    public partial class tbLogin
    {
        sealed class MetaData
        {
            [Required(ErrorMessage = "no es válido")]
            [Display(Name = "Socio ID")]
            public int ID;

            [Required(ErrorMessage = "Ingresé un Email")]
            [EmailAddress(ErrorMessage = "no tiene formato válido")]
            [StringLength(50)]
            [Display(Name = "Email777777777777")]
            public string Email;

            [Required(ErrorMessage = "Ingresé una Contraseña")]
            [Display(Name = "Contraseña")]
            public string Contrasena;

            [Display(Name = "Creado En")]
            public Nullable<System.DateTime> FechaCreacion;
        }
    }


    public class MetaDatatbLogin
    {
       
        //[Display(Name = "Socio ID")]
        public int ID;

        [Required()]
        //[EmailAddress(ErrorMessage = "Email no tiene formato válido")]
        //[StringLength(50)]
        //[Display(Name = "Email777777777777")]
        public string Email;


        //[Display(Name = "Contraseña")]
        [Required()]
        public string Contrasena;

        //[Display(Name = "Creado En")]
        public Nullable<System.DateTime> FechaCreacion;
    }
}