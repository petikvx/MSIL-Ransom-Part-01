using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.Pkcs;

public class Pfx : Asn1Encodable
{
	private ContentInfo contentInfo;

	private MacData macData;

	public ContentInfo AuthSafe => contentInfo;

	public MacData MacData => macData;

	public Pfx(Asn1Sequence seq)
	{
		BigInteger value = ((DerInteger)seq[0]).Value;
		if (value.IntValue != 3)
		{
			throw new ArgumentException("wrong version for PFX PDU");
		}
		contentInfo = ContentInfo.GetInstance(seq[1]);
		if (seq.Count == 3)
		{
			macData = MacData.GetInstance(seq[2]);
		}
	}

	public Pfx(ContentInfo contentInfo, MacData macData)
	{
		this.contentInfo = contentInfo;
		this.macData = macData;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector(new DerInteger(3), contentInfo);
		if (macData != null)
		{
			asn1EncodableVector.Add(macData);
		}
		return new BerSequence(asn1EncodableVector);
	}
}
