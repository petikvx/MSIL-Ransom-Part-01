using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerPrintableString : DerStringBase
{
	private readonly string str;

	public static DerPrintableString GetInstance(object obj)
	{
		if (obj != null && !(obj is DerPrintableString))
		{
			throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
		}
		return (DerPrintableString)obj;
	}

	public static DerPrintableString GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		Asn1Object @object = obj.GetObject();
		if (!isExplicit && !(@object is DerPrintableString))
		{
			return new DerPrintableString(Asn1OctetString.GetInstance(@object).GetOctets());
		}
		return GetInstance(@object);
	}

	public DerPrintableString(byte[] str)
		: this(Strings.FromAsciiByteArray(str), validate: false)
	{
	}

	public DerPrintableString(string str)
		: this(str, validate: false)
	{
	}

	public DerPrintableString(string str, bool validate)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (validate && !IsPrintableString(str))
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
		derOut.WriteEncoded(19, GetOctets());
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerPrintableString derPrintableString))
		{
			return false;
		}
		return str.Equals(derPrintableString.str);
	}

	public static bool IsPrintableString(string str)
	{
		int num = 0;
		while (true)
		{
			if (num < str.Length)
			{
				char c = str[num];
				if (c > '\u007f')
				{
					break;
				}
				if (!char.IsLetterOrDigit(c))
				{
					switch (c)
					{
					case ' ':
					case '\'':
					case '(':
					case ')':
					case '+':
					case ',':
					case '-':
					case '.':
					case '/':
					case ':':
					case '=':
					case '?':
						break;
					default:
						return false;
					}
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}
}
