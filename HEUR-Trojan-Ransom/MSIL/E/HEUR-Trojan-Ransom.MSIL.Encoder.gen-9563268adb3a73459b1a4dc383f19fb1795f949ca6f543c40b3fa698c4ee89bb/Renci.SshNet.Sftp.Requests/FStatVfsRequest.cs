using System;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class FStatVfsRequest : SftpExtendedRequest
{
	private readonly Action<SftpExtendedReplyResponse> _extendedReplyAction;

	public byte[] Handle { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + Handle.Length;

	public FStatVfsRequest(uint protocolVersion, uint requestId, byte[] handle, Action<SftpExtendedReplyResponse> extendedAction, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction, "fstatvfs@openssh.com")
	{
		Handle = handle;
		_extendedReplyAction = extendedAction;
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(Handle);
	}

	public override void Complete(SftpResponse response)
	{
		if (response is SftpExtendedReplyResponse obj)
		{
			_extendedReplyAction(obj);
		}
		else
		{
			base.Complete(response);
		}
	}
}
