namespace Obligatorio.Dominio
{
    public class Equipamiento
    {
        private int aId;
        private string aNombre;
        private string aDescripcion;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Descripcion { get { return aDescripcion; } set { aDescripcion = value; } }

        public Equipamiento(int pId, string pNombre, string pDescripcion)
        {
            aId = pId;
            aNombre = pNombre;
            aDescripcion = pDescripcion;
        }
    }
}