using System;
using Coache.Common;

namespace Coache.ArmarCupon;

public class CuponSavedEventArgs : EventArgs
{
	public Cupon Cupon { get; set; }
}
