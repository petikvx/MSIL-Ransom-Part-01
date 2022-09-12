using System;
using Coache.Common;

namespace Coache.AbmRol;

public class RoleUpdatedEventArgs : EventArgs
{
	public Rol Rol { get; set; }
}
