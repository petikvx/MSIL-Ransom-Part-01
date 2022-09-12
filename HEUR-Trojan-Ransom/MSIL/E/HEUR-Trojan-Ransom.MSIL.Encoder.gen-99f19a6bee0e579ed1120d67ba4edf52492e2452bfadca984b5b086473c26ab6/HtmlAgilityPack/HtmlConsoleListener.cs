using System;
using System.Diagnostics;

namespace HtmlAgilityPack;

internal class HtmlConsoleListener : TraceListener
{
	public override void Write(string Message)
	{
		Write(Message, "");
	}

	public override void Write(string Message, string Category)
	{
		Console.Write("T:" + Category + ": " + Message);
	}

	public override void WriteLine(string Message)
	{
		Write(Message + "\n");
	}

	public override void WriteLine(string Message, string Category)
	{
		Write(Message + "\n", Category);
	}
}
