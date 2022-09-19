using System;

namespace TreehouseDefense;

internal class TreehouseDefenseException : Exception
{
	public TreehouseDefenseException()
	{
	}

	public TreehouseDefenseException(string message)
		: base(message)
	{
	}
}
