namespace Munipocollay_InformesTecnicos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("Equipo")]
    public partial class Equipo
    {
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

        [StringLength(100)]
        public string Observaciones { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ingreso { get; set; }





        //Listar_Estado
        public List<Equipo> Listar()
        {
            var ObjEquipo= new List<Equipo>();
            try
            {
                using (var db = new Model1())
                {
                    ObjEquipo = db.Equipo.ToList();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Listar(): " + ex.Message);
                throw;
            }
            return ObjEquipo;
        }

        //Buscar_Equipo
        public List<Equipo> Buscar(string criterio)
        {
            var ObjEquipo = new List<Equipo>();
            try
            {
                using (var db = new Model1())
                {
                    ObjEquipo = db.Equipo.

                        Where(x => x.Nombre_Equipo.Contains(criterio)).ToList();
                }

            }
            catch (Exception ex)
            {
                throw;

            }
            return ObjEquipo;

        }

        // Obtener_Equipo
        public Equipo Obtener(int id)
        {

            var ObjEquipo = new Equipo();
            try
            {
                using (var db = new Model1())
                {
                    ObjEquipo = db.Equipo
                                         .Where(x => x.EquipoID == id)
                                         .SingleOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw;

            }
            return ObjEquipo;

        }

        //Agregar_Equipo
        public void Guardar()
        {

            try
            {
                using (var db = new Model1())
                {
                    if (this.EquipoID > 0)
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

        //Eliminar_Equipo

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
