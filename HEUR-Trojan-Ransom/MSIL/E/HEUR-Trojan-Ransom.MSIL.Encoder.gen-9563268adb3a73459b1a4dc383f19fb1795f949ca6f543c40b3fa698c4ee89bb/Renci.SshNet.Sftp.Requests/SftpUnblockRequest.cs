using System;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpUnblockRequest : SftpRequest
{
	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.Unblock;

	public byte[] Handle { get; private set; }

	public ulong Offset { get; private set; }

	public ulong Length { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + Handle.Length + 8 + 8;

	public SftpUnblockRequest(uint protocolVersion, uint requestId, byte[] handle, ulong offset, ulong length, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Handle = handle;
		Offset = offset;
		Length = length;
	}

	protected override void LoadData()
	{
		base.LoadData();
		Handle = ReadBinary();
		Offset = ReadUInt64();
		Length = ReadUInt64();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(Handle);
		Write(Offset);
		Write(Length);
	}
}
