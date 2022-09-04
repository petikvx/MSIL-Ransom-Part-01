using System;
using System.Security.Cryptography;

public class GClass1
{
	private byte[] byte_0 = null;

	private byte[] byte_1 = null;

	private const int int_0 = 32;

	private const int int_1 = 16;

	public GClass1()
	{
		method_0();
	}

	void object.Finalize()
	{
		try
		{
			byte_0 = null;
			byte_1 = null;
		}
		finally
		{
			base.Finalize();
		}
	}

	public void method_0()
	{
		while (true)
		{
			int num = 939115622;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8CDEF8u) % 5u)
				{
				case 4u:
					num = ((int)num2 * -1502407868) ^ -2142905323;
					continue;
				case 1u:
					num = (int)((num2 * 2140026334) ^ 0xF41F368);
					continue;
				case 0u:
					byte_1 = method_1(-966394356, 32);
					byte_0 = method_1(-1108901958, 16);
					num = ((int)num2 * -1028458912) ^ 0x451C4AF2;
					continue;
				default:
					return;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private byte[] method_1(int int_2, int int_3)
	{
		byte[] result = default(byte[]);
		byte[] array = default(byte[]);
		Random random = default(Random);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1741714876;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1330E209u) % 10u)
				{
				case 9u:
					result = array;
					num = ((int)num2 * -88649449) ^ 0x292AE6B6;
					continue;
				case 8u:
					num = 372104494;
					continue;
				case 7u:
					array = new byte[int_3];
					random = new Random(int_2);
					num = ((int)num2 * -658802474) ^ -1527309823;
					continue;
				case 5u:
					num4 = num3;
					num = 1098049115;
					continue;
				case 4u:
				{
					num3 = num4 - 1;
					int num5;
					int num6;
					if (num4 <= 0)
					{
						num5 = -240562502;
						num6 = -240562502;
					}
					else
					{
						num5 = -1675730855;
						num6 = -1675730855;
					}
					num = num5 ^ (int)(num2 * 112471848);
					continue;
				}
				case 3u:
					random.NextBytes(array);
					num = ((int)num2 * -1672993277) ^ 0x3122ED8B;
					continue;
				case 1u:
					random.Next();
					num = (int)(num2 * 615158814) ^ -232215334;
					continue;
				case 0u:
					num3 = (int_2 >> 8) & 0xFF;
					num = ((int)num2 * -353250241) ^ -128997774;
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public byte[] method_2(byte[] byte_2)
	{
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		byte[] result = default(byte[]);
		while (true)
		{
			int num = 1783196459;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2DDD519Au) % 10u)
				{
				case 9u:
					rijndaelManaged = new RijndaelManaged();
					num = ((int)num2 * -931325479) ^ 0x472B0765;
					continue;
				case 7u:
					rijndaelManaged.Mode = CipherMode.CBC;
					num = (int)((num2 * 794318236) ^ 0x2AD2BA22);
					continue;
				case 6u:
					rijndaelManaged.BlockSize = 128;
					num = ((int)num2 * -1376221146) ^ -1703962351;
					continue;
				case 4u:
					result = rijndaelManaged.CreateDecryptor().TransformFinalBlock(byte_2, 0, byte_2.Length);
					num = (int)((num2 * 949399376) ^ 0x560D6E2C);
					continue;
				case 3u:
					rijndaelManaged.IV = byte_0;
					num = ((int)num2 * -1966070731) ^ 0x2AE0B1B;
					continue;
				case 2u:
					num = (int)((num2 * 601671704) ^ 0x1D0919AC);
					continue;
				case 1u:
					rijndaelManaged.KeySize = 256;
					num = ((int)num2 * -1269392345) ^ 0x74383E2A;
					continue;
				case 0u:
					rijndaelManaged.Padding = PaddingMode.PKCS7;
					rijndaelManaged.Key = byte_1;
					num = ((int)num2 * -1412986997) ^ 0xAAF634F;
					continue;
				case 5u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}
}
