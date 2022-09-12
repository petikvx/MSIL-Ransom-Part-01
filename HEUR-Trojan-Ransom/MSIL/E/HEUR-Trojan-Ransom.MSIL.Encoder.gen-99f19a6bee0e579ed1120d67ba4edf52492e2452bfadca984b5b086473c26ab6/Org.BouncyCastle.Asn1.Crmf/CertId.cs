using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Crmf;

public class CertId : Asn1Encodable
{
	private readonly GeneralName issuer;

	private readonly DerInteger serialNumber;

	public virtual GeneralName Issuer => issuer;

	public virtual DerInteger SerialNumber => serialNumber;

	private CertId(Asn1Sequence seq)
	{
		issuer = GeneralName.GetInstance(seq[0]);
		serialNumber = DerInteger.GetInstance(seq[1]);
	}

	public static CertId GetInstance(object obj)
	{
		if (obj is CertId)
		{
			return (CertId)obj;
		}
		if (!(obj is Asn1Sequence))
		{
			throw new ArgumentException("Invalid object: " + Platform.GetTypeName(obj), "obj");
		}
		return new CertId((Asn1Sequence)obj);
	}

	public static CertId GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, isExplicit));
	}

	public override Asn1Object ToAsn1Object()
	{
		return new DerSequence(issuer, serialNumber);
	}
}
