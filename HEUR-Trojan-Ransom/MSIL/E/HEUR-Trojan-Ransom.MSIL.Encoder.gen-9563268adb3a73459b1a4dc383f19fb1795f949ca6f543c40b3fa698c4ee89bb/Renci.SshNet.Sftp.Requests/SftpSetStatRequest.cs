using System;
using System.Text;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpSetStatRequest : SftpRequest
{
	private byte[] _path;

	private byte[] _attributesBytes;

	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.SetStat;

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

	private SftpFileAttributes Attributes { get; set; }

	private byte[] AttributesBytes
	{
		get
		{
			if (_attributesBytes == null)
			{
				_attributesBytes = Attributes.GetBytes();
			}
			return _attributesBytes;
		}
	}

	protected override int BufferCapacity => base.BufferCapacity + 4 + _path.Length + AttributesBytes.Length;

	public SftpSetStatRequest(uint protocolVersion, uint requestId, string path, Encoding encoding, SftpFileAttributes attributes, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Encoding = encoding;
		Path = path;
		Attributes = attributes;
	}

	protected override void LoadData()
	{
		base.LoadData();
		_path = ReadBinary();
		Attributes = ReadAttributes();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_path);
		Write(AttributesBytes);
	}
}
