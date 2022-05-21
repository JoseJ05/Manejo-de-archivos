using System;
namespace ManejoDeArchivoWeb.Models;

	public class PedidoVenta
	{
		public string? CodigoVenta { get; set; }
		public string? NombreCliente { get; set; }
		public DateTime FechaVenta { get; set; }
		public List<LineasPedidoVenta>? Lineas { get; set; }
	}

