using CineBack.Datos.Implementacion;
using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using CineBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada.Implementacion
{
    public class AplicacionCliente: IAplicacionCliente
    {
        private IClienteDao dao;

        public AplicacionCliente()
        {
            dao = new ClienteDao();
        }

        public List<Barrio> GetBarrios()
        {
            return dao.TraerBarrios();
        }

        public bool SaveCliente(Cliente oCliente)
        {
            return dao.Crear(oCliente);
        }

        public int ModifyCliente(Cliente oCliente)
        {
            return dao.Modificar(oCliente);
        }

        public bool DeleteCliente(Cliente oCliente)
        {
            return dao.Borrar(oCliente);
        }

<<<<<<< HEAD
        public async Task <Cliente> GetClientesIdAsync(int id)
        {
            return dao.TraerClienteId(id);
=======
        public List<Cliente> GetClientesFiltrados2(DateTime FechaDesde, DateTime FechaHasta, int idBarrio, string apellido)
        {
            return dao.ObtenerClientesFiltrados(FechaDesde, FechaHasta, idBarrio, apellido);
>>>>>>> f4cf6cf7b06d82b0446dc4567daf204543900e4a
        }
    }
}
