namespace Org.BouncyCastle.Tls;

public abstract class NamedGroup
{
	public const int sect163k1 = 1;

	public const int sect163r1 = 2;

	public const int sect163r2 = 3;

	public const int sect193r1 = 4;

	public const int sect193r2 = 5;

	public const int sect233k1 = 6;

	public const int sect233r1 = 7;

	public const int sect239k1 = 8;

	public const int sect283k1 = 9;

	public const int sect283r1 = 10;

	public const int sect409k1 = 11;

	public const int sect409r1 = 12;

	public const int sect571k1 = 13;

	public const int sect571r1 = 14;

	public const int secp160k1 = 15;

	public const int secp160r1 = 16;

	public const int secp160r2 = 17;

	public const int secp192k1 = 18;

	public const int secp192r1 = 19;

	public const int secp224k1 = 20;

	public const int secp224r1 = 21;

	public const int secp256k1 = 22;

	public const int secp256r1 = 23;

	public const int secp384r1 = 24;

	public const int secp521r1 = 25;

	public const int brainpoolP256r1 = 26;

	public const int brainpoolP384r1 = 27;

	public const int brainpoolP512r1 = 28;

	public const int x25519 = 29;

	public const int x448 = 30;

	public const int brainpoolP256r1tls13 = 31;

	public const int brainpoolP384r1tls13 = 32;

	public const int brainpoolP512r1tls13 = 33;

	public const int GC256A = 34;

	public const int GC256B = 35;

	public const int GC256C = 36;

	public const int GC256D = 37;

	public const int GC512A = 38;

	public const int GC512B = 39;

	public const int GC512C = 40;

	public const int curveSM2 = 41;

	public const int ffdhe2048 = 256;

	public const int ffdhe3072 = 257;

	public const int ffdhe4096 = 258;

	public const int ffdhe6144 = 259;

	public const int ffdhe8192 = 260;

	public const int arbitrary_explicit_prime_curves = 65281;

	public const int arbitrary_explicit_char2_curves = 65282;

	private static readonly string[] CurveNames = new string[41]
	{
		"sect163k1", "sect163r1", "sect163r2", "sect193r1", "sect193r2", "sect233k1", "sect233r1", "sect239k1", "sect283k1", "sect283r1",
		"sect409k1", "sect409r1", "sect571k1", "sect571r1", "secp160k1", "secp160r1", "secp160r2", "secp192k1", "secp192r1", "secp224k1",
		"secp224r1", "secp256k1", "secp256r1", "secp384r1", "secp521r1", "brainpoolP256r1", "brainpoolP384r1", "brainpoolP512r1", "X25519", "X448",
		"brainpoolP256r1", "brainpoolP384r1", "brainpoolP512r1", "Tc26-Gost-3410-12-256-paramSetA", "GostR3410-2001-CryptoPro-A", "GostR3410-2001-CryptoPro-B", "GostR3410-2001-CryptoPro-C", "Tc26-Gost-3410-12-512-paramSetA", "Tc26-Gost-3410-12-512-paramSetB", "Tc26-Gost-3410-12-512-paramSetC",
		"sm2p256v1"
	};

	private static readonly string[] FiniteFieldNames = new string[5] { "ffdhe2048", "ffdhe3072", "ffdhe4096", "ffdhe6144", "ffdhe8192" };

	public static bool CanBeNegotiated(int namedGroup, ProtocolVersion version)
	{
		if (TlsUtilities.IsTlsV13(version))
		{
			if ((namedGroup >= 1 && namedGroup <= 22) || (namedGroup >= 26 && namedGroup <= 28) || (namedGroup >= 34 && namedGroup <= 40) || (namedGroup >= 65281 && namedGroup <= 65282))
			{
				return false;
			}
		}
		else if ((namedGroup >= 31 && namedGroup <= 33) || namedGroup == 41)
		{
			return false;
		}
		return IsValid(namedGroup);
	}

	public static int GetCurveBits(int namedGroup)
	{
		switch (namedGroup)
		{
		default:
			return 0;
		case 1:
		case 2:
		case 3:
			return 163;
		case 4:
		case 5:
			return 193;
		case 6:
		case 7:
			return 233;
		case 8:
			return 239;
		case 9:
		case 10:
			return 283;
		case 11:
		case 12:
			return 409;
		case 13:
		case 14:
			return 571;
		case 15:
		case 16:
		case 17:
			return 160;
		case 18:
		case 19:
			return 192;
		case 20:
		case 21:
			return 224;
		case 25:
			return 521;
		case 29:
			return 252;
		case 30:
			return 446;
		case 24:
		case 27:
		case 32:
			return 384;
		case 28:
		case 33:
		case 38:
		case 39:
		case 40:
			return 512;
		case 22:
		case 23:
		case 26:
		case 31:
		case 34:
		case 35:
		case 36:
		case 37:
		case 41:
			return 256;
		}
	}

	public static string GetCurveName(int namedGroup)
	{
		if (RefersToASpecificCurve(namedGroup))
		{
			return CurveNames[namedGroup - 1];
		}
		return null;
	}

	public static int GetFiniteFieldBits(int namedGroup)
	{
		return namedGroup switch
		{
			256 => 2048, 
			257 => 3072, 
			258 => 4096, 
			259 => 6144, 
			260 => 8192, 
			_ => 0, 
		};
	}

	public static string GetFiniteFieldName(int namedGroup)
	{
		if (RefersToASpecificFiniteField(namedGroup))
		{
			return FiniteFieldNames[namedGroup - 256];
		}
		return null;
	}

	public static int GetMaximumChar2CurveBits()
	{
		return 571;
	}

	public static int GetMaximumCurveBits()
	{
		return 571;
	}

	public static int GetMaximumFiniteFieldBits()
	{
		return 8192;
	}

	public static int GetMaximumPrimeCurveBits()
	{
		return 521;
	}

	public static string GetName(int namedGroup)
	{
		if (IsPrivate(namedGroup))
		{
			return "PRIVATE";
		}
		switch (namedGroup)
		{
		default:
		{
			string standardName = GetStandardName(namedGroup);
			if (standardName != null)
			{
				return standardName;
			}
			return "UNKNOWN";
		}
		case 65282:
			return "arbitrary_explicit_char2_curves";
		case 65281:
			return "arbitrary_explicit_prime_curves";
		case 29:
			return "x25519";
		case 30:
			return "x448";
		case 31:
			return "brainpoolP256r1tls13";
		case 32:
			return "brainpoolP384r1tls13";
		case 33:
			return "brainpoolP512r1tls13";
		case 34:
			return "GC256A";
		case 35:
			return "GC256B";
		case 36:
			return "GC256C";
		case 37:
			return "GC256D";
		case 38:
			return "GC512A";
		case 39:
			return "GC512B";
		case 40:
			return "GC512C";
		case 41:
			return "curveSM2";
		}
	}

	public static string GetStandardName(int namedGroup)
	{
		string curveName = GetCurveName(namedGroup);
		if (curveName != null)
		{
			return curveName;
		}
		string finiteFieldName = GetFiniteFieldName(namedGroup);
		if (finiteFieldName != null)
		{
			return finiteFieldName;
		}
		return null;
	}

	public static string GetText(int namedGroup)
	{
		return GetName(namedGroup) + "(" + namedGroup + ")";
	}

	public static bool IsChar2Curve(int namedGroup)
	{
		if (namedGroup >= 1 && namedGroup <= 14)
		{
			return true;
		}
		return namedGroup == 65282;
	}

	public static bool IsPrimeCurve(int namedGroup)
	{
		if (namedGroup >= 15 && namedGroup <= 41)
		{
			return true;
		}
		return namedGroup == 65281;
	}

	public static bool IsPrivate(int namedGroup)
	{
		if (namedGroup >> 2 != 127)
		{
			return namedGroup >> 8 == 254;
		}
		return true;
	}

	public static bool IsValid(int namedGroup)
	{
		if (!RefersToASpecificGroup(namedGroup) && !IsPrivate(namedGroup))
		{
			if (namedGroup >= 65281)
			{
				return namedGroup <= 65282;
			}
			return false;
		}
		return true;
	}

	public static bool RefersToAnECDHCurve(int namedGroup)
	{
		return RefersToASpecificCurve(namedGroup);
	}

	public static bool RefersToAnECDSACurve(int namedGroup)
	{
		if (RefersToASpecificCurve(namedGroup))
		{
			return !RefersToAnXDHCurve(namedGroup);
		}
		return false;
	}

	public static bool RefersToAnXDHCurve(int namedGroup)
	{
		if (namedGroup >= 29)
		{
			return namedGroup <= 30;
		}
		return false;
	}

	public static bool RefersToASpecificCurve(int namedGroup)
	{
		if (namedGroup >= 1)
		{
			return namedGroup <= 41;
		}
		return false;
	}

	public static bool RefersToASpecificFiniteField(int namedGroup)
	{
		if (namedGroup >= 256)
		{
			return namedGroup <= 260;
		}
		return false;
	}

	public static bool RefersToASpecificGroup(int namedGroup)
	{
		if (!RefersToASpecificCurve(namedGroup))
		{
			return RefersToASpecificFiniteField(namedGroup);
		}
		return true;
	}
}
