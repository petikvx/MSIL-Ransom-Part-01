using System;
using System.Text;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class StatVfsRequest : SftpExtendedRequest
{
	private byte[] _path;

	private readonly Action<SftpExtendedReplyResponse> _extendedReplyAction;

	public string Path
	{
		get
		{
			return Encoding.GetString(_path, 0, _path.Length);
		}
		private set
		{
			_path = Encoding.GetBytes(value);
		}
	}

	public Encoding Encoding { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + _path.Length;

	public StatVfsRequest(uint protocolVersion, uint requestId, string path, Encoding encoding, Action<SftpExtendedReplyResponse> extendedAction, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction, "statvfs@openssh.com")
	{
		Encoding = encoding;
		Path = path;
		_extendedReplyAction = extendedAction;
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_path);
	}

	public override void Complete(SftpResponse response)
	{
		if (response is SftpExtendedReplyResponse obj)
		{
			_extendedReplyAction(obj);
		}
		else
		{
			base.Complete(response);
		}
	}
}
