using System;
using Renci.SshNet.Common;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal abstract class SftpExtendedRequest : SftpRequest
{
	private byte[] _nameBytes;

	private string _name;

	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.Extended;

	public string Name
	{
		get
		{
			return _name;
		}
		private set
		{
			_name = value;
			_nameBytes = SshData.Utf8.GetBytes(value);
		}
	}

	protected override int BufferCapacity => base.BufferCapacity + 4 + _nameBytes.Length;

	protected SftpExtendedRequest(uint protocolVersion, uint requestId, Action<SftpStatusResponse> statusAction, string name)
		: base(protocolVersion, requestId, statusAction)
	{
		Name = name;
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_nameBytes);
	}
}
