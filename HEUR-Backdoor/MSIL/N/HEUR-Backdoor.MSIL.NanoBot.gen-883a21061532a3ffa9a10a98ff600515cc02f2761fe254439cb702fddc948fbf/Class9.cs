using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

internal static class Class9
{
	private enum Enum0
	{

	}

	private sealed class Class10
	{
		private Stream stream_0;

		private byte[] byte_0;

		public Class10(Stream stream_1)
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

	internal sealed class Class11
	{
		private struct Struct0
		{
			public int int_0;

			public string string_0;
		}

		private Struct0[] struct0_0;

		private int int_0;

		public Class11()
		{
			struct0_0 = new Struct0[16];
		}

		public Class11(int int_1)
		{
			int num = 16;
			int_1 <<= 1;
			while (num < int_1 && num > 0)
			{
				num <<= 1;
			}
			if (num < 0)
			{
				num = 16;
			}
			struct0_0 = new Struct0[num];
		}

		public int method_0()
		{
			return int_0;
		}

		private void method_1()
		{
			Struct0[] array = struct0_0;
			int num = array.Length;
			int num2 = num * 2;
			if (num2 <= 0)
			{
				return;
			}
			Struct0[] array2 = new Struct0[num2];
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				string string_ = array[i].string_0;
				if (string_ == null)
				{
					continue;
				}
				int num4 = array[i].int_0;
				int num5 = num4 & (num2 - 1);
				while (array2[num5].string_0 != null)
				{
					num5++;
					if (num5 >= num2)
					{
						num5 = 0;
					}
				}
				array2[num5].string_0 = string_;
				array2[num5].int_0 = num4;
				num3++;
			}
			struct0_0 = array2;
			int_0 = num3;
		}

		public string method_2(int int_1)
		{
			Struct0[] array = struct0_0;
			int num = array.Length;
			int num2 = int_1 & (num - 1);
			string result = null;
			while (true)
			{
				if (array[num2].int_0 != int_1)
				{
					if (array[num2].string_0 == null)
					{
						break;
					}
					num2++;
					if (num2 >= num)
					{
						num2 = 0;
					}
					continue;
				}
				result = array[num2].string_0;
				break;
			}
			return result;
		}

		public void method_3(int int_1, string string_0)
		{
			Struct0[] array = struct0_0;
			int num = array.Length;
			int num2 = num >> 1;
			int num3 = int_1 & (num - 1);
			bool flag;
			while (true)
			{
				int num4 = array[num3].int_0;
				flag = array[num3].string_0 == null;
				if (num4 == int_1 || flag)
				{
					break;
				}
				num3++;
				if (num3 >= num)
				{
					num3 = 0;
				}
			}
			array[num3].string_0 = string_0;
			if (flag)
			{
				array[num3].int_0 = int_1;
				int_0++;
				if (int_0 > num2)
				{
					method_1();
				}
			}
		}
	}

	private static Class10 class10_0;

	private static byte[] byte_0;

	private static int int_0;

	private static int int_1;

	private static Enum0 enum0_0;

	private static byte[] byte_1;

	private static Class11 class11_0;

	private static int int_2;

	private static short short_0;

	static Class9()
	{
		int num = -1659457603;
		int num2 = -765633037;
		class11_0 = new Class11(306);
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
		int num4 = ~(-(~(-(-(~(~(-(~((0xD57C5BA ^ num) + num2))))))))) ^ -(~(~(-(~(-(~(-(~((-600854617 - num) ^ num2)))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num4 ^= -(~(~(-(-(~(~(-(~(-(~((-2013393482 ^ num) + num2)))))))))));
		}
		Type type = methodBase?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			enum0_0 |= (Enum0)4;
			num4 ^= ((1869876881 - num) ^ num2) + num3;
		}
		else if ((object)type == null)
		{
			if (smethod_4(stackTrace, int_))
			{
				enum0_0 = (Enum0)16 | enum0_0;
				num4 ^= -(~(~(-(-(~(-(~(~((num ^ -1330320489) + num2))))))))) - num3;
			}
			else
			{
				enum0_0 |= (Enum0)1;
				num4 ^= ~(-(~(-(~(-(-(~(~(-(~((num + -1869905160) ^ num2)))))))))));
			}
		}
		else
		{
			num4 ^= ~(-(-(~(-(~(~(-(~(-(~((num ^ -1330320486) + num2))))))))))) - num3;
			enum0_0 |= (Enum0)16;
		}
		int_2 = num4 + int_2;
	}

	internal static string smethod_0(int int_3)
	{
		lock (class11_0)
		{
			string text = class11_0.method_2(int_3);
			if (text != null)
			{
				return text;
			}
			return smethod_1(int_3, bool_0: true);
		}
	}

	private static string smethod_1(int int_3, bool bool_0)
	{
		int num = 1538733004;
		int num2 = 1418279916;
		string text = null;
		byte[] array;
		int num17;
		while (true)
		{
			int num3;
			if (class10_0 != null)
			{
				num3 = int_0;
			}
			else
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Assembly callingAssembly = Assembly.GetCallingAssembly();
				int_1 |= -118842718 + num - num2;
				StringBuilder stringBuilder = new StringBuilder();
				int num4 = (-800763980 - num) ^ num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = num + 1875554387 + num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = num ^ 0x2F3E2824 ^ num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = -800813127 - num - num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = 0x2F372828 ^ num ^ num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = 657987556 - num + num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = (0xF3E683E ^ num) - num2;
				stringBuilder.Append((char)num4);
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
				int num5 = 2;
				StackTrace stackTrace = new StackTrace(2, fNeedFileInfo: false);
				int_1 ^= (num + 1337960846 + num2) | 2;
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
				int_1 ^= num5 + (num ^ 0xF3E08A0 ^ num2);
				Type type = methodBase?.DeclaringType;
				if (frame == null)
				{
					int_1 ^= 1338173691 + num + num2;
				}
				bool flag = (object)type == typeof(RuntimeMethodHandle);
				int_1 ^= 0xF3E0880 ^ num ^ num2;
				if (!flag && (flag = (object)type == null))
				{
					if (smethod_4(stackTrace, int_4))
					{
						flag = false;
					}
					else
					{
						int_1 ^= num + 1338173659 + num2;
					}
				}
				if (flag == (stackTrace != null))
				{
					int_1 ^= 32;
				}
				int_1 ^= (0xF3E1146 ^ num ^ num2) | (1 + num5);
				class10_0 = new Class10(manifestResourceStream);
				short num6 = (short)(class10_0.method_1() ^ (short)(-(~(~(-(-(~(-(~(~(-(~(num + -120442235 - num2)))))))))))));
				if (num6 == 0)
				{
					short_0 = (short)(class10_0.method_1() ^ (short)(-(~(~(-(~(-(~(-(~(-255722938 ^ num ^ num2)))))))))));
				}
				else
				{
					byte_0 = class10_0.method_6(num6);
				}
				callingAssembly = executingAssembly;
				AssemblyName assemblyName_ = smethod_2(callingAssembly);
				byte_1 = smethod_3(assemblyName_);
				num3 = int_2;
				int_2 = 0;
				num3 ^= -2106083378 - num + num2;
				long num7 = Class21.smethod_0();
				num3 ^= (int)num7;
				num3 ^= (0x2AB862D1 ^ num) - num2;
				num3 ^= 2010311519 - num + num2;
				int num8 = num3;
				int num9 = num8;
				int num10 = 0;
				int int_5 = num9;
				Interface4<int> @interface = ((Interface1<int>)new Class0.Class1((num + 1337954374) | num2)
				{
					int_4 = int_5
				}).imethod_1();
				try
				{
					while (@interface.imethod_2())
					{
						int num11 = @interface.imethod_3();
						num9 ^= num11 + num10;
						num10 += num9 >> 3;
					}
				}
				finally
				{
					((Interface2)@interface)?.imethod_0();
				}
				int num12 = num9;
				int num13 = num12 ^ ((num ^ -1971286297) - num2);
				num3 ^= ~(-(-(~(~(-(~(-(-(~(~((758012736 + num) ^ num2)))))))))));
				int num14 = num13 * (num + 1337959669 + num2) % (-1310212699 - num - num2);
				num3 += num14;
				int_1 = (int_1 & ((num ^ 0x3F3E0892) - num2)) ^ ((-120459876 + num) ^ num2);
				int_0 = num3;
				if (((uint)enum0_0 & (uint)(~(-(-(~(~(-(~(-(~((-255723571 ^ num) | num2))))))))))) == 0)
				{
					int_1 = -1337910414 - num - num2;
				}
			}
			if (int_1 != num + 1337998338 + num2)
			{
				int num15 = int_3 ^ ((-935008612 + num) ^ num2) ^ num3;
				num15 ^= 1985604863 - num + num2;
				class10_0.method_0().Position = num15;
				if (byte_0 != null)
				{
					array = byte_0;
				}
				else
				{
					short num16 = ((short_0 != -1) ? short_0 : ((short)(class10_0.method_1() ^ ((-120438474 + num) ^ num2) ^ num15)));
					if (num16 == 0)
					{
						array = null;
					}
					else
					{
						array = class10_0.method_6(num16);
						for (int i = 0; i != array.Length; i++)
						{
							array[i] ^= (byte)(int_0 >> ((i & 3) << 3));
						}
					}
				}
				num17 = class10_0.method_2() ^ num15 ^ ~(-(-(~(-(~(-(~(~(-(~(-1732126611 - num - num2))))))))))) ^ num3;
				if (num17 != ((-255723554 ^ num) | num2))
				{
					break;
				}
				byte[] array2 = class10_0.method_6(4);
				int_3 = (514625323 - num + num2) ^ num3;
				int_3 = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -int_3;
				text = class11_0.method_2(int_3);
				if (text != null)
				{
					return text;
				}
				continue;
			}
			return new string(new char[3]
			{
				(char)((uint)num ^ 0xF3E0878u ^ (uint)num2),
				'0',
				(char)(-1337954288 - num - num2)
			});
		}
		bool flag2 = (num17 & ((num + 416417824) ^ num2)) != 0;
		bool flag3 = (num17 & ((-1329465384 ^ num) + num2)) != 0;
		bool flag4 = (num17 & ((809529272 - num) ^ num2)) != 0;
		num17 &= (-524159009 ^ num) + num2;
		byte[] array3 = array;
		byte[] array4 = class10_0.method_6(num17);
		byte[] array5 = array3;
		byte b = array5[1];
		int num18 = array4.Length;
		byte b2 = (byte)((11 + num18) ^ (7 + b));
		uint num19 = (uint)((array5[0] | (array5[2] << 8)) + (b2 << 3));
		ushort num20 = 0;
		int num21 = 0;
		while (num21 < num18)
		{
			if ((num21 & 1) == 0)
			{
				num19 = (uint)((int)num19 * (num + -120239075 - num2) + ((-1335437061 - num) ^ num2));
				num20 = (ushort)(num19 >> 16);
			}
			byte b3 = (byte)num20;
			num20 = (ushort)(num20 >> 8);
			byte b4 = array4[num21];
			array4[num21] = (byte)(b ^ b4 ^ (3 + b2) ^ b3);
			num21++;
			b2 = b4;
		}
		byte[] array6 = array4;
		if (byte_1 != null != (int_1 != (num ^ -264732842) + num2))
		{
			for (int j = 0; j < num17; j++)
			{
				byte b5 = byte_1[7 & j];
				b5 = (byte)((b5 << 3) | (b5 >> 5));
				array6[j] = (byte)(array6[j] ^ b5);
			}
		}
		int num22 = int_1 - 12;
		int num23;
		byte[] array7;
		if (!flag3)
		{
			num23 = num17;
			array7 = array6;
		}
		else
		{
			num23 = array6[2] | (array6[0] << 16) | (array6[3] << 8) | (array6[1] << 24);
			array7 = new byte[num23];
			smethod_5(array6, 4, array7);
		}
		if (flag2 && num22 == ((-1337399454 - num) ^ num2))
		{
			char[] array8 = new char[num23];
			for (int num24 = 0; num24 < num23; num24 = 1 + num24)
			{
				array8[num24] = (char)array7[num24];
			}
			text = new string(array8);
		}
		else
		{
			text = Encoding.Unicode.GetString(array7, 0, array7.Length);
		}
		num22 += num + 1337954503 + num2 + (num22 & 3) << 5;
		if (num22 != (0xF16E74A ^ num) - num2)
		{
			int num25 = (int_3 + num17) ^ ((-1338071712 - num) ^ num2) ^ (num22 & (num + 1337955669 + num2));
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = num ^ 0xF3E0878 ^ num2;
			stringBuilder.Append((char)(byte)num4);
			text = num25.ToString(stringBuilder.ToString());
		}
		if (!flag4 && bool_0)
		{
			text = string.Intern(text);
			class11_0.method_3(int_3, text);
			if (class11_0.method_0() == -1337954070 - num - num2)
			{
				class10_0.method_5();
				class10_0 = null;
				byte_0 = null;
				byte_1 = null;
			}
		}
		return text;
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
