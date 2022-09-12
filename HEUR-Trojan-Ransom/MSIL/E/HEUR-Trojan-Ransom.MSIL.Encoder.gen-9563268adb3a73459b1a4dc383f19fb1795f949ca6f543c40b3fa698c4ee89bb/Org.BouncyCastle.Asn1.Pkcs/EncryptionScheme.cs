using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs;

public class EncryptionScheme : AlgorithmIdentifier
{
	public Asn1Object Asn1Object => Parameters.ToAsn1Object();

	public EncryptionScheme(DerObjectIdentifier objectID, Asn1Encodable parameters)
		: base(objectID, parameters)
	{
	}

	internal EncryptionScheme(Asn1Sequence seq)
		: this((DerObjectIdentifier)seq[0], seq[1])
	{
	}

	public new static EncryptionScheme GetInstance(object obj)
	{
		if (obj is EncryptionScheme)
		{
			return (EncryptionScheme)obj;
		}
		if (!(obj is Asn1Sequence))
		{
			throw new ArgumentException("Unknown object in factory: " + Platform.GetTypeName(obj), "obj");
		}
		return new EncryptionScheme((Asn1Sequence)obj);
	}

	public override Asn1Object ToAsn1Object()
	{
		return new DerSequence(Algorithm, Parameters);
	}
}
