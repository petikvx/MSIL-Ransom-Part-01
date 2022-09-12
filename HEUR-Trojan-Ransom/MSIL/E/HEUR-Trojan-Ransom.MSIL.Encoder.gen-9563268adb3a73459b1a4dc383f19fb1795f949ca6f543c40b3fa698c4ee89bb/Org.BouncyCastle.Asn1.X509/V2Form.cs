using System;

namespace Org.BouncyCastle.Asn1.X509;

public class V2Form : Asn1Encodable
{
	internal GeneralNames issuerName;

	internal IssuerSerial baseCertificateID;

	internal ObjectDigestInfo objectDigestInfo;

	public GeneralNames IssuerName => issuerName;

	public IssuerSerial BaseCertificateID => baseCertificateID;

	public ObjectDigestInfo ObjectDigestInfo => objectDigestInfo;

	public static V2Form GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, explicitly));
	}

	public static V2Form GetInstance(object obj)
	{
		if (obj is V2Form)
		{
			return (V2Form)obj;
		}
		if (obj != null)
		{
			return new V2Form(Asn1Sequence.GetInstance(obj));
		}
		return null;
	}

	public V2Form(GeneralNames issuerName)
		: this(issuerName, null, null)
	{
	}

	public V2Form(GeneralNames issuerName, IssuerSerial baseCertificateID)
		: this(issuerName, baseCertificateID, null)
	{
	}

	public V2Form(GeneralNames issuerName, ObjectDigestInfo objectDigestInfo)
		: this(issuerName, null, objectDigestInfo)
	{
	}

	public V2Form(GeneralNames issuerName, IssuerSerial baseCertificateID, ObjectDigestInfo objectDigestInfo)
	{
		this.issuerName = issuerName;
		this.baseCertificateID = baseCertificateID;
		this.objectDigestInfo = objectDigestInfo;
	}

	private V2Form(Asn1Sequence seq)
	{
		if (seq.Count > 3)
		{
			throw new ArgumentException("Bad sequence size: " + seq.Count);
		}
		int num = 0;
		if (!(seq[0] is Asn1TaggedObject))
		{
			num++;
			issuerName = GeneralNames.GetInstance(seq[0]);
		}
		int num2 = num;
		Asn1TaggedObject instance;
		while (true)
		{
			if (num2 == seq.Count)
			{
				return;
			}
			instance = Asn1TaggedObject.GetInstance(seq[num2]);
			if (instance.TagNo == 0)
			{
				baseCertificateID = IssuerSerial.GetInstance(instance, explicitly: false);
			}
			else
			{
				if (instance.TagNo != 1)
				{
					break;
				}
				objectDigestInfo = ObjectDigestInfo.GetInstance(instance, isExplicit: false);
			}
			num2++;
		}
		throw new ArgumentException("Bad tag number: " + instance.TagNo);
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector();
		if (issuerName != null)
		{
			asn1EncodableVector.Add(issuerName);
		}
		if (baseCertificateID != null)
		{
			asn1EncodableVector.Add(new DerTaggedObject(explicitly: false, 0, baseCertificateID));
		}
		if (objectDigestInfo != null)
		{
			asn1EncodableVector.Add(new DerTaggedObject(explicitly: false, 1, objectDigestInfo));
		}
		return new DerSequence(asn1EncodableVector);
	}
}
