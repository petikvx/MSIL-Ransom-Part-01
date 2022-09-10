using System;

namespace WY9_Tray.Tiny.UDP;

public class ProtocolNotSupportedException : Exception
{
	public ProtocolNotSupportedException()
		: base("The protocol selected is not supported.")
	{
	}

	public ProtocolNotSupportedException(string Message)
		: base(Message)
	{
	}
}
