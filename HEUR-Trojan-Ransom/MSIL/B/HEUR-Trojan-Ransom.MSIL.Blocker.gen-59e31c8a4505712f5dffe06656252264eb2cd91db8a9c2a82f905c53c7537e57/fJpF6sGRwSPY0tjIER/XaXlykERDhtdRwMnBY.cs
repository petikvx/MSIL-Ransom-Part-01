using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using cCMBEkOBGIwpDnI0MY;
using zjWSh2Z73jBs4TcJ0x;

namespace fJpF6sGRwSPY0tjIER;

internal class XaXlykERDhtdRwMnBY
{
	private delegate void UOrLP1fSY40G57Ccaw(object o);

	internal class cGSyB0mPjBPwJniINo : Attribute
	{
		internal class tPaBOKHyTPH1a50Q7R<LV5u8MPy9wVfU082qT>
		{
			internal static object W2cvptqWtMHJ7rLKfFQ;

			public tPaBOKHyTPH1a50Q7R()
			{
				jXRWMU6APG();
				zB3PVH9hASM2TtLqpf.unC5KZCzPQ9Xt();
				base._002Ector();
			}

			internal static bool ju2oclqr2a10jpjj5NI()
			{
				return W2cvptqWtMHJ7rLKfFQ == null;
			}

			internal static object oAIxKkqh4oycCYhr4aD()
			{
				return W2cvptqWtMHJ7rLKfFQ;
			}
		}

		[cGSyB0mPjBPwJniINo(typeof(tPaBOKHyTPH1a50Q7R<object>[]))]
		public cGSyB0mPjBPwJniINo(object object_0)
		{
		}
	}

	internal class OhHECUTwMpX5IQbhP8
	{
		[cGSyB0mPjBPwJniINo(typeof(cGSyB0mPjBPwJniINo.tPaBOKHyTPH1a50Q7R<object>[]))]
		internal static string Ow96qs4SyN(object object_0, object object_1)
		{
			byte[] array = (byte[])FMNMQCqX023nWgl1sPT(dOdKwnq7dF4erRM4A2E(), object_0);
			byte[] array2 = array;
			byte[] array3 = new byte[32];
			rWfvnjqMNseOMJuYaYg(array3, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] object_2 = array3;
			byte[] iV = (byte[])osWDTJqtBf12UU4Yywo(FMNMQCqX023nWgl1sPT(dOdKwnq7dF4erRM4A2E(), object_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = (SymmetricAlgorithm)yIQ7DfqDajt6WclUZm2();
			pG3Z2XqGx7UE9bQNHsR(symmetricAlgorithm, object_2);
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)AbDV0Rqq54aXwEuq7DM(symmetricAlgorithm), CryptoStreamMode.Write);
			s6XIvTqEKUrufrU8uIs(cryptoStream, array2, 0, array2.Length);
			cryptoStream.Close();
			return (string)C1U0eaq0cbbia1r7XTh(bqfgRbqYyYrtrrWEZcO(memoryStream));
		}

		internal static object dOdKwnq7dF4erRM4A2E()
		{
			return Encoding.Unicode;
		}

		internal static object FMNMQCqX023nWgl1sPT(object object_0, object object_1)
		{
			return ((Encoding)object_0).GetBytes((string)object_1);
		}

		internal static void rWfvnjqMNseOMJuYaYg(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
		}

		internal static object osWDTJqtBf12UU4Yywo(object object_0)
		{
			return i72W82pYDd(object_0);
		}

		internal static object yIQ7DfqDajt6WclUZm2()
		{
			return cWDWPb1YJ5();
		}

		internal static void pG3Z2XqGx7UE9bQNHsR(object object_0, object object_1)
		{
			((SymmetricAlgorithm)object_0).Key = (byte[])object_1;
		}

		internal static object AbDV0Rqq54aXwEuq7DM(object object_0)
		{
			return ((SymmetricAlgorithm)object_0).CreateEncryptor();
		}

		internal static void s6XIvTqEKUrufrU8uIs(object object_0, object object_1, int int_0, int int_1)
		{
			((Stream)object_0).Write((byte[])object_1, int_0, int_1);
		}

		internal static object bqfgRbqYyYrtrrWEZcO(object object_0)
		{
			return ((MemoryStream)object_0).ToArray();
		}

		internal static object C1U0eaq0cbbia1r7XTh(object object_0)
		{
			return Convert.ToBase64String((byte[])object_0);
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint i6q5Jd8TlK2eUvJJ10(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr Hktk5Kox2Stf69YwrA();

	internal struct ohWaFM2BO8WTgyglV0
	{
		internal bool RSM695VgLs;

		internal byte[] LTn6ZSdJsr;
	}

	internal class rd18TrVMinA0PURbGA
	{
		private object S45rY0o9FZ;

		public rd18TrVMinA0PURbGA(Stream stream_0)
		{
			S45rY0o9FZ = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream fHSkdAnkJf()
		{
			return (Stream)RfismHqoTI6qOaESVs6(S45rY0o9FZ);
		}

		internal byte[] SAd6vG5PDN(int int_0)
		{
			return (byte[])eCRhrRqTWCi3rnj8xLp(S45rY0o9FZ, int_0);
		}

		internal int e5f6OilpOO(byte[] byte_0, int int_0, int int_1)
		{
			return Fn8vVoqaWQmtAP1ABUV(S45rY0o9FZ, byte_0, int_0, int_1);
		}

		internal int EmX6SUPS8Q()
		{
			return JRPhscqvAK9qmQMEJdi(S45rY0o9FZ);
		}

		internal void aim6zD64CW()
		{
			bMEBJcql0NPQkAcEs2X(S45rY0o9FZ);
		}

		internal static object RfismHqoTI6qOaESVs6(object object_0)
		{
			return ((BinaryReader)object_0).BaseStream;
		}

		internal static object eCRhrRqTWCi3rnj8xLp(object object_0, int int_0)
		{
			return ((BinaryReader)object_0).ReadBytes(int_0);
		}

		internal static int Fn8vVoqaWQmtAP1ABUV(object object_0, object object_1, int int_0, int int_1)
		{
			return ((BinaryReader)object_0).Read((byte[])object_1, int_0, int_1);
		}

		internal static int JRPhscqvAK9qmQMEJdi(object object_0)
		{
			return ((BinaryReader)object_0).ReadInt32();
		}

		internal static void bMEBJcql0NPQkAcEs2X(object object_0)
		{
			((BinaryReader)object_0).Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr plN3ALF8dJtGkVW4on(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr hT8AOtKxY2HnWCAw51(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int QyulJxMHiYKchgOpP7(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int hPxrq1kB61b8hWIC85(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr kR13IvxlBlsYKZyER0(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int vy0cdCtX8ildf4imUh(IntPtr ptr);

	[Flags]
	private enum J37OHwqce4o03OjMyG
	{

	}

	private static object icS6X8mfMJ;

	private static bool bgQ6cmxgvy;

	private static bool lmM6Rh9Jd3;

	private static object k5X6QxZLWM;

	private static object NNp6yLHOCK;

	private static IntPtr ao16CHyehk;

	private static int PBh6UKMtON;

	internal static object OLf6G1KLOU;

	private static long UIm6ffHr6M;

	private static bool Njx6HONiFe;

	internal static object Q1X62r0WWy;

	private static object R7P6k0hhqX;

	private static IntPtr l5D6t2UFx6;

	private static object MAV64Kb1Vy;

	private static object EMD6FrMWLU;

	private static object y5l6MWZyrk;

	private static object Bxs6g4aHV5;

	private static object x236nyYma4;

	private static object HsT6xO3EW1;

	internal static object kQ56EaxVda;

	private static IntPtr NKb6p3TFEg;

	private static IntPtr osX68eP07B;

	private static object GcL6LMKGZN;

	private static object B2Y6hxSGbF;

	private static object d0s6Vsy0QY;

	private static object L4L6DyWNC2;

	private static Dictionary<int, int> Bbo67l6DQC;

	private static int QBq6TEWUA2;

	private static object GXM6KdC0rr;

	[cGSyB0mPjBPwJniINo(typeof(cGSyB0mPjBPwJniINo.tPaBOKHyTPH1a50Q7R<object>[]))]
	private static bool vcw6ongIBB;

	private static int vBt6mYCE0k;

	private static bool BX06PLUKPK;

	private static bool Coq6BaVPtq;

	private static bool RyI6wR1iW3;

	private static long jG16eqsVGV;

	private static int Ley65mgaGn;

	private static object Onk60CX2NX;

	static XaXlykERDhtdRwMnBY()
	{
		RyI6wR1iW3 = false;
		icS6X8mfMJ = Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(33554472)).Assembly;
		x236nyYma4 = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		bgQ6cmxgvy = false;
		lmM6Rh9Jd3 = false;
		GcL6LMKGZN = new byte[0];
		Onk60CX2NX = new byte[0];
		Bbo67l6DQC = null;
		k5X6QxZLWM = new object();
		Bxs6g4aHV5 = new byte[0];
		NNp6yLHOCK = new byte[0];
		ao16CHyehk = IntPtr.Zero;
		NKb6p3TFEg = IntPtr.Zero;
		L4L6DyWNC2 = new string[0];
		MAV64Kb1Vy = new int[0];
		PBh6UKMtON = 1;
		Coq6BaVPtq = false;
		B2Y6hxSGbF = new SortedList();
		Ley65mgaGn = 0;
		jG16eqsVGV = 0L;
		kQ56EaxVda = null;
		OLf6G1KLOU = null;
		UIm6ffHr6M = 0L;
		vBt6mYCE0k = 0;
		Njx6HONiFe = false;
		BX06PLUKPK = false;
		QBq6TEWUA2 = 0;
		osX68eP07B = IntPtr.Zero;
		vcw6ongIBB = false;
		Q1X62r0WWy = new Hashtable();
		d0s6Vsy0QY = null;
		EMD6FrMWLU = null;
		GXM6KdC0rr = null;
		y5l6MWZyrk = null;
		R7P6k0hhqX = null;
		HsT6xO3EW1 = null;
		l5D6t2UFx6 = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void Uvx5KZCxycLRJ()
	{
	}

	internal static byte[] EBoW5pZuCT(object object_0)
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
			q2JWexjUd3(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			q2JWexjUd3(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			q2JWexjUd3(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			q2JWexjUd3(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			q2JWexjUd3(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			q2JWexjUd3(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			q2JWexjUd3(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			q2JWexjUd3(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			q2JWexjUd3(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			q2JWexjUd3(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			q2JWexjUd3(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			q2JWexjUd3(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			q2JWexjUd3(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			q2JWexjUd3(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			q2JWexjUd3(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			q2JWexjUd3(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			txjWEkNTE3(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			txjWEkNTE3(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			txjWEkNTE3(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			txjWEkNTE3(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			txjWEkNTE3(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			txjWEkNTE3(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			txjWEkNTE3(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			txjWEkNTE3(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			txjWEkNTE3(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			txjWEkNTE3(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			txjWEkNTE3(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			txjWEkNTE3(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			txjWEkNTE3(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			txjWEkNTE3(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			txjWEkNTE3(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			txjWEkNTE3(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			YpcWGndBPk(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			YpcWGndBPk(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			YpcWGndBPk(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			YpcWGndBPk(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			YpcWGndBPk(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			YpcWGndBPk(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			YpcWGndBPk(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			YpcWGndBPk(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			YpcWGndBPk(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			YpcWGndBPk(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			YpcWGndBPk(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			YpcWGndBPk(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			YpcWGndBPk(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			YpcWGndBPk(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			YpcWGndBPk(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			YpcWGndBPk(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			jJ9WfdjeH0(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			jJ9WfdjeH0(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			jJ9WfdjeH0(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			jJ9WfdjeH0(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			jJ9WfdjeH0(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			jJ9WfdjeH0(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			jJ9WfdjeH0(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			jJ9WfdjeH0(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			jJ9WfdjeH0(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			jJ9WfdjeH0(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			jJ9WfdjeH0(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			jJ9WfdjeH0(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			jJ9WfdjeH0(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			jJ9WfdjeH0(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			jJ9WfdjeH0(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			jJ9WfdjeH0(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void q2JWexjUd3(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + fh0WmZqCxK(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + ((uint[])object_0)[uint_4] + ((uint[])x236nyYma4)[uint_5 - 1], ushort_0);
	}

	private static void txjWEkNTE3(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + fh0WmZqCxK(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + ((uint[])object_0)[uint_4] + ((uint[])x236nyYma4)[uint_5 - 1], ushort_0);
	}

	private static void YpcWGndBPk(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + fh0WmZqCxK(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + ((uint[])object_0)[uint_4] + ((uint[])x236nyYma4)[uint_5 - 1], ushort_0);
	}

	private static void jJ9WfdjeH0(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, object object_0)
	{
		uint_0 = uint_1 + fh0WmZqCxK(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + ((uint[])object_0)[uint_4] + ((uint[])x236nyYma4)[uint_5 - 1], ushort_0);
	}

	private static uint fh0WmZqCxK(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool kZyWHg0Rxv()
	{
		if (!bgQ6cmxgvy)
		{
			pEBWTxxF2p();
			bgQ6cmxgvy = true;
		}
		return lmM6Rh9Jd3;
	}

	internal static SymmetricAlgorithm cWDWPb1YJ5()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (kZyWHg0Rxv())
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

	internal static void pEBWTxxF2p()
	{
		try
		{
			lmM6Rh9Jd3 = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] i72W82pYDd(object object_0)
	{
		if (!kZyWHg0Rxv())
		{
			return new MD5CryptoServiceProvider().ComputeHash((byte[])object_0);
		}
		return EBoW5pZuCT(object_0);
	}

	[cGSyB0mPjBPwJniINo(typeof(cGSyB0mPjBPwJniINo.tPaBOKHyTPH1a50Q7R<object>[]))]
	internal static bool DKUWoxrJBv(int int_0)
	{
		if (((Array)Onk60CX2NX).Length == 0)
		{
			rd18TrVMinA0PURbGA rd18TrVMinA0PURbGA = new rd18TrVMinA0PURbGA(((Assembly)icS6X8mfMJ).GetManifestResourceStream("{11111-22222-20001-00000}"));
			rd18TrVMinA0PURbGA.fHSkdAnkJf().Position = 0L;
			RSACryptoServiceProvider.UseMachineKeyStore = true;
			byte[] array = rd18TrVMinA0PURbGA.SAd6vG5PDN((int)rd18TrVMinA0PURbGA.fHSkdAnkJf().Length);
			byte[] rgbKey = new XaXlykERDhtdRwMnBY().qtN6bpfecB();
			byte[] array2 = new XaXlykERDhtdRwMnBY().Qk66IanJD2();
			byte[] publicKeyToken = ((Assembly)icS6X8mfMJ).GetName().GetPublicKeyToken();
			if (publicKeyToken != null && publicKeyToken.Length > 0)
			{
				array2[1] = publicKeyToken[0];
				array2[3] = publicKeyToken[1];
				array2[5] = publicKeyToken[2];
				array2[7] = publicKeyToken[3];
				array2[9] = publicKeyToken[4];
				array2[11] = publicKeyToken[5];
				array2[13] = publicKeyToken[6];
				array2[15] = publicKeyToken[7];
			}
			SymmetricAlgorithm symmetricAlgorithm = cWDWPb1YJ5();
			symmetricAlgorithm.Mode = CipherMode.CBC;
			ICryptoTransform transform = symmetricAlgorithm.CreateDecryptor(rgbKey, array2);
			Stream stream = CRt6lWJZ3c();
			CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.FlushFinalBlock();
			Onk60CX2NX = UDl6N4xxCW(stream);
			stream.Close();
			cryptoStream.Close();
			rd18TrVMinA0PURbGA.aim6zD64CW();
		}
		if (((Array)GcL6LMKGZN).Length == 0)
		{
			GcL6LMKGZN = C0s6iPbqDd(R2XWZ5witM(icS6X8mfMJ).ToString());
		}
		int num = 0;
		try
		{
			num = BitConverter.ToInt32(new byte[4]
			{
				((byte[])Onk60CX2NX)[int_0],
				((byte[])Onk60CX2NX)[int_0 + 1],
				((byte[])Onk60CX2NX)[int_0 + 2],
				((byte[])Onk60CX2NX)[int_0 + 3]
			}, 0);
		}
		catch
		{
		}
		try
		{
			if (((byte[])GcL6LMKGZN)[num] == 128)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static void FPDW2J1Guv(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (Bbo67l6DQC == null)
			{
				lock (k5X6QxZLWM)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(33554472)).Assembly.GetManifestResourceStream("d137DEAMDtq4F7g5C7.S3SGQlVAHKA1nnQun1"));
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
							num3 += zomWKSSf3P(num3);
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
						rd18TrVMinA0PURbGA rd18TrVMinA0PURbGA = new rd18TrVMinA0PURbGA(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = rd18TrVMinA0PURbGA.EmX6SUPS8Q();
							int value = rd18TrVMinA0PURbGA.EmX6SUPS8Q();
							dictionary.Add(key, value);
						}
						rd18TrVMinA0PURbGA.aim6zD64CW();
					}
					Bbo67l6DQC = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = Bbo67l6DQC[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(33554472)).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(16777238));
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

	private static uint v05WFQBZ7r(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint zomWKSSf3P(uint uint_0)
	{
		return 0u;
	}

	internal static void jXRWMU6APG()
	{
		if (Debugger.IsAttached)
		{
			throw new Exception("Debugger Detected");
		}
	}

	[cGSyB0mPjBPwJniINo(typeof(cGSyB0mPjBPwJniINo.tPaBOKHyTPH1a50Q7R<object>[]))]
	internal static string oXbWkAhpNa(int int_0)
	{
		int num = 355;
		rd18TrVMinA0PURbGA object_ = default(rd18TrVMinA0PURbGA);
		byte[] array = default(byte[]);
		int num5 = default(int);
		byte[] array6 = default(byte[]);
		byte[] array2 = default(byte[]);
		int num8 = default(int);
		byte[] array3 = default(byte[]);
		int num10 = default(int);
		int num17 = default(int);
		uint num26 = default(uint);
		uint num6 = default(uint);
		int num18 = default(int);
		int num7 = default(int);
		byte[] array5 = default(byte[]);
		byte[] array7 = default(byte[]);
		int num16 = default(int);
		int num20 = default(int);
		int num13 = default(int);
		int num28 = default(int);
		int num21 = default(int);
		uint num22 = default(uint);
		uint num11 = default(uint);
		int num27 = default(int);
		byte[] array4 = default(byte[]);
		int num19 = default(int);
		uint num15 = default(uint);
		uint num9 = default(uint);
		uint num23 = default(uint);
		uint num14 = default(uint);
		int num12 = default(int);
		SymmetricAlgorithm object_3 = default(SymmetricAlgorithm);
		ICryptoTransform transform = default(ICryptoTransform);
		Stream stream = default(Stream);
		CryptoStream object_2 = default(CryptoStream);
		int int_ = default(int);
		int num4 = default(int);
		while (true)
		{
			IL_2926:
			if (((Array)Bxs6g4aHV5).Length != 0)
			{
				goto IL_104c;
			}
			goto IL_28fb;
			IL_28fb:
			object_ = new rd18TrVMinA0PURbGA((Stream)hd9m7MYI5HGbJZllcH(icS6X8mfMJ, "Wk2B5ar3wxjTixhAA6.vnuv57eP2kJNSG3LCM"));
			int num2 = 198;
			if (OW9yGbt6ija73HIkSZ() != null)
			{
				goto IL_0092;
			}
			goto IL_2219;
			IL_2219:
			while (true)
			{
				switch (num2)
				{
				case 437:
					array[31] = (byte)num5;
					num2 = 76;
					if (!WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 80;
				case 80:
					array[31] = 153;
					goto case 362;
				case 362:
					array[31] = 166;
					goto case 127;
				case 127:
					array[31] = 242;
					goto case 327;
				case 327:
					array6 = array;
					num = 332;
					goto case 332;
				case 332:
					array2 = new byte[16];
					goto case 383;
				case 383:
					array2[0] = 67;
					num2 = 375;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 436:
					array[28] = (byte)num8;
					goto case 39;
				case 39:
					array[28] = 147;
					num2 = 236;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 435:
					array3[num10 + num17] = (byte)((num26 & num6) >> num18);
					num2 = 335;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 434:
					num5 = 155;
					num2 = 226;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 433:
					array2[15] = (byte)num7;
					goto case 425;
				case 425:
					array2[15] = 49;
					goto case 200;
				case 200:
					array5 = array2;
					num2 = 302;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 14;
				case 14:
					array5[15] = array7[7];
					num2 = 418;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 432:
					array[28] = (byte)num8;
					num2 = 219;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 431:
					array[13] = (byte)num8;
					num2 = 74;
					if (!WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 108;
				case 108:
					num5 = 102;
					num2 = 33;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto case 364;
				case 364:
					array[13] = (byte)num5;
					goto case 113;
				case 113:
					array[13] = 158;
					num2 = 210;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 230:
				case 430:
					if (num17 >= num16)
					{
						num2 = 309;
						if (WDCiOqhWQKxutSt3B6())
						{
							continue;
						}
						goto IL_0092;
					}
					goto case 282;
				case 282:
					if (num17 <= 0)
					{
						goto case 435;
					}
					num2 = 16;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 11;
				case 11:
					array2[1] = 82;
					goto case 89;
				case 89:
					array2[1] = 64;
					num2 = 117;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 429:
					num20 = 0;
					goto case 166;
				case 166:
				case 371:
					if (num20 >= num13)
					{
						goto case 126;
					}
					goto case 403;
				case 126:
					Bxs6g4aHV5 = array3;
					num2 = 315;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 403:
					num28 = num20 % num21;
					goto case 416;
				case 416:
					num10 = num20 * 4;
					goto case 330;
				case 330:
					num22 = (uint)(num28 * 4);
					num2 = 387;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 331;
				case 331:
					array[22] = (byte)num8;
					num2 = 279;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 428:
					num7 = 175;
					goto case 186;
				case 186:
					array2[12] = (byte)num7;
					goto case 158;
				case 158:
					num7 = 195;
					goto case 259;
				case 259:
					array2[12] = (byte)num7;
					num2 = 24;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 427:
					num5 = 106;
					goto case 59;
				case 59:
					array[6] = (byte)num5;
					goto case 2;
				case 2:
					array[6] = 24;
					num2 = 42;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 426:
					array5[1] = array7[0];
					goto case 145;
				case 145:
					array5[3] = array7[1];
					goto case 101;
				case 101:
					array5[5] = array7[2];
					goto case 218;
				case 218:
					array5[7] = array7[3];
					num2 = 378;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 424:
					array2[13] = 129;
					num = 353;
					goto case 353;
				case 353:
					array2[14] = 171;
					num2 = 37;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 423:
					array2[14] = (byte)num7;
					num = 196;
					goto case 196;
				case 196:
					array2[14] = 142;
					goto case 18;
				case 18:
					array2[14] = 41;
					num2 = 389;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 317;
				case 317:
					array[23] = 163;
					num2 = 365;
					if (!WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 434;
				case 422:
					array[20] = (byte)num8;
					num2 = 325;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 421:
					array2[15] = 168;
					num = 322;
					goto case 322;
				case 322:
					num7 = 86;
					goto case 433;
				case 420:
					array[14] = 82;
					num = 137;
					goto case 137;
				case 137:
					num5 = 156;
					goto case 342;
				case 342:
					array[14] = (byte)num5;
					goto case 391;
				case 391:
					array[14] = 147;
					goto case 345;
				case 345:
					num8 = 150;
					num2 = 206;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 419:
					array3[num10 + 1] = (byte)((num11 & 0xFF00) >> 8);
					num2 = 173;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 418:
					num27 = 0;
					goto case 28;
				case 28:
				case 129:
					if (num27 >= array5.Length)
					{
						goto case 15;
					}
					goto case 150;
				case 15:
					if (int_0 == -1)
					{
						num2 = 397;
						if (OW9yGbt6ija73HIkSZ() == null)
						{
							continue;
						}
						goto IL_0092;
					}
					goto case 211;
				case 211:
					num16 = array4.Length % 4;
					num2 = 133;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 150:
					array6[num27] = (byte)(array6[num27] ^ array5[num27]);
					goto case 175;
				case 175:
					num27++;
					num2 = 129;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 417:
					array2[5] = 160;
					num2 = 344;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 226;
				case 226:
					array[23] = (byte)num5;
					num2 = 239;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 415:
					num8 = 221;
					goto case 431;
				case 414:
					num19++;
					num2 = 110;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 21;
				case 21:
					array2[11] = (byte)num7;
					num2 = 27;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 413:
					num8 = 172;
					num2 = 422;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 322;
				case 412:
					array[0] = (byte)num5;
					goto case 277;
				case 277:
					array[0] = 156;
					goto case 244;
				case 244:
					num5 = 223;
					goto case 357;
				case 357:
					array[0] = (byte)num5;
					goto case 388;
				case 388:
					num5 = 104;
					goto case 5;
				case 5:
					array[0] = (byte)num5;
					num2 = 107;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 411:
					array[16] = 211;
					num2 = 103;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 410:
					num8 = 48;
					goto case 275;
				case 275:
					array[4] = (byte)num8;
					goto case 9;
				case 9:
					num8 = 153;
					num2 = 156;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 409:
					array[20] = 128;
					num2 = 413;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 408:
					num8 = 131;
					num2 = 252;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 407:
					array[9] = 163;
					goto case 164;
				case 164:
					array[9] = 109;
					num2 = 90;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 406:
					array[7] = 169;
					goto case 87;
				case 87:
					array[7] = 90;
					goto case 13;
				case 13:
					num8 = 53;
					num2 = 130;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 405:
					array[23] = (byte)num5;
					goto case 317;
				case 404:
					num5 = 142;
					num2 = 231;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 402:
					array[1] = 117;
					goto case 195;
				case 195:
					array[2] = 167;
					goto case 95;
				case 95:
					num5 = 139;
					goto case 276;
				case 276:
					array[2] = (byte)num5;
					num2 = 12;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 401:
					num18 = 0;
					num = 180;
					goto case 180;
				case 180:
					if (num20 == num13 - 1)
					{
						goto case 373;
					}
					goto case 361;
				case 373:
					if (num16 > 0)
					{
						num2 = 43;
						if (OW9yGbt6ija73HIkSZ() == null)
						{
							continue;
						}
						goto IL_0092;
					}
					goto case 361;
				case 361:
					num14 += num15;
					goto case 41;
				case 41:
					num22 = (uint)num10;
					goto case 292;
				case 292:
					num9 = (uint)((array4[num22 + 3] << 24) | (array4[num22 + 2] << 16) | (array4[num22 + 1] << 8) | array4[num22]);
					goto case 86;
				case 86:
				case 262:
					num23 = num14;
					num = 235;
					goto case 235;
				case 235:
					num14 = 0u;
					goto case 341;
				case 341:
				{
					uint num24 = num23;
					uint num25 = num23;
					num25 ^= num25 << 9;
					num25 += 1027490225;
					num25 ^= num25 >> 5;
					num25 += 3194358051u;
					num25 ^= num25 << 25;
					num25 += 1461015013;
					num25 = 402030592 + num25;
					num23 = num24 + (uint)(double)num25;
					goto case 29;
				}
				case 29:
					num14 = num23;
					num = 153;
					goto case 153;
				case 153:
					if (num20 == num13 - 1)
					{
						goto case 234;
					}
					goto case 251;
				case 234:
					if (num16 > 0)
					{
						goto case 46;
					}
					goto case 251;
				case 46:
					num26 = num14 ^ num9;
					num2 = 209;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 251:
					num11 = num14 ^ num9;
					goto case 134;
				case 134:
					array3[num10] = (byte)(num11 & 0xFFu);
					goto case 419;
				case 400:
					array2[9] = (byte)num12;
					num2 = 0;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto default;
				default:
					array2[9] = 56;
					goto case 143;
				case 143:
					num7 = 140;
					goto case 85;
				case 85:
					array2[10] = (byte)num7;
					goto case 339;
				case 339:
					array2[10] = 126;
					goto case 356;
				case 356:
					array2[10] = 134;
					num2 = 10;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 399:
					array2[13] = (byte)num7;
					num2 = 130;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto case 424;
				case 398:
					array[9] = (byte)num8;
					goto case 106;
				case 106:
					num5 = 160;
					goto case 367;
				case 367:
					array[9] = (byte)num5;
					goto case 165;
				case 165:
					num8 = 134;
					goto case 380;
				case 380:
					array[10] = (byte)num8;
					goto case 299;
				case 299:
					array[10] = 109;
					num2 = 164;
					if (!WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 253;
				case 253:
					num5 = 134;
					num = 227;
					goto case 227;
				case 227:
					array[10] = (byte)num5;
					num2 = 216;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 32;
				case 32:
					array2[8] = 141;
					goto case 161;
				case 161:
					array2[8] = 97;
					goto case 56;
				case 56:
					num12 = 87;
					num2 = 205;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 397:
					object_3 = (SymmetricAlgorithm)nNZXhqqimIKDGfNIh7();
					num2 = 175;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto case 203;
				case 203:
					PLjvNmJehHusNaOqWh(object_3, CipherMode.CBC);
					goto case 334;
				case 334:
					transform = (ICryptoTransform)Y2y9eXGAsIZ6ILfjJ9(object_3, array6, array5);
					num2 = 30;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 9;
				case 396:
					array[17] = 128;
					num2 = 176;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 100;
				case 100:
					num8 = 158;
					goto case 220;
				case 220:
					array[12] = (byte)num8;
					num = 291;
					goto case 291;
				case 291:
					num8 = 29;
					num2 = 337;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 395:
					array[14] = 123;
					goto case 404;
				case 394:
					num5 = 104;
					goto case 324;
				case 324:
					array[17] = (byte)num5;
					goto case 245;
				case 245:
					array[17] = 126;
					num2 = 120;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 393:
					num5 = 133;
					num2 = 44;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 392:
					num15 = 0u;
					num2 = 155;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 390:
					array[26] = 229;
					goto case 328;
				case 328:
					num5 = 111;
					goto case 374;
				case 374:
					array[27] = (byte)num5;
					goto case 393;
				case 389:
					num12 = 98;
					goto case 272;
				case 272:
					array2[14] = (byte)num12;
					goto case 267;
				case 267:
					num7 = 136;
					goto case 246;
				case 246:
					array2[15] = (byte)num7;
					goto case 136;
				case 136:
					array2[15] = 158;
					num = 421;
					goto case 421;
				case 387:
					num15 = (uint)((array6[num22 + 3] << 24) | (array6[num22 + 2] << 16) | (array6[num22 + 1] << 8) | array6[num22]);
					goto case 306;
				case 306:
					num6 = 255u;
					num2 = 401;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 75;
				case 75:
					array2[0] = (byte)num7;
					goto case 105;
				case 105:
					num12 = 158;
					num = 225;
					goto case 225;
				case 225:
					array2[0] = (byte)num12;
					num = 208;
					goto case 208;
				case 208:
					array2[0] = 147;
					goto case 11;
				case 386:
					array[7] = 192;
					goto case 382;
				case 382:
					num5 = 53;
					goto case 189;
				case 189:
					array[7] = (byte)num5;
					num2 = 45;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 385:
					sn8mMEA5ODTXWhUIvA(stream);
					goto case 338;
				case 338:
					sn8mMEA5ODTXWhUIvA(object_2);
					num = 51;
					goto case 51;
				case 51:
					array4 = (byte[])Bxs6g4aHV5;
					num2 = 167;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto case 211;
				case 384:
					array[17] = (byte)num8;
					num = 318;
					goto case 318;
				case 318:
					array[18] = 109;
					goto case 98;
				case 98:
					num8 = 173;
					num2 = 73;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 381:
					array[1] = 73;
					goto case 174;
				case 174:
					array[1] = 96;
					num2 = 79;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 379:
					num12 = 98;
					goto case 400;
				case 378:
					array5[9] = array7[4];
					goto case 289;
				case 289:
					array5[11] = array7[5];
					goto case 340;
				case 340:
					array5[13] = array7[6];
					num2 = 14;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 377:
					array2[1] = 103;
					num2 = 0;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto case 202;
				case 202:
					array2[1] = 62;
					goto case 74;
				case 74:
					array2[1] = 213;
					goto case 204;
				case 204:
					num7 = 150;
					goto case 285;
				case 285:
					array2[2] = (byte)num7;
					goto case 365;
				case 365:
					num12 = 149;
					num = 49;
					goto case 49;
				case 49:
					array2[2] = (byte)num12;
					goto case 199;
				case 199:
					array2[2] = 82;
					goto case 296;
				case 296:
					num12 = 106;
					goto case 77;
				case 77:
					array2[2] = (byte)num12;
					goto case 224;
				case 224:
					array2[2] = 218;
					num = 266;
					goto case 266;
				case 266:
					num7 = 177;
					goto case 76;
				case 76:
					array2[3] = (byte)num7;
					num2 = 93;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto case 159;
				case 159:
					num12 = 118;
					goto case 287;
				case 287:
					array2[3] = (byte)num12;
					goto case 321;
				case 321:
					num7 = 96;
					goto case 295;
				case 295:
					array2[3] = (byte)num7;
					goto case 310;
				case 310:
					array2[3] = 124;
					goto case 53;
				case 53:
					array2[4] = 100;
					num2 = 69;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 41;
				case 376:
					num9 <<= 8;
					num = 348;
					goto case 348;
				case 348:
					num9 |= array4[^(1 + num19)];
					num2 = 414;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 363;
				case 363:
					array2[5] = (byte)num7;
					num2 = 238;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 375:
					num12 = 156;
					num = 146;
					goto case 146;
				case 146:
					array2[0] = (byte)num12;
					num2 = 92;
					if (!WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 303;
				case 303:
					array2[0] = 156;
					goto case 171;
				case 171:
					num7 = 166;
					goto case 75;
				case 372:
					num8 = 149;
					goto case 331;
				case 370:
					array4 = (byte[])G2pCqyd1BXlWW63CH9(object_, (int)ji33EfZTx7TU2Qa4E6(sYUkE8rXU8754HDYjM(object_)));
					num2 = 284;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 369:
					array[21] = 97;
					num2 = 283;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 368:
					num8 = 169;
					num2 = 35;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 366:
					array[11] = (byte)num5;
					num2 = 36;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto case 78;
				case 78:
					array[11] = 194;
					goto case 263;
				case 263:
					array[11] = 82;
					num2 = 214;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 360:
					num8 = 156;
					goto case 122;
				case 122:
					array[8] = (byte)num8;
					num2 = 194;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 359:
					gTbTr03JciIGE5lpxp(object_2);
					goto case 55;
				case 55:
					Bxs6g4aHV5 = SIC0Ro0S6lUMkIeYbV(stream);
					goto case 385;
				case 358:
					array[22] = (byte)num5;
					num2 = 351;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 315:
				case 354:
					break;
				case 352:
					array2[6] = 173;
					num2 = 300;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 249;
				case 249:
					num5 = 95;
					goto case 167;
				case 167:
					array[23] = (byte)num5;
					num2 = 61;
					if (!WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 170;
				case 170:
					num5 = 130;
					goto case 405;
				case 351:
					array[22] = 148;
					goto case 372;
				case 350:
					zId4XpFGOAN9Rx9xXV(object_2, array4, 0, array4.Length);
					num = 359;
					goto case 359;
				case 349:
					array[19] = (byte)num5;
					goto case 260;
				case 260:
					num8 = 223;
					num = 346;
					goto case 346;
				case 346:
					array[19] = (byte)num8;
					goto case 313;
				case 313:
					num8 = 84;
					goto case 40;
				case 40:
					array[20] = (byte)num8;
					goto case 154;
				case 154:
					num8 = 156;
					num2 = 26;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto case 36;
				case 36:
					array[20] = (byte)num8;
					goto case 409;
				case 347:
					array[27] = (byte)num5;
					num = 286;
					goto case 286;
				case 286:
					num5 = 85;
					num2 = 163;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 344:
					array2[5] = 181;
					goto case 93;
				case 93:
					num7 = 91;
					goto case 68;
				case 68:
					array2[6] = (byte)num7;
					num2 = 140;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 10;
				case 10:
					array2[10] = 65;
					goto case 157;
				case 157:
					num7 = 60;
					goto case 21;
				case 343:
					num8 = 216;
					goto case 118;
				case 118:
					array[12] = (byte)num8;
					goto case 100;
				case 337:
					array[12] = (byte)num8;
					goto case 415;
				case 336:
					array2[7] = (byte)num12;
					goto case 201;
				case 201:
					array2[7] = 254;
					goto case 32;
				case 335:
					num17++;
					goto case 230;
				case 333:
					num8 = 134;
					goto case 58;
				case 58:
					array[1] = (byte)num8;
					goto case 381;
				case 329:
					num5 = 64;
					goto case 294;
				case 294:
					array[25] = (byte)num5;
					goto case 242;
				case 242:
					array[26] = 144;
					goto case 368;
				case 326:
					array7 = (byte[])ukIBLeSD2HIXKQQwrZ(GXh1dJ2hvb4rbDO0Kp(icS6X8mfMJ));
					goto case 228;
				case 228:
					if (array7 == null)
					{
						goto case 418;
					}
					num = 179;
					goto case 179;
				case 179:
					if (array7.Length > 0)
					{
						goto case 426;
					}
					goto case 418;
				case 325:
					num5 = 129;
					num = 119;
					goto case 119;
				case 119:
					array[20] = (byte)num5;
					num2 = 408;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 323:
					array[15] = (byte)num5;
					num2 = 72;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 320:
					array[21] = 165;
					num2 = 369;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 366;
				case 319:
					array2[11] = 153;
					num2 = 215;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 206;
				case 206:
					array[14] = (byte)num8;
					num2 = 395;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 316:
					num13++;
					goto case 6;
				case 6:
					num22 = 0u;
					goto case 429;
				case 314:
					array[18] = 120;
					goto case 221;
				case 221:
					array[18] = 175;
					goto case 187;
				case 187:
					array[18] = 200;
					num2 = 54;
					if (!WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 84;
				case 84:
					num8 = 139;
					num2 = 48;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 312:
					num21 = array6.Length / 4;
					goto case 160;
				case 160:
					num14 = 0u;
					num2 = 392;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 76;
				case 311:
					array[5] = (byte)num5;
					num2 = 427;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 92:
				case 309:
					num20++;
					num2 = 166;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 56;
				case 308:
					array[8] = (byte)num8;
					goto case 109;
				case 109:
					array[9] = 168;
					goto case 407;
				case 307:
					num7 = 128;
					goto case 363;
				case 305:
					num5 = 149;
					goto case 229;
				case 229:
					array[6] = (byte)num5;
					goto case 232;
				case 232:
					array[6] = 158;
					goto case 406;
				case 304:
					num5 = 45;
					goto case 177;
				case 177:
					array[30] = (byte)num5;
					num = 57;
					goto case 57;
				case 57:
					array[30] = 132;
					goto case 254;
				case 254:
					array[30] = 192;
					num2 = 34;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 302:
					BGocSJvfV8j76ND82q(array5);
					goto case 326;
				case 301:
					array[0] = 71;
					goto case 333;
				case 300:
					num12 = 222;
					goto case 274;
				case 274:
					array2[6] = (byte)num12;
					num2 = 193;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 298:
					object_2 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 350;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 235;
				case 297:
					num7 = 167;
					num = 423;
					goto case 423;
				case 293:
					num8 = 80;
					goto case 148;
				case 148:
					array[4] = (byte)num8;
					goto case 184;
				case 184:
					array[4] = 96;
					goto case 410;
				case 290:
					array[8] = (byte)num5;
					goto case 360;
				case 288:
					if (num19 > 0)
					{
						num2 = 376;
						if (OW9yGbt6ija73HIkSZ() == null)
						{
							continue;
						}
						goto IL_0092;
					}
					goto case 348;
				case 284:
					Ssi2iSOofn9L1E4n5e(object_);
					goto case 116;
				case 116:
					array = new byte[32];
					goto case 265;
				case 265:
					num5 = 67;
					goto case 412;
				case 283:
					array[21] = 108;
					num2 = 64;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 281:
					array[15] = 148;
					goto case 115;
				case 115:
					num5 = 113;
					goto case 323;
				case 280:
					array[21] = (byte)num5;
					goto case 273;
				case 273:
					num5 = 137;
					goto case 358;
				case 279:
					array[22] = 165;
					num2 = 17;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto default;
				case 278:
					array[6] = 90;
					num2 = 48;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto case 305;
				case 271:
					array[17] = (byte)num5;
					goto case 396;
				case 270:
					array[22] = (byte)num5;
					goto case 25;
				case 25:
					array[22] = 134;
					goto case 249;
				case 269:
					array[5] = 61;
					num2 = 162;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 268:
					array2[11] = 132;
					goto case 319;
				case 264:
					array[27] = 96;
					goto case 71;
				case 71:
					num5 = 27;
					num2 = 19;
					if (!WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 347;
				case 258:
					array[24] = (byte)num5;
					goto case 112;
				case 112:
					array[24] = 177;
					num = 124;
					goto case 124;
				case 124:
					num8 = 112;
					goto case 125;
				case 125:
					array[24] = (byte)num8;
					num2 = 213;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 257:
					array[28] = (byte)num5;
					num2 = 26;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 23;
				case 23:
					array[3] = (byte)num8;
					goto case 144;
				case 144:
					array[3] = 155;
					goto case 33;
				case 33:
					array[3] = 180;
					goto case 293;
				case 256:
					array[23] = (byte)num5;
					num2 = 52;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 255:
					array[16] = (byte)num5;
					num2 = 411;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 252:
					array[20] = (byte)num8;
					goto case 320;
				case 250:
					num7 = 132;
					num2 = 147;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 248:
					array[1] = (byte)num8;
					goto case 402;
				case 247:
					num8 = 91;
					num = 23;
					goto case 23;
				case 243:
					array2[8] = (byte)num7;
					goto case 63;
				case 63:
					array2[9] = 115;
					goto case 379;
				case 241:
					num5 = 142;
					num2 = 88;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 240:
					num19 = 0;
					goto case 110;
				case 110:
				case 142:
					if (num19 >= num16)
					{
						num2 = 211;
						if (!WDCiOqhWQKxutSt3B6())
						{
							continue;
						}
						goto case 86;
					}
					goto case 288;
				case 239:
					array[23] = 156;
					goto case 121;
				case 121:
					num5 = 10;
					num2 = 256;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 89;
				case 238:
					num12 = 157;
					goto case 128;
				case 128:
					array2[5] = (byte)num12;
					goto case 417;
				case 237:
					num5 = 208;
					goto case 290;
				case 236:
					num5 = 61;
					goto case 257;
				case 231:
					array[15] = (byte)num5;
					num2 = 152;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 96;
				case 96:
					num18 += 8;
					goto case 435;
				case 223:
					array[25] = (byte)num5;
					num2 = 94;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 222:
					array[26] = 152;
					goto case 390;
				case 219:
					num8 = 140;
					goto case 436;
				case 217:
					array[16] = 91;
					num2 = 66;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 216:
					array[10] = 161;
					goto case 131;
				case 131:
					array[10] = 71;
					num2 = 56;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto case 61;
				case 61:
					array[11] = 137;
					goto case 8;
				case 8:
					num5 = 130;
					goto case 366;
				case 215:
					array2[11] = 202;
					goto case 81;
				case 81:
					num12 = 134;
					num = 67;
					goto case 67;
				case 67:
					array2[12] = (byte)num12;
					goto case 250;
				case 214:
					array[11] = 161;
					num2 = 182;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 213:
					num8 = 119;
					goto case 183;
				case 183:
					array[25] = (byte)num8;
					goto case 178;
				case 178:
					num5 = 86;
					goto case 223;
				case 212:
					array[25] = (byte)num8;
					num2 = 329;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 210:
					array[13] = 95;
					num2 = 420;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 209:
					num17 = 0;
					goto case 230;
				case 207:
					array[16] = (byte)num8;
					num2 = 217;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 205:
					array2[8] = (byte)num12;
					goto case 135;
				case 135:
					num7 = 79;
					num2 = 87;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto case 243;
				case 198:
					fRhAbTDTfL9E2coDZf(sYUkE8rXU8754HDYjM(object_), 0L);
					num2 = 370;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 197:
					num12 = 98;
					num2 = 336;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 194:
					num8 = 68;
					goto case 308;
				case 193:
					num7 = 111;
					goto case 168;
				case 168:
					array2[7] = (byte)num7;
					goto case 197;
				case 192:
					array2[4] = 172;
					goto case 22;
				case 22:
					num12 = 142;
					goto case 70;
				case 70:
					array2[5] = (byte)num12;
					goto case 114;
				case 114:
					array2[5] = 111;
					num2 = 307;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 191:
					num5 = 150;
					num2 = 30;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto case 271;
				case 190:
					array2[4] = (byte)num12;
					num2 = 65;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 7;
				case 7:
					array[15] = 115;
					goto case 281;
				case 188:
					array[0] = (byte)num5;
					num2 = 301;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 185:
					if (num16 <= 0)
					{
						goto case 6;
					}
					num2 = 316;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 4;
				case 4:
					array[5] = 14;
					num2 = 241;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 158;
				case 182:
					num5 = 248;
					goto case 31;
				case 31:
					array[11] = (byte)num5;
					num2 = 343;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 181:
					num14 += num15;
					num2 = 123;
					if (!WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 240;
				case 176:
					num8 = 82;
					goto case 384;
				case 173:
					array3[num10 + 2] = (byte)((num11 & 0xFF0000) >> 16);
					num2 = 54;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 23;
				case 172:
					array[29] = 73;
					goto case 139;
				case 139:
					array[30] = 110;
					num2 = 304;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 169:
					array[17] = (byte)num5;
					num2 = 37;
					if (OW9yGbt6ija73HIkSZ() != null)
					{
						continue;
					}
					goto case 191;
				case 163:
					array[28] = (byte)num5;
					goto case 102;
				case 102:
					array[28] = 138;
					goto case 47;
				case 47:
					num8 = 92;
					num2 = 432;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 162:
					num5 = 77;
					num2 = 311;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 156:
					array[4] = (byte)num8;
					goto case 132;
				case 132:
					array[5] = 168;
					num2 = 141;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 155:
					num9 = 0u;
					goto case 185;
				case 152:
					array[15] = 172;
					goto case 7;
				case 151:
					array2[14] = (byte)num7;
					goto case 297;
				case 149:
					array2[12] = 166;
					num2 = 428;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 147:
					array2[12] = (byte)num7;
					goto case 62;
				case 62:
					array2[12] = 162;
					goto case 149;
				case 141:
					num5 = 151;
					num2 = 1;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 140:
					array2[6] = 149;
					num = 352;
					goto case 352;
				case 133:
					num13 = array4.Length / 4;
					goto case 20;
				case 20:
					array3 = new byte[array4.Length];
					goto case 312;
				case 130:
					array[7] = (byte)num8;
					num2 = 386;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 123:
					num5 = 103;
					goto case 349;
				case 120:
					num5 = 151;
					goto case 169;
				case 117:
					array2[1] = 117;
					goto case 377;
				case 111:
					array[19] = 160;
					goto case 123;
				case 107:
					num5 = 86;
					goto case 188;
				case 104:
					num7 = 82;
					num = 399;
					goto case 399;
				case 103:
					num8 = 87;
					goto case 207;
				case 99:
					num5 = 108;
					goto case 255;
				case 97:
					array[2] = 197;
					goto case 247;
				case 94:
					array[25] = 208;
					num2 = 83;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 91:
					array[8] = (byte)num8;
					num2 = 184;
					if (!WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 237;
				case 90:
					num8 = 136;
					num2 = 398;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 88:
					array[5] = (byte)num5;
					goto case 269;
				case 83:
					num8 = 66;
					num2 = 212;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 82:
					num5 = 117;
					goto case 60;
				case 60:
					array[18] = (byte)num5;
					goto case 314;
				case 79:
					num8 = 124;
					num2 = 248;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 37;
				case 37:
					num7 = 89;
					goto case 151;
				case 73:
					array[18] = (byte)num8;
					goto case 82;
				case 72:
					array[15] = 11;
					goto case 99;
				case 69:
					num12 = 106;
					goto case 190;
				case 66:
					array[16] = 61;
					num2 = 394;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto case 8;
				case 65:
					array2[4] = 185;
					goto case 192;
				case 64:
					num5 = 158;
					goto case 280;
				case 54:
					array3[num10 + 3] = (byte)((num11 & 0xFF000000u) >> 24);
					num2 = 92;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 52:
					num5 = 162;
					num2 = 258;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 50:
					array[2] = (byte)num5;
					num2 = 97;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 48:
					array[19] = (byte)num8;
					num2 = 0;
					if (!WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto case 111;
				case 45:
					num8 = 98;
					num2 = 91;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 44:
					array[27] = (byte)num5;
					num = 264;
					goto case 264;
				case 43:
					num9 = 0u;
					num2 = 181;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 42:
					array[6] = 103;
					goto case 278;
				case 38:
					array[29] = (byte)num5;
					num2 = 172;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 35:
					array[26] = (byte)num8;
					num2 = 222;
					if (WDCiOqhWQKxutSt3B6())
					{
						continue;
					}
					goto IL_0092;
				case 34:
					num5 = 135;
					num = 437;
					goto case 437;
				case 30:
					stream = (Stream)BRD1TSKgMBP8edpAY2();
					num2 = 298;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 27:
					num7 = 90;
					goto case 19;
				case 19:
					array2[11] = (byte)num7;
					goto case 268;
				case 26:
					array[29] = 150;
					goto case 3;
				case 3:
					num5 = 100;
					num2 = 38;
					if (OW9yGbt6ija73HIkSZ() == null)
					{
						continue;
					}
					goto IL_0092;
				case 24:
					array2[13] = 194;
					goto case 104;
				case 17:
					num5 = 134;
					goto case 270;
				case 16:
					num6 <<= 8;
					goto case 96;
				case 12:
					num5 = 132;
					goto case 50;
				case 1:
					array[5] = (byte)num5;
					goto case 4;
				case 261:
					goto IL_28fb;
				case 355:
					goto IL_2926;
				case 138:
					try
					{
						string text = (string)x97AYR7XgbV8WWDBbN(LrXTSgHbnrIlcpVrT4(), Bxs6g4aHV5, int_0 + 4, int_);
						int num3 = 0;
						if (OW9yGbt6ija73HIkSZ() != null)
						{
							num3 = num4;
						}
						return num3 switch
						{
							_ => text, 
						};
					}
					catch
					{
						if (OW9yGbt6ija73HIkSZ() == null)
						{
							switch (0)
							{
							}
						}
					}
					goto case 233;
				case 233:
					return "";
				}
				break;
			}
			goto IL_104c;
			IL_104c:
			int_ = m8a9tAPg1r75uAHuYe(Bxs6g4aHV5, int_0);
			num2 = 138;
			if (OW9yGbt6ija73HIkSZ() != null)
			{
				goto IL_0092;
			}
			goto IL_2219;
			IL_0092:
			num2 = num;
			goto IL_2219;
		}
	}

	[cGSyB0mPjBPwJniINo(typeof(cGSyB0mPjBPwJniINo.tPaBOKHyTPH1a50Q7R<object>[]))]
	internal static string PsNWxeg4Op(object object_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String((string)object_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int ohGWtdOa3J()
	{
		return 5;
	}

	private static void dxSWqouoG2()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate tYmW98xhB2(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(16777378)).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(16777276)),
			Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(16777283))
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object R2XWZ5witM(object object_0)
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
			if (File.Exists(((Assembly)object_0).GetName().CodeBase!.ToString().Replace("file:///", "")))
			{
				return ((Assembly)object_0).GetName().CodeBase!.ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(object_0.GetType().GetProperty("Location")!.GetValue(object_0, new object[0])!.ToString()))
			{
				return object_0.GetType().GetProperty("Location")!.GetValue(object_0, new object[0])!.ToString();
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

	private static IntPtr qWtWSMgeoN(IntPtr intptr_0, object object_0, uint uint_0)
	{
		if (d0s6Vsy0QY == null)
		{
			IntPtr procAddress = GetProcAddress(so8WHSBJcy(), "Find ".Trim() + "ResourceA");
			d0s6Vsy0QY = (plN3ALF8dJtGkVW4on)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(33554481)));
		}
		return d0s6Vsy0QY(intptr_0, (string)object_0, uint_0);
	}

	private static IntPtr riUWz9GWRU(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (EMD6FrMWLU == null)
		{
			IntPtr procAddress = GetProcAddress(so8WHSBJcy(), "Virtual ".Trim() + "Alloc");
			EMD6FrMWLU = (hT8AOtKxY2HnWCAw51)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(33554482)));
		}
		return EMD6FrMWLU(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int mYR6YRYNpj(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (GXM6KdC0rr == null)
		{
			IntPtr procAddress = GetProcAddress(so8WHSBJcy(), "Write ".Trim() + "Process ".Trim() + "Memory");
			GXM6KdC0rr = (QyulJxMHiYKchgOpP7)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(33554483)));
		}
		return GXM6KdC0rr(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int Hwf639qwmN(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (y5l6MWZyrk == null)
		{
			IntPtr procAddress = GetProcAddress(so8WHSBJcy(), "Virtual ".Trim() + "Protect");
			y5l6MWZyrk = (hPxrq1kB61b8hWIC85)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(33554484)));
		}
		return y5l6MWZyrk(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr ubp6JZfKgJ(uint uint_0, int int_0, uint uint_1)
	{
		if (R7P6k0hhqX == null)
		{
			IntPtr procAddress = GetProcAddress(so8WHSBJcy(), "Open ".Trim() + "Process");
			R7P6k0hhqX = (kR13IvxlBlsYKZyER0)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(33554485)));
		}
		return R7P6k0hhqX(uint_0, int_0, uint_1);
	}

	private static int nTt6daPs1O(IntPtr intptr_0)
	{
		if (HsT6xO3EW1 == null)
		{
			IntPtr procAddress = GetProcAddress(so8WHSBJcy(), "Close ".Trim() + "Handle");
			HsT6xO3EW1 = (vy0cdCtX8ildf4imUh)Marshal.GetDelegateForFunctionPointer(procAddress, Type.GetTypeFromHandle(aVemsvvaraXSsOXEKR.lBC5KZxj6LMe3(33554486)));
		}
		return HsT6xO3EW1(intptr_0);
	}

	[SpecialName]
	private static IntPtr so8WHSBJcy()
	{
		if (l5D6t2UFx6 == IntPtr.Zero)
		{
			l5D6t2UFx6 = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return l5D6t2UFx6;
	}

	[cGSyB0mPjBPwJniINo(typeof(cGSyB0mPjBPwJniINo.tPaBOKHyTPH1a50Q7R<object>[]))]
	private static byte[] C0s6iPbqDd(object object_0)
	{
		using FileStream fileStream = new FileStream((string)object_0, FileMode.Open, FileAccess.Read, FileShare.Read);
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

	private static Stream CRt6lWJZ3c()
	{
		return new MemoryStream();
	}

	private static byte[] UDl6N4xxCW(object object_0)
	{
		return ((MemoryStream)object_0).ToArray();
	}

	[cGSyB0mPjBPwJniINo(typeof(cGSyB0mPjBPwJniINo.tPaBOKHyTPH1a50Q7R<object>[]))]
	private static byte[] W3k6W0qnlR(object object_0)
	{
		Stream stream = CRt6lWJZ3c();
		SymmetricAlgorithm symmetricAlgorithm = cWDWPb1YJ5();
		symmetricAlgorithm.Key = new byte[32]
		{
			236, 111, 130, 143, 225, 72, 233, 212, 195, 127,
			66, 58, 16, 42, 90, 175, 73, 17, 7, 43,
			221, 151, 18, 131, 157, 191, 75, 56, 120, 9,
			119, 194
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			208, 203, 157, 20, 56, 119, 182, 211, 143, 84,
			161, 43, 186, 87, 25, 136
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write((byte[])object_0, 0, ((Array)object_0).Length);
		cryptoStream.Close();
		return UDl6N4xxCW(stream);
	}

	private byte[] Mnf66G9C1I()
	{
		return null;
	}

	private byte[] tsF6rAACms()
	{
		return null;
	}

	private byte[] Qk66IanJD2()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] qtN6bpfecB()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] gWD6uf0b8P()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] l2v6sUxhbf()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] l9U6a4dKZj()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] icn6AmxkxW()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] qdo6jYqwqs()
	{
		return null;
	}

	internal byte[] O2l61QdK0U()
	{
		return null;
	}

	internal static object hd9m7MYI5HGbJZllcH(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object sYUkE8rXU8754HDYjM(object object_0)
	{
		return ((rd18TrVMinA0PURbGA)object_0).fHSkdAnkJf();
	}

	internal static void fRhAbTDTfL9E2coDZf(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long ji33EfZTx7TU2Qa4E6(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object G2pCqyd1BXlWW63CH9(object object_0, int int_0)
	{
		return ((rd18TrVMinA0PURbGA)object_0).SAd6vG5PDN(int_0);
	}

	internal static void Ssi2iSOofn9L1E4n5e(object object_0)
	{
		((rd18TrVMinA0PURbGA)object_0).aim6zD64CW();
	}

	internal static void BGocSJvfV8j76ND82q(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object GXh1dJ2hvb4rbDO0Kp(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object ukIBLeSD2HIXKQQwrZ(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object nNZXhqqimIKDGfNIh7()
	{
		return cWDWPb1YJ5();
	}

	internal static void PLjvNmJehHusNaOqWh(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object Y2y9eXGAsIZ6ILfjJ9(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object BRD1TSKgMBP8edpAY2()
	{
		return CRt6lWJZ3c();
	}

	internal static void zId4XpFGOAN9Rx9xXV(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void gTbTr03JciIGE5lpxp(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object SIC0Ro0S6lUMkIeYbV(object object_0)
	{
		return UDl6N4xxCW(object_0);
	}

	internal static void sn8mMEA5ODTXWhUIvA(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int m8a9tAPg1r75uAHuYe(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static object LrXTSgHbnrIlcpVrT4()
	{
		return Encoding.Unicode;
	}

	internal static object x97AYR7XgbV8WWDBbN(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool WDCiOqhWQKxutSt3B6()
	{
		return (object)null == null;
	}

	internal static object OW9yGbt6ija73HIkSZ()
	{
		return null;
	}
}
