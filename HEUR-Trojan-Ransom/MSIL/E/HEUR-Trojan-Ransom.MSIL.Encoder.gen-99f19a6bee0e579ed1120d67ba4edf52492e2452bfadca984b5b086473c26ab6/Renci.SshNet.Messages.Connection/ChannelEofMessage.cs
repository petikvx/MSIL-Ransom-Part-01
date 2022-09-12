namespace Renci.SshNet.Messages.Connection;

[Message("SSH_MSG_CHANNEL_EOF", 96)]
public class ChannelEofMessage : ChannelMessage
{
	public ChannelEofMessage()
	{
	}

	public ChannelEofMessage(uint localChannelNumber)
		: base(localChannelNumber)
	{
	}

	internal override void Process(Session session)
	{
		session.OnChannelEofReceived(this);
	}
}
