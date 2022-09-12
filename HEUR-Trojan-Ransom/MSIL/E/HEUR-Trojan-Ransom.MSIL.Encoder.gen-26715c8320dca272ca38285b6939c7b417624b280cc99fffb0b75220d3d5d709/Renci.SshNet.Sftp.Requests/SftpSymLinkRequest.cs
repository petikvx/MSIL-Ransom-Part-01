using System;
using System.Text;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpSymLinkRequest : SftpRequest
{
	private byte[] _newLinkPath;

	private byte[] _existingPath;

	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.SymLink;

	public string NewLinkPath
	{
		get
		{
			return Encoding.GetString(_newLinkPath, 0, _newLinkPath.Length);
		}
		private set
		{
			_newLinkPath = Encoding.GetBytes(value);
		}
	}

	public string ExistingPath
	{
		get
		{
			return Encoding.GetString(_existingPath, 0, _existingPath.Length);
		}
		private set
		{
			_existingPath = Encoding.GetBytes(value);
		}
	}

	public Encoding Encoding { get; set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + _newLinkPath.Length + 4 + _existingPath.Length;

	public SftpSymLinkRequest(uint protocolVersion, uint requestId, string newLinkPath, string existingPath, Encoding encoding, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Encoding = encoding;
		NewLinkPath = newLinkPath;
		ExistingPath = existingPath;
	}

	protected override void LoadData()
	{
		base.LoadData();
		_newLinkPath = ReadBinary();
		_existingPath = ReadBinary();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_newLinkPath);
		WriteBinaryString(_existingPath);
	}
}
