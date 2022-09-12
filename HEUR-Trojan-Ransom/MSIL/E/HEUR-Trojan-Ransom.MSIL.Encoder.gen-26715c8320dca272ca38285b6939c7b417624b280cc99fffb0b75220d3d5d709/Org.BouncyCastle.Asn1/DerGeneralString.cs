using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerGeneralString : DerStringBase
{
	private readonly string str;

	public static DerGeneralString GetInstance(object obj)
	{
		if (obj != null && !(obj is DerGeneralString))
		{
			throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
		}
		return (DerGeneralString)obj;
	}

	public static DerGeneralString GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object @object = obj.GetObject();
		if (!isExplicit && !(@object is DerGeneralString))
		{
			return new DerGeneralString(((Asn1OctetString)@object).GetOctets());
		}
		return GetInstance(@object);
	}

	public DerGeneralString(byte[] str)
		: this(Strings.FromAsciiByteArray(str))
	{
	}

	public DerGeneralString(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		this.str = str;
	}

	public override string GetString()
	{
		return str;
	}

	public byte[] GetOctets()
	{
		return Strings.ToAsciiByteArray(str);
	}

	internal override void Encode(DerOutputStream derOut)
	{
		derOut.WriteEncoded(27, GetOctets());
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerGeneralString derGeneralString))
		{
			return false;
		}
		return str.Equals(derGeneralString.str);
	}
}
