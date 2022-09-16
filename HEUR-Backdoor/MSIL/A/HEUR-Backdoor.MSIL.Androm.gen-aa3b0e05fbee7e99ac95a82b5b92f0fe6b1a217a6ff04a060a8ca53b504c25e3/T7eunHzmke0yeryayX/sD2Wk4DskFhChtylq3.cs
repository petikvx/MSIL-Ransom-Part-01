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
using EhdA9I4ntZdCXaNotex;
using HrqeXu48u5BWvM2U05m;
using JAhEyh46uvA1xwWjvIk;
using WGDcIt4rthaVX3IEVJJ;

namespace T7eunHzmke0yeryayX;

internal class sD2Wk4DskFhChtylq3
{
	private delegate void QpgXCL4YA37cqZmOnwk(object o);

	internal class SQ5Vv644gjvJ1OZ46Xt : Attribute
	{
		internal class k2WWaX4JH6ysvSNcvf7<BhslPD4eH9r6itJC35R>
		{
			internal static object n3I0Oo3iCl;

			public k2WWaX4JH6ysvSNcvf7()
			{
				xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
				ud9OYc4i7bqX53MRDiY.tvE0cQ1Gob();
				base._002Ector();
			}

			internal static bool YN90FhuqFW()
			{
				return n3I0Oo3iCl == null;
			}

			internal static object OZQ0BUZfL3()
			{
				return n3I0Oo3iCl;
			}

			static k2WWaX4JH6ysvSNcvf7()
			{
				K1GfMT41V9bS6oPmMyh.cKXl4vhcQo();
			}
		}

		[SQ5Vv644gjvJ1OZ46Xt(typeof(k2WWaX4JH6ysvSNcvf7<object>[]))]
		public SQ5Vv644gjvJ1OZ46Xt(object object_0)
		{
			xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
			base._002Ector();
		}

		static SQ5Vv644gjvJ1OZ46Xt()
		{
			K1GfMT41V9bS6oPmMyh.cKXl4vhcQo();
		}
	}

	internal class qN26Mu40091FNVscbCP
	{
		[SQ5Vv644gjvJ1OZ46Xt(typeof(SQ5Vv644gjvJ1OZ46Xt.k2WWaX4JH6ysvSNcvf7<object>[]))]
		internal static string PVw0G3cWny(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] array2 = new byte[32];
			F4W0TaSYhm(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] key = array2;
			byte[] iV = (byte[])CQq0bosepR(aGE0E0Qg1u(n5F0MAItI4(), string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm)djI0AfwAmq();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			xbx0Qbe15j(cryptoStream, array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		public qN26Mu40091FNVscbCP()
		{
			xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
			base._002Ector();
		}

		internal static void F4W0TaSYhm(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
		}

		internal static object n5F0MAItI4()
		{
			return Encoding.Unicode;
		}

		internal static object aGE0E0Qg1u(object object_0, object object_1)
		{
			return ((Encoding)object_0).GetBytes((string)object_1);
		}

		internal static object CQq0bosepR(object object_0)
		{
			return u05JImyAqC((byte[])object_0);
		}

		internal static object djI0AfwAmq()
		{
			return ByhJX6rqeX();
		}

		internal static void xbx0Qbe15j(object object_0, object object_1, int int_0, int int_1)
		{
			((Stream)object_0).Write((byte[])object_1, int_0, int_1);
		}

		static qN26Mu40091FNVscbCP()
		{
			K1GfMT41V9bS6oPmMyh.cKXl4vhcQo();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint gopFQ64lddGbmMcJ5Hj(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Uj6DIq4s8BP2Iu0IY00();

	internal struct jlxLSD4VVJPqJB1nDkm
	{
		internal bool wAl0gnJw2V;

		internal byte[] Wsy0KCFamw;
	}

	internal class eTMvoS42v7M77b7grCN
	{
		private BinaryReader YBk0ht98Oh;

		public eTMvoS42v7M77b7grCN(Stream stream_0)
		{
			xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
			base._002Ector();
			YBk0ht98Oh = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return YBk0ht98Oh.BaseStream;
		}

		internal byte[] CCd0RuQxaA(int int_0)
		{
			return (byte[])c6f0tFfqo4(YBk0ht98Oh, int_0);
		}

		internal int YQy06UsTnb(byte[] byte_0, int int_0, int int_1)
		{
			return ScE0N2cpir(YBk0ht98Oh, byte_0, int_0, int_1);
		}

		internal int VVP09HNALm()
		{
			return YBk0ht98Oh.ReadInt32();
		}

		internal void zfJ0rLEUPV()
		{
			g1Y0PmBjS9(YBk0ht98Oh);
		}

		internal static object c6f0tFfqo4(object object_0, int int_0)
		{
			return ((BinaryReader)object_0).ReadBytes(int_0);
		}

		internal static int ScE0N2cpir(object object_0, object object_1, int int_0, int int_1)
		{
			return ((BinaryReader)object_0).Read((byte[])object_1, int_0, int_1);
		}

		internal static void g1Y0PmBjS9(object object_0)
		{
			((BinaryReader)object_0).Close();
		}

		static eTMvoS42v7M77b7grCN()
		{
			K1GfMT41V9bS6oPmMyh.cKXl4vhcQo();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr empf4r4yAk7MCWuEdYi(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr UPZAZC4vOQgfTXp0SIw(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int BBay724addf97DtxLLM(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int a18NER47tfqAWVswXn2(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr eidVQ84W5sd0GleHkkg(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int i7bXcI4pcEwsV0Suw8G(IntPtr ptr);

	[Flags]
	private enum TP7Axc4dPgbP6SB0IYu
	{

	}

	private static bool KeUe5t791N;

	internal static Assembly xZdeXVsVoR;

	private static bool fJIeowCM2Y;

	[SQ5Vv644gjvJ1OZ46Xt(typeof(SQ5Vv644gjvJ1OZ46Xt.k2WWaX4JH6ysvSNcvf7<object>[]))]
	private static bool w47ezkBSj2;

	internal static RSACryptoServiceProvider xXn02YRE8b;

	private static BBay724addf97DtxLLM opH0yjhF8Q;

	private static bool iUZ07YtIGV;

	internal static gopFQ64lddGbmMcJ5Hj Dxo0d58h9U;

	private static byte[] gdd0nOb1my;

	private static bool G7R0jhpqjR;

	private static IntPtr KFx0kJRwqj;

	internal static gopFQ64lddGbmMcJ5Hj bn60xrwKOx;

	private static bool Qpa0ZUVijI;

	private static int rah0su2iGK;

	private static IntPtr M1Q00iwDbm;

	private static int NfR0vJDpRU;

	private static empf4r4yAk7MCWuEdYi OZ80YcV9RW;

	internal static Hashtable C2b0iPcFFy;

	private static int[] KLD0VCGWFu;

	private static uint[] FtJ0wLORnD;

	private static long kJA0q9EAc3;

	private static IntPtr FCa0UlMCY5;

	private static byte[] zateIc21wQ;

	private static object U6hemG9KWJ;

	private static eidVQ84W5sd0GleHkkg Geg0Jsmcgl;

	private static object IBa0avxa2L;

	private static long gKT08PEami;

	private static byte[] PG6eC0KrXu;

	private static IntPtr BxteD73ekJ;

	private static a18NER47tfqAWVswXn2 mPN04V1e2r;

	private static Dictionary<int, int> D5o0pAmEWH;

	private static SortedList hkBeu0bL0o;

	private static int xFY0Wrinbp;

	private static i7bXcI4pcEwsV0Suw8G vmK0eQSuEk;

	private static bool uul0lSCU7j;

	private static int VCmeSsReKM;

	private static UPZAZC4vOQgfTXp0SIw G1601lalYt;

	static sD2Wk4DskFhChtylq3()
	{
		K1GfMT41V9bS6oPmMyh.cKXl4vhcQo();
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		KeUe5t791N = false;
		xZdeXVsVoR = Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554469)).Assembly;
		FtJ0wLORnD = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		uul0lSCU7j = false;
		fJIeowCM2Y = false;
		zateIc21wQ = new byte[0];
		xXn02YRE8b = null;
		D5o0pAmEWH = null;
		IBa0avxa2L = new object();
		gdd0nOb1my = new byte[0];
		PG6eC0KrXu = new byte[0];
		M1Q00iwDbm = IntPtr.Zero;
		FCa0UlMCY5 = IntPtr.Zero;
		U6hemG9KWJ = new string[0];
		KLD0VCGWFu = new int[0];
		rah0su2iGK = 1;
		iUZ07YtIGV = false;
		hkBeu0bL0o = new SortedList();
		xFY0Wrinbp = 0;
		gKT08PEami = 0L;
		bn60xrwKOx = null;
		Dxo0d58h9U = null;
		kJA0q9EAc3 = 0L;
		VCmeSsReKM = 0;
		Qpa0ZUVijI = false;
		G7R0jhpqjR = false;
		NfR0vJDpRU = 0;
		BxteD73ekJ = IntPtr.Zero;
		w47ezkBSj2 = false;
		C2b0iPcFFy = new Hashtable();
		OZ80YcV9RW = null;
		G1601lalYt = null;
		opH0yjhF8Q = null;
		mPN04V1e2r = null;
		Geg0Jsmcgl = null;
		vmK0eQSuEk = null;
		KFx0kJRwqj = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void diRJPpSdhB()
	{
	}

	internal static byte[] tDxJh3D1jF(byte[] byte_0)
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
			gi2JcAIWC9(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			gi2JcAIWC9(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			gi2JcAIWC9(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			gi2JcAIWC9(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			gi2JcAIWC9(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			gi2JcAIWC9(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			gi2JcAIWC9(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			gi2JcAIWC9(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			gi2JcAIWC9(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			gi2JcAIWC9(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			gi2JcAIWC9(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			gi2JcAIWC9(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			gi2JcAIWC9(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			gi2JcAIWC9(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			gi2JcAIWC9(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			gi2JcAIWC9(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			ucQJ316ERq(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			ucQJ316ERq(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			ucQJ316ERq(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			ucQJ316ERq(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			ucQJ316ERq(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			ucQJ316ERq(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			ucQJ316ERq(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			ucQJ316ERq(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			ucQJ316ERq(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			ucQJ316ERq(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			ucQJ316ERq(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			ucQJ316ERq(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			ucQJ316ERq(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			ucQJ316ERq(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			ucQJ316ERq(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			ucQJ316ERq(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			wBTJLHKL87(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			wBTJLHKL87(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			wBTJLHKL87(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			wBTJLHKL87(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			wBTJLHKL87(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			wBTJLHKL87(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			wBTJLHKL87(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			wBTJLHKL87(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			wBTJLHKL87(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			wBTJLHKL87(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			wBTJLHKL87(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			wBTJLHKL87(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			wBTJLHKL87(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			wBTJLHKL87(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			wBTJLHKL87(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			wBTJLHKL87(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			CuUJHVB5J8(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			CuUJHVB5J8(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			CuUJHVB5J8(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			CuUJHVB5J8(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			CuUJHVB5J8(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			CuUJHVB5J8(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			CuUJHVB5J8(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			CuUJHVB5J8(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			CuUJHVB5J8(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			CuUJHVB5J8(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			CuUJHVB5J8(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			CuUJHVB5J8(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			CuUJHVB5J8(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			CuUJHVB5J8(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			CuUJHVB5J8(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			CuUJHVB5J8(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void gi2JcAIWC9(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + ittJf1GfMT(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + FtJ0wLORnD[uint_5 - 1], ushort_0);
	}

	private static void ucQJ316ERq(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + ittJf1GfMT(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + FtJ0wLORnD[uint_5 - 1], ushort_0);
	}

	private static void wBTJLHKL87(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + ittJf1GfMT(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + FtJ0wLORnD[uint_5 - 1], ushort_0);
	}

	private static void CuUJHVB5J8(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + ittJf1GfMT(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + FtJ0wLORnD[uint_5 - 1], ushort_0);
	}

	private static uint ittJf1GfMT(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool g9bJ5S6oPm()
	{
		if (!uul0lSCU7j)
		{
			Wu5JoBWvM2();
			uul0lSCU7j = true;
		}
		return fJIeowCM2Y;
	}

	internal static SymmetricAlgorithm ByhJX6rqeX()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (g9bJ5S6oPm())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)Activator.CreateInstance(K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(0), K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(160))!.Unwrap();
		}
	}

	internal static void Wu5JoBWvM2()
	{
		try
		{
			fJIeowCM2Y = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] u05JImyAqC(byte[] byte_0)
	{
		if (!g9bJ5S6oPm())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return tDxJh3D1jF(byte_0);
	}

	internal static void draJCETNfP(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			FkAJm8cFdK(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void FkAJm8cFdK(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint pG2JulkmHp(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
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
				num4 = binaryReader_0.ReadUInt32();
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

	public static void FqGJSPSbPj(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (D5o0pAmEWH == null)
			{
				lock (IBa0avxa2L)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554469)).Assembly.GetManifestResourceStream(K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(270)));
					binaryReader.BaseStream.Position = 0L;
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
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
							num3 += LxQJzsH2Ry(num3);
							if (i == num2 - 1 && num > 0)
							{
								uint num9 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num9 & num7) >> num8);
								}
							}
							else
							{
								uint num10 = num3 ^ num4;
								array2[num6] = (byte)(num10 & 0xFFu);
								array2[num6 + 1] = (byte)((num10 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num10 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num11 = array.Length / 8;
						eTMvoS42v7M77b7grCN eTMvoS42v7M77b7grCN = new eTMvoS42v7M77b7grCN(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = eTMvoS42v7M77b7grCN.VVP09HNALm();
							int value = eTMvoS42v7M77b7grCN.VVP09HNALm();
							dictionary.Add(key, value);
						}
						eTMvoS42v7M77b7grCN.zfJ0rLEUPV();
					}
					D5o0pAmEWH = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = D5o0pAmEWH[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554469)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
					continue;
				}
				ParameterInfo[] parameters = methodInfo.GetParameters();
				int num13 = parameters.Length + 1;
				Type[] array3 = new Type[num13];
				if (methodInfo.DeclaringType!.IsValueType)
				{
					array3[0] = methodInfo.DeclaringType!.MakeByRefType();
				}
				else
				{
					array3[0] = Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(16777236));
				}
				for (int n = 0; n < parameters.Length; n++)
				{
					array3[n + 1] = parameters[n].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				for (int num14 = 0; num14 < num13; num14++)
				{
					switch (num14)
					{
					default:
						iLGenerator.Emit(OpCodes.Ldarg_S, num14);
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
						iLGenerator.Emit(OpCodes.Ldarg_3);
						break;
					}
				}
				iLGenerator.Emit(OpCodes.Tailcall);
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
				iLGenerator.Emit(OpCodes.Ret);
				fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint fB5JDgnAQx(uint uint_0)
	{
		return (uint)K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(348).Length;
	}

	private static uint LxQJzsH2Ry(uint uint_0)
	{
		return 0u;
	}

	internal static void WUaeYdNn2x()
	{
	}

	[SQ5Vv644gjvJ1OZ46Xt(typeof(SQ5Vv644gjvJ1OZ46Xt.k2WWaX4JH6ysvSNcvf7<object>[]))]
	internal static string vXpe4HnnoY(int int_0)
	{
		int num = 45;
		byte[] array3 = default(byte[]);
		int num4 = default(int);
		int num3 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		uint num8 = default(uint);
		uint num16 = default(uint);
		byte[] array2 = default(byte[]);
		int num5 = default(int);
		int num12 = default(int);
		int num24 = default(int);
		int num14 = default(int);
		CryptoStream object_3 = default(CryptoStream);
		Stream stream = default(Stream);
		ICryptoTransform transform = default(ICryptoTransform);
		SymmetricAlgorithm object_2 = default(SymmetricAlgorithm);
		uint num6 = default(uint);
		byte[] array7 = default(byte[]);
		int num17 = default(int);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		int num25 = default(int);
		byte[] array6 = default(byte[]);
		int num11 = default(int);
		byte[] array = default(byte[]);
		uint num7 = default(uint);
		uint num13 = default(uint);
		uint num18 = default(uint);
		int num19 = default(int);
		int num21 = default(int);
		uint num20 = default(uint);
		uint num15 = default(uint);
		string result = default(string);
		int int_ = default(int);
		int num27 = default(int);
		int num29 = default(int);
		while (true)
		{
			if (gdd0nOb1my.Length == 0)
			{
				while (true)
				{
					eTMvoS42v7M77b7grCN object_ = new eTMvoS42v7M77b7grCN((Stream)NSJeOgIrAh(xZdeXVsVoR, K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(402)));
					int num2 = 112;
					if (!o8peHDccVx())
					{
						goto IL_0171;
					}
					goto IL_22ea;
					IL_22ea:
					while (true)
					{
						switch (num2)
						{
						case 452:
							array3[5] = (byte)num4;
							goto case 415;
						case 415:
							num3 = 95;
							num = 451;
							goto case 451;
						case 451:
							array3[5] = (byte)num3;
							num2 = 390;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 442;
						case 442:
							num4 = 150;
							goto case 169;
						case 169:
							array3[5] = (byte)num4;
							goto case 94;
						case 94:
							num4 = 118;
							goto case 150;
						case 150:
							array3[5] = (byte)num4;
							goto case 192;
						case 192:
							array3[5] = 250;
							goto case 22;
						case 22:
							array3[6] = 85;
							num = 183;
							goto case 183;
						case 183:
							num3 = 115;
							goto case 174;
						case 174:
							array3[6] = (byte)num3;
							goto case 70;
						case 70:
							num4 = 93;
							goto case 391;
						case 391:
							array3[6] = (byte)num4;
							goto case 433;
						case 433:
							array3[6] = 169;
							goto case 60;
						case 60:
							num3 = 168;
							num2 = 109;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 419;
						case 419:
							array3[6] = (byte)num3;
							goto case 299;
						case 299:
							array3[6] = 201;
							goto case 34;
						case 34:
							num4 = 116;
							goto case 110;
						case 110:
							array3[7] = (byte)num4;
							goto case 371;
						case 371:
							num4 = 152;
							goto case 422;
						case 422:
							array3[7] = (byte)num4;
							num2 = 221;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 152;
						case 152:
							if (num9 != num10 - 1)
							{
								goto case 71;
							}
							num2 = 264;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 71:
							num8 += num16;
							num2 = 360;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 450:
							array2[7] = (byte)num5;
							goto case 21;
						case 21:
							array2[7] = 143;
							num = 2;
							goto case 2;
						case 2:
							array2[7] = 111;
							goto case 144;
						case 144:
							array2[8] = 110;
							goto case 164;
						case 164:
							num5 = 116;
							num = 86;
							goto case 86;
						case 86:
							array2[8] = (byte)num5;
							num = 13;
							goto case 13;
						case 13:
							array2[8] = 70;
							goto case 78;
						case 78:
							num5 = 44;
							num2 = 173;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 280;
						case 280:
							array2[9] = (byte)num5;
							num = 246;
							goto case 246;
						case 246:
							num5 = 97;
							goto case 393;
						case 393:
							array2[9] = (byte)num5;
							num2 = 155;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 449:
							num3 = 77;
							goto case 190;
						case 190:
							array3[4] = (byte)num3;
							goto case 389;
						case 389:
							array3[4] = 99;
							num2 = 89;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 88;
						case 88:
							num5 = 128;
							num2 = 58;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 345;
						case 345:
							array2[1] = (byte)num5;
							num = 49;
							goto case 49;
						case 49:
							num5 = 187;
							goto case 7;
						case 7:
							array2[1] = (byte)num5;
							goto case 131;
						case 131:
							num5 = 100;
							num2 = 106;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 107;
						case 107:
							array2[2] = (byte)num5;
							goto case 10;
						case 10:
							num5 = 133;
							num2 = 266;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 448:
							num5 = 100;
							goto case 398;
						case 398:
							array2[0] = (byte)num5;
							num2 = 52;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 74:
						case 447:
							if (num9 >= num10)
							{
								num2 = 109;
								if (o8peHDccVx())
								{
									continue;
								}
								goto IL_0171;
							}
							goto case 111;
						case 111:
							num12 = num9 % num24;
							num2 = 63;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 108;
						case 108:
							num14 = num9 * 4;
							num2 = 136;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 446:
							array2[15] = (byte)num5;
							goto case 123;
						case 123:
							array2[15] = 92;
							goto case 36;
						case 36:
							array2[15] = 13;
							num2 = 112;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 165;
						case 165:
							num5 = 146;
							goto case 76;
						case 76:
							array2[16] = (byte)num5;
							goto case 380;
						case 380:
							array2[16] = 107;
							goto case 311;
						case 311:
							array2[16] = 138;
							goto case 14;
						case 14:
							num5 = 139;
							num2 = 189;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 445:
							object_3 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
							num2 = 256;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 444:
							array3[14] = (byte)num3;
							goto case 270;
						case 270:
							num3 = 105;
							num2 = 73;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 308;
						case 308:
							array3[14] = (byte)num3;
							goto case 167;
						case 167:
							num4 = 152;
							goto case 240;
						case 240:
							array3[15] = (byte)num4;
							num2 = 126;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 443:
							array2[28] = 140;
							num2 = 158;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 378;
						case 378:
							num5 = 21;
							goto case 300;
						case 300:
							array2[28] = (byte)num5;
							goto case 72;
						case 72:
							num5 = 142;
							num2 = 97;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 272;
						case 272:
							array2[29] = (byte)num5;
							goto case 357;
						case 357:
							num5 = 135;
							goto case 205;
						case 205:
							array2[29] = (byte)num5;
							num2 = 148;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 160;
						case 160:
							num5 = 128;
							goto case 226;
						case 226:
							array2[29] = (byte)num5;
							num2 = 274;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 441:
							array2[4] = 60;
							goto case 247;
						case 247:
							num5 = 102;
							num = 346;
							goto case 346;
						case 346:
							array2[4] = (byte)num5;
							goto case 390;
						case 390:
							array2[4] = 73;
							num = 26;
							goto case 26;
						case 26:
							num5 = 123;
							goto case 178;
						case 178:
							array2[5] = (byte)num5;
							num2 = 269;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 440:
							array3[0] = (byte)num4;
							num2 = 54;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 439:
							num3 = 164;
							num2 = 1;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 438:
							object_2 = (SymmetricAlgorithm)iNpeKCO9qe();
							num2 = 51;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 50;
						case 50:
							array2[17] = 187;
							goto case 384;
						case 384:
							num5 = 125;
							num2 = 410;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 437:
							num6 <<= 8;
							goto case 232;
						case 232:
							num6 |= array7[^(1 + num17)];
							goto case 295;
						case 295:
							num17++;
							num2 = 87;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 436:
							array4[1] = array5[0];
							num2 = 69;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 435:
							array3[11] = 96;
							num2 = 273;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 116;
						case 116:
							num5 = 177;
							num2 = 4;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 434:
							array2[21] = 220;
							num2 = 428;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 432:
							array2[18] = (byte)num5;
							goto case 161;
						case 161:
							num5 = 94;
							goto case 330;
						case 330:
							array2[18] = (byte)num5;
							num = 426;
							goto case 426;
						case 426:
							num5 = 156;
							num2 = 235;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 431:
							array2[2] = (byte)num5;
							num2 = 0;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 430:
							array3[14] = 163;
							goto case 41;
						case 41:
							num3 = 107;
							num2 = 444;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 357;
						case 429:
							array2[23] = (byte)num5;
							goto case 177;
						case 177:
							array2[24] = 152;
							goto case 77;
						case 77:
							num5 = 46;
							num2 = 20;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 4;
						case 4:
							array2[14] = (byte)num5;
							num2 = 281;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 428:
							array2[22] = 67;
							num = 239;
							goto case 239;
						case 239:
							num5 = 80;
							goto case 408;
						case 408:
							array2[22] = (byte)num5;
							num2 = 423;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 427:
							array2[11] = (byte)num5;
							num2 = 382;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 425:
							num5 = 142;
							goto case 293;
						case 293:
							array2[14] = (byte)num5;
							goto case 59;
						case 59:
							num5 = 103;
							num2 = 47;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 424:
							array3[9] = 99;
							goto case 25;
						case 25:
							array3[9] = 107;
							goto case 317;
						case 317:
							array3[9] = 233;
							goto case 28;
						case 28:
							array3[9] = 154;
							num = 99;
							goto case 99;
						case 99:
							array3[9] = 194;
							num2 = 96;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 423:
							num5 = 143;
							num2 = 335;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 421:
							array4[5] = array5[2];
							goto case 332;
						case 332:
							array4[7] = array5[3];
							num2 = 248;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 420:
							array2 = new byte[32];
							num2 = 151;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 142;
						case 142:
							array3[11] = (byte)num4;
							num2 = 57;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 418:
							if (num17 > 0)
							{
								goto case 437;
							}
							goto case 232;
						case 417:
							array2[0] = (byte)num5;
							goto case 85;
						case 85:
							array2[1] = 94;
							num2 = 88;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 416:
							array2[20] = (byte)num5;
							goto case 315;
						case 315:
							array2[21] = 118;
							goto case 307;
						case 307:
							num5 = 140;
							num2 = 202;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 414:
							num5 = 166;
							goto case 305;
						case 305:
							array2[13] = (byte)num5;
							num2 = 277;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 61;
						case 61:
							array3[3] = (byte)num3;
							num = 127;
							goto case 127;
						case 127:
							num3 = 158;
							goto case 394;
						case 394:
							array3[3] = (byte)num3;
							num2 = 403;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 413:
							array3[12] = (byte)num3;
							num2 = 55;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 54;
						case 54:
							array3[0] = 168;
							num2 = 291;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 412:
							num5 = 133;
							goto case 401;
						case 401:
							array2[24] = (byte)num5;
							goto case 250;
						case 250:
							num5 = 168;
							goto case 130;
						case 130:
							array2[24] = (byte)num5;
							num2 = 344;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 411:
							array3[7] = (byte)num3;
							num2 = 316;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 410:
							array2[17] = (byte)num5;
							num2 = 9;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 409:
							array2[6] = (byte)num5;
							num2 = 102;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 120;
						case 120:
							array2[6] = 126;
							goto case 312;
						case 312:
							array2[6] = 224;
							num2 = 179;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 47;
						case 47:
							array2[14] = (byte)num5;
							goto case 116;
						case 407:
							gX3eAIEVJJ(array4);
							goto case 322;
						case 322:
							array5 = (byte[])Au8egyNrTy(SSleQeW5QU(xZdeXVsVoR));
							goto case 118;
						case 118:
							if (array5 != null)
							{
								goto case 381;
							}
							goto case 349;
						case 381:
							if (array5.Length > 0)
							{
								goto case 436;
							}
							goto case 349;
						case 349:
							num25 = 0;
							num = 180;
							goto case 24;
						case 216:
							array6[num25] = (byte)(array6[num25] ^ array4[num25]);
							goto case 348;
						case 348:
							num25++;
							num = 24;
							goto case 24;
						case 24:
						case 180:
							if (num25 >= array4.Length)
							{
								num2 = 11;
								if (o8peHDccVx())
								{
									continue;
								}
								goto IL_0171;
							}
							goto case 216;
						case 406:
							array3[12] = 135;
							goto case 80;
						case 80:
							num3 = 110;
							num2 = 138;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 405:
							array7 = gdd0nOb1my;
							goto case 376;
						case 376:
							num11 = array7.Length % 4;
							goto case 325;
						case 325:
							num10 = array7.Length / 4;
							goto case 359;
						case 359:
							array = new byte[array7.Length];
							goto case 145;
						case 145:
							num24 = array6.Length / 4;
							goto case 35;
						case 35:
							num8 = 0u;
							num2 = 379;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 404:
							num4 = 168;
							goto case 53;
						case 53:
							array3[1] = (byte)num4;
							num = 65;
							goto case 65;
						case 65:
							num4 = 218;
							goto case 329;
						case 329:
							array3[1] = (byte)num4;
							goto case 211;
						case 211:
							array3[2] = 88;
							num2 = 250;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 267;
						case 267:
							num4 = 75;
							goto case 351;
						case 351:
							array3[2] = (byte)num4;
							goto case 79;
						case 79:
							num4 = 88;
							num = 30;
							goto case 30;
						case 30:
							array3[2] = (byte)num4;
							goto case 350;
						case 350:
							array3[2] = 130;
							goto case 297;
						case 297:
							num4 = 87;
							goto case 121;
						case 121:
							array3[2] = (byte)num4;
							goto case 275;
						case 275:
							num4 = 137;
							goto case 148;
						case 148:
							array3[2] = (byte)num4;
							num2 = 253;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 336;
						case 336:
							array3[3] = 117;
							goto case 439;
						case 403:
							array3[3] = 241;
							goto case 449;
						case 402:
							array2[26] = 166;
							num2 = 22;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 220;
						case 220:
							array2[26] = 144;
							goto case 313;
						case 313:
							array2[26] = 24;
							num2 = 41;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 104;
						case 104:
							array2[27] = 130;
							num2 = 36;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 362;
						case 362:
							num5 = 85;
							goto case 373;
						case 373:
							array2[27] = (byte)num5;
							num2 = 23;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 400:
							array2[31] = (byte)num5;
							num2 = 257;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 361;
						case 361:
							array2[31] = 81;
							goto case 286;
						case 286:
							array2[31] = 165;
							goto case 197;
						case 197:
							array2[31] = 153;
							goto case 310;
						case 310:
							array6 = array2;
							goto case 276;
						case 276:
							array3 = new byte[16];
							num2 = 319;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 399:
							array2[30] = (byte)num5;
							goto case 236;
						case 236:
							array2[30] = 204;
							num2 = 67;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 397:
							num4 = 114;
							num2 = 15;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 5;
						case 5:
							array3[7] = (byte)num3;
							goto case 318;
						case 318:
							num3 = 253;
							num = 411;
							goto case 411;
						case 396:
						{
							uint num22 = num7;
							uint num23 = num7;
							num23 ^= num23 << 16;
							num23 += 1008043104;
							num23 ^= num23 << 9;
							num23 += 1367656298;
							num23 ^= num23 >> 21;
							num23 += 2118852622;
							num23 = 2129991649 + num23;
							num7 = num22 + (uint)(double)num23;
							num2 = 83;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						}
						case 395:
							array2[0] = 151;
							num2 = 448;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 392:
							array2[5] = 226;
							num = 97;
							goto case 97;
						case 97:
							num5 = 230;
							num2 = 45;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 409;
						case 388:
							stream = (Stream)PcNe9d7rt9();
							num2 = 445;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 387:
							array4[11] = array5[5];
							num2 = 16;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 386:
							num3 = 176;
							num2 = 89;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 193;
						case 193:
							array3[11] = (byte)num3;
							goto case 3;
						case 3:
							num4 = 114;
							goto case 142;
						case 385:
							array2[31] = 143;
							num2 = 260;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 383:
							num4 = 211;
							goto case 368;
						case 368:
							array3[10] = (byte)num4;
							num2 = 268;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 382:
							array2[11] = 123;
							num2 = 365;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 379:
							num16 = 0u;
							goto case 102;
						case 102:
							num6 = 0u;
							goto case 176;
						case 176:
							if (num11 > 0)
							{
								num2 = 184;
								if (eoHefTNf5Z() == null)
								{
									continue;
								}
								goto IL_0171;
							}
							goto case 42;
						case 42:
							num13 = 0u;
							num2 = 309;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 377:
							num5 = 103;
							num = 194;
							goto case 194;
						case 194:
							array2[23] = (byte)num5;
							goto case 119;
						case 119:
							num5 = 114;
							goto case 429;
						case 375:
							array2[4] = (byte)num5;
							num2 = 331;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 200;
						case 200:
						case 294:
							num9++;
							num2 = 447;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 374:
							num3 = 135;
							num2 = 413;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 123;
						case 372:
							array2[3] = 144;
							num2 = 370;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 55;
						case 55:
							num4 = 76;
							goto case 355;
						case 355:
							array3[12] = (byte)num4;
							num2 = 397;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 370:
							num5 = 28;
							goto case 207;
						case 207:
							array2[3] = (byte)num5;
							goto case 168;
						case 168:
							num5 = 136;
							goto case 39;
						case 39:
							array2[4] = (byte)num5;
							goto case 115;
						case 115:
							num5 = 161;
							goto case 375;
						case 369:
							array2[2] = 84;
							num2 = 228;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 367:
							array7 = (byte[])OKOeEJSClu(object_, (int)BMseM8NOuR(CyheGuvA1x(object_)));
							goto case 73;
						case 73:
							zDcebIttha(object_);
							num2 = 420;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 365:
							num5 = 119;
							num2 = 12;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 4;
						case 364:
							array2[20] = (byte)num5;
							num2 = 86;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 201;
						case 201:
							num5 = 168;
							num2 = 416;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 266;
						case 266:
							array2[2] = (byte)num5;
							goto case 369;
						case 363:
							num5 = 138;
							goto case 48;
						case 48:
							array2[3] = (byte)num5;
							goto case 372;
						case 360:
							num13 = (uint)num14;
							num = 244;
							goto case 244;
						case 244:
							num6 = (uint)((array7[num13 + 3] << 24) | (array7[num13 + 2] << 16) | (array7[num13 + 1] << 8) | array7[num13]);
							num2 = 285;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 182;
						case 182:
							array3[13] = (byte)num3;
							num = 181;
							goto case 181;
						case 181:
							num3 = 59;
							goto case 254;
						case 254:
							array3[14] = (byte)num3;
							goto case 430;
						case 358:
							num5 = 212;
							num2 = 68;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 356:
							num3 = 162;
							num = 5;
							goto case 5;
						case 354:
							array3[11] = (byte)num3;
							num2 = 16;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 66;
						case 66:
							num3 = 122;
							goto case 306;
						case 306:
							array3[11] = (byte)num3;
							goto case 386;
						case 353:
							array3[8] = 23;
							goto case 424;
						case 352:
							array3[15] = (byte)num3;
							goto case 158;
						case 158:
							num4 = 183;
							goto case 124;
						case 124:
							array3[15] = (byte)num4;
							num2 = 147;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 347:
							num5 = 88;
							goto case 206;
						case 206:
							array2[21] = (byte)num5;
							goto case 434;
						case 344:
							num5 = 235;
							goto case 215;
						case 215:
							array2[24] = (byte)num5;
							goto case 208;
						case 208:
							array2[25] = 112;
							num = 33;
							goto case 33;
						case 33:
							num5 = 108;
							goto case 46;
						case 46:
							array2[25] = (byte)num5;
							num2 = 282;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 226;
						case 343:
							array3[13] = (byte)num4;
							goto case 159;
						case 159:
							array3[13] = 88;
							num2 = 32;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 32;
						case 32:
							num3 = 106;
							num2 = 147;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 337;
						case 337:
							array3[13] = (byte)num3;
							goto case 271;
						case 271:
							num3 = 71;
							goto case 182;
						case 342:
							array2[20] = (byte)num5;
							goto case 233;
						case 233:
							array2[20] = 164;
							goto case 304;
						case 304:
							num5 = 102;
							goto case 364;
						case 341:
							array3[5] = (byte)num4;
							goto case 6;
						case 6:
							num4 = 126;
							goto case 452;
						case 340:
							array3[7] = (byte)num3;
							goto case 125;
						case 125:
							num3 = 40;
							num2 = 333;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 87:
						case 339:
							if (num17 < num11)
							{
								goto case 418;
							}
							goto case 285;
						case 285:
						case 301:
							num7 = num8;
							goto case 241;
						case 241:
							num8 = 0u;
							goto case 396;
						case 338:
							array3[8] = (byte)num3;
							goto case 84;
						case 84:
							array3[8] = 26;
							goto case 353;
						case 335:
							array2[22] = (byte)num5;
							goto case 143;
						case 143:
							array2[23] = 168;
							num2 = 196;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 334:
							array2[19] = 1;
							goto case 217;
						case 217:
							array2[20] = 123;
							num = 98;
							goto case 98;
						case 98:
							num5 = 153;
							num2 = 37;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 106;
						case 106:
							array2[20] = (byte)num5;
							num2 = 198;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 333:
							array3[7] = (byte)num3;
							goto case 356;
						case 331:
							array2[4] = 43;
							num2 = 441;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 328:
							num4 = 152;
							goto case 341;
						case 327:
							array2[11] = 148;
							goto case 209;
						case 209:
							array2[11] = 195;
							num2 = 43;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 326:
							num3 = 85;
							goto case 61;
						case 324:
							niOePrAZNO(object_3);
							goto case 405;
						case 323:
							array3[10] = 148;
							num2 = 383;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 337;
						case 321:
							num4 = 114;
							goto case 222;
						case 222:
							array3[1] = (byte)num4;
							num2 = 404;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 320:
							num18 <<= 8;
							goto case 218;
						case 218:
							num19 += 8;
							goto case 298;
						case 298:
							array[num14 + num21] = (byte)((num20 & num18) >> num19);
							goto case 229;
						case 229:
							num21++;
							goto case 92;
						case 170:
							if (num21 > 0)
							{
								num2 = 320;
								if (eoHefTNf5Z() == null)
								{
									continue;
								}
								goto IL_0171;
							}
							goto case 298;
						case 92:
						case 255:
							if (num21 >= num11)
							{
								goto case 200;
							}
							goto case 170;
						case 319:
							num3 = 150;
							num2 = 9;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 223;
						case 223:
							array3[0] = (byte)num3;
							num2 = 171;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 316:
							num3 = 76;
							goto case 338;
						case 314:
							array3[11] = (byte)num4;
							goto case 435;
						case 309:
							num9 = 0;
							goto case 74;
						case 302:
							num20 = num8 ^ num6;
							goto case 283;
						case 283:
							num21 = 0;
							goto case 92;
						case 296:
							num5 = 60;
							num2 = 164;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 261;
						case 261:
							array2[9] = (byte)num5;
							num2 = 105;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 50;
						case 292:
							num3 = 233;
							goto case 352;
						case 291:
							num3 = 100;
							num2 = 135;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 290:
							array2[18] = 131;
							num2 = 210;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 289:
							num5 = 163;
							goto case 173;
						case 173:
							array2[3] = (byte)num5;
							num2 = 277;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 363;
						case 288:
							num5 = 167;
							num2 = 279;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 287:
							array2[28] = (byte)num5;
							num2 = 203;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 284:
							array2[28] = 110;
							num = 146;
							goto case 146;
						case 146:
							num5 = 109;
							num = 287;
							goto case 287;
						case 282:
							array2[25] = 156;
							goto case 162;
						case 162:
							array2[25] = 144;
							goto case 91;
						case 91:
							array2[25] = 177;
							goto case 358;
						case 281:
							num5 = 126;
							goto case 132;
						case 132:
							array2[14] = (byte)num5;
							num2 = 25;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 187;
						case 187:
							num5 = 44;
							num2 = 18;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 279:
							array2[19] = (byte)num5;
							num2 = 334;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 167;
						case 278:
							array2[27] = (byte)num5;
							goto case 27;
						case 27:
							num5 = 154;
							num = 242;
							goto case 242;
						case 242:
							array2[28] = (byte)num5;
							goto case 284;
						case 277:
							array2[13] = 155;
							goto case 122;
						case 122:
							array2[13] = 138;
							goto case 252;
						case 252:
							num5 = 93;
							goto case 243;
						case 243:
							array2[13] = (byte)num5;
							goto case 231;
						case 231:
							array2[14] = 139;
							num2 = 425;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 274:
							array2[29] = 92;
							num2 = 6;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 8;
						case 8:
							array2[29] = 240;
							goto case 153;
						case 153:
							num5 = 140;
							goto case 399;
						case 273:
							num3 = 155;
							goto case 354;
						case 269:
							array2[5] = 201;
							num2 = 392;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 268:
							num3 = 54;
							num2 = 149;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 265:
							gdd0nOb1my = (byte[])DIweNTqZhE(stream);
							num2 = 8;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 93;
						case 93:
							niOePrAZNO(stream);
							goto case 324;
						case 264:
							if (num11 <= 0)
							{
								goto case 71;
							}
							num2 = 62;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 5;
						case 263:
							num5 = 153;
							goto case 214;
						case 214:
							array2[23] = (byte)num5;
							goto case 377;
						case 262:
							num5 = 221;
							goto case 417;
						case 260:
							num5 = 123;
							goto case 400;
						case 259:
							num4 = 106;
							goto case 343;
						case 258:
							num15 = num8 ^ num6;
							goto case 133;
						case 133:
							array[num14] = (byte)(num15 & 0xFFu);
							num2 = 26;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 113;
						case 113:
							array[num14 + 1] = (byte)((num15 & 0xFF00) >> 8);
							num2 = 185;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 257:
							array2[21] = (byte)num5;
							goto case 347;
						case 256:
							mH8er5Atnm(object_3, array7, 0, array7.Length);
							num2 = 204;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 253:
							array2[10] = 217;
							goto case 64;
						case 64:
							array2[11] = 215;
							goto case 327;
						case 251:
							array3[1] = 43;
							goto case 321;
						case 249:
							array2[10] = 99;
							goto case 253;
						case 248:
							array4[9] = array5[4];
							num2 = 387;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 245:
							num5 = 162;
							num2 = 31;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 238:
							num4 = 158;
							goto case 141;
						case 141:
							array3[15] = (byte)num4;
							goto case 292;
						case 237:
							num5 = 130;
							goto case 75;
						case 75:
							array2[16] = (byte)num5;
							num2 = 50;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 235:
							array2[19] = (byte)num5;
							goto case 288;
						case 234:
							num5 = 76;
							goto case 431;
						case 230:
							array2[31] = 147;
							goto case 385;
						case 228:
							array2[2] = 158;
							goto case 19;
						case 19:
							array2[2] = 70;
							goto case 234;
						case 227:
							array3[3] = 43;
							num2 = 326;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 225:
							array3[12] = 133;
							num2 = 290;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 374;
						case 224:
							array2[0] = 125;
							goto case 262;
						case 221:
							num3 = 110;
							num2 = 340;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 219:
							array4[15] = array5[7];
							goto case 349;
						case 213:
							array2[13] = (byte)num5;
							num2 = 245;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 212:
							num19 = 0;
							num = 152;
							goto case 152;
						case 210:
							num5 = 63;
							num2 = 432;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 204:
							kSpetdvTjd(object_3);
							num2 = 265;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 156;
						case 156:
							array2[10] = (byte)num5;
							goto case 249;
						case 203:
							array2[28] = 161;
							num = 443;
							goto case 443;
						case 202:
							array2[21] = (byte)num5;
							num2 = 17;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 199:
							array[num14 + 3] = (byte)((num15 & 0xFF000000u) >> 24);
							num2 = 294;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 198:
							num5 = 114;
							goto case 342;
						case 196:
							array2[23] = 90;
							goto case 263;
						case 195:
							num16 = (uint)((array6[num13 + 3] << 24) | (array6[num13 + 2] << 16) | (array6[num13 + 1] << 8) | array6[num13]);
							num = 134;
							goto case 134;
						case 134:
							num18 = 255u;
							goto case 212;
						case 191:
							num5 = 190;
							num = 446;
							goto case 446;
						case 189:
							array2[16] = (byte)num5;
							num2 = 237;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 166;
						case 166:
							num8 += num16;
							goto case 128;
						case 128:
							num17 = 0;
							num2 = 339;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 188:
							array2[15] = (byte)num5;
							goto case 157;
						case 157:
							array2[15] = 97;
							num2 = 191;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 123;
						case 186:
							num4 = 161;
							goto case 172;
						case 172:
							array3[15] = (byte)num4;
							goto case 238;
						case 185:
							array[num14 + 2] = (byte)((num15 & 0xFF0000) >> 16);
							goto case 199;
						case 184:
							num10++;
							goto case 42;
						case 179:
							num5 = 125;
							goto case 450;
						case 175:
							array2[12] = 98;
							goto case 56;
						case 56:
							array2[12] = 39;
							goto case 129;
						case 129:
							num5 = 57;
							goto case 213;
						case 171:
							array3[0] = 140;
							num2 = 154;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 14;
						case 163:
							array2[17] = (byte)num5;
							num = 117;
							goto case 117;
						case 117:
							array2[17] = 51;
							num2 = 139;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 155:
							array2[9] = 113;
							goto case 296;
						case 154:
							num4 = 88;
							goto case 440;
						case 151:
							array2[0] = 95;
							num2 = 395;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 149:
							array3[10] = (byte)num3;
							goto case 114;
						case 114:
							num4 = 182;
							num2 = 314;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 122;
						case 147:
							array4 = array3;
							num2 = 407;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 9;
						case 9:
							num5 = 92;
							goto case 163;
						case 140:
							array2[3] = 143;
							goto case 289;
						case 139:
							array2[17] = 221;
							goto case 95;
						case 95:
							array2[18] = 105;
							goto case 290;
						case 138:
							array3[12] = (byte)num3;
							num2 = 225;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 136:
							num13 = (uint)(num12 * 4);
							num2 = 98;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 195;
						case 135:
							array3[1] = (byte)num3;
							num2 = 63;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 15;
						case 15:
							array3[13] = (byte)num4;
							goto case 259;
						case 126:
							num4 = 126;
							goto case 58;
						case 58:
							array3[15] = (byte)num4;
							num = 186;
							goto case 186;
						case 112:
							qWjeTvIk48(CyheGuvA1x(object_), 0L);
							num2 = 286;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 367;
						case 105:
							num5 = 147;
							goto case 156;
						case 103:
							transform = (ICryptoTransform)RFje6FD34S(object_2, array6, array4);
							num2 = 388;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 100:
							array3[12] = (byte)num3;
							goto case 406;
						case 96:
							array3[10] = 153;
							goto case 323;
						case 90:
							num5 = 43;
							goto case 188;
						case 89:
							array3[4] = 166;
							goto case 328;
						case 83:
							num8 = num7;
							goto case 37;
						case 37:
							if (num9 != num10 - 1)
							{
								goto case 258;
							}
							goto case 38;
						case 38:
							if (num11 > 0)
							{
								goto case 302;
							}
							goto case 258;
						case 82:
							num5 = 206;
							num2 = 73;
							if (eoHefTNf5Z() != null)
							{
								continue;
							}
							goto case 257;
						case 81:
							array3[1] = (byte)num4;
							goto case 251;
						case 69:
							array4[3] = array5[1];
							num = 421;
							goto case 421;
						case 68:
							array2[25] = (byte)num5;
							goto case 402;
						case 67:
							num5 = 138;
							num2 = 40;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						case 63:
							num4 = 97;
							goto case 81;
						case 62:
							num6 = 0u;
							num2 = 166;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 4;
						case 57:
							num3 = 83;
							num2 = 64;
							if (!o8peHDccVx())
							{
								continue;
							}
							goto case 100;
						case 52:
							array2[0] = 167;
							goto case 224;
						case 51:
							HN7eRS092a(object_2, CipherMode.CBC);
							num = 103;
							goto case 103;
						case 43:
							num5 = 97;
							goto case 427;
						case 40:
							array2[30] = (byte)num5;
							num2 = 230;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto IL_0171;
						case 31:
							array2[13] = (byte)num5;
							num2 = 414;
							if (o8peHDccVx())
							{
								continue;
							}
							goto case 355;
						case 29:
							array2[21] = (byte)num5;
							goto case 82;
						case 23:
							num5 = 145;
							goto case 278;
						case 20:
							array2[24] = (byte)num5;
							num2 = 412;
							if (eoHefTNf5Z() == null)
							{
								continue;
							}
							goto case 378;
						case 18:
							array2[14] = (byte)num5;
							goto case 90;
						case 17:
							num5 = 138;
							num = 29;
							goto case 29;
						case 16:
							array4[13] = array5[6];
							goto case 219;
						case 12:
							array2[12] = (byte)num5;
							num = 175;
							goto case 175;
						case 11:
							if (int_0 == -1)
							{
								num2 = 438;
								if (eoHefTNf5Z() == null)
								{
									continue;
								}
								goto IL_0171;
							}
							goto case 376;
						case 1:
							array3[3] = (byte)num3;
							num2 = 227;
							if (o8peHDccVx())
							{
								continue;
							}
							goto IL_0171;
						default:
							array2[3] = 128;
							goto case 140;
						case 137:
							break;
						case 45:
							goto end_IL_2a08;
						case 109:
							gdd0nOb1my = array;
							num = 366;
							goto IL_2a53;
						case 44:
						case 366:
							goto IL_2a53;
						case 101:
							goto IL_2a60;
						case 303:
							goto end_IL_2a38;
						}
						break;
					}
					continue;
					IL_0171:
					num2 = num;
					goto IL_22ea;
					continue;
					end_IL_2a08:
					break;
				}
				continue;
			}
			goto IL_2a53;
			IL_2a60:
			try
			{
				lWAec2C0ZM();
				int num26 = 0;
				if (o8peHDccVx())
				{
					goto IL_2a73;
				}
				goto IL_2a9a;
				IL_2a9a:
				switch (num26)
				{
				case 1:
					return result;
				}
				goto IL_2a73;
				IL_2a73:
				result = (string)OcgeLsYOkr(aGse3Cv591(), gdd0nOb1my, int_0 + 4, int_);
				num26 = 1;
				if (!o8peHDccVx())
				{
					num26 = num27;
				}
				goto IL_2a9a;
			}
			catch
			{
				int num28 = 0;
				if (eoHefTNf5Z() != null)
				{
					num28 = num29;
				}
				switch (num28)
				{
				}
			}
			break;
			IL_2a53:
			int_ = HKAehRgimk(gdd0nOb1my, int_0);
			goto IL_2a60;
			continue;
			end_IL_2a38:
			break;
		}
		return "";
	}

	[SQ5Vv644gjvJ1OZ46Xt(typeof(SQ5Vv644gjvJ1OZ46Xt.k2WWaX4JH6ysvSNcvf7<object>[]))]
	internal static string qNMeJKJ5cc(string string_0)
	{
		K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(480).Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int o5ueeD7xTl()
	{
		return 5;
	}

	private static void oP1e0Ca2m2()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate JshelTs6Wf(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(16777310)).GetMethod(K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(534), new Type[2]
		{
			Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(16777250)),
			Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(16777257))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object YeLeslomMK(object object_0)
	{
		try
		{
			if (File.Exists(((Assembly)object_0).Location))
			{
				return ((Assembly)object_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((Assembly)object_0).GetName().CodeBase!.ToString().Replace(K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(596), "")))
			{
				return ((Assembly)object_0).GetName().CodeBase!.ToString().Replace(K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(596), "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(object_0.GetType().GetProperty(K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(616))!.GetValue(object_0, new object[0])!.ToString()))
			{
				return object_0.GetType().GetProperty(K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(616))!.GetValue(object_0, new object[0])!.ToString();
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

	private static IntPtr gALeyUx0ox(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (OZ80YcV9RW == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(636).Trim() + K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(650));
			OZ80YcV9RW = (empf4r4yAk7MCWuEdYi)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554478)));
		}
		return OZ80YcV9RW(intptr_0, string_0, uint_0);
	}

	private static IntPtr SLievD3SI7(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (G1601lalYt == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(672).Trim() + K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(692));
			G1601lalYt = (UPZAZC4vOQgfTXp0SIw)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554479)));
		}
		return G1601lalYt(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int VeTeat6D5r(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (opH0yjhF8Q == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(706).Trim() + K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(722).Trim() + K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(742));
			opH0yjhF8Q = (BBay724addf97DtxLLM)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554480)));
		}
		return opH0yjhF8Q(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int eJwe7oSfeX(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (mPN04V1e2r == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(672).Trim() + K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(758));
			mPN04V1e2r = (a18NER47tfqAWVswXn2)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554481)));
		}
		return mPN04V1e2r(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr jIEeWOL2XQ(uint uint_0, int int_0, uint uint_1)
	{
		if (Geg0Jsmcgl == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(776).Trim() + K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(790));
			Geg0Jsmcgl = (eidVQ84W5sd0GleHkkg)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554482)));
		}
		return Geg0Jsmcgl(uint_0, int_0, uint_1);
	}

	private static int tGfepMtdEb(IntPtr intptr_0)
	{
		if (vmK0eQSuEk == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(808).Trim() + K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(824));
			vmK0eQSuEk = (i7bXcI4pcEwsV0Suw8G)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(b8EMs849NOuR3KOJSCl.SVK2lyCMuaNuT(33554483)));
		}
		return vmK0eQSuEk(intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (KFx0kJRwqj == IntPtr.Zero)
		{
			KFx0kJRwqj = LoadLibrary(K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(840).Trim() + K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(858));
		}
		return KFx0kJRwqj;
	}

	[SQ5Vv644gjvJ1OZ46Xt(typeof(SQ5Vv644gjvJ1OZ46Xt.k2WWaX4JH6ysvSNcvf7<object>[]))]
	private static byte[] K6IedociEQ(string string_0)
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

	internal static Stream lx6ei5IhGC()
	{
		return new MemoryStream();
	}

	internal static byte[] hLEenH5Ck3(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[SQ5Vv644gjvJ1OZ46Xt(typeof(SQ5Vv644gjvJ1OZ46Xt.k2WWaX4JH6ysvSNcvf7<object>[]))]
	private static byte[] mOyeqShsoa(byte[] byte_0)
	{
		Stream stream = lx6ei5IhGC();
		SymmetricAlgorithm symmetricAlgorithm = ByhJX6rqeX();
		symmetricAlgorithm.Key = new byte[32]
		{
			139, 4, 195, 91, 166, 55, 214, 133, 231, 239,
			153, 104, 146, 162, 221, 252, 236, 110, 195, 72,
			15, 48, 179, 233, 195, 107, 253, 71, 62, 172,
			156, 213
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			47, 50, 96, 234, 204, 136, 66, 42, 238, 198,
			86, 212, 115, 27, 59, 167
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = hLEenH5Ck3(stream);
		ud9OYc4i7bqX53MRDiY.tvE0cQ1Gob();
		return result;
	}

	private byte[] K5Uej4t7ot()
	{
		return null;
	}

	private byte[] X7Kew7mG3k()
	{
		return null;
	}

	private byte[] kXoe1RD4O0()
	{
		string text = K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(874);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] LOde8j1Y87()
	{
		string text = K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(928);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] TR7ekflAmm()
	{
		string text = K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(982);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] xk1eU9YrBF()
	{
		string text = K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(1036);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] ifrexfya2h()
	{
		string text = K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(1090);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] eP7eZ4wFPQ()
	{
		string text = K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(1144);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] QTgeFyFvSu()
	{
		string text = K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(1198);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] qUheBceXCd()
	{
		string text = K1GfMT41V9bS6oPmMyh.yx7lVsGYGq(1252);
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	public sD2Wk4DskFhChtylq3()
	{
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		base._002Ector();
	}

	internal static object NSJeOgIrAh(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object CyheGuvA1x(object object_0)
	{
		return ((eTMvoS42v7M77b7grCN)object_0).KDikMXewCI();
	}

	internal static void qWjeTvIk48(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long BMseM8NOuR(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object OKOeEJSClu(object object_0, int int_0)
	{
		return ((eTMvoS42v7M77b7grCN)object_0).CCd0RuQxaA(int_0);
	}

	internal static void zDcebIttha(object object_0)
	{
		((eTMvoS42v7M77b7grCN)object_0).zfJ0rLEUPV();
	}

	internal static void gX3eAIEVJJ(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object SSleQeW5QU(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object Au8egyNrTy(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object iNpeKCO9qe()
	{
		return ByhJX6rqeX();
	}

	internal static void HN7eRS092a(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object RFje6FD34S(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object PcNe9d7rt9()
	{
		return lx6ei5IhGC();
	}

	internal static void mH8er5Atnm(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void kSpetdvTjd(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object DIweNTqZhE(object object_0)
	{
		return hLEenH5Ck3((Stream)object_0);
	}

	internal static void niOePrAZNO(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int HKAehRgimk(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void lWAec2C0ZM()
	{
		ud9OYc4i7bqX53MRDiY.tvE0cQ1Gob();
	}

	internal static object aGse3Cv591()
	{
		return Encoding.Unicode;
	}

	internal static object OcgeLsYOkr(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool o8peHDccVx()
	{
		return (object)null == null;
	}

	internal static object eoHefTNf5Z()
	{
		return null;
	}
}
