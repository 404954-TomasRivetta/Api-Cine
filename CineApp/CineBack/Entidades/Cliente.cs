using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Cliente
    {
        public int CodCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido  { get; set; }
        public string Correo { get; set; }
        public int NroTel { get; set; }
        public int CodBarrio { get; set; }
        public string Calle { get; set; }
        public int CalleNro { get; set; }
        public int Dni { get; set; }

        public string NombreBarrio { get; set; }
        public string NombrePelicula { get; set; }
        public string NombreCompleto { get; set; }

        public Cliente()
        {
            CodCliente = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Correo = string.Empty;
            NroTel = 0;
            CodBarrio = 0;
            Calle = string.Empty;
            CalleNro = 0;
            Dni = 0;
        }
        public Cliente(int codCliente,string nom,string ape,string cor,int tel,int cod,
            string cal,int cal_nro,int dni)
        {
            CodCliente=codCliente;
            Nombre = nom;
            Apellido = ape;
            Correo = cor;
            NroTel =tel;
            CodBarrio = cod;
            Calle = cal;
            CalleNro = cal_nro;
            Dni = dni;
        }

        public Cliente(int id, string nombreCompleto, string correo, string nombreBarrio, string nombrePelicula)
        {
            CodCliente = id;
            NombreCompleto = nombreCompleto;
            Correo = correo;
            NombreBarrio = nombreBarrio;
            NombrePelicula = nombrePelicula;
        }
    }
}
