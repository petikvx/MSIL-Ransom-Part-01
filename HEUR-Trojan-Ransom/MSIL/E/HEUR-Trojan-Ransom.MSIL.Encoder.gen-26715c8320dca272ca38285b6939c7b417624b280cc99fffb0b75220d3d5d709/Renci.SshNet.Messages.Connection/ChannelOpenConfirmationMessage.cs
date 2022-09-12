namespace Renci.SshNet.Messages.Connection;

[Message("SSH_MSG_CHANNEL_OPEN_CONFIRMATION", 91)]
public class ChannelOpenConfirmationMessage : ChannelMessage
{
	public uint RemoteChannelNumber { get; private set; }

	public uint InitialWindowSize { get; private set; }

	public uint MaximumPacketSize { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + 4 + 4;

	public ChannelOpenConfirmationMessage()
	{
	}

	public ChannelOpenConfirmationMessage(uint localChannelNumber, uint initialWindowSize, uint maximumPacketSize, uint remoteChannelNumber)
		: base(localChannelNumber)
	{
		InitialWindowSize = initialWindowSize;
		MaximumPacketSize = maximumPacketSize;
		RemoteChannelNumber = remoteChannelNumber;
	}

	protected override void LoadData()
	{
		base.LoadData();
		RemoteChannelNumber = ReadUInt32();
		InitialWindowSize = ReadUInt32();
		MaximumPacketSize = ReadUInt32();
	}

	protected override void SaveData()
	{
		base.SaveData();
		Write(RemoteChannelNumber);
		Write(InitialWindowSize);
		Write(MaximumPacketSize);
	}

	internal override void Process(Session session)
	{
		session.OnChannelOpenConfirmationReceived(this);
	}
}
