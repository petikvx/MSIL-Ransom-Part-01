using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs;

public class Pkcs12PbeParams : Asn1Encodable
{
	private readonly DerInteger iterations;

	private readonly Asn1OctetString iv;

	public BigInteger Iterations => iterations.Value;

	public Pkcs12PbeParams(byte[] salt, int iterations)
	{
		iv = new DerOctetString(salt);
		this.iterations = new DerInteger(iterations);
	}

	private Pkcs12PbeParams(Asn1Sequence seq)
	{
		if (seq.Count != 2)
		{
			throw new ArgumentException("Wrong number of elements in sequence", "seq");
		}
		iv = Asn1OctetString.GetInstance(seq[0]);
		iterations = DerInteger.GetInstance(seq[1]);
	}

	public static Pkcs12PbeParams GetInstance(object obj)
	{
		if (obj is Pkcs12PbeParams)
		{
			return (Pkcs12PbeParams)obj;
		}
		if (!(obj is Asn1Sequence))
		{
			throw new ArgumentException("Unknown object in factory: " + Platform.GetTypeName(obj), "obj");
		}
		return new Pkcs12PbeParams((Asn1Sequence)obj);
	}

	public byte[] GetIV()
	{
		return iv.GetOctets();
	}

	public override Asn1Object ToAsn1Object()
	{
		return new DerSequence(iv, iterations);
	}
}
