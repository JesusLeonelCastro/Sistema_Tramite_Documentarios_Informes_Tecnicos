namespace Munipocollay_InformesTecnicos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class O_Actividades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public O_Actividades()
        {
            Informes = new HashSet<Informes>();
        }

        public int O_ActividadesID { get; set; }

        [StringLength(50)]
        public string Nombre_O_Actividad { get; set; }

        [StringLength(255)]
        public string Descripcion_O_Actividad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Informes> Informes { get; set; }
    }
}
