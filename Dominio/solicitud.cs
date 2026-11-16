namespace Obligatorio.Dominio                             
{
    public class Solicitud
    {
        private int aId;
        private Cliente aCliente; 
        private Equipamiento aEquipamiento;
        private string aFecha;

        public int Id { get { return aId; } set { aId = value; } }
        public Cliente Cliente { get { return aCliente; } set { aCliente = value; } }
        public Equipamiento Equipamiento { get { return aEquipamiento; } set { aEquipamiento = value; } }
        public string Fecha { get { return aFecha; } set { aFecha = value; } }

        public Solicitud(int pId, Cliente pCliente, Equipamiento pEquipamiento, string pFecha)
        {
            aId = pId;
            aCliente = pCliente;
            aEquipamiento = pEquipamiento;
            aFecha = pFecha;
        }
    }
}