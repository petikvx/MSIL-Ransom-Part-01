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

public class SharpAESCrypt : Stream
{
	private class SetupHelper : IDisposable
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
		public SetupHelper(OperationMode mode, string password, byte[] iv)
		{
			//Discarded unreachable code: IL_0005, IL_00ed
			//IL_0006: Incompatible stack heights: 0 vs 1
			_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
			int num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 7 : 12);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 3:
						m_rand = RandomNumberGenerator.Create();
						num3 = 8;
						goto IL_00f2;
					case 15:
						m_aesKey2 = GenerateAESKey2();
						num3 = 16;
						goto IL_00f2;
					case 16:
						return;
					case 14:
						m_crypt.Padding = PaddingMode.None;
						num = 10;
						if (true)
						{
							break;
						}
						goto case 4;
					case 4:
						m_iv2 = GenerateIv2();
						num = 15;
						if (true)
						{
							break;
						}
						goto case 1;
					case 1:
						m_aesKey1 = GenerateAESKey1(EncodePassword(password));
						num = 18;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 8;
					case 8:
						m_hmac = HMAC.Create(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2400));
						num2 = 2;
						continue;
					case 2:
						flag = mode == OperationMode.Encrypt;
						goto default;
					case 0:
					case 12:
						if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(124))
						{
							num2 = 17;
							continue;
						}
						base._002Ector();
						num2 = 6;
						continue;
					case 5:
						m_hash = HashAlgorithm.Create(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2396));
						num3 = 3;
						goto IL_00f2;
					case 6:
						m_crypt = SymmetricAlgorithm.Create(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2392));
						num2 = 14;
						continue;
					default:
						if (!flag)
						{
							m_iv1 = iv;
							num3 = 1;
						}
						else
						{
							num3 = 13;
						}
						goto IL_00f2;
					case 17:
						return;
					case 13:
						m_iv1 = GenerateIv1();
						num = 11;
						if (true)
						{
							break;
						}
						goto case 10;
					case 10:
						m_crypt.Mode = CipherMode.CBC;
						num = 5;
						if (0 == 0)
						{
							break;
						}
						goto case 11;
					case 11:
						m_aesKey1 = GenerateAESKey1(EncodePassword(password));
						num = 4;
						if (1 == 0)
						{
							return;
						}
						break;
					case 18:
						return;
						IL_00f2:
						num = num3;
						break;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] EncodePassword(string password)
		{
			//Discarded unreachable code: IL_0005, IL_0127
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_01a3: Incompatible stack heights: 0 vs 1
			int num = 0;
			byte[] array = default(byte[]);
			byte[] bytes = default(byte[]);
			int num3 = default(int);
			byte b = default(byte);
			bool flag2 = default(bool);
			byte[] result = default(byte[]);
			Encoding encoding = default(Encoding);
			bool flag = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num4;
					object obj;
					switch (num2)
					{
					case 8:
						if (array.Length == 2)
						{
							if (array[0] == byte.MaxValue)
							{
								num2 = 15;
								continue;
							}
							goto IL_001a;
						}
						goto IL_004b;
					case 18:
						bytes[num3 + 1] = b;
						num2 = 2;
						continue;
					case 7:
					case 11:
						flag2 = bytes.Length % 2 != 0;
						goto case 5;
					case 21:
						throw new SystemException(Strings.EncodingNotSupported);
					case 17:
						if (array[1] == byte.MaxValue)
						{
							num4 = 22;
							goto IL_012c;
						}
						goto IL_02d9;
					case 14:
						result = encoding.GetBytes(password);
						num = 3;
						break;
					case 5:
					case 12:
					case 19:
						if (!flag2)
						{
							num3 = 0;
							num = 16;
							break;
						}
						num4 = 21;
						goto IL_012c;
					case 10:
						bytes[num3] = bytes[num3 + 1];
						num = 18;
						break;
					case 1:
						if (encoding != null)
						{
							num = 9;
							break;
						}
						obj = null;
						goto IL_01bf;
					case 22:
						bytes = encoding.GetBytes(password);
						goto default;
					default:
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num4 = 5;
							goto IL_012c;
						}
						num2 = 7;
						continue;
					case 9:
						obj = encoding.GetPreamble();
						goto IL_01bf;
					case 15:
						if (array[1] != 254)
						{
							goto IL_001a;
						}
						num = 14;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 8;
					case 6:
						throw new SystemException(Strings.EncodingNotSupported);
					case 2:
						num3 += 2;
						num4 = 13;
						goto IL_012c;
					case 20:
						result = bytes;
						num4 = 23;
						goto IL_012c;
					case 13:
					case 16:
						flag = num3 < bytes.Length;
						num = 4;
						break;
					case 0:
						if (!S7EI44sMaZQ92MiG6X.EmWT1u1C4(128))
						{
							encoding = Encoding.GetEncoding(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2404));
							num = 1;
						}
						else
						{
							num = 19;
						}
						break;
					case 4:
						if (flag)
						{
							b = bytes[num3];
							num4 = 10;
							goto IL_012c;
						}
						num = 20;
						if (true)
						{
							break;
						}
						goto case 3;
					case 3:
					case 23:
						{
							return result;
						}
						IL_004b:
						num2 = 6;
						continue;
						IL_001a:
						if (array[0] == 254)
						{
							num = 17;
							break;
						}
						goto IL_02d9;
						IL_012c:
						num = num4;
						break;
						IL_02d9:
						throw new SystemException(Strings.EncodingNotSupported);
						IL_01bf:
						array = (byte[])obj;
						if (array == null)
						{
							goto IL_004b;
						}
						num = 8;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 2;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] GenerateIv1()
		{
			//Discarded unreachable code: IL_0005, IL_0111, IL_028b
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_0176: Incompatible stack heights: 0 vs 1
			int num = 10;
			bool flag = default(bool);
			int num4 = default(int);
			byte[] result = default(byte[]);
			byte[] array = default(byte[]);
			byte[] array2 = default(byte[]);
			int num6 = default(int);
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			bool flag2 = default(bool);
			long ticks = default(long);
			DateTime now = default(DateTime);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 5:
					case 14:
						flag = num4 < 8;
						num = 6;
						if (true)
						{
							break;
						}
						goto case 7;
					case 7:
						result = DigestRandomBytes(array, 256);
						num = 16;
						if (true)
						{
							break;
						}
						goto case 0;
					case 0:
						array2 = DEFAULT_MAC;
						num2 = 3;
						continue;
					case 11:
						array2 = null;
						num = 15;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 8;
					case 12:
						Array.Copy(array2, 0, array, 8, Math.Min(array2.Length, array.Length - 8));
						num3 = 7;
						goto IL_0290;
					case 15:
						try
						{
							NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
							int num5 = 0;
							if (0 == 0)
							{
								goto IL_011a;
							}
							goto IL_01a0;
							IL_011a:
							while (true)
							{
								switch (num5)
								{
								case 0:
									num6 = 0;
									num5 = 5;
									if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
									{
										continue;
									}
									break;
								default:
									goto end_IL_011a;
								case 2:
									goto end_IL_011a;
								case 3:
								case 8:
									array2 = allNetworkInterfaces[num6].GetPhysicalAddress().GetAddressBytes();
									goto end_IL_011a;
								case 7:
									if (!flag3)
									{
										num6++;
										num5 = 1;
										continue;
									}
									_ = 0;
									if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
									{
										num5 = 2;
										if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
										{
											continue;
										}
										break;
									}
									num5 = 8;
									if (true)
									{
										continue;
									}
									goto case 6;
								case 6:
									if (flag4)
									{
										flag3 = num6 != NetworkInterface.LoopbackInterfaceIndex;
										num5 = 7;
									}
									else
									{
										num5 = 9;
									}
									continue;
								case 1:
								case 5:
									break;
								case 9:
									goto end_IL_011a;
								}
								goto IL_01a0;
								continue;
								end_IL_011a:
								break;
							}
							goto end_IL_0093;
							IL_01a0:
							flag4 = num6 < allNetworkInterfaces.Length;
							num5 = 6;
							goto IL_011a;
							end_IL_0093:;
						}
						catch
						{
						}
						flag2 = array2 == null;
						num = 8;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 0;
					case 10:
						array = new byte[16];
						_ = 0;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							num3 = 9;
							goto IL_0290;
						}
						num = 13;
						if (0 == 0)
						{
							break;
						}
						goto case 4;
					case 2:
					case 13:
						ticks = now.Ticks;
						num3 = 11;
						goto IL_0290;
					case 6:
						if (flag)
						{
							array[num4] = (byte)((ticks >> num4 * 8) & 0xFF);
							num3 = 4;
							goto IL_0290;
						}
						num = 12;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 1;
					case 1:
					case 9:
						now = DateTime.Now;
						goto case 2;
					case 4:
						num4++;
						num = 14;
						if (0 == 0)
						{
							break;
						}
						goto case 3;
					case 3:
						num4 = 0;
						goto case 5;
					default:
						num3 = 5;
						goto IL_0290;
					case 8:
						if (flag2)
						{
							num2 = 0;
							continue;
						}
						goto case 3;
					case 16:
						{
							return result;
						}
						IL_0290:
						num = num3;
						break;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] GenerateAESKey1(byte[] password)
		{
			//Discarded unreachable code: IL_0005, IL_00a8
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 19;
			bool flag = default(bool);
			byte[] array = default(byte[]);
			int num4 = default(int);
			bool flag2 = default(bool);
			bool flag4 = default(bool);
			bool flag3 = default(bool);
			byte[] result = default(byte[]);
			while (true)
			{
				int num3;
				int num2;
				switch (num)
				{
				case 19:
					if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(132))
					{
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num3 = 16;
							if (false)
							{
								goto case 4;
							}
						}
						else
						{
							num3 = 3;
						}
					}
					else
					{
						flag = !m_hash.CanReuseTransform;
						num3 = 7;
						if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto case 0;
						}
					}
					goto IL_00b1;
				case 4:
					m_hash.TransformBlock(array, 0, array.Length, array, 0);
					num = 13;
					break;
				case 15:
					throw new CryptographicException(Strings.UnsupportedHashAlgorithmBlocks);
				case 8:
					num4 = 0;
					goto case 1;
				default:
					num3 = 5;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_00b1;
					}
					goto case 17;
				case 17:
					Array.Copy(m_iv1, array, m_iv1.Length);
					num2 = 8;
					goto IL_00ad;
				case 10:
					if (!flag2)
					{
						flag4 = 32 < m_hash.HashSize / 8;
						num = 0;
						break;
					}
					num2 = 15;
					goto IL_00ad;
				case 1:
				case 5:
				case 16:
				case 18:
					flag3 = num4 < 8192;
					num2 = 2;
					goto IL_00ad;
				case 13:
					m_hash.TransformFinalBlock(password, 0, password.Length);
					num3 = 12;
					if (0 == 0)
					{
						goto IL_00b1;
					}
					goto case 12;
				case 12:
					array = m_hash.Hash;
					goto case 3;
				case 2:
					if (flag3)
					{
						m_hash.Initialize();
						num2 = 4;
						goto IL_00ad;
					}
					num3 = 11;
					goto IL_00b1;
				case 7:
					if (flag)
					{
						num3 = 9;
						goto IL_00b1;
					}
					flag2 = !m_hash.CanTransformMultipleBlocks;
					num = 10;
					break;
				case 3:
				case 14:
					num4++;
					num = 18;
					break;
				case 9:
					throw new CryptographicException(Strings.UnsupportedHashAlgorithmReuse);
				case 6:
					throw new CryptographicException(string.Format(Strings.UnsupportedHashAlgorithmBlocksize, 32, m_hash.HashSize / 8));
				case 11:
					result = array;
					num2 = 20;
					goto IL_00ad;
				case 0:
					if (!flag4)
					{
						array = new byte[32];
						num3 = 17;
						goto IL_00b1;
					}
					num2 = 6;
					goto IL_00ad;
				case 20:
					{
						return result;
					}
					IL_00b1:
					num = num3;
					break;
					IL_00ad:
					num3 = num2;
					goto IL_00b1;
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
			//Discarded unreachable code: IL_0005, IL_0074
			//IL_0006: Incompatible stack heights: 0 vs 1
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, m_crypt.CreateEncryptor(m_aesKey1, m_iv1), CryptoStreamMode.Write);
			cryptoStream.Write(m_iv2, 0, m_iv2.Length);
			_ = 1;
			int num = (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091() ? 2 : 3);
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 3:
					cryptoStream.Write(m_aesKey2, 0, m_aesKey2.Length);
					break;
				case 4:
					return memoryStream.ToArray();
				}
				cryptoStream.FlushFinalBlock();
				num2 = 4;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] CalculateKeyHmac()
		{
			//Discarded unreachable code: IL_0005, IL_004e
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_009e: Incompatible stack heights: 0 vs 1
			int num = 3;
			byte[] result = default(byte[]);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						result = m_hmac.ComputeHash(EncryptAESKey2());
						num = 5;
						if (0 == 0)
						{
							break;
						}
						goto case 1;
					case 1:
					case 4:
						m_hmac.Key = m_aesKey1;
						goto default;
					case 3:
						m_hmac.Initialize();
						_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
						if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_007d;
						}
						num = 4;
						break;
					case 5:
						return result;
					}
					break;
					IL_007d:
					num2 = 0;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private byte[] DigestRandomBytes(byte[] bytes, int repetitions)
		{
			//Discarded unreachable code: IL_0005, IL_01b4
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 12;
			if (false)
			{
				goto IL_0016;
			}
			goto IL_01bd;
			IL_01bd:
			bool flag2 = default(bool);
			bool flag4 = default(bool);
			int num3 = default(int);
			bool flag3 = default(bool);
			bool flag = default(bool);
			byte[] result = default(byte[]);
			while (true)
			{
				IL_01bd_2:
				int num2 = num;
				while (true)
				{
					int num4;
					switch (num2)
					{
					case 10:
						break;
					case 3:
						goto IL_0039;
					case 12:
						if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(136))
						{
							num2 = 9;
							continue;
						}
						flag2 = bytes.Length > m_hash.HashSize / 8;
						num4 = 16;
						goto IL_01b9;
					case 5:
					case 9:
					case 11:
					case 13:
						flag4 = num3 < repetitions;
						num = 7;
						if (true)
						{
							goto IL_01bd_2;
						}
						goto case 4;
					case 4:
					case 17:
						if (flag3)
						{
							num4 = 2;
							goto IL_01b9;
						}
						flag = !m_hash.CanTransformMultipleBlocks;
						num2 = 14;
						continue;
					case 8:
						m_hash.TransformBlock(bytes, 0, bytes.Length, bytes, 0);
						num = 19;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_01bd_2;
						}
						goto case 16;
					case 16:
						if (flag2)
						{
							num4 = 15;
							goto IL_01b9;
						}
						flag3 = !m_hash.CanReuseTransform;
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							num = 17;
							if (true)
							{
								goto IL_01bd_2;
							}
							goto case 6;
						}
						num2 = 5;
						continue;
					case 15:
						throw new CryptographicException(string.Format(Strings.UnsupportedHashAlgorithmBlocksize, bytes.Length, m_hash.HashSize / 8));
					case 6:
						result = bytes;
						num = 20;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_01bd_2;
						}
						goto case 2;
					case 2:
						throw new CryptographicException(Strings.UnsupportedHashAlgorithmReuse);
					case 1:
						m_hash.TransformFinalBlock(bytes, 0, 0);
						num = 0;
						if (0 == 0)
						{
							goto IL_01bd_2;
						}
						goto case 14;
					case 14:
						if (!flag)
						{
							m_hash.Initialize();
							num4 = 10;
							goto IL_01b9;
						}
						num = 3;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_01bd_2;
						}
						goto case 19;
					case 19:
						num3++;
						goto case 5;
					case 18:
						num3 = 0;
						goto case 5;
					default:
						num = 11;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_01bd_2;
						}
						goto case 0;
					case 0:
						Array.Copy(m_hash.Hash, bytes, bytes.Length);
						num = 6;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_01bd_2;
						}
						goto case 15;
					case 7:
						goto IL_029d;
					case 20:
						{
							return result;
						}
						IL_01b9:
						num = num4;
						goto IL_01bd_2;
					}
					break;
					IL_029d:
					if (flag4)
					{
						m_rand.GetBytes(bytes);
						num2 = 8;
						continue;
					}
					num = 1;
					goto IL_01bd_2;
				}
				break;
			}
			goto IL_0016;
			IL_0039:
			throw new CryptographicException(Strings.UnsupportedHashAlgorithmBlocks);
			IL_0016:
			m_hash.TransformBlock(bytes, 0, bytes.Length, bytes, 0);
			num = 18;
			if (1 == 0)
			{
				goto IL_0039;
			}
			goto IL_01bd;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public ICryptoTransform CreateCryptoStream(OperationMode mode)
		{
			//Discarded unreachable code: IL_0005, IL_003c
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_0086: Incompatible stack heights: 0 vs 1
			int num = 5;
			ICryptoTransform result = default(ICryptoTransform);
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				bool flag = default(bool);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 4:
							break;
						case 5:
							goto IL_007a;
						case 0:
						case 1:
							goto IL_0096;
						default:
							goto IL_00e0;
						}
						break;
						IL_007a:
						flag = mode == OperationMode.Encrypt;
						_ = 0;
						num2 = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 2 : 0);
					}
					break;
					IL_0096:
					if (flag)
					{
						num = 4;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							continue;
						}
					}
					else
					{
						result = m_crypt.CreateDecryptor(m_aesKey2, m_iv2);
						num = 6;
						if (0 == 0)
						{
							continue;
						}
					}
					goto IL_00e0;
				}
			}
			result = m_crypt.CreateEncryptor(m_aesKey2, m_iv2);
			goto IL_00e0;
			IL_00e0:
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public HMAC GetHMAC()
		{
			//Discarded unreachable code: IL_0005, IL_0027
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_0089: Incompatible stack heights: 0 vs 1
			int num = 4;
			if (1 == 0)
			{
				goto IL_0016;
			}
			goto IL_0030;
			IL_0030:
			HMAC result = default(HMAC);
			HMAC hMAC = default(HMAC);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 0:
					case 1:
						break;
					default:
						goto IL_0061;
					case 4:
						goto IL_0072;
					case 5:
						return result;
					}
					break;
					IL_0072:
					hMAC = HMAC.Create(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2400));
					_ = 0;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num2 = 0;
						continue;
					}
					goto IL_0056;
				}
				break;
				IL_0056:
				num = 3;
			}
			goto IL_0016;
			IL_0016:
			hMAC.Key = m_aesKey2;
			goto IL_0061;
			IL_0061:
			result = hMAC;
			num = 5;
			goto IL_0030;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public byte[] DecryptAESKey2(byte[] data)
		{
			//Discarded unreachable code: IL_0005, IL_0068, IL_0141
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 0;
			MemoryStream memoryStream = default(MemoryStream);
			byte[] hash = default(byte[]);
			while (true)
			{
				int num2;
				switch (num)
				{
				case 4:
					try
					{
						using CryptoStream stream = new CryptoStream(memoryStream, m_crypt.CreateDecryptor(m_aesKey1, m_iv1), CryptoStreamMode.Read);
						m_iv2 = RepeatRead(stream, 16);
						_ = 1;
						int num3;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num3 = 2;
							goto IL_0075;
						}
						int num4 = 3;
						if (true)
						{
							num3 = num4;
							goto IL_0075;
						}
						goto end_IL_0030;
						IL_0075:
						switch (num3)
						{
						case 0:
						case 2:
							m_aesKey2 = RepeatRead(stream, 32);
							break;
						case 3:
							break;
						}
						end_IL_0030:;
					}
					finally
					{
						((IDisposable)memoryStream)?.Dispose();
					}
					m_hmac.Initialize();
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 1;
						break;
					}
					num2 = 6;
					if (true)
					{
						goto IL_014a;
					}
					goto case 0;
				default:
					m_hmac.TransformFinalBlock(data, 0, data.Length);
					num2 = 5;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto case 5;
					}
					goto IL_014a;
				case 5:
					hash = m_hmac.Hash;
					num2 = 7;
					goto IL_014a;
				case 1:
				case 2:
					m_hmac.Key = m_aesKey1;
					goto default;
				case 0:
					memoryStream = new MemoryStream(data);
					num = 4;
					break;
				case 7:
					{
						return hash;
					}
					IL_014a:
					num = num2;
					break;
				}
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
			//Discarded unreachable code: IL_0005, IL_003f
			//IL_0006: Incompatible stack heights: 0 vs 1
			int num = 4;
			bool flag2 = default(bool);
			bool flag5 = default(bool);
			bool flag3 = default(bool);
			bool flag = default(bool);
			bool flag4 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 10:
						m_hmac = null;
						num3 = 18;
						goto IL_0044;
					case 22:
						Array.Clear(m_aesKey2, 0, m_aesKey2.Length);
						goto case 2;
					default:
						num3 = 2;
						goto IL_0044;
					case 24:
						if (flag2)
						{
							num = 19;
							break;
						}
						goto case 12;
					case 7:
						if (flag5)
						{
							_ = 1;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								num3 = 14;
								goto IL_0044;
							}
							num2 = 13;
							continue;
						}
						return;
					case 12:
						flag3 = m_aesKey2 != null;
						num2 = 16;
						continue;
					case 3:
					case 14:
						flag = m_aesKey1 != null;
						num2 = 23;
						continue;
					case 11:
						m_iv1 = null;
						num = 0;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 2;
					case 2:
						flag4 = m_iv2 != null;
						num3 = 1;
						goto IL_0044;
					case 15:
						flag5 = m_crypt != null;
						num2 = 7;
						continue;
					case 17:
						m_aesKey1 = null;
						num2 = 11;
						continue;
					case 9:
						m_crypt = null;
						num = 25;
						if (0 == 0)
						{
							break;
						}
						goto case 0;
					case 0:
						m_aesKey2 = null;
						num = 5;
						if (true)
						{
							break;
						}
						goto case 20;
					case 20:
						m_hash = null;
						num = 10;
						if (true)
						{
							break;
						}
						goto case 18;
					case 18:
						m_rand = null;
						num2 = 9;
						continue;
					case 21:
						Array.Clear(m_aesKey1, 0, m_aesKey1.Length);
						goto case 6;
					case 1:
						if (flag4)
						{
							num = 8;
							break;
						}
						goto case 17;
					case 16:
						if (!flag3)
						{
							goto case 2;
						}
						num = 22;
						if (0 == 0)
						{
							break;
						}
						goto case 4;
					case 4:
						if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(140))
						{
							num2 = 15;
							continue;
						}
						return;
					case 8:
						Array.Clear(m_iv2, 0, m_iv2.Length);
						num = 17;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 12;
					case 6:
					case 13:
						flag2 = m_iv1 != null;
						num3 = 24;
						goto IL_0044;
					case 23:
						if (flag)
						{
							num2 = 21;
							continue;
						}
						goto case 6;
					case 5:
						m_iv2 = null;
						num3 = 20;
						goto IL_0044;
					case 19:
						Array.Clear(m_iv1, 0, m_iv1.Length);
						num2 = 12;
						continue;
					case 25:
						return;
						IL_0044:
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

	private class StreamHider : Stream
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
		public StreamHider(Stream stream, int count)
		{
			//Discarded unreachable code: IL_0005, IL_0045
			//IL_0006: Incompatible stack heights: 0 vs 1
			_ = 0;
			int num;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				num = 4;
			}
			else
			{
				num = 2;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_001d;
				}
			}
			goto IL_004e;
			IL_004e:
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					break;
				case 1:
				case 2:
					goto IL_0037;
				default:
					num2 = 3;
					continue;
				case 0:
				case 4:
					base._002Ector();
					goto IL_0037;
				case 5:
					return;
				}
				break;
			}
			goto IL_001d;
			IL_0037:
			m_stream = stream;
			goto IL_001d;
			IL_001d:
			m_hiddenByteCount = count;
			num = 5;
			if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_0037;
			}
			goto IL_004e;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Flush()
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			m_stream.Flush();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			return m_stream.Seek(offset, origin);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void SetLength(long value)
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			m_stream.SetLength(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			//Discarded unreachable code: IL_0005
			//IL_0006: Incompatible stack heights: 0 vs 1
			m_stream.Write(buffer, offset, count);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			//Discarded unreachable code: IL_0005, IL_0028
			//IL_0006: Incompatible stack heights: 0 vs 1
			_ = 0;
			int num;
			if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
			{
				num = 5;
				goto IL_0035;
			}
			int num2 = 4;
			if (true)
			{
				goto IL_0031;
			}
			goto IL_006f;
			IL_0035:
			bool flag = default(bool);
			int result = default(int);
			long num3 = default(long);
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!flag)
					{
						result = m_stream.Read(buffer, offset, (int)num3);
						num2 = 7;
						if (0 == 0)
						{
							goto IL_0031;
						}
					}
					goto default;
				case 6:
					break;
				default:
					result = 0;
					num2 = 2;
					goto IL_0031;
				case 0:
				case 5:
					num3 = Math.Max(0L, Math.Min(count, m_stream.Length - (m_stream.Position + m_hiddenByteCount)));
					num = 6;
					continue;
				case 2:
				case 7:
					return result;
				}
				break;
			}
			goto IL_006f;
			IL_006f:
			flag = num3 == 0;
			num2 = 1;
			goto IL_0031;
			IL_0031:
			num = num2;
			goto IL_0035;
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

	private SetupHelper m_helper;

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
			//Discarded unreachable code: IL_0005, IL_002a
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_007e: Incompatible stack heights: 0 vs 1
			int num = 4;
			if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_001f;
			}
			goto IL_0033;
			IL_001f:
			WriteEncryptionHeader();
			goto IL_008f;
			IL_008f:
			CryptoStream crypto = m_crypto;
			int num2 = 6;
			goto IL_0037;
			IL_0037:
			bool flag = default(bool);
			while (true)
			{
				switch (num2)
				{
				case 0:
					break;
				case 4:
					goto IL_006d;
				default:
					goto IL_008f;
				case 1:
				case 2:
					if (!flag)
					{
						goto IL_008f;
					}
					num = 0;
					if (true)
					{
						goto IL_0033;
					}
					goto case 6;
				case 6:
					return crypto;
				}
				break;
				IL_006d:
				while (true)
				{
					flag = m_crypto == null;
					_ = 1;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					num = 5;
					if (false)
					{
						continue;
					}
					goto IL_0033;
				}
				num2 = 2;
			}
			goto IL_001f;
			IL_0033:
			num2 = num;
			goto IL_0037;
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
			//Discarded unreachable code: IL_0005, IL_0103
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_014f: Incompatible stack heights: 0 vs 1
			int num = 10;
			bool flag = default(bool);
			bool flag2 = default(bool);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					IL_010c:
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 0:
						case 6:
							if (!flag)
							{
								goto end_IL_0110;
							}
							goto case 7;
						case 7:
						case 8:
							throw new ArgumentOutOfRangeException(string.Format(Strings.VersionUnsupported, (byte)2));
						case 3:
							return;
						case 5:
							throw new InvalidOperationException(Strings.StreamMustSupportSeeking);
						case 11:
							break;
						case 4:
							goto IL_00b9;
						case 9:
							goto IL_00d9;
						case 1:
							goto IL_00ee;
						default:
							goto IL_0149;
						case 10:
							goto IL_0164;
						case 2:
							goto IL_0186;
						case 12:
							return;
						}
						if (m_stream.CanSeek)
						{
							goto IL_007a;
						}
						num2 = 5;
						if (0 == 0)
						{
							goto IL_010c;
						}
						goto IL_00b9;
						IL_00d9:
						if (!flag2)
						{
							if (m_mode == OperationMode.Encrypt)
							{
								goto IL_00cf;
							}
							goto IL_00f9;
						}
						num2 = 4;
						if (0 == 0)
						{
							goto IL_010c;
						}
						goto IL_00ee;
						IL_0186:
						if (m_crypto != null)
						{
							num3 = 1;
							continue;
						}
						goto IL_00f9;
						IL_00ee:
						throw new InvalidOperationException(Strings.VersionReadonly);
						IL_00b9:
						throw new InvalidOperationException(Strings.VersionReadonlyForDecryption);
						IL_00f9:
						flag = value > 2;
						goto IL_0149;
						IL_0149:
						_ = 0;
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_001c;
						}
						num2 = 0;
						if (true)
						{
							goto IL_010c;
						}
						goto IL_0164;
						IL_0164:
						if (!S7EI44sMaZQ92MiG6X.EmWT1u1C4(20))
						{
							flag2 = m_mode == OperationMode.Decrypt;
							num2 = 9;
							goto IL_010c;
						}
						num2 = 3;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_010c;
						}
						goto IL_0186;
						continue;
						end_IL_0110:
						break;
					}
					if (value == 0)
					{
						num2 = 11;
						continue;
					}
					goto IL_007a;
					IL_007a:
					m_version = value;
					num2 = 12;
					continue;
					IL_00cf:
					num = 2;
					break;
					IL_001c:
					num = 8;
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
	private void ReadEncryptionHeader(string password)
	{
		//Discarded unreachable code: IL_0005, IL_029d
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0662: Incompatible stack heights: 0 vs 1
		int num = 6;
		bool flag13 = default(bool);
		string @string = default(string);
		byte[] array5 = default(byte[]);
		bool flag7 = default(bool);
		bool flag5 = default(bool);
		int num5 = default(int);
		int num4 = default(int);
		byte[] iv = default(byte[]);
		byte[] array4 = default(byte[]);
		int num6 = default(int);
		bool flag9 = default(bool);
		byte[] array3 = default(byte[]);
		byte[] array6 = default(byte[]);
		bool flag6 = default(bool);
		byte[] array = default(byte[]);
		bool flag15 = default(bool);
		bool flag = default(bool);
		bool flag14 = default(bool);
		bool flag4 = default(bool);
		bool flag8 = default(bool);
		bool flag12 = default(bool);
		bool flag11 = default(bool);
		int num7 = default(int);
		bool flag10 = default(bool);
		bool flag2 = default(bool);
		byte[] array2 = default(byte[]);
		bool flag3 = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_02a6:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 25:
						if (flag13)
						{
							num2 = 21;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								goto IL_02a6;
							}
							goto case 0;
						}
						goto case 15;
					case 0:
					case 34:
						m_extensions.Add(new KeyValuePair<string, byte[]>(@string, array5));
						num2 = 9;
						if (0 == 0)
						{
							goto IL_02a6;
						}
						goto case 26;
					case 26:
						if (flag7)
						{
							num = 45;
							goto end_IL_02a6;
						}
						goto case 9;
					case 16:
						if (flag5)
						{
							num2 = 44;
							if (true)
							{
								goto IL_02a6;
							}
							goto case 31;
						}
						num5++;
						num2 = 54;
						if (0 == 0)
						{
							goto IL_02a6;
						}
						goto case 22;
					case 31:
						flag7 = num4 != 0;
						num2 = 26;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_02a6;
						}
						goto case 46;
					case 46:
						m_helper = new SetupHelper(m_mode, password, iv);
						num3 = 5;
						continue;
					case 20:
						Array.Copy(array4, num6 + 1, array5, 0, array5.Length);
						goto case 0;
					case 9:
						flag9 = num4 > 0;
						num = 28;
						goto end_IL_02a6;
					case 53:
						array3 = RepeatRead(m_stream, 2);
						num3 = 51;
						continue;
					case 8:
						break;
					case 38:
						m_paddingSize = array6[MAGIC_HEADER.Length + 1];
						num = 29;
						goto end_IL_02a6;
					case 18:
						throw new InvalidDataException(string.Format(Strings.UnsupportedFileVersion, m_version));
					case 42:
					case 54:
						flag6 = num5 < array.Length;
						num2 = 43;
						goto IL_02a6;
					case 17:
						throw new InvalidDataException(Strings.InvalidExtensionData);
					case 41:
						flag15 = num6 < 0;
						num3 = 2;
						continue;
					case 29:
						flag = m_paddingSize >= 16;
						num2 = 48;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_02a6;
						}
						goto case 19;
					case 19:
						if (flag14)
						{
							num3 = 50;
							continue;
						}
						goto IL_051c;
					case 15:
						iv = RepeatRead(m_stream, 16);
						num2 = 46;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_02a6;
						}
						goto case 31;
					case 21:
						num4 = 0;
						num2 = 53;
						goto IL_02a6;
					case 5:
						flag4 = m_version >= 1;
						num2 = 33;
						goto IL_02a6;
					case 2:
						goto end_IL_02aa;
					case 39:
						if (!flag8)
						{
							flag12 = m_version == 0;
							num2 = 8;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								goto IL_02a6;
							}
							goto case 13;
						}
						num2 = 18;
						goto IL_02a6;
					case 12:
					case 32:
						flag11 = num7 < MAGIC_HEADER.Length;
						num = 7;
						goto end_IL_02a6;
					case 45:
						array4 = RepeatRead(m_stream, num4);
						goto case 4;
					default:
						num3 = 4;
						continue;
					case 7:
						if (!flag11)
						{
							num2 = 40;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								goto IL_02a6;
							}
							goto case 44;
						}
						flag10 = MAGIC_HEADER[num7] != array6[num7];
						num = 22;
						goto end_IL_02a6;
					case 44:
						throw new CryptographicException(Strings.InvalidPassword);
					case 22:
						if (flag10)
						{
							num3 = 23;
							continue;
						}
						num7++;
						num = 12;
						goto end_IL_02a6;
					case 14:
						m_payloadLength = m_stream.Length - m_stream.Position - 32;
						num2 = 13;
						goto IL_02a6;
					case 13:
					case 35:
						flag2 = m_payloadLength % 16 != 0;
						num3 = 30;
						continue;
					case 10:
						throw new InvalidDataException(Strings.InvalidHeaderMarker);
					case 40:
						m_version = array6[MAGIC_HEADER.Length];
						num3 = 55;
						continue;
					case 28:
						if (!flag9)
						{
							num3 = 15;
							continue;
						}
						goto case 53;
					case 55:
						flag8 = m_version > 2;
						num3 = 39;
						continue;
					case 4:
						num6 = Array.IndexOf(array4, (byte)0);
						num2 = 41;
						goto IL_02a6;
					case 1:
					case 27:
						array6 = new byte[MAGIC_HEADER.Length + 2];
						num = 49;
						goto end_IL_02a6;
					case 43:
						if (flag6)
						{
							flag5 = array[num5] != array2[num5];
							num2 = 16;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								goto IL_02a6;
							}
							goto case 17;
						}
						num = 37;
						goto end_IL_02a6;
					case 50:
						throw new InvalidDataException(Strings.InvalidReservedFieldValue);
					case 33:
						if (flag4)
						{
							num2 = 52;
							if (0 == 0)
							{
								goto IL_02a6;
							}
							goto case 23;
						}
						m_helper.SetBulkKeyToKey1();
						num2 = 14;
						goto IL_02a6;
					case 23:
						throw new InvalidDataException(Strings.InvalidHeaderMarker);
					case 37:
						m_payloadLength = m_stream.Length - m_stream.Position - 33;
						num3 = 35;
						continue;
					case 3:
						throw new InvalidDataException(Strings.InvalidHeaderMarker);
					case 49:
						flag3 = m_stream.Read(array6, 0, array6.Length) != array6.Length;
						num2 = 24;
						goto IL_02a6;
					case 30:
						if (flag2)
						{
							num2 = 56;
							goto IL_02a6;
						}
						return;
					case 52:
						array = m_helper.DecryptAESKey2(RepeatRead(m_stream, 48));
						num2 = 11;
						goto IL_02a6;
					case 24:
						goto IL_060a;
					case 48:
						if (!flag)
						{
							goto IL_051c;
						}
						num2 = 10;
						goto IL_02a6;
					case 36:
						array5 = new byte[array4.Length - num6 - 1];
						num = 20;
						goto end_IL_02a6;
					case 6:
						goto IL_0649;
					case 47:
						num5 = 0;
						num2 = 42;
						goto IL_02a6;
					case 51:
						num4 = (array3[0] << 8) | array3[1];
						num2 = 31;
						goto IL_02a6;
					case 11:
						array2 = RepeatRead(m_stream, array.Length);
						num3 = 47;
						continue;
					case 56:
						{
							throw new CryptographicException(Strings.InvalidFileLength);
						}
						IL_051c:
						flag13 = m_version >= 2;
						num = 25;
						goto end_IL_02a6;
					}
					if (flag12)
					{
						num2 = 38;
						goto IL_02a6;
					}
					flag14 = array6[MAGIC_HEADER.Length + 1] != 0;
					num3 = 19;
					continue;
					end_IL_02aa:
					break;
				}
				if (!flag15)
				{
					@string = Encoding.UTF8.GetString(array4, 0, num6);
					num2 = 36;
				}
				else
				{
					num2 = 17;
				}
				continue;
				IL_060a:
				if (!flag3)
				{
					num7 = 0;
					num = 32;
				}
				else
				{
					num = 3;
				}
				break;
				IL_0649:
				if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(4))
				{
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 0;
						break;
					}
					num2 = 27;
					continue;
				}
				return;
				continue;
				end_IL_02a6:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteEncryptionHeader()
	{
		//Discarded unreachable code: IL_0005, IL_01ce, IL_02c0
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_023a: Incompatible stack heights: 0 vs 1
		int num = 18;
		bool flag2 = default(bool);
		byte[] array = default(byte[]);
		bool flag = default(bool);
		List<KeyValuePair<string, byte[]>>.Enumerator enumerator = default(List<KeyValuePair<string, byte[]>>.Enumerator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_02c9:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 2:
						if (flag2)
						{
							num2 = 6;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								goto IL_02c9;
							}
							goto case 7;
						}
						goto case 8;
					case 7:
						m_stream.Write(MAGIC_HEADER, 0, MAGIC_HEADER.Length);
						num2 = 0;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_02c9;
						}
						goto case 15;
					case 15:
						m_crypto = new CryptoStream(new CryptoStream(new StreamHider(m_stream, 0), m_hmac, CryptoStreamMode.Write), m_helper.CreateCryptoStream(m_mode), CryptoStreamMode.Write);
						num3 = 17;
						continue;
					case 13:
						m_stream.WriteByte(0);
						num2 = 1;
						goto IL_02c9;
					case 3:
					case 19:
						m_hmac = m_helper.GetHMAC();
						num2 = 15;
						goto IL_02c9;
					case 17:
						break;
					case 18:
						if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(8))
						{
							num3 = 7;
							continue;
						}
						return;
					case 12:
						goto IL_011b;
					case 8:
					case 16:
						m_stream.Write(m_helper.IV1, 0, m_helper.IV1.Length);
						goto case 5;
					case 1:
						goto IL_0172;
					case 4:
						goto IL_018a;
					case 14:
						array = m_helper.CalculateKeyHmac();
						num2 = 12;
						if (true)
						{
							goto IL_02c9;
						}
						goto case 20;
					case 20:
						if (!flag)
						{
							array = m_helper.EncryptAESKey2();
							num3 = 11;
							continue;
						}
						goto IL_026d;
					case 6:
						enumerator = m_extensions.GetEnumerator();
						num3 = 4;
						continue;
					case 0:
						m_stream.WriteByte(m_version);
						num2 = 13;
						if (0 == 0)
						{
							goto IL_02c9;
						}
						goto case 5;
					case 5:
					case 9:
						flag = m_version == 0;
						goto case 20;
					default:
						num2 = 20;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_02c9;
						}
						goto case 10;
					case 10:
						m_helper.SetBulkKeyToKey1();
						num3 = 19;
						continue;
					case 11:
						goto IL_0352;
					case 21:
						return;
					}
					break;
					IL_0352:
					m_stream.Write(array, 0, array.Length);
					num = 14;
					goto end_IL_02c9;
					IL_018a:
					try
					{
						while (enumerator.MoveNext())
						{
							KeyValuePair<string, byte[]> current = enumerator.Current;
							_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
							int num5;
							if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
							{
								int num4 = 2;
								num5 = num4;
							}
							else
							{
								num5 = 3;
							}
							switch (num5)
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
					_ = 0;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num2 = 5;
						if (true)
						{
							goto IL_02c9;
						}
						goto IL_0172;
					}
					num3 = 16;
					continue;
					IL_0172:
					flag2 = m_version >= 2;
					num = 2;
					goto end_IL_02c9;
				}
				m_hasWrittenHeader = true;
				num = 21;
				break;
				IL_026d:
				num = 10;
				break;
				IL_011b:
				m_stream.Write(array, 0, array.Length);
				num = 3;
				break;
				continue;
				end_IL_02c9:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void WriteExtension(string identifier, byte[] value)
	{
		//Discarded unreachable code: IL_0005, IL_009e
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 0;
		bool flag = default(bool);
		uint num4 = default(uint);
		byte[] bytes = default(byte[]);
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
						if (flag)
						{
							num = 1;
							goto end_IL_00a7;
						}
						goto case 10;
					case 9:
						break;
					case 11:
						m_stream.WriteByte(0);
						num3 = 9;
						continue;
					case 3:
						m_stream.WriteByte((byte)((num4 >> 8) & 0xFFu));
						num = 4;
						goto end_IL_00a7;
					case 0:
						if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(12))
						{
							num3 = 12;
							continue;
						}
						return;
					case 10:
						num4 = (uint)(bytes.Length + 1 + value.Length);
						goto case 3;
					default:
						goto IL_00e8;
					case 2:
					case 6:
						flag = value == null;
						num = 5;
						goto end_IL_00a7;
					case 12:
						goto IL_0105;
					case 4:
						m_stream.WriteByte((byte)(num4 & 0xFFu));
						goto case 7;
					case 1:
						value = new byte[0];
						num3 = 10;
						continue;
					case 7:
					case 8:
						m_stream.Write(bytes, 0, bytes.Length);
						num2 = 11;
						if (1 == 0)
						{
							return;
						}
						goto end_IL_00ab;
					case 13:
						return;
					}
					m_stream.Write(value, 0, value.Length);
					num2 = 13;
					break;
					IL_0105:
					bytes = Encoding.UTF8.GetBytes(identifier);
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num3 = 6;
						continue;
					}
					num = 7;
					goto end_IL_00a7;
					IL_00e8:
					num2 = 3;
					break;
					continue;
					end_IL_00ab:
					break;
				}
				continue;
				end_IL_00a7:
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static byte[] RepeatRead(Stream stream, int count)
	{
		//Discarded unreachable code: IL_0005, IL_00c3
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 2;
		bool flag = default(bool);
		int num3 = default(int);
		byte[] array = default(byte[]);
		byte[] result = default(byte[]);
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				throw new InvalidDataException(Strings.UnexpectedEndOfStream);
			case 3:
				flag = count > 0;
				num2 = 8;
				goto IL_00cc;
			case 6:
				count -= num3;
				num = 7;
				break;
			case 8:
				if (!flag)
				{
					num = 9;
					break;
				}
				num3 = stream.Read(array, array.Length - count, count);
				num = 6;
				break;
			case 7:
				if (num3 != 0)
				{
					goto case 3;
				}
				_ = 0;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num = 1;
					break;
				}
				num2 = 0;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 1;
				}
				goto IL_00cc;
			case 9:
				result = array;
				num2 = 10;
				if (false)
				{
					goto case 2;
				}
				goto IL_00cc;
			case 2:
				array = new byte[count];
				num2 = 3;
				goto IL_00cc;
			case 1:
			case 4:
				if (count != 0)
				{
					goto default;
				}
				goto case 3;
			case 10:
				{
					return result;
				}
				IL_00cc:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Encrypt(string password, Stream input, Stream output)
	{
		//Discarded unreachable code: IL_0005, IL_00b1
		//IL_0006: Incompatible stack heights: 0 vs 1
		_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 7;
			if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_009b;
			}
		}
		else
		{
			num = 2;
		}
		goto IL_00ba;
		IL_0085:
		bool flag = default(bool);
		SharpAESCrypt sharpAESCrypt = default(SharpAESCrypt);
		byte[] array = default(byte[]);
		int count = default(int);
		int num2;
		if (flag)
		{
			sharpAESCrypt.Write(array, 0, count);
			num2 = 6;
			goto IL_00b6;
		}
		num = 3;
		if (1 == 0)
		{
			goto IL_009b;
		}
		goto IL_00ba;
		IL_009b:
		flag = (count = input.Read(array, 0, array.Length)) != 0;
		goto IL_0085;
		IL_00ba:
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 0:
			case 7:
				array = new byte[4096];
				goto case 1;
			case 1:
			case 2:
				sharpAESCrypt = new SharpAESCrypt(password, output, OperationMode.Encrypt);
				num2 = 5;
				goto IL_00b6;
			case 4:
				goto end_IL_00ba;
			case 5:
			case 6:
				goto IL_009b;
			default:
				num = 4;
				continue;
			case 8:
				return;
			}
			sharpAESCrypt.FlushFinalBlock();
			num2 = 8;
			goto IL_00b6;
			continue;
			end_IL_00ba:
			break;
		}
		goto IL_0085;
		IL_00b6:
		num = num2;
		goto IL_00ba;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Decrypt(string password, Stream input, Stream output)
	{
		//Discarded unreachable code: IL_0005, IL_0024
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 0;
		bool flag = default(bool);
		byte[] array = default(byte[]);
		int count = default(int);
		SharpAESCrypt sharpAESCrypt = default(SharpAESCrypt);
		while (true)
		{
			int num2;
			switch (num)
			{
			default:
				num = 5;
				break;
			case 3:
				if (flag)
				{
					output.Write(array, 0, count);
					goto case 2;
				}
				num2 = 7;
				goto IL_002d;
			case 0:
				array = new byte[4096];
				_ = 0;
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num2 = 4;
					goto IL_002d;
				}
				num = 6;
				break;
			case 2:
			case 5:
			case 6:
				flag = (count = sharpAESCrypt.Read(array, 0, array.Length)) != 0;
				num2 = 3;
				goto IL_002d;
			case 1:
			case 4:
				sharpAESCrypt = new SharpAESCrypt(password, input, OperationMode.Decrypt);
				goto case 2;
			case 7:
				return;
				IL_002d:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Encrypt(string password, string inputfile, string outputfile)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		using FileStream input = File.OpenRead(inputfile);
		using FileStream output = File.Create(outputfile);
		Encrypt(password, input, output);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Decrypt(string password, string inputfile, string outputfile)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		using FileStream input = File.OpenRead(inputfile);
		using FileStream output = File.Create(outputfile);
		Decrypt(password, input, output);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public SharpAESCrypt(string password, Stream stream, OperationMode mode)
	{
		//Discarded unreachable code: IL_0005, IL_0072
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 7;
		if (1 == 0)
		{
			return;
		}
		bool extension_InsertTimeStamp = default(bool);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		bool flag = default(bool);
		bool extension_InsertPlaceholder = default(bool);
		bool extension_InsertCreateByIdentifier = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 18:
					return;
				case 14:
					m_hasFlushedFinalBlock = false;
					num2 = 0;
					continue;
				case 20:
					if (extension_InsertTimeStamp)
					{
						num3 = 36;
						goto IL_0077;
					}
					goto case 35;
				case 8:
				case 19:
					m_extensions = new List<KeyValuePair<string, byte[]>>();
					goto case 3;
				default:
					num3 = 3;
					goto IL_0077;
				case 21:
					throw new ArgumentNullException(S7EI44sMaZQ92MiG6X.pA2PN5iOW(108));
				case 27:
					m_extensions.Add(new KeyValuePair<string, byte[]>("", new byte[127]));
					num = 5;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 37;
				case 37:
					if (flag2)
					{
						num3 = 22;
						goto IL_0077;
					}
					ReadEncryptionHeader(password);
					num = 32;
					if (0 == 0)
					{
						break;
					}
					goto case 4;
				case 24:
					m_helper = new SetupHelper(mode, password, null);
					num2 = 31;
					continue;
				case 2:
					throw new ArgumentNullException(S7EI44sMaZQ92MiG6X.pA2PN5iOW(112));
				case 10:
					m_crypto = new CryptoStream(new CryptoStream(new StreamHider(m_stream, (m_version == 0) ? 32 : 33), m_hmac, CryptoStreamMode.Read), m_helper.CreateCryptoStream(m_mode), CryptoStreamMode.Read);
					num = 40;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 11;
				case 11:
					flag3 = stream == null;
					num = 33;
					break;
				case 13:
					m_extensions.Add(new KeyValuePair<string, byte[]>(S7EI44sMaZQ92MiG6X.pA2PN5iOW(120), Encoding.UTF8.GetBytes(Extension_CreatedByIdentifier)));
					num = 38;
					break;
				case 33:
					if (!flag3)
					{
						flag = password == null;
						num2 = 16;
						continue;
					}
					num = 21;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 1;
				case 15:
					throw new ArgumentException(Strings.InvalidOperationMode, S7EI44sMaZQ92MiG6X.pA2PN5iOW(116));
				case 5:
					m_crypto = null;
					num3 = 26;
					goto IL_0077;
				case 0:
					m_hasReadFooter = false;
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num2 = 29;
						continue;
					}
					num = 8;
					if (1 == 0)
					{
						return;
					}
					break;
				case 9:
					if (mode == OperationMode.Decrypt)
					{
						goto IL_02a4;
					}
					num = 15;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						break;
					}
					goto case 22;
				case 22:
					Version = DefaultFileVersion;
					num = 24;
					break;
				case 7:
					if (!S7EI44sMaZQ92MiG6X.EmWT1u1C4(16))
					{
						MAGIC_HEADER = Encoding.UTF8.GetBytes(S7EI44sMaZQ92MiG6X.pA2PN5iOW(104));
						num3 = 39;
						goto IL_0077;
					}
					num = 18;
					break;
				case 6:
				case 29:
					base._002Ector();
					num = 11;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 8;
				case 30:
					if (extension_InsertPlaceholder)
					{
						num = 27;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
					}
					goto case 5;
				case 3:
					flag2 = mode == OperationMode.Encrypt;
					num3 = 37;
					goto IL_0077;
				case 1:
					if (!stream.CanWrite)
					{
						num2 = 17;
						continue;
					}
					goto IL_04b9;
				case 36:
					m_extensions.Add(new KeyValuePair<string, byte[]>(S7EI44sMaZQ92MiG6X.pA2PN5iOW(124), Encoding.UTF8.GetBytes(DateTime.Now.ToString(S7EI44sMaZQ92MiG6X.pA2PN5iOW(128)))));
					num2 = 34;
					continue;
				case 28:
					throw new ArgumentException(Strings.StreamMustBeReadAble, S7EI44sMaZQ92MiG6X.pA2PN5iOW(108));
				case 35:
					extension_InsertPlaceholder = Extension_InsertPlaceholder;
					num3 = 30;
					goto IL_0077;
				case 39:
					m_version = 2;
					num2 = 4;
					continue;
				case 31:
					extension_InsertCreateByIdentifier = Extension_InsertCreateByIdentifier;
					num = 12;
					break;
				case 26:
					return;
				case 4:
					m_hasWrittenHeader = false;
					num3 = 14;
					goto IL_0077;
				case 16:
					if (!flag)
					{
						if (mode != 0)
						{
							num3 = 9;
							goto IL_0077;
						}
						goto IL_02a4;
					}
					num2 = 2;
					continue;
				case 17:
					throw new ArgumentException(Strings.StreamMustBeWriteAble, S7EI44sMaZQ92MiG6X.pA2PN5iOW(108));
				case 38:
					extension_InsertTimeStamp = Extension_InsertTimeStamp;
					num2 = 20;
					continue;
				case 34:
					m_extensions.Add(new KeyValuePair<string, byte[]>(S7EI44sMaZQ92MiG6X.pA2PN5iOW(132), Encoding.UTF8.GetBytes(DateTime.Now.ToUniversalTime().ToString(S7EI44sMaZQ92MiG6X.pA2PN5iOW(136)))));
					num2 = 35;
					continue;
				case 23:
					if (!stream.CanRead)
					{
						num3 = 28;
						goto IL_0077;
					}
					goto IL_041c;
				case 12:
					if (extension_InsertCreateByIdentifier)
					{
						num3 = 13;
						goto IL_0077;
					}
					goto case 38;
				case 32:
					m_hmac = m_helper.GetHMAC();
					num3 = 10;
					goto IL_0077;
				case 25:
					m_stream = stream;
					goto case 8;
				case 40:
					return;
					IL_02a4:
					if (mode == OperationMode.Encrypt)
					{
						num = 1;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 31;
					}
					goto IL_04b9;
					IL_0077:
					num = num3;
					break;
					IL_04b9:
					if (mode == OperationMode.Decrypt)
					{
						num2 = 23;
						continue;
					}
					goto IL_041c;
					IL_041c:
					m_mode = mode;
					num3 = 25;
					goto IL_0077;
				}
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
	public override long Seek(long offset, SeekOrigin origin)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return Crypto.Seek(offset, origin);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void SetLength(long value)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		Crypto.SetLength(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override int Read(byte[] buffer, int offset, int count)
	{
		//Discarded unreachable code: IL_0005, IL_0269
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_041d: Incompatible stack heights: 0 vs 1
		int num = 16;
		int num5 = default(int);
		byte[] array = default(byte[]);
		byte[] hash = default(byte[]);
		bool flag5 = default(bool);
		bool flag7 = default(bool);
		bool flag = default(bool);
		int result = default(int);
		bool flag2 = default(bool);
		int num4 = default(int);
		bool hasReadFooter = default(bool);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		bool flag6 = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				string message;
				switch (num2)
				{
				case 35:
					num5 = 0;
					num3 = 31;
					goto IL_026e;
				case 36:
					m_readcount += count;
					num = 0;
					break;
				case 24:
					throw new InvalidOperationException(Strings.CannotReadWhileEncrypting);
				case 14:
					array = RepeatRead(m_stream, hash.Length);
					num = 35;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 23;
				case 23:
					if (!flag5)
					{
						num = 22;
						if (true)
						{
							break;
						}
						goto case 4;
					}
					flag7 = hash[num5] != array[num5];
					num2 = 4;
					continue;
				case 4:
					if (flag7)
					{
						num2 = 8;
						continue;
					}
					num5++;
					goto case 20;
				case 8:
					if (m_version != 0)
					{
						num3 = 11;
						goto IL_026e;
					}
					message = Strings.DataHMACMismatch_v0;
					goto IL_0238;
				case 29:
					hash = m_hmac.Hash;
					num3 = 14;
					goto IL_026e;
				case 28:
					throw new InvalidDataException(Strings.InvalidFileLength);
				case 34:
					m_hasReadFooter = true;
					num = 1;
					if (0 == 0)
					{
						break;
					}
					goto case 20;
				case 25:
					if (flag)
					{
						num3 = 26;
						goto IL_026e;
					}
					goto IL_0439;
				case 13:
					result = 0;
					num = 3;
					if (true)
					{
						break;
					}
					goto case 9;
				case 9:
					flag2 = num4 < 0;
					num = 18;
					if (true)
					{
						break;
					}
					goto case 32;
				case 32:
					if (hasReadFooter)
					{
						num = 13;
						if (true)
						{
							break;
						}
						goto case 30;
					}
					count = Crypto.Read(buffer, offset, count);
					num = 36;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 11;
				case 30:
					if (flag3)
					{
						num3 = 7;
						goto IL_026e;
					}
					goto case 17;
				case 2:
					if (!flag4)
					{
						hasReadFooter = m_hasReadFooter;
						num = 32;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 36;
					}
					num3 = 24;
					goto IL_026e;
				case 0:
					m_length = (m_length + count) % 16;
					num = 12;
					if (true)
					{
						break;
					}
					goto case 5;
				case 5:
					throw new InvalidDataException(Strings.UnexpectedEndOfStream);
				case 11:
					message = Strings.DataHMACMismatch;
					goto IL_0238;
				case 37:
					flag6 = m_paddingSize > 16;
					goto case 21;
				default:
					num2 = 27;
					continue;
				case 15:
					if (m_readcount % 16 == 0)
					{
						Crypto.Close();
						num3 = 29;
						goto IL_026e;
					}
					goto IL_033e;
				case 26:
					num4 = m_stream.ReadByte();
					num3 = 9;
					goto IL_026e;
				case 10:
				case 19:
					if (m_readcount == m_payloadLength)
					{
						num3 = 34;
						goto IL_026e;
					}
					goto case 22;
				case 20:
				case 31:
				case 33:
					flag5 = num5 < hash.Length;
					num = 23;
					break;
				case 16:
					if (!S7EI44sMaZQ92MiG6X.EmWT1u1C4(24))
					{
						flag4 = m_mode != OperationMode.Decrypt;
						num2 = 2;
					}
					else
					{
						num2 = 21;
					}
					continue;
				case 18:
					if (!flag2)
					{
						m_paddingSize = (byte)num4;
						num2 = 37;
					}
					else
					{
						num2 = 5;
					}
					continue;
				case 17:
					if (m_length % 16 == 0)
					{
						num2 = 15;
						continue;
					}
					goto IL_033e;
				case 7:
					count -= 16 - m_paddingSize;
					num3 = 17;
					goto IL_026e;
				case 22:
					result = count;
					num2 = 38;
					continue;
				case 12:
					if (!m_hasReadFooter)
					{
						_ = 1;
						if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num = 20;
							break;
						}
						num3 = 19;
						goto IL_026e;
					}
					goto case 22;
				case 6:
					throw new InvalidDataException(Strings.InvalidFileLength);
				case 1:
					flag = m_version >= 1;
					num3 = 25;
					goto IL_026e;
				case 21:
				case 27:
					if (flag6)
					{
						num3 = 6;
						goto IL_026e;
					}
					goto IL_0439;
				case 3:
				case 38:
					{
						return result;
					}
					IL_026e:
					num = num3;
					break;
					IL_0439:
					flag3 = m_paddingSize > 0;
					num3 = 30;
					goto IL_026e;
					IL_0238:
					throw new InvalidDataException(message);
					IL_033e:
					num = 28;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
					goto case 26;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public override void Write(byte[] buffer, int offset, int count)
	{
		//Discarded unreachable code: IL_0005, IL_004e
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 1;
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 5;
			goto IL_005b;
		}
		int num2 = 3;
		goto IL_0057;
		IL_0057:
		num = num2;
		goto IL_005b;
		IL_005b:
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 1:
			case 3:
				if (flag)
				{
					num = 4;
					continue;
				}
				m_length = (m_length + count) % 16;
				goto case 2;
			case 4:
				throw new InvalidOperationException(Strings.CannotWriteWhileDecrypting);
			case 2:
				Crypto.Write(buffer, offset, count);
				num = 6;
				continue;
			case 0:
			case 5:
				flag = m_mode != OperationMode.Encrypt;
				goto case 1;
			case 6:
				return;
			}
			break;
		}
		num2 = 2;
		goto IL_0057;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FlushFinalBlock()
	{
		//Discarded unreachable code: IL_0005, IL_01e8
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_03f6: Incompatible stack heights: 0 vs 1
		int num = 33;
		byte b = default(byte);
		bool flag6 = default(bool);
		byte[] array = default(byte[]);
		bool flag = default(bool);
		bool flag4 = default(bool);
		byte[] hash = default(byte[]);
		bool flag5 = default(bool);
		int num3 = default(int);
		int num4 = default(int);
		bool flag2 = default(bool);
		long position = default(long);
		bool flag3 = default(bool);
		while (true)
		{
			int num2;
			int num5;
			switch (num)
			{
			case 25:
				m_stream.WriteByte(b);
				num2 = 24;
				goto IL_01f1;
			case 9:
				if (flag6)
				{
					num = 19;
					break;
				}
				return;
			case 30:
				flag6 = m_mode == OperationMode.Encrypt;
				num = 9;
				break;
			case 27:
				Write(array, 0, array.Length);
				num = 4;
				break;
			case 19:
				flag = !m_hasWrittenHeader;
				num2 = 21;
				if (false)
				{
					goto case 7;
				}
				goto IL_01f1;
			case 7:
				if (flag4)
				{
					num = 13;
					break;
				}
				m_stream.WriteByte(b);
				num = 1;
				break;
			case 13:
				m_stream.Write(hash, 0, hash.Length);
				num2 = 0;
				goto IL_01f1;
			case 31:
				if (flag5)
				{
					num2 = 30;
					if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto case 10;
					}
					goto IL_01f1;
				}
				return;
			case 10:
				hash = m_hmac.Hash;
				num2 = 22;
				if (1 == 0)
				{
					goto case 8;
				}
				goto IL_01f1;
			case 8:
			case 11:
				num3 = (m_length %= 16);
				num2 = 5;
				goto IL_01f1;
			case 33:
				if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(28))
				{
					num2 = 26;
					goto IL_01f1;
				}
				flag5 = !m_hasFlushedFinalBlock;
				num = 31;
				break;
			case 15:
				num4 = 0;
				num2 = 34;
				if (1 == 0)
				{
					goto case 16;
				}
				goto IL_01f1;
			case 16:
				m_stream.Flush();
				num = 35;
				break;
			case 14:
				if (flag2)
				{
					num = 32;
					break;
				}
				goto case 4;
			case 22:
				flag4 = m_version == 0;
				num2 = 7;
				if (1 == 0)
				{
					goto case 29;
				}
				goto IL_01f1;
			case 29:
				Crypto.Close();
				num = 10;
				break;
			case 32:
				array = new byte[16 - b];
				num = 15;
				break;
			case 5:
				b = (byte)num3;
				num2 = 18;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 24;
				}
				goto IL_01f1;
			case 24:
				m_stream.Seek(position, SeekOrigin.Begin);
				num2 = 23;
				goto IL_01f1;
			case 12:
			case 34:
				flag3 = num4 < array.Length;
				goto default;
			case 18:
				flag2 = b != 0;
				num2 = 14;
				goto IL_01f1;
			default:
				if (!flag3)
				{
					num5 = 27;
					goto IL_01ed;
				}
				array[num4] = (byte)array.Length;
				num = 28;
				break;
			case 2:
				return;
			case 1:
				m_stream.Write(hash, 0, hash.Length);
				num2 = 16;
				if (0 == 0)
				{
					goto IL_01f1;
				}
				goto case 28;
			case 28:
				num4++;
				num2 = 12;
				if (false)
				{
					return;
				}
				goto IL_01f1;
			case 26:
				return;
			case 21:
				if (!flag)
				{
					goto case 8;
				}
				num2 = 3;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 7;
				}
				goto IL_01f1;
			case 23:
				m_stream.Flush();
				num2 = 2;
				goto IL_01f1;
			case 20:
				m_stream.Seek(MAGIC_HEADER.Length + 1, SeekOrigin.Begin);
				num2 = 25;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto case 27;
				}
				goto IL_01f1;
			case 0:
				position = m_stream.Position;
				num2 = 20;
				if (0 == 0)
				{
					goto IL_01f1;
				}
				goto case 4;
			case 4:
				Crypto.FlushFinalBlock();
				num5 = 29;
				goto IL_01ed;
			case 3:
				WriteEncryptionHeader();
				_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num2 = 6;
					if (0 == 0)
					{
						goto IL_01f1;
					}
					goto case 18;
				}
				num = 11;
				break;
			case 35:
				return;
				IL_01f1:
				num = num2;
				break;
				IL_01ed:
				num2 = num5;
				goto IL_01f1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected override void Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_0005, IL_002b
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_012a: Incompatible stack heights: 0 vs 1
		int num = 6;
		if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			goto IL_001b;
		}
		goto IL_0034;
		IL_0034:
		int num2 = num;
		goto IL_0038;
		IL_0038:
		bool flag = default(bool);
		while (true)
		{
			int num3;
			switch (num2)
			{
			case 12:
				break;
			default:
				num = 14;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_0034;
				}
				goto case 16;
			case 3:
				m_hmac = null;
				num2 = 17;
				continue;
			case 16:
				FlushFinalBlock();
				num3 = 12;
				goto IL_0030;
			case 14:
				goto IL_00be;
			case 2:
				m_helper = null;
				num2 = 3;
				continue;
			case 15:
				m_helper.Dispose();
				num = 2;
				if (0 == 0)
				{
					goto IL_0034;
				}
				goto case 4;
			case 4:
				m_stream = null;
				num = 8;
				goto IL_0034;
			case 0:
				if (m_mode != 0)
				{
					break;
				}
				_ = 1;
				if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					num2 = 10;
					continue;
				}
				num3 = 11;
				goto IL_0030;
			case 8:
				m_extensions = null;
				num = 15;
				if (0 == 0)
				{
					goto IL_0034;
				}
				goto case 7;
			case 7:
				flag = disposing;
				num2 = 1;
				continue;
			case 5:
			case 11:
				if (m_hasFlushedFinalBlock)
				{
					break;
				}
				num3 = 16;
				goto IL_0030;
			case 13:
				return;
			case 9:
			case 10:
				goto IL_0198;
			case 6:
				goto IL_01b2;
			case 1:
				if (flag)
				{
					num2 = 0;
					continue;
				}
				return;
			case 17:
				return;
				IL_0030:
				num = num3;
				goto IL_0034;
			}
			break;
		}
		goto IL_001b;
		IL_001b:
		m_crypto.Dispose();
		goto IL_00be;
		IL_00be:
		m_crypto = null;
		goto IL_0198;
		IL_01b2:
		if (!S7EI44sMaZQ92MiG6X.EmWT1u1C4(32))
		{
			base.Dispose(disposing);
			num = 7;
			goto IL_0034;
		}
		num2 = 13;
		goto IL_0038;
		IL_0198:
		m_stream.Dispose();
		num = 4;
		if (true)
		{
			goto IL_0034;
		}
		goto IL_01b2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Main(string[] args)
	{
		//Discarded unreachable code: IL_0005, IL_0070, IL_01e2
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 4;
		if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			goto IL_001a;
		}
		goto IL_0079;
		IL_0079:
		int num2 = num;
		goto IL_007d;
		IL_007d:
		switch (num2)
		{
		case 4:
			break;
		case 1:
		case 3:
			return;
		case 2:
		case 5:
			goto IL_0065;
		default:
			goto IL_009e;
		case 0:
			goto IL_00a8;
		case 6:
			return;
		}
		goto IL_001a;
		IL_009e:
		num = 0;
		goto IL_0079;
		IL_001a:
		bool flag = default(bool);
		if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(36))
		{
			_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				num2 = 3;
				goto IL_007d;
			}
			num = 5;
			if (true)
			{
				goto IL_0079;
			}
		}
		else
		{
			flag = args.Length < 4;
		}
		goto IL_0065;
		IL_00a8:
		do
		{
			Console.WriteLine(Strings.CommandlineUsage);
			num = 6;
		}
		while (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092());
		goto IL_0079;
		IL_0065:
		if (flag)
		{
			goto IL_00a8;
		}
		try
		{
			bool flag2 = args[0].StartsWith(S7EI44sMaZQ92MiG6X.pA2PN5iOW(140), StringComparison.InvariantCultureIgnoreCase);
			int num3 = 6;
			bool flag3 = default(bool);
			bool flag4 = default(bool);
			while (true)
			{
				int num4;
				int num5;
				switch (num3)
				{
				case 6:
					if (flag2)
					{
						num4 = 5;
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto case 5;
						}
						goto IL_01eb;
					}
					flag3 = args[0].StartsWith(S7EI44sMaZQ92MiG6X.pA2PN5iOW(144), StringComparison.InvariantCultureIgnoreCase);
					num3 = 3;
					break;
				case 9:
					if (flag4)
					{
						_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							num3 = 4;
							break;
						}
						num4 = 0;
						if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto case 5;
						}
						goto IL_01eb;
					}
					Console.WriteLine(Strings.CommandlineUnknownMode);
					num5 = 11;
					goto IL_01e7;
				case 3:
					while (flag3)
					{
						num4 = 1;
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							continue;
						}
						goto IL_01eb;
					}
					flag4 = args[0].StartsWith(S7EI44sMaZQ92MiG6X.pA2PN5iOW(148));
					num5 = 9;
					goto IL_01e7;
				case 2:
					return;
				case 10:
					return;
				case 4:
				case 7:
					Unittest();
					return;
				case 8:
					return;
				case 5:
					Encrypt(args[1], args[2], args[3]);
					num5 = 10;
					goto IL_01e7;
				case 1:
					Decrypt(args[1], args[2], args[3]);
					return;
				default:
					num4 = 2;
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						return;
					}
					goto IL_01eb;
				case 0:
					return;
				case 11:
					return;
					IL_01eb:
					num3 = num4;
					break;
					IL_01e7:
					num4 = num5;
					goto IL_01eb;
				}
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(string.Format(Strings.CommandlineError, ex.ToString()));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void Unittest()
	{
		//Discarded unreachable code: IL_0005, IL_0090, IL_020b, IL_02d4
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 2;
		if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			goto IL_016f;
		}
		goto IL_02dd;
		IL_016f:
		Console.WriteLine();
		int num2 = 11;
		goto IL_02d9;
		IL_02d9:
		num = num2;
		goto IL_02dd;
		IL_02dd:
		int num7 = default(int);
		bool flag3 = default(bool);
		bool flag4 = default(bool);
		int num4 = default(int);
		Random random = default(Random);
		MemoryStream memoryStream = default(MemoryStream);
		bool flag5 = default(bool);
		byte b = default(byte);
		bool flag2 = default(bool);
		bool flag = default(bool);
		MemoryStream memoryStream2 = default(MemoryStream);
		while (true)
		{
			IL_02dd_2:
			int num3 = num;
			while (true)
			{
				switch (num3)
				{
				case 20:
					return;
				case 25:
					num7 = 0;
					num3 = 21;
					continue;
				case 12:
					Console.WriteLine();
					num3 = 24;
					continue;
				case 19:
					break;
				case 18:
					flag3 = flag4;
					num = 27;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_02dd_2;
					}
					goto case 16;
				case 7:
				case 26:
					Console.WriteLine();
					num3 = 29;
					continue;
				case 24:
					goto end_IL_02e1;
				case 6:
				case 28:
					num4 = 0;
					num3 = 5;
					continue;
				case 8:
					random = new Random();
					num = 16;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_02dd_2;
					}
					goto case 21;
				case 17:
					try
					{
						byte[] array = new byte[random.Next(5120, 104857600)];
						_ = 1;
						int num5;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							num5 = 3;
							goto IL_0218;
						}
						int num6 = 2;
						if (true)
						{
							goto IL_0214;
						}
						goto IL_0260;
						IL_0218:
						switch (num5)
						{
						case 1:
						case 2:
							memoryStream.Write(array, 0, array.Length);
							goto IL_0260;
						case 0:
						case 3:
							random.NextBytes(array);
							goto case 1;
						case 4:
							goto IL_0260;
						case 5:
							goto end_IL_01c9;
						}
						num6 = 4;
						goto IL_0214;
						IL_0260:
						flag4 |= Unittest(string.Format(S7EI44sMaZQ92MiG6X.pA2PN5iOW(164), num7, 1000, memoryStream.Length), memoryStream);
						num5 = 5;
						goto IL_0218;
						IL_0214:
						num5 = num6;
						goto IL_0218;
						end_IL_01c9:;
					}
					finally
					{
						((IDisposable)memoryStream)?.Dispose();
					}
					num7++;
					num3 = 23;
					continue;
				case 14:
					if (!flag5)
					{
						goto case 1;
					}
					goto IL_0472;
				default:
					num = 1;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_02dd_2;
					}
					goto case 7;
				case 13:
					b = (byte)(b + 1);
					num3 = 10;
					continue;
				case 9:
				case 10:
					flag5 = b <= 2;
					num = 14;
					goto IL_02dd_2;
				case 27:
					if (flag3)
					{
						num2 = 12;
						goto IL_02d9;
					}
					return;
				case 4:
				case 5:
					flag2 = num4 < 5120;
					num = 15;
					goto IL_02dd_2;
				case 16:
					Console.WriteLine(S7EI44sMaZQ92MiG6X.pA2PN5iOW(152));
					num2 = 3;
					goto IL_02d9;
				case 0:
					Console.WriteLine(string.Format(S7EI44sMaZQ92MiG6X.pA2PN5iOW(160), DefaultFileVersion));
					num2 = 25;
					goto IL_02d9;
				case 21:
				case 23:
					flag = num7 < 1000;
					num2 = 22;
					goto IL_02d9;
				case 3:
					b = 0;
					num3 = 9;
					continue;
				case 22:
					if (flag)
					{
						memoryStream = new MemoryStream();
						num = 17;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_02dd_2;
						}
						goto case 27;
					}
					num = 18;
					if (0 == 0)
					{
						goto IL_02dd_2;
					}
					goto case 1;
				case 1:
					DefaultFileVersion = 2;
					num = 0;
					if (true)
					{
						goto IL_02dd_2;
					}
					goto case 2;
				case 2:
					if (!S7EI44sMaZQ92MiG6X.EmWT1u1C4(40))
					{
						flag4 = true;
						num = 8;
						if (0 == 0)
						{
							goto IL_02dd_2;
						}
						goto case 25;
					}
					num2 = 20;
					goto IL_02d9;
				case 15:
					goto IL_04ad;
				case 11:
					Console.WriteLine(S7EI44sMaZQ92MiG6X.pA2PN5iOW(168));
					goto case 7;
				case 29:
					return;
				}
				try
				{
					byte[] array2 = new byte[num4];
					_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
					int num8;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						num8 = 1;
						if (false)
						{
							goto IL_007c;
						}
					}
					else
					{
						num8 = 4;
						if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_00ea;
						}
					}
					int num9 = num8;
					goto IL_009d;
					IL_009d:
					while (true)
					{
						switch (num9)
						{
						case 3:
							break;
						case 0:
						case 1:
							random.NextBytes(array2);
							num9 = 3;
							continue;
						default:
							goto IL_00ea;
						case 5:
							goto end_IL_0054;
						}
						break;
					}
					goto IL_007c;
					IL_007c:
					memoryStream2.Write(array2, 0, array2.Length);
					goto IL_00ea;
					IL_00ea:
					flag4 &= Unittest(string.Format(S7EI44sMaZQ92MiG6X.pA2PN5iOW(156), b, memoryStream2.Length), memoryStream2);
					num9 = 5;
					goto IL_009d;
					end_IL_0054:;
				}
				finally
				{
					((IDisposable)memoryStream2)?.Dispose();
				}
				num4++;
				num2 = 4;
				goto IL_02d9;
				IL_04ad:
				if (flag2)
				{
					memoryStream2 = new MemoryStream();
					num3 = 19;
					continue;
				}
				num = 13;
				goto IL_02dd_2;
				IL_0472:
				DefaultFileVersion = b;
				_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num = 28;
					goto IL_02dd_2;
				}
				num3 = 7;
				continue;
				end_IL_02e1:
				break;
			}
			break;
		}
		goto IL_016f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool Unittest(string message, MemoryStream input)
	{
		//Discarded unreachable code: IL_0005, IL_00d1, IL_02fc
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 1;
		int num;
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 2;
			if (false)
			{
				goto IL_0022;
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0305;
		IL_0039:
		try
		{
			Random random = new Random();
			char[] array = new char[random.Next(1, 25)];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = S7EI44sMaZQ92MiG6X.pA2PN5iOW(172)[random.Next(0, S7EI44sMaZQ92MiG6X.pA2PN5iOW(172).Length)];
			}
			input.Position = 0L;
			using MemoryStream memoryStream = new MemoryStream();
			using MemoryStream memoryStream2 = new MemoryStream();
			Encrypt(new string(array), input, memoryStream);
			int num2 = 5;
			if (1 == 0)
			{
				goto IL_00c5;
			}
			goto IL_00da;
			IL_00da:
			int num4 = default(int);
			bool flag = default(bool);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			while (true)
			{
				IL_00da_2:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 7:
						break;
					default:
						goto IL_011f;
					case 8:
						throw new Exception(string.Format(S7EI44sMaZQ92MiG6X.pA2PN5iOW(180), num4));
					case 5:
						goto IL_0155;
					case 2:
						memoryStream2.Position = 0L;
						goto case 3;
					case 4:
						goto IL_0193;
					case 12:
					case 13:
						goto IL_01d1;
					case 1:
					case 6:
						Decrypt(new string(array), memoryStream, memoryStream2);
						num3 = 2;
						continue;
					case 3:
					case 9:
						input.Position = 0L;
						num3 = 11;
						continue;
					case 0:
						goto IL_021a;
					case 11:
						goto IL_0239;
					case 10:
						goto IL_0258;
					case 14:
						goto end_IL_00a7;
					}
					break;
					IL_0258:
					if (!flag)
					{
						num3 = 14;
						continue;
					}
					flag2 = memoryStream2.ReadByte() != input.ReadByte();
					num2 = 0;
					goto IL_00da_2;
					IL_00d6:
					int num5;
					num2 = num5;
					goto IL_00da_2;
					IL_0155:
					memoryStream.Position = 0L;
					_ = 0;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num2 = 6;
						goto IL_00da_2;
					}
					num5 = 9;
					goto IL_00d6;
					IL_021a:
					if (!flag2)
					{
						num4++;
						num3 = 12;
						continue;
					}
					num2 = 8;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						goto IL_00da_2;
					}
					goto IL_0239;
					IL_011f:
					num5 = 4;
					goto IL_00d6;
					IL_0239:
					flag3 = memoryStream2.Length != input.Length;
					num3 = 7;
				}
				break;
			}
			goto IL_00c5;
			IL_0193:
			throw new Exception(string.Format(S7EI44sMaZQ92MiG6X.pA2PN5iOW(176), memoryStream2.Length, input.Length));
			IL_00c5:
			if (flag3)
			{
				goto IL_0193;
			}
			num4 = 0;
			num2 = 13;
			if (0 == 0)
			{
				goto IL_00da;
			}
			goto IL_01d1;
			IL_01d1:
			flag = num4 < memoryStream2.Length;
			num2 = 10;
			goto IL_00da;
			end_IL_00a7:;
		}
		catch (Exception ex)
		{
			Console.WriteLine(S7EI44sMaZQ92MiG6X.pA2PN5iOW(184) + ex.Message);
			return false;
		}
		Console.WriteLine(S7EI44sMaZQ92MiG6X.pA2PN5iOW(188));
		goto IL_0335;
		IL_0335:
		bool result = true;
		num = 5;
		if (0 == 0)
		{
			goto IL_0305;
		}
		goto IL_034d;
		IL_0305:
		while (true)
		{
			switch (num)
			{
			case 0:
			case 2:
				break;
			case 1:
			case 3:
				goto IL_0039;
			default:
				num = 4;
				if (true)
				{
					continue;
				}
				goto IL_0335;
			case 4:
				goto IL_0335;
			case 5:
				goto IL_034d;
			}
			break;
		}
		goto IL_0022;
		IL_034d:
		return result;
		IL_0022:
		Console.Write(message);
		goto IL_0039;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static SharpAESCrypt()
	{
		//Discarded unreachable code: IL_0005, IL_0028
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num = ((!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()) ? 5 : 3);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 4:
				Extension_InsertTimeStamp = false;
				goto case 6;
			default:
				num2 = 6;
				goto IL_0031;
			case 0:
			case 3:
				Extension_CreatedByIdentifier = string.Format(S7EI44sMaZQ92MiG6X.pA2PN5iOW(192), Assembly.GetExecutingAssembly().GetName().Version);
				break;
			case 6:
				Extension_InsertPlaceholder = true;
				num2 = 2;
				goto IL_0031;
			case 2:
				DefaultFileVersion = 2;
				num2 = 7;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					goto IL_0031;
				}
				break;
			case 1:
			case 5:
				break;
			case 7:
				return;
			}
			Extension_InsertCreateByIdentifier = true;
			num2 = 4;
			if (1 == 0)
			{
				break;
			}
			goto IL_0031;
			IL_0031:
			num = num2;
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
