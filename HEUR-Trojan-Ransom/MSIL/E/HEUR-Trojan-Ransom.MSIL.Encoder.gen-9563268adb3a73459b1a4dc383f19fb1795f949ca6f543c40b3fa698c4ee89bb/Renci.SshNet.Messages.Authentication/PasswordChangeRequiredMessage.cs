namespace Renci.SshNet.Messages.Authentication;

[Message("SSH_MSG_USERAUTH_PASSWD_CHANGEREQ", 60)]
internal class PasswordChangeRequiredMessage : Message
{
	public byte[] Message { get; private set; }

	public byte[] Language { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + Message.Length + 4 + Language.Length;

	protected override void LoadData()
	{
		Message = ReadBinary();
		Language = ReadBinary();
	}

	protected override void SaveData()
	{
		WriteBinaryString(Message);
		WriteBinaryString(Language);
	}

	internal override void Process(Session session)
	{
		session.OnUserAuthenticationPasswordChangeRequiredReceived(this);
	}
}
