using System;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpCloseRequest : SftpRequest
{
	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.Close;

	public byte[] Handle { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + Handle.Length;

	public SftpCloseRequest(uint protocolVersion, uint requestId, byte[] handle, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Handle = handle;
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
}
