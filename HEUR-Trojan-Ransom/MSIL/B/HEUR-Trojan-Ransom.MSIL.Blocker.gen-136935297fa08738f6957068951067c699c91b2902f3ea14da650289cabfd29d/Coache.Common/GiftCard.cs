using System;

namespace Coache.Common;

public class GiftCard
{
	public Cliente ClienteOrigen { get; set; }

	public Cliente ClienteDestino { get; set; }

	public DateTime Fecha { get; set; }

	public double Credito { get; set; }
}
