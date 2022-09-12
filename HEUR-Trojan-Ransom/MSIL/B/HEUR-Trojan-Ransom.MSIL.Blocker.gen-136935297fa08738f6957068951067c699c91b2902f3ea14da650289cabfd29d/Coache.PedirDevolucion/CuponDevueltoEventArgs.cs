using System;
using Coache.Common;

namespace Coache.PedirDevolucion;

public class CuponDevueltoEventArgs : EventArgs
{
	public string Mensaje { get; set; }

	public CompraCupon CompraCupon { get; set; }
}
