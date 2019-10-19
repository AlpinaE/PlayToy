using System;
using System.ComponentModel.DataAnnotations;

namespace PlayToy_3.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApePat { get; set; }
        public string ApeMat { get; set; }
        public DateTime FecNac { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    }
}