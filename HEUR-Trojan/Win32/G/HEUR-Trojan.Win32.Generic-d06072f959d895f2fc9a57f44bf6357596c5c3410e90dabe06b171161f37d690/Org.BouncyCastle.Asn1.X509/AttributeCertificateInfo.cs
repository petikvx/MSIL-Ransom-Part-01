using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509;

public class AttributeCertificateInfo : Asn1Encodable
{
	internal readonly DerInteger version;

	internal readonly Holder holder;

	internal readonly AttCertIssuer issuer;

	internal readonly AlgorithmIdentifier signature;

	internal readonly DerInteger serialNumber;

	internal readonly AttCertValidityPeriod attrCertValidityPeriod;

	internal readonly Asn1Sequence attributes;

	internal readonly DerBitString issuerUniqueID;

	internal readonly X509Extensions extensions;

	public DerInteger Version => version;

	public Holder Holder => holder;

	public AttCertIssuer Issuer => issuer;

	public AlgorithmIdentifier Signature => signature;

	public DerInteger SerialNumber => serialNumber;

	public AttCertValidityPeriod AttrCertValidityPeriod => attrCertValidityPeriod;

	public Asn1Sequence Attributes => attributes;

	public DerBitString IssuerUniqueID => issuerUniqueID;

	public X509Extensions Extensions => extensions;

	public static AttributeCertificateInfo GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, isExplicit));
	}

	public static AttributeCertificateInfo GetInstance(object obj)
	{
		if (obj is AttributeCertificateInfo)
		{
			return (AttributeCertificateInfo)obj;
		}
		if (!(obj is Asn1Sequence))
		{
			throw new ArgumentException("unknown object in factory: " + Platform.GetTypeName(obj), "obj");
		}
		return new AttributeCertificateInfo((Asn1Sequence)obj);
	}

	private AttributeCertificateInfo(Asn1Sequence seq)
	{
		if (seq.Count >= 6 && seq.Count <= 9)
		{
			int num;
			if (seq[0] is DerInteger)
			{
				version = DerInteger.GetInstance(seq[0]);
				num = 1;
			}
			else
			{
				version = new DerInteger(0);
				num = 0;
			}
			holder = Holder.GetInstance(seq[num]);
			issuer = AttCertIssuer.GetInstance(seq[num + 1]);
			signature = AlgorithmIdentifier.GetInstance(seq[num + 2]);
			serialNumber = DerInteger.GetInstance(seq[num + 3]);
			attrCertValidityPeriod = AttCertValidityPeriod.GetInstance(seq[num + 4]);
			attributes = Asn1Sequence.GetInstance(seq[num + 5]);
			for (int i = num + 6; i < seq.Count; i++)
			{
				Asn1Encodable asn1Encodable = seq[i];
				if (asn1Encodable is DerBitString)
				{
					issuerUniqueID = DerBitString.GetInstance(seq[i]);
				}
				else if (asn1Encodable is Asn1Sequence || asn1Encodable is X509Extensions)
				{
					extensions = X509Extensions.GetInstance(seq[i]);
				}
			}
			return;
		}
		throw new ArgumentException("Bad sequence size: " + seq.Count);
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector(9);
		if (!version.HasValue(0))
		{
			asn1EncodableVector.Add(version);
		}
		asn1EncodableVector.Add(holder, issuer, signature, serialNumber, attrCertValidityPeriod, attributes);
		asn1EncodableVector.AddOptional(issuerUniqueID, extensions);
		return new DerSequence(asn1EncodableVector);
	}
}
