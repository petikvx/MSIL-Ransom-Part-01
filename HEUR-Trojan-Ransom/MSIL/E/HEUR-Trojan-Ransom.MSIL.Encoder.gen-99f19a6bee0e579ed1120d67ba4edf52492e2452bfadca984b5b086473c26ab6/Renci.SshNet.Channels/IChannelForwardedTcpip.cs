using System;
using System.Net;
using Renci.SshNet.Common;

namespace Renci.SshNet.Channels;

internal interface IChannelForwardedTcpip : IDisposable
{
	event EventHandler<ExceptionEventArgs> Exception;

	void Bind(IPEndPoint remoteEndpoint, IForwardedPort forwardedPort);
}
