using System;
using System.Net.Sockets;
using Renci.SshNet.Common;

namespace Renci.SshNet.Channels;

internal interface IChannelDirectTcpip : IDisposable
{
	bool IsOpen { get; }

	uint LocalChannelNumber { get; }

	event EventHandler<ExceptionEventArgs> Exception;

	void Open(string remoteHost, uint port, IForwardedPort forwardedPort, Socket socket);

	void Bind();
}
