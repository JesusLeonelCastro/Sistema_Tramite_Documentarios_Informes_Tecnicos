namespace Munipocollay_InformesTecnicos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Equipo")]
    public partial class Equipo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipo()
        {
            Informes = new HashSet<Informes>();
        }

        public int EquipoID { get; set; }

        [StringLength(100)]
        public string Nombre_Equipo { get; set; }

        [StringLength(100)]
        public string Tipo { get; set; }

        [StringLength(255)]
        public string Color { get; set; }

        [StringLength(255)]
        public string Serie { get; set; }

        [StringLength(255)]
        public string Cod_Patrimonial { get; set; }

        [StringLength(100)]
        public string Sub_Tipo { get; set; }

        [StringLength(100)]
        public string Modelo { get; set; }

        [StringLength(100)]
        public string Marca { get; set; }

        [StringLength(100)]
        public string Codigo_Interno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Informes> Informes { get; set; }
    }
}
