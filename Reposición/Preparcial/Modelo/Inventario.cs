﻿namespace Preparcial.Modelo
{
    public class Inventario
    {
        public string idArticulo { get; }//
        public string producto { get; }//
        public string descripcion { get; }//Corrección: Se convirtió los atributos a públicos
        public string precio { get; }//
        public string stock { get; }//

        public Inventario(string idArticulo, string producto, string descripcion, string precio, string stock)
        {
            this.idArticulo = idArticulo;
            this.producto = producto;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
