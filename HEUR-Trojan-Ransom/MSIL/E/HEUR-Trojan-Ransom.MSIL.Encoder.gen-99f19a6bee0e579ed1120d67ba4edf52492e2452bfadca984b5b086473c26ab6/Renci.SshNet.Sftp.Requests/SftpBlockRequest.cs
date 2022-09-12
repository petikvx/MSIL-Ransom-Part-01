using System;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpBlockRequest : SftpRequest
{
	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.Block;

	public byte[] Handle { get; private set; }

	public ulong Offset { get; private set; }

	public ulong Length { get; private set; }

	public uint LockMask { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + Handle.Length + 8 + 8 + 4;

	public SftpBlockRequest(uint protocolVersion, uint requestId, byte[] handle, ulong offset, ulong length, uint lockMask, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Handle = handle;
		Offset = offset;
		Length = length;
		LockMask = lockMask;
	}

	protected override void LoadData()
	{
		base.LoadData();
		Handle = ReadBinary();
		Offset = ReadUInt64();
		Length = ReadUInt64();
		LockMask = ReadUInt32();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(Handle);
		Write(Offset);
		Write(Length);
		Write(LockMask);
	}
}
