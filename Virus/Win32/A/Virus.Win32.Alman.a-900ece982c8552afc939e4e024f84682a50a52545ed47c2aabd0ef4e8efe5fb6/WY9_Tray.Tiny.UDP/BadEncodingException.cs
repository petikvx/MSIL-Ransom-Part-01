using System;

namespace WY9_Tray.Tiny.UDP;

public class BadEncodingException : Exception
{
	public BadEncodingException()
		: base("The encoding type selected is not valid.")
	{
	}

	public BadEncodingException(string Message)
		: base(Message)
	{
	}
}
