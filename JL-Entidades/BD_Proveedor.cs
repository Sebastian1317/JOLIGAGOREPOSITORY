using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Entidades
{
  public class BD_Proveedor
    {
      public int idProvee { get; set; }
      public String nombre { get; set; }
      public String direccion { get; set; }
      public String telefono { get; set; }
      public String rubro { get; set; }
      public String rfc { get; set; }
      public String correo { get; set; }
      public String contacto { get; set; }
      public String foto_logo { get; set; }
      public String estado_provdr { get; set; }

        public BD_Proveedor()
        {
        }

        public BD_Proveedor(int idProvee, string nombre, string direccion, string telefono, string rubro, string rfc,
            string correo, string contacto, string foto_logo, string estado_provdr)
        {
            this.idProvee = idProvee;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.rubro = rubro;
            this.rfc = rfc;
            this.correo = correo;
            this.contacto = contacto;
            this.foto_logo = foto_logo;
            this.estado_provdr = estado_provdr;
        }
    }
}
