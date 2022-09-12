using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Common;

namespace MySql.Data.Common;

internal class StreamCreator
{
	private readonly string _hostList;

	private uint _port;

	private string pipeName;

	private uint keepalive;

	private DBVersion driverVersion;

	public StreamCreator(string hosts, uint port, string pipeName, uint keepalive, DBVersion driverVersion)
	{
		_hostList = hosts;
		if (string.IsNullOrEmpty(_hostList))
		{
			_hostList = "localhost";
		}
		_port = port;
		this.pipeName = pipeName;
		this.keepalive = keepalive;
		this.driverVersion = driverVersion;
	}

	public static Stream GetStream(string server, uint port, string pipename, uint keepalive, DBVersion v, uint timeout)
	{
		return GetStream(new MySqlConnectionStringBuilder
		{
			Server = server,
			Port = port,
			PipeName = pipename,
			Keepalive = keepalive,
			ConnectionTimeout = timeout
		});
	}

	public static Stream GetStream(MySqlConnectionStringBuilder settings)
	{
		return settings.ConnectionProtocol switch
		{
			MySqlConnectionProtocol.Sockets => GetTcpStream(settings), 
			MySqlConnectionProtocol.Pipe => GetNamedPipeStream(settings), 
			MySqlConnectionProtocol.UnixSocket => GetUnixSocketStream(settings), 
			MySqlConnectionProtocol.SharedMemory => GetSharedMemoryStream(settings), 
			_ => throw new InvalidOperationException(Resources.UnknownConnectionProtocol), 
		};
	}

	private static Stream GetTcpStream(MySqlConnectionStringBuilder settings)
	{
		TcpClient tcpClient = new TcpClient(AddressFamily.InterNetwork);
		if (!tcpClient.ConnectAsync(settings.Server, (int)settings.Port).Wait((int)(settings.ConnectionTimeout * 1000)))
		{
			throw new MySqlException(Resources.Timeout);
		}
		if (settings.Keepalive != 0)
		{
			SetKeepAlive(tcpClient.Client, settings.Keepalive);
		}
		return tcpClient.GetStream();
	}

	internal static Stream GetUnixSocketStream(MySqlConnectionStringBuilder settings)
	{
		try
		{
			return new NetworkStream(GetUnixSocket(settings.Server, settings.ConnectionTimeout, settings.Keepalive), ownsSocket: true);
		}
		catch (Exception)
		{
			throw;
		}
	}

	internal static Socket GetUnixSocket(string server, uint connectionTimeout, uint keepAlive)
	{
		if (Platform.IsWindows())
		{
			throw new InvalidOperationException(Resources.NoUnixSocketsOnWindows);
		}
		EndPoint remoteEP = new UnixEndPoint(server);
		Socket socket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.IP);
		if (keepAlive != 0)
		{
			SetKeepAlive(socket, keepAlive);
		}
		try
		{
			socket.ReceiveTimeout = (int)(connectionTimeout * 1000);
			socket.Connect(remoteEP);
			return socket;
		}
		catch (Exception)
		{
			socket.Dispose();
			throw;
		}
	}

	private static Stream GetSharedMemoryStream(MySqlConnectionStringBuilder settings)
	{
		SharedMemoryStream sharedMemoryStream = new SharedMemoryStream(settings.SharedMemoryName);
		sharedMemoryStream.Open(settings.ConnectionTimeout);
		return sharedMemoryStream;
	}

	private static Stream GetNamedPipeStream(MySqlConnectionStringBuilder settings)
	{
		return NamedPipeStream.Create(settings.PipeName, settings.Server, settings.ConnectionTimeout);
	}

	internal static void SetKeepAlive(Socket s, uint time)
	{
		uint value = 1000u;
		uint value2 = ((time <= 4294967) ? (time * 1000) : uint.MaxValue);
		byte[] array = new byte[12];
		BitConverter.GetBytes(1u).CopyTo(array, 0);
		BitConverter.GetBytes(value2).CopyTo(array, 4);
		BitConverter.GetBytes(value).CopyTo(array, 8);
		try
		{
			s.IOControl(IOControlCode.KeepAliveValues, array, null);
			return;
		}
		catch (NotImplementedException)
		{
		}
		s.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, 1);
	}
}
