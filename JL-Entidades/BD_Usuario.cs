using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Entidades
{
  public class BD_Usuario
    {

        public int id_Usu { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public BD_Distrito id_Dis { get; set; }
        public String usuario { get; set; }
        public String contraseña { get; set; }
        public String ubicacion_Foto { get; set; }
        public DateTime fecha_Ncmiento { get; set; }
        public BD_Rol id_Rol { get; set; }
        public String correo { get; set; }
        public String estado_Usu { get; set; }

        public BD_Usuario()
        {
        }

        public BD_Usuario(int id_Usu, string nombres, 
            string apellidos, BD_Distrito id_Dis, string usuario, string contraseña,
            string ubicacion_Foto, DateTime fecha_Ncmiento, BD_Rol id_Rol, string correo, string estado_Usu)
        {
            this.id_Usu = id_Usu;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.id_Dis = id_Dis;
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.ubicacion_Foto = ubicacion_Foto;
            this.fecha_Ncmiento = fecha_Ncmiento;
            this.id_Rol = id_Rol;
            this.correo = correo;
            this.estado_Usu = estado_Usu;
        }
    }
}
