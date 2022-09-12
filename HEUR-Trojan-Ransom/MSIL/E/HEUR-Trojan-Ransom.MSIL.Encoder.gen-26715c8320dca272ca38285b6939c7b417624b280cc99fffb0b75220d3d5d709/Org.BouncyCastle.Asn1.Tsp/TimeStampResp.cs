using System;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Tsp;

public class TimeStampResp : Asn1Encodable
{
	private readonly PkiStatusInfo pkiStatusInfo;

	private readonly ContentInfo timeStampToken;

	public PkiStatusInfo Status => pkiStatusInfo;

	public ContentInfo TimeStampToken => timeStampToken;

	public static TimeStampResp GetInstance(object o)
	{
		if (o != null && !(o is TimeStampResp))
		{
			if (o is Asn1Sequence)
			{
				return new TimeStampResp((Asn1Sequence)o);
			}
			throw new ArgumentException("Unknown object in 'TimeStampResp' factory: " + Platform.GetTypeName(o));
		}
		return (TimeStampResp)o;
	}

	private TimeStampResp(Asn1Sequence seq)
	{
		pkiStatusInfo = PkiStatusInfo.GetInstance(seq[0]);
		if (seq.Count > 1)
		{
			timeStampToken = ContentInfo.GetInstance(seq[1]);
		}
	}

	public TimeStampResp(PkiStatusInfo pkiStatusInfo, ContentInfo timeStampToken)
	{
		this.pkiStatusInfo = pkiStatusInfo;
		this.timeStampToken = timeStampToken;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector(pkiStatusInfo);
		if (timeStampToken != null)
		{
			asn1EncodableVector.Add(timeStampToken);
		}
		return new DerSequence(asn1EncodableVector);
	}
}
