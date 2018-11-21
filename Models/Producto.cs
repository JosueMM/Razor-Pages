using System;
using Razor_Page.Models;



namespace Razor_Page.Models
{
    public class Producto
    {
        
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public char Activo { get; set; }
        public virtual TipoProducto tipo  { get; set; }
        public int TipoProductoId {get; set;}
        public virtual Imagen Imagen { get; set; }
        public int ImagenId {get; set;}
    
    }
}