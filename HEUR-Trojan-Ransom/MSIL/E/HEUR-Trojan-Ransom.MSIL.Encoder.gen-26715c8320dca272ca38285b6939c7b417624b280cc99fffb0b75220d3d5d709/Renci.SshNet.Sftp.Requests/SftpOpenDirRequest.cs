using System;
using System.Text;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpOpenDirRequest : SftpRequest
{
	private byte[] _path;

	private readonly Action<SftpHandleResponse> _handleAction;

	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.OpenDir;

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

	public SftpOpenDirRequest(uint protocolVersion, uint requestId, string path, Encoding encoding, Action<SftpHandleResponse> handleAction, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Encoding = encoding;
		Path = path;
		_handleAction = handleAction;
	}

	protected override void LoadData()
	{
		base.LoadData();
		_path = ReadBinary();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_path);
	}

	public override void Complete(SftpResponse response)
	{
		if (response is SftpHandleResponse obj)
		{
			_handleAction(obj);
		}
		else
		{
			base.Complete(response);
		}
	}
}
