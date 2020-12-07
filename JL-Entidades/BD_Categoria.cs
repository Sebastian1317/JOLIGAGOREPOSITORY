using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JL_Entidades
{
  public  class BD_Categoria
    {
        public int Id_Cat { get; set; }
        public String Categoria { get; set; }
        

        public BD_Categoria()
        {
        }

        public BD_Categoria(int Id_cat, string categoria)
        {
            this.Id_Cat = Id_cat;
            this.Categoria = categoria;
        }
    }
}
