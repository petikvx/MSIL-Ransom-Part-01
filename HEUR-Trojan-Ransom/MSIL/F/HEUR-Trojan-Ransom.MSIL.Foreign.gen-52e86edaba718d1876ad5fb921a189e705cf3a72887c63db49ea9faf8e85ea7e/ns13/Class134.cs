using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using MySql.Data.Common;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns15;
using ns21;
using ns24;
using ns26;

namespace ns13;

internal sealed class Class134
{
	private readonly string string_0;

	private uint uint_0;

	private string string_1;

	private uint uint_1;

	private Struct23 struct23_0;

	[NonSerialized]
	internal static GetString getString_0;

	public Class134(string string_2, uint uint_2, string string_3, uint uint_3, Struct23 struct23_1)
	{
		string_0 = string_2;
		if (string.IsNullOrEmpty(string_0))
		{
			string_0 = getString_0(107409757);
		}
		uint_0 = uint_2;
		string_1 = string_3;
		uint_1 = uint_3;
		struct23_0 = struct23_1;
	}

	public static Stream smethod_0(string string_2, uint uint_2, string string_3, uint uint_3, Struct23 struct23_1, uint uint_4)
	{
		return smethod_1(new MySqlConnectionStringBuilder
		{
			Server = string_2,
			Port = uint_2,
			PipeName = string_3,
			Keepalive = uint_3,
			ConnectionTimeout = uint_4
		});
	}

	public static Stream smethod_1(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0)
	{
		return mySqlConnectionStringBuilder_0.ConnectionProtocol switch
		{
			Enum41.const_0 => smethod_2(mySqlConnectionStringBuilder_0), 
			Enum41.const_3 => smethod_6(mySqlConnectionStringBuilder_0), 
			Enum41.const_5 => smethod_3(mySqlConnectionStringBuilder_0), 
			Enum41.const_7 => smethod_5(mySqlConnectionStringBuilder_0), 
			_ => throw new InvalidOperationException(Class121.UnknownConnectionProtocol), 
		};
	}

	private static Stream smethod_2(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0)
	{
		TcpClient tcpClient = new TcpClient(AddressFamily.InterNetwork);
		if (!tcpClient.ConnectAsync(mySqlConnectionStringBuilder_0.Server, (int)mySqlConnectionStringBuilder_0.Port).Wait((int)(mySqlConnectionStringBuilder_0.ConnectionTimeout * 1000)))
		{
			throw new MySqlException(Class121.Timeout);
		}
		if (mySqlConnectionStringBuilder_0.Keepalive != 0)
		{
			smethod_7(tcpClient.Client, mySqlConnectionStringBuilder_0.Keepalive);
		}
		return tcpClient.GetStream();
	}

	internal static Stream smethod_3(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0)
	{
		try
		{
			return new NetworkStream(smethod_4(mySqlConnectionStringBuilder_0), ownsSocket: true);
		}
		catch (Exception)
		{
			throw;
		}
	}

	internal static Socket smethod_4(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0)
	{
		if (Class131.smethod_0())
		{
			throw new InvalidOperationException(Class121.NoUnixSocketsOnWindows);
		}
		EndPoint remoteEP = new UnixEndPoint(mySqlConnectionStringBuilder_0.Server);
		Socket socket = new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.IP);
		if (mySqlConnectionStringBuilder_0.Keepalive != 0)
		{
			smethod_7(socket, mySqlConnectionStringBuilder_0.Keepalive);
		}
		try
		{
			socket.ReceiveTimeout = (int)(mySqlConnectionStringBuilder_0.ConnectionTimeout * 1000);
			socket.Connect(remoteEP);
			return socket;
		}
		catch (Exception)
		{
			socket.Dispose();
			throw;
		}
	}

	private static Stream smethod_5(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0)
	{
		Stream1 stream = new Stream1(mySqlConnectionStringBuilder_0.SharedMemoryName);
		stream.method_0(mySqlConnectionStringBuilder_0.ConnectionTimeout);
		return stream;
	}

	private static Stream smethod_6(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0)
	{
		return Stream4.smethod_0(mySqlConnectionStringBuilder_0.PipeName, mySqlConnectionStringBuilder_0.Server, mySqlConnectionStringBuilder_0.ConnectionTimeout);
	}

	internal static void smethod_7(Socket socket_0, uint uint_2)
	{
		uint value = 1000u;
		uint value2 = ((uint_2 <= 4294967) ? (uint_2 * 1000) : uint.MaxValue);
		byte[] array = new byte[12];
		BitConverter.GetBytes(1u).CopyTo(array, 0);
		BitConverter.GetBytes(value2).CopyTo(array, 4);
		BitConverter.GetBytes(value).CopyTo(array, 8);
		try
		{
			socket_0.IOControl(IOControlCode.KeepAliveValues, array, null);
			return;
		}
		catch (NotImplementedException)
		{
		}
		socket_0.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, 1);
	}

	static Class134()
	{
		Strings.CreateGetStringDelegate(typeof(Class134));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398204), getString_0(107398199)).Replace(getString_0(107398162), getString_0(107398157)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398152)))
		{
			throw new SecurityException(getString_0(107398127));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_2, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
