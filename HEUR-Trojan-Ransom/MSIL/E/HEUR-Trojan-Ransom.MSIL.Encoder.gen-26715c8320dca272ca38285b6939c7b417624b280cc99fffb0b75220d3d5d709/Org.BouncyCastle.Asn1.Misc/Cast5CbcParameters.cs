using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Misc;

public class Cast5CbcParameters : Asn1Encodable
{
	private readonly DerInteger keyLength;

	private readonly Asn1OctetString iv;

	public int KeyLength => keyLength.Value.IntValue;

	public static Cast5CbcParameters GetInstance(object o)
	{
		if (o is Cast5CbcParameters)
		{
			return (Cast5CbcParameters)o;
		}
		if (!(o is Asn1Sequence))
		{
			throw new ArgumentException("unknown object in Cast5CbcParameters factory");
		}
		return new Cast5CbcParameters((Asn1Sequence)o);
	}

	public Cast5CbcParameters(byte[] iv, int keyLength)
	{
		this.iv = new DerOctetString(iv);
		this.keyLength = new DerInteger(keyLength);
	}

	private Cast5CbcParameters(Asn1Sequence seq)
	{
		if (seq.Count != 2)
		{
			throw new ArgumentException("Wrong number of elements in sequence", "seq");
		}
		iv = (Asn1OctetString)seq[0];
		keyLength = (DerInteger)seq[1];
	}

	public byte[] GetIV()
	{
		return Arrays.Clone(iv.GetOctets());
	}

	public override Asn1Object ToAsn1Object()
	{
		return new DerSequence(iv, keyLength);
	}
}
