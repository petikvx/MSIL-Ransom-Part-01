using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Tsp;

public class MessageImprint : Asn1Encodable
{
	private readonly AlgorithmIdentifier hashAlgorithm;

	private readonly byte[] hashedMessage;

	public AlgorithmIdentifier HashAlgorithm => hashAlgorithm;

	public static MessageImprint GetInstance(object o)
	{
		if (o != null && !(o is MessageImprint))
		{
			if (o is Asn1Sequence)
			{
				return new MessageImprint((Asn1Sequence)o);
			}
			throw new ArgumentException("Unknown object in 'MessageImprint' factory: " + Platform.GetTypeName(o));
		}
		return (MessageImprint)o;
	}

	private MessageImprint(Asn1Sequence seq)
	{
		if (seq.Count != 2)
		{
			throw new ArgumentException("Wrong number of elements in sequence", "seq");
		}
		hashAlgorithm = AlgorithmIdentifier.GetInstance(seq[0]);
		hashedMessage = Asn1OctetString.GetInstance(seq[1]).GetOctets();
	}

	public MessageImprint(AlgorithmIdentifier hashAlgorithm, byte[] hashedMessage)
	{
		this.hashAlgorithm = hashAlgorithm;
		this.hashedMessage = hashedMessage;
	}

	public byte[] GetHashedMessage()
	{
		return hashedMessage;
	}

	public override Asn1Object ToAsn1Object()
	{
		return new DerSequence(hashAlgorithm, new DerOctetString(hashedMessage));
	}
}
