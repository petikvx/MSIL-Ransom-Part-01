using System;

namespace Gecko;

public class JavascriptErrorEventArgs : EventArgs
{
	public string Message { get; protected set; }

	public string Filename { get; protected set; }

	public uint Line { get; protected set; }

	public uint Pos { get; protected set; }

	public ErrorFlags Flags { get; protected set; }

	public uint ErrorNumber { get; protected set; }

	public JavascriptErrorEventArgs(string message, string filename, uint line, uint pos, uint flags, uint errorNumber)
	{
		Message = message;
		Filename = filename;
		Line = line;
		Pos = pos;
		Flags = (ErrorFlags)flags;
		ErrorNumber = errorNumber;
	}
}
