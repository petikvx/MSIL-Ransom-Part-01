using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X9;

public class DHPublicKey : Asn1Encodable
{
	private readonly DerInteger y;

	public DerInteger Y => y;

	public static DHPublicKey GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		return GetInstance(DerInteger.GetInstance(obj, isExplicit));
	}

	public static DHPublicKey GetInstance(object obj)
	{
		if (obj != null && !(obj is DHPublicKey))
		{
			if (obj is DerInteger)
			{
				return new DHPublicKey((DerInteger)obj);
			}
			throw new ArgumentException("Invalid DHPublicKey: " + Platform.GetTypeName(obj), "obj");
		}
		return (DHPublicKey)obj;
	}

	public DHPublicKey(DerInteger y)
	{
		if (y == null)
		{
			throw new ArgumentNullException("y");
		}
		this.y = y;
	}

	public override Asn1Object ToAsn1Object()
	{
		return y;
	}
}
