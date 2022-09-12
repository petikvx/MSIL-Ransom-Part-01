using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Crmf;

public class Controls : Asn1Encodable
{
	private readonly Asn1Sequence content;

	private Controls(Asn1Sequence seq)
	{
		content = seq;
	}

	public static Controls GetInstance(object obj)
	{
		if (obj is Controls)
		{
			return (Controls)obj;
		}
		if (!(obj is Asn1Sequence))
		{
			throw new ArgumentException("Invalid object: " + Platform.GetTypeName(obj), "obj");
		}
		return new Controls((Asn1Sequence)obj);
	}

	public Controls(params AttributeTypeAndValue[] atvs)
	{
		content = new DerSequence(atvs);
	}

	public virtual AttributeTypeAndValue[] ToAttributeTypeAndValueArray()
	{
		AttributeTypeAndValue[] array = new AttributeTypeAndValue[content.Count];
		for (int i = 0; i != array.Length; i++)
		{
			array[i] = AttributeTypeAndValue.GetInstance(content[i]);
		}
		return array;
	}

	public override Asn1Object ToAsn1Object()
	{
		return content;
	}
}
