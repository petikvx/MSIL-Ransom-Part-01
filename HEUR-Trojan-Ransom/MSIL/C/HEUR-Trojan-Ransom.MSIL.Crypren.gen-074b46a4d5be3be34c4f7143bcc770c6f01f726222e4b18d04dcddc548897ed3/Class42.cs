using System;
using System.Diagnostics;

internal class Class42 : TraceListener
{
	public override void Write(string Message)
	{
		Write(Message, "");
	}

	public override void Write(string Message, string Category)
	{
		Console.Write(Class86.smethod_0("\uef2b\uef45", 61297) + Category + Class86.smethod_0("\uebe7\uebfd", 60189) + Message);
	}

	public override void WriteLine(string Message)
	{
		Write(Message + Class86.smethod_0("\ue0b1", 57386));
	}

	public override void WriteLine(string Message, string Category)
	{
		Write(Message + Class86.smethod_0("\ue0b1", 57386), Category);
	}
}
