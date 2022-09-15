using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Bcpg;

public class ECDHPublicBcpgKey : ECPublicBcpgKey
{
	private byte reserved;

	private HashAlgorithmTag hashFunctionId;

	private SymmetricKeyAlgorithmTag symAlgorithmId;

	public virtual byte Reserved => reserved;

	public virtual HashAlgorithmTag HashAlgorithm => hashFunctionId;

	public virtual SymmetricKeyAlgorithmTag SymmetricKeyAlgorithm => symAlgorithmId;

	public ECDHPublicBcpgKey(BcpgInputStream bcpgIn)
		: base(bcpgIn)
	{
		byte[] array = new byte[bcpgIn.ReadByte()];
		if (array.Length != 3)
		{
			throw new InvalidOperationException("kdf parameters size of 3 expected.");
		}
		bcpgIn.ReadFully(array);
		reserved = array[0];
		hashFunctionId = (HashAlgorithmTag)array[1];
		symAlgorithmId = (SymmetricKeyAlgorithmTag)array[2];
		VerifyHashAlgorithm();
		VerifySymmetricKeyAlgorithm();
	}

	public ECDHPublicBcpgKey(DerObjectIdentifier oid, ECPoint point, HashAlgorithmTag hashAlgorithm, SymmetricKeyAlgorithmTag symmetricKeyAlgorithm)
		: base(oid, point)
	{
		reserved = 1;
		hashFunctionId = hashAlgorithm;
		symAlgorithmId = symmetricKeyAlgorithm;
		VerifyHashAlgorithm();
		VerifySymmetricKeyAlgorithm();
	}

	public override void Encode(BcpgOutputStream bcpgOut)
	{
		base.Encode(bcpgOut);
		bcpgOut.WriteByte(3);
		bcpgOut.WriteByte(reserved);
		bcpgOut.WriteByte((byte)hashFunctionId);
		bcpgOut.WriteByte((byte)symAlgorithmId);
	}

	private void VerifyHashAlgorithm()
	{
		HashAlgorithmTag hashAlgorithmTag = hashFunctionId;
		if ((uint)(hashAlgorithmTag - 8) > 2u)
		{
			throw new InvalidOperationException("Hash algorithm must be SHA-256 or stronger.");
		}
	}

	private void VerifySymmetricKeyAlgorithm()
	{
		SymmetricKeyAlgorithmTag symmetricKeyAlgorithmTag = symAlgorithmId;
		if ((uint)(symmetricKeyAlgorithmTag - 7) > 2u)
		{
			throw new InvalidOperationException("Symmetric key algorithm must be AES-128 or stronger.");
		}
	}
}
