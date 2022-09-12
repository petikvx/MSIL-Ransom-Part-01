using System;
using System.Text;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpRmDirRequest : SftpRequest
{
	private byte[] _path;

	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.RmDir;

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

	public SftpRmDirRequest(uint protocolVersion, uint requestId, string path, Encoding encoding, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Encoding = encoding;
		Path = path;
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
}
