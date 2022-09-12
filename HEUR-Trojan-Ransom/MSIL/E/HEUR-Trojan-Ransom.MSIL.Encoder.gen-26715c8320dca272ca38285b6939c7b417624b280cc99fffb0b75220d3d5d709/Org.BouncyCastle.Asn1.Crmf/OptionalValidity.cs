using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Crmf;

public class OptionalValidity : Asn1Encodable
{
	private readonly Time notBefore;

	private readonly Time notAfter;

	public virtual Time NotBefore => notBefore;

	public virtual Time NotAfter => notAfter;

	private OptionalValidity(Asn1Sequence seq)
	{
		foreach (Asn1TaggedObject item in seq)
		{
			if (item.TagNo == 0)
			{
				notBefore = Time.GetInstance(item, explicitly: true);
			}
			else
			{
				notAfter = Time.GetInstance(item, explicitly: true);
			}
		}
	}

	public static OptionalValidity GetInstance(object obj)
	{
		if (obj != null && !(obj is OptionalValidity))
		{
			return new OptionalValidity(Asn1Sequence.GetInstance(obj));
		}
		return (OptionalValidity)obj;
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1EncodableVector asn1EncodableVector = new Asn1EncodableVector();
		if (notBefore != null)
		{
			asn1EncodableVector.Add(new DerTaggedObject(explicitly: true, 0, notBefore));
		}
		if (notAfter != null)
		{
			asn1EncodableVector.Add(new DerTaggedObject(explicitly: true, 1, notAfter));
		}
		return new DerSequence(asn1EncodableVector);
	}
}
