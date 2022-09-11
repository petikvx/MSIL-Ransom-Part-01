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
		//Discarded unreachable code: IL_0005, IL_02f5
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 12:
					CannotWriteWhileDecrypting = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(88);
					num = 22;
					if (true)
					{
						break;
					}
					goto case 8;
				case 8:
					EncodingNotSupported = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(100);
					num = 26;
					break;
				case 22:
					DataHMACMismatch = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(92);
					num = 15;
					if (true)
					{
						break;
					}
					goto case 15;
				case 15:
					DataHMACMismatch_v0 = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(96);
					num3 = 8;
					goto IL_02fa;
				case 7:
					VersionReadonly = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(72);
					_ = 0;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 11;
						break;
					}
					num2 = 9;
					continue;
				case 19:
					InvalidHeaderMarker = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(44);
					num = 5;
					if (0 == 0)
					{
						break;
					}
					goto case 21;
				case 21:
					InvalidFileFormat = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(40);
					num3 = 19;
					goto IL_02fa;
				case 4:
					CommandlineUsage = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(0);
					CommandlineError = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(4);
					num = 25;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 19;
				case 23:
					UnsupportedFileVersion = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(52);
					num = 3;
					break;
				case 24:
					StreamMustBeReadAble = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(32);
					InvalidOperationMode = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(36);
					num = 21;
					if (true)
					{
						break;
					}
					goto case 20;
				case 20:
					UnexpectedEndOfStream = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(24);
					num3 = 16;
					goto IL_02fa;
				case 10:
					UnsupportedHashAlgorithmBlocks = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(16);
					num = 13;
					break;
				case 1:
					if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(0))
					{
						num = 4;
						if (0 == 0)
						{
							break;
						}
						goto case 13;
					}
					return;
				case 13:
					UnsupportedHashAlgorithmBlocksize = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(20);
					num = 20;
					if (true)
					{
						break;
					}
					goto case 5;
				case 5:
					InvalidReservedFieldValue = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(48);
					num = 23;
					if (true)
					{
						break;
					}
					goto case 16;
				case 16:
					StreamMustBeWriteAble = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(28);
					num = 24;
					break;
				case 14:
					InvalidFileLength = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(64);
					num3 = 2;
					goto IL_02fa;
				case 11:
				case 17:
					VersionUnsupported = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(76);
					goto case 9;
				case 6:
					InvalidPassword = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(60);
					num = 14;
					break;
				case 2:
					VersionReadonlyForDecryption = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(68);
					num = 7;
					break;
				case 9:
				case 18:
					StreamMustSupportSeeking = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(80);
					num3 = 0;
					goto IL_02fa;
				case 0:
					CannotReadWhileEncrypting = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(84);
					num3 = 12;
					goto IL_02fa;
				case 25:
					CommandlineUnknownMode = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(8);
					UnsupportedHashAlgorithmReuse = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(12);
					num2 = 10;
					continue;
				case 3:
					InvalidExtensionData = _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(56);
					goto case 6;
				default:
					num2 = 6;
					continue;
				case 26:
					return;
					IL_02fa:
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
			//Discarded unreachable code: IL_0005, IL_00bc
			//IL_0006: Incompatible stack heights: 0 vs 1
			_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
			int num;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				num = 1;
			}
			else
			{
				num = 13;
				if (false)
				{
					goto IL_00a2;
				}
			}
			goto IL_00c5;
			IL_0228:
			bool flag = _0020 == OperationMode.Encrypt;
			int num2 = 12;
			goto IL_00c1;
			IL_00c1:
			num = num2;
			goto IL_00c5;
			IL_00c5:
			while (true)
			{
				IL_00c5_2:
				int num3 = num;
				while (true)
				{
					switch (num3)
					{
					case 14:
						break;
					case 10:
						return;
					case 11:
						return;
					case 15:
						m_hash = HashAlgorithm.Create(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2384));
						goto case 6;
					case 5:
						goto end_IL_00c9;
					default:
						num2 = 2;
						goto IL_00c1;
					case 9:
						m_iv2 = GenerateIv2();
						num2 = 16;
						goto IL_00c1;
					case 8:
						goto IL_0136;
					case 12:
						goto IL_0157;
					case 6:
					case 13:
						m_rand = RandomNumberGenerator.Create();
						num2 = 5;
						goto IL_00c1;
					case 7:
						m_iv1 = GenerateIv1();
						m_aesKey1 = GenerateAESKey1(EncodePassword(_0020));
						num = 9;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_00c5_2;
						}
						goto case 16;
					case 16:
						m_aesKey2 = GenerateAESKey2();
						num = 10;
						goto IL_00c5_2;
					case 0:
					case 1:
						goto IL_01d7;
					case 4:
						m_crypt = SymmetricAlgorithm.Create(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2380));
						num3 = 14;
						continue;
					case 3:
						goto IL_0211;
					case 2:
						goto IL_0228;
					case 17:
						return;
					}
					m_crypt.Padding = PaddingMode.None;
					num = 3;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_00c5_2;
					}
					goto IL_0157;
					IL_01d7:
					if (!_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(120))
					{
						base._002Ector();
						num3 = 4;
					}
					else
					{
						num3 = 11;
					}
					continue;
					IL_0157:
					if (!flag)
					{
						m_iv1 = _0020;
						num3 = 8;
						continue;
					}
					num = 7;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_00c5_2;
					}
					goto IL_0211;
					IL_0211:
					m_crypt.Mode = CipherMode.CBC;
					num2 = 15;
					goto IL_00c1;
					IL_0136:
					m_aesKey1 = GenerateAESKey1(EncodePassword(_0020));
					num = 17;
					goto IL_00c5_2;
					continue;
					end_IL_00c9:
					break;
				}
				break;
			}
			goto IL_00a2;
			IL_00a2:
			m_hmac = HMAC.Create(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2388));
			goto IL_0228;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] EncodePassword(string _0020)
		{
			//Discarded unreachable code: IL_0005, IL_00ea
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_0249: Incompatible stack heights: 0 vs 1
			int num = 20;
			if (false)
			{
				goto IL_0016;
			}
			goto IL_00f3;
			IL_00f3:
			int num2 = num;
			goto IL_00f7;
			IL_00f7:
			byte[] bytes = default(byte[]);
			int num3 = default(int);
			byte b = default(byte);
			bool flag = default(bool);
			byte[] result = default(byte[]);
			byte[] array = default(byte[]);
			Encoding encoding = default(Encoding);
			bool flag2 = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 2:
					break;
				case 14:
				case 16:
					goto IL_002b;
				case 9:
					goto IL_003f;
				case 5:
					goto IL_005b;
				case 8:
					bytes[num3 + 1] = b;
					num3 += 2;
					num2 = 14;
					continue;
				case 3:
				case 19:
					if (flag)
					{
						goto case 1;
					}
					goto IL_00bb;
				case 1:
				case 13:
					throw new SystemException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.EncodingNotSupported);
				case 17:
					goto IL_00cc;
				default:
					num = 6;
					if (true)
					{
						goto IL_00f3;
					}
					goto case 7;
				case 7:
					result = bytes;
					num2 = 21;
					continue;
				case 4:
					throw new SystemException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.EncodingNotSupported);
				case 18:
					goto IL_01b4;
				case 11:
					flag = bytes.Length % 2 != 0;
					num2 = 19;
					continue;
				case 20:
					goto IL_01ea;
				case 6:
					goto IL_0203;
				case 10:
					goto IL_021c;
				case 15:
					goto IL_0259;
				case 12:
				case 21:
					return result;
				}
				break;
				IL_00cc:
				if (array[1] == byte.MaxValue)
				{
					goto IL_0203;
				}
				goto IL_02aa;
				IL_0203:
				bytes = encoding.GetBytes(_0020);
				num = 11;
				if (0 == 0)
				{
					goto IL_00f3;
				}
				goto IL_021c;
				IL_021c:
				if (!flag2)
				{
					num2 = 7;
					continue;
				}
				b = bytes[num3];
				bytes[num3] = bytes[num3 + 1];
				num = 8;
				goto IL_00f3;
				IL_00bb:
				num3 = 0;
				num = 16;
				goto IL_00f3;
				IL_003f:
				result = encoding.GetBytes(_0020);
				num = 12;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_005b;
				}
				goto IL_00f3;
			}
			goto IL_0016;
			IL_0259:
			if (array[1] == 254)
			{
				num = 9;
				goto IL_00f3;
			}
			goto IL_0176;
			IL_0016:
			if (encoding != null)
			{
				num = 18;
				if (1 == 0)
				{
					goto IL_002b;
				}
				goto IL_00f3;
			}
			object obj = null;
			goto IL_01c0;
			IL_01ea:
			int num4;
			if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(124))
			{
				num4 = 3;
			}
			else
			{
				encoding = Encoding.GetEncoding(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2392));
				_ = 1;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					num = 1;
					goto IL_00f3;
				}
				num4 = 0;
			}
			goto IL_00ef;
			IL_02aa:
			throw new SystemException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.EncodingNotSupported);
			IL_002b:
			flag2 = num3 < bytes.Length;
			num2 = 10;
			goto IL_00f7;
			IL_0176:
			if (array[0] == 254)
			{
				num4 = 17;
				goto IL_00ef;
			}
			goto IL_02aa;
			IL_01b4:
			obj = encoding.GetPreamble();
			goto IL_01c0;
			IL_0071:
			num4 = 4;
			goto IL_00ef;
			IL_005b:
			if (array.Length != 2)
			{
				goto IL_0071;
			}
			if (array[0] != byte.MaxValue)
			{
				goto IL_0176;
			}
			num = 15;
			if (true)
			{
				goto IL_00f3;
			}
			goto IL_01b4;
			IL_00ef:
			num = num4;
			goto IL_00f3;
			IL_01c0:
			array = (byte[])obj;
			if (array == null)
			{
				goto IL_0071;
			}
			num = 5;
			goto IL_00f3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] GenerateIv1()
		{
			//Discarded unreachable code: IL_0005, IL_002d, IL_0127
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_021e: Incompatible stack heights: 0 vs 1
			int num = 11;
			byte[] array = default(byte[]);
			int num8 = default(int);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			byte[] array2 = default(byte[]);
			byte[] result = default(byte[]);
			int num4 = default(int);
			long ticks = default(long);
			DateTime now = default(DateTime);
			bool flag4 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					IL_0036:
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 4:
							break;
						case 8:
							array = DEFAULT_MAC;
							goto case 10;
						default:
							num2 = 10;
							goto IL_0036;
						case 1:
						case 9:
							goto IL_008d;
						case 11:
							goto IL_009e;
						case 2:
						case 3:
							array = null;
							num2 = 6;
							if (true)
							{
								goto IL_0036;
							}
							goto case 6;
						case 6:
							try
							{
								NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
								_ = 1;
								int num5;
								if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
								{
									num5 = 3;
									goto IL_012c;
								}
								int num6 = 6;
								goto IL_0134;
								IL_0130:
								int num7;
								num6 = num7;
								goto IL_0134;
								IL_012c:
								num7 = num5;
								goto IL_0130;
								IL_0134:
								while (true)
								{
									switch (num6)
									{
									case 0:
									case 3:
										num8 = 0;
										num6 = 4;
										continue;
									case 1:
										array = allNetworkInterfaces[num8].GetPhysicalAddress().GetAddressBytes();
										break;
									default:
										num7 = 2;
										if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
										{
											goto IL_0130;
										}
										goto case 4;
									case 4:
									case 5:
									case 6:
										flag = num8 < allNetworkInterfaces.Length;
										num7 = 8;
										if (true)
										{
											goto IL_0130;
										}
										goto case 7;
									case 7:
										if (!flag2)
										{
											num8++;
											goto case 4;
										}
										goto IL_0194;
									case 2:
										break;
									case 8:
										goto IL_01d6;
									case 9:
										break;
									}
									break;
									IL_01d6:
									if (flag)
									{
										flag2 = num8 != NetworkInterface.LoopbackInterfaceIndex;
										num6 = 7;
										continue;
									}
									num7 = 9;
									if (false)
									{
										break;
									}
									goto IL_0130;
								}
								goto end_IL_00e6;
								IL_0194:
								num5 = 1;
								goto IL_012c;
								end_IL_00e6:;
							}
							catch
							{
							}
							flag3 = array == null;
							goto case 5;
						case 7:
							goto IL_0210;
						case 12:
							Array.Copy(array, 0, array2, 8, Math.Min(array.Length, array2.Length - 8));
							result = DigestRandomBytes(array2, 256);
							num2 = 15;
							goto IL_0036;
						case 14:
							goto IL_0261;
						case 10:
							num4 = 0;
							num2 = 1;
							goto IL_0036;
						case 0:
							num4++;
							num3 = 9;
							continue;
						case 5:
						case 13:
							if (!flag3)
							{
								goto case 10;
							}
							goto IL_0299;
						case 15:
							return result;
						}
						break;
						IL_0210:
						ticks = now.Ticks;
						_ = 0;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							num3 = 2;
							continue;
						}
						goto IL_0205;
					}
					if (!flag4)
					{
						num = 12;
						break;
					}
					array2[num4] = (byte)((ticks >> num4 * 8) & 0xFF);
					num = 0;
					break;
					IL_008d:
					flag4 = num4 < 8;
					num = 4;
					break;
					IL_0261:
					now = DateTime.Now;
					num = 7;
					break;
					IL_0205:
					num = 13;
					break;
					IL_0299:
					num = 8;
					break;
					IL_009e:
					array2 = new byte[16];
					num = 14;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] GenerateAESKey1(byte[] _0020)
		{
			//Discarded unreachable code: IL_0005, IL_022d
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 15;
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag2 = default(bool);
			byte[] result = default(byte[]);
			byte[] array = default(byte[]);
			int num3 = default(int);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num4;
					switch (num2)
					{
					case 2:
						if (flag3)
						{
							num = 17;
							if (0 == 0)
							{
								break;
							}
							goto case 15;
						}
						flag4 = 32 < m_hash.HashSize / 8;
						num2 = 6;
						continue;
					case 15:
						if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(128))
						{
							_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								num4 = 7;
								goto IL_0232;
							}
							num = 9;
							break;
						}
						flag2 = !m_hash.CanReuseTransform;
						num2 = 11;
						continue;
					case 4:
						result = array;
						num = 19;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 6;
					case 3:
						array = m_hash.Hash;
						num3++;
						num = 18;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 14;
					case 17:
						throw new CryptographicException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedHashAlgorithmBlocks);
					case 6:
						if (flag4)
						{
							num2 = 5;
							continue;
						}
						array = new byte[32];
						goto case 8;
					case 11:
						if (flag2)
						{
							num = 12;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								break;
							}
							goto case 14;
						}
						flag3 = !m_hash.CanTransformMultipleBlocks;
						num = 2;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 16;
					case 14:
						m_hash.TransformBlock(array, 0, array.Length, array, 0);
						num4 = 10;
						goto IL_0232;
					case 13:
						num3 = 0;
						num = 0;
						break;
					case 10:
						m_hash.TransformFinalBlock(_0020, 0, _0020.Length);
						num4 = 3;
						goto IL_0232;
					case 0:
					case 1:
					case 7:
					case 18:
						flag = num3 < 8192;
						num = 16;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 5;
					case 5:
						throw new CryptographicException(string.Format(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedHashAlgorithmBlocksize, 32, m_hash.HashSize / 8));
					case 12:
						throw new CryptographicException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedHashAlgorithmReuse);
					case 16:
						if (flag)
						{
							m_hash.Initialize();
							num4 = 14;
							goto IL_0232;
						}
						num = 4;
						if (0 == 0)
						{
							break;
						}
						goto case 8;
					case 8:
					case 9:
						Array.Copy(m_iv1, array, m_iv1.Length);
						goto case 13;
					default:
						num = 13;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 2;
					case 19:
						{
							return result;
						}
						IL_0232:
						num = num4;
						break;
					}
					break;
				}
			}
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
			//Discarded unreachable code: IL_0005, IL_0092
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
				default:
					cryptoStream.FlushFinalBlock();
					num = 4;
					if (true)
					{
						break;
					}
					goto case 0;
				case 0:
				case 3:
					cryptoStream.Write(m_aesKey2, 0, m_aesKey2.Length);
					goto default;
				case 4:
					return memoryStream.ToArray();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] CalculateKeyHmac()
		{
			//Discarded unreachable code: IL_0005, IL_0076
			//IL_0006: Incompatible stack heights: 0 vs 1
			_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
			int num;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				num = 4;
				if (1 == 0)
				{
					goto IL_0026;
				}
			}
			else
			{
				num = 2;
			}
			goto IL_007f;
			IL_005f:
			m_hmac.Key = m_aesKey1;
			goto IL_0042;
			IL_0026:
			m_hmac.Initialize();
			goto IL_005f;
			IL_007f:
			int num2 = num;
			goto IL_0083;
			IL_0083:
			byte[] result = default(byte[]);
			switch (num2)
			{
			case 0:
			case 4:
				break;
			case 3:
				goto IL_0042;
			case 1:
			case 2:
				goto IL_005f;
			default:
				num = 3;
				if (0 == 0)
				{
					goto IL_007f;
				}
				goto case 5;
			case 5:
				return result;
			}
			goto IL_0026;
			IL_0042:
			result = m_hmac.ComputeHash(EncryptAESKey2());
			num2 = 5;
			goto IL_0083;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] DigestRandomBytes(byte[] _0020, int _0020)
		{
			//Discarded unreachable code: IL_0005, IL_014d
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 7;
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			byte[] result = default(byte[]);
			bool flag = default(bool);
			bool flag4 = default(bool);
			int num3 = default(int);
			while (true)
			{
				int num2;
				int num4;
				switch (num)
				{
				case 10:
					Array.Copy(m_hash.Hash, _0020, _0020.Length);
					num = 8;
					break;
				case 5:
					if (flag2)
					{
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							num2 = 13;
							goto IL_0156;
						}
						num4 = 14;
					}
					else
					{
						flag3 = !m_hash.CanTransformMultipleBlocks;
						num4 = 1;
					}
					goto IL_0152;
				case 1:
					if (flag3)
					{
						goto case 6;
					}
					m_hash.Initialize();
					num2 = 17;
					goto IL_0156;
				case 6:
				case 14:
					throw new CryptographicException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedHashAlgorithmBlocks);
				case 8:
					result = _0020;
					num2 = 19;
					if (false)
					{
						goto case 7;
					}
					goto IL_0156;
				case 7:
					if (!_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(132))
					{
						flag = _0020.Length > m_hash.HashSize / 8;
						num4 = 15;
					}
					else
					{
						num4 = 0;
					}
					goto IL_0152;
				case 12:
					if (!flag4)
					{
						num2 = 11;
					}
					else
					{
						m_rand.GetBytes(_0020);
						num2 = 3;
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto case 4;
						}
					}
					goto IL_0156;
				case 4:
				case 13:
					throw new CryptographicException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedHashAlgorithmReuse);
				case 16:
					num3++;
					num4 = 2;
					goto IL_0152;
				case 3:
					m_hash.TransformBlock(_0020, 0, _0020.Length, _0020, 0);
					num2 = 16;
					goto IL_0156;
				case 9:
					num3 = 0;
					goto case 0;
				default:
					num = 18;
					break;
				case 17:
					m_hash.TransformBlock(_0020, 0, _0020.Length, _0020, 0);
					num2 = 9;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto case 16;
					}
					goto IL_0156;
				case 11:
					m_hash.TransformFinalBlock(_0020, 0, 0);
					num = 10;
					break;
				case 15:
					if (flag)
					{
						throw new CryptographicException(string.Format(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedHashAlgorithmBlocksize, _0020.Length, m_hash.HashSize / 8));
					}
					flag2 = !m_hash.CanReuseTransform;
					num2 = 5;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto case 10;
					}
					goto IL_0156;
				case 0:
				case 2:
				case 18:
					flag4 = num3 < _0020;
					num2 = 12;
					goto IL_0156;
				case 19:
					{
						return result;
					}
					IL_0152:
					num2 = num4;
					goto IL_0156;
					IL_0156:
					num = num2;
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ICryptoTransform CreateCryptoStream(OperationMode _0020)
		{
			//Discarded unreachable code: IL_0005, IL_0090
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 5;
			if (false)
			{
				goto IL_0016;
			}
			goto IL_0099;
			IL_0099:
			int num2 = num;
			goto IL_009d;
			IL_009d:
			bool flag = default(bool);
			ICryptoTransform result = default(ICryptoTransform);
			switch (num2)
			{
			case 5:
				break;
			case 1:
			case 3:
				if (!flag)
				{
					goto IL_0037;
				}
				goto case 0;
			case 0:
			case 2:
				result = m_crypt.CreateEncryptor(m_aesKey2, m_iv2);
				goto case 4;
			default:
				goto IL_00be;
			case 4:
			case 6:
				return result;
			}
			goto IL_0016;
			IL_00be:
			int num3 = 4;
			goto IL_0095;
			IL_0016:
			flag = _0020 == OperationMode.Encrypt;
			_ = 1;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				num2 = 3;
				goto IL_009d;
			}
			num3 = 0;
			goto IL_0095;
			IL_0095:
			num = num3;
			goto IL_0099;
			IL_0037:
			result = m_crypt.CreateDecryptor(m_aesKey2, m_iv2);
			num = 6;
			goto IL_0099;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HMAC GetHMAC()
		{
			//Discarded unreachable code: IL_0005, IL_005b
			//IL_0006: Incompatible stack heights: 0 vs 1
			_ = 0;
			int num;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				num = 1;
				if (1 == 0)
				{
					goto IL_0022;
				}
				goto IL_0064;
			}
			int num2 = 3;
			goto IL_0060;
			IL_0068:
			int num3;
			HMAC result = default(HMAC);
			HMAC hMAC = default(HMAC);
			switch (num3)
			{
			case 0:
			case 1:
				break;
			default:
				result = hMAC;
				num2 = 5;
				goto IL_0060;
			case 4:
				hMAC.Key = m_aesKey2;
				goto default;
			case 5:
				return result;
			}
			goto IL_0022;
			IL_0022:
			hMAC = HMAC.Create(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(2388));
			num3 = 4;
			goto IL_0068;
			IL_0060:
			num = num2;
			goto IL_0064;
			IL_0064:
			num3 = num;
			goto IL_0068;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] DecryptAESKey2(byte[] _0020)
		{
			//Discarded unreachable code: IL_0005, IL_00c5, IL_0155
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 4;
			byte[] hash = default(byte[]);
			MemoryStream memoryStream = default(MemoryStream);
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
						case 5:
							m_hmac.TransformFinalBlock(_0020, 0, _0020.Length);
							num2 = 6;
							break;
						case 6:
							hash = m_hmac.Hash;
							num2 = 7;
							if (0 == 0)
							{
								break;
							}
							goto case 4;
						case 4:
							memoryStream = new MemoryStream(_0020);
							_ = 0;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								goto IL_005f;
							}
							num2 = 3;
							if (0 == 0)
							{
								break;
							}
							goto case 2;
						case 0:
						case 1:
							try
							{
								using CryptoStream cryptoStream = new CryptoStream(memoryStream, m_crypt.CreateDecryptor(m_aesKey1, m_iv1), CryptoStreamMode.Read);
								m_iv2 = RepeatRead(cryptoStream, 16);
								_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
								switch (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 3 : 2)
								{
								case 0:
								case 2:
									m_aesKey2 = RepeatRead(cryptoStream, 32);
									break;
								case 3:
									break;
								}
							}
							finally
							{
								((IDisposable)memoryStream)?.Dispose();
							}
							m_hmac.Initialize();
							goto case 2;
						case 2:
						case 3:
							m_hmac.Key = m_aesKey1;
							goto case 5;
						default:
							goto end_IL_015e;
						case 7:
							return hash;
						}
						break;
						IL_005f:
						num3 = 0;
					}
					continue;
					end_IL_015e:
					break;
				}
				num = 5;
			}
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
			//Discarded unreachable code: IL_0005, IL_012f
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_01eb: Incompatible stack heights: 0 vs 1
			int num = 6;
			bool flag = default(bool);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num2;
				int num3;
				switch (num)
				{
				case 16:
					if (flag)
					{
						num = 4;
						break;
					}
					goto case 21;
				case 9:
					if (!flag3)
					{
						goto case 14;
					}
					num2 = 8;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto case 1;
					}
					goto IL_0138;
				case 15:
					flag = m_iv1 != null;
					num = 16;
					break;
				case 2:
				case 3:
					if (flag4)
					{
						num2 = 10;
						if (1 == 0)
						{
							goto case 8;
						}
						goto IL_0138;
					}
					return;
				case 8:
					Array.Clear(m_iv2, 0, m_iv2.Length);
					num2 = 14;
					if (1 == 0)
					{
						goto case 14;
					}
					goto IL_0138;
				case 14:
					m_aesKey1 = null;
					num = 19;
					break;
				case 18:
					if (!flag2)
					{
						goto IL_011f;
					}
					num2 = 17;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto case 10;
					}
					goto IL_0138;
				case 10:
					if (m_aesKey1 != null)
					{
						num = 20;
						break;
					}
					goto case 15;
				case 0:
					m_iv2 = null;
					m_hash = null;
					num2 = 12;
					goto IL_0138;
				case 1:
				case 11:
					flag4 = m_crypt != null;
					goto case 2;
				case 17:
					Array.Clear(m_aesKey2, 0, m_aesKey2.Length);
					goto IL_011f;
				default:
					num = 9;
					break;
				case 5:
					m_crypt = null;
					num = 22;
					break;
				case 20:
					Array.Clear(m_aesKey1, 0, m_aesKey1.Length);
					num3 = 15;
					goto IL_0134;
				case 6:
					if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(136))
					{
						_ = 0;
						num3 = (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092() ? 11 : 3);
						goto IL_0134;
					}
					return;
				case 21:
					flag2 = m_aesKey2 != null;
					num2 = 18;
					if (true)
					{
						goto IL_0138;
					}
					goto case 4;
				case 4:
					Array.Clear(m_iv1, 0, m_iv1.Length);
					num3 = 21;
					goto IL_0134;
				case 12:
					m_hmac = null;
					num3 = 13;
					goto IL_0134;
				case 19:
					m_iv1 = null;
					num3 = 7;
					goto IL_0134;
				case 7:
					m_aesKey2 = null;
					num2 = 0;
					if (0 == 0)
					{
						goto IL_0138;
					}
					goto case 13;
				case 13:
					m_rand = null;
					num2 = 5;
					goto IL_0138;
				case 22:
					return;
					IL_0138:
					num = num2;
					break;
					IL_011f:
					flag3 = m_iv2 != null;
					goto case 9;
					IL_0134:
					num2 = num3;
					goto IL_0138;
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
			//Discarded unreachable code: IL_0005, IL_0040
			//IL_0006: Incompatible stack heights: 0 vs 1
			_ = 0;
			int num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 3 : 4);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						goto IL_0021;
					case 1:
					case 3:
						break;
					default:
						num = 2;
						if (true)
						{
							goto end_IL_004d;
						}
						goto case 0;
					case 0:
					case 4:
						base._002Ector();
						break;
					case 5:
						return;
					}
					m_stream = _0020;
					goto IL_0021;
					IL_0021:
					m_hiddenByteCount = _0020;
					num2 = 5;
					continue;
					end_IL_004d:
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
			//Discarded unreachable code: IL_0005, IL_001c
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_00c1: Incompatible stack heights: 0 vs 1
			int num = 3;
			bool flag = default(bool);
			int result = default(int);
			long num2 = default(long);
			while (true)
			{
				int num3;
				int num4;
				switch (num)
				{
				case 1:
				case 2:
					if (flag)
					{
						goto case 5;
					}
					result = m_stream.Read(_0020, _0020, (int)num2);
					num3 = 7;
					goto IL_0021;
				default:
					num = 5;
					continue;
				case 5:
					result = 0;
					break;
				case 3:
					num2 = Math.Max(0L, Math.Min(_0020, m_stream.Length - (m_stream.Position + m_hiddenByteCount)));
					num4 = 6;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_0025;
					}
					goto case 5;
				case 6:
					flag = num2 == 0;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num3 = 0;
						goto IL_0021;
					}
					num = 1;
					continue;
				case 0:
				case 4:
				case 7:
					break;
					IL_0025:
					num = num4;
					continue;
					IL_0021:
					num4 = num3;
					goto IL_0025;
				}
				break;
			}
			return result;
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
			//Discarded unreachable code: IL_0005, IL_0072
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 0;
			if (1 == 0)
			{
				goto IL_0016;
			}
			goto IL_007b;
			IL_007b:
			int num2 = num;
			goto IL_007f;
			IL_007f:
			bool flag = default(bool);
			CryptoStream crypto = default(CryptoStream);
			switch (num2)
			{
			case 0:
				break;
			case 1:
			case 5:
				if (flag)
				{
					num = 4;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_007b;
					}
				}
				goto default;
			default:
				crypto = m_crypto;
				num = 6;
				goto IL_007b;
			case 4:
				WriteEncryptionHeader();
				goto default;
			case 6:
				return crypto;
			}
			goto IL_0016;
			IL_0016:
			flag = m_crypto == null;
			_ = 0;
			num2 = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 2 : 5);
			goto IL_007f;
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
			//Discarded unreachable code: IL_0005, IL_0026
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_0109: Incompatible stack heights: 0 vs 1
			int num = 7;
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					IL_002f:
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 3:
						case 5:
							throw new InvalidOperationException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.VersionReadonly);
						case 10:
							break;
						default:
							goto IL_00a1;
						case 2:
							return;
						case 1:
							goto IL_00d9;
						case 0:
							goto IL_00e9;
						case 4:
							goto IL_011e;
						case 11:
							throw new InvalidOperationException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.StreamMustSupportSeeking);
						case 8:
							throw new ArgumentOutOfRangeException(string.Format(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.VersionUnsupported, (byte)2));
						case 7:
							goto IL_0180;
						case 12:
							return;
						}
						if (!m_stream.CanSeek)
						{
							num3 = 11;
							continue;
						}
						goto IL_0149;
						IL_0180:
						if (!_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(20))
						{
							break;
						}
						num3 = 2;
						continue;
						IL_00d9:
						if (flag)
						{
							num3 = 4;
							continue;
						}
						if (m_mode == OperationMode.Encrypt)
						{
							num3 = 0;
							continue;
						}
						goto IL_001c;
						IL_00e9:
						if (m_crypto == null)
						{
							goto IL_001c;
						}
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							num3 = 9;
							continue;
						}
						num2 = 3;
						if (true)
						{
							goto IL_002f;
						}
						goto IL_011e;
						IL_00a1:
						if (flag2)
						{
							num2 = 8;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								goto IL_002f;
							}
							goto IL_00d9;
						}
						if (value != 0)
						{
							goto IL_0149;
						}
						goto IL_0176;
						IL_001c:
						flag2 = value > 2;
						goto IL_00a1;
						IL_011e:
						throw new InvalidOperationException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.VersionReadonlyForDecryption);
						IL_0149:
						m_version = value;
						num3 = 12;
					}
					flag = m_mode == OperationMode.Decrypt;
					num = 1;
					break;
					IL_0176:
					num = 10;
					break;
				}
			}
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
		//Discarded unreachable code: IL_0005, IL_04e9
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0391: Incompatible stack heights: 0 vs 1
		int num = 44;
		if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			goto IL_001a;
		}
		goto IL_04f2;
		IL_04f2:
		bool flag9 = default(bool);
		byte[] array6 = default(byte[]);
		byte[] array3 = default(byte[]);
		int num4 = default(int);
		bool flag8 = default(bool);
		int num6 = default(int);
		bool flag11 = default(bool);
		byte[] array2 = default(byte[]);
		int num5 = default(int);
		byte[] array4 = default(byte[]);
		bool flag13 = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		bool flag5 = default(bool);
		bool flag12 = default(bool);
		bool flag10 = default(bool);
		bool flag7 = default(bool);
		byte[] array = default(byte[]);
		bool flag3 = default(bool);
		byte[] array5 = default(byte[]);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		string @string = default(string);
		bool flag = default(bool);
		while (true)
		{
			IL_04f2_2:
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 19:
					break;
				case 9:
				case 30:
					flag9 = m_version > 2;
					num = 11;
					if (true)
					{
						goto IL_04f2_2;
					}
					goto case 38;
				case 38:
					array6 = RepeatRead(m_stream, array3.Length);
					num2 = 29;
					continue;
				case 29:
					num4 = 0;
					num = 7;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_04f2_2;
					}
					goto case 9;
				case 35:
					if (flag8)
					{
						num6 = 0;
						num = 37;
						if (true)
						{
							goto IL_04f2_2;
						}
						goto case 36;
					}
					goto IL_0106;
				case 36:
					while (!flag11)
					{
						num4++;
						num = 24;
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							continue;
						}
						goto IL_04f2_2;
					}
					num2 = 28;
					continue;
				case 41:
					Array.Copy(array2, num5 + 1, array4, 0, array4.Length);
					num2 = 32;
					continue;
				case 32:
					goto IL_00e6;
				case 10:
					goto IL_0106;
				case 20:
					throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidHeaderMarker);
				case 14:
					goto IL_0156;
				case 34:
					throw new InvalidDataException(string.Format(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnsupportedFileVersion, m_version));
				case 2:
					array3 = m_helper.DecryptAESKey2(RepeatRead(m_stream, 48));
					num2 = 38;
					continue;
				case 6:
					goto IL_01c9;
				case 40:
					goto IL_01df;
				case 12:
					goto IL_01f0;
				case 46:
					if (flag13)
					{
						num = 16;
						if (true)
						{
							goto IL_04f2_2;
						}
						goto case 43;
					}
					goto case 4;
				case 43:
					if (flag2)
					{
						goto IL_021d;
					}
					num3 = 0;
					num = 45;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_04f2_2;
					}
					goto case 1;
				case 23:
					goto IL_0227;
				case 28:
					throw new CryptographicException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidPassword);
				case 4:
					flag5 = num6 > 0;
					num2 = 19;
					continue;
				case 7:
				case 24:
					flag12 = num4 < array3.Length;
					num = 12;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_04f2_2;
					}
					goto case 4;
				case 16:
					array2 = RepeatRead(m_stream, num6);
					num = 25;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_04f2_2;
					}
					goto case 21;
				case 21:
					throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidHeaderMarker);
				case 45:
					flag10 = num3 < MAGIC_HEADER.Length;
					num = 40;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_04f2_2;
					}
					goto case 11;
				case 11:
					if (!flag9)
					{
						flag7 = m_version == 0;
						num2 = 13;
						continue;
					}
					goto IL_030b;
				case 31:
					throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidHeaderMarker);
				case 1:
					m_version = array[MAGIC_HEADER.Length];
					goto case 9;
				case 13:
					if (!flag7)
					{
						if (array[MAGIC_HEADER.Length + 1] != 0)
						{
							num = 18;
							if (0 == 0)
							{
								goto IL_04f2_2;
							}
							goto IL_0156;
						}
						goto IL_040a;
					}
					num = 0;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_04f2_2;
					}
					goto case 45;
				case 33:
					if (!flag3)
					{
						goto IL_040a;
					}
					num2 = 20;
					continue;
				case 42:
					m_helper = new _008E_008A_0091_008A_0091_008D_008A_008D_008D_0090_008F_0088_0093_008A_008F_0090_0095_008A_008F_0086_0089_0090_0086_0091_0088_0088_0093_0094_008B_0092_008B_0091_008F_0091_008C_008F(m_mode, _0020, array5);
					flag6 = m_version >= 1;
					num = 6;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_04f2_2;
					}
					goto case 44;
				case 44:
					if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(4))
					{
						num2 = 15;
						continue;
					}
					goto IL_0645;
				case 18:
					throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidReservedFieldValue);
				case 39:
					throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidExtensionData);
				case 27:
					array4 = new byte[array2.Length - num5 - 1];
					num2 = 41;
					continue;
				case 22:
					goto IL_048f;
				case 37:
					goto IL_04ba;
				case 25:
					num5 = Array.IndexOf(array2, (byte)0);
					flag4 = num5 < 0;
					goto case 17;
				default:
					num = 17;
					goto IL_04f2_2;
				case 17:
					if (!flag4)
					{
						@string = Encoding.UTF8.GetString(array2, 0, num5);
						num = 27;
						goto IL_04f2_2;
					}
					num = 39;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_04f2_2;
					}
					goto case 2;
				case 0:
					m_paddingSize = array[MAGIC_HEADER.Length + 1];
					flag3 = m_paddingSize >= 16;
					num = 33;
					if (true)
					{
						goto IL_04f2_2;
					}
					goto case 3;
				case 3:
				case 26:
					if (m_payloadLength % 16 != 0)
					{
						num = 47;
						if (true)
						{
							goto IL_04f2_2;
						}
					}
					return;
				case 15:
					return;
				case 5:
				case 8:
					if (!flag)
					{
						num3++;
						goto case 45;
					}
					num2 = 21;
					continue;
				case 47:
					{
						throw new CryptographicException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidFileLength);
					}
					IL_040a:
					flag8 = m_version >= 2;
					num = 35;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_04f2_2;
					}
					goto case 39;
				}
				break;
				IL_01f0:
				if (flag12)
				{
					flag11 = array3[num4] != array6[num4];
					num2 = 36;
					continue;
				}
				goto IL_01f7;
				IL_01df:
				if (!flag10)
				{
					num2 = 1;
					continue;
				}
				flag = MAGIC_HEADER[num3] != array[num3];
				_ = 0;
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num2 = 30;
					continue;
				}
				goto IL_0396;
				IL_01c9:
				if (flag6)
				{
					num = 2;
					if (true)
					{
						goto IL_04f2_2;
					}
					goto IL_01df;
				}
				m_helper.SetBulkKeyToKey1();
				num = 23;
				goto IL_04f2_2;
			}
			break;
		}
		goto IL_001a;
		IL_04ba:
		byte[] array7 = RepeatRead(m_stream, 2);
		int num7 = 14;
		goto IL_04ee;
		IL_0106:
		array5 = RepeatRead(m_stream, 16);
		num7 = 42;
		goto IL_04ee;
		IL_030b:
		num7 = 34;
		goto IL_04ee;
		IL_0396:
		num7 = 8;
		goto IL_04ee;
		IL_04ee:
		num = num7;
		goto IL_04f2;
		IL_0156:
		num6 = (array7[0] << 8) | array7[1];
		flag13 = num6 != 0;
		num7 = 46;
		goto IL_04ee;
		IL_021d:
		num7 = 31;
		goto IL_04ee;
		IL_00e6:
		m_extensions.Add(new KeyValuePair<string, byte[]>(@string, array4));
		num7 = 4;
		goto IL_04ee;
		IL_01f7:
		num7 = 22;
		goto IL_04ee;
		IL_048f:
		m_payloadLength = m_stream.Length - m_stream.Position - 33;
		num7 = 3;
		goto IL_04ee;
		IL_0227:
		m_payloadLength = m_stream.Length - m_stream.Position - 32;
		num7 = 26;
		goto IL_04ee;
		IL_0645:
		array = new byte[MAGIC_HEADER.Length + 2];
		flag2 = m_stream.Read(array, 0, array.Length) != array.Length;
		num7 = 43;
		goto IL_04ee;
		IL_001a:
		if (flag5)
		{
			goto IL_04ba;
		}
		num = 10;
		goto IL_04f2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteEncryptionHeader()
	{
		//Discarded unreachable code: IL_0005, IL_020f, IL_02e0
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0187: Incompatible stack heights: 0 vs 1
		int num = 18;
		bool flag = default(bool);
		byte[] array = default(byte[]);
		bool flag2 = default(bool);
		List<KeyValuePair<string, byte[]>>.Enumerator enumerator = default(List<KeyValuePair<string, byte[]>>.Enumerator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				switch (num2)
				{
				case 5:
					if (flag)
					{
						num4 = 0;
						goto IL_0214;
					}
					array = m_helper.EncryptAESKey2();
					num = 4;
					break;
				case 0:
					m_helper.SetBulkKeyToKey1();
					goto case 13;
				case 13:
				case 14:
					m_hmac = m_helper.GetHMAC();
					num = 12;
					break;
				case 11:
					m_stream.Write(array, 0, array.Length);
					goto case 13;
				case 7:
					m_stream.WriteByte(m_version);
					num = 9;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 2;
				case 2:
					m_stream.Write(m_helper.IV1, 0, m_helper.IV1.Length);
					num4 = 3;
					goto IL_0214;
				case 9:
					m_stream.WriteByte(0);
					num4 = 8;
					goto IL_0214;
				case 16:
					m_stream.Write(MAGIC_HEADER, 0, MAGIC_HEADER.Length);
					num = 7;
					break;
				case 12:
					m_crypto = new CryptoStream(new CryptoStream(new _0093_008C_008E_008E_008B_008A_0094_008C_008E_008B_0088_0090_0094_0093_0091_0086_0092_0090_008E_008D_0093_0086_008E_008B_008E_008E_0094_0090_008C_0088_0087_0093_0090_0095_0088_0092(m_stream, 0), m_hmac, CryptoStreamMode.Write), m_helper.CreateCryptoStream(m_mode), CryptoStreamMode.Write);
					num2 = 10;
					continue;
				case 15:
					if (!flag2)
					{
						goto case 2;
					}
					enumerator = m_extensions.GetEnumerator();
					_ = 1;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						num = 13;
						break;
					}
					num4 = 1;
					goto IL_0214;
				case 8:
					flag2 = m_version >= 2;
					num4 = 15;
					goto IL_0214;
				case 18:
					if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(8))
					{
						num = 16;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 9;
					}
					return;
				case 17:
					array = m_helper.CalculateKeyHmac();
					num2 = 11;
					continue;
				case 10:
					m_hasWrittenHeader = true;
					num4 = 19;
					goto IL_0214;
				case 3:
					flag = m_version == 0;
					goto case 5;
				default:
					num = 5;
					break;
				case 4:
					m_stream.Write(array, 0, array.Length);
					num = 17;
					if (true)
					{
						break;
					}
					goto case 1;
				case 1:
				case 6:
					try
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<string, byte[]> current = enumerator.Current;
							_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
							int num3;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								num3 = 2;
							}
							else
							{
								num3 = 3;
								if (1 == 0)
								{
									continue;
								}
							}
							switch (num3)
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
					num2 = 2;
					continue;
				case 19:
					return;
					IL_0214:
					num = num4;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteExtension(string _0020, byte[] _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0053
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 2;
		byte[] bytes = default(byte[]);
		uint num4 = default(uint);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_005c:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 12:
						break;
					case 3:
						m_stream.Write(bytes, 0, bytes.Length);
						num2 = 4;
						if (true)
						{
							goto IL_005c;
						}
						goto case 10;
					case 10:
						num4 = (uint)(bytes.Length + 1 + _0020.Length);
						goto default;
					default:
						_ = 1;
						num2 = (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 9 : 0);
						goto IL_005c;
					case 1:
						m_stream.Write(_0020, 0, _0020.Length);
						num2 = 13;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_005c;
						}
						goto case 0;
					case 8:
						goto end_IL_0060;
					case 7:
					case 9:
						do
						{
							m_stream.WriteByte((byte)(num4 & 0xFFu));
							num2 = 3;
						}
						while (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091());
						goto IL_005c;
					case 4:
						m_stream.WriteByte(0);
						num2 = 1;
						goto IL_005c;
					case 2:
						if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(12))
						{
							num3 = 5;
							continue;
						}
						return;
					case 5:
						bytes = Encoding.UTF8.GetBytes(_0020);
						num2 = 12;
						if (true)
						{
							goto IL_005c;
						}
						goto case 11;
					case 11:
						if (!flag)
						{
							goto case 10;
						}
						goto IL_0174;
					case 0:
					case 6:
						m_stream.WriteByte((byte)((num4 >> 8) & 0xFFu));
						goto case 7;
					case 13:
						return;
					}
					flag = _0020 == null;
					num2 = 11;
					goto IL_005c;
					continue;
					end_IL_0060:
					break;
				}
				_0020 = new byte[0];
				num = 10;
				break;
				IL_0174:
				num = 8;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] RepeatRead(Stream _0020, int _0020)
	{
		//Discarded unreachable code: IL_0005, IL_00a1
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0076: Incompatible stack heights: 0 vs 1
		int num = 3;
		int num2 = default(int);
		bool flag = default(bool);
		byte[] array = default(byte[]);
		byte[] result = default(byte[]);
		while (true)
		{
			int num4;
			int num3;
			switch (num)
			{
			case 0:
				if (num2 != 0)
				{
					goto case 1;
				}
				num4 = 9;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_00aa;
				}
				goto case 2;
			case 4:
				if (!flag)
				{
					goto case 2;
				}
				num2 = _0020.Read(array, array.Length - _0020, _0020);
				num4 = 5;
				if (1 == 0)
				{
					goto case 3;
				}
				goto IL_00aa;
			case 3:
				array = new byte[_0020];
				_ = 1;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					num = 2;
					break;
				}
				num4 = 8;
				if (false)
				{
					goto case 9;
				}
				goto IL_00aa;
			case 9:
				if (_0020 != 0)
				{
					goto case 6;
				}
				goto case 1;
			default:
				num = 6;
				break;
			case 5:
				_0020 -= num2;
				num3 = 0;
				goto IL_00a6;
			case 6:
				throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnexpectedEndOfStream);
			case 1:
			case 8:
				flag = _0020 > 0;
				num4 = 4;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_00aa;
				}
				goto case 2;
			case 2:
			case 7:
				result = array;
				num3 = 10;
				goto IL_00a6;
			case 10:
				{
					return result;
				}
				IL_00a6:
				num4 = num3;
				goto IL_00aa;
				IL_00aa:
				num = num4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Encrypt(string _0020, Stream _0020, Stream _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0028
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 0;
		bool flag = default(bool);
		int count = default(int);
		byte[] array = default(byte[]);
		_008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089 obj = default(_008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089);
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
					case 2:
					case 5:
					case 7:
						flag = (count = _0020.Read(array, 0, array.Length)) != 0;
						goto case 6;
					default:
						num = 6;
						break;
					case 0:
						array = new byte[4096];
						_ = 0;
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto end_IL_0035;
						}
						num = 3;
						break;
					case 4:
						goto IL_00a2;
					case 1:
					case 3:
						obj = new _008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089(_0020, _0020, OperationMode.Encrypt);
						goto case 2;
					case 6:
						if (flag)
						{
							obj.Write(array, 0, count);
							num = 5;
						}
						else
						{
							num = 4;
						}
						break;
					case 8:
						return;
					}
					goto end_IL_0031;
					IL_00a2:
					obj.FlushFinalBlock();
					num3 = 8;
					continue;
					end_IL_0035:
					break;
				}
				num2 = 7;
				continue;
				end_IL_0031:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Decrypt(string _0020, Stream _0020, Stream _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0096
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 4;
		bool flag = default(bool);
		byte[] array = default(byte[]);
		int count = default(int);
		_008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089 obj = default(_008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!flag)
					{
						num = 7;
						break;
					}
					_0020.Write(array, 0, count);
					goto default;
				default:
					flag = (count = obj.Read(array, 0, array.Length)) != 0;
					num = 1;
					break;
				case 0:
					obj = new _008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089(_0020, _0020, OperationMode.Decrypt);
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 5;
						if (1 == 0)
						{
							goto IL_006d;
						}
					}
					else
					{
						num = 6;
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							return;
						}
					}
					break;
				case 4:
					goto IL_006d;
				case 7:
					return;
				}
				break;
				IL_006d:
				array = new byte[4096];
				num2 = 0;
			}
		}
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
		//Discarded unreachable code: IL_0005, IL_002e
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 23;
			if (false)
			{
				goto IL_0022;
			}
			goto IL_0037;
		}
		int num2 = 1;
		goto IL_003b;
		IL_0022:
		m_stream = _0020;
		goto IL_046f;
		IL_0037:
		num2 = num;
		goto IL_003b;
		IL_003b:
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool extension_InsertTimeStamp = default(bool);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 12:
				break;
			default:
				num3 = 14;
				goto IL_0033;
			case 33:
				flag2 = _0020 == null;
				num2 = 16;
				continue;
			case 29:
				base._002Ector();
				num = 33;
				if (true)
				{
					goto IL_0037;
				}
				goto case 19;
			case 19:
				m_hasWrittenHeader = false;
				num3 = 15;
				goto IL_0033;
			case 3:
				MAGIC_HEADER = Encoding.UTF8.GetBytes(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(104));
				m_version = 2;
				num = 19;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_0037;
				}
				goto case 2;
			case 27:
				m_helper = new _008E_008A_0091_008A_0091_008D_008A_008D_008D_0090_008F_0088_0093_008A_008F_0090_0095_008A_008F_0086_0089_0090_0086_0091_0088_0088_0093_0094_008B_0092_008B_0091_008F_0091_008C_008F(_0020, _0020, null);
				num2 = 26;
				continue;
			case 1:
			case 18:
				goto IL_0160;
			case 0:
			case 23:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(16))
				{
					num = 3;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_0037;
					}
					goto case 6;
				}
				return;
			case 26:
				if (Extension_InsertCreateByIdentifier)
				{
					num = 9;
					goto IL_0037;
				}
				goto IL_03f2;
			case 5:
				if (Extension_InsertPlaceholder)
				{
					num3 = 7;
					goto IL_0033;
				}
				goto IL_04da;
			case 17:
				m_hmac = m_helper.GetHMAC();
				num3 = 8;
				goto IL_0033;
			case 31:
				m_extensions.Add(new KeyValuePair<string, byte[]>(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(124), Encoding.UTF8.GetBytes(DateTime.Now.ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(128)))));
				num = 32;
				if (0 == 0)
				{
					goto IL_0037;
				}
				goto case 2;
			case 2:
				if (!_0020.CanWrite)
				{
					num2 = 30;
					continue;
				}
				goto IL_02a2;
			case 15:
				m_hasFlushedFinalBlock = false;
				num2 = 10;
				continue;
			case 6:
				if (_0020 != OperationMode.Decrypt)
				{
					num = 22;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_0037;
					}
					goto case 30;
				}
				goto IL_0334;
			case 30:
				throw new ArgumentException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.StreamMustBeWriteAble, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(108));
			case 24:
				throw new ArgumentException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.StreamMustBeReadAble, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(108));
			case 20:
				throw new ArgumentNullException(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(112));
			case 13:
				return;
			case 22:
				throw new ArgumentException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidOperationMode, _008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(116));
			case 25:
				Version = DefaultFileVersion;
				num2 = 27;
				continue;
			case 16:
				if (flag2)
				{
					num = 28;
					if (true)
					{
						goto IL_0037;
					}
					goto case 32;
				}
				if (_0020 != null)
				{
					if (_0020 != 0)
					{
						num2 = 6;
						continue;
					}
					goto IL_0334;
				}
				num3 = 20;
				goto IL_0033;
			case 32:
				m_extensions.Add(new KeyValuePair<string, byte[]>(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(132), Encoding.UTF8.GetBytes(DateTime.Now.ToUniversalTime().ToString(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(136)))));
				num = 5;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					goto IL_0037;
				}
				goto case 9;
			case 9:
				m_extensions.Add(new KeyValuePair<string, byte[]>(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(120), Encoding.UTF8.GetBytes(Extension_CreatedByIdentifier)));
				goto IL_03f2;
			case 10:
				m_hasReadFooter = false;
				num = 29;
				if (true)
				{
					goto IL_0037;
				}
				goto case 8;
			case 8:
				m_crypto = new CryptoStream(new CryptoStream(new _0093_008C_008E_008E_008B_008A_0094_008C_008E_008B_0088_0090_0094_0093_0091_0086_0092_0090_008E_008D_0093_0086_008E_008B_008E_008E_0094_0090_008C_0088_0087_0093_0090_0095_0088_0092(m_stream, (m_version == 0) ? 32 : 33), m_hmac, CryptoStreamMode.Read), m_helper.CreateCryptoStream(m_mode), CryptoStreamMode.Read);
				num = 34;
				goto IL_0037;
			case 14:
				goto IL_046f;
			case 21:
				if (!flag)
				{
					ReadEncryptionHeader(_0020);
					num = 17;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_0037;
					}
					goto case 22;
				}
				num2 = 25;
				continue;
			case 4:
				if (!_0020.CanRead)
				{
					num2 = 24;
					continue;
				}
				goto IL_02cd;
			case 7:
				m_extensions.Add(new KeyValuePair<string, byte[]>("", new byte[127]));
				goto IL_04da;
			case 28:
				throw new ArgumentNullException(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(108));
			case 11:
				if (extension_InsertTimeStamp)
				{
					num2 = 31;
					continue;
				}
				goto case 5;
			case 34:
				return;
				IL_0334:
				if (_0020 == OperationMode.Encrypt)
				{
					num2 = 2;
					continue;
				}
				goto IL_02a2;
				IL_02a2:
				if (_0020 == OperationMode.Decrypt)
				{
					num = 4;
					if (0 == 0)
					{
						goto IL_0037;
					}
					goto case 24;
				}
				goto IL_02cd;
				IL_0033:
				num = num3;
				goto IL_0037;
				IL_04da:
				m_crypto = null;
				num3 = 13;
				goto IL_0033;
				IL_02cd:
				m_mode = _0020;
				num3 = 12;
				goto IL_0033;
				IL_03f2:
				extension_InsertTimeStamp = Extension_InsertTimeStamp;
				num2 = 11;
				continue;
			}
			break;
		}
		goto IL_0022;
		IL_0160:
		flag = _0020 == OperationMode.Encrypt;
		num2 = 21;
		goto IL_003b;
		IL_046f:
		m_extensions = new List<KeyValuePair<string, byte[]>>();
		goto IL_0160;
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
		//Discarded unreachable code: IL_0005, IL_01c2
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 4;
		bool flag4 = default(bool);
		bool flag3 = default(bool);
		bool hasReadFooter = default(bool);
		byte[] array = default(byte[]);
		byte[] hash = default(byte[]);
		int num3 = default(int);
		int num2 = default(int);
		bool flag6 = default(bool);
		bool flag = default(bool);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		int result = default(int);
		bool flag2 = default(bool);
		while (true)
		{
			string message;
			int num4;
			int num5;
			switch (num)
			{
			case 9:
				throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidFileLength);
			case 19:
				flag4 = m_paddingSize > 16;
				goto case 1;
			case 1:
			case 12:
				if (flag4)
				{
					num = 6;
					break;
				}
				goto IL_03d6;
			case 2:
				message = _0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.DataHMACMismatch;
				goto IL_006b;
			case 28:
				if (flag3)
				{
					num = 31;
					break;
				}
				hasReadFooter = m_hasReadFooter;
				num4 = 8;
				if (1 == 0)
				{
					goto case 21;
				}
				goto IL_01cb;
			case 15:
			case 20:
				if (m_length % 16 == 0)
				{
					num = 7;
					break;
				}
				goto IL_032a;
			case 4:
				if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(24))
				{
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num4 = 15;
						goto IL_01cb;
					}
					num5 = 12;
				}
				else
				{
					flag3 = m_mode != OperationMode.Decrypt;
					num5 = 28;
				}
				goto IL_01c7;
			case 22:
				array = RepeatRead(m_stream, hash.Length);
				num3 = 0;
				num5 = 26;
				goto IL_01c7;
			case 31:
				throw new InvalidOperationException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.CannotReadWhileEncrypting);
			case 21:
				num2 = m_stream.ReadByte();
				num4 = 27;
				goto IL_01cb;
			case 24:
				if (!m_hasReadFooter)
				{
					num4 = 5;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto case 3;
					}
					goto IL_01cb;
				}
				goto case 30;
			case 3:
			case 26:
				flag6 = num3 < hash.Length;
				num5 = 23;
				goto IL_01c7;
			case 11:
				throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.UnexpectedEndOfStream);
			default:
				num4 = 19;
				goto IL_01cb;
			case 14:
				_0020 -= 16 - m_paddingSize;
				goto case 15;
			case 0:
				if (!flag)
				{
					m_paddingSize = (byte)num2;
					goto case 19;
				}
				num = 11;
				break;
			case 13:
				if (!flag7)
				{
					goto case 15;
				}
				num4 = 14;
				goto IL_01cb;
			case 29:
				flag5 = m_version >= 1;
				num5 = 10;
				goto IL_01c7;
			case 8:
				if (!hasReadFooter)
				{
					_0020 = Crypto.Read(_0020, _0020, _0020);
					m_readcount += _0020;
					num5 = 18;
					goto IL_01c7;
				}
				result = 0;
				num4 = 32;
				goto IL_01cb;
			case 7:
				if (m_readcount % 16 == 0)
				{
					Crypto.Close();
					hash = m_hmac.Hash;
					num5 = 22;
					goto IL_01c7;
				}
				goto IL_032a;
			case 23:
				if (flag6)
				{
					flag2 = hash[num3] != array[num3];
					num4 = 25;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto case 11;
					}
				}
				else
				{
					num4 = 30;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto case 17;
					}
				}
				goto IL_01cb;
			case 17:
				m_hasReadFooter = true;
				num = 29;
				break;
			case 18:
				m_length = (m_length + _0020) % 16;
				num = 24;
				break;
			case 30:
				result = _0020;
				num = 33;
				break;
			case 10:
				if (flag5)
				{
					num4 = 21;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_01cb;
					}
					goto case 13;
				}
				goto IL_03d6;
			case 16:
				if (m_version == 0)
				{
					message = _0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.DataHMACMismatch_v0;
					goto IL_006b;
				}
				num4 = 2;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_01cb;
				}
				goto case 8;
			case 6:
				throw new InvalidDataException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.InvalidFileLength);
			case 25:
				if (!flag2)
				{
					num3++;
					num4 = 3;
					goto IL_01cb;
				}
				num = 16;
				break;
			case 5:
				if (m_readcount == m_payloadLength)
				{
					num = 17;
					break;
				}
				goto case 30;
			case 27:
				flag = num2 < 0;
				num = 0;
				break;
			case 32:
			case 33:
				{
					return result;
				}
				IL_006b:
				throw new InvalidDataException(message);
				IL_03d6:
				flag7 = m_paddingSize > 0;
				num5 = 13;
				goto IL_01c7;
				IL_032a:
				num = 9;
				break;
				IL_01c7:
				num4 = num5;
				goto IL_01cb;
				IL_01cb:
				num = num4;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(byte[] _0020, int _0020, int _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0085
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 3;
			goto IL_008e;
		}
		int num2 = 4;
		goto IL_008a;
		IL_008a:
		num = num2;
		goto IL_008e;
		IL_008e:
		int num3 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num3)
			{
			case 0:
			case 3:
				goto IL_0021;
			case 1:
				Crypto.Write(_0020, _0020, _0020);
				num2 = 6;
				break;
			case 5:
				if (flag)
				{
					goto case 2;
				}
				m_length = (m_length + _0020) % 16;
				goto case 1;
			case 2:
			case 4:
				throw new InvalidOperationException(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.CannotWriteWhileDecrypting);
			default:
				num2 = 1;
				break;
			case 6:
				return;
			}
			break;
			IL_0021:
			flag = m_mode != OperationMode.Encrypt;
			num3 = 5;
		}
		goto IL_008a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FlushFinalBlock()
	{
		//Discarded unreachable code: IL_0005, IL_0239
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 23;
		bool flag3 = default(bool);
		byte[] hash = default(byte[]);
		byte b = default(byte);
		int num5 = default(int);
		bool flag2 = default(bool);
		long position = default(long);
		byte[] array = default(byte[]);
		int num3 = default(int);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				switch (num2)
				{
				case 25:
					flag3 = !m_hasFlushedFinalBlock;
					num2 = 18;
					continue;
				case 5:
					if (m_mode == OperationMode.Encrypt)
					{
						num4 = 12;
						goto IL_023e;
					}
					return;
				case 23:
					if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(28))
					{
						num = 25;
						break;
					}
					return;
				case 17:
					Crypto.FlushFinalBlock();
					num = 3;
					break;
				case 3:
					Crypto.Close();
					num4 = 15;
					goto IL_023e;
				case 1:
					return;
				case 15:
					hash = m_hmac.Hash;
					num4 = 27;
					goto IL_023e;
				case 27:
					if (m_version != 0)
					{
						m_stream.WriteByte(b);
						num2 = 29;
					}
					else
					{
						num2 = 24;
					}
					continue;
				case 22:
					m_stream.WriteByte(b);
					num4 = 14;
					goto IL_023e;
				case 18:
					if (flag3)
					{
						num4 = 5;
						goto IL_023e;
					}
					return;
				case 20:
					m_stream.Flush();
					num = 30;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 22;
				case 7:
					b = (byte)num5;
					num2 = 21;
					continue;
				case 9:
				case 13:
					if (flag2)
					{
						num = 0;
						break;
					}
					goto case 17;
				case 16:
					WriteEncryptionHeader();
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 4;
						break;
					}
					num = 13;
					if (0 == 0)
					{
						break;
					}
					goto case 26;
				case 28:
					position = m_stream.Position;
					num4 = 10;
					goto IL_023e;
				case 0:
					array = new byte[16 - b];
					num3 = 0;
					num = 8;
					if (0 == 0)
					{
						break;
					}
					goto case 24;
				case 24:
					m_stream.Write(hash, 0, hash.Length);
					num4 = 28;
					goto IL_023e;
				case 12:
					if (!m_hasWrittenHeader)
					{
						num = 16;
						break;
					}
					goto case 4;
				case 11:
					num3++;
					num4 = 2;
					goto IL_023e;
				case 4:
				case 6:
					num5 = (m_length %= 16);
					num2 = 7;
					continue;
				case 19:
					if (flag)
					{
						array[num3] = (byte)array.Length;
						num2 = 11;
						continue;
					}
					goto case 26;
				default:
					num = 26;
					break;
				case 2:
				case 8:
					flag = num3 < array.Length;
					num = 19;
					if (true)
					{
						break;
					}
					goto case 10;
				case 10:
					m_stream.Seek(MAGIC_HEADER.Length + 1, SeekOrigin.Begin);
					num = 22;
					if (true)
					{
						break;
					}
					goto case 21;
				case 21:
					flag2 = b != 0;
					goto case 9;
				case 26:
					Write(array, 0, array.Length);
					num4 = 17;
					goto IL_023e;
				case 14:
					m_stream.Seek(position, SeekOrigin.Begin);
					m_stream.Flush();
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto case 29;
				case 29:
					m_stream.Write(hash, 0, hash.Length);
					num = 20;
					break;
				case 30:
					return;
					IL_023e:
					num = num4;
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool _0020)
	{
		//Discarded unreachable code: IL_0005, IL_002a
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 2;
			goto IL_002f;
		}
		int num2 = 3;
		goto IL_0033;
		IL_0033:
		bool flag = default(bool);
		while (true)
		{
			IL_0033_2:
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 10:
					m_crypto = null;
					goto case 12;
				case 13:
					goto IL_008e;
				case 6:
					goto IL_00a1;
				case 1:
				case 3:
					base.Dispose(_0020);
					num2 = 5;
					if (true)
					{
						goto IL_0033_2;
					}
					goto case 5;
				case 5:
					flag = _0020;
					num2 = 4;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_0033_2;
					}
					goto case 7;
				case 7:
					m_hmac = null;
					num = 16;
					goto end_IL_0037;
				case 8:
					m_extensions = null;
					num = 14;
					goto end_IL_0037;
				case 12:
					m_stream.Dispose();
					num3 = 13;
					continue;
				case 9:
					if (m_mode == OperationMode.Encrypt)
					{
						num2 = 15;
						goto IL_0033_2;
					}
					goto IL_00a1;
				case 15:
					if (m_hasFlushedFinalBlock)
					{
						goto IL_00a1;
					}
					FlushFinalBlock();
					num2 = 6;
					if (0 == 0)
					{
						goto IL_0033_2;
					}
					goto case 4;
				case 4:
					if (flag)
					{
						num2 = 9;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_0033_2;
						}
						goto case 5;
					}
					return;
				case 0:
				case 2:
					if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(32))
					{
						goto case 1;
					}
					return;
				case 14:
					m_helper.Dispose();
					num = 11;
					goto end_IL_0037;
				case 11:
					m_helper = null;
					num3 = 7;
					continue;
				case 16:
					return;
				}
				num2 = 12;
				goto IL_0033_2;
				IL_00a1:
				m_crypto.Dispose();
				num = 10;
				break;
				IL_008e:
				m_stream = null;
				num = 8;
				break;
				continue;
				end_IL_0037:
				break;
			}
			break;
		}
		goto IL_002f;
		IL_002f:
		num2 = num;
		goto IL_0033;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Main(string[] _0020)
	{
		//Discarded unreachable code: IL_0005, IL_002d, IL_0180
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 1;
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 5;
			if (false)
			{
				goto IL_0022;
			}
		}
		else
		{
			num = 4;
			if (false)
			{
				return;
			}
		}
		goto IL_0036;
		IL_009f:
		bool flag = default(bool);
		do
		{
			if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(36))
			{
				return;
			}
			flag = _0020.Length < 4;
			num = 3;
		}
		while (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092());
		goto IL_0036;
		IL_006a:
		Console.WriteLine(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.CommandlineUsage);
		int num2 = 6;
		goto IL_003a;
		IL_0036:
		num2 = num;
		goto IL_003a;
		IL_003a:
		switch (num2)
		{
		case 3:
			break;
		default:
			goto IL_005b;
		case 2:
			goto IL_006a;
		case 1:
			return;
		case 4:
			return;
		case 0:
		case 5:
			goto IL_009f;
		case 6:
			return;
		}
		goto IL_0022;
		IL_005b:
		num = 2;
		if (true)
		{
			goto IL_0036;
		}
		goto IL_006a;
		IL_0022:
		if (flag)
		{
			goto IL_006a;
		}
		try
		{
			bool flag2 = _0020[0].StartsWith(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(140), StringComparison.InvariantCultureIgnoreCase);
			int num3 = 6;
			bool flag4 = default(bool);
			bool flag3 = default(bool);
			while (true)
			{
				int num4 = num3;
				while (true)
				{
					int num5;
					switch (num4)
					{
					case 0:
						Unittest();
						num3 = 4;
						break;
					case 4:
						return;
					default:
						return;
					case 10:
						return;
					case 8:
						if (!flag4)
						{
							Console.WriteLine(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.CommandlineUnknownMode);
							num3 = 11;
							break;
						}
						num5 = 0;
						goto IL_0185;
					case 6:
						if (flag2)
						{
							_ = 0;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								goto IL_0162;
							}
							num3 = 10;
							if (0 == 0)
							{
								break;
							}
							goto case 3;
						}
						flag3 = _0020[0].StartsWith(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(144), StringComparison.InvariantCultureIgnoreCase);
						num3 = 3;
						if (true)
						{
							break;
						}
						goto case 1;
					case 7:
						Decrypt(_0020[1], _0020[2], _0020[3]);
						return;
					case 3:
						if (!flag3)
						{
							flag4 = _0020[0].StartsWith(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(148));
							num5 = 8;
							goto IL_0185;
						}
						num3 = 7;
						if (1 == 0)
						{
							return;
						}
						break;
					case 2:
						return;
					case 1:
					case 9:
						Encrypt(_0020[1], _0020[2], _0020[3]);
						num3 = 2;
						break;
					case 11:
						return;
						IL_0185:
						num3 = num5;
						break;
					}
					break;
					IL_0162:
					num4 = 9;
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(_0091_0093_008B_008F_0094_0088_008C_0086_008C_008B_008E_008E_008D_0095_008D_0086_0092_0093_008E_008B_008A_008F_0091_0094_0094_0092_0087_008F_008D_0092_0087_008B_0087_0087_0087_0095.CommandlineError, ex.ToString()));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void Unittest()
	{
		//Discarded unreachable code: IL_0005, IL_00da, IL_02bd, IL_0397
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0126: Incompatible stack heights: 0 vs 1
		int num = 9;
		if (1 == 0)
		{
			goto IL_0016;
		}
		goto IL_02c6;
		IL_02c6:
		Random random = default(Random);
		bool flag3 = default(bool);
		int num7 = default(int);
		MemoryStream memoryStream = default(MemoryStream);
		int num3;
		bool flag4 = default(bool);
		byte b = default(byte);
		int num4 = default(int);
		bool flag2 = default(bool);
		MemoryStream memoryStream2 = default(MemoryStream);
		bool flag = default(bool);
		while (true)
		{
			IL_02c6_2:
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					break;
				case 6:
					goto IL_002b;
				case 13:
					try
					{
						byte[] array2 = new byte[random.Next(5120, 104857600)];
						int num6 = 3;
						while (true)
						{
							switch (num6)
							{
							default:
								flag3 |= Unittest(string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(164), num7, 1000, memoryStream.Length), memoryStream);
								num6 = 5;
								continue;
							case 1:
							case 4:
								memoryStream.Write(array2, 0, array2.Length);
								goto default;
							case 3:
								random.NextBytes(array2);
								_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
								num6 = ((!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()) ? 4 : 0);
								continue;
							case 5:
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)memoryStream)?.Dispose();
					}
					num7++;
					num = 11;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_02c6_2;
					}
					goto case 7;
				case 2:
					random = new Random();
					num3 = 18;
					goto IL_02c2;
				case 7:
				case 12:
					flag4 = b <= 2;
					num = 1;
					if (0 == 0)
					{
						goto IL_02c6_2;
					}
					goto case 10;
				case 10:
					num4 = 0;
					num = 22;
					if (0 == 0)
					{
						goto IL_02c6_2;
					}
					goto case 9;
				case 9:
					if (_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.EmWT1u1C4(40))
					{
						num = 21;
						if (true)
						{
							goto IL_02c6_2;
						}
						goto case 20;
					}
					return;
				case 20:
					b = 0;
					num3 = 7;
					goto IL_02c2;
				case 19:
				case 25:
					if (flag2)
					{
						num3 = 24;
						goto IL_02c2;
					}
					return;
				case 21:
					flag3 = true;
					num3 = 2;
					goto IL_02c2;
				case 18:
					Console.WriteLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(152));
					num3 = 20;
					goto IL_02c2;
				case 23:
					flag2 = flag3;
					goto case 19;
				case 24:
					Console.WriteLine();
					num2 = 4;
					continue;
				case 14:
				case 16:
					num7 = 0;
					break;
				case 0:
				case 22:
					if (num4 < 5120)
					{
						memoryStream2 = new MemoryStream();
						num2 = 17;
						continue;
					}
					b = (byte)(b + 1);
					num3 = 12;
					goto IL_02c2;
				case 4:
					Console.WriteLine();
					num = 15;
					goto IL_02c6_2;
				case 5:
					DefaultFileVersion = 2;
					goto IL_002b;
				default:
					num3 = 6;
					goto IL_02c2;
				case 3:
					if (flag)
					{
						memoryStream = new MemoryStream();
						num = 13;
						goto IL_02c6_2;
					}
					num = 23;
					if (true)
					{
						goto IL_02c6_2;
					}
					goto case 17;
				case 17:
					try
					{
						byte[] array = new byte[num4];
						_ = 1;
						int num5;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num5 = 1;
							if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								goto IL_0383;
							}
						}
						else
						{
							num5 = 4;
						}
						goto IL_03a0;
						IL_0410:
						random.NextBytes(array);
						num5 = 3;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_03a0;
						}
						goto IL_03d5;
						IL_03d5:
						flag3 &= Unittest(string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(156), b, memoryStream2.Length), memoryStream2);
						num5 = 5;
						if (0 == 0)
						{
							goto IL_03a0;
						}
						goto IL_0410;
						IL_03a0:
						switch (num5)
						{
						case 3:
							break;
						default:
							goto IL_03d5;
						case 0:
						case 1:
							goto IL_0410;
						case 5:
							goto end_IL_035b;
						}
						goto IL_0383;
						IL_0383:
						memoryStream2.Write(array, 0, array.Length);
						goto IL_03d5;
						end_IL_035b:;
					}
					finally
					{
						((IDisposable)memoryStream2)?.Dispose();
					}
					num4++;
					num = 0;
					if (true)
					{
						goto IL_02c6_2;
					}
					goto case 1;
				case 1:
					if (flag4)
					{
						DefaultFileVersion = b;
						num = 10;
						if (true)
						{
							goto IL_02c6_2;
						}
						goto case 0;
					}
					num = 5;
					if (true)
					{
						goto IL_02c6_2;
					}
					goto case 8;
				case 8:
					Console.WriteLine();
					num = 26;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_02c6_2;
					}
					goto case 15;
				case 15:
					Console.WriteLine(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(168));
					num2 = 8;
					continue;
				case 26:
					return;
				}
				break;
			}
			break;
			IL_002b:
			Console.WriteLine(string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(160), DefaultFileVersion));
			_ = 0;
			num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 25 : 16);
		}
		goto IL_0016;
		IL_02c2:
		num = num3;
		goto IL_02c6;
		IL_0016:
		flag = num7 < 1000;
		num3 = 3;
		goto IL_02c2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool Unittest(string _0020, MemoryStream _0020)
	{
		//Discarded unreachable code: IL_0005, IL_0210, IL_0305
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 4;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_030e;
			}
			goto IL_0350;
		}
		int num2 = 3;
		goto IL_030a;
		IL_030e:
		bool result = default(bool);
		switch (num)
		{
		case 1:
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
				int num3 = 3;
				bool flag2 = default(bool);
				bool flag3 = default(bool);
				int num6 = default(int);
				bool flag = default(bool);
				while (true)
				{
					IL_0215:
					int num4 = num3;
					while (true)
					{
						IL_0219:
						int num5 = num4;
						while (true)
						{
							switch (num5)
							{
							case 4:
								Decrypt(new string(array), memoryStream, memoryStream2);
								num5 = 13;
								continue;
							case 2:
								break;
							case 8:
								throw new Exception(string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(176), memoryStream2.Length, _0020.Length));
							case 10:
							case 11:
								if (!flag2)
								{
									num4 = 14;
									goto IL_0219;
								}
								flag3 = memoryStream2.ReadByte() != _0020.ReadByte();
								num4 = 7;
								if (true)
								{
									goto IL_0219;
								}
								goto case 0;
							case 0:
							case 6:
								flag2 = num6 < memoryStream2.Length;
								goto case 10;
							case 9:
								goto IL_01af;
							case 13:
								goto IL_01df;
							case 7:
								goto end_IL_021d;
							case 1:
							case 5:
								if (!flag)
								{
									num6 = 0;
									num4 = 6;
									if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
									{
										goto IL_0219;
									}
									goto case 12;
								}
								goto case 8;
							default:
								num4 = 8;
								if (0 == 0)
								{
									goto IL_0219;
								}
								goto case 12;
							case 12:
								_0020.Position = 0L;
								num3 = 2;
								goto IL_0215;
							case 3:
								memoryStream.Position = 0L;
								num4 = 4;
								if (0 == 0)
								{
									goto IL_0219;
								}
								goto end_IL_0219;
							case 14:
								goto end_IL_0219;
							}
							flag = memoryStream2.Length != _0020.Length;
							_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								num4 = 1;
								goto IL_0219;
							}
							num4 = 10;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								goto IL_0219;
							}
							goto IL_01af;
							IL_01df:
							memoryStream2.Position = 0L;
							num3 = 12;
							goto IL_0215;
							IL_01af:
							throw new Exception(string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(180), num6));
							continue;
							end_IL_021d:
							break;
						}
						if (!flag3)
						{
							num6++;
							num4 = 0;
							continue;
						}
						num3 = 9;
						goto IL_0215;
						continue;
						end_IL_0219:
						break;
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
			goto IL_0350;
		case 0:
		case 4:
			break;
		default:
			goto IL_0350;
		case 5:
			return result;
		}
		Console.Write(_0020);
		num2 = 1;
		goto IL_030a;
		IL_0350:
		result = true;
		num = 5;
		goto IL_030e;
		IL_030a:
		num = num2;
		goto IL_030e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _008A_008E_0094_008E_0095_0089_008F_0092_0088_0093_008A_008E_008A_0089_0087_0090_0095_0091_0088_0088_0087_0088_0095_0090_0092_008A_0091_0091_008B_0093_0090_008E_008B_0088_008B_0089()
	{
		//Discarded unreachable code: IL_0005, IL_0066
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 1;
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 6;
			if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				goto IL_0026;
			}
		}
		else
		{
			num = 5;
			if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_00b1;
			}
		}
		goto IL_006f;
		IL_00b1:
		Extension_CreatedByIdentifier = string.Format(_008D_0091_008A_0089_0089_0086_0087_0087_008E_0090_0094_008F_008F_0094_008A_0095_008C_0093_008C_0095_008F_0090_008F_0087_0088_0087_0091_0086_008D_0094_008D_0094_0094_0094_008F_0090.pA2PN5iOW(192), Assembly.GetExecutingAssembly().GetName().Version);
		int num2 = 2;
		goto IL_006b;
		IL_0026:
		Extension_InsertPlaceholder = true;
		num2 = 4;
		goto IL_006b;
		IL_006f:
		while (true)
		{
			IL_006f_2:
			int num3 = num;
			while (true)
			{
				switch (num3)
				{
				case 2:
					Extension_InsertCreateByIdentifier = true;
					num = 1;
					if (0 == 0)
					{
						goto IL_006f_2;
					}
					goto case 4;
				case 4:
					DefaultFileVersion = 2;
					num3 = 7;
					continue;
				case 1:
					Extension_InsertTimeStamp = false;
					break;
				case 0:
				case 6:
					goto IL_00b1;
				case 7:
					return;
				}
				break;
			}
			break;
		}
		goto IL_0026;
		IL_006b:
		num = num2;
		goto IL_006f;
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
