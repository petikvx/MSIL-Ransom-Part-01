namespace Org.BouncyCastle.Asn1;

public class BerBitString : DerBitString
{
	public BerBitString(byte[] data, int padBits)
		: base(data, padBits)
	{
	}

	public BerBitString(byte[] data)
		: base(data)
	{
	}

	public BerBitString(int namedBits)
		: base(namedBits)
	{
	}

	public BerBitString(Asn1Encodable obj)
		: base(obj)
	{
	}

	internal override void Encode(DerOutputStream derOut)
	{
		if (!(derOut is Asn1OutputStream) && !(derOut is BerOutputStream))
		{
			base.Encode(derOut);
		}
		else
		{
			derOut.WriteEncoded(3, (byte)mPadBits, mData);
		}
	}
}
