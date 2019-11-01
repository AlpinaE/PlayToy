using System;
using System.ComponentModel.DataAnnotations;
using PlayToy_3.Models;

namespace PlayToy.Models
{
    public class Pedido
    {
        
        public int ID { get; set; }

        public DateTime fecha { get; set; }

        public int? IDUsuario { get; set; }
        public Usuario Usuario{get;set;}

        public int? IDJuguete {get; set;}

        public Juguete Juguete{get;set;}
    }
}