using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_KEXDH_REPLY", 31)]
public class KeyExchangeDhReplyMessage : Message
{
	private byte[] _fBytes;

	public byte[] HostKey { get; private set; }

	public BigInteger F => _fBytes.ToBigInteger();

	public byte[] Signature { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + HostKey.Length + 4 + _fBytes.Length + 4 + Signature.Length;

	protected override void LoadData()
	{
		HostKey = ReadBinary();
		_fBytes = ReadBinary();
		Signature = ReadBinary();
	}

	protected override void SaveData()
	{
		WriteBinaryString(HostKey);
		WriteBinaryString(_fBytes);
		WriteBinaryString(Signature);
	}

	internal override void Process(Session session)
	{
		session.OnKeyExchangeDhReplyMessageReceived(this);
	}
}
