using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using yleKZlCXnrEgcQD3gk;

internal class Class1
{
	internal class Attribute0 : Attribute
	{
		internal class DCAGOPLFHBJIALDPGBGDBGGMNEPIAIFAIEAG<T>
		{
		}

		[Attribute0(typeof(JGJDEKNCCPFEMINLNAFHJIDDLFJBHJDLFNJJ_002FBPJNDKHFPODFBIJPBMGGEOBDIGOEFEIEPPBO_002FDCAGOPLFHBJIALDPGBGDBGGMNEPIAIFAIEAG<object>[]))]
		public Attribute0(object object_0)
		{
		}
	}

	[Flags]
	private enum Enum0
	{

	}

	private static uint[] uint_0;

	private static bool bool_0;

	private static bool bool_1;

	private static byte[] byte_0;

	private static byte[] byte_1;

	private static byte[] byte_2;

	private static byte[] byte_3;

	private static IntPtr intptr_0;

	private static IntPtr intptr_1;

	private static string[] string_0;

	private static int[] int_0;

	private static int int_1;

	private static long long_0;

	private static int int_2;

	private static bool bool_2;

	static Class1()
	{
		uint_0 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		bool_0 = false;
		bool_1 = false;
		byte_0 = new byte[0];
		byte_1 = new byte[0];
		byte_2 = new byte[0];
		byte_3 = new byte[0];
		intptr_0 = IntPtr.Zero;
		intptr_1 = IntPtr.Zero;
		string_0 = new string[0];
		int_0 = new int[0];
		int_1 = 1;
		long_0 = 0L;
		int_2 = 0;
		bool_2 = false;
	}

	private void leHifFIJCLsZtKEFfM1i()
	{
	}

	internal static byte[] smethod_0(byte[] byte_4)
	{
		uint[] array = new uint[16];
		int num = 448 - byte_4.Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(byte_4.Length + num2 / 8u + 8L);
		ulong num4 = (ulong)(byte_4.Length * 8L);
		byte[] array2 = new byte[num3];
		for (int i = 0; i < byte_4.Length; i++)
		{
			array2[i] = byte_4[i];
		}
		array2[byte_4.Length] |= 128;
		for (int num5 = 8; num5 > 0; num5--)
		{
			array2[num3 - num5] = (byte)((num4 >> (8 - num5) * 8) & 0xFFuL);
		}
		uint num6 = (uint)(array2.Length * 8) / 32u;
		uint uint_ = 1732584193u;
		uint uint_2 = 4023233417u;
		uint uint_3 = 2562383102u;
		uint uint_4 = 271733878u;
		for (uint num7 = 0u; num7 < num6 / 16u; num7++)
		{
			uint num8 = num7 << 6;
			for (uint num9 = 0u; num9 < 61; num9 += 4)
			{
				array[num9 >> 2] = (uint)((array2[num8 + (num9 + 3)] << 24) | (array2[num8 + (num9 + 2)] << 16) | (array2[num8 + (num9 + 1)] << 8) | array2[num8 + num9]);
			}
			uint num10 = uint_;
			uint num11 = uint_2;
			uint num12 = uint_3;
			uint num13 = uint_4;
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			smethod_1(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			smethod_1(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			smethod_1(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			smethod_1(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			smethod_2(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			smethod_2(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			smethod_2(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			smethod_2(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			smethod_3(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			smethod_3(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			smethod_3(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			smethod_3(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			smethod_4(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			smethod_4(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			smethod_4(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			smethod_4(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
			uint_ += num10;
			uint_2 += num11;
			uint_3 += num12;
			uint_4 += num13;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(uint_), 0, array3, 0, 4);
		Array.Copy(BitConverter.GetBytes(uint_2), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(uint_3), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(uint_4), 0, array3, 12, 4);
		return array3;
	}

	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + uint_7[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + uint_7[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + uint_7[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + uint_7[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return (uint_1 >> 32 - ushort_0) | (uint_1 << (int)ushort_0);
	}

	internal static bool smethod_6()
	{
		if (!bool_0)
		{
			smethod_7();
			bool_0 = true;
		}
		return bool_1;
	}

	internal static void smethod_7()
	{
		try
		{
			bool_1 = (bool)typeof(RijndaelManaged).Assembly.GetType("System.Security.Cryptography.CryptoConfig", throwOnError: false)!.GetMethod("get_AllowOnlyFipsAlgorithms", BindingFlags.Static | BindingFlags.Public)!.Invoke(null, new object[0]);
		}
		catch
		{
			try
			{
				int num = (int)typeof(RijndaelManaged).Assembly.GetType("System.Security.Cryptography.Utils", throwOnError: false)!.GetMethod("get_FipsAlgorithmPolicy", BindingFlags.Static | BindingFlags.NonPublic)!.Invoke(null, new object[0]);
				if (num == 1)
				{
					bool_1 = true;
				}
			}
			catch
			{
			}
		}
	}

	internal static SymmetricAlgorithm smethod_8()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (smethod_6())
		{
			try
			{
				return (SymmetricAlgorithm)Activator.CreateInstance(Assembly.Load("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089").GetType("System.Security.Cryptography.AesCryptoServiceProvider"));
			}
			catch
			{
				return new RijndaelManaged();
			}
		}
		return new RijndaelManaged();
	}

	internal static byte[] smethod_9(byte[] byte_4)
	{
		if (!smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_4);
		}
		return smethod_0(byte_4);
	}

	static bool smethod_10(int int_3)
	{
		if (byte_1.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class1).Assembly.GetManifestResourceStream("994a82cb-7be1-4a15-8e89-0b8a1068cba4"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 158;
			array2[0] = 118;
			array2[0] = 163;
			array2[0] = 135;
			array2[0] = 146;
			array2[1] = 141;
			array2[1] = 168;
			array2[1] = 117;
			array2[1] = 65;
			array2[2] = 125;
			array2[2] = 144;
			array2[2] = 123;
			array2[2] = 137;
			array2[3] = 147;
			array2[3] = 237;
			array2[3] = 138;
			array2[3] = 139;
			array2[4] = 124;
			array2[4] = 128;
			array2[4] = 118;
			array2[4] = 220;
			array2[5] = 101;
			array2[5] = 107;
			array2[5] = 116;
			array2[6] = 152;
			array2[6] = 160;
			array2[6] = 55;
			array2[7] = 92;
			array2[7] = 129;
			array2[7] = 209;
			array2[8] = 141;
			array2[8] = 152;
			array2[8] = 165;
			array2[8] = 204;
			array2[9] = 89;
			array2[9] = 152;
			array2[9] = 137;
			array2[9] = 98;
			array2[9] = 188;
			array2[10] = 66;
			array2[10] = 88;
			array2[10] = 133;
			array2[10] = 153;
			array2[10] = 77;
			array2[11] = 138;
			array2[11] = 118;
			array2[11] = 50;
			array2[11] = 220;
			array2[12] = 98;
			array2[12] = 130;
			array2[12] = 50;
			array2[13] = 87;
			array2[13] = 115;
			array2[13] = 94;
			array2[13] = 111;
			array2[13] = 207;
			array2[13] = 129;
			array2[14] = 124;
			array2[14] = 88;
			array2[14] = 231;
			array2[14] = 13;
			array2[15] = 125;
			array2[15] = 88;
			array2[15] = 42;
			array2[15] = 16;
			array2[16] = 162;
			array2[16] = 142;
			array2[16] = 58;
			array2[17] = 124;
			array2[17] = 48;
			array2[17] = 120;
			array2[17] = 153;
			array2[17] = 88;
			array2[17] = 78;
			array2[18] = 166;
			array2[18] = 88;
			array2[18] = 161;
			array2[18] = 120;
			array2[18] = 87;
			array2[19] = 100;
			array2[19] = 55;
			array2[19] = 112;
			array2[19] = 88;
			array2[19] = 154;
			array2[19] = 193;
			array2[20] = 211;
			array2[20] = 84;
			array2[20] = 167;
			array2[20] = 133;
			array2[20] = 179;
			array2[21] = 102;
			array2[21] = 59;
			array2[21] = 204;
			array2[22] = 93;
			array2[22] = 161;
			array2[22] = 43;
			array2[23] = 114;
			array2[23] = 153;
			array2[23] = 149;
			array2[23] = 44;
			array2[23] = 151;
			array2[24] = 168;
			array2[24] = 177;
			array2[24] = 139;
			array2[24] = 92;
			array2[24] = 207;
			array2[25] = 201;
			array2[25] = 101;
			array2[25] = 166;
			array2[25] = 116;
			array2[25] = 4;
			array2[26] = 102;
			array2[26] = 154;
			array2[26] = 118;
			array2[26] = 235;
			array2[27] = 93;
			array2[27] = 34;
			array2[27] = 95;
			array2[28] = 122;
			array2[28] = 91;
			array2[28] = 123;
			array2[28] = 98;
			array2[28] = 156;
			array2[29] = 146;
			array2[29] = 111;
			array2[29] = 6;
			array2[30] = 123;
			array2[30] = 161;
			array2[30] = 139;
			array2[31] = 100;
			array2[31] = 113;
			array2[31] = 168;
			array2[31] = 140;
			array2[31] = 110;
			array2[31] = 23;
			byte[] rgbKey = array2;
			byte[] array3 = new byte[16];
			array3[0] = 146;
			array3[0] = 140;
			array3[0] = 105;
			array3[0] = 170;
			array3[0] = 62;
			array3[1] = 173;
			array3[1] = 117;
			array3[1] = 168;
			array3[1] = 191;
			array3[1] = 124;
			array3[1] = 251;
			array3[2] = 238;
			array3[2] = 157;
			array3[2] = 164;
			array3[2] = 172;
			array3[3] = 110;
			array3[3] = 66;
			array3[3] = 72;
			array3[3] = 178;
			array3[3] = 138;
			array3[3] = 250;
			array3[4] = 151;
			array3[4] = 122;
			array3[4] = 35;
			array3[4] = 245;
			array3[5] = 66;
			array3[5] = 141;
			array3[5] = 192;
			array3[5] = 97;
			array3[5] = 89;
			array3[5] = 77;
			array3[6] = 189;
			array3[6] = 86;
			array3[6] = 130;
			array3[6] = 108;
			array3[7] = 88;
			array3[7] = 92;
			array3[7] = 200;
			array3[8] = 139;
			array3[8] = 31;
			array3[8] = 138;
			array3[8] = 118;
			array3[8] = 73;
			array3[9] = 86;
			array3[9] = 71;
			array3[9] = 130;
			array3[9] = 120;
			array3[9] = 87;
			array3[9] = 105;
			array3[10] = 28;
			array3[10] = 141;
			array3[10] = 167;
			array3[10] = 164;
			array3[10] = 161;
			array3[11] = 146;
			array3[11] = 180;
			array3[11] = 169;
			array3[11] = 133;
			array3[11] = 126;
			array3[12] = 108;
			array3[12] = 87;
			array3[12] = 174;
			array3[12] = 176;
			array3[12] = 28;
			array3[13] = 129;
			array3[13] = 90;
			array3[13] = 120;
			array3[13] = 153;
			array3[13] = 212;
			array3[14] = 152;
			array3[14] = 166;
			array3[14] = 30;
			array3[15] = 161;
			array3[15] = 122;
			array3[15] = 216;
			byte[] array4 = array3;
			byte[] publicKeyToken = typeof(Class1).Assembly.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length > 0)
			{
				array4[1] = publicKeyToken[0];
				array4[3] = publicKeyToken[1];
				array4[5] = publicKeyToken[2];
				array4[7] = publicKeyToken[3];
				array4[9] = publicKeyToken[4];
				array4[11] = publicKeyToken[5];
				array4[13] = publicKeyToken[6];
				array4[15] = publicKeyToken[7];
			}
			SymmetricAlgorithm symmetricAlgorithm = smethod_8();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, array4);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			byte_1 = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			binaryReader.Close();
		}
		if (byte_0.Length == 0)
		{
			byte_0 = smethod_14(smethod_13(typeof(Class1).Assembly).ToString());
		}
		int num = 0;
		try
		{
			num = BitConverter.ToInt32(new byte[4]
			{
				byte_1[int_3],
				byte_1[int_3 + 1],
				byte_1[int_3 + 2],
				byte_1[int_3 + 3]
			}, 0);
		}
		catch
		{
		}
		try
		{
			if (byte_0[num] == 128)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	static string smethod_11(int int_3)
	{
		if (byte_2.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class1).Assembly.GetManifestResourceStream("48837e94-b664-47cc-bc32-9659b39ea47a"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 87;
			array2[0] = 169;
			array2[0] = 116;
			array2[0] = 170;
			array2[0] = 206;
			array2[1] = 150;
			array2[1] = 124;
			array2[1] = 180;
			array2[1] = 118;
			array2[2] = 92;
			array2[2] = 116;
			array2[2] = 150;
			array2[2] = 20;
			array2[3] = 156;
			array2[3] = 169;
			array2[3] = 165;
			array2[3] = 138;
			array2[3] = 232;
			array2[4] = 99;
			array2[4] = 153;
			array2[4] = 164;
			array2[4] = 228;
			array2[4] = 172;
			array2[5] = 182;
			array2[5] = 146;
			array2[5] = 112;
			array2[5] = 39;
			array2[6] = 32;
			array2[6] = 92;
			array2[6] = 150;
			array2[7] = 154;
			array2[7] = 150;
			array2[7] = 58;
			array2[8] = 102;
			array2[8] = 117;
			array2[8] = 46;
			array2[8] = 92;
			array2[8] = 159;
			array2[8] = 22;
			array2[9] = 136;
			array2[9] = 94;
			array2[9] = 113;
			array2[9] = 127;
			array2[9] = 251;
			array2[10] = 131;
			array2[10] = 136;
			array2[10] = 46;
			array2[10] = 45;
			array2[10] = 48;
			array2[11] = 160;
			array2[11] = 134;
			array2[11] = 90;
			array2[11] = 148;
			array2[12] = 132;
			array2[12] = 144;
			array2[12] = 116;
			array2[12] = 9;
			array2[13] = 132;
			array2[13] = 84;
			array2[13] = 199;
			array2[13] = 68;
			array2[13] = 14;
			array2[14] = 148;
			array2[14] = 155;
			array2[14] = 92;
			array2[14] = 55;
			array2[15] = 131;
			array2[15] = 105;
			array2[15] = 126;
			array2[15] = 126;
			array2[15] = 163;
			array2[16] = 178;
			array2[16] = 168;
			array2[16] = 87;
			array2[16] = 124;
			array2[16] = 253;
			array2[17] = 85;
			array2[17] = 103;
			array2[17] = 116;
			array2[18] = 139;
			array2[18] = 112;
			array2[18] = 124;
			array2[18] = 246;
			array2[19] = 164;
			array2[19] = 5;
			array2[19] = 176;
			array2[19] = 154;
			array2[19] = 116;
			array2[19] = 184;
			array2[20] = 75;
			array2[20] = 116;
			array2[20] = 93;
			array2[20] = 98;
			array2[20] = 250;
			array2[21] = 109;
			array2[21] = 99;
			array2[21] = 193;
			array2[21] = 72;
			array2[21] = 126;
			array2[21] = 119;
			array2[22] = 103;
			array2[22] = 162;
			array2[22] = 123;
			array2[22] = 116;
			array2[22] = 65;
			array2[23] = 78;
			array2[23] = 102;
			array2[23] = 94;
			array2[23] = 104;
			array2[23] = 87;
			array2[24] = 176;
			array2[24] = 104;
			array2[24] = 172;
			array2[24] = 214;
			array2[25] = 120;
			array2[25] = 130;
			array2[25] = 138;
			array2[25] = 132;
			array2[25] = 133;
			array2[25] = 160;
			array2[26] = 138;
			array2[26] = 112;
			array2[26] = 156;
			array2[26] = 6;
			array2[27] = 88;
			array2[27] = 130;
			array2[27] = 112;
			array2[27] = 140;
			array2[28] = 78;
			array2[28] = 77;
			array2[28] = 8;
			array2[29] = 130;
			array2[29] = 216;
			array2[29] = 144;
			array2[29] = 135;
			array2[29] = 20;
			array2[30] = 134;
			array2[30] = 210;
			array2[30] = 164;
			array2[30] = 72;
			array2[30] = 150;
			array2[31] = 90;
			array2[31] = 21;
			array2[31] = 185;
			array2[31] = 23;
			array2[31] = 179;
			byte[] rgbKey = array2;
			byte[] array3 = new byte[16];
			array3[0] = 90;
			array3[0] = 125;
			array3[0] = 165;
			array3[0] = 194;
			array3[1] = 196;
			array3[1] = 119;
			array3[1] = 135;
			array3[1] = 186;
			array3[1] = 92;
			array3[1] = 152;
			array3[2] = 162;
			array3[2] = 162;
			array3[2] = 141;
			array3[2] = 96;
			array3[2] = 233;
			array3[2] = 108;
			array3[3] = 205;
			array3[3] = 98;
			array3[3] = 137;
			array3[3] = 120;
			array3[3] = 100;
			array3[4] = 228;
			array3[4] = 118;
			array3[4] = 106;
			array3[4] = 31;
			array3[5] = 130;
			array3[5] = 76;
			array3[5] = 23;
			array3[5] = 137;
			array3[5] = 152;
			array3[5] = 197;
			array3[6] = 218;
			array3[6] = 36;
			array3[6] = 151;
			array3[6] = 90;
			array3[6] = 132;
			array3[6] = 130;
			array3[7] = 137;
			array3[7] = 46;
			array3[7] = 122;
			array3[7] = 181;
			array3[8] = 100;
			array3[8] = 123;
			array3[8] = 158;
			array3[8] = 86;
			array3[8] = 0;
			array3[9] = 195;
			array3[9] = 112;
			array3[9] = 134;
			array3[9] = 144;
			array3[9] = 191;
			array3[10] = 111;
			array3[10] = 84;
			array3[10] = 39;
			array3[10] = 180;
			array3[11] = 139;
			array3[11] = 94;
			array3[11] = 174;
			array3[12] = 71;
			array3[12] = 114;
			array3[12] = 148;
			array3[12] = 28;
			array3[13] = 105;
			array3[13] = 127;
			array3[13] = 137;
			array3[13] = 121;
			array3[13] = 100;
			array3[13] = 99;
			array3[14] = 145;
			array3[14] = 140;
			array3[14] = 186;
			array3[15] = 25;
			array3[15] = 96;
			array3[15] = 222;
			byte[] array4 = array3;
			byte[] publicKeyToken = typeof(Class1).Assembly.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length > 0)
			{
				array4[1] = publicKeyToken[0];
				array4[3] = publicKeyToken[1];
				array4[5] = publicKeyToken[2];
				array4[7] = publicKeyToken[3];
				array4[9] = publicKeyToken[4];
				array4[11] = publicKeyToken[5];
				array4[13] = publicKeyToken[6];
				array4[15] = publicKeyToken[7];
			}
			SymmetricAlgorithm symmetricAlgorithm = smethod_8();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, array4);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			byte_2 = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			binaryReader.Close();
		}
		int num = BitConverter.ToInt32(byte_2, int_3);
		try
		{
			byte[] array5 = new byte[num];
			Array.Copy(byte_2, int_3 + 4, array5, 0, num);
			return Encoding.Unicode.GetString(array5, 0, array5.Length);
		}
		catch
		{
		}
		return "";
	}

	internal static string smethod_12(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[DllImport("kernel32.dll")]
	private static extern int VirtualProtect(IntPtr intptr_2, int int_3, int int_4, ref int int_5);

	internal static object smethod_13(Assembly assembly_0)
	{
		try
		{
			if (File.Exists(assembly_0.Location))
			{
				return assembly_0.Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_0.GetName().CodeBase!.ToString().Replace("file:///", "")))
			{
				return assembly_0.GetName().CodeBase!.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_0.GetType().GetProperty("Location")!.GetValue(assembly_0, new object[0])!.ToString()))
			{
				return assembly_0.GetType().GetProperty("Location")!.GetValue(assembly_0, new object[0])!.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32.dll")]
	private static extern int WriteProcessMemory(IntPtr intptr_2, IntPtr intptr_3, [In][Out] byte[] byte_4, uint uint_1, out IntPtr intptr_4);

	[DllImport("kernel32.dll")]
	private static extern int ReadProcessMemory(IntPtr intptr_2, IntPtr intptr_3, [In][Out] byte[] byte_4, uint uint_1, out IntPtr intptr_4);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint uint_1, int int_3, uint uint_2);

	[DllImport("kernel32.dll")]
	private static extern int CloseHandle(IntPtr intptr_2);

	private static byte[] smethod_14(string string_1)
	{
		using FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		long length = fileStream.Length;
		int num2 = (int)length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	private static byte[] smethod_15(byte[] byte_4)
	{
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = smethod_8();
		symmetricAlgorithm.Key = new byte[32]
		{
			70, 75, 63, 61, 165, 136, 18, 35, 19, 124,
			88, 97, 246, 171, 77, 253, 55, 128, 61, 56,
			220, 215, 174, 73, 65, 88, 237, 6, 123, 191,
			10, 234
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			189, 163, 240, 122, 42, 24, 164, 186, 164, 123,
			175, 68, 251, 241, 131, 109
		};
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_4, 0, byte_4.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	private byte[] method_0()
	{
		return null;
	}

	private byte[] method_1()
	{
		return null;
	}

	private byte[] method_2()
	{
		return null;
	}

	private byte[] method_3()
	{
		return null;
	}

	private byte[] method_4()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] method_5()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_6()
	{
		return null;
	}

	internal byte[] method_7()
	{
		return null;
	}

	internal byte[] method_8()
	{
		return null;
	}

	internal byte[] method_9()
	{
		return null;
	}

	internal byte[] method_10()
	{
		string text = "{11111-22222-60001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_11()
	{
		string text = "{11111-22222-60001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static string smethod_16(string string_1, string string_2)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(string_1);
		byte[] array = bytes;
		byte[] key = new byte[32]
		{
			82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
			51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
			34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
			1, 88
		};
		byte[] iV = smethod_9(Encoding.Unicode.GetBytes(string_2));
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = smethod_8();
		symmetricAlgorithm.Key = key;
		symmetricAlgorithm.IV = iV;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.Close();
		return Convert.ToBase64String(memoryStream.ToArray());
	}
}
