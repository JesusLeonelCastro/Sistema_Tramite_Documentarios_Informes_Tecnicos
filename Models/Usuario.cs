namespace Munipocollay_InformesTecnicos.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Threading.Tasks;
   


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


        //Listar_Usuario
        public List<Usuario> Listar()
        {
            var ObjUsuario = new List<Usuario>();
            try
            {
                using (var db = new Model1())
                {
                    ObjUsuario = db.Usuario.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en Listar(): " + ex.Message);
                throw;
            }
            return ObjUsuario;
        }

        //Buscar_Usuario
        public List<Usuario> Buscar(string criterio)
        {
            var ObjUsuario = new List<Usuario>();
            try
            {
                using (var db = new Model1())
                {
                    ObjUsuario = db.Usuario.
                        Where(x => x.Nombre_Usuario.Contains(criterio)).ToList();
                }

            }
            catch (Exception ex)
            {
                throw;

            }
            return ObjUsuario;

        }

        // Obtener_Usuario
        public Usuario Obtener(int id)
        {

            var ObjUsuario = new Usuario();
            try
            {
                using (var db = new Model1())
                {
                    ObjUsuario = db.Usuario.
                        Where(x => x.UsuarioID == id).SingleOrDefault();
                }


            }
            catch (Exception ex)
            {
                throw;

            }
            return ObjUsuario;

        }

        //Agregar_Usuario
        public void Guardar()
        {

            try
            {
                using (var db = new Model1())
                {
                    if (this.UsuarioID > 0)
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

        //Eliminar_Usuario
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


        Model1 db = new Model1();

        //Autenticar_Login_Usuario
        public bool Autenticar()
        {

            return db.Usuario
                   .Where(x => x.DNI == this.DNI
                   && x.Password == this.Password)
                   .FirstOrDefault() != null;
        }

        //obtener datos del login
        public Usuario ObtenerDatos(string Correo)
        {
            var usuario = new Usuario();

            try
            {
                using (var db = new Model1())
                {

                }
            }
            catch (Exception)
            {
                throw;
            }
            return usuario;
        }



    }
}
