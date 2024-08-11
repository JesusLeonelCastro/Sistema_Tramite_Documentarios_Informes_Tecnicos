namespace Munipocollay_InformesTecnicos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Informes
    {
        [Key]
        public int InformeID { get; set; }

        [StringLength(255)]
        public string Titulo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha_Solicitud { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha_Informe { get; set; }

        [StringLength(1000)]
        public string Diagnostico { get; set; }

        [StringLength(1000)]
        public string Solucion_Primaria { get; set; }

        public int? EstadoID { get; set; }

        public int? UsuarioID { get; set; }

        public int? Tipo_EquipoID { get; set; }

        public int? AreaID { get; set; }

        public int? SedeID { get; set; }

        public int? FallaID { get; set; }

        public int? O_ActividadesID { get; set; }

        public int? EquipoID { get; set; }

        public virtual Area Area { get; set; }

        public virtual Equipo Equipo { get; set; }

        public virtual Estados Estados { get; set; }

        public virtual Falla Falla { get; set; }

        public virtual O_Actividades O_Actividades { get; set; }

        public virtual Sede Sede { get; set; }

        public virtual Tipo_Equipo Tipo_Equipo { get; set; }

        public virtual Usuario Usuario { get; set; }
    }
}
