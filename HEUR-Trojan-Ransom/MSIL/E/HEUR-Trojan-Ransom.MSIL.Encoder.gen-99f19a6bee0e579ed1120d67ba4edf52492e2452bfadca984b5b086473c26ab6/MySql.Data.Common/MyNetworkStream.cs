using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace MySql.Data.Common;

internal class MyNetworkStream : NetworkStream
{
	private const int MaxRetryCount = 2;

	private readonly Socket _socket;

	public MyNetworkStream(Socket socket, bool ownsSocket)
		: base(socket, ownsSocket)
	{
		_socket = socket;
	}

	private static bool IsTimeoutException(SocketException e)
	{
		return e.SocketErrorCode == SocketError.TimedOut;
	}

	private static bool IsWouldBlockException(SocketException e)
	{
		return e.SocketErrorCode == SocketError.WouldBlock;
	}

	private void HandleOrRethrowException(Exception e)
	{
		Exception ex = e;
		while (true)
		{
			if (ex != null)
			{
				if (ex is SocketException)
				{
					SocketException e2 = (SocketException)ex;
					if (IsWouldBlockException(e2))
					{
						_socket.Blocking = true;
						break;
					}
					if (IsTimeoutException(e2))
					{
						break;
					}
				}
				ex = ex.InnerException;
				continue;
			}
			throw e;
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		int num = 0;
		Exception ex = null;
		do
		{
			try
			{
				return base.Read(buffer, offset, count);
			}
			catch (Exception ex2)
			{
				ex = ex2;
				HandleOrRethrowException(ex2);
			}
		}
		while (++num < 2);
		if (ex.GetBaseException() is SocketException && IsTimeoutException((SocketException)ex.GetBaseException()))
		{
			throw new TimeoutException(ex.Message, ex);
		}
		throw ex;
	}

	public override int ReadByte()
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
				HandleOrRethrowException(ex2);
			}
		}
		while (++num < 2);
		throw ex;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		int num = 0;
		Exception ex = null;
		do
		{
			try
			{
				base.Write(buffer, offset, count);
				return;
			}
			catch (Exception ex2)
			{
				ex = ex2;
				HandleOrRethrowException(ex2);
			}
		}
		while (++num < 2);
		throw ex;
	}

	public override void Flush()
	{
		int num = 0;
		Exception ex = null;
		do
		{
			try
			{
				base.Flush();
				return;
			}
			catch (Exception ex2)
			{
				ex = ex2;
				HandleOrRethrowException(ex2);
			}
		}
		while (++num < 2);
		throw ex;
	}

	public static MyNetworkStream CreateStream(string server, uint connectionTimeout, uint keepAlive, uint port, bool unix)
	{
		if (unix)
		{
			return new MyNetworkStream(StreamCreator.GetUnixSocket(server, connectionTimeout, keepAlive), ownsSocket: true);
		}
		MyNetworkStream myNetworkStream = null;
		IPAddress[] addressList = GetHostEntry(server).AddressList;
		foreach (IPAddress ip in addressList)
		{
			try
			{
				myNetworkStream = CreateSocketStream(port, keepAlive, connectionTimeout, ip, unix);
				if (myNetworkStream == null)
				{
					continue;
				}
				return myNetworkStream;
			}
			catch (Exception ex)
			{
				string message = ((connectionTimeout == 0) ? ResourcesX.TimeOutSingleHost0ms : string.Format(ResourcesX.TimeOutSingleHost, connectionTimeout));
				if (ex is TimeoutException)
				{
					throw new TimeoutException(message);
				}
				SocketException obj = ex as SocketException;
				if (obj == null)
				{
					throw;
				}
				if (obj.SocketErrorCode == SocketError.TimedOut)
				{
					throw new TimeoutException(message);
				}
				if (obj.SocketErrorCode != SocketError.ConnectionRefused)
				{
					throw;
				}
			}
		}
		return myNetworkStream;
	}

	private static IPHostEntry ParseIPAddress(string hostname)
	{
		IPHostEntry iPHostEntry = null;
		if (IPAddress.TryParse(hostname, out var address))
		{
			iPHostEntry = new IPHostEntry();
			iPHostEntry.AddressList = new IPAddress[1];
			iPHostEntry.AddressList[0] = address;
		}
		return iPHostEntry;
	}

	private static IPHostEntry GetHostEntry(string hostname)
	{
		IPHostEntry iPHostEntry = ParseIPAddress(hostname);
		if (iPHostEntry != null)
		{
			return iPHostEntry;
		}
		Task<IPHostEntry> hostEntryAsync = Dns.GetHostEntryAsync(hostname);
		hostEntryAsync.Wait();
		return hostEntryAsync.Result;
	}

	private static MyNetworkStream CreateSocketStream(uint port, uint keepAlive, uint connectionTimeout, IPAddress ip, bool unix)
	{
		EndPoint remoteEP = new IPEndPoint(ip, (int)port);
		Socket socket = (unix ? new Socket(AddressFamily.Unix, SocketType.Stream, ProtocolType.IP) : new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp));
		socket.NoDelay = true;
		if (keepAlive != 0)
		{
			SetKeepAlive(socket, keepAlive);
		}
		IAsyncResult asyncResult = socket.BeginConnect(remoteEP, null, null);
		if (connectionTimeout == 0)
		{
			if (!asyncResult.AsyncWaitHandle.WaitOne())
			{
				socket.Close();
			}
		}
		else if (!asyncResult.AsyncWaitHandle.WaitOne((int)connectionTimeout, exitContext: false))
		{
			socket.Close();
			throw new TimeoutException();
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
		MyNetworkStream myNetworkStream = new MyNetworkStream(socket, ownsSocket: true);
		GC.SuppressFinalize(socket);
		GC.SuppressFinalize(myNetworkStream);
		return myNetworkStream;
	}

	private static void SetKeepAlive(Socket s, uint time)
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
