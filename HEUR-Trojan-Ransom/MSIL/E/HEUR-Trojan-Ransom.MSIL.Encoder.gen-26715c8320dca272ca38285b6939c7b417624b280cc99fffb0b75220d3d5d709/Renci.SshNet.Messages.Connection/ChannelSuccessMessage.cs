namespace Renci.SshNet.Messages.Connection;

[Message("SSH_MSG_CHANNEL_SUCCESS", 99)]
public class ChannelSuccessMessage : ChannelMessage
{
	public ChannelSuccessMessage()
	{
	}

	public ChannelSuccessMessage(uint localChannelNumber)
		: base(localChannelNumber)
	{
	}

	internal override void Process(Session session)
	{
		session.OnChannelSuccessReceived(this);
	}
}
