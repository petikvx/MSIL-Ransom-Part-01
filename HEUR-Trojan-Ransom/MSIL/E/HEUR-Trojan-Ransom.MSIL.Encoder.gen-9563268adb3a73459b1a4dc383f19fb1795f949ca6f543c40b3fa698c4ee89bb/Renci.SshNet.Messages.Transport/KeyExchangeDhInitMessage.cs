using System;

namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_KEXDH_INIT", 30)]
internal class KeyExchangeDhInitMessage : Message, IKeyExchangedAllowed
{
	public byte[] E { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + E.Length;

	public KeyExchangeDhInitMessage(byte[] clientExchangeValue)
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
