using System;

namespace Org.BouncyCastle.Asn1.Pkcs;

public class AuthenticatedSafe : Asn1Encodable
{
	private readonly ContentInfo[] info;

	private readonly bool isBer;

	private static ContentInfo[] Copy(ContentInfo[] info)
	{
		return (ContentInfo[])info.Clone();
	}

	public static AuthenticatedSafe GetInstance(object obj)
	{
		if (obj is AuthenticatedSafe)
		{
			return (AuthenticatedSafe)obj;
		}
		if (obj == null)
		{
			return null;
		}
		return new AuthenticatedSafe(Asn1Sequence.GetInstance(obj));
	}

	[Obsolete("Use 'GetInstance' instead")]
	public AuthenticatedSafe(Asn1Sequence seq)
	{
		info = new ContentInfo[seq.Count];
		for (int i = 0; i != info.Length; i++)
		{
			info[i] = ContentInfo.GetInstance(seq[i]);
		}
		isBer = seq is BerSequence;
	}

	public AuthenticatedSafe(ContentInfo[] info)
	{
		this.info = Copy(info);
		isBer = true;
	}

	public ContentInfo[] GetContentInfo()
	{
		return Copy(info);
	}

	public override Asn1Object ToAsn1Object()
	{
		Asn1Encodable[] elements;
		if (isBer)
		{
			elements = info;
			return new BerSequence(elements);
		}
		elements = info;
		return new DerSequence(elements);
	}
}
