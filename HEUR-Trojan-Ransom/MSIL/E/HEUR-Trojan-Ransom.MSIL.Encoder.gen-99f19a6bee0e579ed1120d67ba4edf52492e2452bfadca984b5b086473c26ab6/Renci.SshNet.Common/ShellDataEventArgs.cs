using System;

namespace Renci.SshNet.Common;

public class ShellDataEventArgs : EventArgs
{
	public byte[] Data { get; private set; }

	public string Line { get; private set; }

	public ShellDataEventArgs(byte[] data)
	{
		Data = data;
	}

	public ShellDataEventArgs(string line)
	{
		Line = line;
	}
}
