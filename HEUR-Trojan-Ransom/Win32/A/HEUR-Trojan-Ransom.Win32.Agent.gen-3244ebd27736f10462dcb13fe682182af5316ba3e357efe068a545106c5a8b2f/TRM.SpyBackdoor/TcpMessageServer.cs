using System;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace TRM.SpyBackdoor;

public class TcpMessageServer : IDisposable
{
	private class TcpReadBufferData : IDisposable
	{
		public const int ReadBufferSize = 8192;

		public byte[] ReadBuffer;

		public Stream ClientConnectStream;

		public MemoryStream ClientStreamBuffer;

		public TcpClient TcpClient;

		public void Dispose()
		{
			if (ClientStreamBuffer != null)
			{
				ClientStreamBuffer.Dispose();
			}
			ClientStreamBuffer = null;
			if (ClientConnectStream != null)
			{
				ClientConnectStream.Dispose();
			}
			ClientConnectStream = null;
			ReadBuffer = null;
		}
	}

	private TcpListener _tcpListener;

	public TcpMessageServer(int port)
	{
		_tcpListener = new TcpListener(IPAddress.Any, port);
	}

	public void Start(int backlog = 50)
	{
		_tcpListener.Start(backlog);
		RestartListening();
	}

	private void RestartListening()
	{
		_tcpListener.BeginAcceptTcpClient(OnAcceptTcpClient, _tcpListener);
	}

	private void OnAcceptTcpClient(IAsyncResult asyncResult)
	{
		try
		{
			TcpClient tcpClient;
			try
			{
				tcpClient = _tcpListener.EndAcceptTcpClient(asyncResult);
			}
			finally
			{
				RestartListening();
			}
			ProcessTcpClient(tcpClient);
		}
		catch
		{
		}
	}

	private void ProcessTcpClient(TcpClient tcpClient)
	{
		TcpReadBufferData tcpReadBufferData = new TcpReadBufferData();
		tcpReadBufferData.ClientConnectStream = tcpClient.GetStream();
		tcpReadBufferData.ClientStreamBuffer = new MemoryStream();
		tcpReadBufferData.ReadBuffer = new byte[8192];
		tcpReadBufferData.TcpClient = tcpClient;
		try
		{
			tcpReadBufferData.ClientConnectStream.BeginRead(tcpReadBufferData.ReadBuffer, 0, 8192, ProcessClientRequestOnRead, tcpReadBufferData);
		}
		catch (Exception)
		{
			tcpClient.Close();
			tcpReadBufferData.Dispose();
		}
	}

	private void ProcessClientRequestOnRead(IAsyncResult asyncResult)
	{
		TcpReadBufferData tcpReadBufferData = (TcpReadBufferData)asyncResult.AsyncState;
		TcpClient tcpClient = tcpReadBufferData.TcpClient;
		int num = 0;
		try
		{
			num = tcpReadBufferData.ClientConnectStream.EndRead(asyncResult);
			tcpReadBufferData.ClientStreamBuffer.Write(tcpReadBufferData.ReadBuffer, 0, num);
			int num2;
			for (; num == tcpReadBufferData.ReadBuffer.Length; num += num2)
			{
				num2 = tcpReadBufferData.ClientConnectStream.Read(tcpReadBufferData.ReadBuffer, 0, tcpReadBufferData.ReadBuffer.Length);
				tcpReadBufferData.ClientStreamBuffer.Write(tcpReadBufferData.ReadBuffer, 0, num2);
			}
			if (tcpReadBufferData.ClientStreamBuffer.Length > 2147483647L)
			{
				return;
			}
		}
		catch (Exception)
		{
			if (tcpReadBufferData.ClientStreamBuffer != null)
			{
				_ = tcpReadBufferData.ClientStreamBuffer.Length;
			}
			tcpClient?.Close();
			return;
		}
		if (num == 0)
		{
			tcpClient?.Close();
			return;
		}
		if (tcpReadBufferData.ClientStreamBuffer.Capacity != tcpReadBufferData.ClientStreamBuffer.Length)
		{
			tcpReadBufferData.ClientStreamBuffer.Capacity = (int)tcpReadBufferData.ClientStreamBuffer.Length;
		}
		try
		{
			TcpMessageProcess.PrcessMessage(tcpReadBufferData.ClientStreamBuffer, tcpClient);
		}
		finally
		{
			Close(tcpClient);
		}
	}

	internal void Close(TcpClient tcpClient)
	{
		if (tcpClient == null)
		{
			return;
		}
		Socket client = tcpClient.Client;
		try
		{
			client.Shutdown(SocketShutdown.Both);
		}
		catch
		{
		}
		finally
		{
			client.Close();
			tcpClient.Close();
		}
	}

	public void Dispose()
	{
	}
}
