using System.Collections.Generic;
using Orcus.Plugins;

namespace Orcus.CommandManagement;

public class CommandComparer : IEqualityComparer<Command>
{
	public bool Equals(Command x, Command y)
	{
		return x.get_Identifier() == y.get_Identifier();
	}

	public int GetHashCode(Command obj)
	{
		return (int)obj.get_Identifier();
	}
}
