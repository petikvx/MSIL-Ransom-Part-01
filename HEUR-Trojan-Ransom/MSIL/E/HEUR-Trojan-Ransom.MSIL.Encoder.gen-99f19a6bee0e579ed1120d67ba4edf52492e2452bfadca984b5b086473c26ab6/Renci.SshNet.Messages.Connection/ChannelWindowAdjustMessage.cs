namespace Renci.SshNet.Messages.Connection;

[Message("SSH_MSG_CHANNEL_WINDOW_ADJUST", 93)]
public class ChannelWindowAdjustMessage : ChannelMessage
{
	public uint BytesToAdd { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4;

	public ChannelWindowAdjustMessage()
	{
	}

	public ChannelWindowAdjustMessage(uint localChannelNumber, uint bytesToAdd)
		: base(localChannelNumber)
	{
		BytesToAdd = bytesToAdd;
	}

	protected override void LoadData()
	{
		base.LoadData();
		BytesToAdd = ReadUInt32();
	}

	protected override void SaveData()
	{
		base.SaveData();
		Write(BytesToAdd);
	}

	internal override void Process(Session session)
	{
		session.OnChannelWindowAdjustReceived(this);
	}
}
