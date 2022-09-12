using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Connection;

[Message("SSH_MSG_CHANNEL_OPEN_FAILURE", 92)]
public class ChannelOpenFailureMessage : ChannelMessage
{
	internal const uint AdministrativelyProhibited = 1u;

	internal const uint ConnectFailed = 2u;

	internal const uint UnknownChannelType = 3u;

	internal const uint ResourceShortage = 4u;

	private byte[] _description;

	private byte[] _language;

	public uint ReasonCode { get; private set; }

	public string Description
	{
		get
		{
			return SshData.Utf8.GetString(_description, 0, _description.Length);
		}
		private set
		{
			_description = SshData.Utf8.GetBytes(value);
		}
	}

	public string Language
	{
		get
		{
			return SshData.Utf8.GetString(_language, 0, _language.Length);
		}
		private set
		{
			_language = SshData.Utf8.GetBytes(value);
		}
	}

	protected override int BufferCapacity => base.BufferCapacity + 4 + 4 + _description.Length + 4 + _language.Length;

	public ChannelOpenFailureMessage()
	{
	}

	public ChannelOpenFailureMessage(uint localChannelNumber, string description, uint reasonCode)
		: this(localChannelNumber, description, reasonCode, "en")
	{
	}

	public ChannelOpenFailureMessage(uint localChannelNumber, string description, uint reasonCode, string language)
		: base(localChannelNumber)
	{
		Description = description;
		ReasonCode = reasonCode;
		Language = language;
	}

	protected override void LoadData()
	{
		base.LoadData();
		ReasonCode = ReadUInt32();
		_description = ReadBinary();
		_language = ReadBinary();
	}

	protected override void SaveData()
	{
		base.SaveData();
		Write(ReasonCode);
		WriteBinaryString(_description);
		WriteBinaryString(_language);
	}

	internal override void Process(Session session)
	{
		session.OnChannelOpenFailureReceived(this);
	}
}
