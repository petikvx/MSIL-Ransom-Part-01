using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerNumericString : DerStringBase
{
	private readonly string str;

	public static DerNumericString GetInstance(object obj)
	{
		if (obj != null && !(obj is DerNumericString))
		{
			throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
		}
		return (DerNumericString)obj;
	}

	public static DerNumericString GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object @object = obj.GetObject();
		if (!isExplicit && !(@object is DerNumericString))
		{
			return new DerNumericString(Asn1OctetString.GetInstance(@object).GetOctets());
		}
		return GetInstance(@object);
	}

	public DerNumericString(byte[] str)
		: this(Strings.FromAsciiByteArray(str), validate: false)
	{
	}

	public DerNumericString(string str)
		: this(str, validate: false)
	{
	}

	public DerNumericString(string str, bool validate)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (validate && !IsNumericString(str))
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
		derOut.WriteEncoded(18, GetOctets());
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerNumericString derNumericString))
		{
			return false;
		}
		return str.Equals(derNumericString.str);
	}

	public static bool IsNumericString(string str)
	{
		int num = 0;
		while (true)
		{
			if (num < str.Length)
			{
				char c = str[num];
				if (c > '\u007f' || (c != ' ' && !char.IsDigit(c)))
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
