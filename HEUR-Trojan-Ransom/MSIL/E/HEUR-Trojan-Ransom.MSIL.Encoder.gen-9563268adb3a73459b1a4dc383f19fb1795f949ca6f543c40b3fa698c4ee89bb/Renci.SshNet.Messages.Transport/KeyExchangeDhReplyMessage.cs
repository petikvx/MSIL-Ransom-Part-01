namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_KEXDH_REPLY", 31)]
public class KeyExchangeDhReplyMessage : Message
{
	public byte[] HostKey { get; private set; }

	public byte[] F { get; private set; }

	public byte[] Signature { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + HostKey.Length + 4 + F.Length + 4 + Signature.Length;

	protected override void LoadData()
	{
		HostKey = ReadBinary();
		F = ReadBinary();
		Signature = ReadBinary();
	}

	protected override void SaveData()
	{
		WriteBinaryString(HostKey);
		WriteBinaryString(F);
		WriteBinaryString(Signature);
	}

	internal override void Process(Session session)
	{
		session.OnKeyExchangeDhReplyMessageReceived(this);
	}
}
