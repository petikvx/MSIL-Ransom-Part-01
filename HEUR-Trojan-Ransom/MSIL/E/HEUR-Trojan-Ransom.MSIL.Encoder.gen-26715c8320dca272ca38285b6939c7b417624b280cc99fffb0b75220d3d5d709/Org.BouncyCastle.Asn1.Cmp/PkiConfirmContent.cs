using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp;

public class PkiConfirmContent : Asn1Encodable
{
	public static PkiConfirmContent GetInstance(object obj)
	{
		if (obj is PkiConfirmContent)
		{
			return (PkiConfirmContent)obj;
		}
		if (!(obj is Asn1Null))
		{
			throw new ArgumentException("Invalid object: " + Platform.GetTypeName(obj), "obj");
		}
		return new PkiConfirmContent();
	}

	public override Asn1Object ToAsn1Object()
	{
		return DerNull.Instance;
	}
}
