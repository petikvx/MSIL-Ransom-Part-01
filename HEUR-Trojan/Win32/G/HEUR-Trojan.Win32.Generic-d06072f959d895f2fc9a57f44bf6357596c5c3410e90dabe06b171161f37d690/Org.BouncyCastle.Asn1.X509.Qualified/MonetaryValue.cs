using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509.Qualified;

public class MonetaryValue : Asn1Encodable
{
	internal Iso4217CurrencyCode currency;

	internal DerInteger amount;

	internal DerInteger exponent;

	public Iso4217CurrencyCode Currency => currency;

	public BigInteger Amount => amount.Value;

	public BigInteger Exponent => exponent.Value;

	public static MonetaryValue GetInstance(object obj)
	{
		if (obj != null && !(obj is MonetaryValue))
		{
			if (obj is Asn1Sequence)
			{
				return new MonetaryValue(Asn1Sequence.GetInstance(obj));
			}
			throw new ArgumentException("unknown object in GetInstance: " + Platform.GetTypeName(obj), "obj");
		}
		return (MonetaryValue)obj;
	}

	private MonetaryValue(Asn1Sequence seq)
	{
		if (seq.Count != 3)
		{
			throw new ArgumentException("Bad sequence size: " + seq.Count, "seq");
		}
		currency = Iso4217CurrencyCode.GetInstance(seq[0]);
		amount = DerInteger.GetInstance(seq[1]);
		exponent = DerInteger.GetInstance(seq[2]);
	}

	public MonetaryValue(Iso4217CurrencyCode currency, int amount, int exponent)
	{
		this.currency = currency;
		this.amount = new DerInteger(amount);
		this.exponent = new DerInteger(exponent);
	}

	public override Asn1Object ToAsn1Object()
	{
		return new DerSequence(currency, amount, exponent);
	}
}
