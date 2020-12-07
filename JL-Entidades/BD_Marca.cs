using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Entidades
{
   public class BD_Marca
    {
        public int Id_Marca { get; set; }
        public String Marca { get; set; }


        public BD_Marca()
        {
        }

        public BD_Marca(int Id_marca, string marca)
        {
            this.Id_Marca = Id_marca;
            this.Marca = marca;
        }

    }
}
