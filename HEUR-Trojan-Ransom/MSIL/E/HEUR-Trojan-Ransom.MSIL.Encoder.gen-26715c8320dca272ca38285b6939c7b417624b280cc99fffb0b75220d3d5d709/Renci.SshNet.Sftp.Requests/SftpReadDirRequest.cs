using System;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpReadDirRequest : SftpRequest
{
	private readonly Action<SftpNameResponse> _nameAction;

	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.ReadDir;

	public byte[] Handle { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + Handle.Length;

	public SftpReadDirRequest(uint protocolVersion, uint requestId, byte[] handle, Action<SftpNameResponse> nameAction, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Handle = handle;
		_nameAction = nameAction;
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
		if (response is SftpNameResponse obj)
		{
			_nameAction(obj);
		}
		else
		{
			base.Complete(response);
		}
	}
}
