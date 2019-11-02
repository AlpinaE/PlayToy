using System.Collections.Generic;
using PlayToy.Controllers;

namespace PlayToy.Models
{
    public class Juguete
    {
        
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Foto { get; set; }
        public string Categoria{get;set;}
        public List<Pedido> Pedidos {get;set;}
        
    }
}