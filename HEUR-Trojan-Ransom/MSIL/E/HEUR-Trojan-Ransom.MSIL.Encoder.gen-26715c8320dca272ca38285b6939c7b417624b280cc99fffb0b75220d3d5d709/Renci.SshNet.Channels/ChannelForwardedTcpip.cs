using System;
using System.Net;
using System.Net.Sockets;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Connection;

namespace Renci.SshNet.Channels;

internal class ChannelForwardedTcpip : ServerChannel, IDisposable, IChannelForwardedTcpip
{
	private readonly object _socketShutdownAndCloseLock = new object();

	private Socket _socket;

	private IForwardedPort _forwardedPort;

	public override ChannelTypes ChannelType => ChannelTypes.ForwardedTcpip;

	internal ChannelForwardedTcpip(ISession session, uint localChannelNumber, uint localWindowSize, uint localPacketSize, uint remoteChannelNumber, uint remoteWindowSize, uint remotePacketSize)
		: base(session, localChannelNumber, localWindowSize, localPacketSize, remoteChannelNumber, remoteWindowSize, remotePacketSize)
	{
	}

	public void Bind(IPEndPoint remoteEndpoint, IForwardedPort forwardedPort)
	{
		if (!base.IsConnected)
		{
			throw new SshException("Session is not connected.");
		}
		_forwardedPort = forwardedPort;
		_forwardedPort.Closing += ForwardedPort_Closing;
		try
		{
			_socket = SocketAbstraction.Connect(remoteEndpoint, base.ConnectionInfo.Timeout);
			SendMessage(new ChannelOpenConfirmationMessage(base.RemoteChannelNumber, base.LocalWindowSize, base.LocalPacketSize, base.LocalChannelNumber));
		}
		catch (Exception ex)
		{
			SendMessage(new ChannelOpenFailureMessage(base.RemoteChannelNumber, ex.ToString(), 2u, "en"));
			throw;
		}
		byte[] array = new byte[base.RemotePacketSize];
		SocketAbstraction.ReadContinuous(_socket, array, 0, array.Length, SendData);
	}

	protected override void OnErrorOccured(Exception exp)
	{
		base.OnErrorOccured(exp);
		ShutdownSocket(SocketShutdown.Send);
	}

	private void ForwardedPort_Closing(object sender, EventArgs e)
	{
		ShutdownSocket(SocketShutdown.Send);
	}

	private void ShutdownSocket(SocketShutdown how)
	{
		if (_socket == null)
		{
			return;
		}
		lock (_socketShutdownAndCloseLock)
		{
			Socket socket = _socket;
			if (socket.IsConnected())
			{
				try
				{
					socket.Shutdown(how);
					return;
				}
				catch (SocketException)
				{
					return;
				}
			}
		}
	}

	private void CloseSocket()
	{
		if (_socket == null)
		{
			return;
		}
		lock (_socketShutdownAndCloseLock)
		{
			Socket socket = _socket;
			if (socket != null)
			{
				_socket = null;
				socket.Dispose();
			}
		}
	}

	protected override void Close()
	{
		IForwardedPort forwardedPort = _forwardedPort;
		if (forwardedPort != null)
		{
			forwardedPort.Closing -= ForwardedPort_Closing;
			_forwardedPort = null;
		}
		ShutdownSocket(SocketShutdown.Send);
		base.Close();
		CloseSocket();
	}

	protected override void OnData(byte[] data)
	{
		base.OnData(data);
		Socket socket = _socket;
		if (socket.IsConnected())
		{
			SocketAbstraction.Send(socket, data, 0, data.Length);
		}
	}
}
