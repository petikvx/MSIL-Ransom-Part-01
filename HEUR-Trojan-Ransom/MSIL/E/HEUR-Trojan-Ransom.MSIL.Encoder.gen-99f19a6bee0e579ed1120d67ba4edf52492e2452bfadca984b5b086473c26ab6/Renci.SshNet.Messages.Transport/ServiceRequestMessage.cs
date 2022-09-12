using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_SERVICE_REQUEST", 5)]
public class ServiceRequestMessage : Message
{
	private readonly byte[] _serviceName;

	public ServiceName ServiceName => _serviceName.ToServiceName();

	protected override int BufferCapacity => base.BufferCapacity + 4 + _serviceName.Length;

	public ServiceRequestMessage(ServiceName serviceName)
	{
		_serviceName = serviceName.ToArray();
	}

	protected override void LoadData()
	{
		throw new InvalidOperationException("Load data is not supported.");
	}

	protected override void SaveData()
	{
		WriteBinaryString(_serviceName);
	}

	internal override void Process(Session session)
	{
		session.OnServiceRequestReceived(this);
	}
}
