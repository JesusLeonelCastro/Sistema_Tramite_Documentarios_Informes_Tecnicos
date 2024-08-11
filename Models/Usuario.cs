namespace Munipocollay_InformesTecnicos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Usuario")]
    public partial class Usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuario()
        {
            Informes = new HashSet<Informes>();
        }

        public int UsuarioID { get; set; }

        [StringLength(100)]
        public string DNI { get; set; }

        [StringLength(100)]
        public string Nombre_Usuario { get; set; }

        [StringLength(100)]
        public string Apellido_Usuario { get; set; }

        [StringLength(100)]
        public string Correo { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Informes> Informes { get; set; }
    }
}
