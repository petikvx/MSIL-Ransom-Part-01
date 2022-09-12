using Renci.SshNet.Security.Org.BouncyCastle.Asn1.X9;
using Renci.SshNet.Security.Org.BouncyCastle.Math;
using Renci.SshNet.Security.Org.BouncyCastle.Math.EC;
using Renci.SshNet.Security.Org.BouncyCastle.Utilities.Encoders;

namespace Renci.SshNet.Security.Org.BouncyCastle.Asn1.Sec;

internal sealed class SecNamedCurves
{
	internal class Secp256r1Holder : X9ECParametersHolder
	{
		internal static readonly X9ECParametersHolder Instance = new Secp256r1Holder();

		private Secp256r1Holder()
		{
		}

		protected override X9ECParameters CreateParameters()
		{
			BigInteger q = FromHex("FFFFFFFF00000001000000000000000000000000FFFFFFFFFFFFFFFFFFFFFFFF");
			BigInteger a = FromHex("FFFFFFFF00000001000000000000000000000000FFFFFFFFFFFFFFFFFFFFFFFC");
			BigInteger b = FromHex("5AC635D8AA3A93E7B3EBBD55769886BC651D06B0CC53B0F63BCE3C3E27D2604B");
			byte[] seed = Hex.Decode("C49D360886E704936A6678E1139D26B7819F7E90");
			BigInteger bigInteger = FromHex("FFFFFFFF00000000FFFFFFFFFFFFFFFFBCE6FAADA7179E84F3B9CAC2FC632551");
			BigInteger one = BigInteger.One;
			FpCurve fpCurve = new FpCurve(q, a, b, bigInteger, one);
			X9ECPoint g = new X9ECPoint(fpCurve, Hex.Decode("046B17D1F2E12C4247F8BCE6E563A440F277037D812DEB33A0F4A13945D898C2964FE342E2FE1A7F9B8EE7EB4A7C0F9E162BCE33576B315ECECBB6406837BF51F5"));
			return new X9ECParameters(fpCurve, g, bigInteger, one, seed);
		}
	}

	internal class Secp384r1Holder : X9ECParametersHolder
	{
		internal static readonly X9ECParametersHolder Instance = new Secp384r1Holder();

		private Secp384r1Holder()
		{
		}

		protected override X9ECParameters CreateParameters()
		{
			BigInteger q = FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFF0000000000000000FFFFFFFF");
			BigInteger a = FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFF0000000000000000FFFFFFFC");
			BigInteger b = FromHex("B3312FA7E23EE7E4988E056BE3F82D19181D9C6EFE8141120314088F5013875AC656398D8A2ED19D2A85C8EDD3EC2AEF");
			byte[] seed = Hex.Decode("A335926AA319A27A1D00896A6773A4827ACDAC73");
			BigInteger bigInteger = FromHex("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFC7634D81F4372DDF581A0DB248B0A77AECEC196ACCC52973");
			BigInteger one = BigInteger.One;
			FpCurve fpCurve = new FpCurve(q, a, b, bigInteger, one);
			X9ECPoint g = new X9ECPoint(fpCurve, Hex.Decode("04AA87CA22BE8B05378EB1C71EF320AD746E1D3B628BA79B9859F741E082542A385502F25DBF55296C3A545E3872760AB73617DE4A96262C6F5D9E98BF9292DC29F8F41DBD289A147CE9DA3113B5F0B8C00A60B1CE1D7E819D7A431D7C90EA0E5F"));
			return new X9ECParameters(fpCurve, g, bigInteger, one, seed);
		}
	}

	internal class Secp521r1Holder : X9ECParametersHolder
	{
		internal static readonly X9ECParametersHolder Instance = new Secp521r1Holder();

		private Secp521r1Holder()
		{
		}

		protected override X9ECParameters CreateParameters()
		{
			BigInteger q = FromHex("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF");
			BigInteger a = FromHex("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFC");
			BigInteger b = FromHex("0051953EB9618E1C9A1F929A21A0B68540EEA2DA725B99B315F3B8B489918EF109E156193951EC7E937B1652C0BD3BB1BF073573DF883D2C34F1EF451FD46B503F00");
			byte[] seed = Hex.Decode("D09E8800291CB85396CC6717393284AAA0DA64BA");
			BigInteger bigInteger = FromHex("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFA51868783BF2F966B7FCC0148F709A5D03BB5C9B8899C47AEBB6FB71E91386409");
			BigInteger one = BigInteger.One;
			FpCurve fpCurve = new FpCurve(q, a, b, bigInteger, one);
			X9ECPoint g = new X9ECPoint(fpCurve, Hex.Decode("0400C6858E06B70404E9CD9E3ECB662395B4429C648139053FB521F828AF606B4D3DBAA14B5E77EFE75928FE1DC127A2FFA8DE3348B3C1856A429BF97E7E31C2E5BD66011839296A789A3BC0045C8A5FB42C7D1BD998F54449579B446817AFBD17273E662C97EE72995EF42640C550B9013FAD0761353C7086A272C24088BE94769FD16650"));
			return new X9ECParameters(fpCurve, g, bigInteger, one, seed);
		}
	}

	public static X9ECParameters GetByName(string name)
	{
		switch (name)
		{
		case "P-521":
		case "secp521r1":
			return Secp521r1Holder.Instance.Parameters;
		case "P-384":
		case "secp384r1":
			return Secp384r1Holder.Instance.Parameters;
		case "P-256":
		case "secp256r1":
			return Secp256r1Holder.Instance.Parameters;
		default:
			return null;
		}
	}

	private static BigInteger FromHex(string hex)
	{
		return new BigInteger(1, Hex.Decode(hex));
	}
}
