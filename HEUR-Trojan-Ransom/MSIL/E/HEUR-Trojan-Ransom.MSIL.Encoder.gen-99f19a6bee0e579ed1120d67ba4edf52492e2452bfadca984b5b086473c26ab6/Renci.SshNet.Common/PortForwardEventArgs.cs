using System;

namespace Renci.SshNet.Common;

public class PortForwardEventArgs : EventArgs
{
	public string OriginatorHost { get; private set; }

	public uint OriginatorPort { get; private set; }

	internal PortForwardEventArgs(string host, uint port)
	{
		if (host == null)
		{
			throw new ArgumentNullException("host");
		}
		port.ValidatePort("port");
		OriginatorHost = host;
		OriginatorPort = port;
	}
}
