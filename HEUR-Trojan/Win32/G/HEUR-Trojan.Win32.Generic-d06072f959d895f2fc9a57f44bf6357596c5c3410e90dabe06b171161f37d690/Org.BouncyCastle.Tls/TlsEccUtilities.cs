using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public abstract class TlsEccUtilities
{
	public static TlsECConfig CreateNamedECConfig(TlsContext context, int namedGroup)
	{
		if (NamedGroup.GetCurveBits(namedGroup) < 1)
		{
			throw new TlsFatalAlert(80);
		}
		return new TlsECConfig(namedGroup);
	}

	public static int GetMinimumCurveBits(int cipherSuite)
	{
		if (!IsEccCipherSuite(cipherSuite))
		{
			return 0;
		}
		return 1;
	}

	public static bool IsEccCipherSuite(int cipherSuite)
	{
		int keyExchangeAlgorithm = TlsUtilities.GetKeyExchangeAlgorithm(cipherSuite);
		if ((uint)(keyExchangeAlgorithm - 16) > 4u && keyExchangeAlgorithm != 24)
		{
			return false;
		}
		return true;
	}

	public static void CheckPointEncoding(int namedGroup, byte[] encoding)
	{
		if (TlsUtilities.IsNullOrEmpty(encoding))
		{
			throw new TlsFatalAlert(47);
		}
		if ((uint)(namedGroup - 29) > 1u)
		{
			switch (encoding[0])
			{
			case 4:
				return;
			}
			throw new TlsFatalAlert(47);
		}
	}

	public static TlsECConfig ReceiveECDHConfig(TlsContext context, Stream input)
	{
		if (TlsUtilities.ReadUint8(input) != 3)
		{
			throw new TlsFatalAlert(40);
		}
		int num = TlsUtilities.ReadUint16(input);
		if (NamedGroup.RefersToAnECDHCurve(num))
		{
			int[] clientSupportedGroups = context.SecurityParameters.ClientSupportedGroups;
			if (clientSupportedGroups == null || Arrays.Contains(clientSupportedGroups, num))
			{
				return new TlsECConfig(num);
			}
		}
		throw new TlsFatalAlert(47);
	}

	public static void WriteECConfig(TlsECConfig ecConfig, Stream output)
	{
		WriteNamedECParameters(ecConfig.NamedGroup, output);
	}

	public static void WriteNamedECParameters(int namedGroup, Stream output)
	{
		if (!NamedGroup.RefersToASpecificCurve(namedGroup))
		{
			throw new TlsFatalAlert(80);
		}
		TlsUtilities.WriteUint8((short)3, output);
		TlsUtilities.CheckUint16(namedGroup);
		TlsUtilities.WriteUint16(namedGroup, output);
	}
}
