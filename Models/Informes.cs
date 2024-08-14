namespace Munipocollay_InformesTecnicos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.Linq;

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

        public string Nombre_Equipos { get; set; }

        public string Tipo { get; set; }

        public string Color { get; set; }

        public string Serie { get; set; }

        public string Cod_Patrimonial { get; set; }

        public string Sub_Tipo { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public string Codigo_Interno { get; set; }

        public string Observaciones { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ingreso { get; set; }

        //Listar_Articulo      "Poner la relacion de 2 o 3 tablas"
        public List<Informes> Listar()
        {
            var ObjInformes = new List<Informes>();
            try
            {
                using (var db = new Model1())
                {
                    // Incluye la relación con la tabla Categorias
                    ObjInformes = db.Informes.Include(a => a.Area).ToList();
                    ObjInformes = db.Informes.Include(a => a.Falla).ToList();
                    ObjInformes = db.Informes.Include(a => a.Sede).ToList();
                    ObjInformes = db.Informes.Include(a => a.Tipo_Equipo).ToList();
                    ObjInformes = db.Informes.Include(a => a.Area).ToList();
                    ObjInformes = db.Informes.Include(a => a.O_Actividades).ToList();
                    ObjInformes = db.Informes.Include(a => a.Estados).ToList();
                    ObjInformes = db.Informes.Include(a => a.Equipo).ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Listar(): " + ex.Message);
                throw;
            }
            return ObjInformes;
        }

        //Buscar_Articulo
        public List<Informes> Buscar(string criterio)
        {
            var ObjInformes = new List<Informes>();
            try
            {
                using (var db = new Model1())
                {
                    // Incluye las relaciones con las tablas relacionadas y filtra por el criterio
                    ObjInformes = db.Informes
                        .Include(a => a.Area)
                        .Include(a => a.Falla)
                        .Include(a => a.Sede)
                        .Include(a => a.Tipo_Equipo)
                        .Include(a => a.O_Actividades)
                        .Include(a => a.Estados)
                        .Include(a => a.Equipo)
                        .Where(a => a.Titulo.Contains(criterio))
                        .ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Buscar(): " + ex.Message);
                throw;
            }
            return ObjInformes;
        }

        // Obtener_Articulo    "Cada debes poner la relacion de 2 o 3 tablas"
        public Informes Obtener(int id)
        {
            var ObjInformes = new Informes();
            try
            {
                using (var db = new Model1())
                {
                    ObjInformes = db.Informes.
                        Where(x => x.InformeID == id).SingleOrDefault();
                }

                using (var db = new Model1())
                {
                    ObjInformes = db.Informes
                        .Include("Area")
                        .Include("Falla")
                        .Include("Sede")
                        .Include("Tipo_Equipo")
                        .Include("O_Actividades")
                        .Include("Estados")
                        .Include("Equipo")
                        .Where(x => x.InformeID == id)
                        .SingleOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw;

            }
            return ObjInformes;
        }

        //Guardar_Articulo
        public void Guardar()
        {
            try
            {
                using (var db = new Model1())
                {
                    if (this.InformeID > 0)
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

        //Eliminar_Articulo
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
