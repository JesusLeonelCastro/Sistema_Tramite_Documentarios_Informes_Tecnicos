using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Munipocollay_InformesTecnicos.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Area> Area { get; set; }
        public virtual DbSet<Equipo> Equipo { get; set; }
        public virtual DbSet<Estados> Estados { get; set; }
        public virtual DbSet<Falla> Falla { get; set; }
        public virtual DbSet<Informes> Informes { get; set; }
        public virtual DbSet<O_Actividades> O_Actividades { get; set; }
        public virtual DbSet<Sede> Sede { get; set; }
        public virtual DbSet<Tipo_Equipo> Tipo_Equipo { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
