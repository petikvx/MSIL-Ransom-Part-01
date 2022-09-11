using System;
using System.Diagnostics;
using rifhadhsva.My.Resources;

namespace rifhadhsva;

public class Class1
{
	[DebuggerNonUserCode]
	public Class1()
	{
	}

	public byte[] getWind()
	{
		string text = Environment.OSVersion.ToString();
		if (text.Contains("6.2") | text.Contains("6.3"))
		{
			return Resources.rnthiavesa8;
		}
		return Resources.rnthiavesa7;
	}
}
