using System;

namespace Renci.SshNet.Messages.Connection;

[Message("SSH_MSG_CHANNEL_DATA", 94)]
public class ChannelDataMessage : ChannelMessage
{
	internal const byte MessageNumber = 94;

	public byte[] Data { get; private set; }

	public int Offset { get; set; }

	public int Size { get; set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + Size;

	internal override void Process(Session session)
	{
		session.OnChannelDataReceived(this);
	}

	public ChannelDataMessage()
	{
	}

	public ChannelDataMessage(uint localChannelNumber, byte[] data)
		: base(localChannelNumber)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Data = data;
		Offset = 0;
		Size = data.Length;
	}

	public ChannelDataMessage(uint localChannelNumber, byte[] data, int offset, int size)
		: base(localChannelNumber)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		Data = data;
		Offset = offset;
		Size = size;
	}

	protected override void LoadData()
	{
		base.LoadData();
		Data = ReadBinary();
		Offset = 0;
		Size = Data.Length;
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinary(Data, Offset, Size);
	}
}
