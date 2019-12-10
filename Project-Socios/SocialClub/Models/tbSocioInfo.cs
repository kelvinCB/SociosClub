//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialClub.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbSocioInfo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string Cedula { get; set; }
        public byte[] Foto { get; set; }
        public Nullable<int> tbSexoID { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Fax { get; set; }
        public Nullable<int> tbAfiliadosID { get; set; }
        public Nullable<int> tbMembresiaID { get; set; }
        public string LugarTrabajo { get; set; }
        public string DireccionOficina { get; set; }
        public string TelefonoOficina { get; set; }
        public Nullable<int> EstadoMenbresia { get; set; }
        public Nullable<int> tbLoginID { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<System.DateTime> FechaSalida { get; set; }
    
        public virtual tbAfiliado tbAfiliado { get; set; }
        public virtual tbLogin tbLogin { get; set; }
        public virtual tbMembresia tbMembresia { get; set; }
        public virtual tbSexo tbSexo { get; set; }
    }
}