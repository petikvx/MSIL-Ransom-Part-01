using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public abstract class TlsSrpUtilities
{
	public static void AddSrpExtension(IDictionary extensions, byte[] identity)
	{
		extensions[12] = CreateSrpExtension(identity);
	}

	public static byte[] GetSrpExtension(IDictionary extensions)
	{
		byte[] extensionData = TlsUtilities.GetExtensionData(extensions, 12);
		if (extensionData != null)
		{
			return ReadSrpExtension(extensionData);
		}
		return null;
	}

	public static byte[] CreateSrpExtension(byte[] identity)
	{
		if (identity == null)
		{
			throw new TlsFatalAlert(80);
		}
		return TlsUtilities.EncodeOpaque8(identity);
	}

	public static byte[] ReadSrpExtension(byte[] extensionData)
	{
		if (extensionData == null)
		{
			throw new ArgumentNullException("extensionData");
		}
		return TlsUtilities.DecodeOpaque8(extensionData, 1);
	}

	public static BigInteger ReadSrpParameter(Stream input)
	{
		return new BigInteger(1, TlsUtilities.ReadOpaque16(input, 1));
	}

	public static void WriteSrpParameter(BigInteger x, Stream output)
	{
		TlsUtilities.WriteOpaque16(BigIntegers.AsUnsignedByteArray(x), output);
	}

	public static bool IsSrpCipherSuite(int cipherSuite)
	{
		int keyExchangeAlgorithm = TlsUtilities.GetKeyExchangeAlgorithm(cipherSuite);
		if ((uint)(keyExchangeAlgorithm - 21) <= 2u)
		{
			return true;
		}
		return false;
	}
}
