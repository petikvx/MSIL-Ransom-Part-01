using System;
using System.Text;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpLStatRequest : SftpRequest
{
	private byte[] _path;

	private readonly Action<SftpAttrsResponse> _attrsAction;

	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.LStat;

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

	public SftpLStatRequest(uint protocolVersion, uint requestId, string path, Encoding encoding, Action<SftpAttrsResponse> attrsAction, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Encoding = encoding;
		Path = path;
		_attrsAction = attrsAction;
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
		if (response is SftpAttrsResponse obj)
		{
			_attrsAction(obj);
		}
		else
		{
			base.Complete(response);
		}
	}
}
