using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;

namespace vc;

internal class Kg
{
	private delegate void kZ(object o);

	internal class zX : Attribute
	{
		internal class q0<od>
		{
			internal static object gsp;

			public q0()
			{
				OZ.kN(OZ.Ou);
				base._002Ector();
			}

			internal static bool Ssb()
			{
				return gsp == null;
			}

			internal static object oso()
			{
				return gsp;
			}
		}

		[zX(typeof(q0<object>[]))]
		public zX(object object_0)
		{
		}
	}

	internal class X7
	{
		[zX(typeof(zX.q0<object>[]))]
		internal static string wPo(string string_0, string string_1)
		{
			byte[] bytes = Encoding.Unicode.GetBytes(string_0);
			byte[] array = bytes;
			byte[] array2 = new byte[32];
			VsB(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
			byte[] object_ = array2;
			byte[] iV = qnX(Encoding.Unicode.GetBytes(string_1));
			MemoryStream memoryStream = new MemoryStream();
			SymmetricAlgorithm symmetricAlgorithm = yng();
			ksJ(symmetricAlgorithm, object_);
			symmetricAlgorithm.IV = iV;
			CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(array, 0, array.Length);
			cryptoStream.Close();
			return Convert.ToBase64String(memoryStream.ToArray());
		}

		internal static void VsB(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
		{
			RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
		}

		internal static void ksJ(object object_0, object object_1)
		{
			((SymmetricAlgorithm)object_0).Key = (byte[])object_1;
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate uint AE(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr FS();

	internal struct uy
	{
		internal bool WPN;

		internal byte[] EPu;
	}

	internal class Wv
	{
		private BinaryReader jPA;

		public Wv(Stream stream_0)
		{
			jPA = new BinaryReader(stream_0);
		}

		[SpecialName]
		internal Stream KDikMXewCI()
		{
			return jPA.BaseStream;
		}

		internal byte[] QPl(int int_0)
		{
			return jPA.ReadBytes(int_0);
		}

		internal int yPO(byte[] byte_0, int int_0, int int_1)
		{
			return jPA.Read(byte_0, int_0, int_1);
		}

		internal int AP3()
		{
			return jPA.ReadInt32();
		}

		internal void pPj()
		{
			Tsk(jPA);
		}

		internal static void Tsk(object object_0)
		{
			((BinaryReader)object_0).Close();
		}
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
	private delegate IntPtr SW(IntPtr hModule, string lpName, uint lpType);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr HG(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int z1(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int Ko(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr SN(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate int cu(IntPtr ptr);

	[Flags]
	private enum Jl
	{

	}

	private static bool anw;

	internal static Assembly Qnx;

	private static uint[] Dn8;

	private static bool cnR;

	private static bool pns;

	private static byte[] xnU;

	internal static RSACryptoServiceProvider ynz;

	private static Dictionary<int, int> yP5;

	private static object OPc;

	private static byte[] tPn;

	private static byte[] IPP;

	private static IntPtr pPf;

	private static IntPtr vPI;

	private static object OPH;

	private static int[] fP6;

	private static int HPV;

	private static bool jPq;

	private static SortedList BPL;

	private static int VP2;

	private static long NPh;

	internal static AE YPF;

	internal static AE qPT;

	private static long mPD;

	private static int EPa;

	private static bool SPg;

	private static bool DPZ;

	private static int mPX;

	private static IntPtr mP0;

	[zX(typeof(zX.q0<object>[]))]
	private static bool QPd;

	internal static Hashtable WP7;

	private static SW iPE;

	private static HG UPS;

	private static z1 lPy;

	private static Ko OPv;

	private static SN uPW;

	private static cu WPG;

	private static IntPtr xP1;

	static Kg()
	{
		anw = false;
		Qnx = typeof(Kg).Assembly;
		uint[] array = new uint[64];
		bz(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		Dn8 = array;
		cnR = false;
		pns = false;
		xnU = new byte[0];
		ynz = null;
		yP5 = null;
		OPc = new object();
		tPn = new byte[0];
		IPP = new byte[0];
		pPf = IntPtr.Zero;
		vPI = IntPtr.Zero;
		OPH = new string[0];
		fP6 = new int[0];
		HPV = 1;
		jPq = false;
		BPL = new SortedList();
		VP2 = 0;
		NPh = 0L;
		YPF = null;
		qPT = null;
		mPD = 0L;
		EPa = 0;
		SPg = false;
		DPZ = false;
		mPX = 0;
		mP0 = IntPtr.Zero;
		QPd = false;
		WP7 = new Hashtable();
		iPE = null;
		UPS = null;
		lPy = null;
		OPv = null;
		uPW = null;
		WPG = null;
		xP1 = IntPtr.Zero;
		try
		{
			Ssx(bool_0: true);
		}
		catch
		{
		}
	}

	private void adPcGv()
	{
	}

	internal static byte[] YnL(byte[] byte_0)
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
			zn2(ref uint_, uint_2, uint_3, uint_4, 0u, 7, 1u, array);
			zn2(ref uint_4, uint_, uint_2, uint_3, 1u, 12, 2u, array);
			zn2(ref uint_3, uint_4, uint_, uint_2, 2u, 17, 3u, array);
			zn2(ref uint_2, uint_3, uint_4, uint_, 3u, 22, 4u, array);
			zn2(ref uint_, uint_2, uint_3, uint_4, 4u, 7, 5u, array);
			zn2(ref uint_4, uint_, uint_2, uint_3, 5u, 12, 6u, array);
			zn2(ref uint_3, uint_4, uint_, uint_2, 6u, 17, 7u, array);
			zn2(ref uint_2, uint_3, uint_4, uint_, 7u, 22, 8u, array);
			zn2(ref uint_, uint_2, uint_3, uint_4, 8u, 7, 9u, array);
			zn2(ref uint_4, uint_, uint_2, uint_3, 9u, 12, 10u, array);
			zn2(ref uint_3, uint_4, uint_, uint_2, 10u, 17, 11u, array);
			zn2(ref uint_2, uint_3, uint_4, uint_, 11u, 22, 12u, array);
			zn2(ref uint_, uint_2, uint_3, uint_4, 12u, 7, 13u, array);
			zn2(ref uint_4, uint_, uint_2, uint_3, 13u, 12, 14u, array);
			zn2(ref uint_3, uint_4, uint_, uint_2, 14u, 17, 15u, array);
			zn2(ref uint_2, uint_3, uint_4, uint_, 15u, 22, 16u, array);
			inh(ref uint_, uint_2, uint_3, uint_4, 1u, 5, 17u, array);
			inh(ref uint_4, uint_, uint_2, uint_3, 6u, 9, 18u, array);
			inh(ref uint_3, uint_4, uint_, uint_2, 11u, 14, 19u, array);
			inh(ref uint_2, uint_3, uint_4, uint_, 0u, 20, 20u, array);
			inh(ref uint_, uint_2, uint_3, uint_4, 5u, 5, 21u, array);
			inh(ref uint_4, uint_, uint_2, uint_3, 10u, 9, 22u, array);
			inh(ref uint_3, uint_4, uint_, uint_2, 15u, 14, 23u, array);
			inh(ref uint_2, uint_3, uint_4, uint_, 4u, 20, 24u, array);
			inh(ref uint_, uint_2, uint_3, uint_4, 9u, 5, 25u, array);
			inh(ref uint_4, uint_, uint_2, uint_3, 14u, 9, 26u, array);
			inh(ref uint_3, uint_4, uint_, uint_2, 3u, 14, 27u, array);
			inh(ref uint_2, uint_3, uint_4, uint_, 8u, 20, 28u, array);
			inh(ref uint_, uint_2, uint_3, uint_4, 13u, 5, 29u, array);
			inh(ref uint_4, uint_, uint_2, uint_3, 2u, 9, 30u, array);
			inh(ref uint_3, uint_4, uint_, uint_2, 7u, 14, 31u, array);
			inh(ref uint_2, uint_3, uint_4, uint_, 12u, 20, 32u, array);
			OnF(ref uint_, uint_2, uint_3, uint_4, 5u, 4, 33u, array);
			OnF(ref uint_4, uint_, uint_2, uint_3, 8u, 11, 34u, array);
			OnF(ref uint_3, uint_4, uint_, uint_2, 11u, 16, 35u, array);
			OnF(ref uint_2, uint_3, uint_4, uint_, 14u, 23, 36u, array);
			OnF(ref uint_, uint_2, uint_3, uint_4, 1u, 4, 37u, array);
			OnF(ref uint_4, uint_, uint_2, uint_3, 4u, 11, 38u, array);
			OnF(ref uint_3, uint_4, uint_, uint_2, 7u, 16, 39u, array);
			OnF(ref uint_2, uint_3, uint_4, uint_, 10u, 23, 40u, array);
			OnF(ref uint_, uint_2, uint_3, uint_4, 13u, 4, 41u, array);
			OnF(ref uint_4, uint_, uint_2, uint_3, 0u, 11, 42u, array);
			OnF(ref uint_3, uint_4, uint_, uint_2, 3u, 16, 43u, array);
			OnF(ref uint_2, uint_3, uint_4, uint_, 6u, 23, 44u, array);
			OnF(ref uint_, uint_2, uint_3, uint_4, 9u, 4, 45u, array);
			OnF(ref uint_4, uint_, uint_2, uint_3, 12u, 11, 46u, array);
			OnF(ref uint_3, uint_4, uint_, uint_2, 15u, 16, 47u, array);
			OnF(ref uint_2, uint_3, uint_4, uint_, 2u, 23, 48u, array);
			bnT(ref uint_, uint_2, uint_3, uint_4, 0u, 6, 49u, array);
			bnT(ref uint_4, uint_, uint_2, uint_3, 7u, 10, 50u, array);
			bnT(ref uint_3, uint_4, uint_, uint_2, 14u, 15, 51u, array);
			bnT(ref uint_2, uint_3, uint_4, uint_, 5u, 21, 52u, array);
			bnT(ref uint_, uint_2, uint_3, uint_4, 12u, 6, 53u, array);
			bnT(ref uint_4, uint_, uint_2, uint_3, 3u, 10, 54u, array);
			bnT(ref uint_3, uint_4, uint_, uint_2, 10u, 15, 55u, array);
			bnT(ref uint_2, uint_3, uint_4, uint_, 1u, 21, 56u, array);
			bnT(ref uint_, uint_2, uint_3, uint_4, 8u, 6, 57u, array);
			bnT(ref uint_4, uint_, uint_2, uint_3, 15u, 10, 58u, array);
			bnT(ref uint_3, uint_4, uint_, uint_2, 6u, 15, 59u, array);
			bnT(ref uint_2, uint_3, uint_4, uint_, 13u, 21, 60u, array);
			bnT(ref uint_, uint_2, uint_3, uint_4, 4u, 6, 61u, array);
			bnT(ref uint_4, uint_, uint_2, uint_3, 11u, 10, 62u, array);
			bnT(ref uint_3, uint_4, uint_, uint_2, 2u, 15, 63u, array);
			bnT(ref uint_2, uint_3, uint_4, uint_, 9u, 21, 64u, array);
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

	private static void zn2(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + znD(uint_0 + ((uint_1 & uint_2) | (~uint_1 & uint_3)) + uint_6[uint_4] + Dn8[uint_5 - 1], ushort_0);
	}

	private static void inh(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + znD(uint_0 + ((uint_1 & uint_3) | (uint_2 & ~uint_3)) + uint_6[uint_4] + Dn8[uint_5 - 1], ushort_0);
	}

	private static void OnF(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + znD(uint_0 + (uint_1 ^ uint_2 ^ uint_3) + uint_6[uint_4] + Dn8[uint_5 - 1], ushort_0);
	}

	private static void bnT(ref uint uint_0, uint uint_1, uint uint_2, uint uint_3, uint uint_4, ushort ushort_0, uint uint_5, uint[] uint_6)
	{
		uint_0 = uint_1 + rss(uint_0 + (uint_2 ^ (uint_1 | ~uint_3)) + uint_6[uint_4] + Dn8[uint_5 - 1], ushort_0);
	}

	private static uint znD(uint uint_0, ushort ushort_0)
	{
		return (uint_0 >> 32 - ushort_0) | (uint_0 << (int)ushort_0);
	}

	internal static bool Gna()
	{
		if (!cnR)
		{
			Gsg();
			cnR = true;
		}
		return pns;
	}

	internal static SymmetricAlgorithm yng()
	{
		SymmetricAlgorithm symmetricAlgorithm = null;
		if (Gna())
		{
			return new AesCryptoServiceProvider();
		}
		try
		{
			return new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)VsL(Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider"));
		}
	}

	internal static void AnZ()
	{
		try
		{
			pns = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	internal static byte[] qnX(byte[] byte_0)
	{
		if (!Gna())
		{
			return new MD5CryptoServiceProvider().ComputeHash(byte_0);
		}
		return YnL(byte_0);
	}

	internal static void Cn0(HashAlgorithm hashAlgorithm_0, Stream stream_0, uint uint_0, byte[] byte_0)
	{
		while (uint_0 != 0)
		{
			int num = ((uint_0 > (uint)byte_0.Length) ? byte_0.Length : ((int)uint_0));
			vsC(stream_0, byte_0, 0, num);
			Snd(hashAlgorithm_0, byte_0, 0, num);
			uint_0 -= (uint)num;
		}
	}

	internal static void Snd(HashAlgorithm hashAlgorithm_0, byte[] byte_0, int int_0, int int_1)
	{
		hashAlgorithm_0.TransformBlock(byte_0, int_0, int_1, byte_0, int_0);
	}

	internal static uint kn7(uint uint_0, int int_0, long long_0, BinaryReader binaryReader_0)
	{
		int num = 0;
		uint num3;
		uint num4;
		while (true)
		{
			if (num < int_0)
			{
				csT(binaryReader_0.BaseStream, long_0 + (num * 40 + 8));
				uint num2 = binaryReader_0.ReadUInt32();
				num3 = ps4(binaryReader_0);
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

	public static void pnE(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		try
		{
			Type typeFromHandle = Type.GetTypeFromHandle(runtimeTypeHandle_0);
			if (yP5 == null)
			{
				lock (OPc)
				{
					Dictionary<int, int> dictionary = new Dictionary<int, int>();
					BinaryReader binaryReader = new BinaryReader(typeof(Kg).Assembly.GetManifestResourceStream("ArhtZ5khI492f839Ti.0yxTgVJmsgfpXRlRxN"));
					csT(Rsv(binaryReader), 0L);
					byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
					kse(binaryReader);
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
							num10 += 4091627251u;
							num10 ^= num10 >> 3;
							num10 += 2727350383u;
							num10 ^= num10 << 4;
							num10 += 3169346433u;
							num10 = 2074024291 - num10;
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
						Wv wv = new Wv(new MemoryStream(array));
						for (int l = 0; l < num13; l++)
						{
							int key = wv.AP3();
							int value = wv.AP3();
							dictionary.Add(key, value);
						}
						wv.pPj();
					}
					yP5 = dictionary;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
			foreach (FieldInfo fieldInfo in fields)
			{
				int key2 = JsS(fieldInfo);
				int num14 = yP5[key2];
				bool flag = (num14 & 0x40000000) > 0;
				num14 &= 0x3FFFFFFF;
				MethodInfo methodInfo = (MethodInfo)Ns9(typeof(Kg).TypeHandle).Module.ResolveMethod(num14, typeFromHandle.GetGenericArguments(), new Type[0]);
				if (methodInfo.IsStatic)
				{
					fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
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
						iLGenerator.Emit(OpCodes.Ldarg_3);
						break;
					}
				}
				iLGenerator.Emit(OpCodes.Tailcall);
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
				iLGenerator.Emit(OpCodes.Ret);
				isD(fieldInfo, null, dynamicMethod.CreateDelegate(typeFromHandle));
			}
		}
		catch (Exception)
		{
		}
	}

	private static uint qnS(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11111}".Length;
	}

	private static uint Qny(uint uint_0)
	{
		return (uint)"{11111-22222-10009-11112}".Length;
	}

	internal static void wnW()
	{
	}

	[zX(typeof(zX.q0<object>[]))]
	internal static string WnG(string string_0)
	{
		"{11111-22222-50001-00000}".Trim();
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	private static int Nn1()
	{
		return 5;
	}

	private static void zno()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	private static Delegate rnN(IntPtr intptr_0, Type type_0)
	{
		return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
		{
			typeof(IntPtr),
			Ns9(typeof(Type).TypeHandle)
		})!.Invoke(null, new object[2] { intptr_0, type_0 });
	}

	internal static object cnu(object object_0)
	{
		try
		{
			if (File.Exists((string?)gsV((Assembly)object_0)))
			{
				return ((Assembly)object_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (bsu(((Assembly)object_0).GetName().CodeBase!.ToString().Replace("file:///", "")))
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
				return Bs7(object_0.GetType().GetProperty("Location"), object_0, new object[0]).ToString();
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

	private static IntPtr Pn3(IntPtr intptr_0, string string_0, uint uint_0)
	{
		if (iPE == null)
		{
			IntPtr procAddress = GetProcAddress(psE(), (string?)FsU("Find ") + "ResourceA");
			iPE = (SW)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(SW));
		}
		return iPE(intptr_0, string_0, uint_0);
	}

	private static IntPtr znj(IntPtr intptr_0, uint uint_0, uint uint_1, uint uint_2)
	{
		if (UPS == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Virtual ".Trim() + "Alloc");
			UPS = (HG)Marshal.GetDelegateForFunctionPointer(procAddress, Ns9(typeof(HG).TypeHandle));
		}
		return UPS(intptr_0, uint_0, uint_1, uint_2);
	}

	private static int mnA(IntPtr intptr_0, IntPtr intptr_1, [In][Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2)
	{
		if (lPy == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Write ".Trim() + (string?)FsU("Process ") + "Memory");
			lPy = (z1)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(z1));
		}
		return lPy(intptr_0, intptr_1, byte_0, uint_0, out intptr_2);
	}

	private static int On4(IntPtr intptr_0, int int_0, int int_1, ref int int_2)
	{
		if (OPv == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), (string?)FsU("Virtual ") + "Protect");
			OPv = (Ko)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(Ko));
		}
		return OPv(intptr_0, int_0, int_1, ref int_2);
	}

	private static IntPtr znM(uint uint_0, int int_0, uint uint_1)
	{
		if (uPW == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), (string)Ws2(FsU("Open "), "Process"));
			uPW = (SN)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(SN));
		}
		return uPW(uint_0, int_0, uint_1);
	}

	private static int inm(IntPtr intptr_0)
	{
		if (WPG == null)
		{
			IntPtr procAddress = GetProcAddress(umLocehuEC(), "Close ".Trim() + "Handle");
			WPG = (cu)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(cu));
		}
		return Vsy(WPG, intptr_0);
	}

	[SpecialName]
	private static IntPtr umLocehuEC()
	{
		if (xP1 == IntPtr.Zero)
		{
			xP1 = LoadLibrary("kernel ".Trim() + "32.dll");
		}
		return xP1;
	}

	[zX(typeof(zX.q0<object>[]))]
	private static byte[] CnQ(string string_0)
	{
		FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.Read);
		try
		{
			int num = 0;
			long num2 = YsG(fileStream);
			int num3 = (int)num2;
			byte[] array = new byte[num3];
			while (num3 > 0)
			{
				int num4 = fileStream.Read(array, num, num3);
				num += num4;
				num3 -= num4;
			}
			return array;
		}
		finally
		{
			if (fileStream != null)
			{
				QsI(fileStream);
			}
		}
	}

	internal static Stream Wnt()
	{
		return new MemoryStream();
	}

	internal static byte[] XnC(Stream stream_0)
	{
		return ((MemoryStream)stream_0).ToArray();
	}

	[zX(typeof(zX.q0<object>[]))]
	private static byte[] BnJ(byte[] byte_0)
	{
		Stream stream = Wnt();
		SymmetricAlgorithm symmetricAlgorithm = yng();
		byte[] array = new byte[32];
		bz(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		gsM(symmetricAlgorithm, array);
		byte[] array2 = new byte[16];
		bz(array2, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		symmetricAlgorithm.IV = array2;
		CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		byte[] result = XnC(stream);
		wO.JdPcGz();
		return result;
	}

	private byte[] Xnb()
	{
		string text = "{11111-22222-10001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] Kn9()
	{
		string text = "{11111-22222-10001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] wnK()
	{
		string text = "{11111-22222-20001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] qnY()
	{
		string object_ = "{11111-22222-20001-00002}";
		if (FsA(object_) > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] Ynk()
	{
		string text = "{11111-22222-30001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	private byte[] Rnp()
	{
		string text = "{11111-22222-30001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] pnB()
	{
		string text = "{11111-22222-40001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] zni()
	{
		string text = "{11111-22222-40001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] Tne()
	{
		string text = "{11111-22222-50001-00001}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal byte[] dnr()
	{
		string text = "{11111-22222-50001-00002}";
		if (text.Length > 0)
		{
			return new byte[2] { 1, 2 };
		}
		return new byte[2] { 1, 2 };
	}

	internal static void bz(object object_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray((Array)object_0, runtimeFieldHandle_0);
	}

	internal static void Ssx(bool bool_0)
	{
		RSACryptoServiceProvider.UseMachineKeyStore = bool_0;
	}

	internal static uint rss(uint uint_0, ushort ushort_0)
	{
		return znD(uint_0, ushort_0);
	}

	internal static void Gsg()
	{
		AnZ();
	}

	internal static object VsL(object object_0)
	{
		return ((ObjectHandle)object_0).Unwrap();
	}

	internal static int vsC(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Stream)object_0).Read((byte[])object_1, int_0, int_1);
	}

	internal static void csT(object object_0, long long_0)
	{
		((Stream)object_0).Position = long_0;
	}

	internal static uint ps4(object object_0)
	{
		return ((BinaryReader)object_0).ReadUInt32();
	}

	internal static object Rsv(object object_0)
	{
		return ((BinaryReader)object_0).BaseStream;
	}

	internal static void kse(object object_0)
	{
		((BinaryReader)object_0).Close();
	}

	internal static int JsS(object object_0)
	{
		return ((MemberInfo)object_0).MetadataToken;
	}

	internal static Type Ns9(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void isD(object object_0, object object_1, object object_2)
	{
		((FieldInfo)object_0).SetValue(object_1, object_2);
	}

	internal static object gsV(object object_0)
	{
		return ((Assembly)object_0).Location;
	}

	internal static bool bsu(object object_0)
	{
		return File.Exists((string?)object_0);
	}

	internal static object Bs7(object object_0, object object_1, object object_2)
	{
		return ((PropertyInfo)object_0).GetValue(object_1, (object?[]?)object_2);
	}

	internal static IntPtr psE()
	{
		return umLocehuEC();
	}

	internal static object FsU(object object_0)
	{
		return ((string)object_0).Trim();
	}

	internal static object Ws2(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static int Vsy(object object_0, IntPtr ptr)
	{
		return object_0(ptr);
	}

	internal static long YsG(object object_0)
	{
		return ((Stream)object_0).Length;
	}

	internal static void QsI(object object_0)
	{
		((IDisposable)object_0).Dispose();
	}

	internal static void gsM(object object_0, object object_1)
	{
		((SymmetricAlgorithm)object_0).Key = (byte[])object_1;
	}

	internal static int FsA(object object_0)
	{
		return ((string)object_0).Length;
	}
}
