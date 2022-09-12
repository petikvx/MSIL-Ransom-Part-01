using System.Runtime.CompilerServices;
using A6yJVNZuoAn9NC1LAS;

namespace SharpAESCrypt;

public static class Strings
{
	public static string CommandlineUsage;

	public static string CommandlineError;

	public static string CommandlineUnknownMode;

	public static string UnsupportedHashAlgorithmReuse;

	public static string UnsupportedHashAlgorithmBlocks;

	public static string UnsupportedHashAlgorithmBlocksize;

	public static string UnexpectedEndOfStream;

	public static string StreamMustBeWriteAble;

	public static string StreamMustBeReadAble;

	public static string InvalidOperationMode;

	public static string InvalidFileFormat;

	public static string InvalidHeaderMarker;

	public static string InvalidReservedFieldValue;

	public static string UnsupportedFileVersion;

	public static string InvalidExtensionData;

	public static string InvalidPassword;

	public static string InvalidFileLength;

	public static string VersionReadonlyForDecryption;

	public static string VersionReadonly;

	public static string VersionUnsupported;

	public static string StreamMustSupportSeeking;

	public static string CannotReadWhileEncrypting;

	public static string CannotWriteWhileDecrypting;

	public static string DataHMACMismatch;

	public static string DataHMACMismatch_v0;

	public static string EncodingNotSupported;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Strings()
	{
		//Discarded unreachable code: IL_0005, IL_00ef
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_01de: Incompatible stack heights: 0 vs 1
		int num = 9;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 16:
				case 22:
					InvalidPassword = S7EI44sMaZQ92MiG6X.pA2PN5iOW(60);
					num2 = 10;
					continue;
				case 23:
					VersionReadonlyForDecryption = S7EI44sMaZQ92MiG6X.pA2PN5iOW(68);
					num2 = 6;
					continue;
				case 3:
					CommandlineError = S7EI44sMaZQ92MiG6X.pA2PN5iOW(4);
					num = 26;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 7;
				case 13:
					StreamMustBeReadAble = S7EI44sMaZQ92MiG6X.pA2PN5iOW(32);
					num = 14;
					break;
				case 5:
					InvalidHeaderMarker = S7EI44sMaZQ92MiG6X.pA2PN5iOW(44);
					num = 25;
					if (true)
					{
						break;
					}
					goto case 12;
				case 12:
					EncodingNotSupported = S7EI44sMaZQ92MiG6X.pA2PN5iOW(100);
					num2 = 29;
					continue;
				case 19:
					UnexpectedEndOfStream = S7EI44sMaZQ92MiG6X.pA2PN5iOW(24);
					num2 = 17;
					continue;
				case 25:
					InvalidReservedFieldValue = S7EI44sMaZQ92MiG6X.pA2PN5iOW(48);
					goto case 2;
				default:
					num2 = 2;
					continue;
				case 14:
					InvalidOperationMode = S7EI44sMaZQ92MiG6X.pA2PN5iOW(36);
					num = 24;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
					VersionUnsupported = S7EI44sMaZQ92MiG6X.pA2PN5iOW(76);
					goto case 20;
				case 8:
					while (true)
					{
						InvalidExtensionData = S7EI44sMaZQ92MiG6X.pA2PN5iOW(56);
						_ = 1;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						num = 20;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto end_IL_00fc;
						}
					}
					num2 = 22;
					continue;
				case 27:
					UnsupportedHashAlgorithmBlocksize = S7EI44sMaZQ92MiG6X.pA2PN5iOW(20);
					num2 = 19;
					continue;
				case 7:
					DataHMACMismatch = S7EI44sMaZQ92MiG6X.pA2PN5iOW(92);
					num2 = 28;
					continue;
				case 28:
					DataHMACMismatch_v0 = S7EI44sMaZQ92MiG6X.pA2PN5iOW(96);
					num = 12;
					break;
				case 26:
					CommandlineUnknownMode = S7EI44sMaZQ92MiG6X.pA2PN5iOW(8);
					num = 11;
					break;
				case 17:
					StreamMustBeWriteAble = S7EI44sMaZQ92MiG6X.pA2PN5iOW(28);
					num = 13;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 0;
				case 0:
					CannotReadWhileEncrypting = S7EI44sMaZQ92MiG6X.pA2PN5iOW(84);
					num2 = 15;
					continue;
				case 6:
					VersionReadonly = S7EI44sMaZQ92MiG6X.pA2PN5iOW(72);
					num = 1;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 4;
				case 4:
					UnsupportedHashAlgorithmBlocks = S7EI44sMaZQ92MiG6X.pA2PN5iOW(16);
					num = 27;
					break;
				case 20:
				case 21:
					StreamMustSupportSeeking = S7EI44sMaZQ92MiG6X.pA2PN5iOW(80);
					num2 = 0;
					continue;
				case 15:
					CannotWriteWhileDecrypting = S7EI44sMaZQ92MiG6X.pA2PN5iOW(88);
					num = 7;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 23;
				case 2:
					UnsupportedFileVersion = S7EI44sMaZQ92MiG6X.pA2PN5iOW(52);
					num = 8;
					break;
				case 9:
					if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(0))
					{
						num2 = 18;
						continue;
					}
					return;
				case 11:
					UnsupportedHashAlgorithmReuse = S7EI44sMaZQ92MiG6X.pA2PN5iOW(12);
					num2 = 4;
					continue;
				case 10:
					InvalidFileLength = S7EI44sMaZQ92MiG6X.pA2PN5iOW(64);
					num2 = 23;
					continue;
				case 24:
					InvalidFileFormat = S7EI44sMaZQ92MiG6X.pA2PN5iOW(40);
					num2 = 5;
					continue;
				case 18:
					CommandlineUsage = S7EI44sMaZQ92MiG6X.pA2PN5iOW(0);
					num = 3;
					break;
				case 29:
					return;
					end_IL_00fc:
					break;
				}
				break;
			}
		}
	}

	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}
}
