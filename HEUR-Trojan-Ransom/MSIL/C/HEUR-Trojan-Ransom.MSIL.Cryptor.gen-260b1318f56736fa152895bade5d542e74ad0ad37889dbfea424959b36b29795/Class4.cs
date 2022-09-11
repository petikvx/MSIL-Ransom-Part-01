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

	private static byte[] byte_0;

	private static short short_0;

	private static Enum0 enum0_0;

	private static Dictionary<int, string> dictionary_0;

	private static int int_0;

	private static Class5 class5_0;

	private static byte[] byte_1;

	private static int int_1;

	private static int int_2;

	static Class4()
	{
		int num = -1602424573;
		int num2 = -1432987124;
		dictionary_0 = new Dictionary<int, string>(108);
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
		int num4 = -(~(-(~(~(-(-(~(~((176828258 - num) ^ num2))))))))) ^ -(~(~(-(~(-(~(-(~((num ^ -489441010) + num2)))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num4 ^= -(~(~(-(~(-(~(-(~((num + -1487489810) ^ num2)))))))));
		}
		Type type = methodBase?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			num4 ^= (0xAEAAC30 ^ num) - num2 + num3;
			enum0_0 = (Enum0)4 | enum0_0;
		}
		else if ((object)type == null)
		{
			if (smethod_4(stackTrace, int_))
			{
				enum0_0 |= (Enum0)16;
				num4 ^= -(~(~(-(~(-(~(-(~(num + -1259579638 + num2))))))))) - num3;
			}
			else
			{
				enum0_0 = (Enum0)1 | enum0_0;
				num4 ^= -(~(-(~(-(~(~(-(~(1259518554 - num - num2)))))))));
			}
		}
		else
		{
			num4 ^= ~(-(~(-(~(-(-(~(~(-(~((-183125745 ^ num) + num2))))))))))) - num3;
			enum0_0 |= (Enum0)16;
		}
		int_0 = num4 + int_0;
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
		int num = 979343268;
		int num2 = -1283349616;
		string value = null;
		byte[] array;
		int num17;
		while (true)
		{
			int num3;
			if (class5_0 != null)
			{
				num3 = int_1;
			}
			else
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Assembly callingAssembly = Assembly.GetCallingAssembly();
				int_2 |= (0x76C97956 ^ num) + num2;
				StringBuilder stringBuilder = new StringBuilder();
				int num4 = (-840295618 - num) ^ num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = num + 841213143 + num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = (num ^ -371895242) - num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = (-840885452 - num) ^ num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = num + 841409746 + num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
				int num5 = 2;
				StackTrace stackTrace = new StackTrace(2, fNeedFileInfo: false);
				int_2 ^= ((-304000390 - num) ^ num2) | 2;
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
				int_2 ^= num5 + (num + 304006476 + num2);
				Type type = methodBase?.DeclaringType;
				if (frame == null)
				{
					int_2 ^= -303787033 - num - num2;
				}
				bool flag = (object)type == typeof(RuntimeMethodHandle);
				int_2 ^= -1981926252 ^ num ^ num2;
				if (!flag && (flag = (object)type == null))
				{
					if (smethod_4(stackTrace, int_4))
					{
						flag = false;
					}
					else
					{
						int_2 ^= -303787065 - num - num2;
					}
				}
				if (flag == (stackTrace != null))
				{
					int_2 = 0x20 ^ int_2;
				}
				int_2 ^= ((num ^ 0x7621E272) + num2) | (1 + num5);
				class5_0 = new Class5(manifestResourceStream);
				short num6 = (short)(class5_0.method_1() ^ (short)(-(~(~(-(~(-(~(-(-(~(~(-304034973 - num - num2)))))))))))));
				if (num6 == 0)
				{
					short_0 = (short)(class5_0.method_1() ^ (short)(~(-(-(~(~(-(-(~(-(~(~((num + 303986980) ^ num2)))))))))))));
				}
				else
				{
					byte_1 = class5_0.method_6(num6);
				}
				callingAssembly = executingAssembly;
				AssemblyName assemblyName_ = smethod_2(callingAssembly);
				byte_0 = smethod_3(assemblyName_);
				num3 = int_0;
				int_0 = 0;
				long num7 = Class10.smethod_0();
				num3 ^= (int)num7;
				num3 ^= (num ^ -2054423437) + num2;
				int num8 = num3;
				int num9 = num8;
				int num10 = (2032274497 + num) ^ num2;
				int num11 = num9 * (-304001055 - num - num2) % ((num ^ 0x747A3DF9) + num2);
				int num12 = (-1070443744 - num + num2 + num11) ^ ((-827031199 ^ num) - num2);
				int int_5 = num12;
				Interface4<int> enumerator = ((Interface1<int>)new Class0.Class3((-2032274414 - num) | num2)
				{
					int_4 = int_5
				}).GetEnumerator();
				try
				{
					while (enumerator.imethod_1())
					{
						int num13 = enumerator.imethod_3();
						num12 ^= num13 - num10;
						num10 -= 3 + num12 >> 8;
					}
				}
				finally
				{
					((Interface2)enumerator)?.imethod_0();
				}
				num3 ^= ((2032907006 + num) ^ num2) + -(~(~(-(~(-(~(-(~(-2032274721 - num + num2)))))))));
				int num14 = num12;
				num3 ^= ~(-(-(~(-(~(~(-(~(-(~(-517759996 + num - num2)))))))))));
				num3 = num14 + num3;
				int_2 = (int_2 & ((num ^ 0x6621CC46) + num2)) ^ ((-304000840 - num) ^ num2);
				int_1 = num3;
				if (((uint)enum0_0 & (uint)(-(~(~(-(~(-(~(-(~(-(~(num + 304006328 + num2))))))))))))) == 0)
				{
					int_2 = (-304046130 - num) ^ num2;
				}
			}
			if (int_2 != num + 304050310 + num2)
			{
				int num15 = int_3 ^ (808559518 - num - num2) ^ num3;
				num15 ^= 1812147691 + num + num2;
				class5_0.method_0().Position = num15;
				if (byte_1 != null)
				{
					array = byte_1;
				}
				else
				{
					short num16 = ((short_0 != -1) ? short_0 : ((short)(class5_0.method_1() ^ ((-1981908788 ^ num) - num2) ^ num15)));
					if (num16 == 0)
					{
						array = null;
					}
					else
					{
						array = class5_0.method_6(num16);
						for (int i = 0; i != array.Length; i++)
						{
							array[i] ^= (byte)(int_1 >> ((i & 3) << 3));
						}
					}
				}
				num17 = class5_0.method_2() ^ num15 ^ -(~(-(~(-(~(~(-(-(~(~(num + 1808306534 + num2))))))))))) ^ num3;
				if (num17 != ((num ^ 0x7621CBCA) | num2))
				{
					break;
				}
				byte[] array2 = class5_0.method_6(4);
				int_3 = (-612894380 + num) ^ num2 ^ num3;
				int_3 = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -int_3;
				if (dictionary_0.TryGetValue(int_3, out value))
				{
					return value;
				}
				continue;
			}
			return new string(new char[3]
			{
				(char)((-304006292 - num) ^ num2),
				'0',
				(char)((num ^ 0x7621CB6C) + num2)
			});
		}
		bool flag2 = (num17 & ((-1239299116 ^ num) + num2)) != 0;
		bool flag3 = (num17 & ((-840877260 - num) ^ num2)) != 0;
		bool flag4 = (num17 & (num + -115209236 - num2)) != 0;
		num17 &= -1763838957 - num + num2;
		byte[] array3 = array;
		byte[] array4 = class5_0.method_6(num17);
		byte[] array5 = array3;
		byte b = array5[1];
		int num18 = array4.Length;
		byte b2 = (byte)((11 + num18) ^ (7 + b));
		uint num19 = (uint)((array5[0] | (array5[2] << 8)) + (b2 << 3));
		int num20 = 0;
		ushort num21 = 0;
		while (num20 < num18)
		{
			if ((num20 & 1) == 0)
			{
				num19 = (uint)((int)num19 * (num ^ -1981974583 ^ num2) + (-2029743401 - num + num2));
				num21 = (ushort)(num19 >> 16);
			}
			byte b3 = (byte)num21;
			num21 = (ushort)(num21 >> 8);
			byte b4 = array4[num20];
			array4[num20] = (byte)(b4 ^ b ^ (b2 + 3) ^ b3);
			num20 = 1 + num20;
			b2 = b4;
		}
		byte[] array6 = array4;
		if (byte_0 != null != (int_2 != ((2033816434 + num) ^ num2)))
		{
			for (int num22 = 0; num22 < num17; num22 = 1 + num22)
			{
				byte b5 = byte_0[num22 & 7];
				b5 = (byte)((b5 << 3) | (b5 >> 5));
				array6[num22] = (byte)(array6[num22] ^ b5);
			}
		}
		int num23 = int_2 - 12;
		int num24;
		byte[] array7;
		if (!flag3)
		{
			num24 = num17;
			array7 = array6;
		}
		else
		{
			num24 = array6[2] | (array6[0] << 16) | (array6[3] << 8) | (array6[1] << 24);
			array7 = new byte[num24];
			smethod_5(array6, 4, array7);
		}
		if (flag2 && num23 == -2030666610 - num + num2)
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
		num23 += ((num + 2032274507) ^ num2) + (num23 & 3) << 5;
		if (num23 != (0x76C962AE ^ num) + num2)
		{
			int num25 = (num17 + int_3) ^ (2033210980 + num - num2) ^ (num23 & ((num ^ 0x7621F6D9) + num2));
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = -304006260 - num - num2;
			stringBuilder.Append((char)(byte)num4);
			value = num25.ToString(stringBuilder.ToString());
		}
		if (!flag4 && bool_0)
		{
			value = string.Intern(value);
			dictionary_0[int_3] = value;
			if (dictionary_0.Count == 304006456 + num + num2)
			{
				class5_0.method_5();
				class5_0 = null;
				byte_1 = null;
				byte_0 = null;
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
