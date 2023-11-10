using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    internal class Pelicula
    {
        public string descripcion { get; set; }
        public int id_tipo_pelicula { get; set; }
        public int id_idioma { get; set; }
        public int id_tipo_publico { get; set; }
        public Boolean subtitulada { get; set; }
        public int id_director { get; set; }
        public Pelicula()
        {
            descripcion = string.Empty;
            id_tipo_pelicula = 0;
            id_idioma = 0;
            id_tipo_publico = 0;
            subtitulada = false;
            id_director = 0;
        }
        public Pelicula(string des,int tipo_pel,int idioma,int tipo_pub,Boolean sub,int dir)
        {
            descripcion=des;
            id_tipo_pelicula=tipo_pel;
            id_idioma=idioma;
            id_tipo_publico=tipo_pub;
            subtitulada=sub;
            id_director=dir;
        }
    }
}
