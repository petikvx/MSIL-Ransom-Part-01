using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp;

public class RevReqContent : Asn1Encodable
{
	private readonly Asn1Sequence content;

	private RevReqContent(Asn1Sequence seq)
	{
		content = seq;
	}

	public static RevReqContent GetInstance(object obj)
	{
		if (obj is RevReqContent)
		{
			return (RevReqContent)obj;
		}
		if (!(obj is Asn1Sequence))
		{
			throw new ArgumentException("Invalid object: " + Platform.GetTypeName(obj), "obj");
		}
		return new RevReqContent((Asn1Sequence)obj);
	}

	public RevReqContent(params RevDetails[] revDetails)
	{
		content = new DerSequence(revDetails);
	}

	public virtual RevDetails[] ToRevDetailsArray()
	{
		RevDetails[] array = new RevDetails[content.Count];
		for (int i = 0; i != array.Length; i++)
		{
			array[i] = RevDetails.GetInstance(content[i]);
		}
		return array;
	}

	public override Asn1Object ToAsn1Object()
	{
		return content;
	}
}
