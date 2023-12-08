namespace ProyectoFinalECommerce.DTO
{
    public class CarritoComprasNuevoDTO
    {
        public int ProductoNuevoId { get; set; }

        public decimal Cantidad { get; set; } = 1;

        public string Observaciones { get; set; } = string.Empty;
    }
}
