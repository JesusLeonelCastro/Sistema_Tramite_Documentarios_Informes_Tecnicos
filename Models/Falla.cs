namespace Munipocollay_InformesTecnicos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Falla")]
    public partial class Falla
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Falla()
        {
            Informes = new HashSet<Informes>();
        }

        public int FallaID { get; set; }

        [StringLength(50)]
        public string Nombre_Falla { get; set; }

        [StringLength(255)]
        public string Descripcion_Falla { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Informes> Informes { get; set; }
    }
}
