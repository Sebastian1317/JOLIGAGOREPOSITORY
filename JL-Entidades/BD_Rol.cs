using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Entidades
{
   public class BD_Rol
    {
        public int Id_Rol { get; set; }
        public String Rol { get; set; }

        public BD_Rol()
        {
        }

        public BD_Rol(int id_Rol, string rol)
        {
            Id_Rol = id_Rol;
            Rol = rol;
        }
    }
}
