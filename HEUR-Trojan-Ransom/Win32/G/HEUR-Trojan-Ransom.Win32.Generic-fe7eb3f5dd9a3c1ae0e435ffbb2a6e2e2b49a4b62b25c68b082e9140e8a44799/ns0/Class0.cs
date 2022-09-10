using System;
using System.Security.Cryptography;

namespace ns0;

internal class Class0
{
	private byte[] byte_0;

	private byte[] byte_1;

	public Class0()
	{
		byte_0 = new byte[32];
		byte_1 = new byte[16];
		method_1(ref byte_0, ref byte_1);
	}

	private void method_0(ref byte[] byte_2, int int_0)
	{
		Random random = new Random(int_0);
		int num = (int_0 ^ random.Next()) & 0xFFFFFF;
		while (true)
		{
			int num2 = -440658568;
			while (true)
			{
				int num3 = num2;
				uint num4;
				switch ((num4 = (uint)(-(-(237089474 - ~(num3 ^ -855277887) - -1869996855) ^ -1589021899))) % 5u)
				{
				case 3u:
				{
					int num5;
					if (num-- > 0)
					{
						num2 = -193540041;
						num5 = -193540041;
					}
					else
					{
						num2 = -1837301663;
						num5 = -1837301663;
					}
					continue;
				}
				case 2u:
					random.Next();
					num2 = 1300023103;
					continue;
				case 1u:
					num2 = (int)((num4 * 1648805516) ^ 0x665F155F);
					continue;
				case 0u:
					break;
				default:
					random.NextBytes(byte_2);
					return;
				}
				break;
			}
		}
	}

	private void method_1(ref byte[] byte_2, ref byte[] byte_3)
	{
		method_0(ref byte_2, 1791344241);
		method_0(ref byte_3, -1525554636);
	}

	public byte[] method_2(byte[] byte_2)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.Mode = CipherMode.CBC;
		while (true)
		{
			int num = -802181471;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(num2 * -1074450031 * -1942452289 - 1955535109 + 1454690650 - 2005013176 - -634002931)) % 3u)
				{
				case 2u:
					goto IL_0025;
				case 0u:
					break;
				default:
					rijndaelManaged.Key = byte_0;
					rijndaelManaged.IV = byte_1;
					try
					{
						return rijndaelManaged.CreateDecryptor().TransformFinalBlock(byte_2, 0, byte_2.Length);
					}
					catch
					{
						return null;
					}
				}
				break;
				IL_0025:
				rijndaelManaged.Padding = PaddingMode.PKCS7;
				num = ((int)num3 * -1972916499) ^ -1077637783;
			}
		}
	}
}
