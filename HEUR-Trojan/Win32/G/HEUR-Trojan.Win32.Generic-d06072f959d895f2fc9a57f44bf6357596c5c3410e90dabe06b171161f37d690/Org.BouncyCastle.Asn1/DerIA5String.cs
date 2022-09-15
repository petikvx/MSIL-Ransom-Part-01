using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerIA5String : DerStringBase
{
	private readonly string str;

	public static DerIA5String GetInstance(object obj)
	{
		if (obj != null && !(obj is DerIA5String))
		{
			throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
		}
		return (DerIA5String)obj;
	}

	public static DerIA5String GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object @object = obj.GetObject();
		if (!isExplicit && !(@object is DerIA5String))
		{
			return new DerIA5String(((Asn1OctetString)@object).GetOctets());
		}
		return GetInstance(@object);
	}

	public DerIA5String(byte[] str)
		: this(Strings.FromAsciiByteArray(str), validate: false)
	{
	}

	public DerIA5String(string str)
		: this(str, validate: false)
	{
	}

	public DerIA5String(string str, bool validate)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (validate && !IsIA5String(str))
		{
			throw new ArgumentException("string contains illegal characters", "str");
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
		derOut.WriteEncoded(22, GetOctets());
	}

	protected override int Asn1GetHashCode()
	{
		return str.GetHashCode();
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerIA5String derIA5String))
		{
			return false;
		}
		return str.Equals(derIA5String.str);
	}

	public static bool IsIA5String(string str)
	{
		int num = 0;
		while (true)
		{
			if (num < str.Length)
			{
				if (str[num] > '\u007f')
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}
}
