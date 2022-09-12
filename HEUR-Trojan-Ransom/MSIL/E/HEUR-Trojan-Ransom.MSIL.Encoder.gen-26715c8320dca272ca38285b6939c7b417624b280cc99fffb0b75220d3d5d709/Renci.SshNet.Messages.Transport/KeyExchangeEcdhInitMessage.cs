using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Messages.Transport;

[Message("SSH_MSG_KEX_ECDH_INIT", 30)]
internal class KeyExchangeEcdhInitMessage : Message, IKeyExchangedAllowed
{
	public byte[] QC { get; private set; }

	protected override int BufferCapacity => base.BufferCapacity + 4 + QC.Length;

	public KeyExchangeEcdhInitMessage(byte[] q)
	{
		QC = q;
	}

	public KeyExchangeEcdhInitMessage(BigInteger d, BigInteger q)
	{
		byte[] array = d.ToByteArray().Reverse();
		byte[] array2 = q.ToByteArray().Reverse();
		byte[] array3 = new byte[array.Length + array2.Length + 1];
		array3[0] = 4;
		Buffer.BlockCopy(array, 0, array3, 1, array.Length);
		Buffer.BlockCopy(array2, 0, array3, array.Length + 1, array2.Length);
		QC = array3;
	}

	protected override void LoadData()
	{
		QC = ReadBinary();
	}

	protected override void SaveData()
	{
		WriteBinaryString(QC);
	}

	internal override void Process(Session session)
	{
		throw new NotImplementedException();
	}
}
