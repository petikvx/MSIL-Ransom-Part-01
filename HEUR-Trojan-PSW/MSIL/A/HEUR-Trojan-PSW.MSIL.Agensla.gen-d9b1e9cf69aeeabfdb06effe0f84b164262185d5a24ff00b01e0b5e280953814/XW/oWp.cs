using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace XW;

internal class oWp
{
	private delegate void uWZ(object o);

	internal class oWu : Attribute
	{
		internal class EWe<dWA>
		{
			private static object XfA;

			public EWe()
			{
				G3.nJ(G3.By);
				base._002Ector();
			}

			internal static bool Afi()
			{
				return XfA == null;
			}

			internal static object Cf2()
			{
				return XfA;
			}
		}

		[oWu(typeof(EWe<object>[]))]
		public oWu(object object_0)
		{
		}
	}

	internal class OWC
	{
		[oWu(typeof(oWu.EWe<object>[]))]
		internal static string Mqg(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] array2 = new byte[32];
			TMf(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] key = array2;
			byte[] iV = (byte[])PMd(((Encoding)rMM()).GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = OaE();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		internal static void TMf(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
		}

		internal static object rMM()
		{
			return Encoding.Unicode;
		}

		internal static object PMd(object object_0)
		{
			return Fak((byte[])object_0);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint rWB(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr SWo();

	internal struct qW6
	{
		internal bool eq0;

		internal byte[] Dql;
	}

	internal class lWP
	{
		private BinaryReader lqM;

		public lWP(Stream stream_0)
		{
			lqM = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return lqM.BaseStream;
		}

		internal byte[] Wqd(int int_0)
		{
			return lqM.ReadBytes(int_0);
		}

		internal int xqV(byte[] byte_0, int int_0, int int_1)
		{
			return lqM.Read(byte_0, int_0, int_1);
		}

		internal int fqR()
		{
			return lqM.ReadInt32();
		}

		internal void rqO()
		{
			lqM.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr HWQ(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr IWN(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int vWm(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int RWE(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr aWw(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int FWk(IntPtr ptr);

	[Flags]
	private enum WWf
	{

	}

	private static bool Hqh;

	internal static Assembly jqH;

	private static uint[] Pqv;

	private static bool eq4;

	private static bool AqU;

	private static byte[] BqG;

	internal static RSACryptoServiceProvider MqI;

	private static Dictionary<int, int> jq1;

	private static object tq5;

	private static byte[] BqJ;

	private static byte[] Cq9;

	private static IntPtr Gqp;

	private static IntPtr OqZ;

	private static object Kqu;

	private static int[] Mqe;

	private static int tqA;

	private static bool wqC;

	private static SortedList BqB;

	private static int pqo;

	private static long Hq6;

	internal static rWB aqP;

	internal static rWB uqQ;

	private static long WqN;

	private static int zqm;

	private static bool tqE;

	private static bool iqw;

	private static int Iqk;

	private static IntPtr Sqf;

	[oWu(typeof(oWu.EWe<object>[]))]
	private static bool gqr;

	internal static Hashtable Tqy;

	private static HWQ Tqx;

	private static IWN LqY;

	private static vWm Xq8;

	private static RWE jqn;

	private static aWw tqX;

	private static FWk eqb;

	private static IntPtr Oqc;

	static oWp()
	{
		Hqh = false;
		jqH = typeof(oWp).Assembly;
		Pqv = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		eq4 = false;
		AqU = false;
		BqG = new byte[0];
		MqI = null;
		jq1 = null;
		tq5 = new object();
		BqJ = new byte[0];
		Cq9 = new byte[0];
		Gqp = IntPtr.Zero;
		OqZ = IntPtr.Zero;
		Kqu = new string[0];
		Mqe = new int[0];
		tqA = 1;
		wqC = false;
		BqB = new SortedList();
		pqo = 0;
		Hq6 = 0L;
		aqP = null;
		uqQ = null;
		WqN = 0L;
		zqm = 0;
		tqE = false;
		iqw = false;
		Iqk = 0;
		Sqf = IntPtr.Zero;
		gqr = false;
		Tqy = new Hashtable();
		Tqx = null;
		LqY = null;
		Xq8 = null;
		jqn = null;
		tqX = null;
		eqb = null;
		Oqc = IntPtr.Zero;
		try
		{
			VfC(bool_0: true);
		}
		catch
		{
		}
	}

	private void ULUCPb()
	{
	}

	internal static byte[] vaB(byte[] byte_0)
	{
		uint[] array = new uint[16];
		int num = 448 - byte_0.Length * 8 % 512;
		uint num2 = (uint)((num + 512) % 512);
		if (num2 == 0)
		{
			num2 = 512u;
		}
		uint num3 = (uint)(byte_0.Length + num2 / 8u + 8L);
		ulong num4 = (ulong)(byte_0.Length * 8L);
		byte[] array2 = new byte[num3];
		for (int i = 0; i < byte_0.Length; i++)
		{
			array2[i] = byte_0[i];
		}
		array2[byte_0.Length] |= 128;
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
			Wao(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			Wao(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			Wao(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			Wao(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			Wao(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			Wao(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			Wao(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			Wao(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			Wao(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			Wao(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			Wao(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			Wao(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			Wao(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			Wao(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			Wao(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			Wao(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			ga6(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			ga6(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			ga6(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			ga6(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			ga6(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			ga6(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			ga6(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			ga6(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			ga6(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			ga6(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			ga6(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			ga6(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			ga6(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			ga6(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			ga6(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			ga6(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			daP(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			daP(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			daP(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			daP(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			daP(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			daP(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			daP(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			daP(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			daP(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			daP(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			daP(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			daP(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			daP(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			daP(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			daP(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			daP(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			YaQ(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			YaQ(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			YaQ(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			YaQ(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			YaQ(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			YaQ(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			YaQ(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			YaQ(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			YaQ(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			YaQ(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			YaQ(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			YaQ(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			YaQ(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			YaQ(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			YaQ(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			YaQ(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
			uint_ += num10;
			uint_2 += num11;
			uint_3 += num12;
			uint_4 += num13;
		}
		byte[] array3 = new byte[16];
		Array.Copy(BitConverter.GetBytes(uint_), 0, array3, 0, 4);
		Array.Copy((Array)HfJ(uint_2), 0, array3, 4, 4);
		Array.Copy(BitConverter.GetBytes(uint_3), 0, array3, 8, 4);
		Array.Copy(BitConverter.GetBytes(uint_4), 0, array3, 12, 4);
		return array3;
	}

	private static void Wao(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + faN(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + Pqv[uint_5 - 1], ushort_0);
	}

	private static void ga6(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + faN(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + Pqv[uint_5 - 1], ushort_0);
	}

	private static void daP(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + mfN(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + Pqv[uint_5 - 1], ushort_0);
	}

	private static void YaQ(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + faN(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + Pqv[uint_5 - 1], ushort_0);
	}

	private static uint faN(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool Bam()
	{
		if (!eq4)
		{
			Iaw();
			eq4 = true;
		}
		return AqU;
	}

	internal static SymmetricAlgorithm OaE()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (Bam())
		{
			return new AesCryptoServiceProvider();
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

	internal static void Iaw()
	{
		try
		{
			AqU = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] Fak(byte[] byte_0)
	{
		if (!Tfa())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return vaB(byte_0);
	}

	internal static void Haf(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			Var(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void Var(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint Eay(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
	{
		int num = 0;
		uint num3;
		uint num4;
		while (true)
		{
			if (num < int_0)
			{
				binaryReader_0.BaseStream.Position = long_0 + (num * 40 + 8);
				uint num2 = binaryReader_0.ReadUInt32();
				num3 = binaryReader_0.ReadUInt32();
				binaryReader_0.ReadUInt32();
				num4 = Gfx(binaryReader_0);
				if (num3 <= uint_0 && uint_0 < num3 + num2)
				{
					break;
				}
				num++;
				continue;
			}
			return 0u;
		}
		return num4 + uint_0 - num3;
	}

	public static void max(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (jq1 == null)
			{
				bool lockTaken = false;
				object object_ = default(object);
				try
				{
					Monitor.Enter(object_ = tq5, ref lockTaken);
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(oWp).Assembly.GetManifestResourceStream("1K9ArbPyAvTd9cXGOw.FKZ8GDRijKqoVZ5Gjp"));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = (byte[])Afg(binaryReader, (int)binaryReader.BaseStream.Length);
					binaryReader.Close();
					if (array.Length > 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[^(1 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							uint num9 = num3;
							uint num10 = num3;
							num10 ^= num10 << 27;
							num10 += 3613734180u;
							num10 ^= num10 >> 3;
							num10 += 683632170;
							num10 ^= num10 << 4;
							num10 += 3185074561u;
							num10 = 1036765596 - num10;
							num3 = num9 + (uint)(double)num10;
							if (i == num2 - 1 && num > 0)
							{
								uint num11 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num11 & num7) >> num8);
								}
							}
							else
							{
								uint num12 = num3 ^ num4;
								array2[num6] = (byte)(num12 & 0xFFu);
								array2[num6 + 1] = (byte)((num12 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num12 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num12 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num13 = array.Length / 8;
						lWP lWP = new lWP(new MemoryStream(array));
						for (int l = 0; l < num13; l++)
						{
							int key = lWP.fqR();
							int value = lWP.fqR();
							dictionary.Add(key, value);
						}
						PfI(lWP);
					}
					jq1 = dictionary;
				}
				finally
				{
					if (lockTaken)
					{
						qfS(object_);
					}
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num14 = jq1[metadataToken];
				bool flag = (num14 & 0x40000000) > 0;
				num14 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)mfm(typeof(oWp).TypeHandle).Module.ResolveMethod(num14, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, vf4(fieldInfo.FieldType, methodInfo));
					continue;
				}
				ParameterInfo[] parameters = methodInfo.GetParameters();
				int num15 = parameters.Length + 1;
				Type[] array3 = new Type[num15];
				if (methodInfo.DeclaringType!.IsValueType)
				{
					array3[0] = methodInfo.DeclaringType!.MakeByRefType();
				}
				else
				{
					array3[0] = typeof(object);
				}
				for (int n = 0; n < parameters.Length; n++)
				{
					array3[n + 1] = parameters[n].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				for (int num16 = 0; num16 < num15; num16++)
				{
					switch (num16)
					{
					default:
						iLGenerator.Emit(OpCodes.Ldarg_S, num16);
						break;
					case 0:
						iLGenerator.Emit(OpCodes.Ldarg_0);
						break;
					case 1:
						iLGenerator.Emit(OpCodes.Ldarg_1);
						break;
					case 2:
						iLGenerator.Emit(OpCodes.Ldarg_2);
						break;
					case 3:
						Tfe(iLGenerator, OpCodes.Ldarg_3);
						break;
					}
				}
				iLGenerator.Emit(OpCodes.Tailcall);
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
				iLGenerator.Emit(OpCodes.Ret);
				dfn(fieldInfo, null, dynamicMethod.CreateDelegate(typeFromHandle));
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint laY(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11111}".Length;
	}

	private static uint Ra8(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	internal static void KaX()
	{
	}

	[oWu(typeof(oWu.EWe<object>[]))]
	internal static string zab(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int iac()
	{
		return 5;
	}

	private static void Oag()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate La0(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			mfm(typeof(Type).TypeHandle)
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object jal(object object_0)
	{
		try
		{
			if (Sfc(((Assembly)object_0).Location))
			{
				return ((Assembly)object_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)object_0).GetName().CodeBase!.ToString().Replace("file:///", "")))
			{
				return ((AssemblyName)QfR((Assembly)object_0)).CodeBase!.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(afr(object_0.GetType().GetProperty("Location"), object_0, new object[0]).ToString()))
			{
				return afr(object_0.GetType().GetProperty("Location"), object_0, new object[0]).ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[DllImport("kernel32")]
	public static extern IntPtr LoadLibrary(string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	private static IntPtr DaR(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (Tqx == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Find ".Trim() + "ResourceA");
			Tqx = (HWQ)Jfv(procAddress, typeof(HWQ));
		}
		return Tqx(intptr_0, string_0, uint_0);
	}

	private static IntPtr IaO(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (LqY == null)
		{
			IntPtr procAddress = GetProcAddress(Cfk(), "Virtual ".Trim() + "Alloc");
			LqY = (IWN)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(IWN));
		}
		return LqY(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int zaM(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (Xq8 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), (string?)sf3("Write ") + "Process ".Trim() + "Memory");
			Xq8 = (vWm)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(vWm));
		}
		return Xq8(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int saK(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (jqn == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), (string?)sf3("Virtual ") + "Protect");
			jqn = (RWE)Jfv(procAddress, typeof(RWE));
		}
		return jqn(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr GaT(uint uint_0, int int_0, uint uint_1)
	{
		if (tqX == null)
		{
			IntPtr procAddress = GetProcAddress(Cfk(), "Open ".Trim() + "Process");
			tqX = (aWw)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(aWw));
		}
		return tqX(uint_0, int_0, uint_1);
	}

	private static int eaz(IntPtr intptr_0)
	{
		if (eqb == null)
		{
			IntPtr procAddress = GetProcAddress(Cfk(), "Close ".Trim() + "Handle");
			eqb = (FWk)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(FWk));
		}
		return MfO(eqb, intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (Oqc == IntPtr.Zero)
		{
			Oqc = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return Oqc;
	}

	[oWu(typeof(oWu.EWe<object>[]))]
	private static byte[] bq3(string string_0)
	{
		using FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
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

	internal static Stream zqW()
	{
		return new MemoryStream();
	}

	internal static byte[] MqL(Stream stream_0)
	{
		return (byte[])Lft((MemoryStream)stream_0);
	}

	[oWu(typeof(oWu.EWe<object>[]))]
	private static byte[] Fqi(byte[] byte_0)
	{
		Stream stream = zqW();
		SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm)Lfo();
		byte[] array = new byte[32];
		OfK(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		symmetricAlgorithm.Key = array;
		symmetricAlgorithm.IV = new byte[16]
		{
			117, 254, 41, 121, 65, 52, 9, 43, 221, 154,
			12, 54, 68, 241, 68, 66
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = MqL(stream);
		uWr.hLUCPz();
		return result;
	}

	private byte[] Iqa()
	{
		string text = "{11111-22222-10001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] Dqq()
	{
		string text = "{11111-22222-10001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] vqF()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] xq2()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] NqS()
	{
		string object_ = "{11111-22222-30001-00001}";
		if (cfP(object_) > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] eqt()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] fqD()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] Uq7()
	{
		string object_ = "{11111-22222-40001-00002}";
		if (cfP(object_) > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] dqj()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] mqs()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static void VfC(bool bool_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
	}

	internal static object HfJ(uint uint_0)
	{
		return BitConverter.GetBytes(uint_0);
	}

	internal static uint mfN(uint uint_0, ushort ushort_0)
	{
		return faN(uint_0, ushort_0);
	}

	internal static bool Tfa()
	{
		return Bam();
	}

	internal static uint Gfx(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt32();
	}

	internal static object Afg(object object_0, int int_0)
	{
		return ((BinaryReader)object_0).ReadBytes(int_0);
	}

	internal static void PfI(object object_0)
	{
		((lWP)object_0).rqO();
	}

	internal static void qfS(object object_0)
	{
		Monitor.Exit(object_0);
	}

	internal static Type mfm(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static object vf4(Type type_0, object object_0)
	{
		return Delegate.CreateDelegate(type_0, (MethodInfo)object_0);
	}

	internal static void Tfe(object object_0, OpCode opCode_0)
	{
		((ILGenerator)object_0).Emit(opCode_0);
	}

	internal static void dfn(object object_0, object object_1, object object_2)
	{
		((FieldInfo)object_0).SetValue(object_1, object_2);
	}

	internal static bool Sfc(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object QfR(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object afr(object object_0, object object_1, object object_2)
	{
		return ((PropertyInfo)object_0).GetValue(object_1, (object?[]?)object_2);
	}

	internal static object Jfv(IntPtr intptr_0, Type type_0)
	{
		return Marshal.GetDelegateForFunctionPointer(intptr_0, type_0);
	}

	internal static IntPtr Cfk()
	{
		return umLocehuEC();
	}

	internal static object sf3(object object_0)
	{
		return ((string)object_0).Trim();
	}

	internal static int MfO(object object_0, IntPtr ptr)
	{
		return object_0(ptr);
	}

	internal static object Lft(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	internal static object Lfo()
	{
		return OaE();
	}

	internal static void OfK(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
	}

	internal static int cfP(object object_0)
	{
		return ((string)object_0).Length;
	}
}
