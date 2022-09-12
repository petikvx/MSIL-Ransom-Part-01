using System;

namespace Org.BouncyCastle.Asn1.X509;

public class PolicyInformation : Asn1Encodable
{
	private readonly DerObjectIdentifier policyIdentifier;

	private readonly Asn1Sequence policyQualifiers;

	public DerObjectIdentifier PolicyIdentifier => policyIdentifier;

	public Asn1Sequence PolicyQualifiers => policyQualifiers;

	private PolicyInformation(Asn1Sequence seq)
	{
		if (seq.Count >= 1 && seq.Count <= 2)
		{
			policyIdentifier = DerObjectIdentifier.GetInstance(seq[0]);
			if (seq.Count > 1)
			{
				policyQualifiers = Asn1Sequence.GetInstance(seq[1]);
			}
			return;
		}
		throw new ArgumentException("Bad sequence size: " + seq.Count);
	}

	public PolicyInformation(DerObjectIdentifier policyIdentifier)
	{
		this.policyIdentifier = policyIdentifier;
	}

	public PolicyInformation(DerObjectIdentifier policyIdentifier, Asn1Sequence policyQualifiers)
	{
		this.policyIdentifier = policyIdentifier;
		this.policyQualifiers = policyQualifiers;
	}

	public static PolicyInformation GetInstance(object obj)
	{
		if (obj != null && !(obj is PolicyInformation))
		{
			return new PolicyInformation(Asn1Sequence.GetInstance(obj));
		}
		return (PolicyInformation)obj;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector(policyIdentifier);
		if (policyQualifiers != null)
		{
			asn1EncodableVector.Add(policyQualifiers);
		}
		return new DerSequence(asn1EncodableVector);
	}
}
