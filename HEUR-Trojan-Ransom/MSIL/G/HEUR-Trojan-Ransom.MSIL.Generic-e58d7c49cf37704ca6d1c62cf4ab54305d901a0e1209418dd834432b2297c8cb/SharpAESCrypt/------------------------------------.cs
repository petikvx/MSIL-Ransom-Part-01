using System;
using System.Collections.Generic;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using A6yJVNZuoAn9NC1LAS;

namespace SharpAESCrypt;

public static class _0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095
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
	static _0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095()
	{
		//Discarded unreachable code: IL_0005, IL_003e
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0229: Incompatible stack heights: 0 vs 1
		int num = 16;
		while (true)
		{
			int num3;
			int num2;
			switch (num)
			{
			case 12:
				UnexpectedEndOfStream = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(24);
				num3 = 25;
				goto IL_0043;
			case 10:
				InvalidReservedFieldValue = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(48);
				goto default;
			case 9:
				InvalidExtensionData = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(56);
				num = 7;
				continue;
			case 26:
				UnsupportedHashAlgorithmBlocksize = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(20);
				num = 12;
				continue;
			case 24:
				UnsupportedHashAlgorithmReuse = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(12);
				num2 = 4;
				goto IL_0047;
			case 4:
				UnsupportedHashAlgorithmBlocks = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(16);
				num2 = 26;
				if (true)
				{
					goto IL_0047;
				}
				goto case 5;
			case 5:
				CommandlineUsage = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(0);
				num2 = 23;
				goto IL_0047;
			case 23:
				CommandlineError = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(4);
				num2 = 27;
				if (true)
				{
					goto IL_0047;
				}
				goto case 8;
			case 8:
				CannotReadWhileEncrypting = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(84);
				num = 13;
				continue;
			case 2:
				DataHMACMismatch = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(92);
				num = 17;
				continue;
			case 15:
				InvalidHeaderMarker = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(44);
				num2 = 10;
				goto IL_0047;
			case 27:
				CommandlineUnknownMode = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(8);
				num2 = 24;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_0047;
				}
				goto case 23;
			case 28:
				VersionReadonlyForDecryption = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(68);
				num = 1;
				continue;
			case 3:
				InvalidOperationMode = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(36);
				_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					num3 = 21;
					goto IL_0043;
				}
				num2 = 18;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_0047;
				}
				goto case 20;
			case 20:
				StreamMustBeReadAble = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(32);
				num = 3;
				continue;
			case 25:
				StreamMustBeWriteAble = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(28);
				num2 = 20;
				if (0 == 0)
				{
					goto IL_0047;
				}
				goto case 6;
			case 6:
				VersionUnsupported = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(76);
				num = 19;
				continue;
			case 13:
				CannotWriteWhileDecrypting = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(88);
				num3 = 2;
				goto IL_0043;
			case 11:
			case 18:
				InvalidFileFormat = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(40);
				num2 = 15;
				goto IL_0047;
			case 16:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(0))
				{
					num = 5;
					continue;
				}
				return;
			default:
				UnsupportedFileVersion = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(52);
				num3 = 9;
				goto IL_0043;
			case 19:
				StreamMustSupportSeeking = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(80);
				num3 = 8;
				goto IL_0043;
			case 0:
				do
				{
					InvalidFileLength = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(64);
					num2 = 28;
				}
				while (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091());
				goto IL_0047;
			case 1:
				VersionReadonly = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(72);
				num = 6;
				continue;
			case 7:
				InvalidPassword = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(60);
				num = 0;
				continue;
			case 22:
				EncodingNotSupported = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(100);
				num2 = 29;
				if (1 == 0)
				{
					break;
				}
				goto IL_0047;
			case 17:
				break;
			case 29:
				return;
				IL_0043:
				num2 = num3;
				goto IL_0047;
				IL_0047:
				num = num2;
				continue;
			}
			DataHMACMismatch_v0 = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(96);
			num = 22;
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
public class _008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089 : Stream
{
	private class _008E_008A_0091_008A_0091_008D_008A_008D_008D_0090_008F_0088_0093_008A_008F_0090_0095_008A_008F_0086_0089_0090_0086_0091_0088_0088_0093_0094_008B_0092_008B_0091_008F_0091_008C_008F : IDisposable
	{
		private static readonly byte[] DEFAULT_MAC = new byte[8] { 1, 35, 69, 103, 137, 171, 205, 239 };

		private const string HASH_ALGORITHM = "SHA-256";

		private const string CRYPT_ALGORITHM = "Rijndael";

		private const string RAND_ALGORITHM = "SHA1PRNG";

		private const string HMAC_ALGORITHM = "HmacSHA256";

		private const string PASSWORD_ENCODING = "utf-16";

		private SymmetricAlgorithm m_crypt;

		private HashAlgorithm m_hash;

		private RandomNumberGenerator m_rand;

		private HMAC m_hmac;

		private byte[] m_iv1;

		private byte[] m_aesKey1;

		private byte[] m_iv2;

		private byte[] m_aesKey2;

		public byte[] IV1
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0005
				//IL_0006: Incompatible stack heights: 0 vs 1
				return m_iv1;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _008E_008A_0091_008A_0091_008D_008A_008D_008D_0090_008F_0088_0093_008A_008F_0090_0095_008A_008F_0086_0089_0090_0086_0091_0088_0088_0093_0094_008B_0092_008B_0091_008F_0091_008C_008F(OperationMode _0020, string _0020, byte[] _0020)
		{
			//Discarded unreachable code: IL_0005, IL_00a9
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 3;
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 13:
						m_aesKey1 = GenerateAESKey1(EncodePassword(_0020));
						num3 = 5;
						goto IL_00ae;
					case 2:
						base._002Ector();
						num2 = 8;
						continue;
					case 11:
						m_hmac = HMAC.Create(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2400));
						num = 14;
						if (0 == 0)
						{
							break;
						}
						goto case 3;
					case 3:
						if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(124))
						{
							num = 2;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								break;
							}
							goto case 5;
						}
						return;
					case 5:
						m_iv2 = GenerateIv2();
						num3 = 4;
						goto IL_00ae;
					case 14:
						flag = _0020 == OperationMode.Encrypt;
						goto case 9;
					default:
						num = 9;
						break;
					case 4:
						m_aesKey2 = GenerateAESKey2();
						num3 = 1;
						goto IL_00ae;
					case 6:
					case 12:
						m_rand = RandomNumberGenerator.Create();
						num3 = 11;
						goto IL_00ae;
					case 8:
						m_crypt = SymmetricAlgorithm.Create(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2392));
						num = 0;
						break;
					case 1:
						return;
					case 0:
						m_crypt.Padding = PaddingMode.None;
						num2 = 15;
						continue;
					case 10:
					case 17:
						m_iv1 = GenerateIv1();
						num3 = 13;
						goto IL_00ae;
					case 16:
						m_hash = HashAlgorithm.Create(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2396));
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num2 = 12;
							continue;
						}
						num = 17;
						break;
					case 15:
						m_crypt.Mode = CipherMode.CBC;
						num = 16;
						if (0 == 0)
						{
							break;
						}
						goto case 9;
					case 9:
						if (!flag)
						{
							m_iv1 = _0020;
							num = 7;
							break;
						}
						goto case 10;
					case 7:
						m_aesKey1 = GenerateAESKey1(EncodePassword(_0020));
						num = 18;
						if (1 == 0)
						{
							return;
						}
						break;
					case 18:
						return;
						IL_00ae:
						num = num3;
						break;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] EncodePassword(string _0020)
		{
			//Discarded unreachable code: IL_0005, IL_00b7
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_02c9: Incompatible stack heights: 0 vs 1
			int num = 11;
			byte[] result = default(byte[]);
			byte[] bytes = default(byte[]);
			Encoding encoding = default(Encoding);
			byte[] array = default(byte[]);
			bool flag2 = default(bool);
			bool flag = default(bool);
			int num4 = default(int);
			byte b = default(byte);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					IL_00c0:
					int num3 = num2;
					while (true)
					{
						object obj;
						switch (num3)
						{
						case 2:
							break;
						case 13:
							throw new SystemException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.EncodingNotSupported);
						case 3:
							result = bytes;
							num2 = 23;
							if (true)
							{
								goto IL_00c0;
							}
							goto case 11;
						case 11:
							if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(128))
							{
								num2 = 18;
								if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
								{
									goto IL_00c0;
								}
								goto case 13;
							}
							encoding = Encoding.GetEncoding(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2404));
							num2 = 16;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								goto IL_00c0;
							}
							goto case 9;
						case 14:
							goto end_IL_00c4;
						case 7:
						case 20:
							result = encoding.GetBytes(_0020);
							num3 = 15;
							continue;
						case 12:
							bytes = encoding.GetBytes(_0020);
							goto case 6;
						default:
							num3 = 6;
							continue;
						case 0:
							if (array[1] == byte.MaxValue)
							{
								goto IL_014c;
							}
							goto IL_02de;
						case 6:
							flag2 = bytes.Length % 2 != 0;
							num3 = 17;
							continue;
						case 10:
							throw new SystemException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.EncodingNotSupported);
						case 1:
						case 8:
							flag = num4 < bytes.Length;
							num2 = 2;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								goto IL_00c0;
							}
							goto case 16;
						case 16:
							if (encoding != null)
							{
								num3 = 9;
								continue;
							}
							obj = null;
							goto IL_02b8;
						case 4:
						case 5:
							if (array.Length != 2)
							{
								goto IL_020f;
							}
							if (array[0] == byte.MaxValue)
							{
								num2 = 22;
								goto IL_00c0;
							}
							goto IL_024f;
						case 21:
							bytes[num4] = bytes[num4 + 1];
							num2 = 14;
							if (0 == 0)
							{
								goto IL_00c0;
							}
							goto case 17;
						case 17:
						case 18:
							if (!flag2)
							{
								num4 = 0;
								num2 = 8;
								goto IL_00c0;
							}
							goto IL_0240;
						case 19:
							num4 += 2;
							num2 = 1;
							if (0 == 0)
							{
								goto IL_00c0;
							}
							goto case 22;
						case 22:
							if (array[1] == 254)
							{
								goto case 7;
							}
							goto IL_024f;
						case 9:
							obj = encoding.GetPreamble();
							goto IL_02b8;
						case 15:
						case 23:
							{
								return result;
							}
							IL_024f:
							if (array[0] == 254)
							{
								num2 = 0;
								if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
								{
									goto IL_00c0;
								}
								goto case 19;
							}
							goto IL_02de;
							IL_02b8:
							array = (byte[])obj;
							if (array == null)
							{
								goto IL_020f;
							}
							goto IL_02bf;
							IL_020f:
							num2 = 13;
							if (true)
							{
								goto IL_00c0;
							}
							goto case 21;
							IL_02de:
							throw new SystemException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.EncodingNotSupported);
						}
						if (!flag)
						{
							num3 = 3;
							continue;
						}
						goto IL_018c;
						IL_02bf:
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num3 = 20;
							continue;
						}
						goto IL_02ce;
						continue;
						end_IL_00c4:
						break;
					}
					bytes[num4 + 1] = b;
					num = 19;
					break;
					IL_0240:
					num = 10;
					break;
					IL_014c:
					num = 12;
					break;
					IL_018c:
					b = bytes[num4];
					num = 21;
					break;
					IL_02ce:
					num = 5;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] GenerateIv1()
		{
			//Discarded unreachable code: IL_0005, IL_00f1, IL_01ba
			//IL_0006: Incompatible stack heights: 0 vs 1
			_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
			int num;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				num = 5;
				goto IL_01c7;
			}
			int num2 = 2;
			goto IL_01c3;
			IL_01c3:
			num = num2;
			goto IL_01c7;
			IL_01c7:
			bool flag4 = default(bool);
			int num3 = default(int);
			bool flag3 = default(bool);
			int num7 = default(int);
			bool flag2 = default(bool);
			byte[] array = default(byte[]);
			bool flag = default(bool);
			byte[] array2 = default(byte[]);
			long ticks = default(long);
			DateTime now = default(DateTime);
			byte[] result = default(byte[]);
			while (true)
			{
				int num4;
				switch (num)
				{
				case 8:
				case 11:
					flag4 = num3 < 8;
					num2 = 15;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 3;
				case 3:
					try
					{
						NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						int num5;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							num5 = 8;
							goto IL_00fe;
						}
						int num6 = 6;
						goto IL_00fa;
						IL_00fa:
						num5 = num6;
						goto IL_00fe;
						IL_00fe:
						while (true)
						{
							switch (num5)
							{
							case 7:
								if (flag3)
								{
									num6 = 1;
									break;
								}
								num7++;
								num5 = 2;
								continue;
							case 3:
							{
								int num8;
								if (!flag2)
								{
									num8 = 9;
								}
								else
								{
									flag3 = num7 != NetworkInterface.LoopbackInterfaceIndex;
									num8 = 7;
								}
								num6 = num8;
								break;
							}
							case 0:
							case 8:
								num7 = 0;
								num5 = 5;
								continue;
							case 2:
							case 5:
								do
								{
									flag2 = num7 < allNetworkInterfaces.Length;
									num6 = 3;
								}
								while (false);
								break;
							default:
								goto end_IL_00fe;
							case 6:
								goto end_IL_00fe;
							case 1:
								array = allNetworkInterfaces[num7].GetPhysicalAddress().GetAddressBytes();
								goto end_IL_00fe;
							case 9:
								goto end_IL_00fe;
							}
							goto IL_00fa;
							continue;
							end_IL_00fe:
							break;
						}
					}
					catch
					{
					}
					flag = array == null;
					num4 = 4;
					goto IL_01bf;
				case 15:
					while (flag4)
					{
						array2[num3] = (byte)((ticks >> num3 * 8) & 0xFF);
						num2 = 14;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto end_IL_01c7;
						}
					}
					num4 = 12;
					goto IL_01bf;
				case 0:
				case 5:
					array2 = new byte[16];
					num2 = 10;
					break;
				case 6:
					num3 = 0;
					goto case 8;
				default:
					num2 = 8;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 9;
				case 9:
					ticks = now.Ticks;
					num4 = 7;
					goto IL_01bf;
				case 2:
				case 13:
					result = DigestRandomBytes(array2, 256);
					num2 = 16;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
					array = DEFAULT_MAC;
					num4 = 6;
					goto IL_01bf;
				case 14:
					num3++;
					num2 = 11;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 4;
				case 4:
					if (!flag)
					{
						goto case 6;
					}
					num4 = 1;
					goto IL_01bf;
				case 10:
					now = DateTime.Now;
					num = 9;
					continue;
				case 12:
					Array.Copy(array, 0, array2, 8, Math.Min(array.Length, array2.Length - 8));
					goto case 2;
				case 7:
					array = null;
					num = 3;
					continue;
				case 16:
					{
						return result;
					}
					IL_01bf:
					num2 = num4;
					break;
					end_IL_01c7:
					break;
				}
				break;
			}
			goto IL_01c3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] GenerateAESKey1(byte[] _0020)
		{
			//Discarded unreachable code: IL_0005, IL_00c7
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 11;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				goto IL_00d0;
			}
			goto IL_014d;
			IL_014d:
			bool flag = default(bool);
			byte[] array = default(byte[]);
			if (flag)
			{
				num = 15;
				if (1 == 0)
				{
					goto IL_0263;
				}
			}
			else
			{
				array = new byte[32];
				num = 5;
				if (1 == 0)
				{
					goto IL_0228;
				}
			}
			goto IL_00d0;
			IL_0286:
			byte[] result = default(byte[]);
			return result;
			IL_024a:
			bool flag2 = default(bool);
			int num2;
			if (!_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(132))
			{
				flag2 = !m_hash.CanReuseTransform;
				num2 = 2;
			}
			else
			{
				num2 = 9;
			}
			goto IL_00cc;
			IL_00d0:
			int num3 = num;
			goto IL_00d4;
			IL_00d4:
			int num4 = default(int);
			bool flag3 = default(bool);
			while (true)
			{
				switch (num3)
				{
				case 5:
					break;
				case 17:
					goto IL_005d;
				case 7:
					throw new CryptographicException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedHashAlgorithmBlocks);
				case 10:
					goto IL_00ae;
				case 8:
					num4 = 0;
					goto IL_0263;
				default:
					num3 = 4;
					continue;
				case 13:
				case 18:
					array = m_hash.Hash;
					num3 = 16;
					continue;
				case 6:
				case 12:
					goto end_IL_00d4;
				case 1:
					result = array;
					num = 20;
					if (0 == 0)
					{
						goto IL_00d0;
					}
					goto case 14;
				case 14:
					throw new CryptographicException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedHashAlgorithmReuse);
				case 2:
					goto IL_01b7;
				case 19:
					m_hash.TransformFinalBlock(_0020, 0, _0020.Length);
					goto case 13;
				case 15:
					throw new CryptographicException(string.Format(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedHashAlgorithmBlocksize, 32, m_hash.HashSize / 8));
				case 3:
					goto IL_0228;
				case 16:
					goto IL_0239;
				case 11:
					goto IL_024a;
				case 0:
				case 4:
				case 9:
					goto IL_0263;
				case 20:
					goto IL_0286;
				}
				Array.Copy(m_iv1, array, m_iv1.Length);
				num = 8;
				if (1 == 0)
				{
					goto IL_005d;
				}
				goto IL_00d0;
				IL_0239:
				num4++;
				num2 = 0;
				goto IL_00cc;
				IL_01b7:
				if (!flag2)
				{
					flag3 = !m_hash.CanTransformMultipleBlocks;
					num3 = 10;
					continue;
				}
				num2 = 14;
				goto IL_00cc;
				IL_00ae:
				if (!flag3)
				{
					flag = 32 < m_hash.HashSize / 8;
					_ = 1;
					num3 = (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 18 : 12);
					continue;
				}
				num2 = 7;
				goto IL_00cc;
				IL_005d:
				m_hash.TransformBlock(array, 0, array.Length, array, 0);
				num2 = 19;
				goto IL_00cc;
				continue;
				end_IL_00d4:
				break;
			}
			goto IL_014d;
			IL_00cc:
			num = num2;
			goto IL_00d0;
			IL_0263:
			bool flag4 = num4 < 8192;
			num = 3;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_00d0;
			}
			goto IL_0286;
			IL_0228:
			if (flag4)
			{
				m_hash.Initialize();
				num3 = 17;
				goto IL_00d4;
			}
			num2 = 1;
			goto IL_00cc;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] GenerateIv2()
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			m_crypt.GenerateIV();
			return DigestRandomBytes(m_crypt.IV, 256);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] GenerateAESKey2()
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			m_crypt.GenerateKey();
			return DigestRandomBytes(m_crypt.Key, 32);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] EncryptAESKey2()
		{
			//Discarded unreachable code: IL_0005, IL_0089
			//IL_0006: Incompatible stack heights: 0 vs 1
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, m_crypt.CreateEncryptor(m_aesKey1, m_iv1), CryptoStreamMode.Write);
			cryptoStream.Write(m_iv2, 0, m_iv2.Length);
			_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
			int num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 2 : 3);
			while (true)
			{
				switch (num)
				{
				case 0:
				case 3:
					cryptoStream.Write(m_aesKey2, 0, m_aesKey2.Length);
					break;
				case 4:
					return memoryStream.ToArray();
				}
				cryptoStream.FlushFinalBlock();
				int num2 = 4;
				num = num2;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] CalculateKeyHmac()
		{
			//Discarded unreachable code: IL_0005, IL_0055
			//IL_0006: Incompatible stack heights: 0 vs 1
			_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
			int num = ((!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()) ? 1 : 3);
			byte[] result = default(byte[]);
			while (true)
			{
				switch (num)
				{
				default:
					result = m_hmac.ComputeHash(EncryptAESKey2());
					num = 5;
					break;
				case 4:
					m_hmac.Key = m_aesKey1;
					goto default;
				case 0:
				case 1:
				{
					m_hmac.Initialize();
					int num2 = 4;
					num = num2;
					break;
				}
				case 5:
					return result;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] DigestRandomBytes(byte[] _0020, int _0020)
		{
			//Discarded unreachable code: IL_0005, IL_003d
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 5;
			if (false)
			{
				goto IL_0016;
			}
			goto IL_0046;
			IL_0046:
			int num2 = num;
			goto IL_004a;
			IL_004a:
			int num3 = default(int);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag2 = default(bool);
			bool flag = default(bool);
			byte[] result = default(byte[]);
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 7:
				case 18:
					break;
				case 13:
					goto IL_0026;
				case 9:
				case 17:
					num3 = 0;
					break;
				default:
					num = 3;
					goto IL_0046;
				case 16:
					goto IL_00b1;
				case 0:
					throw new CryptographicException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedHashAlgorithmBlocks);
				case 6:
					goto IL_00fa;
				case 11:
					Array.Copy(m_hash.Hash, _0020, _0020.Length);
					num2 = 6;
					continue;
				case 2:
					m_hash.TransformFinalBlock(_0020, 0, 0);
					num = 11;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto IL_0046;
				case 19:
					m_hash.TransformBlock(_0020, 0, _0020.Length, _0020, 0);
					num = 10;
					goto IL_0046;
				case 14:
					if (flag3)
					{
						num = 4;
						if (0 == 0)
						{
							goto IL_0046;
						}
						goto case 10;
					}
					flag4 = !m_hash.CanTransformMultipleBlocks;
					num2 = 13;
					continue;
				case 10:
					num3++;
					num = 18;
					goto IL_0046;
				case 5:
					if (!_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(136))
					{
						flag2 = _0020.Length > m_hash.HashSize / 8;
						num = 16;
						if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto case 2;
						}
					}
					else
					{
						num = 7;
					}
					goto IL_0046;
				case 12:
					throw new CryptographicException(string.Format(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedHashAlgorithmBlocksize, _0020.Length, m_hash.HashSize / 8));
				case 4:
					throw new CryptographicException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedHashAlgorithmReuse);
				case 15:
					if (flag)
					{
						m_rand.GetBytes(_0020);
						num2 = 19;
						continue;
					}
					num = 2;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_0046;
					}
					goto case 1;
				case 1:
				case 8:
					m_hash.TransformBlock(_0020, 0, _0020.Length, _0020, 0);
					goto case 9;
				case 20:
					return result;
				}
				break;
				IL_00b1:
				if (flag2)
				{
					num = 12;
					goto IL_0046;
				}
				flag3 = !m_hash.CanReuseTransform;
				num2 = 14;
				continue;
				IL_0026:
				if (flag4)
				{
					num2 = 0;
					continue;
				}
				m_hash.Initialize();
				_ = 0;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num = 1;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_0046;
					}
					goto IL_00fa;
				}
				num2 = 17;
				continue;
				IL_00fa:
				result = _0020;
				num2 = 20;
			}
			goto IL_0016;
			IL_0016:
			flag = num3 < _0020;
			num2 = 15;
			goto IL_004a;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ICryptoTransform CreateCryptoStream(OperationMode _0020)
		{
			//Discarded unreachable code: IL_0005, IL_004e
			//IL_0006: Incompatible stack heights: 0 vs 1
			_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
			int num2;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				int num = 5;
				num2 = num;
			}
			else
			{
				num2 = 1;
			}
			bool flag = default(bool);
			ICryptoTransform result = default(ICryptoTransform);
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 5:
					flag = _0020 == OperationMode.Encrypt;
					num2 = 2;
					continue;
				case 4:
					result = m_crypt.CreateEncryptor(m_aesKey2, m_iv2);
					break;
				case 2:
					if (!flag)
					{
						result = m_crypt.CreateDecryptor(m_aesKey2, m_iv2);
						num2 = 6;
					}
					else
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HMAC GetHMAC()
		{
			//Discarded unreachable code: IL_0005, IL_0060
			//IL_0006: Incompatible stack heights: 0 vs 1
			_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
			int num;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				num = 3;
				goto IL_0065;
			}
			int num2 = 2;
			goto IL_006d;
			IL_006d:
			HMAC hMAC = default(HMAC);
			HMAC result = default(HMAC);
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 3:
					hMAC = HMAC.Create(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2400));
					goto case 1;
				case 4:
					break;
				case 1:
				case 2:
					hMAC.Key = m_aesKey2;
					break;
				default:
					goto IL_008a;
				case 5:
					return result;
				}
				break;
				IL_008a:
				num2 = 4;
			}
			result = hMAC;
			num = 5;
			goto IL_0065;
			IL_0065:
			int num3 = num;
			num2 = num3;
			goto IL_006d;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] DecryptAESKey2(byte[] _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0098, IL_0143
			//IL_0006: Incompatible stack heights: 0 vs 1
			_ = 0;
			int num;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				num = 6;
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0116;
				}
			}
			goto IL_014c;
			IL_0150:
			int num2;
			MemoryStream memoryStream = default(MemoryStream);
			byte[] hash = default(byte[]);
			switch (num2)
			{
			case 0:
			case 6:
				break;
			case 1:
				try
				{
					using CryptoStream cryptoStream = new CryptoStream(memoryStream, m_crypt.CreateDecryptor(m_aesKey1, m_iv1), CryptoStreamMode.Read);
					m_iv2 = RepeatRead(cryptoStream, 16);
					_ = 1;
					int num3;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						num3 = 2;
						goto IL_00a5;
					}
					int num4 = 3;
					if (true)
					{
						num3 = num4;
						goto IL_00a5;
					}
					goto end_IL_0060;
					IL_00a5:
					switch (num3)
					{
					case 0:
					case 2:
						m_aesKey2 = RepeatRead(cryptoStream, 32);
						break;
					case 3:
						break;
					}
					end_IL_0060:;
				}
				finally
				{
					((IDisposable)memoryStream)?.Dispose();
				}
				m_hmac.Initialize();
				goto case 2;
			case 3:
				goto IL_0116;
			case 2:
			case 4:
				m_hmac.Key = m_aesKey1;
				goto case 5;
			default:
				num = 5;
				goto IL_014c;
			case 5:
				m_hmac.TransformFinalBlock(_0020, 0, _0020.Length);
				num = 3;
				if (true)
				{
					goto IL_014c;
				}
				goto case 7;
			case 7:
				return hash;
			}
			memoryStream = new MemoryStream(_0020);
			num = 1;
			if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_0116;
			}
			goto IL_014c;
			IL_0116:
			hash = m_hmac.Hash;
			num2 = 7;
			goto IL_0150;
			IL_014c:
			num2 = num;
			goto IL_0150;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBulkKeyToKey1()
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			m_iv2 = m_iv1;
			m_aesKey2 = m_aesKey1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Dispose()
		{
			//Discarded unreachable code: IL_0005, IL_0072
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 3;
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			bool flag5 = default(bool);
			bool flag4 = default(bool);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 11:
						do
						{
							m_hmac = null;
							num = 24;
						}
						while (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092());
						break;
					case 0:
						m_aesKey2 = null;
						num = 14;
						break;
					case 15:
						if (flag2)
						{
							num3 = 13;
							goto IL_0077;
						}
						goto case 5;
					case 19:
						Array.Clear(m_aesKey2, 0, m_aesKey2.Length);
						goto default;
					default:
						_ = 1;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num = 22;
							break;
						}
						num2 = 8;
						continue;
					case 8:
					case 16:
						m_iv1 = null;
						num = 0;
						break;
					case 12:
					case 22:
						flag3 = m_iv2 != null;
						num2 = 4;
						continue;
					case 13:
						Array.Clear(m_iv1, 0, m_iv1.Length);
						num3 = 5;
						goto IL_0077;
					case 20:
						m_aesKey1 = null;
						goto case 8;
					case 6:
						if (flag5)
						{
							num3 = 17;
							goto IL_0077;
						}
						goto case 18;
					case 21:
						Array.Clear(m_iv2, 0, m_iv2.Length);
						num2 = 20;
						continue;
					case 1:
						if (flag4)
						{
							num3 = 23;
							goto IL_0077;
						}
						return;
					case 9:
						m_hash = null;
						num = 11;
						if (0 == 0)
						{
							break;
						}
						goto case 5;
					case 5:
						flag = m_aesKey2 != null;
						num = 2;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 3;
					case 3:
						if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(140))
						{
							num2 = 10;
							continue;
						}
						return;
					case 23:
						flag5 = m_aesKey1 != null;
						num3 = 6;
						goto IL_0077;
					case 24:
						m_rand = null;
						num2 = 7;
						continue;
					case 18:
						flag2 = m_iv1 != null;
						num2 = 15;
						continue;
					case 17:
						Array.Clear(m_aesKey1, 0, m_aesKey1.Length);
						num = 18;
						if (true)
						{
							break;
						}
						goto case 10;
					case 10:
						flag4 = m_crypt != null;
						num3 = 1;
						goto IL_0077;
					case 4:
						if (flag3)
						{
							num = 21;
							break;
						}
						goto case 20;
					case 7:
						m_crypt = null;
						num3 = 25;
						goto IL_0077;
					case 2:
						if (flag)
						{
							num3 = 19;
							goto IL_0077;
						}
						goto case 12;
					case 14:
						m_iv2 = null;
						num = 9;
						if (1 == 0)
						{
							return;
						}
						break;
					case 25:
						return;
						IL_0077:
						num = num3;
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

	private class _0093_008C_008E_008E_008B_008A_0094_008C_008E_008B_0088_0090_0094_0093_0091_0086_0092_0090_008E_008D_0093_0086_008E_008B_008E_008E_0094_0090_008C_0088_0087_0093_0090_0095_0088_0092 : Stream
	{
		private Stream m_stream;

		private int m_hiddenByteCount;

		public override bool CanRead
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0005
				//IL_0006: Incompatible stack heights: 0 vs 1
				return m_stream.CanRead;
			}
		}

		public override bool CanSeek
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0005
				//IL_0006: Incompatible stack heights: 0 vs 1
				return m_stream.CanSeek;
			}
		}

		public override bool CanWrite
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0005
				//IL_0006: Incompatible stack heights: 0 vs 1
				return m_stream.CanWrite;
			}
		}

		public override long Length
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0005
				//IL_0006: Incompatible stack heights: 0 vs 1
				return m_stream.Length;
			}
		}

		public override long Position
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				//Discarded unreachable code: IL_0005
				//IL_0006: Incompatible stack heights: 0 vs 1
				return m_stream.Position;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				//Discarded unreachable code: IL_0005
				//IL_0006: Incompatible stack heights: 0 vs 1
				m_stream.Position = value;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public _0093_008C_008E_008E_008B_008A_0094_008C_008E_008B_0088_0090_0094_0093_0091_0086_0092_0090_008E_008D_0093_0086_008E_008B_008E_008E_0094_0090_008C_0088_0087_0093_0090_0095_0088_0092(Stream _0020, int _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0057
			//IL_0006: Incompatible stack heights: 0 vs 1
			_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
			int num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 4 : 3);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						m_hiddenByteCount = _0020;
						num = 5;
						goto end_IL_0060;
					case 0:
					case 3:
						base._002Ector();
						goto case 1;
					case 1:
					case 4:
						m_stream = _0020;
						goto case 2;
					default:
						num2 = 2;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 1;
					case 5:
						return;
					}
					continue;
					end_IL_0060:
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Flush()
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			m_stream.Flush();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override long Seek(long _0020, SeekOrigin _0020)
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return m_stream.Seek(_0020, _0020);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetLength(long _0020)
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			m_stream.SetLength(_0020);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(byte[] _0020, int _0020, int _0020)
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			m_stream.Write(_0020, _0020, _0020);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int Read(byte[] _0020, int _0020, int _0020)
		{
			//Discarded unreachable code: IL_0005, IL_006e
			//IL_0006: Incompatible stack heights: 0 vs 1
			_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
			int num;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				num = 3;
				goto IL_007b;
			}
			int num2 = 5;
			goto IL_0077;
			IL_0077:
			num = num2;
			goto IL_007b;
			IL_007b:
			bool flag = default(bool);
			long num3 = default(long);
			int result = default(int);
			while (true)
			{
				switch (num)
				{
				case 6:
					flag = num3 == 0;
					num2 = 2;
					if (true)
					{
						break;
					}
					goto case 4;
				case 2:
					if (!flag)
					{
						result = m_stream.Read(_0020, _0020, (int)num3);
						num2 = 7;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 6;
					}
					goto case 1;
				default:
					goto IL_00a0;
				case 0:
				case 3:
					num3 = Math.Max(0L, Math.Min(_0020, m_stream.Length - (m_stream.Position + m_hiddenByteCount)));
					num2 = 6;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 2;
				case 1:
					result = 0;
					goto case 4;
				case 4:
				case 5:
				case 7:
					return result;
				}
				break;
				IL_00a0:
				num = 1;
			}
			goto IL_0077;
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

	private readonly byte[] MAGIC_HEADER;

	public const byte MAX_FILE_VERSION = 2;

	private const int BLOCK_SIZE = 16;

	private const int IV_SIZE = 16;

	private const int KEY_SIZE = 32;

	private const int HASH_SIZE = 32;

	private Stream m_stream;

	private OperationMode m_mode;

	private CryptoStream m_crypto;

	private HMAC m_hmac;

	private int m_length;

	private _008E_008A_0091_008A_0091_008D_008A_008D_008D_0090_008F_0088_0093_008A_008F_0090_0095_008A_008F_0086_0089_0090_0086_0091_0088_0088_0093_0094_008B_0092_008B_0091_008F_0091_008C_008F m_helper;

	private List<KeyValuePair<string, byte[]>> m_extensions;

	private byte m_version;

	private bool m_hasWrittenHeader;

	private bool m_hasFlushedFinalBlock;

	private long m_payloadLength;

	private long m_readcount;

	private byte m_paddingSize;

	private bool m_hasReadFooter;

	public static string Extension_CreatedByIdentifier;

	public static bool Extension_InsertCreateByIdentifier;

	public static bool Extension_InsertTimeStamp;

	public static bool Extension_InsertPlaceholder;

	public static byte DefaultFileVersion;

	private CryptoStream Crypto
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005, IL_0032
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_0099: Incompatible stack heights: 0 vs 1
			int num = 5;
			CryptoStream crypto = default(CryptoStream);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						crypto = m_crypto;
						num2 = 6;
						continue;
					case 2:
						WriteEncryptionHeader();
						goto default;
					case 0:
					case 1:
						if (flag)
						{
							num = 2;
							break;
						}
						goto default;
					case 5:
						flag = m_crypto == null;
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num = 4;
							break;
						}
						num2 = 0;
						continue;
					case 6:
						return crypto;
					}
					break;
				}
			}
		}
	}

	public byte Version
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return m_version;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//Discarded unreachable code: IL_0005, IL_00c9
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_0135: Incompatible stack heights: 0 vs 1
			int num = 9;
			if (false)
			{
				goto IL_0016;
			}
			goto IL_00d2;
			IL_00d2:
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 10:
						break;
					case 7:
					case 11:
						throw new ArgumentOutOfRangeException(string.Format(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.VersionUnsupported, (byte)2));
					case 0:
						throw new InvalidOperationException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.StreamMustSupportSeeking);
					case 1:
						goto IL_0077;
					case 9:
						goto IL_0097;
					case 2:
						throw new InvalidOperationException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.VersionReadonly);
					default:
						goto IL_010f;
					case 4:
						goto IL_0119;
					case 5:
						goto IL_0129;
					case 6:
					case 8:
						goto IL_0145;
					case 3:
						throw new InvalidOperationException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.VersionReadonlyForDecryption);
					case 12:
						return;
					}
					break;
					IL_0119:
					if (flag)
					{
						goto IL_011f;
					}
					if (m_mode != 0)
					{
						goto IL_00bf;
					}
					goto IL_0180;
					IL_0145:
					if (m_stream.CanSeek)
					{
						goto IL_0066;
					}
					goto IL_0160;
					IL_0077:
					if (m_crypto != null)
					{
						goto IL_008d;
					}
					goto IL_00bf;
					IL_00bf:
					flag2 = value > 2;
					goto IL_0129;
					IL_0129:
					if (flag2)
					{
						goto IL_012f;
					}
					if (value != 0)
					{
						goto IL_0066;
					}
					goto IL_0145;
					IL_0066:
					m_version = value;
					num2 = 12;
				}
				break;
				IL_012f:
				_ = 0;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num = 6;
					continue;
				}
				goto IL_013a;
				IL_0180:
				num = 1;
				continue;
				IL_0097:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(20))
				{
					num = 10;
					continue;
				}
				return;
			}
			goto IL_0016;
			IL_013a:
			int num3 = 11;
			goto IL_00ce;
			IL_00ce:
			num = num3;
			goto IL_00d2;
			IL_0160:
			num3 = 0;
			goto IL_00ce;
			IL_011f:
			num3 = 3;
			goto IL_00ce;
			IL_0016:
			flag = m_mode == OperationMode.Decrypt;
			num3 = 4;
			goto IL_00ce;
			IL_008d:
			num3 = 2;
			goto IL_00ce;
			IL_010f:
			num3 = 5;
			goto IL_00ce;
		}
	}

	public IList<KeyValuePair<string, byte[]>> Extensions
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			if (m_mode == OperationMode.Decrypt || (m_mode == OperationMode.Encrypt && m_crypto != null))
			{
				return m_extensions.AsReadOnly();
			}
			return m_extensions;
		}
	}

	public override bool CanRead
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return Crypto.CanRead;
		}
	}

	public override bool CanSeek
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return Crypto.CanSeek;
		}
	}

	public override bool CanWrite
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return Crypto.CanWrite;
		}
	}

	public override long Length
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return Crypto.Length;
		}
	}

	public override long Position
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return Crypto.Position;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		set
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			Crypto.Position = value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void ReadEncryptionHeader(string _0020)
	{
		//Discarded unreachable code: IL_0005, IL_010d
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 49;
		bool flag13 = default(bool);
		int num6 = default(int);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		int num4 = default(int);
		string @string = default(string);
		byte[] array = default(byte[]);
		bool flag3 = default(bool);
		byte[] array2 = default(byte[]);
		bool flag7 = default(bool);
		byte[] array3 = default(byte[]);
		byte[] array7 = default(byte[]);
		byte[] array6 = default(byte[]);
		bool flag2 = default(bool);
		int num7 = default(int);
		bool flag14 = default(bool);
		bool flag5 = default(bool);
		bool flag12 = default(bool);
		bool flag10 = default(bool);
		bool flag6 = default(bool);
		int num5 = default(int);
		bool flag11 = default(bool);
		bool flag4 = default(bool);
		bool flag8 = default(bool);
		bool flag9 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 31:
					throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidHeaderMarker);
				case 37:
					flag13 = num6 > 0;
					num = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 6;
				case 6:
					throw new InvalidDataException(string.Format(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedFileVersion, m_version));
				case 43:
					m_paddingSize = array4[MAGIC_HEADER.Length + 1];
					num2 = 47;
					continue;
				case 48:
					array5 = RepeatRead(m_stream, 2);
					num = 14;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 25;
				case 25:
					if (num4 < 0)
					{
						num = 21;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 37;
					}
					@string = Encoding.UTF8.GetString(array, 0, num4);
					num = 40;
					break;
				case 35:
					num6 = 0;
					num2 = 48;
					continue;
				case 12:
					if (!flag3)
					{
						goto case 37;
					}
					goto case 13;
				default:
					num3 = 13;
					goto IL_0112;
				case 52:
					Array.Copy(array, num4 + 1, array2, 0, array2.Length);
					num3 = 3;
					goto IL_0112;
				case 21:
					throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidExtensionData);
				case 17:
				case 50:
					flag7 = m_payloadLength % 16 != 0;
					num = 27;
					if (true)
					{
						break;
					}
					goto case 15;
				case 15:
					throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidReservedFieldValue);
				case 3:
					m_extensions.Add(new KeyValuePair<string, byte[]>(@string, array2));
					num2 = 37;
					continue;
				case 46:
					num4 = Array.IndexOf(array, (byte)0);
					num2 = 25;
					continue;
				case 27:
					if (flag7)
					{
						num3 = 53;
						goto IL_0112;
					}
					return;
				case 41:
					m_helper = new _008E_008A_0091_008A_0091_008D_008A_008D_008D_0090_008F_0088_0093_008A_008F_0090_0095_008A_008F_0086_0089_0090_0086_0091_0088_0088_0093_0094_008B_0092_008B_0091_008F_0091_008C_008F(m_mode, _0020, array3);
					num3 = 39;
					goto IL_0112;
				case 42:
					array7 = RepeatRead(m_stream, array6.Length);
					num = 23;
					if (0 == 0)
					{
						break;
					}
					goto case 22;
				case 22:
					if (flag2)
					{
						num2 = 11;
						continue;
					}
					num7 = 0;
					_ = 1;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						num = 24;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 23;
					}
					num3 = 20;
					goto IL_0112;
				case 7:
					if (flag13)
					{
						goto case 48;
					}
					num = 38;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 26;
				case 26:
					if (flag14)
					{
						num = 35;
						break;
					}
					goto case 38;
				case 19:
					m_version = array4[MAGIC_HEADER.Length];
					num3 = 8;
					goto IL_0112;
				case 32:
					array4 = new byte[MAGIC_HEADER.Length + 2];
					num = 0;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 16;
				case 16:
					if (!flag5)
					{
						flag12 = m_version == 0;
						num3 = 28;
						goto IL_0112;
					}
					num2 = 6;
					continue;
				case 4:
				case 5:
				case 24:
					flag10 = num7 < MAGIC_HEADER.Length;
					num3 = 2;
					goto IL_0112;
				case 38:
					array3 = RepeatRead(m_stream, 16);
					num = 41;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 28;
				case 28:
					if (!flag12)
					{
						flag6 = array4[MAGIC_HEADER.Length + 1] != 0;
						num = 29;
					}
					else
					{
						num = 43;
					}
					break;
				case 11:
					throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidHeaderMarker);
				case 23:
					num5 = 0;
					num = 33;
					break;
				case 36:
					if (flag11)
					{
						num = 18;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 45;
					}
					num7++;
					num = 4;
					break;
				case 13:
					array = RepeatRead(m_stream, num6);
					num = 46;
					if (0 == 0)
					{
						break;
					}
					goto case 10;
				case 10:
					if (!flag4)
					{
						goto IL_0272;
					}
					num2 = 31;
					continue;
				case 1:
				case 33:
					do
					{
						flag8 = num5 < array6.Length;
						num = 30;
					}
					while (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092());
					break;
				case 45:
					if (!flag9)
					{
						m_helper.SetBulkKeyToKey1();
						num3 = 34;
					}
					else
					{
						num3 = 51;
					}
					goto IL_0112;
				case 30:
					if (!flag8)
					{
						m_payloadLength = m_stream.Length - m_stream.Position - 33;
						num = 17;
						break;
					}
					flag = array6[num5] != array7[num5];
					num = 9;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 39;
				case 51:
					array6 = m_helper.DecryptAESKey2(RepeatRead(m_stream, 48));
					num2 = 42;
					continue;
				case 29:
					if (flag6)
					{
						num = 15;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 17;
					}
					goto IL_0272;
				case 47:
					flag4 = m_paddingSize >= 16;
					num = 10;
					if (0 == 0)
					{
						break;
					}
					goto case 8;
				case 8:
					flag5 = m_version > 2;
					num3 = 16;
					goto IL_0112;
				case 14:
					num6 = (array5[0] << 8) | array5[1];
					flag3 = num6 != 0;
					num2 = 12;
					continue;
				case 0:
					flag2 = m_stream.Read(array4, 0, array4.Length) != array4.Length;
					num3 = 22;
					goto IL_0112;
				case 9:
					if (flag)
					{
						goto case 20;
					}
					num5++;
					num = 1;
					break;
				case 39:
					flag9 = m_version >= 1;
					num = 45;
					if (true)
					{
						break;
					}
					goto case 49;
				case 49:
					if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(4))
					{
						num = 32;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 2;
					}
					return;
				case 2:
					if (flag10)
					{
						flag11 = MAGIC_HEADER[num7] != array4[num7];
						num = 36;
						break;
					}
					num3 = 19;
					goto IL_0112;
				case 40:
					array2 = new byte[array.Length - num4 - 1];
					num = 52;
					break;
				case 34:
					m_payloadLength = m_stream.Length - m_stream.Position - 32;
					num3 = 50;
					goto IL_0112;
				case 20:
				case 44:
					throw new CryptographicException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidPassword);
				case 18:
					throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidHeaderMarker);
				case 53:
					{
						throw new CryptographicException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidFileLength);
					}
					IL_0112:
					num = num3;
					break;
					IL_0272:
					flag14 = m_version >= 2;
					num2 = 26;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteEncryptionHeader()
	{
		//Discarded unreachable code: IL_0005, IL_007f, IL_0293
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 11;
			goto IL_0084;
		}
		int num2 = 19;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			goto IL_0088;
		}
		goto IL_0122;
		IL_0084:
		num2 = num;
		goto IL_0088;
		IL_0088:
		bool flag2 = default(bool);
		byte[] array = default(byte[]);
		List<KeyValuePair<string, byte[]>>.Enumerator enumerator = default(List<KeyValuePair<string, byte[]>>.Enumerator);
		bool flag = default(bool);
		while (true)
		{
			IL_0088_2:
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 15:
					m_stream.Write(MAGIC_HEADER, 0, MAGIC_HEADER.Length);
					goto case 2;
				case 9:
					if (flag2)
					{
						num2 = 1;
						if (0 == 0)
						{
							goto IL_0088_2;
						}
						goto case 4;
					}
					array = m_helper.EncryptAESKey2();
					num3 = 13;
					continue;
				case 4:
					flag2 = m_version == 0;
					goto case 9;
				default:
					num2 = 9;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_0088_2;
					}
					goto case 16;
				case 17:
					enumerator = m_extensions.GetEnumerator();
					num2 = 20;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_0088_2;
					}
					break;
				case 7:
					break;
				case 10:
					m_crypto = new CryptoStream(new CryptoStream(new _0093_008C_008E_008E_008B_008A_0094_008C_008E_008B_0088_0090_0094_0093_0091_0086_0092_0090_008E_008D_0093_0086_008E_008B_008E_008E_0094_0090_008C_0088_0087_0093_0090_0095_0088_0092(m_stream, 0), m_hmac, CryptoStreamMode.Write), m_helper.CreateCryptoStream(m_mode), CryptoStreamMode.Write);
					num3 = 7;
					continue;
				case 2:
				case 19:
					m_stream.WriteByte(m_version);
					num3 = 3;
					continue;
				case 12:
					array = m_helper.CalculateKeyHmac();
					num2 = 6;
					goto IL_0088_2;
				case 6:
					m_stream.Write(array, 0, array.Length);
					num2 = 8;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_0088_2;
					}
					goto case 8;
				case 8:
				case 18:
					m_hmac = m_helper.GetHMAC();
					num = 10;
					goto IL_0084;
				case 13:
					m_stream.Write(array, 0, array.Length);
					num2 = 12;
					if (true)
					{
						goto IL_0088_2;
					}
					goto case 3;
				case 3:
					m_stream.WriteByte(0);
					num = 5;
					goto IL_0084;
				case 1:
					m_helper.SetBulkKeyToKey1();
					num = 18;
					goto IL_0084;
				case 20:
					try
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<string, byte[]> current = enumerator.Current;
							_ = 0;
							int num4;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								num4 = 2;
							}
							else
							{
								int num5 = 3;
								num4 = num5;
							}
							switch (num4)
							{
							case 0:
							case 2:
								WriteExtension(current.Key, current.Value);
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					m_stream.Write(new byte[2], 0, 2);
					num2 = 16;
					goto IL_0088_2;
				case 5:
					flag = m_version >= 2;
					num2 = 14;
					goto IL_0088_2;
				case 0:
				case 11:
					if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(8))
					{
						num3 = 15;
						continue;
					}
					return;
				case 14:
					if (flag)
					{
						num = 17;
						goto IL_0084;
					}
					goto case 16;
				case 16:
					m_stream.Write(m_helper.IV1, 0, m_helper.IV1.Length);
					num3 = 4;
					continue;
				case 21:
					return;
				}
				break;
			}
			break;
		}
		goto IL_0122;
		IL_0122:
		m_hasWrittenHeader = true;
		num = 21;
		goto IL_0084;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteExtension(string _0020, byte[] _0020)
	{
		//Discarded unreachable code: IL_0005, IL_007c
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0181: Incompatible stack heights: 0 vs 1
		int num = 6;
		if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			goto IL_001a;
		}
		goto IL_0085;
		IL_0085:
		byte[] bytes = default(byte[]);
		bool flag = default(bool);
		uint num3 = default(uint);
		while (true)
		{
			IL_0085_2:
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					break;
				case 7:
					m_stream.Write(bytes, 0, bytes.Length);
					num = 5;
					if (true)
					{
						goto IL_0085_2;
					}
					goto case 3;
				case 3:
				case 10:
					if (flag)
					{
						num = 11;
						goto IL_0085_2;
					}
					goto case 4;
				case 4:
					num3 = (uint)(bytes.Length + 1 + _0020.Length);
					break;
				default:
					num2 = 2;
					continue;
				case 12:
					goto IL_00d0;
				case 9:
					m_stream.WriteByte((byte)(num3 & 0xFFu));
					num = 7;
					if (true)
					{
						goto IL_0085_2;
					}
					goto case 0;
				case 0:
					flag = _0020 == null;
					goto case 3;
				case 1:
				case 8:
					goto IL_0123;
				case 11:
					_0020 = new byte[0];
					num2 = 4;
					continue;
				case 5:
					m_stream.WriteByte(0);
					num = 12;
					if (true)
					{
						goto IL_0085_2;
					}
					goto case 6;
				case 6:
					if (!_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(12))
					{
						return;
					}
					goto IL_0177;
				case 13:
					return;
				}
				break;
			}
			break;
			IL_0177:
			_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				num = 8;
				if (false)
				{
					return;
				}
				continue;
			}
			goto IL_0118;
		}
		goto IL_001a;
		IL_001a:
		m_stream.WriteByte((byte)((num3 >> 8) & 0xFFu));
		int num4 = 9;
		goto IL_0081;
		IL_0118:
		num4 = 10;
		goto IL_0081;
		IL_00d0:
		m_stream.Write(_0020, 0, _0020.Length);
		num4 = 13;
		goto IL_0081;
		IL_0081:
		num = num4;
		goto IL_0085;
		IL_0123:
		bytes = Encoding.UTF8.GetBytes(_0020);
		num4 = 0;
		goto IL_0081;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] RepeatRead(Stream _0020, int _0020)
	{
		//Discarded unreachable code: IL_0005, IL_00ed
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 1;
			if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_002a;
			}
			goto IL_00f6;
		}
		int num2 = 7;
		goto IL_00fa;
		IL_002a:
		bool flag = default(bool);
		int num3;
		if (!flag)
		{
			num3 = 2;
			goto IL_00f2;
		}
		byte[] array = default(byte[]);
		int num4 = _0020.Read(array, array.Length - _0020, _0020);
		num = 8;
		goto IL_00f6;
		IL_00f2:
		num = num3;
		goto IL_00f6;
		IL_00fa:
		byte[] result = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 6:
			case 7:
				break;
			case 3:
				if (num4 == 0)
				{
					num2 = 4;
					continue;
				}
				goto case 9;
			case 5:
				throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnexpectedEndOfStream);
			case 9:
				flag = _0020 > 0;
				break;
			case 8:
				_0020 -= num4;
				num3 = 3;
				goto IL_00f2;
			case 0:
			case 1:
				array = new byte[_0020];
				num = 9;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 5;
				}
				goto IL_00f6;
			case 2:
				result = array;
				num = 10;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto case 8;
				}
				goto IL_00f6;
			case 4:
				if (_0020 != 0)
				{
					goto case 5;
				}
				goto case 9;
			default:
				num = 5;
				goto IL_00f6;
			case 10:
				return result;
			}
			break;
		}
		goto IL_002a;
		IL_00f6:
		num2 = num;
		goto IL_00fa;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Encrypt(string _0020, Stream _0020, Stream _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0028
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_00de: Incompatible stack heights: 0 vs 1
		int num = 6;
		bool flag = default(bool);
		int count = default(int);
		byte[] array = default(byte[]);
		_008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089 obj = default(_008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 4:
				case 7:
					flag = (count = _0020.Read(array, 0, array.Length)) != 0;
					goto case 2;
				default:
					num = 2;
					if (0 == 0)
					{
						break;
					}
					goto case 2;
				case 2:
					if (!flag)
					{
						goto case 1;
					}
					obj.Write(array, 0, count);
					_ = 0;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num2 = 1;
						continue;
					}
					num = 7;
					break;
				case 1:
				case 5:
					obj.FlushFinalBlock();
					num2 = 8;
					continue;
				case 6:
					array = new byte[4096];
					num = 0;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 0;
				case 0:
					obj = new _008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089(_0020, _0020, OperationMode.Encrypt);
					num = 4;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				case 8:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Decrypt(string _0020, Stream _0020, Stream _0020)
	{
		//Discarded unreachable code: IL_0005, IL_008e
		//IL_0006: Incompatible stack heights: 0 vs 1
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 6;
			goto IL_0093;
		}
		int num2 = 3;
		goto IL_0097;
		IL_0097:
		byte[] array = default(byte[]);
		bool flag = default(bool);
		int count = default(int);
		_008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089 obj = default(_008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089);
		while (true)
		{
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 0:
				case 6:
					array = new byte[4096];
					goto case 1;
				case 4:
				case 5:
					flag = (count = obj.Read(array, 0, array.Length)) != 0;
					num = 2;
					goto end_IL_0097;
				case 2:
					if (!flag)
					{
						num2 = 7;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 1;
					}
					_0020.Write(array, 0, count);
					goto case 4;
				default:
					num2 = 4;
					break;
				case 1:
				case 3:
					obj = new _008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089(_0020, _0020, OperationMode.Decrypt);
					num3 = 5;
					continue;
				case 7:
					return;
				}
				break;
			}
			continue;
			end_IL_0097:
			break;
		}
		goto IL_0093;
		IL_0093:
		num2 = num;
		goto IL_0097;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Encrypt(string _0020, string _0020, string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		using FileStream fileStream = File.OpenRead(_0020);
		using FileStream fileStream2 = File.Create(_0020);
		Encrypt(_0020, fileStream, fileStream2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Decrypt(string _0020, string _0020, string _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		using FileStream fileStream = File.OpenRead(_0020);
		using FileStream fileStream2 = File.Create(_0020);
		Decrypt(_0020, fileStream, fileStream2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089(string _0020, Stream _0020, OperationMode _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0216
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_03e6: Incompatible stack heights: 0 vs 1
		int num = 12;
		bool flag2 = default(bool);
		bool extension_InsertPlaceholder = default(bool);
		bool flag = default(bool);
		bool extension_InsertTimeStamp = default(bool);
		bool extension_InsertCreateByIdentifier = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_021f:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 10:
						break;
					case 17:
						m_hasWrittenHeader = false;
						num3 = 32;
						continue;
					case 20:
						if (!_0020.CanRead)
						{
							num3 = 26;
							continue;
						}
						goto IL_01e7;
					case 11:
						m_crypto = new CryptoStream(new CryptoStream(new _0093_008C_008E_008E_008B_008A_0094_008C_008E_008B_0088_0090_0094_0093_0091_0086_0092_0090_008E_008D_0093_0086_008E_008B_008E_008E_0094_0090_008C_0088_0087_0093_0090_0095_0088_0092(m_stream, (m_version == 0) ? 32 : 33), m_hmac, CryptoStreamMode.Read), m_helper.CreateCryptoStream(m_mode), CryptoStreamMode.Read);
						num2 = 38;
						goto IL_021f;
					case 37:
						m_extensions.Add(new KeyValuePair<string, byte[]>(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(120), Encoding.UTF8.GetBytes(Extension_CreatedByIdentifier)));
						num2 = 33;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_021f;
						}
						goto case 20;
					case 32:
						goto IL_012b;
					case 8:
						flag2 = _0020 == OperationMode.Encrypt;
						num3 = 28;
						continue;
					case 6:
						extension_InsertPlaceholder = Extension_InsertPlaceholder;
						goto case 7;
					case 0:
						MAGIC_HEADER = Encoding.UTF8.GetBytes(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(104));
						num = 34;
						goto end_IL_021f;
					case 2:
						flag = _0020 == null;
						num = 30;
						goto end_IL_021f;
					case 13:
						goto IL_01a1;
					case 29:
						if (!_0020.CanWrite)
						{
							num3 = 16;
							continue;
						}
						goto IL_02e3;
					case 26:
						throw new ArgumentException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.StreamMustBeReadAble, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(108));
					case 4:
						m_extensions = new List<KeyValuePair<string, byte[]>>();
						goto case 8;
					default:
						num3 = 8;
						continue;
					case 16:
						throw new ArgumentException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.StreamMustBeWriteAble, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(108));
					case 28:
						if (flag2)
						{
							num3 = 27;
							continue;
						}
						ReadEncryptionHeader(_0020);
						num2 = 23;
						if (true)
						{
							goto IL_021f;
						}
						goto case 19;
					case 25:
						m_hasReadFooter = false;
						num = 21;
						goto end_IL_021f;
					case 9:
						m_extensions.Add(new KeyValuePair<string, byte[]>(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(124), Encoding.UTF8.GetBytes(DateTime.Now.ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(128)))));
						num2 = 10;
						goto IL_021f;
					case 12:
						if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(16))
						{
							num = 0;
							goto end_IL_021f;
						}
						return;
					case 34:
						m_version = 2;
						num2 = 17;
						goto IL_021f;
					case 33:
						extension_InsertTimeStamp = Extension_InsertTimeStamp;
						num = 18;
						goto end_IL_021f;
					case 15:
						throw new ArgumentException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidOperationMode, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(116));
					case 27:
						Version = DefaultFileVersion;
						_ = 0;
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							num2 = 7;
							if (true)
							{
								goto IL_021f;
							}
							goto case 0;
						}
						num2 = 5;
						if (true)
						{
							goto IL_021f;
						}
						goto case 3;
					case 3:
						if (_0020 != OperationMode.Decrypt)
						{
							num3 = 15;
							continue;
						}
						goto IL_03bf;
					case 14:
						if (extension_InsertCreateByIdentifier)
						{
							num = 37;
							goto end_IL_021f;
						}
						goto case 33;
					case 7:
					case 31:
						if (extension_InsertPlaceholder)
						{
							m_extensions.Add(new KeyValuePair<string, byte[]>("", new byte[127]));
							num2 = 13;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								goto IL_021f;
							}
							goto case 37;
						}
						goto IL_01a1;
					case 23:
						m_hmac = m_helper.GetHMAC();
						num2 = 11;
						goto IL_021f;
					case 24:
						extension_InsertCreateByIdentifier = Extension_InsertCreateByIdentifier;
						num3 = 14;
						continue;
					case 35:
						throw new ArgumentNullException(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(112));
					case 30:
						goto end_IL_0223;
					case 1:
						return;
					case 19:
						if (!flag3)
						{
							if (_0020 != 0)
							{
								num3 = 3;
								continue;
							}
							goto IL_03bf;
						}
						num2 = 35;
						goto IL_021f;
					case 36:
						m_stream = _0020;
						num3 = 4;
						continue;
					case 5:
					case 22:
						m_helper = new _008E_008A_0091_008A_0091_008D_008A_008D_008D_0090_008F_0088_0093_008A_008F_0090_0095_008A_008F_0086_0089_0090_0086_0091_0088_0088_0093_0094_008B_0092_008B_0091_008F_0091_008C_008F(_0020, _0020, null);
						num2 = 24;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_021f;
						}
						goto case 21;
					case 21:
						base._002Ector();
						num = 2;
						goto end_IL_021f;
					case 18:
						if (extension_InsertTimeStamp)
						{
							num2 = 9;
							if (0 == 0)
							{
								goto IL_021f;
							}
							return;
						}
						goto case 6;
					case 38:
						return;
						IL_02e3:
						if (_0020 != OperationMode.Decrypt)
						{
							goto IL_01e7;
						}
						num2 = 20;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_021f;
						}
						goto case 28;
						IL_03bf:
						if (_0020 != 0)
						{
							goto IL_02e3;
						}
						num2 = 29;
						if (true)
						{
							goto IL_021f;
						}
						goto case 27;
						IL_01e7:
						m_mode = _0020;
						num2 = 36;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_021f;
						}
						goto case 9;
					}
					m_extensions.Add(new KeyValuePair<string, byte[]>(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(132), Encoding.UTF8.GetBytes(DateTime.Now.ToUniversalTime().ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(136)))));
					num = 6;
					goto end_IL_021f;
					IL_01a1:
					m_crypto = null;
					num = 1;
					goto end_IL_021f;
					IL_012b:
					m_hasFlushedFinalBlock = false;
					num = 25;
					goto end_IL_021f;
					continue;
					end_IL_0223:
					break;
				}
				if (flag)
				{
					throw new ArgumentNullException(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(108));
				}
				flag3 = _0020 == null;
				num2 = 19;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					return;
				}
				continue;
				end_IL_021f:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Flush()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		Crypto.Flush();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override long Seek(long _0020, SeekOrigin _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return Crypto.Seek(_0020, _0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetLength(long _0020)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		Crypto.SetLength(_0020);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int Read(byte[] _0020, int _0020, int _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0051
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_039b: Incompatible stack heights: 0 vs 1
		int num = 23;
		if (true)
		{
			goto IL_005a;
		}
		goto IL_020e;
		IL_005a:
		byte[] hash = default(byte[]);
		bool flag3 = default(bool);
		int num3 = default(int);
		bool flag2 = default(bool);
		bool flag5 = default(bool);
		int result = default(int);
		bool flag4 = default(bool);
		byte[] array = default(byte[]);
		bool hasReadFooter = default(bool);
		bool flag = default(bool);
		bool flag6 = default(bool);
		int num4 = default(int);
		bool flag7 = default(bool);
		while (true)
		{
			IL_005a_2:
			int num2 = num;
			while (true)
			{
				string message;
				switch (num2)
				{
				case 15:
				case 17:
					break;
				default:
					num = 36;
					if (true)
					{
						goto IL_005a_2;
					}
					goto case 4;
				case 4:
					throw new InvalidOperationException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.CannotReadWhileEncrypting);
				case 21:
				case 35:
					goto IL_0134;
				case 0:
					if (m_readcount % 16 != 0)
					{
						goto IL_0165;
					}
					Crypto.Close();
					hash = m_hmac.Hash;
					goto case 26;
				case 6:
					flag3 = num3 < 0;
					num2 = 31;
					continue;
				case 11:
					flag2 = m_version >= 1;
					num2 = 30;
					continue;
				case 24:
					message = _0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.DataHMACMismatch;
					goto IL_01ac;
				case 3:
					m_length = (m_length + _0020) % 16;
					num2 = 10;
					continue;
				case 20:
					if (m_length % 16 != 0)
					{
						goto IL_0165;
					}
					goto IL_01eb;
				case 23:
					goto IL_01f5;
				case 19:
				case 32:
					goto end_IL_005e;
				case 34:
					goto IL_0224;
				case 12:
					throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidFileLength);
				case 36:
					flag5 = m_paddingSize > 16;
					num2 = 19;
					continue;
				case 9:
					result = _0020;
					num = 37;
					goto IL_005a_2;
				case 30:
					if (!flag2)
					{
						goto IL_0230;
					}
					num = 8;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_005a_2;
					}
					goto case 10;
				case 10:
					if (m_hasReadFooter)
					{
						goto case 9;
					}
					num = 28;
					if (0 == 0)
					{
						goto IL_005a_2;
					}
					goto case 22;
				case 22:
					result = 0;
					num2 = 13;
					continue;
				case 8:
					num3 = m_stream.ReadByte();
					num = 6;
					goto IL_005a_2;
				case 25:
					goto IL_0349;
				case 16:
					if (flag4)
					{
						num = 5;
						goto IL_005a_2;
					}
					goto case 20;
				case 2:
					goto IL_0370;
				case 1:
					goto IL_0381;
				case 31:
					if (!flag3)
					{
						m_paddingSize = (byte)num3;
						goto case 36;
					}
					goto IL_0395;
				case 5:
					goto IL_03ab;
				case 18:
					m_readcount += _0020;
					num = 3;
					goto IL_005a_2;
				case 26:
				case 27:
					array = RepeatRead(m_stream, hash.Length);
					num2 = 1;
					continue;
				case 29:
					if (m_version == 0)
					{
						message = _0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.DataHMACMismatch_v0;
						goto IL_01ac;
					}
					goto IL_0405;
				case 28:
					if (m_readcount != m_payloadLength)
					{
						goto case 9;
					}
					num = 25;
					if (true)
					{
						goto IL_005a_2;
					}
					goto IL_0439;
				case 7:
					goto IL_0439;
				case 14:
					if (!hasReadFooter)
					{
						_0020 = Crypto.Read(_0020, _0020, _0020);
						num2 = 18;
						continue;
					}
					num = 22;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_005a_2;
					}
					goto case 33;
				case 33:
					if (!flag)
					{
						hasReadFooter = m_hasReadFooter;
						num = 14;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_005a_2;
						}
						goto case 26;
					}
					num2 = 4;
					continue;
				case 13:
				case 37:
					{
						return result;
					}
					IL_01ac:
					throw new InvalidDataException(message);
					IL_0165:
					num = 12;
					if (true)
					{
						goto IL_005a_2;
					}
					goto case 6;
				}
				goto IL_0038;
				IL_0395:
				_ = 0;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num = 27;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_005a_2;
					}
					goto IL_0134;
				}
				goto IL_03a0;
				IL_0134:
				flag6 = num4 < hash.Length;
				num2 = 7;
				continue;
				IL_0370:
				if (!flag7)
				{
					num4++;
					num2 = 21;
					continue;
				}
				goto IL_0377;
				IL_0038:
				throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnexpectedEndOfStream);
				IL_01f5:
				if (!_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(24))
				{
					flag = m_mode != OperationMode.Decrypt;
					num = 33;
					if (0 == 0)
					{
						goto IL_005a_2;
					}
					goto IL_0038;
				}
				num2 = 32;
				continue;
				end_IL_005e:
				break;
			}
			break;
		}
		goto IL_020e;
		IL_03a0:
		int num5 = 15;
		goto IL_0056;
		IL_0230:
		flag4 = m_paddingSize > 0;
		num5 = 16;
		goto IL_0056;
		IL_0224:
		throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidFileLength);
		IL_0349:
		m_hasReadFooter = true;
		num5 = 11;
		goto IL_0056;
		IL_020e:
		if (flag5)
		{
			num = 34;
			if (0 == 0)
			{
				goto IL_005a;
			}
			goto IL_0224;
		}
		goto IL_0230;
		IL_03ab:
		_0020 -= 16 - m_paddingSize;
		num5 = 20;
		goto IL_0056;
		IL_01eb:
		num5 = 0;
		goto IL_0056;
		IL_0056:
		num = num5;
		goto IL_005a;
		IL_0381:
		num4 = 0;
		num5 = 35;
		goto IL_0056;
		IL_0439:
		if (flag6)
		{
			flag7 = hash[num4] != array[num4];
			num5 = 2;
		}
		else
		{
			num5 = 9;
		}
		goto IL_0056;
		IL_0377:
		num5 = 29;
		goto IL_0056;
		IL_0405:
		num5 = 24;
		goto IL_0056;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(byte[] _0020, int _0020, int _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0084
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 1;
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 1;
			if (1 == 0)
			{
				goto IL_0022;
			}
			goto IL_008d;
		}
		int num2 = 2;
		goto IL_0091;
		IL_008d:
		num2 = num;
		goto IL_0091;
		IL_0032:
		Crypto.Write(_0020, _0020, _0020);
		num = 6;
		goto IL_008d;
		IL_0091:
		switch (num2)
		{
		case 5:
			break;
		default:
			goto IL_0032;
		case 0:
		case 1:
			goto IL_004e;
		case 4:
			throw new InvalidOperationException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.CannotWriteWhileDecrypting);
		case 6:
			return;
		}
		goto IL_0022;
		IL_0022:
		bool flag = default(bool);
		int num3;
		if (flag)
		{
			num3 = 4;
			goto IL_0089;
		}
		m_length = (m_length + _0020) % 16;
		goto IL_0032;
		IL_004e:
		flag = m_mode != OperationMode.Encrypt;
		num3 = 5;
		goto IL_0089;
		IL_0089:
		num = num3;
		goto IL_008d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FlushFinalBlock()
	{
		//Discarded unreachable code: IL_0005, IL_00e9
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0352: Incompatible stack heights: 0 vs 1
		int num = 0;
		byte[] hash = default(byte[]);
		bool flag4 = default(bool);
		int num3 = default(int);
		bool flag = default(bool);
		byte b = default(byte);
		byte[] array = default(byte[]);
		bool flag6 = default(bool);
		int num5 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		long position = default(long);
		bool flag5 = default(bool);
		while (true)
		{
			int num4;
			int num2;
			switch (num)
			{
			case 23:
				m_stream.Write(hash, 0, hash.Length);
				goto case 17;
			case 11:
				if (flag4)
				{
					num4 = 19;
					if (false)
					{
						goto case 0;
					}
					goto IL_00f2;
				}
				goto case 15;
			case 0:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(28))
				{
					num = 33;
					break;
				}
				return;
			case 8:
				hash = m_hmac.Hash;
				num4 = 10;
				if (1 == 0)
				{
					goto case 1;
				}
				goto IL_00f2;
			case 1:
			case 14:
				num3++;
				num4 = 12;
				goto IL_00f2;
			case 22:
				flag = m_mode == OperationMode.Encrypt;
				num2 = 18;
				goto IL_00ee;
			case 32:
				m_stream.WriteByte(b);
				num = 25;
				break;
			case 7:
				Write(array, 0, array.Length);
				num4 = 15;
				if (1 == 0)
				{
					goto case 16;
				}
				goto IL_00f2;
			case 16:
				if (!flag6)
				{
					goto case 7;
				}
				array[num3] = (byte)array.Length;
				_ = 1;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					num4 = 17;
					if (false)
					{
						goto case 11;
					}
					goto IL_00f2;
				}
				num2 = 1;
				goto IL_00ee;
			default:
				num = 7;
				break;
			case 28:
				b = (byte)num5;
				num4 = 2;
				if (true)
				{
					goto IL_00f2;
				}
				goto case 31;
			case 31:
				if (flag3)
				{
					num2 = 23;
					goto IL_00ee;
				}
				m_stream.WriteByte(b);
				num4 = 30;
				if (true)
				{
					goto IL_00f2;
				}
				goto case 19;
			case 15:
				Crypto.FlushFinalBlock();
				num2 = 26;
				goto IL_00ee;
			case 6:
				if (flag2)
				{
					num4 = 29;
					if (0 == 0)
					{
						goto IL_00f2;
					}
					goto case 17;
				}
				goto case 9;
			case 17:
			case 24:
				position = m_stream.Position;
				num = 20;
				break;
			case 5:
			case 12:
				flag6 = num3 < array.Length;
				num4 = 16;
				if (0 == 0)
				{
					goto IL_00f2;
				}
				goto case 33;
			case 33:
				flag5 = !m_hasFlushedFinalBlock;
				num4 = 27;
				goto IL_00f2;
			case 27:
				if (flag5)
				{
					num2 = 22;
					goto IL_00ee;
				}
				return;
			case 21:
				m_stream.Flush();
				num4 = 3;
				goto IL_00f2;
			case 26:
				Crypto.Close();
				num = 8;
				break;
			case 2:
				flag4 = b != 0;
				num2 = 11;
				goto IL_00ee;
			case 10:
				flag3 = m_version == 0;
				num4 = 31;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_00f2;
				}
				goto case 9;
			case 9:
				num5 = (m_length %= 16);
				num4 = 28;
				goto IL_00f2;
			case 20:
				m_stream.Seek(MAGIC_HEADER.Length + 1, SeekOrigin.Begin);
				num4 = 32;
				goto IL_00f2;
			case 4:
				m_stream.Flush();
				num4 = 34;
				if (false)
				{
					return;
				}
				goto IL_00f2;
			case 3:
				return;
			case 19:
				array = new byte[16 - b];
				num4 = 13;
				goto IL_00f2;
			case 29:
				WriteEncryptionHeader();
				num = 9;
				break;
			case 13:
				num3 = 0;
				num4 = 5;
				goto IL_00f2;
			case 18:
				if (flag)
				{
					flag2 = !m_hasWrittenHeader;
					num2 = 6;
					goto IL_00ee;
				}
				return;
			case 25:
				m_stream.Seek(position, SeekOrigin.Begin);
				num = 21;
				break;
			case 30:
				m_stream.Write(hash, 0, hash.Length);
				num = 4;
				break;
			case 34:
				return;
				IL_00ee:
				num4 = num2;
				goto IL_00f2;
				IL_00f2:
				num = num4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool _0020)
	{
		//Discarded unreachable code: IL_0005, IL_00b7
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 16;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 14:
						break;
					case 16:
						goto IL_0026;
					case 4:
						m_hmac = null;
						num3 = 17;
						continue;
					case 5:
					case 13:
						m_helper = null;
						num = 4;
						goto end_IL_00c0;
					case 1:
						if (flag)
						{
							num3 = 15;
							continue;
						}
						return;
					case 12:
						m_stream.Dispose();
						num3 = 11;
						continue;
					case 7:
						m_crypto = null;
						num3 = 12;
						continue;
					case 2:
					case 10:
						flag = _0020;
						num3 = 1;
						continue;
					case 8:
						m_crypto.Dispose();
						goto case 7;
					default:
						num2 = 7;
						goto end_IL_00c4;
					case 15:
						if (m_mode == OperationMode.Encrypt)
						{
							num = 3;
							goto end_IL_00c0;
						}
						goto case 8;
					case 11:
						m_stream = null;
						num = 14;
						goto end_IL_00c0;
					case 6:
						return;
					case 9:
						FlushFinalBlock();
						num = 8;
						goto end_IL_00c0;
					case 3:
						if (m_hasFlushedFinalBlock)
						{
							goto case 8;
						}
						num2 = 9;
						if (true)
						{
							goto end_IL_00c4;
						}
						goto case 0;
					case 0:
						m_helper.Dispose();
						goto case 5;
					case 17:
						return;
					}
					m_extensions = null;
					num2 = 0;
					break;
					IL_0026:
					if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(32))
					{
						num3 = 6;
						continue;
					}
					goto IL_014c;
					continue;
					end_IL_00c4:
					break;
				}
				continue;
				IL_014c:
				base.Dispose(_0020);
				_ = 1;
				num2 = (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 5 : 10);
				continue;
				end_IL_00c0:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Main(string[] _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0081, IL_0160
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0216: Incompatible stack heights: 0 vs 1
		int num = 4;
		bool flag = default(bool);
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 4:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(36))
				{
					_ = 0;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 5;
						break;
					}
					num2 = 3;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_008a;
					}
				}
				else
				{
					flag = _0020.Length < 4;
				}
				goto case 2;
			case 0:
				Console.WriteLine(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.CommandlineUsage);
				num2 = 6;
				if (1 == 0)
				{
					return;
				}
				goto IL_008a;
			case 1:
			case 5:
				return;
			case 2:
			case 3:
				if (flag)
				{
					goto case 0;
				}
				try
				{
					bool flag2 = _0020[0].StartsWith(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(140), StringComparison.InvariantCultureIgnoreCase);
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						while (true)
						{
							int num5;
							switch (num4)
							{
							case 4:
								return;
							case 3:
								return;
							case 8:
								return;
							case 1:
								return;
							case 10:
								Decrypt(_0020[1], _0020[2], _0020[3]);
								return;
							default:
								num5 = 4;
								goto IL_0165;
							case 9:
								goto IL_01ac;
							case 5:
								if (!flag4)
								{
									flag3 = _0020[0].StartsWith(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(148));
									num5 = 2;
								}
								else
								{
									num5 = 10;
								}
								goto IL_0165;
							case 0:
								if (!flag2)
								{
									flag4 = _0020[0].StartsWith(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(144), StringComparison.InvariantCultureIgnoreCase);
									num3 = 5;
									break;
								}
								num3 = 9;
								if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
								{
									break;
								}
								goto case 6;
							case 6:
							case 7:
								Unittest();
								return;
							case 2:
								if (!flag3)
								{
									Console.WriteLine(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.CommandlineUnknownMode);
									num3 = 11;
									if (1 == 0)
									{
										return;
									}
									break;
								}
								_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
								if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
								{
									num3 = 3;
									break;
								}
								num3 = 6;
								if (false)
								{
									return;
								}
								break;
							case 11:
								return;
								IL_0165:
								num3 = num5;
								break;
							}
							break;
							IL_01ac:
							Encrypt(_0020[1], _0020[2], _0020[3]);
							num4 = 1;
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(string.Format(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.CommandlineError, ex.ToString()));
					return;
				}
			default:
				num = 0;
				break;
			case 6:
				return;
				IL_008a:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void Unittest()
	{
		//Discarded unreachable code: IL_0005, IL_014b, IL_0244, IL_03b6
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 6;
		if (false)
		{
			goto IL_0016;
		}
		goto IL_03bf;
		IL_03bf:
		int num2 = num;
		goto IL_03c3;
		IL_03c3:
		bool flag4 = default(bool);
		byte b = default(byte);
		bool flag = default(bool);
		int num5 = default(int);
		Random random = default(Random);
		int num4 = default(int);
		MemoryStream memoryStream2 = default(MemoryStream);
		bool flag5 = default(bool);
		bool flag3 = default(bool);
		MemoryStream memoryStream = default(MemoryStream);
		bool flag2 = default(bool);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 11:
				break;
			case 0:
				DefaultFileVersion = 2;
				num = 19;
				if (1 == 0)
				{
					goto case 25;
				}
				goto IL_03bf;
			case 25:
				Console.WriteLine();
				num2 = 3;
				continue;
			case 5:
				if (flag4)
				{
					num3 = 25;
					goto IL_03bb;
				}
				return;
			case 26:
				b = 0;
				num3 = 27;
				goto IL_03bb;
			case 24:
				flag4 = flag;
				num = 5;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 6;
				}
				goto IL_03bf;
			case 6:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(40))
				{
					num = 9;
					if (1 == 0)
					{
						goto case 16;
					}
					goto IL_03bf;
				}
				return;
			case 16:
				num5 = 0;
				num3 = 15;
				goto IL_03bb;
			case 21:
				try
				{
					byte[] array2 = new byte[random.Next(5120, 104857600)];
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					int num8;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num8 = 1;
						if (1 == 0)
						{
							goto IL_00e0;
						}
						goto IL_0154;
					}
					int num9 = 4;
					goto IL_0158;
					IL_00e0:
					flag |= Unittest(string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(164), num4, 1000, memoryStream2.Length), memoryStream2);
					num8 = 5;
					goto IL_0154;
					IL_0121:
					random.NextBytes(array2);
					num8 = 3;
					goto IL_0154;
					IL_0158:
					switch (num9)
					{
					case 0:
					case 1:
						goto IL_0121;
					case 3:
						memoryStream2.Write(array2, 0, array2.Length);
						break;
					case 5:
						goto end_IL_00a9;
					}
					goto IL_00e0;
					IL_0154:
					num9 = num8;
					goto IL_0158;
					end_IL_00a9:;
				}
				finally
				{
					((IDisposable)memoryStream2)?.Dispose();
				}
				num4++;
				num2 = 22;
				continue;
			case 18:
			case 20:
				if (!flag5)
				{
					num2 = 24;
					continue;
				}
				memoryStream2 = new MemoryStream();
				num = 21;
				goto IL_03bf;
			case 15:
			case 23:
				flag3 = num5 < 5120;
				_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num2 = 17;
					continue;
				}
				num3 = 18;
				goto IL_03bb;
			case 28:
				try
				{
					byte[] array = new byte[num5];
					int num6 = 3;
					while (true)
					{
						IL_0249:
						int num7 = num6;
						while (true)
						{
							switch (num7)
							{
							case 3:
								random.NextBytes(array);
								_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
								if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
								{
									goto IL_0221;
								}
								num6 = 0;
								break;
							case 1:
							case 4:
								memoryStream.Write(array, 0, array.Length);
								goto default;
							default:
								flag &= Unittest(string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(156), b, memoryStream.Length), memoryStream);
								num6 = 5;
								break;
							case 5:
								goto end_IL_024d;
							}
							goto IL_0249;
							IL_0221:
							num7 = 4;
							continue;
							end_IL_024d:
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)memoryStream)?.Dispose();
				}
				num5++;
				num = 23;
				goto IL_03bf;
			case 14:
				random = new Random();
				num = 8;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 12;
				}
				goto IL_03bf;
			case 13:
			case 22:
				flag5 = num4 < 1000;
				goto case 18;
			case 1:
				Console.WriteLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(168));
				num = 12;
				goto IL_03bf;
			case 12:
				Console.WriteLine();
				num3 = 29;
				goto IL_03bb;
			case 2:
				num4 = 0;
				num = 13;
				if (1 == 0)
				{
					goto case 3;
				}
				goto IL_03bf;
			case 3:
				Console.WriteLine();
				num3 = 1;
				goto IL_03bb;
			case 8:
				Console.WriteLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(152));
				num2 = 26;
				continue;
			case 10:
			case 17:
				if (flag3)
				{
					memoryStream = new MemoryStream();
					num3 = 28;
					goto IL_03bb;
				}
				num = 11;
				goto IL_03bf;
			case 4:
				if (flag2)
				{
					DefaultFileVersion = b;
					num3 = 16;
					goto IL_03bb;
				}
				goto case 0;
			default:
				num = 0;
				goto IL_03bf;
			case 19:
				Console.WriteLine(string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(160), DefaultFileVersion));
				num = 2;
				goto IL_03bf;
			case 7:
			case 27:
				flag2 = b <= 2;
				num2 = 4;
				continue;
			case 9:
				flag = true;
				num = 14;
				if (false)
				{
					return;
				}
				goto IL_03bf;
			case 29:
				return;
				IL_03bb:
				num = num3;
				goto IL_03bf;
			}
			break;
		}
		goto IL_0016;
		IL_0016:
		b = (byte)(b + 1);
		num2 = 7;
		goto IL_03c3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool Unittest(string _0020, MemoryStream _0020)
	{
		//Discarded unreachable code: IL_0005, IL_018a, IL_02e7
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 1;
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 1;
			goto IL_02ec;
		}
		int num2 = 4;
		goto IL_02f0;
		IL_02f0:
		int num3 = num2;
		int num6 = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			switch (num3)
			{
			case 0:
			case 1:
				break;
			case 3:
				try
				{
					Random random = new Random();
					char[] array = new char[random.Next(1, 25)];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(172)[random.Next(0, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(172).Length)];
					}
					_0020.Position = 0L;
					using MemoryStream memoryStream = new MemoryStream();
					using MemoryStream memoryStream2 = new MemoryStream();
					Encrypt(new string(array), _0020, memoryStream);
					int num4 = 6;
					while (true)
					{
						int num7;
						int num5;
						switch (num4)
						{
						case 4:
							memoryStream2.Position = 0L;
							num7 = 3;
							if (1 == 0)
							{
								goto case 13;
							}
							goto IL_0193;
						case 13:
							throw new Exception(string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(180), num6));
						case 5:
							flag3 = memoryStream2.Length != _0020.Length;
							num7 = 0;
							if (true)
							{
								goto IL_0193;
							}
							goto case 7;
						case 8:
						case 11:
							if (flag2)
							{
								flag = memoryStream2.ReadByte() != _0020.ReadByte();
								num7 = 12;
								goto IL_0193;
							}
							num4 = 14;
							continue;
						case 6:
							memoryStream.Position = 0L;
							_ = 1;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								num7 = 2;
								goto IL_0193;
							}
							num5 = 8;
							goto IL_018f;
						case 0:
							if (flag3)
							{
								goto case 9;
							}
							num6 = 0;
							num4 = 7;
							continue;
						default:
							num7 = 9;
							goto IL_0193;
						case 12:
							if (!flag)
							{
								num6++;
								num7 = 10;
								goto IL_0193;
							}
							num5 = 13;
							goto IL_018f;
						case 1:
						case 2:
							Decrypt(new string(array), memoryStream, memoryStream2);
							num5 = 4;
							goto IL_018f;
						case 3:
							_0020.Position = 0L;
							num4 = 5;
							continue;
						case 7:
						case 10:
							flag2 = num6 < memoryStream2.Length;
							goto case 8;
						case 9:
							throw new Exception(string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(176), memoryStream2.Length, _0020.Length));
						case 14:
							break;
							IL_0193:
							num4 = num7;
							continue;
							IL_018f:
							num7 = num5;
							goto IL_0193;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(184) + ex.Message);
					return false;
				}
				Console.WriteLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(188));
				goto IL_0325;
			default:
				goto IL_0325;
			case 5:
				return result;
			}
			break;
			IL_0325:
			result = true;
			num3 = 5;
		}
		Console.Write(_0020);
		num = 3;
		goto IL_02ec;
		IL_02ec:
		num2 = num;
		goto IL_02f0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089()
	{
		//Discarded unreachable code: IL_0005, IL_001c
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_008e: Incompatible stack heights: 0 vs 1
		int num = 1;
		while (true)
		{
			int num3;
			int num2;
			switch (num)
			{
			case 0:
			case 2:
				Extension_InsertTimeStamp = false;
				goto default;
			case 6:
				DefaultFileVersion = 2;
				num3 = 7;
				goto IL_0021;
			default:
				Extension_InsertPlaceholder = true;
				num3 = 6;
				goto IL_0021;
			case 4:
				Extension_InsertCreateByIdentifier = true;
				_ = 1;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					num2 = 5;
					goto IL_0025;
				}
				num = 0;
				break;
			case 1:
				Extension_CreatedByIdentifier = string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(192), Assembly.GetExecutingAssembly().GetName().Version);
				num = 4;
				break;
			case 7:
				return;
				IL_0021:
				num2 = num3;
				goto IL_0025;
				IL_0025:
				num = num2;
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
