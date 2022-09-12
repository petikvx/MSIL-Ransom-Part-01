using System;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpReadRequest : SftpRequest
{
	private readonly Action<SftpDataResponse> _dataAction;

	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.Read;

	public byte[] Handle { get; private set; }

	public ulong Offset { get; private set; }

	public uint Length { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + Handle.Length + 8 + 4;

	public SftpReadRequest(uint protocolVersion, uint requestId, byte[] handle, ulong offset, uint length, Action<SftpDataResponse> dataAction, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Handle = handle;
		Offset = offset;
		Length = length;
		_dataAction = dataAction;
	}

	protected override void LoadData()
	{
		base.LoadData();
		Handle = ReadBinary();
		Offset = ReadUInt64();
		Length = ReadUInt32();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(Handle);
		Write(Offset);
		Write(Length);
	}

	public override void Complete(SftpResponse response)
	{
		if (response is SftpDataResponse obj)
		{
			_dataAction(obj);
		}
		else
		{
			base.Complete(response);
		}
	}
}
