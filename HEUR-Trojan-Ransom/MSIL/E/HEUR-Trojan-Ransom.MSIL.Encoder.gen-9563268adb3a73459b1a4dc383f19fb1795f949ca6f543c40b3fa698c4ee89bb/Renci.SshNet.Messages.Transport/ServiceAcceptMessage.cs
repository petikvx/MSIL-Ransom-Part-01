using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_SERVICE_ACCEPT", 6)]
public class ServiceAcceptMessage : Message
{
	internal const byte MessageNumber = 6;

	public ServiceName ServiceName { get; private set; }

	protected override void LoadData()
	{
		ServiceName = ReadBinary().ToServiceName();
	}

	protected override void SaveData()
	{
		throw new NotImplementedException();
	}

	internal override void Process(Session session)
	{
		session.OnServiceAcceptReceived(this);
	}
}
