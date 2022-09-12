using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cms;

public class Evidence : Asn1Encodable, IAsn1Choice
{
	private TimeStampTokenEvidence tstEvidence;

	public virtual TimeStampTokenEvidence TstEvidence => tstEvidence;

	public Evidence(TimeStampTokenEvidence tstEvidence)
	{
		this.tstEvidence = tstEvidence;
	}

	private Evidence(Asn1TaggedObject tagged)
	{
		if (tagged.TagNo == 0)
		{
			tstEvidence = TimeStampTokenEvidence.GetInstance(tagged, isExplicit: false);
		}
	}

	public static Evidence GetInstance(object obj)
	{
		if (obj is Evidence)
		{
			return (Evidence)obj;
		}
		if (!(obj is Asn1TaggedObject))
		{
			throw new ArgumentException("Unknown object in GetInstance: " + Platform.GetTypeName(obj), "obj");
		}
		return new Evidence(Asn1TaggedObject.GetInstance(obj));
	}

	public override Asn1Object ToAsn1Object()
	{
		if (tstEvidence != null)
		{
			return new DerTaggedObject(explicitly: false, 0, tstEvidence);
		}
		return null;
	}
}
