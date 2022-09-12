namespace Renci.SshNet.Messages.Connection;

[Message("SSH_MSG_CHANNEL_CLOSE", 97)]
public class ChannelCloseMessage : ChannelMessage
{
	public ChannelCloseMessage()
	{
	}

	public ChannelCloseMessage(uint localChannelNumber)
		: base(localChannelNumber)
	{
	}

	internal override void Process(Session session)
	{
		session.OnChannelCloseReceived(this);
	}
}
