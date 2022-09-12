using System;
using System.Text;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpRemoveRequest : SftpRequest
{
	private byte[] _fileName;

	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.Remove;

	public string Filename
	{
		get
		{
			return Encoding.GetString(_fileName, 0, _fileName.Length);
		}
		private set
		{
			_fileName = Encoding.GetBytes(value);
		}
	}

	public Encoding Encoding { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + _fileName.Length;

	public SftpRemoveRequest(uint protocolVersion, uint requestId, string filename, Encoding encoding, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Encoding = encoding;
		Filename = filename;
	}

	protected override void LoadData()
	{
		base.LoadData();
		_fileName = ReadBinary();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_fileName);
	}
}
