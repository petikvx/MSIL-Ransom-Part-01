using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ns13;

namespace ns25;

internal sealed class Stream0 : NetworkStream
{
	private readonly Socket socket_0;

	public Stream0(Socket socket_1, bool bool_0)
		: base(socket_1, bool_0)
	{
		socket_0 = socket_1;
	}

	private static bool smethod_0(SocketException socketException_0)
	{
		return socketException_0.SocketErrorCode == SocketError.TimedOut;
	}

	private static bool smethod_1(SocketException socketException_0)
	{
		return socketException_0.SocketErrorCode == SocketError.WouldBlock;
	}

	private void method_0(Exception exception_0)
	{
		Exception ex = exception_0;
		while (true)
		{
			if (ex != null)
			{
				if (ex is SocketException)
				{
					SocketException socketException_ = (SocketException)ex;
					if (smethod_1(socketException_))
					{
						socket_0.Blocking = true;
						break;
					}
					if (smethod_0(socketException_))
					{
						break;
					}
				}
				ex = ex.InnerException;
				continue;
			}
			throw exception_0;
		}
	}

	int NetworkStream.Read(byte[] buffer, int offset, int size)
	{
		int num = 0;
		Exception ex = null;
		do
		{
			try
			{
				return Read(buffer, offset, size);
			}
			catch (Exception ex2)
			{
				ex = ex2;
				method_0(ex2);
			}
		}
		while (++num < 2);
		if (ex.GetBaseException() is SocketException && smethod_0((SocketException)ex.GetBaseException()))
		{
			throw new TimeoutException(ex.Message, ex);
		}
		throw ex;
	}

	int Stream.ReadByte()
	{
		int num = 0;
		Exception ex = null;
		do
		{
			try
			{
				return ((Stream)this).ReadByte();
			}
			catch (Exception ex2)
			{
				ex = ex2;
				method_0(ex2);
			}
		}
		while (++num < 2);
		throw ex;
	}

	void NetworkStream.Write(byte[] buffer, int offset, int size)
	{
		int num = 0;
		Exception ex = null;
		do
		{
			try
			{
				Write(buffer, offset, size);
				return;
			}
			catch (Exception ex2)
			{
				ex = ex2;
				method_0(ex2);
			}
		}
		while (++num < 2);
		throw ex;
	}

	void NetworkStream.Flush()
	{
		int num = 0;
		Exception ex = null;
		do
		{
			try
			{
				Flush();
				return;
			}
			catch (Exception ex2)
			{
				ex = ex2;
				method_0(ex2);
			}
		}
		while (++num < 2);
		throw ex;
	}

	public static Stream0 smethod_2(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, bool bool_0)
	{
		if (bool_0)
		{
			return new Stream0(Class134.smethod_4(mySqlConnectionStringBuilder_0), bool_0: true);
		}
		Stream0 stream = null;
		IPAddress[] addressList = smethod_4(mySqlConnectionStringBuilder_0.Server).AddressList;
		foreach (IPAddress ipaddress_ in addressList)
		{
			try
			{
				stream = smethod_5(mySqlConnectionStringBuilder_0, ipaddress_, bool_0);
				if (stream == null)
				{
					continue;
				}
				return stream;
			}
			catch (Exception ex)
			{
				SocketException obj = ex as SocketException;
				if (obj == null)
				{
					throw;
				}
				if (obj.SocketErrorCode != SocketError.ConnectionRefused)
				{
					throw;
				}
			}
		}
		return stream;
	}

	private static IPHostEntry smethod_3(string string_0)
	{
		IPHostEntry iPHostEntry = null;
		if (IPAddress.TryParse(string_0, out var address))
		{
			iPHostEntry = new IPHostEntry();
			iPHostEntry.AddressList = new IPAddress[1];
			iPHostEntry.AddressList[0] = address;
		}
		return iPHostEntry;
	}

	private static IPHostEntry smethod_4(string string_0)
	{
		IPHostEntry iPHostEntry = smethod_3(string_0);
		if (iPHostEntry != null)
		{
			return iPHostEntry;
		}
		Task<IPHostEntry> hostEntryAsync = Dns.GetHostEntryAsync(string_0);
		hostEntryAsync.Wait();
		return hostEntryAsync.Result;
	}

	private static Stream0 smethod_5(MySqlConnectionStringBuilder mySqlConnectionStringBuilder_0, IPAddress ipaddress_0, bool bool_0)
	{
		EndPoint remoteEP = new IPEndPoint(ipaddress_0, (int)mySqlConnectionStringBuilder_0.Port);
		Socket socket = (bool_0 ? new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.IP) : new Socket(ipaddress_0.AddressFamily, SocketType.Stream, ProtocolType.Tcp));
		socket.NoDelay = true;
		if (mySqlConnectionStringBuilder_0.Keepalive != 0)
		{
			smethod_6(socket, mySqlConnectionStringBuilder_0.Keepalive);
		}
		IAsyncResult asyncResult = socket.BeginConnect(remoteEP, null, null);
		if (!asyncResult.AsyncWaitHandle.WaitOne((int)(mySqlConnectionStringBuilder_0.ConnectionTimeout * 1000), exitContext: false))
		{
			socket.Close();
		}
		try
		{
			socket.EndConnect(asyncResult);
		}
		catch (Exception)
		{
			socket.Close();
			throw;
		}
		Stream0 stream = new Stream0(socket, bool_0: true);
		GC.SuppressFinalize(socket);
		GC.SuppressFinalize(stream);
		return stream;
	}

	private static void smethod_6(Socket socket_1, uint uint_0)
	{
		uint value = 1000u;
		uint value2 = ((uint_0 <= 4294967) ? (uint_0 * 1000) : uint.MaxValue);
		byte[] array = new byte[12];
		BitConverter.GetBytes(1u).CopyTo(array, 0);
		BitConverter.GetBytes(value2).CopyTo(array, 4);
		BitConverter.GetBytes(value).CopyTo(array, 8);
		try
		{
			socket_1.IOControl(IOControlCode.KeepAliveValues, array, null);
			return;
		}
		catch (NotImplementedException)
		{
		}
		socket_1.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, 1);
	}
}
