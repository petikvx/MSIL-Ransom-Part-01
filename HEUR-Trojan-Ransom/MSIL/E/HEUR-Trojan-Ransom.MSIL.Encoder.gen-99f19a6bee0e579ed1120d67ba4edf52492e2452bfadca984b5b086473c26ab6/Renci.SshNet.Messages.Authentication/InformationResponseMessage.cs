using System;
using System.Collections.Generic;

namespace Renci.SshNet.Messages.Authentication;

[Message("SSH_MSG_USERAUTH_INFO_RESPONSE", 61)]
internal class InformationResponseMessage : Message
{
	public IList<string> Responses { get; private set; }

	protected override int BufferCapacity => -1;

	public InformationResponseMessage()
	{
		Responses = new List<string>();
	}

	protected override void LoadData()
	{
		throw new NotImplementedException();
	}

	protected override void SaveData()
	{
		Write((uint)Responses.Count);
		foreach (string response in Responses)
		{
			Write(response);
		}
	}

	internal override void Process(Session session)
	{
		throw new NotImplementedException();
	}
}
