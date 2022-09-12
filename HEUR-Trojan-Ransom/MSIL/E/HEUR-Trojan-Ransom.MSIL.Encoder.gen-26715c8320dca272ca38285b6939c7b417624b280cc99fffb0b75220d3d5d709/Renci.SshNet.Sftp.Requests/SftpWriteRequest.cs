using System;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpWriteRequest : SftpRequest
{
	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.Write;

	public byte[] Handle { get; private set; }

	public ulong ServerFileOffset { get; private set; }

	public byte[] Data { get; private set; }

	public int Offset { get; private set; }

	public int Length { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + Handle.Length + 8 + 4 + Length;

	public SftpWriteRequest(uint protocolVersion, uint requestId, byte[] handle, ulong serverFileOffset, byte[] data, int offset, int length, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Handle = handle;
		ServerFileOffset = serverFileOffset;
		Data = data;
		Offset = offset;
		Length = length;
	}

	protected override void LoadData()
	{
		base.LoadData();
		Handle = ReadBinary();
		ServerFileOffset = ReadUInt64();
		Data = ReadBinary();
		Offset = 0;
		Length = Data.Length;
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(Handle);
		Write(ServerFileOffset);
		WriteBinary(Data, Offset, Length);
	}
}
