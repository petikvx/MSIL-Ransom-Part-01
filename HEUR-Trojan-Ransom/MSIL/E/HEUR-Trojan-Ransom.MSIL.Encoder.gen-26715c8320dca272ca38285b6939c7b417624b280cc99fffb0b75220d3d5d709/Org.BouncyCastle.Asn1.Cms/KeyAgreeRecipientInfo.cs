using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms;

public class KeyAgreeRecipientInfo : Asn1Encodable
{
	private DerInteger version;

	private OriginatorIdentifierOrKey originator;

	private Asn1OctetString ukm;

	private AlgorithmIdentifier keyEncryptionAlgorithm;

	private Asn1Sequence recipientEncryptedKeys;

	public DerInteger Version => version;

	public OriginatorIdentifierOrKey Originator => originator;

	public Asn1OctetString UserKeyingMaterial => ukm;

	public AlgorithmIdentifier KeyEncryptionAlgorithm => keyEncryptionAlgorithm;

	public Asn1Sequence RecipientEncryptedKeys => recipientEncryptedKeys;

	public KeyAgreeRecipientInfo(OriginatorIdentifierOrKey originator, Asn1OctetString ukm, AlgorithmIdentifier keyEncryptionAlgorithm, Asn1Sequence recipientEncryptedKeys)
	{
		version = new DerInteger(3);
		this.originator = originator;
		this.ukm = ukm;
		this.keyEncryptionAlgorithm = keyEncryptionAlgorithm;
		this.recipientEncryptedKeys = recipientEncryptedKeys;
	}

	public KeyAgreeRecipientInfo(Asn1Sequence seq)
	{
		int num = 0;
		num = 1;
		version = (DerInteger)seq[0];
		num = 2;
		originator = OriginatorIdentifierOrKey.GetInstance((Asn1TaggedObject)seq[1], explicitly: true);
		if (seq[2] is Asn1TaggedObject)
		{
			ukm = Asn1OctetString.GetInstance((Asn1TaggedObject)seq[num++], isExplicit: true);
		}
		keyEncryptionAlgorithm = AlgorithmIdentifier.GetInstance(seq[num++]);
		recipientEncryptedKeys = (Asn1Sequence)seq[num++];
	}

	public static KeyAgreeRecipientInfo GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, explicitly));
	}

	public static KeyAgreeRecipientInfo GetInstance(object obj)
	{
		if (obj != null && !(obj is KeyAgreeRecipientInfo))
		{
			if (obj is Asn1Sequence)
			{
				return new KeyAgreeRecipientInfo((Asn1Sequence)obj);
			}
			throw new ArgumentException("Illegal object in KeyAgreeRecipientInfo: " + Platform.GetTypeName(obj));
		}
		return (KeyAgreeRecipientInfo)obj;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector(version, new DerTaggedObject(explicitly: true, 0, originator));
		if (ukm != null)
		{
			asn1EncodableVector.Add(new DerTaggedObject(explicitly: true, 1, ukm));
		}
		asn1EncodableVector.Add(keyEncryptionAlgorithm, recipientEncryptedKeys);
		return new DerSequence(asn1EncodableVector);
	}
}
