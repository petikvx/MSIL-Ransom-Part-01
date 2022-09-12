using System;

namespace Coache.Common;

public class CompraCupon
{
	public int ID { get; set; }

	public string Descripcion { get; set; }

	public string Codigo { get; set; }

	public string Estado { get; set; }

	public string Cliente { get; set; }

	public double Precio { get; set; }

	public DateTime Fecha { get; set; }

	public DateTime FechaVencimiento { get; set; }
}
