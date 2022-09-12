using System;
using System.Text;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class PosixRenameRequest : SftpExtendedRequest
{
	private byte[] _oldPath;

	private byte[] _newPath;

	public string OldPath
	{
		get
		{
			return Encoding.GetString(_oldPath, 0, _oldPath.Length);
		}
		private set
		{
			_oldPath = Encoding.GetBytes(value);
		}
	}

	public string NewPath
	{
		get
		{
			return Encoding.GetString(_newPath, 0, _newPath.Length);
		}
		private set
		{
			_newPath = Encoding.GetBytes(value);
		}
	}

	public Encoding Encoding { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + _oldPath.Length + 4 + _newPath.Length;

	public PosixRenameRequest(uint protocolVersion, uint requestId, string oldPath, string newPath, Encoding encoding, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction, "posix-rename@openssh.com")
	{
		Encoding = encoding;
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
