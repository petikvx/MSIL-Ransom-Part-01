using System;
using Renci.SshNet.Common;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class HardLinkRequest : SftpExtendedRequest
{
	private byte[] _oldPath;

	private byte[] _newPath;

	public string OldPath
	{
		get
		{
			return SshData.Utf8.GetString(_oldPath, 0, _oldPath.Length);
		}
		private set
		{
			_oldPath = SshData.Utf8.GetBytes(value);
		}
	}

	public string NewPath
	{
		get
		{
			return SshData.Utf8.GetString(_newPath, 0, _newPath.Length);
		}
		private set
		{
			_newPath = SshData.Utf8.GetBytes(value);
		}
	}

	protected override int BufferCapacity => base.BufferCapacity + 4 + _oldPath.Length + 4 + _newPath.Length;

	public HardLinkRequest(uint protocolVersion, uint requestId, string oldPath, string newPath, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction, "hardlink@openssh.com")
	{
		OldPath = oldPath;
		NewPath = newPath;
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_oldPath);
		WriteBinaryString(_newPath);
	}
}
