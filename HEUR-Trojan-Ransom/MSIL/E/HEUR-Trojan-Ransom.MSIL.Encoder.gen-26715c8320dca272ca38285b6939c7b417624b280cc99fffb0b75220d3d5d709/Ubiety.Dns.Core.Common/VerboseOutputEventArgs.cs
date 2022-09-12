using System;

namespace Ubiety.Dns.Core.Common;

public class VerboseOutputEventArgs : EventArgs
{
	public string Message { get; }

	public VerboseOutputEventArgs(string message)
	{
		Message = message;
	}
}
