namespace Munipocollay_InformesTecnicos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Runtime.Remoting;

    [Table("Area")]
    public partial class Area
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Area()
        {
            Informes = new HashSet<Informes>();
        }

        public int AreaID { get; set; }

        [StringLength(100)]
        public string Nombre_Area { get; set; }

        [StringLength(255)]
        public string Descripcion_Area { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Informes> Informes { get; set; }


        //Listar_Area 
        public List<Area> Listar()
        {
            var ObjArea = new List<Area>();
            try
            {
                using (var db = new Model1())
                {
                    ObjArea = db.Area.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Listar(): " + ex.Message);
                throw;
            }
            return ObjArea;
        }

        //Buscar_Area 
        public List<Area> Buscar(string criterio)
        {
            var ObjArea = new List<Area>();
            try
            {
                using (var db = new Model1())
                {
                    ObjArea = db.Area.
                        Where(x => x.Nombre_Area.Contains(criterio)).ToList();
                }

            }
            catch (Exception ex)
            {
                throw;

            }
            return ObjArea;

        }

        // Obtener_Area
        public Area Obtener(int id)
        {

            var ObjArea = new Area();
            try
            {
                using (var db = new Model1())
                {
                    ObjArea = db.Area.
                        Where(x => x.AreaID == id).SingleOrDefault();
                }


            }
            catch (Exception ex)
            {
                throw;

            }
            return ObjArea;

        }

        //Agregar_Area 
        public void Guardar()
        {

            try
            {
                using (var db = new Model1())
                {
                    if (this.AreaID > 0)
                    {
                        db.Entry(this).State = EntityState.Modified;
                    }
                    else
                    {
                        db.Entry(this).State = EntityState.Added;
                        db.SaveChanges();
                    }
                    db.SaveChanges();
                }

            }
            catch (Exception)
            {
                throw;

            }
        }

        //Eliminar_Area 
        public void Eliminar()
        {

            try
            {
                using (var db = new Model1())
                {
                    db.Entry(this).State = EntityState.Deleted;
                    db.SaveChanges();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
