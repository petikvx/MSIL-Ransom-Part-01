using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509;

public class TbsCertificateStructure : Asn1Encodable
{
	internal Asn1Sequence seq;

	internal DerInteger version;

	internal DerInteger serialNumber;

	internal AlgorithmIdentifier signature;

	internal X509Name issuer;

	internal Time startDate;

	internal Time endDate;

	internal X509Name subject;

	internal SubjectPublicKeyInfo subjectPublicKeyInfo;

	internal DerBitString issuerUniqueID;

	internal DerBitString subjectUniqueID;

	internal X509Extensions extensions;

	public int Version => version.IntValueExact + 1;

	public DerInteger VersionNumber => version;

	public DerInteger SerialNumber => serialNumber;

	public AlgorithmIdentifier Signature => signature;

	public X509Name Issuer => issuer;

	public Time StartDate => startDate;

	public Time EndDate => endDate;

	public X509Name Subject => subject;

	public SubjectPublicKeyInfo SubjectPublicKeyInfo => subjectPublicKeyInfo;

	public DerBitString IssuerUniqueID => issuerUniqueID;

	public DerBitString SubjectUniqueID => subjectUniqueID;

	public X509Extensions Extensions => extensions;

	public static TbsCertificateStructure GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, explicitly));
	}

	public static TbsCertificateStructure GetInstance(object obj)
	{
		if (obj is TbsCertificateStructure)
		{
			return (TbsCertificateStructure)obj;
		}
		if (obj != null)
		{
			return new TbsCertificateStructure(Asn1Sequence.GetInstance(obj));
		}
		return null;
	}

	internal TbsCertificateStructure(Asn1Sequence seq)
	{
		int num = 0;
		this.seq = seq;
		if (seq[0] is Asn1TaggedObject)
		{
			version = DerInteger.GetInstance((Asn1TaggedObject)seq[0], isExplicit: true);
		}
		else
		{
			num = -1;
			version = new DerInteger(0);
		}
		bool flag = false;
		bool flag2 = false;
		if (version.HasValue(0))
		{
			flag = true;
		}
		else if (version.HasValue(1))
		{
			flag2 = true;
		}
		else if (!version.HasValue(2))
		{
			throw new ArgumentException("version number not recognised");
		}
		serialNumber = DerInteger.GetInstance(seq[num + 1]);
		signature = AlgorithmIdentifier.GetInstance(seq[num + 2]);
		issuer = X509Name.GetInstance(seq[num + 3]);
		Asn1Sequence asn1Sequence = (Asn1Sequence)seq[num + 4];
		startDate = Time.GetInstance(asn1Sequence[0]);
		endDate = Time.GetInstance(asn1Sequence[1]);
		subject = X509Name.GetInstance(seq[num + 5]);
		subjectPublicKeyInfo = SubjectPublicKeyInfo.GetInstance(seq[num + 6]);
		int num2 = seq.Count - (num + 6) - 1;
		if (num2 != 0 && flag)
		{
			throw new ArgumentException("version 1 certificate contains extra data");
		}
		while (num2 > 0)
		{
			Asn1TaggedObject instance = Asn1TaggedObject.GetInstance(seq[num + 6 + num2]);
			switch (instance.TagNo)
			{
			case 1:
				issuerUniqueID = DerBitString.GetInstance(instance, isExplicit: false);
				break;
			case 2:
				subjectUniqueID = DerBitString.GetInstance(instance, isExplicit: false);
				break;
			case 3:
				if (!flag2)
				{
					extensions = X509Extensions.GetInstance(Asn1Sequence.GetInstance(instance, explicitly: true));
					break;
				}
				throw new ArgumentException("version 2 certificate cannot contain extensions");
			default:
				throw new ArgumentException("Unknown tag encountered in structure: " + instance.TagNo);
			}
			num2--;
		}
	}

	public override Asn1Object ToAsn1Object()
	{
		string environmentVariable = Platform.GetEnvironmentVariable("Org.BouncyCastle.X509.Allow_Non-DER_TBSCert");
		if (environmentVariable != null && !Platform.EqualsIgnoreCase("true", environmentVariable))
		{
			Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector();
			if (!version.HasValue(0))
			{
				asn1EncodableVector.Add(new DerTaggedObject(explicitly: true, 0, version));
			}
			asn1EncodableVector.Add(serialNumber, signature, issuer);
			asn1EncodableVector.Add(new DerSequence(startDate, endDate));
			if (subject != null)
			{
				asn1EncodableVector.Add(subject);
			}
			else
			{
				asn1EncodableVector.Add(DerSequence.Empty);
			}
			asn1EncodableVector.Add(subjectPublicKeyInfo);
			asn1EncodableVector.AddOptionalTagged(isExplicit: false, 1, issuerUniqueID);
			asn1EncodableVector.AddOptionalTagged(isExplicit: false, 2, subjectUniqueID);
			asn1EncodableVector.AddOptionalTagged(isExplicit: true, 3, extensions);
			return new DerSequence(asn1EncodableVector);
		}
		return seq;
	}
}
