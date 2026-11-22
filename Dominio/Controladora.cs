
using System.Collections.Generic;

namespace Obligatorio.Dominio
{
    public class Controladora
    {
        private static readonly List<Cliente> listaClientes = new List<Cliente>();
        private static readonly List<Equipamiento> listaEquipamientos = new List<Equipamiento>();
        private static readonly List<Solicitud> listaSolicitudes = new List<Solicitud>();

        #region Clientes

        public List<Cliente> ListarClientes()
        {
            return listaClientes;
        }

        public Cliente BuscarCliente(int pId)
        {
            foreach (Cliente unCliente in listaClientes)
            {
                if (unCliente.Id == pId)
                {
                    return unCliente;
                }
            }

            return null;
        }

        public bool AltaCliente(Cliente pCliente)
        {
            if (pCliente == null || BuscarCliente(pCliente.Id) != null)
            {
                return false;
            }

            listaClientes.Add(pCliente);
            return true;
        }

        public bool BajaCliente(int pId)
        {
            Cliente clienteAEliminar = BuscarCliente(pId);

            if (clienteAEliminar == null)
            {
                return false;
            }

            listaClientes.Remove(clienteAEliminar);
            return true;
        }

        public bool ModificarCliente(int pId, string pNombre, string pApellido,
            string pDireccion, string pTelefono)
        {
            Cliente clienteAModificar = BuscarCliente(pId);

            if (clienteAModificar == null)
            {
                return false;
            }

            clienteAModificar.Nombre = pNombre;
            clienteAModificar.Apellido = pApellido;
            clienteAModificar.Direccion = pDireccion;
            clienteAModificar.Telefono = pTelefono;
            return true;
        }

        #endregion

        #region Equipamiento

        public List<Equipamiento> ListarEquipamiento()
        {
            return listaEquipamientos;
        }

        public Equipamiento BuscarEquipamiento(int pId)
        {
            foreach (Equipamiento unEquipamiento in listaEquipamientos)
            {
                if (unEquipamiento.Id == pId)
                {
                    return unEquipamiento;
                }
            }

            return null;
        }

        public bool AltaEquipamiento(Equipamiento pEquipamiento)
        {
            if (pEquipamiento == null || BuscarEquipamiento(pEquipamiento.Id) != null)
            {
                return false;
            }

            listaEquipamientos.Add(pEquipamiento);
            return true;
        }

        public bool BajaEquipamiento(int pId)
        {
            Equipamiento equipamientoAEliminar = BuscarEquipamiento(pId);

            if (equipamientoAEliminar == null)
            {
                return false;
            }

            listaEquipamientos.Remove(equipamientoAEliminar);
            return true;
        }

        public bool ModificarEquipamiento(int pId, string pNombre,
            string pDescripcion, decimal pPrecioPorDia)
        {
            Equipamiento equipamientoAModificar = BuscarEquipamiento(pId);

            if (equipamientoAModificar == null)
            {
                return false;
            }

            equipamientoAModificar.Nombre = pNombre;
            equipamientoAModificar.Descripcion = pDescripcion;
            
            return true;
        }

        #endregion
    
    #region Solicitudes

public List<Solicitud> ListarSolicitudes()
{
    return listaSolicitudes;
}

public Solicitud BuscarSolicitud(int pId)
{
    foreach (Solicitud unaSolicitud in listaSolicitudes)
    {
        if (unaSolicitud.Id == pId)
        {
            return unaSolicitud;
        }
    }
    return null;
}

public bool AgregarSolicitud(Solicitud pSolicitud)
{
    if (pSolicitud == null || BuscarSolicitud(pSolicitud.Id) != null)
    {
        return false;
    }
    listaSolicitudes.Add(pSolicitud);
    return true;
}
public void ModificarSolicitud(Solicitud pSolicitud)
{
    Solicitud Solicitud = BuscarSolicitud(pSolicitud.Id);
    if (Solicitud != null)
    {
        Solicitud.Cliente = pSolicitud.Cliente;
        Solicitud.Equipamiento = pSolicitud.Equipamiento;
        Solicitud.FechaSolicitud = pSolicitud.FechaSolicitud;
        Solicitud.FechaInicio = pSolicitud.FechaInicio;
        Solicitud.FechaFin = pSolicitud.FechaFin;
        Solicitud.Estado = pSolicitud.Estado;
    }
}

#endregion

}
}
