using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_KEX_DH_GEX_INIT", 32)]
internal class KeyExchangeDhGroupExchangeInit : Message, IKeyExchangedAllowed
{
	private byte[] _eBytes;

	public BigInteger E => _eBytes.ToBigInteger();

	protected override int BufferCapacity => base.BufferCapacity + 4 + _eBytes.Length;

	public KeyExchangeDhGroupExchangeInit(BigInteger clientExchangeValue)
	{
		_eBytes = clientExchangeValue.ToByteArray().Reverse();
	}

	protected override void LoadData()
	{
		_eBytes = ReadBinary();
	}

	protected override void SaveData()
	{
		WriteBinaryString(_eBytes);
	}

	internal override void Process(Session session)
	{
		throw new NotImplementedException();
	}
}
