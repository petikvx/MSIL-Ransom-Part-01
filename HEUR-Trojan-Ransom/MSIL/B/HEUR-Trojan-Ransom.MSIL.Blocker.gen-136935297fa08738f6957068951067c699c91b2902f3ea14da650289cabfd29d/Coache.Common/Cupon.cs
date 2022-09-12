using System;
using System.Collections.Generic;

namespace Coache.Common;

public class Cupon
{
	public int ID { get; set; }

	public string Descripcion { get; set; }

	public string Codigo { get; set; }

	public DateTime FechaPublicacion { get; set; }

	public DateTime FechaVencimientoOferta { get; set; }

	public DateTime FechaVencimientoConsumo { get; set; }

	public double PrecioOriginal { get; set; }

	public double Precio { get; set; }

	public Proveedor Proveedor { get; set; }

	public int Cantidad { get; set; }

	public int CantidadPorUsuario { get; set; }

	public List<City> Ciudades { get; set; }

	public bool Publicado { get; set; }
}
