using System;
using System.Collections;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.Asn1.Esf;

public class CompleteRevocationRefs : Asn1Encodable
{
	private readonly Asn1Sequence crlOcspRefs;

	public static CompleteRevocationRefs GetInstance(object obj)
	{
		if (obj != null && !(obj is CompleteRevocationRefs))
		{
			if (obj is Asn1Sequence)
			{
				return new CompleteRevocationRefs((Asn1Sequence)obj);
			}
			throw new ArgumentException("Unknown object in 'CompleteRevocationRefs' factory: " + Platform.GetTypeName(obj), "obj");
		}
		return (CompleteRevocationRefs)obj;
	}

	private CompleteRevocationRefs(Asn1Sequence seq)
	{
		if (seq == null)
		{
			throw new ArgumentNullException("seq");
		}
		foreach (Asn1Encodable item in seq)
		{
			CrlOcspRef.GetInstance(item.ToAsn1Object());
		}
		crlOcspRefs = seq;
	}

	public CompleteRevocationRefs(params CrlOcspRef[] crlOcspRefs)
	{
		if (crlOcspRefs == null)
		{
			throw new ArgumentNullException("crlOcspRefs");
		}
		this.crlOcspRefs = new DerSequence(crlOcspRefs);
	}

	public CompleteRevocationRefs(IEnumerable crlOcspRefs)
	{
		if (crlOcspRefs == null)
		{
			throw new ArgumentNullException("crlOcspRefs");
		}
		if (!CollectionUtilities.CheckElementsAreOfType(crlOcspRefs, typeof(CrlOcspRef)))
		{
			throw new ArgumentException("Must contain only 'CrlOcspRef' objects", "crlOcspRefs");
		}
		this.crlOcspRefs = new DerSequence(Asn1EncodableVector.FromEnumerable(crlOcspRefs));
	}

	public CrlOcspRef[] GetCrlOcspRefs()
	{
		CrlOcspRef[] array = new CrlOcspRef[crlOcspRefs.Count];
		for (int i = 0; i < crlOcspRefs.Count; i++)
		{
			array[i] = CrlOcspRef.GetInstance(crlOcspRefs[i].ToAsn1Object());
		}
		return array;
	}

	public override Asn1Object ToAsn1Object()
	{
		return crlOcspRefs;
	}
}
