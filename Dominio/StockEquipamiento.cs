namespace Obligatorio.Dominio
{
    public class StockEquipamiento
    {
        public int Id { get; set; }
        public int CantidadTotal { get; set; }
        public int CantidadDisponible { get; set; }

        public int EquipamientoId { get; set; }
        public Equipamiento Equipamiento { get; set; }

        public void ActualizarStock(int cantidad)
        {
            CantidadTotal += cantidad;
            CantidadDisponible += cantidad;
        }
    }
}
