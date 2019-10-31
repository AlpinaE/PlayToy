namespace PlayToy.Models
{
    public class Juguete
    {
        
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Foto { get; set; }
        public List<Pedido> Pedidos {get;set;}

    }
}