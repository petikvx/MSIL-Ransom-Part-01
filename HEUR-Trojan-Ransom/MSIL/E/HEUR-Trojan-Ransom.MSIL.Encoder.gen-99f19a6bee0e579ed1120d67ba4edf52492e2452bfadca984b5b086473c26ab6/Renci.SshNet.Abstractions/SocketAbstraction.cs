using System;
using System.Globalization;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Renci.SshNet.Common;
using Renci.SshNet.Messages.Transport;

namespace Renci.SshNet.Abstractions;

internal static class SocketAbstraction
{
	public static bool CanRead(Socket socket)
	{
		if (socket.Connected)
		{
			if (socket.Poll(-1, SelectMode.SelectRead))
			{
				return socket.Available > 0;
			}
			return false;
		}
		return false;
	}

	public static bool CanWrite(Socket socket)
	{
		if (socket != null && socket.Connected)
		{
			return socket.Poll(-1, SelectMode.SelectWrite);
		}
		return false;
	}

	public static Socket Connect(IPEndPoint remoteEndpoint, TimeSpan connectTimeout)
	{
		Socket socket = new Socket(remoteEndpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp)
		{
			NoDelay = true
		};
		ManualResetEvent manualResetEvent = new ManualResetEvent(initialState: false);
		SocketAsyncEventArgs socketAsyncEventArgs = new SocketAsyncEventArgs
		{
			UserToken = manualResetEvent,
			RemoteEndPoint = remoteEndpoint
		};
		socketAsyncEventArgs.Completed += ConnectCompleted;
		if (socket.ConnectAsync(socketAsyncEventArgs) && !manualResetEvent.WaitOne(connectTimeout))
		{
			socketAsyncEventArgs.Completed -= ConnectCompleted;
			socket.Dispose();
			manualResetEvent.Dispose();
			socketAsyncEventArgs.Dispose();
			throw new SshOperationTimeoutException(string.Format(CultureInfo.InvariantCulture, "Connection failed to establish within {0:F0} milliseconds.", new object[1] { connectTimeout.TotalMilliseconds }));
		}
		manualResetEvent.Dispose();
		if (socketAsyncEventArgs.SocketError != 0)
		{
			SocketError socketError = socketAsyncEventArgs.SocketError;
			socket.Dispose();
			socketAsyncEventArgs.Dispose();
			throw new SocketException((int)socketError);
		}
		socketAsyncEventArgs.Dispose();
		return socket;
	}

	public static void ClearReadBuffer(Socket socket)
	{
		TimeSpan timeout = TimeSpan.FromMilliseconds(500.0);
		byte[] array = new byte[256];
		int num;
		do
		{
			num = ReadPartial(socket, array, 0, array.Length, timeout);
		}
		while (num > 0);
	}

	public static int ReadPartial(Socket socket, byte[] buffer, int offset, int size, TimeSpan timeout)
	{
		socket.ReceiveTimeout = (int)timeout.TotalMilliseconds;
		try
		{
			return socket.Receive(buffer, offset, size, SocketFlags.None);
		}
		catch (SocketException ex)
		{
			if (ex.SocketErrorCode == SocketError.TimedOut)
			{
				throw new SshOperationTimeoutException(string.Format(CultureInfo.InvariantCulture, "Socket read operation has timed out after {0:F0} milliseconds.", new object[1] { timeout.TotalMilliseconds }));
			}
			throw;
		}
	}

	public static void ReadContinuous(Socket socket, byte[] buffer, int offset, int size, Action<byte[], int, int> processReceivedBytesAction)
	{
		socket.ReceiveTimeout = 0;
		while (socket.Connected)
		{
			try
			{
				int num = socket.Receive(buffer, offset, size, SocketFlags.None);
				if (num == 0)
				{
					break;
				}
				processReceivedBytesAction(buffer, offset, num);
			}
			catch (SocketException ex)
			{
				if (IsErrorResumable(ex.SocketErrorCode))
				{
					continue;
				}
				SocketError socketErrorCode = ex.SocketErrorCode;
				if (socketErrorCode != SocketError.Interrupted && (uint)(socketErrorCode - 10053) > 1u)
				{
					throw;
				}
				break;
			}
		}
	}

	public static int ReadByte(Socket socket, TimeSpan timeout)
	{
		byte[] array = new byte[1];
		if (Read(socket, array, 0, 1, timeout) == 0)
		{
			return -1;
		}
		return array[0];
	}

	public static void SendByte(Socket socket, byte value)
	{
		byte[] data = new byte[1] { value };
		Send(socket, data, 0, 1);
	}

	public static int Read(Socket socket, byte[] buffer, int offset, int size, TimeSpan timeout)
	{
		int num = 0;
		socket.ReceiveTimeout = (int)timeout.TotalMilliseconds;
		do
		{
			try
			{
				int num2 = socket.Receive(buffer, offset + num, size - num, SocketFlags.None);
				if (num2 == 0)
				{
					return 0;
				}
				num += num2;
			}
			catch (SocketException ex)
			{
				if (!IsErrorResumable(ex.SocketErrorCode))
				{
					if (ex.SocketErrorCode == SocketError.TimedOut)
					{
						throw new SshOperationTimeoutException(string.Format(CultureInfo.InvariantCulture, "Socket read operation has timed out after {0:F0} milliseconds.", new object[1] { timeout.TotalMilliseconds }));
					}
					throw;
				}
				ThreadAbstraction.Sleep(30);
			}
		}
		while (num < size);
		return num;
	}

	public static void Send(Socket socket, byte[] data)
	{
		Send(socket, data, 0, data.Length);
	}

	public static void Send(Socket socket, byte[] data, int offset, int size)
	{
		int num = 0;
		do
		{
			try
			{
				int num2 = socket.Send(data, offset + num, size - num, SocketFlags.None);
				if (num2 == 0)
				{
					throw new SshConnectionException("An established connection was aborted by the server.", DisconnectReason.ConnectionLost);
				}
				num += num2;
			}
			catch (SocketException ex)
			{
				if (!IsErrorResumable(ex.SocketErrorCode))
				{
					throw;
				}
				ThreadAbstraction.Sleep(30);
			}
		}
		while (num < size);
	}

	public static bool IsErrorResumable(SocketError socketError)
	{
		if (socketError != SocketError.IOPending && socketError != SocketError.WouldBlock && socketError != SocketError.NoBufferSpaceAvailable)
		{
			return false;
		}
		return true;
	}

	private static void ConnectCompleted(object sender, SocketAsyncEventArgs e)
	{
		((ManualResetEvent)e.UserToken)?.Set();
	}
}
