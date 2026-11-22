namespace Obligatorio.Dominio
{
    public class Solicitud
    {
        private int aId;
        private Cliente aCliente;
        private Equipamiento aEquipamiento;
        private string aFechaSolicitud;
        private string aFechaInicio;
        private string aFechaFin;
        private string aEstado;

        public int Id { get { return aId; } set { aId = value; } }
        public Cliente Cliente { get { return aCliente; } set { aCliente = value; } }
        public Equipamiento Equipamiento { get { return aEquipamiento; } set { aEquipamiento = value; } }
        public string FechaSolicitud { get { return aFechaSolicitud; } set { aFechaSolicitud = value; } }
        public string FechaInicio { get { return aFechaInicio; } set { aFechaInicio = value; } }
        public string FechaFin { get { return aFechaFin; } set { aFechaFin = value; } }
        public string Estado { get { return aEstado; } set { aEstado = value; } }

        public Solicitud(int pId, Cliente pCliente, Equipamiento pEquipamiento, string pFechaSolicitud, string pFechaInicio, string pFechaFin, string pEstado)
        {
            aId = pId;
            aCliente = pCliente;
            aEquipamiento = pEquipamiento;
            aFechaSolicitud = pFechaSolicitud;
            aFechaInicio = pFechaInicio;
            aFechaFin = pFechaFin;
            aEstado = pEstado;
        }
    }
}
