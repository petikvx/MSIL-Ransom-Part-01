using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_DEBUG", 4)]
public class DebugMessage : Message
{
	private byte[] _message;

	private byte[] _language;

	public bool IsAlwaysDisplay { get; private set; }

	public string Message => SshData.Utf8.GetString(_message, 0, _message.Length);

	public string Language => SshData.Utf8.GetString(_language, 0, _language.Length);

	protected override int BufferCapacity => base.BufferCapacity + 1 + 4 + _message.Length + 4 + _language.Length;

	protected override void LoadData()
	{
		IsAlwaysDisplay = ReadBoolean();
		_message = ReadBinary();
		_language = ReadBinary();
	}

	protected override void SaveData()
	{
		Write(IsAlwaysDisplay);
		WriteBinaryString(_message);
		WriteBinaryString(_language);
	}

	internal override void Process(Session session)
	{
		session.OnDebugReceived(this);
	}
}
