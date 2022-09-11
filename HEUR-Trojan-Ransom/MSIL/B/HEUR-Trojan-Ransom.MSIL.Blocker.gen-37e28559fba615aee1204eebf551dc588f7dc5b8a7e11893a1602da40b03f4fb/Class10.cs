using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal class Class10
{
	internal class Attribute1 : Attribute
	{
		internal class Class11<zKZu8DG7um8vNBCUCx>
		{
			public Class11()
			{
				Class8.t3hvLuccnmfIO();
				base._002Ector();
			}
		}

		[Attribute1(typeof(Class11<object>[]))]
		public Attribute1(object object_0)
		{
			Class8.t3hvLuccnmfIO();
			base._002Ector();
		}
	}

	internal class Class12
	{
		[Attribute1(typeof(Attribute1.Class11<object>[]))]
		internal static void ce4DmfsmSrOT856tDgfrkMb()
		{
			if (smethod_0(Convert.ToBase64String(assembly_0.GetName().GetPublicKeyToken()), " ") != "  ")
			{
				while (true)
				{
					ce4DmfsmSrOT856tDgfrkMb();
				}
			}
		}

		[Attribute1(typeof(Attribute1.Class11<object>[]))]
		internal static string smethod_0(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] key = new byte[32]
			{
				82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
				51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
				34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
				1, 88
			};
			byte[] iV = smethod_9(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = smethod_7();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		public Class12()
		{
			Class8.t3hvLuccnmfIO();
			base._002Ector();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint Delegate3(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Delegate4();

	internal struct Struct4
	{
		internal bool bool_0;

		internal byte[] byte_0;
	}

	[Flags]
	private enum Enum0
	{

	}

	private static int int_0;

	private static long long_0;

	private static int int_1;

	private static string[] string_0;

	internal static Delegate3 delegate3_0;

	private static int int_2;

	private static IntPtr intptr_0;

	private static bool bool_0;

	private static bool bool_1;

	internal static Hashtable hashtable_0;

	private static uint[] uint_0;

	private static int int_3;

	private static byte[] byte_0;

	private static bool bool_2;

	private static int[] int_4;

	private static long long_1;

	private static IntPtr intptr_1;

	private static byte[] byte_1;

	internal static Delegate3 delegate3_1;

	private static bool bool_3;

	private static SortedList sortedList_0;

	private static bool bool_4;

	private static byte[] byte_2;

	private static Assembly assembly_0;

	[Attribute1(typeof(Attribute1.Class11<object>[]))]
	private static bool bool_5;

	private static IntPtr intptr_2;

	private static byte[] CgfEuafQys;

	static Class10()
	{
		assembly_0 = typeof(Class10).Assembly;
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
		bool_4 = false;
		bool_0 = false;
		byte_0 = new byte[0];
		byte_1 = new byte[0];
		byte_2 = new byte[0];
		CgfEuafQys = new byte[0];
		intptr_2 = IntPtr.Zero;
		intptr_1 = IntPtr.Zero;
		string_0 = new string[0];
		int_4 = new int[0];
		int_2 = 1;
		bool_2 = false;
		sortedList_0 = new SortedList();
		int_0 = 0;
		long_1 = 0L;
		delegate3_0 = null;
		delegate3_1 = null;
		long_0 = 0L;
		int_1 = 0;
		bool_1 = false;
		bool_3 = false;
		int_3 = 0;
		intptr_0 = IntPtr.Zero;
		bool_5 = false;
		hashtable_0 = new Hashtable();
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void G1EvLuczIotMe()
	{
	}

	internal static byte[] smethod_0(object object_0)
	{
		uint[] array = new uint[16];
		int num = 448 - ((Array)object_0).Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(((Array)object_0).Length + num2 / 8u + 8L);
		ulong num4 = (ulong)(((Array)object_0).Length * 8L);
		byte[] array2 = new byte[num3];
		for (int i = 0; i < ((Array)object_0).Length; i++)
		{
			array2[i] = ((byte[])object_0)[i];
		}
		array2[((Array)object_0).Length] |= 128;
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

	private static void smethod_1(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_0)
	{
		uint_1 = uint_2 + smethod_5(uint_1 + ((uint_2 & uint_3) | (~uint_2 & uint_4)) + ((uint[])object_0)[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static void smethod_2(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_0)
	{
		uint_1 = uint_2 + smethod_5(uint_1 + ((uint_2 & uint_4) | (uint_3 & ~uint_4)) + ((uint[])object_0)[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static void smethod_3(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_0)
	{
		uint_1 = uint_2 + smethod_5(uint_1 + (uint_2 ^ uint_3 ^ uint_4) + ((uint[])object_0)[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static void smethod_4(ref uint uint_1, uint uint_2, uint uint_3, uint uint_4, uint uint_5, ushort ushort_0, uint uint_6, object object_0)
	{
		uint_1 = uint_2 + smethod_5(uint_1 + (uint_3 ^ (uint_2 | ~uint_4)) + ((uint[])object_0)[uint_5] + uint_0[uint_6 - 1], ushort_0);
	}

	private static uint smethod_5(uint uint_1, ushort ushort_0)
	{
		return (uint_1 >> 32 - ushort_0) | (uint_1 << (int)ushort_0);
	}

	internal static bool smethod_6()
	{
		if (!bool_4)
		{
			smethod_8();
			bool_4 = true;
		}
		return bool_0;
	}

	internal static SymmetricAlgorithm smethod_7()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (smethod_6())
		{
			try
			{
				return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider")!.Unwrap();
			}
			catch
			{
				return new RijndaelManaged();
			}
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider")!.Unwrap();
		}
	}

	internal static void smethod_8()
	{
		try
		{
			new RijndaelManaged();
			bool_0 = false;
		}
		catch
		{
			bool_0 = true;
		}
	}

	internal static byte[] smethod_9(byte[] byte_3)
	{
		if (!smethod_6())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_3);
		}
		return smethod_0(byte_3);
	}

	[Attribute1(typeof(Attribute1.Class11<object>[]))]
	internal static bool smethod_10(int int_5)
	{
		if (byte_1.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(assembly_0.GetManifestResourceStream("RlruYNsTT9RKqlPnse.EDPmHD42U4A93DoFms"));
			binaryReader.BaseStream.Position = 0L;
			RSACryptoServiceProvider.UseMachineKeyStore = true;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			byte[] array2 = new byte[32];
			array2[0] = 103;
			array2[0] = 154;
			array2[0] = 37;
			array2[1] = 27;
			array2[1] = 133;
			array2[1] = 169;
			array2[1] = 79;
			array2[2] = 125;
			array2[2] = 84;
			array2[2] = 99;
			array2[2] = 36;
			array2[3] = 100;
			array2[3] = 136;
			array2[3] = 156;
			array2[3] = 8;
			array2[4] = 150;
			array2[4] = 119;
			array2[4] = 227;
			array2[4] = 219;
			array2[5] = 82;
			array2[5] = 157;
			array2[5] = 95;
			array2[5] = 137;
			array2[6] = 90;
			array2[6] = 122;
			array2[6] = 105;
			array2[6] = 3;
			array2[7] = 142;
			array2[7] = 140;
			array2[7] = 109;
			array2[7] = 88;
			array2[7] = 94;
			array2[7] = 177;
			array2[8] = 171;
			array2[8] = 111;
			array2[8] = 122;
			array2[9] = 112;
			array2[9] = 152;
			array2[9] = 112;
			array2[9] = 95;
			array2[9] = 94;
			array2[9] = 89;
			array2[10] = 146;
			array2[10] = 112;
			array2[10] = 101;
			array2[10] = 67;
			array2[11] = 105;
			array2[11] = 102;
			array2[11] = 169;
			array2[11] = 123;
			array2[11] = 101;
			array2[11] = 193;
			array2[12] = 106;
			array2[12] = 212;
			array2[12] = 44;
			array2[13] = 113;
			array2[13] = 117;
			array2[13] = 123;
			array2[13] = 248;
			array2[14] = 88;
			array2[14] = 22;
			array2[14] = 156;
			array2[14] = 133;
			array2[14] = 183;
			array2[14] = 46;
			array2[15] = 120;
			array2[15] = 122;
			array2[15] = 140;
			array2[15] = 204;
			array2[16] = 110;
			array2[16] = 105;
			array2[16] = 139;
			array2[16] = 169;
			array2[16] = 130;
			array2[16] = 160;
			array2[17] = 146;
			array2[17] = 130;
			array2[17] = 107;
			array2[17] = 59;
			array2[18] = 139;
			array2[18] = 154;
			array2[18] = 67;
			array2[18] = 88;
			array2[18] = 82;
			array2[19] = 112;
			array2[19] = 91;
			array2[19] = 89;
			array2[19] = 43;
			array2[20] = 12;
			array2[20] = 150;
			array2[20] = 204;
			array2[21] = 102;
			array2[21] = 102;
			array2[21] = 227;
			array2[22] = 73;
			array2[22] = 160;
			array2[22] = 138;
			array2[22] = 89;
			array2[22] = 28;
			array2[23] = 127;
			array2[23] = 112;
			array2[23] = 128;
			array2[24] = 132;
			array2[24] = 153;
			array2[24] = 142;
			array2[24] = 127;
			array2[24] = 148;
			array2[24] = 171;
			array2[25] = 98;
			array2[25] = 94;
			array2[25] = 113;
			array2[25] = 54;
			array2[25] = 120;
			array2[25] = 236;
			array2[26] = 110;
			array2[26] = 98;
			array2[26] = 3;
			array2[27] = 162;
			array2[27] = 67;
			array2[27] = 164;
			array2[27] = 133;
			array2[27] = 184;
			array2[28] = 156;
			array2[28] = 112;
			array2[28] = 123;
			array2[28] = 204;
			array2[29] = 111;
			array2[29] = 108;
			array2[29] = 98;
			array2[29] = 105;
			array2[29] = 14;
			array2[30] = 156;
			array2[30] = 88;
			array2[30] = 170;
			array2[30] = 164;
			array2[30] = 163;
			array2[30] = 118;
			array2[31] = 121;
			array2[31] = 104;
			array2[31] = 131;
			array2[31] = 196;
			byte[] rgbKey = array2;
			byte[] array3 = new byte[16];
			array3[0] = 115;
			array3[0] = 112;
			array3[0] = 93;
			array3[0] = 85;
			array3[0] = 206;
			array3[0] = 232;
			array3[1] = 114;
			array3[1] = 120;
			array3[1] = 138;
			array3[2] = 232;
			array3[2] = 181;
			array3[2] = 204;
			array3[3] = 140;
			array3[3] = 84;
			array3[3] = 45;
			array3[4] = 121;
			array3[4] = 69;
			array3[4] = 142;
			array3[4] = 177;
			array3[5] = 146;
			array3[5] = 94;
			array3[5] = 59;
			array3[6] = 162;
			array3[6] = 96;
			array3[6] = 88;
			array3[6] = 165;
			array3[6] = 13;
			array3[7] = 140;
			array3[7] = 189;
			array3[7] = 108;
			array3[7] = 134;
			array3[8] = 151;
			array3[8] = 111;
			array3[8] = 142;
			array3[8] = 126;
			array3[8] = 83;
			array3[8] = 115;
			array3[9] = 150;
			array3[9] = 118;
			array3[9] = 168;
			array3[9] = 101;
			array3[9] = 132;
			array3[9] = 106;
			array3[10] = 115;
			array3[10] = 138;
			array3[10] = 76;
			array3[10] = 246;
			array3[11] = 166;
			array3[11] = 104;
			array3[11] = 75;
			array3[11] = 175;
			array3[12] = 149;
			array3[12] = 151;
			array3[12] = 94;
			array3[12] = 77;
			array3[13] = 93;
			array3[13] = 74;
			array3[13] = 63;
			array3[13] = 55;
			array3[14] = 144;
			array3[14] = 114;
			array3[14] = 125;
			array3[14] = 109;
			array3[14] = 133;
			array3[14] = 231;
			array3[15] = 104;
			array3[15] = 85;
			array3[15] = 145;
			array3[15] = 161;
			array3[15] = 173;
			array3[15] = 94;
			byte[] array4 = array3;
			byte[] publicKeyToken = assembly_0.GetName().GetPublicKeyToken();
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
			byte_0 = smethod_18(smethod_17(assembly_0).ToString());
		}
		int num = 0;
		try
		{
			num = BitConverter.ToInt32(new byte[4]
			{
				byte_1[int_5],
				byte_1[int_5 + 1],
				byte_1[int_5 + 2],
				byte_1[int_5 + 3]
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

	[Attribute1(typeof(Attribute1.Class11<object>[]))]
	internal static string smethod_11(int int_5)
	{
		if (byte_2.Length == 0)
		{
			BinaryReader binaryReader = new BinaryReader(assembly_0.GetManifestResourceStream("bIkvYoU5gNE99NXJob.29rqUUA1knOXMZ3I81"));
			binaryReader.BaseStream.Position = 0L;
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			binaryReader.Close();
			byte[] array2 = new byte[32];
			array2[0] = 152;
			array2[0] = 120;
			array2[0] = 169;
			array2[0] = 110;
			array2[0] = 218;
			array2[1] = 152;
			array2[1] = 150;
			array2[1] = 119;
			array2[1] = 118;
			array2[2] = 112;
			array2[2] = 160;
			array2[2] = 92;
			array2[2] = 161;
			array2[2] = 69;
			array2[2] = 223;
			array2[3] = 124;
			array2[3] = 135;
			array2[3] = 116;
			array2[3] = 151;
			array2[3] = 134;
			array2[3] = 243;
			array2[4] = 131;
			array2[4] = 88;
			array2[4] = 233;
			array2[5] = 157;
			array2[5] = 101;
			array2[5] = 97;
			array2[5] = 135;
			array2[5] = 249;
			array2[6] = 205;
			array2[6] = 189;
			array2[6] = 117;
			array2[6] = 117;
			array2[6] = 20;
			array2[7] = 139;
			array2[7] = 133;
			array2[7] = 153;
			array2[7] = 154;
			array2[7] = 81;
			array2[7] = 240;
			array2[8] = 122;
			array2[8] = 140;
			array2[8] = 139;
			array2[9] = 142;
			array2[9] = 96;
			array2[9] = 137;
			array2[9] = 148;
			array2[9] = 38;
			array2[10] = 118;
			array2[10] = 158;
			array2[10] = 98;
			array2[10] = 122;
			array2[10] = 87;
			array2[11] = 152;
			array2[11] = 103;
			array2[11] = 208;
			array2[11] = 91;
			array2[11] = 102;
			array2[11] = 31;
			array2[12] = 128;
			array2[12] = 80;
			array2[12] = 154;
			array2[12] = 200;
			array2[12] = 105;
			array2[12] = 97;
			array2[13] = 207;
			array2[13] = 170;
			array2[13] = 81;
			array2[13] = 191;
			array2[13] = 210;
			array2[14] = 225;
			array2[14] = 104;
			array2[14] = 113;
			array2[14] = 88;
			array2[14] = 191;
			array2[14] = 1;
			array2[15] = 103;
			array2[15] = 53;
			array2[15] = 42;
			array2[16] = 35;
			array2[16] = 146;
			array2[16] = 117;
			array2[16] = 85;
			array2[17] = 142;
			array2[17] = 117;
			array2[17] = 144;
			array2[17] = 191;
			array2[18] = 123;
			array2[18] = 162;
			array2[18] = 87;
			array2[18] = 128;
			array2[18] = 60;
			array2[19] = 96;
			array2[19] = 80;
			array2[19] = 167;
			array2[19] = 170;
			array2[19] = 122;
			array2[19] = 247;
			array2[20] = 133;
			array2[20] = 154;
			array2[20] = 16;
			array2[21] = 162;
			array2[21] = 177;
			array2[21] = 84;
			array2[21] = 208;
			array2[22] = 131;
			array2[22] = 150;
			array2[22] = 97;
			array2[22] = 218;
			array2[23] = 41;
			array2[23] = 92;
			array2[23] = 123;
			array2[23] = 52;
			array2[23] = 176;
			array2[24] = 130;
			array2[24] = 50;
			array2[24] = 125;
			array2[24] = 54;
			array2[24] = 115;
			array2[25] = 21;
			array2[25] = 101;
			array2[25] = 199;
			array2[26] = 58;
			array2[26] = 112;
			array2[26] = 144;
			array2[26] = 95;
			array2[26] = 158;
			array2[26] = 52;
			array2[27] = 104;
			array2[27] = 99;
			array2[27] = 30;
			array2[27] = 96;
			array2[27] = 126;
			array2[27] = 234;
			array2[28] = 61;
			array2[28] = 85;
			array2[28] = 133;
			array2[28] = 129;
			array2[28] = 180;
			array2[29] = 94;
			array2[29] = 65;
			array2[29] = 140;
			array2[29] = 78;
			array2[29] = 208;
			array2[30] = 113;
			array2[30] = 113;
			array2[30] = 127;
			array2[31] = 73;
			array2[31] = 120;
			array2[31] = 136;
			array2[31] = 113;
			array2[31] = 196;
			array2[31] = 96;
			byte[] array3 = array2;
			byte[] array4 = new byte[16];
			array4[0] = 152;
			array4[0] = 155;
			array4[0] = 109;
			array4[0] = 151;
			array4[1] = 110;
			array4[1] = 152;
			array4[1] = 176;
			array4[1] = 144;
			array4[1] = 119;
			array4[1] = 96;
			array4[2] = 132;
			array4[2] = 69;
			array4[2] = 91;
			array4[2] = 252;
			array4[3] = 146;
			array4[3] = 125;
			array4[3] = 130;
			array4[3] = 64;
			array4[3] = 10;
			array4[4] = 60;
			array4[4] = 116;
			array4[4] = 162;
			array4[4] = 101;
			array4[4] = 130;
			array4[4] = 165;
			array4[5] = 135;
			array4[5] = 180;
			array4[5] = 219;
			array4[6] = 159;
			array4[6] = 154;
			array4[6] = 117;
			array4[6] = 45;
			array4[7] = 98;
			array4[7] = 106;
			array4[7] = 35;
			array4[8] = 154;
			array4[8] = 135;
			array4[8] = 125;
			array4[8] = 122;
			array4[8] = 140;
			array4[8] = 133;
			array4[9] = 128;
			array4[9] = 134;
			array4[9] = 148;
			array4[9] = 154;
			array4[9] = 115;
			array4[9] = 75;
			array4[10] = 151;
			array4[10] = 32;
			array4[10] = 59;
			array4[11] = 182;
			array4[11] = 147;
			array4[11] = 91;
			array4[11] = 190;
			array4[12] = 176;
			array4[12] = 128;
			array4[12] = 80;
			array4[12] = 154;
			array4[12] = 200;
			array4[12] = 236;
			array4[13] = 96;
			array4[13] = 165;
			array4[13] = 126;
			array4[13] = 94;
			array4[14] = 81;
			array4[14] = 191;
			array4[14] = 129;
			array4[14] = 104;
			array4[14] = 113;
			array4[14] = 6;
			array4[15] = 113;
			array4[15] = 164;
			array4[15] = 49;
			array4[15] = 131;
			byte[] array5 = array4;
			Array.Reverse((Array)array5);
			byte[] publicKeyToken = assembly_0.GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length > 0)
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
			if (int_5 == -1)
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
				num4 = 0u;
				uint num13 = num12;
				uint num14 = num12;
				num14 ^= num14 << 25;
				num14 += 436136944;
				num14 ^= num14 >> 5;
				num14 += 2400072875u;
				num14 ^= num14 << 3;
				num14 += 172139080;
				num14 = 2701521061u + num14;
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
		int count = BitConverter.ToInt32(byte_2, int_5);
		try
		{
			return Encoding.Unicode.GetString(byte_2, int_5 + 4, count);
		}
		catch
		{
		}
		return "";
	}

	[Attribute1(typeof(Attribute1.Class11<object>[]))]
	internal static string smethod_12(string string_1)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_1);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[DllImport("kernel32.dll")]
	private static extern void RtlZeroMemory(IntPtr intptr_3, uint uint_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int VirtualProtect(ref IntPtr intptr_3, int int_5, int int_6, ref int int_7);

	[DllImport("kernel32.dll")]
	public static extern IntPtr FindResource(IntPtr intptr_3, string string_1, uint uint_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr VirtualAlloc(IntPtr intptr_3, uint uint_1, uint uint_2, uint uint_3);

	internal static uint smethod_13(IntPtr intptr_3, IntPtr intptr_4, IntPtr intptr_5, [MarshalAs(UnmanagedType.U4)] uint uint_1, IntPtr intptr_6, ref uint uint_2)
	{
		long num = 0L;
		num = ((IntPtr.Size != 4) ? Marshal.ReadInt64(intptr_5, IntPtr.Size * 2) : Marshal.ReadInt32(intptr_5, IntPtr.Size * 2));
		object obj = hashtable_0[num];
		if (obj != null)
		{
			Struct4 @struct = (Struct4)obj;
			IntPtr intPtr = Marshal.AllocCoTaskMem(@struct.byte_0.Length);
			Marshal.Copy(@struct.byte_0, 0, intPtr, @struct.byte_0.Length);
			if (@struct.bool_0)
			{
				intptr_6 = intPtr;
				uint_2 = (uint)@struct.byte_0.Length;
				VirtualProtect_1(intptr_6, @struct.byte_0.Length, 64, ref int_3);
				return 0u;
			}
			Marshal.WriteIntPtr(intptr_5, IntPtr.Size * 2, intPtr);
			Marshal.WriteInt32(intptr_5, IntPtr.Size * 3, @struct.byte_0.Length);
			uint result = 0u;
			if (uint_1 == 216669565 && !bool_5)
			{
				bool_5 = true;
			}
			else
			{
				result = delegate3_0(intptr_3, intptr_4, intptr_5, uint_1, intptr_6, ref uint_2);
			}
			return result;
		}
		return delegate3_0(intptr_3, intptr_4, intptr_5, uint_1, intptr_6, ref uint_2);
	}

	private static void smethod_14()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate smethod_15(IntPtr intptr_3, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		})!.Invoke(null, new object[2] { intptr_3, type_0 });
	}

	internal unsafe static void smethod_16()
	{
		if (bool_2)
		{
			return;
		}
		bool_2 = true;
		long num = 0L;
		Marshal.ReadIntPtr(new IntPtr(&num), 0);
		Marshal.ReadInt32(new IntPtr(&num), 0);
		Marshal.ReadInt64(new IntPtr(&num), 0);
		Marshal.WriteIntPtr(new IntPtr(&num), 0, IntPtr.Zero);
		Marshal.WriteInt32(new IntPtr(&num), 0, 0);
		Marshal.WriteInt64(new IntPtr(&num), 0, 0L);
		byte[] source = new byte[1];
		Marshal.Copy(source, 0, Marshal.AllocCoTaskMem(8), 1);
		smethod_14();
		BinaryReader binaryReader = new BinaryReader(assembly_0.GetManifestResourceStream("adlgr4QNfZiNP4N9xj.EkTQxvETyUKWDtOhxK"));
		binaryReader.BaseStream.Position = 0L;
		byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
		byte[] array2 = new byte[32];
		array2[0] = 119;
		array2[0] = 129;
		array2[0] = 123;
		array2[0] = 102;
		array2[0] = 154;
		array2[0] = 138;
		array2[1] = 193;
		array2[1] = 84;
		array2[1] = 155;
		array2[1] = 95;
		array2[1] = 144;
		array2[1] = 226;
		array2[2] = 107;
		array2[2] = 18;
		array2[2] = 117;
		array2[3] = 109;
		array2[3] = 103;
		array2[3] = 227;
		array2[4] = 107;
		array2[4] = 210;
		array2[4] = 188;
		array2[4] = 24;
		array2[5] = 153;
		array2[5] = 150;
		array2[5] = 21;
		array2[6] = 166;
		array2[6] = 122;
		array2[6] = 108;
		array2[6] = 80;
		array2[7] = 133;
		array2[7] = 157;
		array2[7] = 167;
		array2[7] = 50;
		array2[8] = 111;
		array2[8] = 31;
		array2[8] = 94;
		array2[8] = 154;
		array2[8] = 64;
		array2[8] = 85;
		array2[9] = 88;
		array2[9] = 160;
		array2[9] = 120;
		array2[9] = 143;
		array2[9] = 106;
		array2[10] = 210;
		array2[10] = 74;
		array2[10] = 11;
		array2[11] = 83;
		array2[11] = 123;
		array2[11] = 167;
		array2[11] = 76;
		array2[12] = 118;
		array2[12] = 87;
		array2[12] = 167;
		array2[12] = 147;
		array2[12] = 57;
		array2[13] = 139;
		array2[13] = 143;
		array2[13] = 213;
		array2[13] = 90;
		array2[13] = 131;
		array2[13] = 98;
		array2[14] = 96;
		array2[14] = 102;
		array2[14] = 164;
		array2[15] = 117;
		array2[15] = 85;
		array2[15] = 204;
		array2[15] = 125;
		array2[15] = 203;
		array2[15] = 127;
		array2[16] = 119;
		array2[16] = 149;
		array2[16] = 89;
		array2[17] = 144;
		array2[17] = 177;
		array2[17] = 110;
		array2[17] = 42;
		array2[18] = 140;
		array2[18] = 156;
		array2[18] = 148;
		array2[18] = 226;
		array2[18] = 189;
		array2[19] = 158;
		array2[19] = 53;
		array2[19] = 14;
		array2[20] = 152;
		array2[20] = 95;
		array2[20] = 92;
		array2[20] = 110;
		array2[20] = 163;
		array2[20] = 106;
		array2[21] = 169;
		array2[21] = 69;
		array2[21] = 163;
		array2[22] = 150;
		array2[22] = 76;
		array2[22] = 156;
		array2[22] = 131;
		array2[22] = 112;
		array2[22] = 73;
		array2[23] = 179;
		array2[23] = 107;
		array2[23] = 234;
		array2[24] = 145;
		array2[24] = 115;
		array2[24] = 78;
		array2[25] = 85;
		array2[25] = 32;
		array2[25] = 161;
		array2[25] = 114;
		array2[25] = 173;
		array2[26] = 88;
		array2[26] = 145;
		array2[26] = 83;
		array2[26] = 84;
		array2[26] = 74;
		array2[27] = 77;
		array2[27] = 149;
		array2[27] = 160;
		array2[27] = 144;
		array2[27] = 220;
		array2[27] = 160;
		array2[28] = 95;
		array2[28] = 163;
		array2[28] = 169;
		array2[28] = 76;
		array2[29] = 71;
		array2[29] = 44;
		array2[29] = 112;
		array2[29] = 12;
		array2[29] = 6;
		array2[29] = 148;
		array2[30] = 149;
		array2[30] = 120;
		array2[30] = 164;
		array2[30] = 222;
		array2[31] = 104;
		array2[31] = 165;
		array2[31] = 238;
		byte[] array3 = array2;
		byte[] array4 = new byte[16];
		array4[0] = 119;
		array4[0] = 113;
		array4[0] = 242;
		array4[0] = 112;
		array4[1] = 144;
		array4[1] = 175;
		array4[1] = 193;
		array4[1] = 107;
		array4[2] = 155;
		array4[2] = 95;
		array4[2] = 76;
		array4[3] = 96;
		array4[3] = 107;
		array4[3] = 96;
		array4[3] = 16;
		array4[4] = 82;
		array4[4] = 103;
		array4[4] = 207;
		array4[5] = 22;
		array4[5] = 144;
		array4[5] = 157;
		array4[5] = 139;
		array4[5] = 107;
		array4[6] = 150;
		array4[6] = 106;
		array4[6] = 86;
		array4[6] = 238;
		array4[7] = 82;
		array4[7] = 98;
		array4[7] = 134;
		array4[7] = 236;
		array4[8] = 120;
		array4[8] = 111;
		array4[8] = 87;
		array4[8] = 134;
		array4[8] = 128;
		array4[8] = 44;
		array4[9] = 108;
		array4[9] = 84;
		array4[9] = 88;
		array4[9] = 156;
		array4[10] = 120;
		array4[10] = 143;
		array4[10] = 123;
		array4[10] = 156;
		array4[10] = 192;
		array4[11] = 203;
		array4[11] = 142;
		array4[11] = 76;
		array4[12] = 148;
		array4[12] = 85;
		array4[12] = 146;
		array4[12] = 208;
		array4[12] = 147;
		array4[12] = 112;
		array4[13] = 133;
		array4[13] = 164;
		array4[13] = 183;
		array4[13] = 65;
		array4[13] = 86;
		array4[13] = 122;
		array4[14] = 73;
		array4[14] = 86;
		array4[14] = 117;
		array4[14] = 24;
		array4[14] = 209;
		array4[14] = 155;
		array4[15] = 203;
		array4[15] = 36;
		array4[15] = 71;
		array4[15] = 208;
		byte[] array5 = array4;
		Array.Reverse((Array)array5);
		byte[] publicKeyToken = assembly_0.GetName().GetPublicKeyToken();
		if (publicKeyToken != null && publicKeyToken.Length > 0)
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
		int num2 = array6.Length % 4;
		int num3 = array6.Length / 4;
		byte[] array7 = new byte[array6.Length];
		int num4 = array3.Length / 4;
		uint num5 = 0u;
		uint num6 = 0u;
		uint num7 = 0u;
		if (num2 > 0)
		{
			num3++;
		}
		uint num8 = 0u;
		for (int j = 0; j < num3; j++)
		{
			int num9 = j % num4;
			int num10 = j * 4;
			num8 = (uint)(num9 * 4);
			num6 = (uint)((array3[num8 + 3] << 24) | (array3[num8 + 2] << 16) | (array3[num8 + 1] << 8) | array3[num8]);
			uint num11 = 255u;
			int num12 = 0;
			if (j == num3 - 1 && num2 > 0)
			{
				num5 += num6;
				num7 = 0u;
				for (int k = 0; k < num2; k++)
				{
					if (k > 0)
					{
						num7 <<= 8;
					}
					num7 |= array6[^(1 + k)];
				}
			}
			else
			{
				num8 = (uint)num10;
				num5 += num6;
				num7 = (uint)((array6[num8 + 3] << 24) | (array6[num8 + 2] << 16) | (array6[num8 + 1] << 8) | array6[num8]);
			}
			num5 = num5;
			uint num13 = num5;
			uint num14 = num5;
			num14 ^= num14 << 25;
			num14 += 436136944;
			num14 ^= num14 >> 5;
			num14 += 2400072875u;
			num14 ^= num14 << 3;
			num14 += 172139080;
			num14 = 2701521061u + num14;
			num5 = num13 + (uint)(double)num14;
			if (j == num3 - 1 && num2 > 0)
			{
				uint num15 = num5 ^ num7;
				for (int l = 0; l < num2; l++)
				{
					if (l > 0)
					{
						num11 <<= 8;
						num12 += 8;
					}
					array7[num10 + l] = (byte)((num15 & num11) >> num12);
				}
			}
			else
			{
				uint num16 = num5 ^ num7;
				array7[num10] = (byte)(num16 & 0xFFu);
				array7[num10 + 1] = (byte)((num16 & 0xFF00) >> 8);
				array7[num10 + 2] = (byte)((num16 & 0xFF0000) >> 16);
				array7[num10 + 3] = (byte)((num16 & 0xFF000000u) >> 24);
			}
		}
		byte[] array8 = array7;
		int num17 = array8.Length / 8;
		fixed (byte* ptr = array8)
		{
			for (int m = 0; m < num17; m++)
			{
				*(long*)(ptr + (nint)m * (nint)8) ^= 1773917349L;
			}
		}
		binaryReader = new BinaryReader(new MemoryStream(array8));
		binaryReader.BaseStream.Position = 0L;
		long num18 = Marshal.GetHINSTANCE(assembly_0.GetModules()[0]).ToInt64();
		int int_ = 0;
		int num19 = 0;
		if (assembly_0.Location == null || assembly_0.Location.Length == 0)
		{
			num19 = 7168;
		}
		int num20 = binaryReader.ReadInt32();
		int num21 = binaryReader.ReadInt32();
		if (num21 == 4)
		{
			SymmetricAlgorithm symmetricAlgorithm = smethod_7();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(array3, array5);
			Array.Clear(array3, 0, array3.Length);
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			array8 = memoryStream.ToArray();
			Array.Clear(array5, 0, array5.Length);
			memoryStream.Close();
			cryptoStream.Close();
			binaryReader.Close();
			num20 = binaryReader.ReadInt32();
			num21 = binaryReader.ReadInt32();
		}
		if (num21 == 1)
		{
			IntPtr zero = IntPtr.Zero;
			zero = OpenProcess(56u, 1, (uint)Process.GetCurrentProcess().Id);
			if (IntPtr.Size == 4)
			{
				int_0 = Marshal.GetHINSTANCE(assembly_0.GetModules()[0]).ToInt32();
			}
			long_1 = Marshal.GetHINSTANCE(assembly_0.GetModules()[0]).ToInt64();
			IntPtr intptr_ = IntPtr.Zero;
			for (int n = 0; n < num20; n++)
			{
				IntPtr intPtr = new IntPtr(long_1 + binaryReader.ReadInt32() - num19);
				VirtualProtect_1(intPtr, 4, 4, ref int_);
				if (IntPtr.Size == 4)
				{
					WriteProcessMemory(zero, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4u, out intptr_);
				}
				else
				{
					WriteProcessMemory(zero, intPtr, BitConverter.GetBytes(binaryReader.ReadInt32()), 4u, out intptr_);
				}
				VirtualProtect_1(intPtr, 4, int_, ref int_);
			}
			while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length - 1L)
			{
				int num22 = binaryReader.ReadInt32();
				IntPtr intptr_2 = new IntPtr(long_1 + num22);
				int num23 = binaryReader.ReadInt32();
				VirtualProtect_1(intptr_2, num23 * 4, 4, ref int_);
				for (int num24 = 0; num24 < num23; num24++)
				{
					Marshal.WriteInt32(new IntPtr(intptr_2.ToInt64() + num24 * 4), binaryReader.ReadInt32());
				}
				VirtualProtect_1(intptr_2, num23 * 4, int_, ref int_);
			}
			CloseHandle(zero);
			return;
		}
		for (int num25 = 0; num25 < num20; num25++)
		{
			IntPtr intPtr2 = new IntPtr(num18 + binaryReader.ReadInt32() - num19);
			VirtualProtect_1(intPtr2, 4, 4, ref int_);
			Marshal.WriteInt32(intPtr2, binaryReader.ReadInt32());
			VirtualProtect_1(intPtr2, 4, int_, ref int_);
		}
		hashtable_0 = new Hashtable(binaryReader.ReadInt32() + 1);
		Struct4 @struct = default(Struct4);
		@struct.byte_0 = new byte[1] { 42 };
		@struct.bool_0 = false;
		hashtable_0.Add(0L, @struct);
		bool flag = false;
		while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length - 1L)
		{
			int num26 = binaryReader.ReadInt32() - num19;
			int num27 = binaryReader.ReadInt32();
			flag = false;
			if (num27 >= 1879048192)
			{
				flag = true;
			}
			int count = binaryReader.ReadInt32();
			byte[] array9 = binaryReader.ReadBytes(count);
			Struct4 struct2 = default(Struct4);
			struct2.byte_0 = array9;
			struct2.bool_0 = flag;
			hashtable_0.Add(num18 + num26, struct2);
		}
		long_0 = Marshal.GetHINSTANCE(typeof(Class10).Assembly.GetModules()[0]).ToInt64();
		if (IntPtr.Size == 4)
		{
			int_1 = Convert.ToInt32(long_0);
		}
		byte[] bytes = new byte[12]
		{
			109, 115, 99, 111, 114, 106, 105, 116, 46, 100,
			108, 108
		};
		string @string = Encoding.UTF8.GetString(bytes);
		IntPtr intPtr3 = LoadLibrary(@string);
		if (intPtr3 == IntPtr.Zero)
		{
			bytes = new byte[10] { 99, 108, 114, 106, 105, 116, 46, 100, 108, 108 };
			@string = Encoding.UTF8.GetString(bytes);
			intPtr3 = LoadLibrary(@string);
		}
		byte[] bytes2 = new byte[6] { 103, 101, 116, 74, 105, 116 };
		string string2 = Encoding.UTF8.GetString(bytes2);
		IntPtr procAddress = GetProcAddress(intPtr3, string2);
		Delegate4 @delegate = (Delegate4)smethod_15(procAddress, typeof(Delegate4));
		IntPtr ptr2 = @delegate();
		long num28 = 0L;
		num28 = ((IntPtr.Size != 4) ? Marshal.ReadInt64(ptr2) : Marshal.ReadInt32(ptr2));
		Marshal.ReadIntPtr(ptr2, 0);
		delegate3_1 = smethod_13;
		IntPtr zero2 = IntPtr.Zero;
		zero2 = Marshal.GetFunctionPointerForDelegate((Delegate)delegate3_1);
		long num29 = 0L;
		num29 = ((IntPtr.Size != 4) ? Marshal.ReadInt64(new IntPtr(num28)) : Marshal.ReadInt32(new IntPtr(num28)));
		Process currentProcess = Process.GetCurrentProcess();
		try
		{
			ProcessModuleCollection modules = currentProcess.Modules;
			foreach (ProcessModule item in modules)
			{
				if (item.ModuleName == @string && (num29 < item.BaseAddress.ToInt64() || num29 > item.BaseAddress.ToInt64() + item.ModuleMemorySize) && (object)typeof(Class10).Assembly.EntryPoint != null)
				{
					return;
				}
			}
		}
		catch
		{
		}
		try
		{
			ProcessModuleCollection modules2 = currentProcess.Modules;
			foreach (ProcessModule item2 in modules2)
			{
				if (item2.BaseAddress.ToInt64() == long_0)
				{
					num19 = 0;
					break;
				}
			}
		}
		catch
		{
		}
		delegate3_0 = null;
		try
		{
			delegate3_0 = (Delegate3)smethod_15(new IntPtr(num29), typeof(Delegate3));
		}
		catch
		{
			try
			{
				Delegate delegate2 = smethod_15(new IntPtr(num29), typeof(Delegate3));
				delegate3_0 = (Delegate3)Delegate.CreateDelegate(typeof(Delegate3), delegate2.Method);
			}
			catch
			{
			}
		}
		int int_2 = 0;
		if ((object)typeof(Class10).Assembly.EntryPoint != null && typeof(Class10).Assembly.EntryPoint!.GetParameters().Length == 2 && typeof(Class10).Assembly.Location != null && typeof(Class10).Assembly.Location.Length > 0)
		{
			return;
		}
		try
		{
			object value = typeof(Class10).Assembly.ManifestModule.ModuleHandle.GetType().GetField("m_ptr", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)!.GetValue(typeof(Class10).Assembly.ManifestModule.ModuleHandle);
			if (value is IntPtr)
			{
				intptr_0 = (IntPtr)value;
			}
			if (value.GetType().ToString() == "System.Reflection.RuntimeModule")
			{
				intptr_0 = (IntPtr)value.GetType().GetField("m_pData", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)!.GetValue(value);
			}
			MemoryStream memoryStream2 = new MemoryStream();
			memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
			if (IntPtr.Size == 4)
			{
				memoryStream2.Write(BitConverter.GetBytes(intptr_0.ToInt32()), 0, 4);
			}
			else
			{
				memoryStream2.Write(BitConverter.GetBytes(intptr_0.ToInt64()), 0, 8);
			}
			memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
			memoryStream2.Write(new byte[IntPtr.Size], 0, IntPtr.Size);
			memoryStream2.Position = 0L;
			byte[] array10 = memoryStream2.ToArray();
			memoryStream2.Close();
			uint nativeSizeOfCode = 0u;
			try
			{
				fixed (byte* value2 = array10)
				{
					delegate3_1(new IntPtr(value2), new IntPtr(value2), new IntPtr(value2), 216669565u, new IntPtr(value2), ref nativeSizeOfCode);
				}
			}
			finally
			{
			}
		}
		catch
		{
		}
		RuntimeHelpers.PrepareDelegate(delegate3_0);
		RuntimeHelpers.PrepareMethod(delegate3_0.Method.MethodHandle);
		RuntimeHelpers.PrepareDelegate(delegate3_1);
		RuntimeHelpers.PrepareMethod(delegate3_1.Method.MethodHandle);
		byte[] array11 = null;
		array11 = ((IntPtr.Size == 4) ? new byte[30]
		{
			85, 139, 236, 139, 69, 16, 129, 120, 4, 125,
			29, 234, 12, 116, 7, 184, 182, 177, 74, 6,
			235, 5, 184, 182, 146, 64, 12, 93, 255, 224
		} : new byte[40]
		{
			72, 184, 0, 0, 0, 0, 0, 0, 0, 0,
			73, 57, 64, 8, 116, 12, 72, 184, 0, 0,
			0, 0, 0, 0, 0, 0, 255, 224, 72, 184,
			0, 0, 0, 0, 0, 0, 0, 0, 255, 224
		});
		IntPtr intPtr4 = VirtualAlloc(IntPtr.Zero, (uint)array11.Length, 4096u, 64u);
		byte[] array12 = array11;
		byte[] array13 = null;
		byte[] array14 = null;
		byte[] array15 = null;
		if (IntPtr.Size == 4)
		{
			array15 = BitConverter.GetBytes(intptr_0.ToInt32());
			array13 = BitConverter.GetBytes(zero2.ToInt32());
			array14 = BitConverter.GetBytes(Convert.ToInt32(num29));
		}
		else
		{
			array15 = BitConverter.GetBytes(intptr_0.ToInt64());
			array13 = BitConverter.GetBytes(zero2.ToInt64());
			array14 = BitConverter.GetBytes(num29);
		}
		if (IntPtr.Size == 4)
		{
			array12[9] = array15[0];
			array12[10] = array15[1];
			array12[11] = array15[2];
			array12[12] = array15[3];
			array12[16] = array14[0];
			array12[17] = array14[1];
			array12[18] = array14[2];
			array12[19] = array14[3];
			array12[23] = array13[0];
			array12[24] = array13[1];
			array12[25] = array13[2];
			array12[26] = array13[3];
		}
		else
		{
			array12[2] = array15[0];
			array12[3] = array15[1];
			array12[4] = array15[2];
			array12[5] = array15[3];
			array12[6] = array15[4];
			array12[7] = array15[5];
			array12[8] = array15[6];
			array12[9] = array15[7];
			array12[18] = array14[0];
			array12[19] = array14[1];
			array12[20] = array14[2];
			array12[21] = array14[3];
			array12[22] = array14[4];
			array12[23] = array14[5];
			array12[24] = array14[6];
			array12[25] = array14[7];
			array12[30] = array13[0];
			array12[31] = array13[1];
			array12[32] = array13[2];
			array12[33] = array13[3];
			array12[34] = array13[4];
			array12[35] = array13[5];
			array12[36] = array13[6];
			array12[37] = array13[7];
		}
		Marshal.Copy(array12, 0, intPtr4, array12.Length);
		bool_1 = false;
		VirtualProtect_1(new IntPtr(num28), IntPtr.Size, 64, ref int_2);
		Marshal.WriteIntPtr(new IntPtr(num28), intPtr4);
		VirtualProtect_1(new IntPtr(num28), IntPtr.Size, int_2, ref int_2);
	}

	internal static object smethod_17(Assembly assembly_1)
	{
		try
		{
			if (File.Exists(assembly_1.Location))
			{
				return assembly_1.Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetName().CodeBase!.ToString().Replace("file:///", "")))
			{
				return assembly_1.GetName().CodeBase!.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(assembly_1.GetType().GetProperty("Location")!.GetValue(assembly_1, new object[0])!.ToString()))
			{
				return assembly_1.GetType().GetProperty("Location")!.GetValue(assembly_1, new object[0])!.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_3, string string_1);

	[DllImport("kernel32.dll")]
	private static extern int WriteProcessMemory(IntPtr intptr_3, IntPtr intptr_4, [In][Out] byte[] byte_3, uint uint_1, out IntPtr intptr_5);

	[DllImport("kernel32.dll")]
	private static extern int ReadProcessMemory(IntPtr intptr_3, IntPtr intptr_4, [In][Out] byte[] byte_3, uint uint_1, out IntPtr intptr_5);

	[DllImport("kernel32.dll", EntryPoint = "VirtualProtect")]
	private static extern int VirtualProtect_1(IntPtr intptr_3, int int_5, int int_6, ref int int_7);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint uint_1, int int_5, uint uint_2);

	[DllImport("kernel32.dll")]
	private static extern int CloseHandle(IntPtr intptr_3);

	[Attribute1(typeof(Attribute1.Class11<object>[]))]
	private static byte[] smethod_18(string string_1)
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

	[Attribute1(typeof(Attribute1.Class11<object>[]))]
	private static byte[] smethod_19(byte[] byte_3)
	{
		MemoryStream memoryStream = new MemoryStream();
		SymmetricAlgorithm symmetricAlgorithm = smethod_7();
		symmetricAlgorithm.Key = new byte[32]
		{
			98, 210, 35, 218, 152, 6, 11, 175, 27, 15,
			123, 183, 228, 208, 249, 249, 204, 214, 50, 222,
			249, 10, 136, 83, 194, 174, 192, 71, 97, 164,
			138, 36
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			252, 223, 177, 56, 80, 91, 221, 247, 93, 166,
			202, 7, 158, 237, 58, 237
		};
		CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_3, 0, byte_3.Length);
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
		return null;
	}

	private byte[] method_5()
	{
		return null;
	}

	internal byte[] method_6()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_7()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] method_8()
	{
		return null;
	}

	internal byte[] method_9()
	{
		return null;
	}
}
