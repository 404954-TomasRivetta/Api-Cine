using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    internal class Cliente
    {
        public string nombre { get; set; }
        public string apellido  { get; set; }
        public string correo { get; set; }
        public int nro_tel { get; set; }
        public int cod_barrio { get; set; }
        public string calle { get; set; }
        public int calle_nro { get; set; }
        public int Dni { get; set; }
        public Cliente()
        {
            nombre = string.Empty;
            apellido = string.Empty;
            correo = string.Empty;
            nro_tel = 0;
            cod_barrio = 0;
            calle = string.Empty;
            calle_nro = 0;
            Dni = 0;
        }
        public Cliente(string nom,string ape,string cor,int tel,int cod,
            string cal,int cal_nro,int dni)
        {
            nombre = nom;
            apellido = ape;
            correo = cor;
            nro_tel=tel;
            cod_barrio = cod;
            calle = cal;
            calle_nro = cal_nro;
            Dni = dni;
        }

    }
}
