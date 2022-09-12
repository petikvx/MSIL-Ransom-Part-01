using System;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal abstract class SftpRequest : SftpMessage
{
	private readonly Action<SftpStatusResponse> _statusAction;

	public uint RequestId { get; private set; }

	public uint ProtocolVersion { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4;

	protected SftpRequest(uint protocolVersion, uint requestId, Action<SftpStatusResponse> statusAction)
	{
		RequestId = requestId;
		ProtocolVersion = protocolVersion;
		_statusAction = statusAction;
	}

	public virtual void Complete(SftpResponse response)
	{
		if (!(response is SftpStatusResponse obj))
		{
			throw new InvalidOperationException($"Response of type '{response.GetType().Name}' is not expected.");
		}
		_statusAction(obj);
	}

	protected override void LoadData()
	{
		throw new InvalidOperationException("Request cannot be saved.");
	}

	protected override void SaveData()
	{
		base.SaveData();
		Write(RequestId);
	}
}
