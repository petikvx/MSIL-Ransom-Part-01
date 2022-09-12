using System;
using Coache.Common;

namespace Coache.CargaCredito;

public class PagoAddedEventArgs : EventArgs
{
	public Pago Pago { get; set; }
}
