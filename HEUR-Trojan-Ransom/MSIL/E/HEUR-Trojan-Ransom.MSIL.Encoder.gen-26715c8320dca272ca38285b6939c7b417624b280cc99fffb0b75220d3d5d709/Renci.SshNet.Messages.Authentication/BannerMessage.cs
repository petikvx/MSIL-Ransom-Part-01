using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Authentication;

[Message("SSH_MSG_USERAUTH_BANNER", 53)]
public class BannerMessage : Message
{
	private byte[] _message;

	private byte[] _language;

	public string Message => SshData.Utf8.GetString(_message, 0, _message.Length);

	public string Language => SshData.Utf8.GetString(_language, 0, _language.Length);

	protected override int BufferCapacity => base.BufferCapacity + 4 + _message.Length + 4 + _language.Length;

	internal override void Process(Session session)
	{
		session.OnUserAuthenticationBannerReceived(this);
	}

	protected override void LoadData()
	{
		_message = ReadBinary();
		_language = ReadBinary();
	}

	protected override void SaveData()
	{
		WriteBinaryString(_message);
		WriteBinaryString(_language);
	}
}
