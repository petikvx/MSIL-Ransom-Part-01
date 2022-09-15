using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Ess;

public class SigningCertificateV2 : Asn1Encodable
{
	private readonly Asn1Sequence certs;

	private readonly Asn1Sequence policies;

	public static SigningCertificateV2 GetInstance(object o)
	{
		if (o != null && !(o is SigningCertificateV2))
		{
			if (o is Asn1Sequence)
			{
				return new SigningCertificateV2((Asn1Sequence)o);
			}
			throw new ArgumentException("unknown object in 'SigningCertificateV2' factory : " + Platform.GetTypeName(o) + ".");
		}
		return (SigningCertificateV2)o;
	}

	private SigningCertificateV2(Asn1Sequence seq)
	{
		if (seq.Count >= 1 && seq.Count <= 2)
		{
			certs = Asn1Sequence.GetInstance(seq[0].ToAsn1Object());
			if (seq.Count > 1)
			{
				policies = Asn1Sequence.GetInstance(seq[1].ToAsn1Object());
			}
			return;
		}
		throw new ArgumentException("Bad sequence size: " + seq.Count, "seq");
	}

	public SigningCertificateV2(EssCertIDv2 cert)
	{
		certs = new DerSequence(cert);
	}

	public SigningCertificateV2(EssCertIDv2[] certs)
	{
		this.certs = new DerSequence(certs);
	}

	public SigningCertificateV2(EssCertIDv2[] certs, PolicyInformation[] policies)
	{
		Asn1Encodable[] elements = certs;
		this.certs = new DerSequence(elements);
		if (policies != null)
		{
			elements = policies;
			this.policies = new DerSequence(elements);
		}
	}

	public EssCertIDv2[] GetCerts()
	{
		EssCertIDv2[] array = new EssCertIDv2[certs.Count];
		for (int i = 0; i != certs.Count; i++)
		{
			array[i] = EssCertIDv2.GetInstance(certs[i]);
		}
		return array;
	}

	public PolicyInformation[] GetPolicies()
	{
		if (policies == null)
		{
			return null;
		}
		PolicyInformation[] array = new PolicyInformation[policies.Count];
		for (int i = 0; i != policies.Count; i++)
		{
			array[i] = PolicyInformation.GetInstance(policies[i]);
		}
		return array;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector(certs);
		asn1EncodableVector.AddOptional(policies);
		return new DerSequence(asn1EncodableVector);
	}
}
