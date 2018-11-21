using System;
using Razor_Page.Models;


namespace Razor_Page.Models
{
    public class TipoProducto
    {
        public int Id { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int UsuarioId {get; set;}
        public virtual Producto Producto { get; set; }
        public int ProductoId {get; set;}
        public int Cantidad { get; set; }
        public float Precio { get; set; }
    }
}