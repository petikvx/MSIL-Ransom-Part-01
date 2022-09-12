using System;

namespace Ubiety.Dns.Core.Common;

public class VerboseEventArgs : EventArgs
{
	public string Message { get; set; }

	public VerboseEventArgs(string message)
	{
		Message = message;
	}
}
