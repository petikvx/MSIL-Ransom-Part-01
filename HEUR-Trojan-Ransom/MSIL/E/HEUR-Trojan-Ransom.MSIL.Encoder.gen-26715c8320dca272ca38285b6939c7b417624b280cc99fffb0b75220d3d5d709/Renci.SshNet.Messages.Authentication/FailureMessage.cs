using System;

namespace Renci.SshNet.Messages.Authentication;

[Message("SSH_MSG_USERAUTH_FAILURE", 51)]
public class FailureMessage : Message
{
	public string[] AllowedAuthentications { get; set; }

	public string Message { get; private set; }

	public bool PartialSuccess { get; private set; }

	protected override void LoadData()
	{
		AllowedAuthentications = ReadNamesList();
		PartialSuccess = ReadBoolean();
		if (PartialSuccess)
		{
			Message = string.Join(",", AllowedAuthentications);
		}
	}

	protected override void SaveData()
	{
		throw new NotImplementedException();
	}

	internal override void Process(Session session)
	{
		session.OnUserAuthenticationFailureReceived(this);
	}
}
