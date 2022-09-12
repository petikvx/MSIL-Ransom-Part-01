using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Security.Cryptography;

public abstract class CipherDigitalSignature : DigitalSignature
{
	private readonly AsymmetricCipher _cipher;

	private readonly ObjectIdentifier _oid;

	protected CipherDigitalSignature(ObjectIdentifier oid, AsymmetricCipher cipher)
	{
		if (cipher == null)
		{
			throw new ArgumentNullException("cipher");
		}
		_cipher = cipher;
		_oid = oid;
	}

	public override bool Verify(byte[] input, byte[] signature)
	{
		byte[] right = _cipher.Decrypt(signature);
		byte[] hashData = Hash(input);
		return DerEncode(hashData).IsEqualTo(right);
	}

	public override byte[] Sign(byte[] input)
	{
		byte[] hashData = Hash(input);
		byte[] input2 = DerEncode(hashData);
		return _cipher.Encrypt(input2).TrimLeadingZeros();
	}

	protected abstract byte[] Hash(byte[] input);

	protected byte[] DerEncode(byte[] hashData)
	{
		DerData derData = new DerData();
		derData.Write(_oid);
		derData.WriteNull();
		DerData derData2 = new DerData();
		derData2.Write(derData);
		derData2.Write(hashData);
		return derData2.Encode();
	}
}
