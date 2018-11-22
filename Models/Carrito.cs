using System;

namespace  Razor_Page.Models
{
    public class Carrito
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }

    }
}