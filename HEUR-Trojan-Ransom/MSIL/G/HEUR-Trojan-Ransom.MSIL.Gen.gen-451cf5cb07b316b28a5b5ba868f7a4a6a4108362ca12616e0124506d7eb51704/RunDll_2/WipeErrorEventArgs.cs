using System;

namespace RunDll_2;

public class WipeErrorEventArgs : EventArgs
{
	private readonly Exception e;

	public Exception WipeError => e;

	public WipeErrorEventArgs(Exception error)
	{
		e = error;
	}
}
