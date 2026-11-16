using Obligatorio.Dominio;

namespace Obligatorio.Dominio
{
    public class Controladora
    {
        private static List<Cliente> aListaClientes = new List<Cliente>();


        #region Clientes

        public List<Cliente> ListarClientes()
        {
            return aListaClientes;
        }
        public Cliente BuscarCliente(int pId)
        {
            foreach (Cliente unCliente in aListaClientes)
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
            Cliente ComparoCliente = BuscarCliente(pCliente.Id);
            if (ComparoCliente == null)
            {
                aListaClientes.Add(pCliente);
                return true;
            }
            return false;
        }
        public bool BajaCliente(int pId)
        {
            Cliente ClienteAEliminar = BuscarCliente(pId);
            if (ClienteAEliminar != null)
            {
                aListaClientes.Remove(ClienteAEliminar);
                return true;
            }
            return false;
        }
        public bool ModificarCliente(int pId, string pNombre, string pDocumento, string pDireccion, string pTelefono, string pEmail)
        {
            Cliente ClienteAModificar = BuscarCliente(pId);
            if (ClienteAModificar != null)
            {
                ClienteAModificar.Nombre = pNombre;
                ClienteAModificar.Documento = pDocumento;
                ClienteAModificar.Email = pEmail;
                ClienteAModificar.Telefono = pTelefono;
                ClienteAModificar.Direccion = pDireccion;
                
                
                return true;
            }
            return false;
        }
        #endregion
        
        

        
}
}
