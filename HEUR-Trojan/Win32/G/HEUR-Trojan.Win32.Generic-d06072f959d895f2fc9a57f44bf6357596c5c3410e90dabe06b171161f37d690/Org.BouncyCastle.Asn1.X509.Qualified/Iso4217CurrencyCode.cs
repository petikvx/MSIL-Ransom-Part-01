using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509.Qualified;

public class Iso4217CurrencyCode : Asn1Encodable, IAsn1Choice
{
	internal const int AlphabeticMaxSize = 3;

	internal const int NumericMinSize = 1;

	internal const int NumericMaxSize = 999;

	internal Asn1Encodable obj;

	public bool IsAlphabetic => obj is DerPrintableString;

	public string Alphabetic => ((DerPrintableString)obj).GetString();

	public int Numeric => ((DerInteger)obj).IntValueExact;

	public static Iso4217CurrencyCode GetInstance(object obj)
	{
		if (obj != null && !(obj is Iso4217CurrencyCode))
		{
			if (obj is DerInteger)
			{
				return new Iso4217CurrencyCode(DerInteger.GetInstance(obj).IntValueExact);
			}
			if (obj is DerPrintableString)
			{
				return new Iso4217CurrencyCode(DerPrintableString.GetInstance(obj).GetString());
			}
			throw new ArgumentException("unknown object in GetInstance: " + Platform.GetTypeName(obj), "obj");
		}
		return (Iso4217CurrencyCode)obj;
	}

	public Iso4217CurrencyCode(int numeric)
	{
		if (numeric > 999 || numeric < 1)
		{
			throw new ArgumentException("wrong size in numeric code : not in (" + 1 + ".." + 999 + ")");
		}
		obj = new DerInteger(numeric);
	}

	public Iso4217CurrencyCode(string alphabetic)
	{
		if (alphabetic.Length > 3)
		{
			throw new ArgumentException("wrong size in alphabetic code : max size is " + 3);
		}
		obj = new DerPrintableString(alphabetic);
	}

	public override Asn1Object ToAsn1Object()
	{
		return obj.ToAsn1Object();
	}
}
