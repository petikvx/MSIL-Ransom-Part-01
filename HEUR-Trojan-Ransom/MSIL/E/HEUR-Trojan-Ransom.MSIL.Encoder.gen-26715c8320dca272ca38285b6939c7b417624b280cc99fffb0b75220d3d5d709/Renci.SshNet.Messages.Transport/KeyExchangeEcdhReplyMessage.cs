namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_KEX_ECDH_REPLY", 31)]
public class KeyExchangeEcdhReplyMessage : Message
{
	public byte[] KS { get; private set; }

	public byte[] QS { get; private set; }

	public byte[] Signature { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + KS.Length + 4 + QS.Length + 4 + Signature.Length;

	protected override void LoadData()
	{
		KS = ReadBinary();
		QS = ReadBinary();
		Signature = ReadBinary();
	}

	protected override void SaveData()
	{
		WriteBinaryString(KS);
		WriteBinaryString(QS);
		WriteBinaryString(Signature);
	}

	internal override void Process(Session session)
	{
		session.OnKeyExchangeEcdhReplyMessageReceived(this);
	}
}
