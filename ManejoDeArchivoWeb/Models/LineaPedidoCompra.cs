using System;
namespace ManejoDeArchivoWeb.Models;

	public class LineaPedidoCompra
	{
    public int CodigoProducto { get; set; }
    public string? Nombre { get; set; }
    public string? Almacen { get; set; }
    public string? Color { get; set; }
    public string? Talla { get; set; }
    public string? Estilo { get; set; }
    public decimal CantidadCompra { get; set; }
    public string? UnidadCompra { get; set; }
}

