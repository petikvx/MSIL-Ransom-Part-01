using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using ns4;
using ns5;
using ns6;

namespace ns2;

internal class Class12
{
	private const int int_0 = 4096;

	private const int int_1 = 6;

	private const int int_2 = 4;

	private const int int_3 = 4;

	private static Assembly assembly_0 = null;

	private static readonly byte[] byte_0;

	public static void smethod_0()
	{
		AppDomain appDomain_ = Class19.smethod_4(5495);
		Class19.smethod_5(appDomain_, smethod_1, 37386);
	}

	internal static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if ((object)assembly_0 == null)
		{
			Stream stream = Class18.smethod_15(Class18.smethod_14(16455), "RSRCNAME", 21202);
			BinaryReader binaryReader_ = new BinaryReader(stream);
			byte[] array = new byte[Class18.smethod_1(stream, 18515)];
			Class19.smethod_2(binaryReader_, array, 0, array.Length, 4252);
			assembly_0 = Class19.smethod_0(smethod_2(smethod_5(array, "399eGcVPQb0nPJws")), 40308);
		}
		string[] array2 = Class19.smethod_7(assembly_0, 47127);
		string[] array3 = array2;
		int num = 0;
		while (true)
		{
			if (num < array3.Length)
			{
				string string_ = array3[num];
				if (Class18.smethod_5(string_, Class19.smethod_8(resolveEventArgs_0, 60371), 24791))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return assembly_0;
	}

	public static byte[] smethod_2(byte[] byte_1)
	{
		int num = smethod_4(byte_1);
		int num2 = smethod_3(byte_1);
		int num3 = 0;
		uint num4 = 1u;
		byte[] array = new byte[num];
		int[] array2 = new int[4096];
		byte[] array3 = new byte[4096];
		int num5 = num - 6 - 4 - 1;
		int num6 = -1;
		uint num7 = 0u;
		int num8 = (byte_1[0] >> 2) & 3;
		if (num8 != 1 && num8 != 3)
		{
			throw new ArgumentException("C# version only supports level 1 and 3");
		}
		if ((byte_1[0] & 1) != 1)
		{
			byte[] array4 = new byte[num];
			Class20.smethod_13(byte_1, smethod_3(byte_1), array4, 0, num, 42485);
			return array4;
		}
		while (true)
		{
			if (num4 == 1)
			{
				num4 = (uint)(byte_1[num2] | (byte_1[num2 + 1] << 8) | (byte_1[num2 + 2] << 16) | (byte_1[num2 + 3] << 24));
				num2 += 4;
				if (num3 <= num5)
				{
					num7 = (uint)((num8 != 1) ? (byte_1[num2] | (byte_1[num2 + 1] << 8) | (byte_1[num2 + 2] << 16) | (byte_1[num2 + 3] << 24)) : (byte_1[num2] | (byte_1[num2 + 1] << 8) | (byte_1[num2 + 2] << 16)));
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
						num11 = byte_1[num2 + 2];
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
					num7 = (uint)(byte_1[num2] | (byte_1[num2 + 1] << 8) | (byte_1[num2 + 2] << 16));
				}
				else
				{
					num7 = (uint)(byte_1[num2] | (byte_1[num2 + 1] << 8) | (byte_1[num2 + 2] << 16) | (byte_1[num2 + 3] << 24));
				}
				num6 = num3 - 1;
				continue;
			}
			if (num3 > num5)
			{
				break;
			}
			array[num3] = byte_1[num2];
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
				num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (byte_1[num2 + 2] << 16));
			}
			else
			{
				num7 = (uint)(((num7 >> 8) & 0xFFFFu) | (byte_1[num2 + 2] << 16) | (byte_1[num2 + 3] << 24));
			}
		}
		while (num3 <= num - 1)
		{
			if (num4 == 1)
			{
				num2 += 4;
				num4 = 2147483648u;
			}
			array[num3] = byte_1[num2];
			num3++;
			num2++;
			num4 >>= 1;
		}
		return array;
	}

	private static int smethod_3(byte[] byte_1)
	{
		if ((byte_1[0] & 2) != 2)
		{
			return 3;
		}
		return 9;
	}

	public static int smethod_4(byte[] byte_1)
	{
		if (smethod_3(byte_1) == 9)
		{
			return byte_1[5] | (byte_1[6] << 8) | (byte_1[7] << 16) | (byte_1[8] << 24);
		}
		return byte_1[2];
	}

	public static byte[] smethod_5(byte[] byte_1, string string_0)
	{
		Rijndael symmetricAlgorithm_ = Class19.smethod_16(4702);
		Rfc2898DeriveBytes deriveBytes_ = new Rfc2898DeriveBytes(string_0, byte_0);
		Class19.smethod_18(symmetricAlgorithm_, Class19.smethod_17(deriveBytes_, 32, 41887), 8939);
		Class19.smethod_19(symmetricAlgorithm_, Class19.smethod_17(deriveBytes_, 16, 41887), 20192);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream stream_ = new CryptoStream(memoryStream, Class20.smethod_0(symmetricAlgorithm_, 56251), CryptoStreamMode.Write);
		Class18.smethod_0(stream_, byte_1, 0, byte_1.Length, 18525);
		Class18.smethod_2(stream_, 35274);
		return Class19.smethod_15(memoryStream, 34849);
	}

	private static string smethod_6(string string_0, int int_4)
	{
		char[] array = Class20.smethod_18(string_0, 60655);
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)(array[i] ^ int_4);
		}
		return new string(array);
	}

	static Class12()
	{
		byte[] array_ = new byte[16];
		Class20.smethod_7(array_, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/, 2863);
		byte_0 = array_;
	}
}
