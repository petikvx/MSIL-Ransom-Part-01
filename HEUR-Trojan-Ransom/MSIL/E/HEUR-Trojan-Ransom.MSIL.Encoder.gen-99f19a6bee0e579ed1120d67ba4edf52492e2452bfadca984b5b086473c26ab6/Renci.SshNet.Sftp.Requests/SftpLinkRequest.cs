using System;
using Renci.SshNet.Common;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpLinkRequest : SftpRequest
{
	private byte[] _newLinkPath;

	private byte[] _existingPath;

	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.Link;

	public string NewLinkPath
	{
		get
		{
			return SshData.Utf8.GetString(_newLinkPath, 0, _newLinkPath.Length);
		}
		private set
		{
			_newLinkPath = SshData.Utf8.GetBytes(value);
		}
	}

	public string ExistingPath
	{
		get
		{
			return SshData.Utf8.GetString(_existingPath, 0, _existingPath.Length);
		}
		private set
		{
			_existingPath = SshData.Utf8.GetBytes(value);
		}
	}

	public bool IsSymLink { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + NewLinkPath.Length + 4 + ExistingPath.Length + 1;

	public SftpLinkRequest(uint protocolVersion, uint requestId, string newLinkPath, string existingPath, bool isSymLink, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		NewLinkPath = newLinkPath;
		ExistingPath = existingPath;
		IsSymLink = isSymLink;
	}

	protected override void LoadData()
	{
		base.LoadData();
		_newLinkPath = ReadBinary();
		_existingPath = ReadBinary();
		IsSymLink = ReadBoolean();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_newLinkPath);
		WriteBinaryString(_existingPath);
		Write(IsSymLink);
	}
}
