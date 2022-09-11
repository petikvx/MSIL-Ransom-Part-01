using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

internal static class Class4
{
	private enum Enum0
	{

	}

	private sealed class Class5
	{
		private Stream stream_0;

		private byte[] byte_0;

		public Class5(Stream stream_1)
		{
			stream_0 = stream_1;
			byte_0 = new byte[4];
		}

		public Stream method_0()
		{
			return stream_0;
		}

		public short method_1()
		{
			method_4(2);
			return (short)(byte_0[0] | (byte_0[1] << 8));
		}

		public int method_2()
		{
			method_4(4);
			return byte_0[0] | (byte_0[1] << 8) | (byte_0[2] << 16) | (byte_0[3] << 24);
		}

		private void method_3()
		{
			throw new EndOfStreamException();
		}

		private void method_4(int int_0)
		{
			int num = 0;
			int num2 = 0;
			if (int_0 == 1)
			{
				num2 = stream_0.ReadByte();
				if (num2 == -1)
				{
					method_3();
				}
				byte_0[0] = (byte)num2;
				return;
			}
			do
			{
				num2 = stream_0.Read(byte_0, num, int_0 - num);
				if (num2 == 0)
				{
					method_3();
				}
				num += num2;
			}
			while (num < int_0);
		}

		public void method_5()
		{
			Stream stream = stream_0;
			stream_0 = null;
			stream?.Close();
			byte_0 = null;
		}

		public byte[] method_6(int int_0)
		{
			if (int_0 < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[int_0];
			int num = 0;
			do
			{
				int num2 = stream_0.Read(array, num, int_0);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				int_0 -= num2;
			}
			while (int_0 > 0);
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				array = array2;
			}
			return array;
		}
	}

	private static Dictionary<int, string> dictionary_0;

	private static byte[] byte_0;

	private static Enum0 enum0_0;

	private static short short_0;

	private static int int_0;

	private static byte[] byte_1;

	private static int int_1;

	private static Class5 class5_0;

	private static int int_2;

	static Class4()
	{
		int num = 411681087;
		int num2 = 575388268;
		dictionary_0 = new Dictionary<int, string>(150);
		int num3 = 2;
		StackTrace stackTrace = new StackTrace(2, fNeedFileInfo: false);
		num3 = 0;
		StackFrame frame = stackTrace.GetFrame(0);
		int int_ = 0;
		if (frame == null)
		{
			stackTrace = new StackTrace();
			int_ = 1;
			frame = stackTrace.GetFrame(1);
		}
		int num4 = -(~(~(-(-(~(~(-(~(-(~((num ^ 0x2CBB63CC) + num2))))))))))) ^ -(~(-(~(~(-(-(~(~((num + -1232840910) ^ num2)))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num4 ^= -(~(~(-(~(-(~(-(~(672889768 - num - num2)))))))));
		}
		Type type = methodBase?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			enum0_0 = (Enum0)4 | enum0_0;
			num4 ^= ((163706892 + num) ^ num2) + num3;
		}
		else if ((object)type == null)
		{
			if (smethod_4(stackTrace, int_))
			{
				num4 ^= -(~(~(-(~(-(-(~(-(~(~(-163731217 - num + num2))))))))))) - num3;
				enum0_0 |= (Enum0)16;
			}
			else
			{
				enum0_0 |= (Enum0)1;
				num4 ^= -(~(~(-(~(-(~(-(~((num + -987032596) ^ num2)))))))));
			}
		}
		else
		{
			num4 ^= -(~(~(-(-(~(~(-(-(~(~((num ^ -986044785) + num2))))))))))) - num3;
			enum0_0 |= (Enum0)16;
		}
		int_1 = num4 + int_1;
	}

	internal static string smethod_0(int int_3)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.TryGetValue(int_3, out var value))
			{
				return value;
			}
			return smethod_1(int_3, bool_0: true);
		}
	}

	private static string smethod_1(int int_3, bool bool_0)
	{
		int num = 727668721;
		int num2 = 31122634;
		string value = null;
		byte[] array;
		int num18;
		while (true)
		{
			int num3;
			if (class5_0 != null)
			{
				num3 = int_2;
			}
			else
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Assembly callingAssembly = Assembly.GetCallingAssembly();
				int_0 |= num + -694935717 - num2;
				StringBuilder stringBuilder = new StringBuilder();
				int num4 = (1295588537 - num) ^ num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = (0x356F6CCA ^ num) + num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = 1295998146 - num - num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = (0x35776CCD ^ num) + num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = -159077150 + num - num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
				int num5 = 2;
				StackTrace stackTrace = new StackTrace(2, fNeedFileInfo: false);
				int_0 ^= (696552557 - num + num2) | 2;
				num5 = 0;
				StackFrame frame = stackTrace.GetFrame(0);
				int int_4 = 0;
				if (frame == null)
				{
					stackTrace = new StackTrace();
					int_4 = 1;
					frame = stackTrace.GetFrame(1);
				}
				MethodBase methodBase = frame?.GetMethod();
				int_0 ^= num5 + ((0x2A85B2BB ^ num) - num2);
				Type type = methodBase?.DeclaringType;
				if (frame == null)
				{
					int_0 ^= 696765402 - num + num2;
				}
				bool flag = (object)type == typeof(RuntimeMethodHandle);
				int_0 ^= 0x2A85B39B ^ num ^ num2;
				if (!flag && (flag = (object)type == null))
				{
					if (smethod_4(stackTrace, int_4))
					{
						flag = false;
					}
					else
					{
						int_0 ^= num + -696326804 - num2;
					}
				}
				if (flag == (stackTrace != null))
				{
					int_0 ^= 32;
				}
				int_0 ^= (696552589 - num + num2) | (num5 + 1);
				class5_0 = new Class5(manifestResourceStream);
				short num6 = (short)(class5_0.method_1() ^ (short)(~(-(-(~(~(-(~(-(~((num + -696558951) ^ num2)))))))))));
				if (num6 == 0)
				{
					short_0 = (short)(class5_0.method_1() ^ (short)(-(~(-(~(~(-(~(-(-(~(~(758802882 - num - num2)))))))))))));
				}
				else
				{
					byte_0 = class5_0.method_6(num6);
				}
				callingAssembly = executingAssembly;
				AssemblyName assemblyName_ = smethod_2(callingAssembly);
				byte_1 = smethod_3(assemblyName_);
				num3 = int_1;
				int_1 = 0;
				long num7 = Class10.smethod_0();
				num3 ^= (int)num7;
				num3 ^= 479057945 + num + num2;
				int num8 = num3;
				int num9 = num8;
				int num10 = num9 * (num ^ 0x2A85A796 ^ num2) % (724287764 - num + num2);
				int num11 = num ^ 0x2A85B34E ^ num2;
				int num12 = (1720622023 - num - num2 + num10) ^ (num ^ 0x6BECC00E ^ num2);
				int int_5 = num12;
				Interface4<int> enumerator = ((Interface1<int>)new Class0.Class3((696546085 - num) | num2)
				{
					int_4 = int_5
				}).GetEnumerator();
				try
				{
					while (enumerator.imethod_1())
					{
						int num13 = enumerator.imethod_3();
						num12 ^= num13 - num11;
						num11 -= num12 + 3 >> 8;
					}
				}
				finally
				{
					((Interface2)enumerator)?.imethod_0();
				}
				int num14 = num12;
				num3 ^= ~(-(~(-(-(~(~(-(~((num ^ -494188014) + num2)))))))));
				num3 = (int_2 = num3 + num14);
				int_0 = (int_0 & (-428110773 + num - num2)) ^ (num ^ 0x2A85A9BF ^ num2);
				if (((uint)enum0_0 & (uint)(-(~(-(~(~(-(~(-(~(-(~((num + -758791373) | num2))))))))))))) == 0)
				{
					int_0 = 696590049 - num + num2;
				}
			}
			if (int_0 != (num ^ 0x2A851881 ^ num2))
			{
				int num15 = int_3 ^ (0x61FBE436 ^ num ^ num2) ^ num3;
				num15 ^= 811595256 + num - num2;
				class5_0.method_0().Position = num15;
				if (byte_0 != null)
				{
					array = byte_0;
				}
				else
				{
					short num16 = ((short_0 != -1) ? short_0 : ((short)(class5_0.method_1() ^ ((num ^ -713318310) + num2) ^ num15)));
					if (num16 == 0)
					{
						array = null;
					}
					else
					{
						array = class5_0.method_6(num16);
						for (int num17 = 0; num17 != array.Length; num17 = 1 + num17)
						{
							array[num17] ^= (byte)(int_2 >> ((3 & num17) << 3));
						}
					}
				}
				num18 = class5_0.method_2() ^ num15 ^ -(~(-(~(~(-(-(~(~((-695148704 - num) ^ num2))))))))) ^ num3;
				if (num18 != ((num + -758791357) | num2))
				{
					break;
				}
				byte[] array2 = class5_0.method_6(4);
				int_3 = (-2108761833 - num - num2) ^ num3;
				int_3 = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -int_3;
				if (dictionary_0.TryGetValue(int_3, out value))
				{
					return value;
				}
				continue;
			}
			return new string(new char[3]
			{
				(char)(num + -696545999 - num2),
				'0',
				(char)(696546175 - num + num2)
			});
		}
		bool flag2 = (num18 & (num ^ 0x6A85B33B ^ num2)) != 0;
		bool flag3 = (num18 & (-221920443 + num + num2)) != 0;
		bool flag4 = (num18 & (num ^ -1434078405 ^ num2)) != 0;
		num18 &= (-490355900 + num) | num2;
		byte[] array3 = array;
		byte[] array4 = class5_0.method_6(num18);
		byte[] array5 = array3;
		byte b = array5[1];
		int num19 = array4.Length;
		byte b2 = (byte)((num19 + 11) ^ (b + 7));
		uint num20 = (uint)((array5[0] | (array5[2] << 8)) + (b2 << 3));
		int i = 0;
		ushort num21 = 0;
		for (; i < num19; i++)
		{
			if ((1 & i) == 0)
			{
				num20 = (uint)((int)num20 * ((-713619262 ^ num) + num2) + (num + -694015076 - num2));
				num21 = (ushort)(num20 >> 16);
			}
			byte b3 = (byte)num21;
			num21 = (ushort)(num21 >> 8);
			byte b4 = array4[i];
			array4[i] = (byte)(b4 ^ b ^ (3 + b2) ^ b3);
			b2 = b4;
		}
		byte[] array6 = array4;
		if (byte_1 != null != (int_0 != (num ^ 0x2A9D3BBD ^ num2)))
		{
			for (int num22 = 0; num22 < num18; num22 = 1 + num22)
			{
				byte b5 = byte_1[7 & num22];
				b5 = (byte)((b5 << 3) | (b5 >> 5));
				array6[num22] = (byte)(array6[num22] ^ b5);
			}
		}
		int num23 = int_0 - 12;
		byte[] array7;
		int num24;
		if (!flag3)
		{
			array7 = array6;
			num24 = num18;
		}
		else
		{
			num24 = array6[2] | (array6[0] << 16) | (array6[3] << 8) | (array6[1] << 24);
			array7 = new byte[num24];
			smethod_5(array6, 4, array7);
		}
		if (flag2 && num23 == -694938285 + num - num2)
		{
			char[] array8 = new char[num24];
			for (int j = 0; j < num24; j++)
			{
				array8[j] = (char)array7[j];
			}
			value = new string(array8);
		}
		else
		{
			value = Encoding.Unicode.GetString(array7, 0, array7.Length);
		}
		num23 += (-713405372 ^ num) + num2 + (3 & num23) << 5;
		if (num23 != num + -694934157 - num2)
		{
			int num25 = (int_3 + num18) ^ (num ^ 0x2A8BF943 ^ num2) ^ (num23 & (696547380 - num + num2));
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = 0x2A85B363 ^ num ^ num2;
			stringBuilder.Append((char)(byte)num4);
			value = num25.ToString(stringBuilder.ToString());
		}
		if (!flag4 && bool_0)
		{
			value = string.Intern(value);
			dictionary_0[int_3] = value;
			if (dictionary_0.Count == -758791205 + num + num2)
			{
				class5_0.method_5();
				class5_0 = null;
				byte_0 = null;
				byte_1 = null;
			}
		}
		return value;
	}

	private static AssemblyName smethod_2(Assembly assembly_0)
	{
		try
		{
			return assembly_0.GetName();
		}
		catch
		{
			return new AssemblyName(assembly_0.FullName);
		}
	}

	private static byte[] smethod_3(AssemblyName assemblyName_0)
	{
		byte[] array = assemblyName_0.GetPublicKeyToken();
		if (array != null && array.Length == 0)
		{
			array = null;
		}
		return array;
	}

	private static bool smethod_4(StackTrace stackTrace_0, int int_3)
	{
		Assembly assembly = stackTrace_0.GetFrame(int_3 + 1)?.GetMethod()?.DeclaringType?.Assembly;
		if ((object)assembly != null)
		{
			AssemblyName assemblyName_ = smethod_2(assembly);
			byte[] array = smethod_3(assemblyName_);
			if (array != null && array.Length == 8 && array[0] == 183 && array[7] == 137)
			{
				return true;
			}
		}
		return false;
	}

	private static void smethod_5(byte[] byte_2, int int_3, byte[] byte_3)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 128;
		int num4 = byte_3.Length;
		while (num < num4)
		{
			if ((num3 <<= 1) == 256)
			{
				num3 = 1;
				num2 = byte_2[int_3++];
			}
			if ((num2 & num3) != 0)
			{
				int num5 = (byte_2[int_3] >> 2) + 3;
				int num6 = ((byte_2[int_3] << 8) | byte_2[int_3 + 1]) & 0x3FF;
				int_3 += 2;
				int num7 = num - num6;
				if (num7 < 0)
				{
					break;
				}
				while (--num5 >= 0 && num < num4)
				{
					byte_3[num++] = byte_3[num7++];
				}
			}
			else
			{
				byte_3[num++] = byte_2[int_3++];
			}
		}
	}
}
