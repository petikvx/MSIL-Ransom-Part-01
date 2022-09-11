using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DevDefined.OAuth.KeyInterop;

public class AsnKeyParser
{
	private readonly AsnParser parser;

	public AsnKeyParser(string pathname)
	{
		using BinaryReader binaryReader = new BinaryReader(new FileStream(pathname, FileMode.Open, FileAccess.Read));
		FileInfo fileInfo = new FileInfo(pathname);
		parser = new AsnParser(binaryReader.ReadBytes((int)fileInfo.Length));
	}

	public AsnKeyParser(byte[] contents)
	{
		parser = new AsnParser(contents);
	}

	public static byte[] TrimLeadingZero(byte[] values)
	{
		byte[] array = null;
		if (values[0] == 0 && values.Length > 1)
		{
			array = new byte[values.Length - 1];
			Array.Copy(values, 1, array, 0, values.Length - 1);
		}
		else
		{
			array = new byte[values.Length];
			Array.Copy(values, array, values.Length);
		}
		return array;
	}

	public static bool EqualOid(byte[] first, byte[] second)
	{
		if (first.Length != second.Length)
		{
			return false;
		}
		int num = 0;
		while (true)
		{
			if (num < first.Length)
			{
				if (first[num] != second[num])
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

	public RSAParameters ParseRSAPublicKey()
	{
		RSAParameters result = default(RSAParameters);
		byte[] array = null;
		int num = 0;
		int position = parser.CurrentPosition();
		num = parser.NextSequence();
		if (num != parser.RemainingBytes())
		{
			StringBuilder stringBuilder = new StringBuilder("Incorrect Sequence Size. ");
			stringBuilder.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder.ToString(), position);
		}
		position = parser.CurrentPosition();
		num = parser.NextSequence();
		if (num > parser.RemainingBytes())
		{
			StringBuilder stringBuilder2 = new StringBuilder("Incorrect AlgorithmIdentifier Size. ");
			stringBuilder2.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder2.ToString(), position);
		}
		position = parser.CurrentPosition();
		array = parser.NextOID();
		byte[] second = new byte[9] { 42, 134, 72, 134, 247, 13, 1, 1, 1 };
		if (!EqualOid(array, second))
		{
			throw new BerDecodeException("Expected OID 1.2.840.113549.1.1.1", position);
		}
		if (parser.IsNextNull())
		{
			parser.NextNull();
		}
		else
		{
			array = parser.Next();
		}
		position = parser.CurrentPosition();
		num = parser.NextBitString();
		if (num > parser.RemainingBytes())
		{
			StringBuilder stringBuilder3 = new StringBuilder("Incorrect PublicKey Size. ");
			stringBuilder3.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder3.ToString(), position);
		}
		position = parser.CurrentPosition();
		num = parser.NextSequence();
		if (num < parser.RemainingBytes())
		{
			StringBuilder stringBuilder4 = new StringBuilder("Incorrect RSAPublicKey Size. ");
			stringBuilder4.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder4.ToString(), position);
		}
		result.Modulus = TrimLeadingZero(parser.NextInteger());
		result.Exponent = TrimLeadingZero(parser.NextInteger());
		return result;
	}

	public RSAParameters ParseRSAPrivateKey()
	{
		RSAParameters result = default(RSAParameters);
		byte[] array = null;
		int position = parser.CurrentPosition();
		int num = 0;
		num = parser.NextSequence();
		if (num != parser.RemainingBytes())
		{
			StringBuilder stringBuilder = new StringBuilder("Incorrect Sequence Size. ");
			stringBuilder.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder.ToString(), position);
		}
		position = parser.CurrentPosition();
		array = parser.NextInteger();
		if (array[0] != 0)
		{
			StringBuilder stringBuilder2 = new StringBuilder("Incorrect PrivateKeyInfo Version. ");
			BigInteger bigInteger = new BigInteger(array);
			stringBuilder2.AppendFormat("Expected: 0, Specified: {0}", bigInteger.ToString(10));
			throw new BerDecodeException(stringBuilder2.ToString(), position);
		}
		position = parser.CurrentPosition();
		num = parser.NextSequence();
		if (num > parser.RemainingBytes())
		{
			StringBuilder stringBuilder3 = new StringBuilder("Incorrect AlgorithmIdentifier Size. ");
			stringBuilder3.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder3.ToString(), position);
		}
		position = parser.CurrentPosition();
		array = parser.NextOID();
		byte[] second = new byte[9] { 42, 134, 72, 134, 247, 13, 1, 1, 1 };
		if (!EqualOid(array, second))
		{
			throw new BerDecodeException("Expected OID 1.2.840.113549.1.1.1", position);
		}
		if (parser.IsNextNull())
		{
			parser.NextNull();
		}
		else
		{
			array = parser.Next();
		}
		position = parser.CurrentPosition();
		num = parser.NextOctetString();
		if (num > parser.RemainingBytes())
		{
			StringBuilder stringBuilder4 = new StringBuilder("Incorrect PrivateKey Size. ");
			stringBuilder4.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder4.ToString(), position);
		}
		position = parser.CurrentPosition();
		num = parser.NextSequence();
		if (num < parser.RemainingBytes())
		{
			StringBuilder stringBuilder5 = new StringBuilder("Incorrect RSAPrivateKey Size. ");
			stringBuilder5.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder5.ToString(), position);
		}
		position = parser.CurrentPosition();
		array = parser.NextInteger();
		if (array[0] != 0)
		{
			StringBuilder stringBuilder6 = new StringBuilder("Incorrect RSAPrivateKey Version. ");
			BigInteger bigInteger2 = new BigInteger(array);
			stringBuilder6.AppendFormat("Expected: 0, Specified: {0}", bigInteger2.ToString(10));
			throw new BerDecodeException(stringBuilder6.ToString(), position);
		}
		result.Modulus = TrimLeadingZero(parser.NextInteger());
		result.Exponent = TrimLeadingZero(parser.NextInteger());
		result.D = TrimLeadingZero(parser.NextInteger());
		result.P = TrimLeadingZero(parser.NextInteger());
		result.Q = TrimLeadingZero(parser.NextInteger());
		result.DP = TrimLeadingZero(parser.NextInteger());
		result.DQ = TrimLeadingZero(parser.NextInteger());
		result.InverseQ = TrimLeadingZero(parser.NextInteger());
		return result;
	}

	public DSAParameters ParseDSAPublicKey()
	{
		DSAParameters result = default(DSAParameters);
		byte[] array = null;
		int position = parser.CurrentPosition();
		int num = 0;
		num = parser.NextSequence();
		if (num != parser.RemainingBytes())
		{
			StringBuilder stringBuilder = new StringBuilder("Incorrect Sequence Size. ");
			stringBuilder.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder.ToString(), position);
		}
		position = parser.CurrentPosition();
		num = parser.NextSequence();
		if (num > parser.RemainingBytes())
		{
			StringBuilder stringBuilder2 = new StringBuilder("Incorrect AlgorithmIdentifier Size. ");
			stringBuilder2.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder2.ToString(), position);
		}
		position = parser.CurrentPosition();
		array = parser.NextOID();
		byte[] second = new byte[7] { 42, 134, 72, 206, 56, 4, 1 };
		if (!EqualOid(array, second))
		{
			throw new BerDecodeException("Expected OID 1.2.840.10040.4.1", position);
		}
		position = parser.CurrentPosition();
		num = parser.NextSequence();
		if (num > parser.RemainingBytes())
		{
			StringBuilder stringBuilder3 = new StringBuilder("Incorrect DSS-Params Size. ");
			stringBuilder3.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder3.ToString(), position);
		}
		result.P = TrimLeadingZero(parser.NextInteger());
		result.Q = TrimLeadingZero(parser.NextInteger());
		result.G = TrimLeadingZero(parser.NextInteger());
		parser.NextBitString();
		result.Y = TrimLeadingZero(parser.NextInteger());
		return result;
	}

	public DSAParameters ParseDSAPrivateKey()
	{
		DSAParameters result = default(DSAParameters);
		byte[] array = null;
		int position = parser.CurrentPosition();
		int num = 0;
		num = parser.NextSequence();
		if (num != parser.RemainingBytes())
		{
			StringBuilder stringBuilder = new StringBuilder("Incorrect Sequence Size. ");
			stringBuilder.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder.ToString(), position);
		}
		position = parser.CurrentPosition();
		array = parser.NextInteger();
		if (array[0] != 0)
		{
			throw new BerDecodeException("Incorrect PrivateKeyInfo Version", position);
		}
		position = parser.CurrentPosition();
		num = parser.NextSequence();
		if (num > parser.RemainingBytes())
		{
			StringBuilder stringBuilder2 = new StringBuilder("Incorrect AlgorithmIdentifier Size. ");
			stringBuilder2.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder2.ToString(), position);
		}
		position = parser.CurrentPosition();
		array = parser.NextOID();
		byte[] second = new byte[7] { 42, 134, 72, 206, 56, 4, 1 };
		if (!EqualOid(array, second))
		{
			throw new BerDecodeException("Expected OID 1.2.840.10040.4.1", position);
		}
		position = parser.CurrentPosition();
		num = parser.NextSequence();
		if (num > parser.RemainingBytes())
		{
			StringBuilder stringBuilder3 = new StringBuilder("Incorrect DSS-Params Size. ");
			stringBuilder3.AppendFormat("Specified: {0}, Remaining: {1}", num.ToString(CultureInfo.InvariantCulture), parser.RemainingBytes().ToString(CultureInfo.InvariantCulture));
			throw new BerDecodeException(stringBuilder3.ToString(), position);
		}
		result.P = TrimLeadingZero(parser.NextInteger());
		result.Q = TrimLeadingZero(parser.NextInteger());
		result.G = TrimLeadingZero(parser.NextInteger());
		parser.NextOctetString();
		result.X = TrimLeadingZero(parser.NextInteger());
		return result;
	}
}
