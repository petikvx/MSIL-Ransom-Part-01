using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_DISCONNECT", 1)]
public class DisconnectMessage : Message, IKeyExchangedAllowed
{
	private byte[] _description;

	private byte[] _language;

	public DisconnectReason ReasonCode { get; private set; }

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

	public DisconnectMessage()
	{
	}

	public DisconnectMessage(DisconnectReason reasonCode, string message)
	{
		ReasonCode = reasonCode;
		Description = message;
		Language = "en";
	}

	protected override void LoadData()
	{
		ReasonCode = (DisconnectReason)ReadUInt32();
		_description = ReadBinary();
		_language = ReadBinary();
	}

	protected override void SaveData()
	{
		Write((uint)ReasonCode);
		WriteBinaryString(_description);
		WriteBinaryString(_language);
	}

	internal override void Process(Session session)
	{
		session.OnDisconnectReceived(this);
	}
}
