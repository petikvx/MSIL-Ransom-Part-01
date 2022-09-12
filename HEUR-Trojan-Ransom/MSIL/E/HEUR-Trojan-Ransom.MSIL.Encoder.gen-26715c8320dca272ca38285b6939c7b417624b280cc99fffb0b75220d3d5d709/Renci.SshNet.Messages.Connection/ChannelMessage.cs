using System.Globalization;

namespace Renci.SshNet.Messages.Connection;

public abstract class ChannelMessage : Message
{
	public uint LocalChannelNumber { get; protected set; }

	protected override int BufferCapacity => base.BufferCapacity + 4;

	protected ChannelMessage()
	{
	}

	protected ChannelMessage(uint localChannelNumber)
	{
		LocalChannelNumber = localChannelNumber;
	}

	protected override void LoadData()
	{
		LocalChannelNumber = ReadUInt32();
	}

	protected override void SaveData()
	{
		Write(LocalChannelNumber);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "{0} : #{1}", new object[2]
		{
			base.ToString(),
			LocalChannelNumber
		});
	}
}
