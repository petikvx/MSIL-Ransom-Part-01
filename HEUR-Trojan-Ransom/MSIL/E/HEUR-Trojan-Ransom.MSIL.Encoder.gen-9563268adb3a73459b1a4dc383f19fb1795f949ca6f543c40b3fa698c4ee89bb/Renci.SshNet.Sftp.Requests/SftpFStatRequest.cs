using System;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpFStatRequest : SftpRequest
{
	private readonly Action<SftpAttrsResponse> _attrsAction;

	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.FStat;

	public byte[] Handle { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + Handle.Length;

	public SftpFStatRequest(uint protocolVersion, uint requestId, byte[] handle, Action<SftpAttrsResponse> attrsAction, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Handle = handle;
		_attrsAction = attrsAction;
	}

	protected override void LoadData()
	{
		base.LoadData();
		Handle = ReadBinary();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(Handle);
	}

	public override void Complete(SftpResponse response)
	{
		if (response is SftpAttrsResponse obj)
		{
			_attrsAction(obj);
		}
		else
		{
			base.Complete(response);
		}
	}
}
