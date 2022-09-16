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

namespace F0;

internal class sE
{
	private delegate void S4(object o);

	internal class ny : Attribute
	{
		internal class Mm<RN>
		{
			internal static object Jco;

			public Mm()
			{
				Rg.XRF6rz();
				base._002Ector();
			}

			internal static bool Pcq()
			{
				return Jco == null;
			}

			internal static object Vcg()
			{
				return Jco;
			}
		}

		[ny(typeof(Mm<object>[]))]
		public ny(object object_0)
		{
		}
	}

	internal class EY
	{
		[ny(typeof(ny.Mm<object>[]))]
		internal static string DE1(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] array2 = new byte[32];
			McU(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] key = array2;
			byte[] iV = Cnl(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = qnA();
			symmetricAlgorithm.Key = key;
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, (ICryptoTransform)DcE(symmetricAlgorithm), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String((byte[])Xc2(memoryStream));
		}

		internal static void McU(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
		}

		internal static object DcE(object object_0)
		{
			return ((SymmetricAlgorithm)object_0).CreateEncryptor();
		}

		internal static object Xc2(object object_0)
		{
			return ((MemoryStream)object_0).ToArray();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint KR(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr oZ();

	internal struct Rq
	{
		internal bool MEO;

		internal byte[] JEh;
	}

	internal class UM
	{
		private BinaryReader BEz;

		public UM(Stream stream_0)
		{
			BEz = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return BEz.BaseStream;
		}

		internal byte[] cEe(int int_0)
		{
			return BEz.ReadBytes(int_0);
		}

		internal int sEC(byte[] byte_0, int int_0, int int_1)
		{
			return BEz.Read(byte_0, int_0, int_1);
		}

		internal int lEU()
		{
			return BEz.ReadInt32();
		}

		internal void pE6()
		{
			BEz.Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr VX(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr gs(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int DS(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int If(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr A9(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int ck(IntPtr ptr);

	[Flags]
	private enum Cr
	{

	}

	internal static Assembly QEq;

	private static byte[] XE4;

	private static IntPtr WEo;

	private static object QEm;

	private static int[] eEH;

	private static int GEa;

	private static bool WED;

	private static int rEk;

	private static long MEF;

	internal static KR lEJ;

	private static int lEv;

	internal static Hashtable JEL;

	private static gs eEX;

	private static IntPtr yEt;

	private static Dictionary<int, int> qEx;

	private static VX PEr;

	private static bool nEf;

	private static byte[] nEy;

	private static SortedList XEi;

	private static IntPtr VEj;

	internal static RSACryptoServiceProvider iEP;

	internal static KR DET;

	private static A9 rEu;

	private static If dEV;

	private static DS tE3;

	private static IntPtr EEG;

	private static ck JE8;

	private static int hEA;

	private static bool CEK;

	private static bool fEl;

	[ny(typeof(ny.Mm<object>[]))]
	private static bool pEM;

	private static bool dER;

	private static bool VEW;

	private static object jE5;

	private static uint[] KES;

	private static byte[] IEd;

	private static long jEs;

	static sE()
	{
		dER = false;
		QEq = typeof(sE).Assembly;
		KES = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};
		nEf = false;
		VEW = false;
		IEd = new byte[0];
		iEP = null;
		qEx = null;
		jE5 = new object();
		XE4 = new byte[0];
		nEy = new byte[0];
		EEG = IntPtr.Zero;
		WEo = IntPtr.Zero;
		QEm = new string[0];
		eEH = new int[0];
		GEa = 1;
		WED = false;
		XEi = new SortedList();
		rEk = 0;
		MEF = 0L;
		DET = null;
		lEJ = null;
		jEs = 0L;
		hEA = 0;
		CEK = false;
		fEl = false;
		lEv = 0;
		yEt = IntPtr.Zero;
		pEM = false;
		JEL = new Hashtable();
		PEr = null;
		eEX = null;
		tE3 = null;
		dEV = null;
		rEu = null;
		JE8 = null;
		VEj = IntPtr.Zero;
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private void tRF6r0()
	{
	}

	internal static byte[] SnD(byte[] byte_0)
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
			Gni(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			Gni(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			Gni(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			Gni(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			Gni(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			Gni(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			Gni(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			Gni(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			Gni(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			Gni(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			Gni(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			Gni(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			Gni(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			Gni(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			Gni(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			Gni(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			Ink(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			Ink(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			Ink(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			Ink(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			Ink(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			Ink(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			Ink(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			Ink(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			Ink(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			Ink(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			Ink(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			Ink(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			Ink(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			Ink(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			Ink(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			Ink(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			inF(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			inF(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			inF(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			inF(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			inF(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			inF(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			inF(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			inF(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			inF(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			inF(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			inF(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			inF(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			inF(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			inF(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			inF(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			inF(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			fnT(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			fnT(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			fnT(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			fnT(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			fnT(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			fnT(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			fnT(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			fnT(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			fnT(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			fnT(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			fnT(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			fnT(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			fnT(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			fnT(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			fnT(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			fnT(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void Gni(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + jnJ(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + KES[uint_5 - 1], ushort_0);
	}

	private static void Ink(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + jnJ(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + KES[uint_5 - 1], ushort_0);
	}

	private static void inF(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + jnJ(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + KES[uint_5 - 1], ushort_0);
	}

	private static void fnT(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + jnJ(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + KES[uint_5 - 1], ushort_0);
	}

	private static uint jnJ(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool Tns()
	{
		if (!nEf)
		{
			XnK();
			nEf = true;
		}
		return VEW;
	}

	internal static SymmetricAlgorithm qnA()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (Tns())
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

	internal static void XnK()
	{
		try
		{
			VEW = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] Cnl(byte[] byte_0)
	{
		if (!Tns())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return SnD(byte_0);
	}

	internal static void Mnv(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			stream_0.Read(byte_0, 0, num);
			Vnt(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void Vnt(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint bnM(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
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

	public static void inL(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (qEx == null)
			{
				lock (jE5)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(sE).Assembly.GetManifestResourceStream("OWqx2eTffotbMcOZuy.EfiIwjgXJVx3tkIO6V"));
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
							num3 += Pn3(num3);
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
						UM uM = new UM(new MemoryStream(array));
						for (int l = 0; l < num11; l++)
						{
							int key = uM.lEU();
							int value = uM.lEU();
							dictionary.Add(key, value);
						}
						uM.pE6();
					}
					qEx = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int metadataToken = fieldInfo.MetadataToken;
				int num12 = qEx[metadataToken];
				bool flag = (num12 & 0x40000000) > 0;
				num12 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)typeof(sE).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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
					array3[0] = typeof(object);
				}
				for (int num14 = 0; num14 < parameters.Length; num14++)
				{
					array3[num14 + 1] = parameters[num14].ParameterType;
				}
				DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
				ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
				for (int num15 = 0; num15 < num13; num15++)
				{
					switch (num15)
					{
					default:
						iLGenerator.Emit(OpCodes.Ldarg_S, num15);
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

	private static uint VnX(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	private static uint Pn3(uint uint_0)
	{
		return 0u;
	}

	internal static void snV()
	{
	}

	[ny(typeof(ny.Mm<object>[]))]
	internal static string znu(int int_0)
	{
		int num = 21;
		UM object_ = default(UM);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num5 = default(int);
		int num8 = default(int);
		int num6 = default(int);
		byte[] array5 = default(byte[]);
		byte[] array7 = default(byte[]);
		int num20 = default(int);
		int num19 = default(int);
		byte[] array6 = default(byte[]);
		int num26 = default(int);
		byte[] array3 = default(byte[]);
		SymmetricAlgorithm object_2 = default(SymmetricAlgorithm);
		int num7 = default(int);
		int num11 = default(int);
		uint num15 = default(uint);
		uint num17 = default(uint);
		uint num25 = default(uint);
		int num23 = default(int);
		uint num18 = default(uint);
		uint num12 = default(uint);
		int num10 = default(int);
		int num27 = default(int);
		uint num21 = default(uint);
		uint num9 = default(uint);
		int num24 = default(int);
		int num16 = default(int);
		byte[] array4 = default(byte[]);
		Stream stream = default(Stream);
		CryptoStream object_3 = default(CryptoStream);
		ICryptoTransform transform = default(ICryptoTransform);
		uint num22 = default(uint);
		string result = default(string);
		int int_ = default(int);
		int num4 = default(int);
		while (true)
		{
			IL_26f9:
			if (XE4.Length != 0)
			{
				num = 20;
				goto IL_007c;
			}
			goto IL_26ca;
			IL_0043:
			int num2 = num;
			goto IL_2002;
			IL_26ca:
			object_ = new UM((Stream)vt(QEq, "ZLkXImhQyLY9aG4ur6.6K4uuRtcngW08sOcg9"));
			num = 209;
			goto IL_26b3;
			IL_26b3:
			S8(AO(object_), 0L);
			goto IL_2688;
			IL_2688:
			array = (byte[])EI(object_, (int)di(AO(object_)));
			num2 = 168;
			if (!MM())
			{
				goto IL_0043;
			}
			goto IL_2002;
			IL_2002:
			while (true)
			{
				switch (num2)
				{
				case 414:
					array2[16] = (byte)num5;
					goto case 295;
				case 295:
					num8 = 157;
					goto case 381;
				case 381:
					array2[17] = (byte)num8;
					num2 = 47;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 413:
					num6 = 187;
					goto case 314;
				case 314:
					array5[10] = (byte)num6;
					num2 = 37;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 412:
					XE4 = array7;
					break;
				case 20:
				case 198:
					break;
				case 411:
					num20 = array.Length % 4;
					goto case 269;
				case 269:
					num19 = array.Length / 4;
					goto case 52;
				case 52:
					array7 = new byte[array.Length];
					num2 = 190;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 410:
					num6 = 141;
					goto case 106;
				case 106:
					array5[7] = (byte)num6;
					num = 43;
					goto case 43;
				case 43:
					array5[7] = 34;
					num2 = 4;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 409:
					num5 = 149;
					goto case 147;
				case 147:
					array2[23] = (byte)num5;
					goto case 372;
				case 372:
					array2[23] = 153;
					num2 = 281;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 408:
					array2[23] = (byte)num5;
					num = 129;
					goto case 129;
				case 129:
					array2[24] = 110;
					goto case 164;
				case 164:
					num8 = 67;
					num2 = 53;
					if (MM())
					{
						continue;
					}
					goto case 43;
				case 407:
					array5[14] = 166;
					goto case 387;
				case 387:
					array5[14] = 144;
					num2 = 3;
					if (!MM())
					{
						continue;
					}
					goto case 7;
				case 7:
					num6 = 58;
					goto case 125;
				case 125:
					array5[14] = (byte)num6;
					goto case 238;
				case 238:
					num6 = 217;
					num2 = 260;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 406:
					array5[5] = (byte)num6;
					goto case 159;
				case 159:
					num6 = 158;
					num = 364;
					goto case 364;
				case 364:
					array5[6] = (byte)num6;
					goto case 354;
				case 354:
					array5[6] = 86;
					goto case 169;
				case 169:
					num6 = 52;
					goto case 233;
				case 233:
					array5[6] = (byte)num6;
					goto case 399;
				case 399:
					array5[7] = 53;
					num2 = 92;
					if (!MM())
					{
						continue;
					}
					goto case 132;
				case 132:
					array5[7] = 108;
					num2 = 410;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 405:
					array5[4] = 179;
					num2 = 254;
					if (BY() != null)
					{
						continue;
					}
					goto case 267;
				case 267:
					num6 = 165;
					num2 = 352;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 404:
					array5[11] = 15;
					num2 = 35;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 403:
					array2[20] = 138;
					goto case 355;
				case 355:
					num8 = 147;
					num2 = 287;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 402:
					array2[14] = (byte)num5;
					goto case 189;
				case 189:
					array2[14] = 117;
					num2 = 71;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 401:
					array2[14] = 200;
					goto case 200;
				case 200:
					num5 = 149;
					goto case 402;
				case 400:
					array2[8] = 183;
					num = 388;
					goto case 388;
				case 388:
					array2[9] = 68;
					num = 8;
					goto case 8;
				case 8:
					num5 = 124;
					goto case 48;
				case 48:
					array2[9] = (byte)num5;
					num2 = 78;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 398:
					num6 = 106;
					num2 = 286;
					if (MM())
					{
						continue;
					}
					goto case 180;
				case 44:
					array6[num26] = (byte)(array6[num26] ^ array3[num26]);
					num = 327;
					goto case 327;
				case 327:
					num26++;
					goto case 180;
				case 180:
				case 220:
					if (num26 < array3.Length)
					{
						goto case 44;
					}
					num = 178;
					goto case 178;
				case 178:
					if (int_0 != -1)
					{
						goto case 411;
					}
					goto case 15;
				case 15:
					object_2 = (SymmetricAlgorithm)O1();
					goto case 303;
				case 303:
					YX(object_2, CipherMode.CBC);
					num2 = 16;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 396:
					array5[1] = (byte)num6;
					num2 = 350;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 395:
					num5 = 118;
					goto case 360;
				case 360:
					array2[29] = (byte)num5;
					num2 = 168;
					if (!MM())
					{
						continue;
					}
					goto case 208;
				case 208:
					num8 = 124;
					goto case 330;
				case 330:
					array2[29] = (byte)num8;
					num2 = 165;
					if (MM())
					{
						continue;
					}
					goto case 120;
				case 120:
					num7 = 0;
					goto case 240;
				case 240:
					if (num11 == num19 - 1)
					{
						goto case 119;
					}
					goto case 298;
				case 119:
					if (num20 > 0)
					{
						num2 = 337;
						if (MM())
						{
							continue;
						}
						goto IL_0043;
					}
					goto case 298;
				case 298:
					num15 += num17;
					num2 = 136;
					if (BY() != null)
					{
						continue;
					}
					goto case 153;
				case 153:
					num25 = (uint)num23;
					goto case 145;
				case 145:
					num18 = (uint)((array[num25 + 3] << 24) | (array[num25 + 2] << 16) | (array[num25 + 1] << 8) | array[num25]);
					goto case 64;
				case 64:
				case 235:
					num12 = num15;
					goto case 318;
				case 318:
					num15 = 0u;
					num2 = 131;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 394:
					if (num10 <= 0)
					{
						goto case 321;
					}
					goto case 101;
				case 321:
					num18 |= array[^(1 + num10)];
					num = 333;
					goto case 333;
				case 333:
					num10++;
					goto case 195;
				case 101:
					num18 <<= 8;
					goto case 321;
				case 195:
				case 299:
					if (num10 >= num20)
					{
						goto case 64;
					}
					goto case 394;
				case 393:
					array2[24] = (byte)num5;
					num2 = 10;
					if (BY() != null)
					{
						continue;
					}
					goto case 290;
				case 290:
					array2[25] = 138;
					num2 = 98;
					if (BY() != null)
					{
						continue;
					}
					goto case 171;
				case 171:
					array2[25] = 109;
					num = 226;
					goto case 226;
				case 226:
					array2[25] = 96;
					goto case 348;
				case 348:
					num5 = 0;
					goto case 157;
				case 157:
					array2[25] = (byte)num5;
					num2 = 365;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 392:
					array3 = array5;
					goto case 302;
				case 302:
					r0(array3);
					num2 = 12;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 391:
					array2[22] = (byte)num5;
					goto case 254;
				case 254:
					num5 = 121;
					goto case 317;
				case 317:
					array2[22] = (byte)num5;
					num2 = 264;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 390:
					num27 = 0;
					goto case 73;
				case 148:
					if (num27 > 0)
					{
						num2 = 284;
						if (MM())
						{
							continue;
						}
						goto IL_0043;
					}
					goto case 363;
				case 363:
					array7[num23 + num27] = (byte)((num21 & num9) >> num7);
					goto case 334;
				case 334:
					num27++;
					num = 368;
					goto case 73;
				case 73:
				case 368:
					if (num27 < num20)
					{
						goto case 148;
					}
					goto case 108;
				case 108:
				case 155:
					num11++;
					num = 184;
					goto case 13;
				case 13:
				case 184:
					if (num11 >= num19)
					{
						num = 412;
						goto case 412;
					}
					goto case 105;
				case 105:
					num24 = num11 % num16;
					num2 = 218;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 389:
					num15 += num17;
					num2 = 72;
					if (BY() == null)
					{
						continue;
					}
					break;
				case 386:
					num6 = 111;
					num2 = 361;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 385:
					array2[16] = 156;
					goto case 249;
				case 249:
					array2[16] = 132;
					goto case 301;
				case 301:
					num8 = 158;
					num2 = 81;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 384:
					num5 = 219;
					goto case 351;
				case 351:
					array2[22] = (byte)num5;
					num = 409;
					goto case 409;
				case 383:
					array2[12] = 234;
					goto case 222;
				case 222:
					array2[12] = 201;
					goto case 172;
				case 172:
					array2[12] = 52;
					num2 = 253;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 382:
					num8 = 90;
					goto case 338;
				case 338:
					array2[0] = (byte)num8;
					num2 = 167;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 380:
					array5[5] = (byte)num6;
					num2 = 174;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 379:
					num8 = 147;
					goto case 273;
				case 273:
					array2[17] = (byte)num8;
					goto case 89;
				case 89:
					array2[17] = 52;
					goto case 96;
				case 96:
					num5 = 148;
					goto case 86;
				case 86:
					array2[18] = (byte)num5;
					num2 = 113;
					if (MM())
					{
						continue;
					}
					goto case 43;
				case 378:
					array5[11] = 86;
					goto case 133;
				case 133:
					num6 = 200;
					num2 = 25;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 336:
				case 377:
					num26 = 0;
					goto case 180;
				case 376:
					num6 = 197;
					goto case 396;
				case 375:
					if (array4.Length > 0)
					{
						num2 = 340;
						if (BY() == null)
						{
							continue;
						}
						goto IL_0043;
					}
					goto case 336;
				case 374:
					array2[3] = (byte)num8;
					num2 = 309;
					if (BY() == null)
					{
						continue;
					}
					goto case 284;
				case 284:
					num9 <<= 8;
					num2 = 51;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 373:
					stream = (Stream)X4();
					goto case 31;
				case 31:
					object_3 = new CryptoStream(stream, transform, CryptoStreamMode.Write);
					num2 = 92;
					if (!MM())
					{
						continue;
					}
					goto case 143;
				case 143:
					Dr(object_3, array, 0, array.Length);
					num2 = 115;
					if (BY() == null)
					{
						continue;
					}
					goto case 111;
				case 111:
					array2[6] = (byte)num5;
					goto case 97;
				case 97:
					array2[6] = 47;
					num = 191;
					goto case 191;
				case 191:
					array2[7] = 141;
					num2 = 1;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 371:
					array5[3] = (byte)num6;
					num = 66;
					goto case 66;
				case 66:
					num6 = 148;
					num2 = 18;
					if (!MM())
					{
						continue;
					}
					goto case 265;
				case 265:
					array5[3] = (byte)num6;
					goto case 319;
				case 319:
					num6 = 55;
					goto case 203;
				case 203:
					array5[3] = (byte)num6;
					num2 = 138;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 370:
					array2[1] = 2;
					goto case 212;
				case 212:
					num5 = 146;
					num2 = 221;
					if (BY() == null)
					{
						continue;
					}
					goto case 129;
				case 369:
					array2[5] = (byte)num5;
					goto case 194;
				case 194:
					array2[5] = 92;
					num = 39;
					goto case 39;
				case 39:
					array2[5] = 130;
					goto case 134;
				case 134:
					num8 = 45;
					goto case 18;
				case 18:
					array2[5] = (byte)num8;
					goto case 32;
				case 32:
					array2[6] = 116;
					num2 = 322;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 367:
					array2[19] = 39;
					goto case 331;
				case 331:
					num5 = 35;
					num = 225;
					goto case 225;
				case 225:
					array2[19] = (byte)num5;
					goto case 280;
				case 280:
					num8 = 167;
					num2 = 275;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 366:
					array5[0] = 176;
					num = 186;
					goto case 186;
				case 186:
					num6 = 110;
					goto case 211;
				case 211:
					array5[1] = (byte)num6;
					goto case 376;
				case 365:
					array2[26] = 85;
					goto case 232;
				case 232:
					array2[26] = 72;
					num2 = 139;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 362:
					num6 = 85;
					goto case 136;
				case 136:
					array5[0] = (byte)num6;
					goto case 366;
				case 361:
					array5[3] = (byte)num6;
					goto case 144;
				case 144:
					array5[4] = 182;
					goto case 75;
				case 75:
					array5[4] = 226;
					goto case 177;
				case 177:
					num6 = 118;
					num2 = 0;
					if (BY() != null)
					{
						continue;
					}
					goto default;
				default:
					array5[4] = (byte)num6;
					num = 405;
					goto case 405;
				case 359:
					num5 = 90;
					goto case 313;
				case 313:
					array2[11] = (byte)num5;
					goto case 50;
				case 50:
					num5 = 108;
					num2 = 297;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 358:
					num6 = 116;
					num2 = 371;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 357:
					array5[2] = (byte)num6;
					goto case 257;
				case 257:
					array5[2] = 46;
					goto case 166;
				case 166:
					array5[2] = 152;
					num2 = 135;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 356:
					array2[8] = 136;
					goto case 217;
				case 217:
					array2[8] = 160;
					goto case 266;
				case 266:
					array2[8] = 40;
					goto case 315;
				case 315:
					array2[8] = 214;
					goto case 400;
				case 353:
					num5 = 148;
					goto case 414;
				case 352:
					array5[4] = (byte)num6;
					goto case 110;
				case 110:
					num6 = 100;
					goto case 342;
				case 342:
					array5[5] = (byte)num6;
					num2 = 230;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 350:
					array5[1] = 31;
					goto case 161;
				case 161:
					array5[2] = 170;
					goto case 261;
				case 261:
					num6 = 117;
					goto case 357;
				case 349:
					array2[13] = (byte)num8;
					goto case 294;
				case 294:
					num8 = 125;
					goto case 30;
				case 30:
					array2[13] = (byte)num8;
					goto case 326;
				case 326:
					array2[13] = 71;
					num2 = 401;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 347:
					num5 = 86;
					goto case 140;
				case 140:
					array2[11] = (byte)num5;
					num2 = 222;
					if (!MM())
					{
						continue;
					}
					goto case 262;
				case 262:
					array2[11] = 132;
					goto case 162;
				case 162:
					array2[11] = 227;
					num2 = 35;
					if (!MM())
					{
						continue;
					}
					goto case 205;
				case 205:
					array2[12] = 64;
					num = 187;
					goto case 187;
				case 187:
					num8 = 141;
					goto case 90;
				case 90:
					array2[12] = (byte)num8;
					goto case 383;
				case 346:
					array6 = array2;
					num2 = 213;
					if (BY() == null)
					{
						continue;
					}
					goto case 137;
				case 137:
					num8 = 127;
					goto case 23;
				case 23:
					array2[9] = (byte)num8;
					goto case 192;
				case 192:
					array2[10] = 162;
					goto case 251;
				case 251:
					array2[10] = 52;
					goto case 252;
				case 252:
					num8 = 152;
					goto case 122;
				case 122:
					array2[10] = (byte)num8;
					num2 = 216;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 345:
					num5 = 98;
					goto case 100;
				case 100:
					array2[23] = (byte)num5;
					num2 = 19;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 344:
					array5[13] = (byte)num6;
					goto case 407;
				case 343:
					array2[1] = 126;
					num2 = 36;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 341:
					array2[20] = (byte)num8;
					num2 = 118;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 340:
					array3[1] = array4[0];
					num2 = 2;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 339:
					array2[28] = 182;
					num2 = 239;
					if (BY() == null)
					{
						continue;
					}
					goto case 230;
				case 230:
					num6 = 160;
					goto case 380;
				case 337:
					num18 = 0u;
					goto case 389;
				case 335:
					array2[13] = (byte)num8;
					goto case 104;
				case 104:
					array2[13] = 191;
					goto case 126;
				case 126:
					num8 = 87;
					num2 = 349;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 332:
					array5[13] = (byte)num6;
					num2 = 78;
					if (BY() != null)
					{
						continue;
					}
					goto case 124;
				case 124:
					array5[13] = 222;
					goto case 150;
				case 150:
					array5[13] = 145;
					goto case 26;
				case 26:
					num6 = 15;
					num2 = 262;
					if (!MM())
					{
						continue;
					}
					goto case 344;
				case 329:
					array2[10] = (byte)num5;
					goto case 223;
				case 223:
					array2[10] = 60;
					num2 = 258;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 328:
					array2[30] = 135;
					goto case 202;
				case 202:
					array2[30] = 2;
					goto case 288;
				case 288:
					array2[31] = 141;
					num2 = 60;
					if (BY() == null)
					{
						continue;
					}
					goto case 36;
				case 36:
					num5 = 140;
					goto case 305;
				case 305:
					array2[1] = (byte)num5;
					goto case 141;
				case 141:
					array2[1] = 168;
					goto case 370;
				case 325:
					array5[8] = 139;
					num = 142;
					goto case 142;
				case 142:
					array5[8] = 27;
					goto case 92;
				case 92:
					num6 = 123;
					goto case 228;
				case 228:
					array5[8] = (byte)num6;
					num = 82;
					goto case 82;
				case 82:
					array5[8] = 209;
					goto case 210;
				case 210:
					array5[9] = 160;
					num2 = 29;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 324:
					array2[22] = (byte)num8;
					goto case 307;
				case 307:
					num5 = 151;
					goto case 391;
				case 323:
					num5 = 98;
					goto case 95;
				case 95:
					array2[4] = (byte)num5;
					num2 = 3;
					if (BY() != null)
					{
						continue;
					}
					goto case 170;
				case 170:
					num8 = 83;
					goto case 91;
				case 91:
					array2[4] = (byte)num8;
					num2 = 276;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 322:
					array2[6] = 142;
					num2 = 128;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 320:
					num8 = 236;
					num2 = 341;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 316:
					array7[num23 + 3] = (byte)((num22 & 0xFF000000u) >> 24);
					num2 = 108;
					if (MM())
					{
						continue;
					}
					goto case 75;
				case 312:
					array2[15] = 69;
					goto case 117;
				case 117:
					num5 = 166;
					goto case 243;
				case 243:
					array2[15] = (byte)num5;
					goto case 310;
				case 310:
					array2[15] = 31;
					goto case 74;
				case 74:
					array2[16] = 194;
					num2 = 79;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 311:
					if (array4 == null)
					{
						goto case 336;
					}
					goto case 375;
				case 309:
					array2[3] = 35;
					goto case 40;
				case 40:
					num8 = 41;
					goto case 270;
				case 270:
					array2[4] = (byte)num8;
					goto case 263;
				case 263:
					array2[4] = 157;
					num = 323;
					goto case 323;
				case 308:
					num8 = 111;
					goto case 59;
				case 59:
					array2[13] = (byte)num8;
					num2 = 181;
					if (BY() == null)
					{
						continue;
					}
					goto case 157;
				case 306:
					num8 = 108;
					goto case 65;
				case 65:
					array2[15] = (byte)num8;
					num = 185;
					goto case 185;
				case 185:
					array2[15] = 104;
					num2 = 175;
					if (MM())
					{
						continue;
					}
					goto case 144;
				case 304:
					num6 = 87;
					num2 = 99;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 300:
					num8 = 175;
					goto case 6;
				case 6:
					array2[29] = (byte)num8;
					goto case 241;
				case 241:
					num8 = 98;
					num = 277;
					goto case 277;
				case 277:
					array2[30] = (byte)num8;
					num2 = 85;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 297:
					array2[11] = (byte)num5;
					goto case 347;
				case 296:
					num25 = 0u;
					num2 = 83;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 293:
					array2[9] = (byte)num8;
					goto case 137;
				case 292:
					num6 = 161;
					goto case 268;
				case 268:
					array5[10] = (byte)num6;
					goto case 11;
				case 11:
					array5[10] = 196;
					goto case 28;
				case 28:
					array5[10] = 123;
					num2 = 413;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 291:
					num19++;
					goto case 296;
				case 289:
					num6 = 74;
					num2 = 406;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 287:
					array2[20] = (byte)num8;
					num2 = 45;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 286:
					array5[12] = (byte)num6;
					goto case 84;
				case 84:
					array5[12] = 54;
					num2 = 285;
					if (MM())
					{
						continue;
					}
					goto case 108;
				case 285:
					num6 = 125;
					goto case 332;
				case 283:
					array2[27] = 120;
					num2 = 17;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 282:
					array7[num23 + 2] = (byte)((num22 & 0xFF0000) >> 16);
					goto case 316;
				case 281:
					array2[23] = 97;
					goto case 5;
				case 5:
					array2[23] = 162;
					num = 345;
					goto case 345;
				case 279:
					array2[0] = (byte)num8;
					num2 = 46;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 278:
					array3[9] = array4[4];
					num2 = 52;
					if (BY() != null)
					{
						continue;
					}
					goto case 54;
				case 54:
					array3[11] = array4[5];
					goto case 215;
				case 215:
					array3[13] = array4[6];
					goto case 87;
				case 87:
					array3[15] = array4[7];
					goto case 336;
				case 276:
					array2[4] = 212;
					goto case 34;
				case 34:
					array2[4] = 77;
					goto case 272;
				case 272:
					num5 = 110;
					goto case 369;
				case 275:
					array2[19] = (byte)num8;
					num2 = 12;
					if (!MM())
					{
						continue;
					}
					goto case 109;
				case 109:
					array2[19] = 109;
					goto case 403;
				case 274:
					num5 = 139;
					goto case 193;
				case 193:
					array2[21] = (byte)num5;
					goto case 207;
				case 207:
					num8 = 195;
					num2 = 324;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 271:
					if (num20 <= 0)
					{
						goto case 296;
					}
					goto case 291;
				case 264:
					num8 = 163;
					num2 = 248;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 260:
					array5[15] = (byte)num6;
					num2 = 9;
					if (BY() != null)
					{
						continue;
					}
					goto case 10;
				case 10:
					array5[15] = 124;
					goto case 68;
				case 68:
					array5[15] = 248;
					num2 = 392;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 259:
					array2[15] = (byte)num8;
					num2 = 310;
					if (BY() != null)
					{
						continue;
					}
					goto case 312;
				case 258:
					array2[11] = 140;
					goto case 359;
				case 256:
					array2[2] = 207;
					num2 = 250;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 255:
					array5[8] = (byte)num6;
					goto case 325;
				case 253:
					array2[12] = 89;
					goto case 308;
				case 250:
					num8 = 138;
					goto case 245;
				case 245:
					array2[3] = (byte)num8;
					num = 188;
					goto case 188;
				case 188:
					array2[3] = 158;
					num2 = 25;
					if (!MM())
					{
						continue;
					}
					goto case 38;
				case 38:
					num5 = 140;
					goto case 179;
				case 179:
					array2[3] = (byte)num5;
					num = 49;
					goto case 49;
				case 49:
					num8 = 96;
					num2 = 374;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 248:
					array2[22] = (byte)num8;
					goto case 227;
				case 227:
					num5 = 178;
					num2 = 9;
					if (!MM())
					{
						continue;
					}
					goto case 24;
				case 24:
					array2[22] = (byte)num5;
					num = 384;
					goto case 384;
				case 247:
					array7[num23 + 1] = (byte)((num22 & 0xFF00) >> 8);
					goto case 282;
				case 246:
					array2[14] = 162;
					goto case 306;
				case 244:
					array2[31] = 150;
					num2 = 346;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 242:
					array5[0] = 106;
					goto case 362;
				case 239:
					array2[28] = 79;
					num2 = 57;
					if (MM())
					{
						continue;
					}
					goto case 40;
				case 237:
					array5[12] = 156;
					goto case 398;
				case 236:
					num6 = 113;
					num2 = 163;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 234:
					num25 = (uint)(num24 * 4);
					num = 42;
					goto case 42;
				case 42:
					num17 = (uint)((array6[num25 + 3] << 24) | (array6[num25 + 2] << 16) | (array6[num25 + 1] << 8) | array6[num25]);
					num2 = 70;
					if (MM())
					{
						continue;
					}
					goto case 7;
				case 231:
					array5[10] = 97;
					num = 292;
					goto case 292;
				case 229:
					array3[5] = array4[2];
					num2 = 14;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 224:
					num8 = 212;
					num2 = 58;
					if (BY() == null)
					{
						continue;
					}
					goto case 30;
				case 221:
					array2[2] = (byte)num5;
					goto case 94;
				case 94:
					array2[2] = 124;
					num2 = 146;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 219:
					array5[10] = 188;
					num2 = 231;
					if (BY() == null)
					{
						continue;
					}
					goto case 71;
				case 71:
					array2[14] = 19;
					goto case 246;
				case 218:
					num23 = num11 * 4;
					goto case 234;
				case 216:
					array2[10] = 74;
					goto case 127;
				case 127:
					num5 = 186;
					num = 329;
					goto case 329;
				case 214:
					num6 = 163;
					goto case 116;
				case 116:
					array5[8] = (byte)num6;
					num2 = 154;
					if (BY() == null)
					{
						continue;
					}
					goto case 112;
				case 112:
					array2[18] = (byte)num8;
					goto case 206;
				case 206:
					num5 = 150;
					num2 = 62;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 213:
					array5 = new byte[16];
					num2 = 242;
					if (MM())
					{
						continue;
					}
					goto case 183;
				case 183:
					num5 = 232;
					goto case 393;
				case 204:
					num8 = 182;
					goto case 279;
				case 201:
					if (num11 == num19 - 1)
					{
						goto case 55;
					}
					goto case 107;
				case 55:
					if (num20 > 0)
					{
						num2 = 5;
						if (!MM())
						{
							continue;
						}
						goto case 9;
					}
					goto case 107;
				case 9:
					num21 = num15 ^ num18;
					num2 = 390;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 107:
					num22 = num15 ^ num18;
					num = 196;
					goto case 196;
				case 196:
					array7[num23] = (byte)(num22 & 0xFFu);
					goto case 247;
				case 199:
					rw(stream);
					num2 = 76;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 197:
					array2[7] = 172;
					num2 = 356;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 190:
					num16 = array6.Length / 4;
					goto case 77;
				case 77:
					num15 = 0u;
					goto case 3;
				case 3:
					num17 = 0u;
					goto case 182;
				case 182:
					num18 = 0u;
					num2 = 234;
					if (BY() != null)
					{
						continue;
					}
					goto case 271;
				case 181:
					num8 = 96;
					num = 335;
					goto case 335;
				case 176:
					array5[9] = 43;
					goto case 219;
				case 175:
					num8 = 144;
					num2 = 259;
					if (BY() == null)
					{
						continue;
					}
					goto case 224;
				case 174:
					num6 = 80;
					num = 102;
					goto case 102;
				case 102:
					array5[5] = (byte)num6;
					goto case 304;
				case 173:
					array2[19] = (byte)num8;
					num = 367;
					goto case 367;
				case 168:
					ae(object_);
					goto case 61;
				case 61:
					array2 = new byte[32];
					goto case 98;
				case 98:
					num5 = 134;
					num2 = 130;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 167:
					array2[0] = 211;
					goto case 204;
				case 165:
					array2[29] = 92;
					goto case 300;
				case 163:
					array5[11] = (byte)num6;
					goto case 237;
				case 160:
					array2[28] = 57;
					goto case 339;
				case 158:
					array2[18] = (byte)num5;
					goto case 114;
				case 114:
					num8 = 98;
					goto case 173;
				case 156:
					num15 = num12;
					goto case 201;
				case 154:
					num6 = 136;
					num2 = 255;
					if (BY() == null)
					{
						continue;
					}
					goto case 59;
				case 152:
					array2[27] = 154;
					num2 = 33;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 151:
					array2[28] = 115;
					goto case 67;
				case 67:
					array2[28] = 122;
					num2 = 160;
					if (BY() == null)
					{
						continue;
					}
					goto case 90;
				case 149:
					array2[20] = 55;
					goto case 320;
				case 146:
					array2[2] = 92;
					goto case 256;
				case 139:
					array2[26] = 156;
					num2 = 283;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 138:
					array5[3] = 109;
					num2 = 386;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 135:
					array5[2] = 179;
					goto case 80;
				case 80:
					array5[2] = 199;
					goto case 358;
				case 131:
				{
					uint num13 = num12;
					uint num14 = num12;
					num14 ^= num14 << 27;
					num14 += 3890013905u;
					num14 ^= num14 >> 3;
					num14 += 1873524328;
					num14 ^= num14 << 4;
					num14 += 2748867457u;
					num14 = 3767789902u - num14;
					num12 = num13 + (uint)(double)num14;
					num2 = 94;
					if (BY() != null)
					{
						continue;
					}
					goto case 156;
				}
				case 130:
					array2[0] = (byte)num5;
					num2 = 382;
					if (BY() == null)
					{
						continue;
					}
					goto case 146;
				case 128:
					array2[6] = 117;
					num = 123;
					goto case 123;
				case 123:
					num5 = 183;
					goto case 111;
				case 121:
					array2[27] = (byte)num5;
					num2 = 224;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 118:
					array2[21] = 153;
					num = 93;
					goto case 93;
				case 93:
					num5 = 140;
					num2 = 88;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 115:
					ox(object_3);
					num2 = 22;
					if (MM())
					{
						continue;
					}
					goto case 19;
				case 19:
					num5 = 144;
					num2 = 408;
					if (MM())
					{
						continue;
					}
					goto case 68;
				case 113:
					num8 = 18;
					num2 = 82;
					if (!MM())
					{
						continue;
					}
					goto case 112;
				case 103:
					array = XE4;
					num2 = 411;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 99:
					array5[5] = (byte)num6;
					num2 = 289;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 88:
					array2[21] = (byte)num5;
					goto case 274;
				case 85:
					array2[30] = 152;
					goto case 328;
				case 83:
					num11 = 0;
					goto case 13;
				case 81:
					array2[16] = (byte)num8;
					num = 353;
					goto case 353;
				case 79:
					array2[16] = 121;
					goto case 385;
				case 78:
					num8 = 121;
					goto case 293;
				case 76:
					rw(object_3);
					num2 = 103;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 72:
					num10 = 0;
					goto case 195;
				case 70:
					num9 = 255u;
					num2 = 120;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 63:
					array5[7] = 116;
					goto case 214;
				case 62:
					array2[18] = (byte)num5;
					num2 = 41;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 60:
					array2[31] = 156;
					num = 244;
					goto case 244;
				case 58:
					array2[27] = (byte)num8;
					goto case 152;
				case 57:
					array2[28] = 43;
					goto case 395;
				case 53:
					array2[24] = (byte)num8;
					goto case 183;
				case 51:
					num7 += 8;
					goto case 363;
				case 47:
					array2[17] = 98;
					goto case 379;
				case 46:
					array2[1] = 133;
					goto case 343;
				case 45:
					array2[20] = 112;
					num2 = 149;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 41:
					num5 = 15;
					num2 = 158;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 37:
					array5[11] = 164;
					num2 = 404;
					if (BY() == null)
					{
						continue;
					}
					goto case 293;
				case 35:
					array5[11] = 164;
					goto case 378;
				case 33:
					array2[27] = 186;
					num2 = 151;
					if (MM())
					{
						continue;
					}
					goto IL_0043;
				case 29:
					array5[9] = 162;
					goto case 176;
				case 25:
					array5[11] = (byte)num6;
					num = 236;
					goto case 236;
				case 22:
					XE4 = (byte[])OU(stream);
					goto case 199;
				case 17:
					num5 = 142;
					num2 = 121;
					if (BY() == null)
					{
						continue;
					}
					goto IL_0043;
				case 16:
					transform = (ICryptoTransform)sF(object_2, array6, array3);
					goto case 373;
				case 14:
					array3[7] = array4[3];
					goto case 278;
				case 12:
					array4 = (byte[])Dp(Gg(QEq));
					goto case 311;
				case 4:
					array5[7] = 86;
					goto case 63;
				case 2:
					array3[3] = array4[1];
					goto case 229;
				case 1:
					array2[7] = 115;
					goto case 197;
				case 27:
					goto IL_2688;
				case 209:
					goto IL_26b3;
				case 397:
					goto IL_26ca;
				case 21:
					goto IL_26f9;
				case 69:
					try
					{
						Q9();
						int num3 = 0;
						if (BY() == null)
						{
							goto IL_2717;
						}
						goto IL_273e;
						IL_273e:
						switch (num3)
						{
						case 1:
							return result;
						}
						goto IL_2717;
						IL_2717:
						result = (string)LS(xy(), XE4, int_0 + 4, int_);
						num3 = 1;
						if (!MM())
						{
							num3 = num4;
						}
						goto IL_273e;
					}
					catch
					{
						if (!MM())
						{
							switch (0)
							{
							}
						}
					}
					goto case 56;
				case 56:
					return "";
				}
				break;
			}
			goto IL_007c;
			IL_007c:
			int_ = e3(XE4, int_0);
			num2 = 69;
			if (!MM())
			{
				goto IL_0043;
			}
			goto IL_2002;
		}
	}

	[ny(typeof(ny.Mm<object>[]))]
	internal static string un8(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int Enj()
	{
		return 5;
	}

	private static void hn1()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate enO(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			typeof(Type)
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object Qnh(object object_0)
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

	private static IntPtr DnU(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (PEr == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Find ".Trim() + "ResourceA");
			PEr = (VX)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(VX));
		}
		return PEr(intptr_0, string_0, uint_0);
	}

	private static IntPtr Rn6(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (eEX == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			eEX = (gs)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(gs));
		}
		return eEX(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int Anz(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (tE3 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + "Process ".Trim() + "Memory");
			tE3 = (DS)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(DS));
		}
		return tE3(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int YEZ(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (dEV == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Protect");
			dEV = (If)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(If));
		}
		return dEV(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr QE2(uint uint_0, int int_0, uint uint_1)
	{
		if (rEu == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Open ".Trim() + "Process");
			rEu = (A9)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(A9));
		}
		return rEu(uint_0, int_0, uint_1);
	}

	private static int DEI(IntPtr intptr_0)
	{
		if (JE8 == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			JE8 = (ck)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(ck));
		}
		return JE8(intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (VEj == IntPtr.Zero)
		{
			VEj = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return VEj;
	}

	[ny(typeof(ny.Mm<object>[]))]
	private static byte[] UEg(string string_0)
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

	internal static Stream oEb()
	{
		return new MemoryStream();
	}

	internal static byte[] uEn(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[ny(typeof(ny.Mm<object>[]))]
	private static byte[] nEE(byte[] byte_0)
	{
		Stream stream = oEb();
		SymmetricAlgorithm symmetricAlgorithm = qnA();
		symmetricAlgorithm.Key = new byte[32]
		{
			76, 23, 114, 189, 209, 195, 137, 121, 67, 117,
			106, 12, 2, 203, 101, 236, 221, 57, 210, 188,
			66, 237, 8, 120, 169, 217, 179, 155, 26, 91,
			94, 145
		};
		symmetricAlgorithm.IV = new byte[16]
		{
			78, 82, 1, 139, 157, 232, 17, 75, 25, 8,
			4, 179, 132, 88, 223, 68
		};
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = uEn(stream);
		Rg.XRF6rz();
		return result;
	}

	private byte[] OE0()
	{
		return null;
	}

	private byte[] DEc()
	{
		return null;
	}

	private byte[] yE7()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] jEB()
	{
		string text = "{11111-22222-20001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] GE9()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] SEQ()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] KEp()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] EEw()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] gEY()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] UEN()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static object vt(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object AO(object object_0)
	{
		return ((UM)object_0).KDikMXewCI();
	}

	internal static void S8(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static long di(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static object EI(object object_0, int int_0)
	{
		return ((UM)object_0).cEe(int_0);
	}

	internal static void ae(object object_0)
	{
		((UM)object_0).pE6();
	}

	internal static void r0(object object_0)
	{
		Array.Reverse((Array)object_0);
	}

	internal static object Gg(object object_0)
	{
		return ((Assembly)object_0).GetName();
	}

	internal static object Dp(object object_0)
	{
		return ((AssemblyName)object_0).GetPublicKeyToken();
	}

	internal static object O1()
	{
		return qnA();
	}

	internal static void YX(object object_0, CipherMode cipherMode_0)
	{
		((SymmetricAlgorithm)object_0).Mode = cipherMode_0;
	}

	internal static object sF(object object_0, object object_1, object object_2)
	{
		return ((SymmetricAlgorithm)object_0).CreateDecryptor((byte[])object_1, (byte[]?)object_2);
	}

	internal static object X4()
	{
		return oEb();
	}

	internal static void Dr(object object_0, object object_1, int int_0, int int_1)
	{
		((Stream)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void ox(object object_0)
	{
		((CryptoStream)object_0).FlushFinalBlock();
	}

	internal static object OU(object object_0)
	{
		return uEn((Stream)object_0);
	}

	internal static void rw(object object_0)
	{
		((Stream)object_0).Close();
	}

	internal static int e3(object object_0, int int_0)
	{
		return BitConverter.ToInt32((byte[])object_0, int_0);
	}

	internal static void Q9()
	{
		Rg.XRF6rz();
	}

	internal static object xy()
	{
		return Encoding.Unicode;
	}

	internal static object LS(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static bool MM()
	{
		return (object)null == null;
	}

	internal static object BY()
	{
		return null;
	}
}
