using System.Security;
using System.Security.Cryptography;

namespace c;

internal sealed class d
{
	public static void g(Rijndael rijndael_0, Rfc2898DeriveBytes rfc2898DeriveBytes_0)
	{
		int num = 3;
		while (true)
		{
			int num2 = 589186256;
			while (true)
			{
				switch ((uint)(num2 ^ 0x4BE93593) % 6u)
				{
				case 5u:
					m.o((SymmetricAlgorithm)rijndael_0, b.f, 182, (short)147);
					num2 = 2045696241;
					continue;
				case 4u:
					goto IL_0023;
				case 3u:
					switch (num)
					{
					case 0:
					case 3:
						break;
					case 4:
						goto IL_0023;
					default:
						goto IL_0052;
					case 1:
					case 2:
						goto IL_0059;
					}
					goto case 5u;
				case 2u:
					goto IL_0059;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
					IL_0059:
					e.r.k((SymmetricAlgorithm)rijndael_0, e.r.q((DeriveBytes)rfc2898DeriveBytes_0, 32, 743, 671), (short)156, (short)140);
					num = 4;
					num2 = 589186256;
					continue;
					IL_0052:
					num2 = 1576344918;
					continue;
					IL_0023:
					d.smethod_1((SymmetricAlgorithm)rijndael_0, d.smethod_0((DeriveBytes)rfc2898DeriveBytes_0, 16));
					num2 = 1858943952;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ICryptoTransform o<T>(T gparam_0, char char_0, int int_0) where T : SymmetricAlgorithm
	{
		int[] x = l.x;
		object obj = default(object);
		int num5 = default(int);
		char[] k = default(char[]);
		int num4 = default(int);
		while (true)
		{
			int num = -773736910;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xADE6B9F7u) % 11u)
				{
				case 10u:
					num = -1045000871;
					continue;
				case 8u:
					num = (int)(num2 * 1335433224) ^ -241042164;
					continue;
				case 7u:
					while (true)
					{
						switch (num4)
						{
						case 1:
						case 8:
							break;
						case 9:
							num4 = x[84] - 6604;
							continue;
						case 2:
						case 7:
							obj = d.smethod_2((SymmetricAlgorithm)gparam_0);
							num4 = x[196] - 2548;
							continue;
						case 6:
							num5++;
							if ((char_0 * char_0 + char_0) % 2 != 0)
							{
								num4 = k[446] - 10210;
								continue;
							}
							num4 = 0;
							goto case 0;
						case 5:
							obj = null;
							num4 = k[256] - 38375;
							continue;
						default:
							goto IL_00ba;
						case 10:
							num4 = 3;
							goto IL_00c6;
						case 3:
							goto IL_00c6;
						case 4:
						case 11:
							goto IL_00f4;
						case 0:
							return (ICryptoTransform)obj;
						}
						break;
					}
					goto case 10u;
				case 5u:
					goto IL_00c6;
				default:
					num3 = x[346] - 43972;
					goto IL_00ec;
				case 0u:
					goto IL_00f4;
				case 6u:
					num4 = 11;
					num = ((int)num2 * -1821515126) ^ 0x30F9A688;
					continue;
				case 4u:
					num3 = k[487] - 18993;
					goto IL_00ec;
				case 2u:
					num = ((int)num2 * -1469738140) ^ -2070913249;
					continue;
				case 1u:
					k = e.e.k;
					num = (int)((num2 * 1153937634) ^ 0x5D629769);
					continue;
				case 9u:
					break;
					IL_00f4:
					num5 = 0;
					num4 = x[28] - 62815;
					num = -1494603330;
					continue;
					IL_00c6:
					switch (((char_0 ^ int_0) - 99) ^ num5)
					{
					default:
						num = -2123863136;
						continue;
					case 0:
						break;
					}
					goto default;
					IL_00ec:
					num4 = num3;
					num = -1188190396;
					continue;
					IL_00ba:
					num = -331969127;
					continue;
				}
				break;
			}
		}
	}

	static byte[] smethod_0(DeriveBytes deriveBytes_0, int int_0)
	{
		return deriveBytes_0.GetBytes(int_0);
	}

	static void smethod_1(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		symmetricAlgorithm_0.IV = byte_0;
	}

	static ICryptoTransform smethod_2(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		return symmetricAlgorithm_0.CreateDecryptor();
	}
}
