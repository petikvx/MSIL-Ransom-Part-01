using System;
using System.Globalization;
using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_IGNORE", 2)]
public class IgnoreMessage : Message
{
	internal const byte MessageNumber = 2;

	public byte[] Data { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + Data.Length;

	public IgnoreMessage()
	{
		Data = Array<byte>.Empty;
	}

	public IgnoreMessage(byte[] data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Data = data;
	}

	protected override void LoadData()
	{
		uint num = ReadUInt32();
		if (num > int.MaxValue)
		{
			throw new NotSupportedException(string.Format(CultureInfo.CurrentCulture, "Data longer than {0} is not supported.", new object[1] { int.MaxValue }));
		}
		if (num > base.DataStream.Length - base.DataStream.Position)
		{
			Data = Array<byte>.Empty;
		}
		else
		{
			Data = ReadBytes((int)num);
		}
	}

	protected override void SaveData()
	{
		WriteBinaryString(Data);
	}

	internal override void Process(Session session)
	{
		session.OnIgnoreReceived(this);
	}
}
