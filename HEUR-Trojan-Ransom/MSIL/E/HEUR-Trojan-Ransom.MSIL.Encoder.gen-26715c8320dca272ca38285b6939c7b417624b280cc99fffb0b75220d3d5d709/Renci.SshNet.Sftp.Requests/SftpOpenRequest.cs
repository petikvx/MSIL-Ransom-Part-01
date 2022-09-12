using System;
using System.Text;
using Renci.SshNet.Sftp.Responses;

namespace Renci.SshNet.Sftp.Requests;

internal class SftpOpenRequest : SftpRequest
{
	private byte[] _fileName;

	private byte[] _attributes;

	private readonly Action<SftpHandleResponse> _handleAction;

	public override SftpMessageTypes SftpMessageType => SftpMessageTypes.Open;

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

	public Flags Flags { get; private set; }

	public SftpFileAttributes Attributes
	{
		get
		{
			return SftpFileAttributes.FromBytes(_attributes);
		}
		private set
		{
			_attributes = value.GetBytes();
		}
	}

	public Encoding Encoding { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + _fileName.Length + 4 + _attributes.Length;

	public SftpOpenRequest(uint protocolVersion, uint requestId, string fileName, Encoding encoding, Flags flags, Action<SftpHandleResponse> handleAction, Action<SftpStatusResponse> statusAction)
		: this(protocolVersion, requestId, fileName, encoding, flags, SftpFileAttributes.Empty, handleAction, statusAction)
	{
	}

	private SftpOpenRequest(uint protocolVersion, uint requestId, string fileName, Encoding encoding, Flags flags, SftpFileAttributes attributes, Action<SftpHandleResponse> handleAction, Action<SftpStatusResponse> statusAction)
		: base(protocolVersion, requestId, statusAction)
	{
		Encoding = encoding;
		Filename = fileName;
		Flags = flags;
		Attributes = attributes;
		_handleAction = handleAction;
	}

	protected override void LoadData()
	{
		base.LoadData();
		throw new NotSupportedException();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_fileName);
		Write((uint)Flags);
		Write(_attributes);
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
