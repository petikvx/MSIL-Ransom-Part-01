using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

[Message("SSH_MSG_CHANNEL_REQUEST", 98)]
public class ChannelRequestMessage : ChannelMessage
{
	private string _requestName;

	private byte[] _requestNameBytes;

	public string RequestName
	{
		get
		{
			return _requestName;
		}
		private set
		{
			_requestName = value;
			_requestNameBytes = SshData.Ascii.GetBytes(value);
		}
	}

	public byte[] RequestData { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + _requestNameBytes.Length + RequestData.Length;

	public ChannelRequestMessage()
	{
	}

	public ChannelRequestMessage(uint localChannelNumber, RequestInfo info)
		: base(localChannelNumber)
	{
		RequestName = info.RequestName;
		RequestData = info.GetBytes();
	}

	protected override void LoadData()
	{
		base.LoadData();
		_requestNameBytes = ReadBinary();
		_requestName = SshData.Ascii.GetString(_requestNameBytes, 0, _requestNameBytes.Length);
		RequestData = ReadBytes();
	}

	protected override void SaveData()
	{
		base.SaveData();
		WriteBinaryString(_requestNameBytes);
		Write(RequestData);
	}

	internal override void Process(Session session)
	{
		session.OnChannelRequestReceived(this);
	}
}
