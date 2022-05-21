using System;
namespace ManejoDeArchivoWeb.Models;

	public class PedidoCompra
	{
    public string? CodigoCompra { get; set; }
    public string? NombreProveedor { get; set; }
    public DateTime FechaCompra { get; set; }
    public List<LineaPedidoCompra>? Lineas { get; set; }

    }

