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
    
    public partial class tbAfiliado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbAfiliado()
        {
            this.tbSocioInfoes = new HashSet<tbSocioInfo>();
        }
    
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public string Cedula { get; set; }
        public string Parentesco { get; set; }
        public Nullable<int> tbSexoID { get; set; }
    
        public virtual tbSexo tbSexo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSocioInfo> tbSocioInfoes { get; set; }
    }
}