using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509;

public class AttCertValidityPeriod : Asn1Encodable
{
	private readonly DerGeneralizedTime notBeforeTime;

	private readonly DerGeneralizedTime notAfterTime;

	public DerGeneralizedTime NotBeforeTime => notBeforeTime;

	public DerGeneralizedTime NotAfterTime => notAfterTime;

	public static AttCertValidityPeriod GetInstance(object obj)
	{
		if (!(obj is AttCertValidityPeriod) && obj != null)
		{
			if (obj is Asn1Sequence)
			{
				return new AttCertValidityPeriod((Asn1Sequence)obj);
			}
			throw new ArgumentException("unknown object in factory: " + Platform.GetTypeName(obj), "obj");
		}
		return (AttCertValidityPeriod)obj;
	}

	public static AttCertValidityPeriod GetInstance(Asn1TaggedObject obj, bool explicitly)
	{
		return GetInstance(Asn1Sequence.GetInstance(obj, explicitly));
	}

	private AttCertValidityPeriod(Asn1Sequence seq)
	{
		if (seq.Count != 2)
		{
			throw new ArgumentException("Bad sequence size: " + seq.Count);
		}
		notBeforeTime = DerGeneralizedTime.GetInstance(seq[0]);
		notAfterTime = DerGeneralizedTime.GetInstance(seq[1]);
	}

	public AttCertValidityPeriod(DerGeneralizedTime notBeforeTime, DerGeneralizedTime notAfterTime)
	{
		this.notBeforeTime = notBeforeTime;
		this.notAfterTime = notAfterTime;
	}

	public override Asn1Object ToAsn1Object()
	{
		return new DerSequence(notBeforeTime, notAfterTime);
	}
}
