using System;

namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_KEX_DH_GEX_INIT", 32)]
internal class KeyExchangeDhGroupExchangeInit : Message, IKeyExchangedAllowed
{
	public byte[] E { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + E.Length;

	public KeyExchangeDhGroupExchangeInit(byte[] clientExchangeValue)
	{
		E = clientExchangeValue;
	}

	protected override void LoadData()
	{
		E = ReadBinary();
	}

	protected override void SaveData()
	{
		WriteBinaryString(E);
	}

	internal override void Process(Session session)
	{
		throw new NotImplementedException();
	}
}
