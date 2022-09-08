using System;

namespace Orcus.Plugins;

public class CommandLoadedEventArgs : EventArgs
{
	public Type NewCommandType { get; }

	public CommandLoadedEventArgs(Type newCommandType)
	{
		NewCommandType = newCommandType;
	}
}
