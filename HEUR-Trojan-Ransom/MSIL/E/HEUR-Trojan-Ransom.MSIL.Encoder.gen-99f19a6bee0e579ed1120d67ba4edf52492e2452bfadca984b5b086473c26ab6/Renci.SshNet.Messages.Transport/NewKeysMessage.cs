namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_NEWKEYS", 21)]
public class NewKeysMessage : Message, IKeyExchangedAllowed
{
	protected override void LoadData()
	{
	}

	protected override void SaveData()
	{
	}

	internal override void Process(Session session)
	{
		session.OnNewKeysReceived(this);
	}
}
