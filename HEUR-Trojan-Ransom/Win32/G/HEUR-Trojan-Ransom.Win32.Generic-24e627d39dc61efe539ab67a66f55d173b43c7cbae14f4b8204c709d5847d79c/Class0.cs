using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using bIt6aKMJmdN4envZf5;

internal class Class0
{
	internal class Attribute0 : Attribute
	{
		internal class Class1<T>
		{
			static Class1()
			{
				Class0.smethod_13();
			}
		}

		[Attribute0(typeof(meEHaGXoMCetp5S3b8_002FG5Hnap3Afwyh22oZFw_002FPajT0mKiH5EbJgAG5t<object>[]))]
		public Attribute0(object object_0)
		{
		}

		static Attribute0()
		{
			Class0.smethod_13();
		}
	}

	[Flags]
	private enum Enum0
	{

	}

	private static uint[] uint_0;

	private static byte[] byte_0;

	private static byte[] byte_1;

	private static byte[] byte_2;

	private static int int_0;

	private static long long_0;

	private static string[] string_0;

	private static byte[] byte_3;

	private static bool bool_0;

	private static int[] int_1;

	private static IntPtr intptr_0;

	private static bool bool_1;

	private static IntPtr intptr_1;

	private static bool bool_2;

	private static int int_2;

	static Class0()
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
		int_1 = new int[0];
		int_0 = 1;
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
		uint num = (uint)((448 - byte_4.Length * 8 % 512 + 512) % 512);
		if (num == 0)
		{
			num = 512u;
		}
		uint num2 = (uint)(byte_4.Length + num / 8u + 8L);
		ulong num3 = (ulong)(byte_4.Length * 8L);
		byte[] array2 = new byte[num2];
		for (int i = 0; i < byte_4.Length; i++)
		{
			array2[i] = byte_4[i];
		}
		array2[byte_4.Length] |= 128;
		for (int num4 = 8; num4 > 0; num4--)
		{
			array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFFuL);
		}
		uint num5 = (uint)(array2.Length * 8) / 32u;
		uint uint_ = 1732584193u;
		uint uint_2 = 4023233417u;
		uint uint_3 = 2562383102u;
		uint uint_4 = 271733878u;
		for (uint num6 = 0u; num6 < num5 / 16u; num6++)
		{
			uint num7 = num6 << 6;
			for (uint num8 = 0u; num8 < 61; num8 += 4)
			{
				array[num8 >> 2] = (uint)((array2[num7 + (num8 + 3)] << 24) | (array2[num7 + (num8 + 2)] << 16) | (array2[num7 + (num8 + 1)] << 8) | array2[num7 + num8]);
			}
			uint num9 = uint_;
			uint num10 = uint_2;
			uint num11 = uint_3;
			uint num12 = uint_4;
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
			uint_ += num9;
			uint_2 += num10;
			uint_3 += num11;
			uint_4 += num12;
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
		uint_1 = uint_2 + AthkFcJtv(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + uint_7[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + AthkFcJtv(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + uint_7[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + AthkFcJtv(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + uint_7[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, uint[] uint_7)
	{
		uint_1 = uint_2 + AthkFcJtv(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + uint_7[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static uint AthkFcJtv(uint uint_1, ushort ushort_0)
	{
		return (uint_1 >> 32 - ushort_0) | (uint_1 << (int)ushort_0);
	}

	internal static bool smethod_5()
	{
		if (!bool_0)
		{
			smethod_6();
			bool_0 = true;
		}
		return bool_1;
	}

	internal static void smethod_6()
	{
		try
		{
			bool_1 = (bool)typeof(RijndaelManaged).Assembly.GetType("System.Security.Cryptography.CryptoConfig", throwOnError: false)!.GetMethod("get_AllowOnlyFipsAlgorithms", BindingFlags.Static | BindingFlags.Public)!.Invoke(null, new object[0]);
		}
		catch
		{
			try
			{
				if ((int)typeof(RijndaelManaged).Assembly.GetType("System.Security.Cryptography.Utils", throwOnError: false)!.GetMethod("get_FipsAlgorithmPolicy", BindingFlags.Static | BindingFlags.NonPublic)!.Invoke(null, new object[0]) == 1)
				{
					bool_1 = true;
				}
			}
			catch
			{
			}
		}
	}

	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (smethod_5())
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

	internal static byte[] smethod_8(byte[] byte_4)
	{
		if (!smethod_5())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_4);
		}
		return smethod_0(byte_4);
	}

	static bool smethod_9(int int_3)
	{
		if (byte_1.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class0).Assembly.GetManifestResourceStream("b7db9b89-aa67-4952-ab3d-2045ea791d95"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 113;
			array2[0] = 90;
			array2[0] = 90;
			array2[0] = 132;
			array2[0] = 197;
			array2[1] = 127;
			array2[1] = 100;
			array2[1] = 162;
			array2[1] = 76;
			array2[2] = 111;
			array2[2] = 106;
			array2[2] = 102;
			array2[2] = 167;
			array2[2] = 123;
			array2[2] = 106;
			array2[3] = 109;
			array2[3] = 127;
			array2[3] = 125;
			array2[3] = 70;
			array2[4] = 86;
			array2[4] = 116;
			array2[4] = 210;
			array2[5] = 148;
			array2[5] = 119;
			array2[5] = 102;
			array2[5] = 127;
			array2[6] = 145;
			array2[6] = 90;
			array2[6] = 154;
			array2[6] = 88;
			array2[6] = 164;
			array2[6] = 234;
			array2[7] = 135;
			array2[7] = 166;
			array2[7] = 202;
			array2[7] = 205;
			array2[8] = 93;
			array2[8] = 50;
			array2[8] = 145;
			array2[8] = 152;
			array2[8] = 109;
			array2[8] = 224;
			array2[9] = 74;
			array2[9] = 136;
			array2[9] = 126;
			array2[9] = 60;
			array2[9] = 200;
			array2[10] = 99;
			array2[10] = 123;
			array2[10] = 57;
			array2[10] = 154;
			array2[10] = 100;
			array2[11] = 227;
			array2[11] = 183;
			array2[11] = 71;
			array2[12] = 164;
			array2[12] = 98;
			array2[12] = 128;
			array2[13] = 140;
			array2[13] = 141;
			array2[13] = 142;
			array2[13] = 166;
			array2[13] = 140;
			array2[13] = 200;
			array2[14] = 162;
			array2[14] = 107;
			array2[14] = 232;
			array2[15] = 24;
			array2[15] = 26;
			array2[15] = 150;
			array2[15] = 105;
			array2[16] = 107;
			array2[16] = 78;
			array2[16] = 126;
			array2[16] = 162;
			array2[17] = 34;
			array2[17] = 121;
			array2[17] = 125;
			array2[17] = 241;
			array2[18] = 194;
			array2[18] = 107;
			array2[18] = 161;
			array2[18] = 0;
			array2[19] = 177;
			array2[19] = 103;
			array2[19] = 181;
			array2[20] = 155;
			array2[20] = 133;
			array2[20] = 141;
			array2[20] = 171;
			array2[21] = 125;
			array2[21] = 92;
			array2[21] = 107;
			array2[21] = 102;
			array2[22] = 95;
			array2[22] = 85;
			array2[22] = 249;
			array2[23] = 152;
			array2[23] = 131;
			array2[23] = 214;
			array2[23] = 223;
			array2[24] = 111;
			array2[24] = 16;
			array2[24] = 167;
			array2[24] = 167;
			array2[24] = 13;
			array2[25] = 127;
			array2[25] = 65;
			array2[25] = 162;
			array2[25] = 68;
			array2[26] = 123;
			array2[26] = 58;
			array2[26] = 129;
			array2[26] = 107;
			array2[26] = 167;
			array2[26] = 208;
			array2[27] = 152;
			array2[27] = 155;
			array2[27] = 251;
			array2[28] = 118;
			array2[28] = 101;
			array2[28] = 137;
			array2[28] = 112;
			array2[28] = 121;
			array2[28] = 227;
			array2[29] = 197;
			array2[29] = 156;
			array2[29] = 96;
			array2[29] = 237;
			array2[30] = 142;
			array2[30] = 100;
			array2[30] = 176;
			array2[31] = 49;
			array2[31] = 124;
			array2[31] = 222;
			byte[] rgbKey = array2;
			byte[] array3 = new byte[16];
			array3[0] = 113;
			array3[0] = 90;
			array3[0] = 39;
			array3[1] = 124;
			array3[1] = 176;
			array3[1] = 246;
			array3[2] = 67;
			array3[2] = 123;
			array3[2] = 111;
			array3[2] = 106;
			array3[2] = 82;
			array3[2] = 62;
			array3[3] = 148;
			array3[3] = 145;
			array3[3] = 125;
			array3[4] = 48;
			array3[4] = 163;
			array3[4] = 169;
			array3[4] = 84;
			array3[5] = 92;
			array3[5] = 140;
			array3[5] = 92;
			array3[6] = 128;
			array3[6] = 116;
			array3[6] = 121;
			array3[7] = 112;
			array3[7] = 198;
			array3[7] = 88;
			array3[7] = 164;
			array3[7] = 166;
			array3[7] = 247;
			array3[8] = 178;
			array3[8] = 202;
			array3[8] = 21;
			array3[8] = 113;
			array3[8] = 126;
			array3[8] = 232;
			array3[9] = 212;
			array3[9] = 74;
			array3[9] = 120;
			array3[10] = 83;
			array3[10] = 138;
			array3[10] = 73;
			array3[11] = 126;
			array3[11] = 124;
			array3[11] = 186;
			array3[12] = 156;
			array3[12] = 31;
			array3[12] = 121;
			array3[12] = 186;
			array3[13] = 120;
			array3[13] = 162;
			array3[13] = 149;
			array3[14] = 183;
			array3[14] = 116;
			array3[14] = 213;
			array3[15] = 96;
			array3[15] = 140;
			array3[15] = 141;
			array3[15] = 100;
			byte[] array4 = array3;
			byte[] publicKeyToken = typeof(Class0).Assembly.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length != 0)
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
			SymmetricAlgorithm symmetricAlgorithm = smethod_7();
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
			byte_0 = smethod_15(smethod_14(typeof(Class0).Assembly).ToString());
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

	static string smethod_10(int int_3)
	{
		if (byte_2.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class0).Assembly.GetManifestResourceStream("af850e81-8956-4e82-9175-f5ce3522454c"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 149;
			array2[0] = 125;
			array2[0] = 119;
			array2[0] = 210;
			array2[0] = 85;
			array2[0] = 160;
			array2[1] = 140;
			array2[1] = 120;
			array2[1] = 152;
			array2[1] = 120;
			array2[1] = 110;
			array2[2] = 93;
			array2[2] = 98;
			array2[2] = 136;
			array2[2] = 112;
			array2[2] = 153;
			array2[3] = 88;
			array2[3] = 87;
			array2[3] = 27;
			array2[4] = 150;
			array2[4] = 180;
			array2[4] = 94;
			array2[4] = 156;
			array2[4] = 84;
			array2[4] = 102;
			array2[5] = 165;
			array2[5] = 137;
			array2[5] = 191;
			array2[5] = 106;
			array2[5] = 77;
			array2[6] = 166;
			array2[6] = 187;
			array2[6] = 143;
			array2[6] = 55;
			array2[7] = 120;
			array2[7] = 111;
			array2[7] = 103;
			array2[7] = 143;
			array2[7] = 142;
			array2[7] = 225;
			array2[8] = 184;
			array2[8] = 121;
			array2[8] = 170;
			array2[8] = 53;
			array2[8] = 191;
			array2[9] = 158;
			array2[9] = 96;
			array2[9] = 120;
			array2[9] = 238;
			array2[10] = 164;
			array2[10] = 110;
			array2[10] = 230;
			array2[10] = 47;
			array2[11] = 139;
			array2[11] = 113;
			array2[11] = 5;
			array2[12] = 155;
			array2[12] = 156;
			array2[12] = 16;
			array2[13] = 150;
			array2[13] = 43;
			array2[13] = 180;
			array2[13] = 80;
			array2[13] = 234;
			array2[14] = 108;
			array2[14] = 106;
			array2[14] = 30;
			array2[15] = 134;
			array2[15] = 154;
			array2[15] = 162;
			array2[15] = 124;
			array2[16] = 121;
			array2[16] = 120;
			array2[16] = 52;
			array2[17] = 87;
			array2[17] = 138;
			array2[17] = 74;
			array2[17] = 122;
			array2[17] = 91;
			array2[17] = 75;
			array2[18] = 6;
			array2[18] = 128;
			array2[18] = 115;
			array2[18] = 97;
			array2[18] = 147;
			array2[18] = 203;
			array2[19] = 134;
			array2[19] = 126;
			array2[19] = 53;
			array2[20] = 216;
			array2[20] = 138;
			array2[20] = 146;
			array2[20] = 97;
			array2[20] = 58;
			array2[21] = 162;
			array2[21] = 117;
			array2[21] = 217;
			array2[21] = 94;
			array2[21] = 114;
			array2[21] = 142;
			array2[22] = 146;
			array2[22] = 108;
			array2[22] = 121;
			array2[22] = 122;
			array2[22] = 179;
			array2[23] = 173;
			array2[23] = 130;
			array2[23] = 60;
			array2[23] = 118;
			array2[23] = 150;
			array2[23] = 30;
			array2[24] = 196;
			array2[24] = 148;
			array2[24] = 114;
			array2[24] = 131;
			array2[24] = 4;
			array2[25] = 141;
			array2[25] = 98;
			array2[25] = 224;
			array2[25] = 155;
			array2[26] = 52;
			array2[26] = 169;
			array2[26] = 37;
			array2[27] = 141;
			array2[27] = 166;
			array2[27] = 134;
			array2[28] = 87;
			array2[28] = 170;
			array2[28] = 173;
			array2[29] = 95;
			array2[29] = 70;
			array2[29] = 107;
			array2[29] = 186;
			array2[30] = 134;
			array2[30] = 88;
			array2[30] = 148;
			array2[30] = 140;
			array2[30] = 142;
			array2[30] = 242;
			array2[31] = 36;
			array2[31] = 145;
			array2[31] = 139;
			array2[31] = 126;
			array2[31] = 32;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 115;
			array4[0] = 150;
			array4[0] = 48;
			array4[0] = 61;
			array4[1] = 114;
			array4[1] = 151;
			array4[1] = 85;
			array4[1] = 143;
			array4[1] = 124;
			array4[1] = 7;
			array4[2] = 143;
			array4[2] = 114;
			array4[2] = 93;
			array4[2] = 196;
			array4[3] = 96;
			array4[3] = 166;
			array4[3] = 116;
			array4[3] = 103;
			array4[3] = 169;
			array4[3] = 201;
			array4[4] = 168;
			array4[4] = 75;
			array4[4] = 239;
			array4[5] = 146;
			array4[5] = 162;
			array4[5] = 146;
			array4[5] = 219;
			array4[5] = 225;
			array4[6] = 160;
			array4[6] = 127;
			array4[6] = 158;
			array4[6] = 88;
			array4[7] = 114;
			array4[7] = 165;
			array4[7] = 120;
			array4[7] = 92;
			array4[7] = 64;
			array4[7] = 60;
			array4[8] = 153;
			array4[8] = 154;
			array4[8] = 143;
			array4[8] = 21;
			array4[8] = 143;
			array4[8] = 63;
			array4[9] = 118;
			array4[9] = 108;
			array4[9] = 110;
			array4[9] = 54;
			array4[10] = 220;
			array4[10] = 128;
			array4[10] = 243;
			array4[11] = 157;
			array4[11] = 138;
			array4[11] = 132;
			array4[12] = 123;
			array4[12] = 155;
			array4[12] = 156;
			array4[12] = 166;
			array4[12] = 98;
			array4[12] = 130;
			array4[13] = 61;
			array4[13] = 132;
			array4[13] = 108;
			array4[13] = 42;
			array4[13] = 236;
			array4[14] = 114;
			array4[14] = 112;
			array4[14] = 83;
			array4[14] = 43;
			array4[14] = 245;
			array4[15] = 146;
			array4[15] = 98;
			array4[15] = 114;
			array4[15] = 74;
			array4[15] = 100;
			array4[15] = 20;
			byte[] array5 = array4;
			byte[] publicKeyToken = typeof(Class0).Assembly.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length != 0)
			{
				array5[1] = publicKeyToken[0];
				array5[3] = publicKeyToken[1];
				array5[5] = publicKeyToken[2];
				array5[7] = publicKeyToken[3];
				array5[9] = publicKeyToken[4];
				array5[11] = publicKeyToken[5];
				array5[13] = publicKeyToken[6];
				array5[15] = publicKeyToken[7];
			}
			for (int i = 0; i < array5.Length; i++)
			{
				array3[i] = (byte)(array3[i] ^ array5[i]);
			}
			if (int_3 == -1)
			{
				SymmetricAlgorithm symmetricAlgorithm = smethod_7();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				byte_2 = memoryStream.ToArray();
				memoryStream.Close();
				cryptoStream.Close();
				binaryReader.Close();
				array = byte_2;
			}
			int num = array.Length % 4;
			int num2 = array.Length / 4;
			byte[] array6 = new byte[array.Length];
			int num3 = array3.Length / 4;
			uint num4 = 0u;
			uint num5 = 0u;
			uint num6 = 0u;
			if (num > 0)
			{
				num2++;
			}
			uint num7 = 0u;
			for (int j = 0; j < num2; j++)
			{
				int num8 = j % num3;
				int num9 = j * 4;
				num7 = (uint)(num8 * 4);
				num5 = (uint)((array3[num7 + 3] << 24) | (array3[num7 + 2] << 16) | (array3[num7 + 1] << 8) | array3[num7]);
				uint num10 = 255u;
				int num11 = 0;
				if (j == num2 - 1 && num > 0)
				{
					num6 = 0u;
					num4 += num5;
					for (int k = 0; k < num; k++)
					{
						if (k > 0)
						{
							num6 <<= 8;
						}
						num6 |= array[^(1 + k)];
					}
				}
				else
				{
					num4 += num5;
					num7 = (uint)num9;
					num6 = (uint)((array[num7 + 3] << 24) | (array[num7 + 2] << 16) | (array[num7 + 1] << 8) | array[num7]);
				}
				uint num12 = num4;
				num4++;
				uint num13 = num12;
				uint num14 = num12;
				num14 ^= num14 << 7;
				num14 += 473299652;
				num14 ^= num14 << 6;
				num14 += 552115465;
				num14 ^= num14 >> 21;
				num14 += 849608662;
				num14 = 3897017104u - num14;
				num12 = num13 + (uint)(double)num14;
				num4 = num12;
				if (j == num2 - 1 && num > 0)
				{
					uint num15 = num4 ^ num6;
					for (int l = 0; l < num; l++)
					{
						if (l > 0)
						{
							num10 <<= 8;
							num11 += 8;
						}
						array6[num9 + l] = (byte)((num15 & num10) >> num11);
					}
				}
				else
				{
					uint num16 = num4 ^ num6;
					array6[num9] = (byte)(num16 & 0xFFu);
					array6[num9 + 1] = (byte)((num16 & 0xFF00) >> 8);
					array6[num9 + 2] = (byte)((num16 & 0xFF0000) >> 16);
					array6[num9 + 3] = (byte)((num16 & 0xFF000000u) >> 24);
				}
			}
			byte_2 = array6;
		}
		int num17 = BitConverter.ToInt32(byte_2, int_3);
		try
		{
			byte[] array7 = new byte[num17];
			Array.Copy(byte_2, int_3 + 4, array7, 0, num17);
			return Encoding.Unicode.GetString(array7, 0, array7.Length);
		}
		catch
		{
		}
		return "";
	}

	static string smethod_11(int int_3)
	{
		if (byte_3.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(typeof(Class0).Assembly.GetManifestResourceStream("af850e81-8956-4e82-9175-f5ce3522454c"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 149;
			array2[0] = 125;
			array2[0] = 119;
			array2[0] = 210;
			array2[0] = 85;
			array2[0] = 160;
			array2[1] = 140;
			array2[1] = 120;
			array2[1] = 152;
			array2[1] = 120;
			array2[1] = 110;
			array2[2] = 93;
			array2[2] = 98;
			array2[2] = 136;
			array2[2] = 112;
			array2[2] = 153;
			array2[3] = 88;
			array2[3] = 87;
			array2[3] = 27;
			array2[4] = 150;
			array2[4] = 180;
			array2[4] = 94;
			array2[4] = 156;
			array2[4] = 84;
			array2[4] = 102;
			array2[5] = 165;
			array2[5] = 137;
			array2[5] = 191;
			array2[5] = 106;
			array2[5] = 77;
			array2[6] = 166;
			array2[6] = 187;
			array2[6] = 143;
			array2[6] = 55;
			array2[7] = 120;
			array2[7] = 111;
			array2[7] = 103;
			array2[7] = 143;
			array2[7] = 142;
			array2[7] = 225;
			array2[8] = 184;
			array2[8] = 121;
			array2[8] = 170;
			array2[8] = 53;
			array2[8] = 191;
			array2[9] = 158;
			array2[9] = 96;
			array2[9] = 120;
			array2[9] = 238;
			array2[10] = 164;
			array2[10] = 110;
			array2[10] = 230;
			array2[10] = 47;
			array2[11] = 139;
			array2[11] = 113;
			array2[11] = 5;
			array2[12] = 155;
			array2[12] = 156;
			array2[12] = 16;
			array2[13] = 150;
			array2[13] = 43;
			array2[13] = 180;
			array2[13] = 80;
			array2[13] = 234;
			array2[14] = 108;
			array2[14] = 106;
			array2[14] = 30;
			array2[15] = 134;
			array2[15] = 154;
			array2[15] = 162;
			array2[15] = 124;
			array2[16] = 121;
			array2[16] = 120;
			array2[16] = 52;
			array2[17] = 87;
			array2[17] = 138;
			array2[17] = 74;
			array2[17] = 122;
			array2[17] = 91;
			array2[17] = 75;
			array2[18] = 6;
			array2[18] = 128;
			array2[18] = 115;
			array2[18] = 97;
			array2[18] = 147;
			array2[18] = 203;
			array2[19] = 134;
			array2[19] = 126;
			array2[19] = 53;
			array2[20] = 216;
			array2[20] = 138;
			array2[20] = 146;
			array2[20] = 97;
			array2[20] = 58;
			array2[21] = 162;
			array2[21] = 117;
			array2[21] = 217;
			array2[21] = 94;
			array2[21] = 114;
			array2[21] = 142;
			array2[22] = 146;
			array2[22] = 108;
			array2[22] = 121;
			array2[22] = 122;
			array2[22] = 179;
			array2[23] = 173;
			array2[23] = 130;
			array2[23] = 60;
			array2[23] = 118;
			array2[23] = 150;
			array2[23] = 30;
			array2[24] = 196;
			array2[24] = 148;
			array2[24] = 114;
			array2[24] = 131;
			array2[24] = 4;
			array2[25] = 141;
			array2[25] = 98;
			array2[25] = 224;
			array2[25] = 155;
			array2[26] = 52;
			array2[26] = 169;
			array2[26] = 37;
			array2[27] = 141;
			array2[27] = 166;
			array2[27] = 134;
			array2[28] = 87;
			array2[28] = 170;
			array2[28] = 173;
			array2[29] = 95;
			array2[29] = 70;
			array2[29] = 107;
			array2[29] = 186;
			array2[30] = 134;
			array2[30] = 88;
			array2[30] = 148;
			array2[30] = 140;
			array2[30] = 142;
			array2[30] = 242;
			array2[31] = 36;
			array2[31] = 145;
			array2[31] = 139;
			array2[31] = 126;
			array2[31] = 32;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 115;
			array4[0] = 150;
			array4[0] = 48;
			array4[0] = 61;
			array4[1] = 114;
			array4[1] = 151;
			array4[1] = 85;
			array4[1] = 143;
			array4[1] = 124;
			array4[1] = 7;
			array4[2] = 143;
			array4[2] = 114;
			array4[2] = 93;
			array4[2] = 196;
			array4[3] = 96;
			array4[3] = 166;
			array4[3] = 116;
			array4[3] = 103;
			array4[3] = 169;
			array4[3] = 201;
			array4[4] = 168;
			array4[4] = 75;
			array4[4] = 239;
			array4[5] = 146;
			array4[5] = 162;
			array4[5] = 146;
			array4[5] = 219;
			array4[5] = 225;
			array4[6] = 160;
			array4[6] = 127;
			array4[6] = 158;
			array4[6] = 88;
			array4[7] = 114;
			array4[7] = 165;
			array4[7] = 120;
			array4[7] = 92;
			array4[7] = 64;
			array4[7] = 60;
			array4[8] = 153;
			array4[8] = 154;
			array4[8] = 143;
			array4[8] = 21;
			array4[8] = 143;
			array4[8] = 63;
			array4[9] = 118;
			array4[9] = 108;
			array4[9] = 110;
			array4[9] = 54;
			array4[10] = 220;
			array4[10] = 128;
			array4[10] = 243;
			array4[11] = 157;
			array4[11] = 138;
			array4[11] = 132;
			array4[12] = 123;
			array4[12] = 155;
			array4[12] = 156;
			array4[12] = 166;
			array4[12] = 98;
			array4[12] = 130;
			array4[13] = 61;
			array4[13] = 132;
			array4[13] = 108;
			array4[13] = 42;
			array4[13] = 236;
			array4[14] = 114;
			array4[14] = 112;
			array4[14] = 83;
			array4[14] = 43;
			array4[14] = 245;
			array4[15] = 146;
			array4[15] = 98;
			array4[15] = 114;
			array4[15] = 74;
			array4[15] = 100;
			array4[15] = 20;
			byte[] array5 = array4;
			byte[] publicKeyToken = typeof(Class0).Assembly.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length != 0)
			{
				array5[1] = publicKeyToken[0];
				array5[3] = publicKeyToken[1];
				array5[5] = publicKeyToken[2];
				array5[7] = publicKeyToken[3];
				array5[9] = publicKeyToken[4];
				array5[11] = publicKeyToken[5];
				array5[13] = publicKeyToken[6];
				array5[15] = publicKeyToken[7];
			}
			for (int i = 0; i < array5.Length; i++)
			{
				array3[i] = (byte)(array3[i] ^ array5[i]);
			}
			if (int_3 == -1)
			{
				SymmetricAlgorithm symmetricAlgorithm = smethod_7();
				symmetricAlgorithm.Mode = CipherMode.CBC;
				ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
				MemoryStream memoryStream = new MemoryStream();
				CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				byte_3 = memoryStream.ToArray();
				if (byte_3.Length != 0)
				{
					string_0 = new string[byte_3.Length / 4 + 1];
					int_1 = new int[byte_3.Length / 4 + 1];
				}
				memoryStream.Close();
				cryptoStream.Close();
				binaryReader.Close();
				array = byte_3;
			}
			int num = array.Length % 4;
			int num2 = array.Length / 4;
			byte[] array6 = new byte[array.Length];
			int num3 = array3.Length / 4;
			uint num4 = 0u;
			uint num5 = 0u;
			uint num6 = 0u;
			if (num > 0)
			{
				num2++;
			}
			uint num7 = 0u;
			for (int j = 0; j < num2; j++)
			{
				int num8 = j % num3;
				int num9 = j * 4;
				num7 = (uint)(num8 * 4);
				num5 = (uint)((array3[num7 + 3] << 24) | (array3[num7 + 2] << 16) | (array3[num7 + 1] << 8) | array3[num7]);
				uint num10 = 255u;
				int num11 = 0;
				if (j == num2 - 1 && num > 0)
				{
					num6 = 0u;
					for (int k = 0; k < num; k++)
					{
						if (k > 0)
						{
							num6 <<= 8;
						}
						num6 |= array[^(1 + k)];
					}
					num4 += num5;
				}
				else
				{
					num7 = (uint)num9;
					num6 = (uint)((array[num7 + 3] << 24) | (array[num7 + 2] << 16) | (array[num7 + 1] << 8) | array[num7]);
					num4 += num5;
				}
				uint num12 = num4;
				uint num13 = num4;
				num13 ^= num13 << 7;
				num13 += 473299652;
				num13 ^= num13 << 6;
				num13 += 552115465;
				num13 ^= num13 >> 21;
				num13 += 849608662;
				num13 = 3897017104u - num13;
				num4 = num12 + (uint)(double)num13;
				if (j == num2 - 1 && num > 0)
				{
					uint num14 = num4 ^ num6;
					for (int l = 0; l < num; l++)
					{
						if (l > 0)
						{
							num10 <<= 8;
							num11 += 8;
						}
						array6[num9 + l] = (byte)((num14 & num10) >> num11);
					}
				}
				else
				{
					uint num15 = num4 ^ num6;
					array6[num9] = (byte)(num15 & 0xFFu);
					array6[num9 + 1] = (byte)((num15 & 0xFF00) >> 8);
					array6[num9 + 2] = (byte)((num15 & 0xFF0000) >> 16);
					array6[num9 + 3] = (byte)((num15 & 0xFF000000u) >> 24);
				}
			}
			byte_3 = array6;
			if (byte_3.Length != 0)
			{
				string_0 = new string[byte_3.Length / 4 + 1];
				int_1 = new int[byte_3.Length / 4 + 1];
			}
			Assembly assembly = typeof(Class0).Assembly;
			if (IntPtr.Size == 4)
			{
				int_2 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt32();
			}
			long_0 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt64();
		}
		int num16 = int_3 / 4;
		if (int_1[num16] > 0)
		{
			return string_0[int_1[num16]];
		}
		int num17 = BitConverter.ToInt32(byte_3, int_3);
		if (intptr_0 == IntPtr.Zero)
		{
			intptr_0 = OpenProcess(16u, 1, (uint)Process.GetCurrentProcess().Id);
		}
		byte[] array7 = new byte[4];
		if (IntPtr.Size == 4)
		{
			ReadProcessMemory(intptr_0, new IntPtr(int_2 + num17), array7, 4u, out intptr_1);
		}
		else
		{
			ReadProcessMemory(intptr_0, new IntPtr(long_0 + num17), array7, 4u, out intptr_1);
		}
		int num18 = BitConverter.ToInt32(array7, 0);
		array7 = new byte[num18];
		if (IntPtr.Size == 4)
		{
			ReadProcessMemory(intptr_0, new IntPtr(int_2 + num17 + 4), array7, Convert.ToUInt32(num18), out intptr_1);
		}
		else
		{
			ReadProcessMemory(intptr_0, new IntPtr(long_0 + num17 + 4L), array7, Convert.ToUInt32(num18), out intptr_1);
		}
		byte[] array8 = smethod_16(array7);
		string @string = Encoding.Unicode.GetString(array8, 0, array8.Length);
		int_1[num16] = int_0;
		string_0[int_0] = @string;
		int_0++;
		return @string;
	}

	internal static string smethod_12(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[DllImport("kernel32.dll")]
	private static extern int VirtualProtect(IntPtr intptr_2, int int_3, int int_4, ref int int_5);

	[Attribute0(typeof(meEHaGXoMCetp5S3b8_002FG5Hnap3Afwyh22oZFw_002FPajT0mKiH5EbJgAG5t<object>[]))]
	static void smethod_13()
	{
		if (bool_2)
		{
			return;
		}
		bool_2 = true;
		BinaryReader binaryReader = new BinaryReader(typeof(Class0).Assembly.GetManifestResourceStream("2f14830f-0ba6-4272-819d-9118df29fe3b"));
		binaryReader.BaseStream.Position = 0L;
		byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
		byte[] array2 = new byte[32];
		array2[0] = 213;
		array2[0] = 170;
		array2[0] = 30;
		array2[0] = 213;
		array2[1] = 17;
		array2[1] = 131;
		array2[1] = 148;
		array2[1] = 84;
		array2[1] = 160;
		array2[1] = 17;
		array2[2] = 254;
		array2[2] = 130;
		array2[2] = 60;
		array2[2] = 153;
		array2[2] = 108;
		array2[2] = 142;
		array2[2] = 254;
		array2[3] = 63;
		array2[3] = 206;
		array2[3] = 141;
		array2[3] = 115;
		array2[3] = 154;
		array2[3] = 140;
		array2[3] = 63;
		array2[4] = 165;
		array2[4] = 127;
		array2[4] = 114;
		array2[4] = 108;
		array2[4] = 137;
		array2[4] = 165;
		array2[5] = 186;
		array2[5] = 151;
		array2[5] = 118;
		array2[5] = 133;
		array2[5] = 186;
		array2[6] = 243;
		array2[6] = 116;
		array2[6] = 7;
		array2[6] = 136;
		array2[6] = 243;
		array2[7] = 137;
		array2[7] = 158;
		array2[7] = 229;
		array2[7] = 210;
		array2[7] = 65;
		array2[7] = 137;
		array2[8] = 45;
		array2[8] = 80;
		array2[8] = 173;
		array2[8] = 106;
		array2[8] = 160;
		array2[8] = 45;
		array2[9] = 254;
		array2[9] = 110;
		array2[9] = 150;
		array2[9] = 136;
		array2[9] = 254;
		array2[10] = 165;
		array2[10] = 171;
		array2[10] = 97;
		array2[10] = 106;
		array2[10] = 135;
		array2[10] = 165;
		array2[11] = 229;
		array2[11] = 160;
		array2[11] = 102;
		array2[11] = 166;
		array2[11] = 107;
		array2[11] = 229;
		array2[12] = 219;
		array2[12] = 89;
		array2[12] = 141;
		array2[12] = 131;
		array2[12] = 135;
		array2[12] = 219;
		array2[13] = 148;
		array2[13] = 134;
		array2[13] = 170;
		array2[13] = 148;
		array2[14] = 158;
		array2[14] = 21;
		array2[14] = 155;
		array2[14] = 88;
		array2[14] = 149;
		array2[14] = 26;
		array2[14] = 158;
		array2[15] = 182;
		array2[15] = 107;
		array2[15] = 102;
		array2[15] = 182;
		array2[16] = 0;
		array2[16] = 94;
		array2[16] = 51;
		array2[16] = 158;
		array2[16] = 0;
		array2[17] = 194;
		array2[17] = 96;
		array2[17] = 133;
		array2[17] = 146;
		array2[17] = 128;
		array2[17] = 194;
		array2[18] = 114;
		array2[18] = 160;
		array2[18] = 207;
		array2[18] = 128;
		array2[18] = 148;
		array2[18] = 151;
		array2[18] = 114;
		array2[19] = 126;
		array2[19] = 115;
		array2[19] = 137;
		array2[19] = 84;
		array2[19] = 105;
		array2[19] = 160;
		array2[19] = 126;
		array2[20] = 240;
		array2[20] = 149;
		array2[20] = 88;
		array2[20] = 147;
		array2[20] = 240;
		array2[21] = 202;
		array2[21] = 135;
		array2[21] = 136;
		array2[21] = 94;
		array2[21] = 202;
		array2[22] = 243;
		array2[22] = 126;
		array2[22] = 135;
		array2[22] = 95;
		array2[22] = 167;
		array2[22] = 118;
		array2[22] = 243;
		array2[23] = 76;
		array2[23] = 86;
		array2[23] = 125;
		array2[23] = 39;
		array2[23] = 96;
		array2[23] = 76;
		array2[24] = 243;
		array2[24] = 37;
		array2[24] = 88;
		array2[24] = 243;
		array2[25] = 54;
		array2[25] = 152;
		array2[25] = 70;
		array2[25] = 88;
		array2[25] = 163;
		array2[25] = 54;
		array2[26] = 214;
		array2[26] = 182;
		array2[26] = 159;
		array2[26] = 240;
		array2[26] = 214;
		array2[27] = 187;
		array2[27] = 120;
		array2[27] = 78;
		array2[27] = 89;
		array2[27] = 142;
		array2[27] = 187;
		array2[28] = 153;
		array2[28] = 106;
		array2[28] = 118;
		array2[28] = 126;
		array2[28] = 146;
		array2[28] = 117;
		array2[28] = 153;
		array2[29] = 122;
		array2[29] = 157;
		array2[29] = 34;
		array2[29] = 148;
		array2[29] = 122;
		array2[30] = 136;
		array2[30] = 150;
		array2[30] = 104;
		array2[30] = 136;
		array2[31] = 221;
		array2[31] = 157;
		array2[31] = 136;
		array2[31] = 154;
		array2[31] = 221;
		byte[] array3 = array2;
		byte[] array4 = new byte[16];
		array4[0] = 170;
		array4[0] = 30;
		array4[0] = 127;
		array4[1] = 163;
		array4[1] = 109;
		array4[1] = 46;
		array4[2] = 164;
		array4[2] = 84;
		array4[2] = 24;
		array4[2] = 121;
		array4[3] = 60;
		array4[3] = 132;
		array4[3] = 128;
		array4[3] = 158;
		array4[4] = 117;
		array4[4] = 194;
		array4[4] = 128;
		array4[5] = 114;
		array4[5] = 145;
		array4[5] = 161;
		array4[5] = 127;
		array4[5] = 129;
		array4[6] = 76;
		array4[6] = 140;
		array4[6] = 68;
		array4[6] = 103;
		array4[6] = 228;
		array4[7] = 133;
		array4[7] = 123;
		array4[7] = 112;
		array4[7] = 31;
		array4[8] = 92;
		array4[8] = 105;
		array4[8] = 158;
		array4[8] = 169;
		array4[8] = 102;
		array4[8] = 36;
		array4[9] = 114;
		array4[9] = 94;
		array4[9] = 222;
		array4[10] = 124;
		array4[10] = 152;
		array4[10] = 122;
		array4[10] = 98;
		array4[10] = 139;
		array4[10] = 75;
		array4[11] = 101;
		array4[11] = 96;
		array4[11] = 235;
		array4[12] = 102;
		array4[12] = 88;
		array4[12] = 132;
		array4[12] = 91;
		array4[12] = 140;
		array4[13] = 152;
		array4[13] = 217;
		array4[13] = 173;
		array4[13] = 168;
		array4[13] = 91;
		array4[13] = 179;
		array4[14] = 140;
		array4[14] = 162;
		array4[14] = 169;
		array4[15] = 215;
		array4[15] = 225;
		array4[15] = 207;
		byte[] array5 = array4;
		Array.Reverse((Array)array5);
		byte[] publicKeyToken = typeof(Class0).Assembly.GetName().GetPublicKeyToken();
		if (publicKeyToken != null && publicKeyToken.Length != 0)
		{
			array5[1] = publicKeyToken[0];
			array5[3] = publicKeyToken[1];
			array5[5] = publicKeyToken[2];
			array5[7] = publicKeyToken[3];
			array5[9] = publicKeyToken[4];
			array5[11] = publicKeyToken[5];
			array5[13] = publicKeyToken[6];
			array5[15] = publicKeyToken[7];
			Array.Clear(publicKeyToken, 0, publicKeyToken.Length);
		}
		for (int i = 0; i < array5.Length; i++)
		{
			array3[i] = (byte)(array3[i] ^ array5[i]);
		}
		byte[] array6 = array;
		int num = array6.Length % 4;
		int num2 = array6.Length / 4;
		byte[] array7 = new byte[array6.Length];
		int num3 = array3.Length / 4;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = 0u;
		for (int j = 0; j < num2; j++)
		{
			int num8 = j % num3;
			int num9 = j * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((array3[num7 + 3] << 24) | (array3[num7 + 2] << 16) | (array3[num7 + 1] << 8) | array3[num7]);
			uint num10 = 255u;
			int num11 = 0;
			if (j == num2 - 1 && num > 0)
			{
				num4 += num5;
				num6 = 0u;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num6 <<= 8;
					}
					num6 |= array6[^(1 + k)];
				}
			}
			else
			{
				num7 = (uint)num9;
				num4 += num5;
				num6 = (uint)((array6[num7 + 3] << 24) | (array6[num7 + 2] << 16) | (array6[num7 + 1] << 8) | array6[num7]);
			}
			num4 = num4;
			uint num12 = num4;
			uint num13 = num4;
			num13 ^= num13 << 7;
			num13 += 473299652;
			num13 ^= num13 << 6;
			num13 += 552115465;
			num13 ^= num13 >> 21;
			num13 += 849608662;
			num13 = 3897017104u - num13;
			num4 = num12 + (uint)(double)num13;
			if (j == num2 - 1 && num > 0)
			{
				uint num14 = num4 ^ num6;
				for (int l = 0; l < num; l++)
				{
					if (l > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array7[num9 + l] = (byte)((num14 & num10) >> num11);
				}
			}
			else
			{
				uint num15 = num4 ^ num6;
				array7[num9] = (byte)(num15 & 0xFFu);
				array7[num9 + 1] = (byte)((num15 & 0xFF00) >> 8);
				array7[num9 + 2] = (byte)((num15 & 0xFF0000) >> 16);
				array7[num9 + 3] = (byte)((num15 & 0xFF000000u) >> 24);
			}
		}
		Array.Clear(array5, 0, array5.Length);
		binaryReader.Close();
		binaryReader = new BinaryReader(new MemoryStream(array7));
		binaryReader.BaseStream.Position = 0L;
		IntPtr zero = IntPtr.Zero;
		Assembly assembly = typeof(Class0).Assembly;
		zero = OpenProcess(56u, 1, (uint)Process.GetCurrentProcess().Id);
		long_0 = Marshal.GetHINSTANCE(assembly.GetModules()[0]).ToInt64();
		IntPtr intptr_ = IntPtr.Zero;
		int int_ = 0;
		int num16 = binaryReader.ReadInt32();
		binaryReader.ReadInt32();
		for (int m = 0; m < num16; m++)
		{
			IntPtr intPtr = new IntPtr(long_0 + binaryReader.ReadInt32());
			VirtualProtect(intPtr, 4, 4, ref int_);
			if (IntPtr.Size == 4)
			{
				WriteProcessMemory(zero, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4u, out intptr_);
			}
			else
			{
				WriteProcessMemory(zero, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4u, out intptr_);
			}
			VirtualProtect(intPtr, 4, int_, ref int_);
		}
		try
		{
			while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length - 1L)
			{
				int num17 = binaryReader.ReadInt32();
				IntPtr intptr_2 = new IntPtr(long_0 + num17);
				int num18 = binaryReader.ReadInt32();
				VirtualProtect(intptr_2, num18 * 4, 4, ref int_);
				for (int n = 0; n < num18; n++)
				{
					Marshal.WriteInt32(new IntPtr(intptr_2.ToInt64() + n * 4), binaryReader.ReadInt32());
				}
				VirtualProtect(intptr_2, num18 * 4, int_, ref int_);
			}
			CloseHandle(zero);
		}
		catch
		{
		}
	}

	internal static object smethod_14(Assembly assembly_0)
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

	private static byte[] smethod_15(string string_1)
	{
		using FileStream fileStream = new FileStream(string_1, FileMode.Open, FileAccess.Read, FileShare.Read);
		int num = 0;
		int num2 = (int)fileStream.Length;
		byte[] array = new byte[num2];
		while (num2 > 0)
		{
			int num3 = fileStream.Read(array, num, num2);
			num += num3;
			num2 -= num3;
		}
		return array;
	}

	private static byte[] smethod_16(byte[] byte_4)
	{
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = smethod_7();
		symmetricAlgorithm.Key = new byte[32]
		{
			148, 244, 126, 39, 96, 242, 156, 222, 188, 200,
			242, 154, 136, 26, 56, 149, 234, 212, 36, 139,
			102, 74, 177, 153, 109, 18, 10, 206, 160, 124,
			19, 193
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			13, 106, 12, 154, 217, 48, 214, 72, 186, 168,
			12, 204, 254, 114, 7, 162
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

	private byte[] TvsjaYtYa()
	{
		return null;
	}

	private byte[] method_4()
	{
		return null;
	}

	internal byte[] method_5()
	{
		_ = "{11111-22222-40001-00001}".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_6()
	{
		_ = "{11111-22222-40001-00002}".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_7()
	{
		_ = "{11111-22222-50001-00001}".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] rPoAiZfwV()
	{
		_ = "{11111-22222-50001-00002}".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_8()
	{
		_ = "{11111-22222-60001-00001}".Length;
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_9()
	{
		_ = "{11111-22222-60001-00002}".Length;
		return new byte[2] { 1, 2 };
	}

	internal static string smethod_17(string string_1, string string_2)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(string_1);
		byte[] key = new byte[32]
		{
			82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
			51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
			34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
			1, 88
		};
		byte[] iV = smethod_8(Encoding.Unicode.GetBytes(string_2));
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = smethod_7();
		symmetricAlgorithm.Key = key;
		symmetricAlgorithm.IV = iV;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.Close();
		return Convert.ToBase64String(memoryStream.ToArray());
	}
}
