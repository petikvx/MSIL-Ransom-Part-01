using System;

namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_UNIMPLEMENTED", 3)]
public class UnimplementedMessage : Message
{
	protected override void LoadData()
	{
	}

	protected override void SaveData()
	{
		throw new NotImplementedException();
	}

	internal override void Process(Session session)
	{
		session.OnUnimplementedReceived(this);
	}
}
