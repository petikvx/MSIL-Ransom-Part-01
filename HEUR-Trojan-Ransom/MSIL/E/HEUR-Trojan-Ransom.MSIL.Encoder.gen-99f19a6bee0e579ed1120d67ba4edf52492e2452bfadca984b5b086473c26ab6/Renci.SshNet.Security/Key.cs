using System;
using System.Collections.Generic;
using Renci.SshNet.Common;
using Renci.SshNet.Security.Cryptography;

namespace Renci.SshNet.Security;

public abstract class Key
{
	protected BigInteger[] _privateKey;

	protected abstract DigitalSignature DigitalSignature { get; }

	public abstract BigInteger[] Public { get; set; }

	public abstract int KeyLength { get; }

	protected Key(byte[] data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		DerData derData = new DerData(data);
		derData.ReadBigInteger();
		List<BigInteger> list = new List<BigInteger>();
		while (!derData.IsEndOfData)
		{
			list.Add(derData.ReadBigInteger());
		}
		_privateKey = list.ToArray();
	}

	protected Key()
	{
	}

	public byte[] Sign(byte[] data)
	{
		return DigitalSignature.Sign(data);
	}

	public bool VerifySignature(byte[] data, byte[] signature)
	{
		return DigitalSignature.Verify(data, signature);
	}
}
