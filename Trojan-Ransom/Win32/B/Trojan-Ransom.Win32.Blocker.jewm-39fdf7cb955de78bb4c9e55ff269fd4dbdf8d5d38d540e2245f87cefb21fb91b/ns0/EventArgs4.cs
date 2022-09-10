using System;
using System.Diagnostics;

namespace ns0;

internal class EventArgs4 : EventArgs
{
	internal Process process_0;

	internal Exception exception_0;

	internal bool bool_0 = true;

	public Process Process_0 => process_0;

	public Exception Exception_0 => exception_0;

	public bool Boolean_0
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
		}
	}

	internal EventArgs4(Process process_1, Exception exception_1)
	{
		process_0 = process_1;
		exception_0 = exception_1;
	}
}
