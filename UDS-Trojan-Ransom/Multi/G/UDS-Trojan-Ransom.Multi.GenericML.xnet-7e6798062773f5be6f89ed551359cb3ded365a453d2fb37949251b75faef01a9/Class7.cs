using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

internal static class Class7
{
	private sealed class Class8
	{
		private Stream stream_0;

		private byte[] byte_0;

		public Class8(Stream stream_1)
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

	private enum Enum0
	{

	}

	internal sealed class Class9
	{
		private struct Struct0
		{
			public int int_0;

			public string string_0;
		}

		private Struct0[] struct0_0;

		private int int_0;

		public Class9()
		{
			struct0_0 = new Struct0[16];
		}

		public Class9(int int_1)
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

	private static byte[] byte_0;

	private static short short_0;

	private static byte[] byte_1;

	private static int int_0;

	private static int int_1;

	private static Class8 class8_0;

	private static Enum0 enum0_0;

	private static Class9 class9_0;

	private static int int_2;

	static Class7()
	{
		int num = -1707723163;
		int num2 = 763252630;
		class9_0 = new Class9(71);
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
		int num4 = -(~(~(-(~(-(-(~(~(-(~(1474264596 - num - num2))))))))))) ^ -(~(-(~(~(-(-(~(~((num + 637908774) ^ num2)))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num4 ^= ~(-(-(~(~(-(~(-(~(1509811916 - num + num2)))))))));
		}
		Type type = methodBase?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			num4 ^= (num ^ -1219992360) - num2 + num3;
			enum0_0 |= (Enum0)4;
		}
		else if ((object)type == null)
		{
			if (smethod_4(stackTrace, int_))
			{
				num4 ^= -(~(~(-(~(-(~(-(~((1824007156 - num) ^ num2))))))))) - num3;
				enum0_0 |= (Enum0)16;
			}
			else
			{
				num4 ^= ~(-(-(~(-(~(~(-(-(~(~(num + -1824028549 - num2)))))))))));
				enum0_0 |= (Enum0)1;
			}
		}
		else
		{
			num4 ^= ~(-(~(-(-(~(~(-(~(-(~((0x48B764E7 ^ num) + num2))))))))))) - num3;
			enum0_0 = (Enum0)16 | enum0_0;
		}
		int_0 = num4 + int_0;
	}

	internal static string smethod_0(int int_3)
	{
		lock (class9_0)
		{
			string text = class9_0.method_2(int_3);
			if (text != null)
			{
				return text;
			}
			return smethod_1(int_3, bool_0: true);
		}
	}

	private static string smethod_1(int int_3, bool bool_0)
	{
		int num = 988351420;
		int num2 = 53654906;
		string text = null;
		byte[] array;
		int num17;
		while (true)
		{
			int num3;
			if (class8_0 != null)
			{
				num3 = int_1;
			}
			else
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Assembly callingAssembly = Assembly.GetCallingAssembly();
				int_2 |= (num ^ 0x39A24C40) - num2;
				StringBuilder stringBuilder = new StringBuilder();
				int num4 = (1579065645 - num) ^ num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = (num ^ 0x26246135) + num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = (num + -397899331) ^ num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = 1579082045 - num - num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = (0x263F6132 ^ num) + num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = (-934704705 + num) ^ num2;
				stringBuilder.Append((char)num4);
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
				int num5 = 2;
				StackTrace stackTrace = new StackTrace(2, fNeedFileInfo: false);
				int_2 ^= (1042012796 - num - num2) | 2;
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
				int_2 ^= num5 + (-1042006198 + num + num2);
				Type type = methodBase?.DeclaringType;
				if (frame == null)
				{
					int_2 ^= 1042225641 - num - num2;
				}
				bool flag = (object)type == typeof(RuntimeMethodHandle);
				int_2 ^= (-934696418 + num) ^ num2;
				if (!flag && (flag = (object)type == null))
				{
					if (smethod_4(stackTrace, int_4))
					{
						flag = false;
					}
					else
					{
						int_2 ^= (num ^ -969299803) + num2;
					}
				}
				if (flag == (stackTrace != null))
				{
					int_2 ^= 32;
				}
				int_2 ^= ((num + -934698912) ^ num2) | (1 + num5);
				class8_0 = new Class8(manifestResourceStream);
				short num6 = (short)(class8_0.method_1() ^ (short)(-(~(-(~(-(~(~(-(~(1042035954 - num - num2)))))))))));
				if (num6 == 0)
				{
					short_0 = (short)(class8_0.method_1() ^ (short)(-(~(-(~(~(-(-(~(-(~(~(num ^ 0x39DBE7EA ^ num2)))))))))))));
				}
				else
				{
					byte_1 = class8_0.method_6(num6);
				}
				callingAssembly = executingAssembly;
				AssemblyName assemblyName_ = smethod_2(callingAssembly);
				byte_0 = smethod_3(assemblyName_);
				num3 = int_0;
				num3 ^= 270849944 + num + num2;
				int_0 = 0;
				long num7 = Class14.smethod_0();
				num3 ^= (int)num7;
				num3 ^= (-1737411940 - num) ^ num2;
				num3 ^= (num ^ 0x579B35B9) + num2;
				int num8 = num3;
				int num9 = 0;
				int num10 = num8;
				int int_5 = num10;
				Interface4<int> @interface = ((Interface1<int>)new Class0.Class1((num + -1042006328) | num2)
				{
					int_4 = int_5
				}).imethod_1();
				try
				{
					while (@interface.imethod_2())
					{
						int num11 = @interface.imethod_3();
						num10 ^= num11 + num9;
						num9 += num10 >> 3;
					}
				}
				finally
				{
					((Interface2)@interface)?.imethod_0();
				}
				int num12 = num10;
				int num13 = num12 ^ ((num ^ 0x45083D05) - num2);
				num3 ^= (num ^ 0x39D157F4 ^ num2) + ~(-(-(~(~(-(~(-(~(1042006017 - num - num2)))))))));
				int num14 = num13 * (-1042001033 + num + num2) % (1069748003 - num - num2);
				num3 ^= ~(-(-(~(-(~(~(-(~(-(~((-1311218036 ^ num) + num2)))))))))));
				num3 = (int_1 = num3 + num14);
				int_2 = (int_2 & ((-773570996 + num) ^ num2)) ^ (934703302 - num + num2);
				if (((uint)enum0_0 & (uint)(-(~(-(~(~(-(-(~(~((num ^ 0x39DBBED7) - num2))))))))))) == 0)
				{
					int_2 = 934740476 - num + num2;
				}
			}
			if (int_2 != ((num + -934735100) ^ num2))
			{
				int num15 = int_3 ^ (-775748732 - num - num2) ^ num3;
				num15 ^= (num + 825242793) ^ num2;
				class8_0.method_0().Position = num15;
				if (byte_1 != null)
				{
					array = byte_1;
				}
				else
				{
					short num16 = ((short_0 != -1) ? short_0 : ((short)(class8_0.method_1() ^ ((-970588925 ^ num) + num2) ^ num15)));
					if (num16 == 0)
					{
						array = null;
					}
					else
					{
						array = class8_0.method_6(num16);
						for (int i = 0; i != array.Length; i++)
						{
							array[i] ^= (byte)(int_1 >> ((3 & i) << 3));
						}
					}
				}
				num17 = class8_0.method_2() ^ num15 ^ -(~(~(-(~(-(~(-(-(~(~((num + -442855390) ^ num2))))))))))) ^ num3;
				if (num17 != ((934696512 - num) | num2))
				{
					break;
				}
				byte[] array2 = class8_0.method_6(4);
				int_3 = ((num ^ -446132888) - num2) ^ num3;
				int_3 = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -int_3;
				text = class9_0.method_2(int_3);
				if (text != null)
				{
					return text;
				}
				continue;
			}
			return new string(new char[3]
			{
				(char)(1042006414 - num - num2),
				'0',
				(char)(-1042006238 + num + num2)
			});
		}
		bool flag2 = (num17 & ((num + -397825602) ^ num2)) != 0;
		bool flag3 = (num17 & (2008438338 - num + num2)) != 0;
		bool flag4 = (num17 & (-1176781114 ^ num ^ num2)) != 0;
		num17 &= (1203131969 - num) | num2;
		byte[] array3 = array;
		byte[] array4 = class8_0.method_6(num17);
		byte[] array5 = array3;
		byte b = array5[1];
		int num18 = array4.Length;
		byte b2 = (byte)((11 + num18) ^ (b + 7));
		uint num19 = (uint)((array5[0] | (array5[2] << 8)) + (b2 << 3));
		ushort num20 = 0;
		int num21 = 0;
		while (num21 < num18)
		{
			if ((1 & num21) == 0)
			{
				num19 = (uint)((int)num19 * ((num + -934745397) ^ num2) + ((num ^ -971316491) + num2));
				num20 = (ushort)(num19 >> 16);
			}
			byte b3 = (byte)num20;
			num20 = (ushort)(num20 >> 8);
			byte b4 = array4[num21];
			array4[num21] = (byte)(b4 ^ b ^ (3 + b2) ^ b3);
			num21 = 1 + num21;
			b2 = b4;
		}
		byte[] array6 = array4;
		if (byte_0 != null != (int_2 != 1043614140 - num - num2))
		{
			for (int j = 0; j < num17; j++)
			{
				byte b5 = byte_0[j & 7];
				b5 = (byte)((b5 << 3) | (b5 >> 5));
				array6[j] = (byte)(array6[j] ^ b5);
			}
		}
		int num22 = int_2 - 12;
		byte[] array7;
		int num23;
		if (!flag3)
		{
			array7 = array6;
			num23 = num17;
		}
		else
		{
			num23 = array6[2] | (array6[0] << 16) | (array6[3] << 8) | (array6[1] << 24);
			array7 = new byte[num23];
			smethod_5(array6, 4, array7);
		}
		if (flag2 && num22 == num + -1040398524 + num2)
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
		num22 += (0x39DBBE45 ^ num) - num2 + (num22 & 3) << 5;
		if (num22 != ((1041447324 - num) ^ num2))
		{
			int num25 = (int_3 + num17) ^ (num + -1041069758 + num2) ^ (num22 & (num ^ 0x39DBBBCB ^ num2));
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = 1042006414 - num - num2;
			stringBuilder.Append((char)(byte)num4);
			text = num25.ToString(stringBuilder.ToString());
		}
		if (!flag4 && bool_0)
		{
			text = string.Intern(text);
			class9_0.method_3(int_3, text);
			if (class9_0.method_0() == ((-934696575 + num) ^ num2))
			{
				class8_0.method_5();
				class8_0 = null;
				byte_1 = null;
				byte_0 = null;
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
