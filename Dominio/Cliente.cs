namespace Obligatorio.Dominio
{
    public class Cliente
    {
        private int aId;
        private string aNombre;
        private string aDocumento;
        private string aEmail;
        private string aTelefono;

        private string aDireccion;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Documento { get { return aDocumento; } set { aDocumento = value; } }
        public string Direccion { get { return aDireccion; } set { aDireccion = value; } }
        public string Telefono { get { return aTelefono; } set { aTelefono = value; } }
        public string Email { get { return aEmail; } set { aEmail = value; } }

        public Cliente(int pId, string pNombre, string pDocumento, string pDireccion, string pTelefono, string pEmail)
        {
            aId = pId;
            aNombre = pNombre;
            aDocumento = pDocumento;
            aEmail = pEmail;
            aTelefono = pTelefono;
            aDireccion = pDireccion;
        }
    }
}
