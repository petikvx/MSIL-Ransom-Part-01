using System;
using System.Text;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpReadLinkRequest : SftpRequest
{
	private byte[] _path;

	private readonly Action<SftpNameResponse> _nameAction;

	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.ReadLink;

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

	public SftpReadLinkRequest(uint protocolVersion, uint requestId, string path, Encoding encoding, Action<SftpNameResponse> nameAction, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Encoding = encoding;
		Path = path;
		_nameAction = nameAction;
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
		if (response is SftpNameResponse obj)
		{
			_nameAction(obj);
		}
		else
		{
			base.Complete(response);
		}
	}
}
