using System;

namespace Razor_Page.Models
{
    public class Imagen
    {
        public int Id { get; set; }
        public byte[] ImagenArray { get; set; }
        public char Activo { get; set; }
    }
}