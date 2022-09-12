using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_KEX_DH_GEX_GROUP", 31)]
public class KeyExchangeDhGroupExchangeGroup : Message
{
	internal const byte MessageNumber = 31;

	private byte[] _safePrime;

	private byte[] _subGroup;

	public BigInteger SafePrime => _safePrime.ToBigInteger();

	public BigInteger SubGroup => _subGroup.ToBigInteger();

	protected override int BufferCapacity => base.BufferCapacity + 4 + _safePrime.Length + 4 + _subGroup.Length;

	protected override void LoadData()
	{
		_safePrime = ReadBinary();
		_subGroup = ReadBinary();
	}

	protected override void SaveData()
	{
		WriteBinaryString(_safePrime);
		WriteBinaryString(_subGroup);
	}

	internal override void Process(Session session)
	{
		session.OnKeyExchangeDhGroupExchangeGroupReceived(this);
	}
}
