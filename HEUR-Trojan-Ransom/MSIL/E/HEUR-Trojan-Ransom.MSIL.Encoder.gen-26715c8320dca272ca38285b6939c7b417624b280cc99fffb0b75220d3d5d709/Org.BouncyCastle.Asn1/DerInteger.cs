using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1;

public class DerInteger : Asn1Object
{
	private readonly byte[] bytes;

	public BigInteger Value => new BigInteger(bytes);

	public BigInteger PositiveValue => new BigInteger(1, bytes);

	public static DerInteger GetInstance(object obj)
	{
		if (obj != null && !(obj is DerInteger))
		{
			throw new ArgumentException("illegal object in GetInstance: " + Platform.GetTypeName(obj));
		}
		return (DerInteger)obj;
	}

	public static DerInteger GetInstance(Asn1TaggedObject obj, bool isExplicit)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		Asn1Object @object = obj.GetObject();
		if (!isExplicit && !(@object is DerInteger))
		{
			return new DerInteger(Asn1OctetString.GetInstance(@object).GetOctets());
		}
		return GetInstance(@object);
	}

	public DerInteger(int value)
	{
		bytes = BigInteger.ValueOf(value).ToByteArray();
	}

	public DerInteger(BigInteger value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		bytes = value.ToByteArray();
	}

	public DerInteger(byte[] bytes)
	{
		if (bytes.Length > 1)
		{
			if (bytes[0] == 0 && (bytes[1] & 0x80) == 0)
			{
				throw new ArgumentException("malformed integer");
			}
			if (bytes[0] == byte.MaxValue && (bytes[1] & 0x80u) != 0)
			{
				throw new ArgumentException("malformed integer");
			}
		}
		this.bytes = Arrays.Clone(bytes);
	}

	internal override void Encode(DerOutputStream derOut)
	{
		derOut.WriteEncoded(2, bytes);
	}

	protected override int Asn1GetHashCode()
	{
		return Arrays.GetHashCode(bytes);
	}

	protected override bool Asn1Equals(Asn1Object asn1Object)
	{
		if (!(asn1Object is DerInteger derInteger))
		{
			return false;
		}
		return Arrays.AreEqual(bytes, derInteger.bytes);
	}

	public override string ToString()
	{
		return Value.ToString();
	}
}
