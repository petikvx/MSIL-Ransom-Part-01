using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Renci.SshNet.Abstractions;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Connection;

namespace Renci.SshNet.Channels;

internal class ChannelDirectTcpip : ClientChannel, IDisposable, IChannelDirectTcpip
{
	private readonly object _socketLock = new object();

	private EventWaitHandle _channelOpen = new AutoResetEvent(initialState: false);

	private EventWaitHandle _channelData = new AutoResetEvent(initialState: false);

	private IForwardedPort _forwardedPort;

	private Socket _socket;

	public override ChannelTypes ChannelType => ChannelTypes.DirectTcpip;

	public ChannelDirectTcpip(ISession session, uint localChannelNumber, uint localWindowSize, uint localPacketSize)
		: base(session, localChannelNumber, localWindowSize, localPacketSize)
	{
	}

	public void Open(string remoteHost, uint port, IForwardedPort forwardedPort, Socket socket)
	{
		if (base.IsOpen)
		{
			throw new SshException("Channel is already open.");
		}
		if (!base.IsConnected)
		{
			throw new SshException("Session is not connected.");
		}
		_socket = socket;
		_forwardedPort = forwardedPort;
		_forwardedPort.Closing += ForwardedPort_Closing;
		IPEndPoint iPEndPoint = (IPEndPoint)socket.RemoteEndPoint;
		SendMessage(new ChannelOpenMessage(base.LocalChannelNumber, base.LocalWindowSize, base.LocalPacketSize, new DirectTcpipChannelInfo(remoteHost, port, iPEndPoint.Address.ToString(), (uint)iPEndPoint.Port)));
		WaitOnHandle(_channelOpen);
	}

	private void ForwardedPort_Closing(object sender, EventArgs e)
	{
		ShutdownSocket(SocketShutdown.Send);
		CloseSocket();
	}

	public void Bind()
	{
		if (base.IsOpen)
		{
			byte[] array = new byte[base.RemotePacketSize];
			SocketAbstraction.ReadContinuous(_socket, array, 0, array.Length, SendData);
		}
	}

	private void CloseSocket()
	{
		if (_socket == null)
		{
			return;
		}
		lock (_socketLock)
		{
			if (_socket != null)
			{
				_socket.Dispose();
				_socket = null;
			}
		}
	}

	private void ShutdownSocket(SocketShutdown how)
	{
		if (_socket == null)
		{
			return;
		}
		lock (_socketLock)
		{
			if (_socket.IsConnected())
			{
				try
				{
					_socket.Shutdown(how);
					return;
				}
				catch (SocketException)
				{
					return;
				}
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
		if (_socket == null)
		{
			return;
		}
		lock (_socketLock)
		{
			if (_socket.IsConnected())
			{
				SocketAbstraction.Send(_socket, data, 0, data.Length);
			}
		}
	}

	protected override void OnOpenConfirmation(uint remoteChannelNumber, uint initialWindowSize, uint maximumPacketSize)
	{
		base.OnOpenConfirmation(remoteChannelNumber, initialWindowSize, maximumPacketSize);
		_channelOpen.Set();
	}

	protected override void OnOpenFailure(uint reasonCode, string description, string language)
	{
		base.OnOpenFailure(reasonCode, description, language);
		_channelOpen.Set();
	}

	protected override void OnEof()
	{
		base.OnEof();
		ShutdownSocket(SocketShutdown.Send);
	}

	protected override void OnErrorOccured(Exception exp)
	{
		base.OnErrorOccured(exp);
		ShutdownSocket(SocketShutdown.Send);
	}

	protected override void OnDisconnected()
	{
		base.OnDisconnected();
		ShutdownSocket(SocketShutdown.Both);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (!disposing)
		{
			return;
		}
		if (_socket != null)
		{
			lock (_socketLock)
			{
				Socket socket = _socket;
				if (socket != null)
				{
					_socket = null;
					socket.Dispose();
				}
			}
		}
		EventWaitHandle channelOpen = _channelOpen;
		if (channelOpen != null)
		{
			_channelOpen = null;
			channelOpen.Dispose();
		}
		EventWaitHandle channelData = _channelData;
		if (channelData != null)
		{
			_channelData = null;
			channelData.Dispose();
		}
	}
}
