namespace Renci.SshNet.Messages.Authentication;

[Message("SSH_MSG_USERAUTH_PK_OK", 60)]
internal class PublicKeyMessage : Message
{
	public byte[] PublicKeyAlgorithmName { get; private set; }

	public byte[] PublicKeyData { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + PublicKeyAlgorithmName.Length + 4 + PublicKeyData.Length;

	internal override void Process(Session session)
	{
		session.OnUserAuthenticationPublicKeyReceived(this);
	}

	protected override void LoadData()
	{
		PublicKeyAlgorithmName = ReadBinary();
		PublicKeyData = ReadBinary();
	}

	protected override void SaveData()
	{
		WriteBinaryString(PublicKeyAlgorithmName);
		WriteBinaryString(PublicKeyData);
	}
}
