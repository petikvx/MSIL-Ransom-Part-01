using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

internal static class Class8
{
	private enum Enum0
	{

	}

	[DefaultMember("Item")]
	internal sealed class Class9
	{
		private struct Struct1
		{
			public int int_0;

			public string string_0;
		}

		private Struct1[] struct1_0;

		private int int_0;

		public Class9()
		{
			struct1_0 = new Struct1[16];
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
			struct1_0 = new Struct1[num];
		}

		public int method_0()
		{
			return int_0;
		}

		private void method_1()
		{
			Struct1[] array = struct1_0;
			int num = array.Length;
			int num2 = num * 2;
			if (num2 <= 0)
			{
				return;
			}
			Struct1[] array2 = new Struct1[num2];
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
			struct1_0 = array2;
			int_0 = num3;
		}

		public string method_2(int int_1)
		{
			Struct1[] array = struct1_0;
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
			Struct1[] array = struct1_0;
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

	private static Class9 class9_0;

	private static Class10 class10_0;

	private static byte[] byte_0;

	private static short short_0;

	private static int int_0;

	private static byte[] byte_1;

	private static int int_1;

	private static int int_2;

	private static Enum0 enum0_0;

	static Class8()
	{
		int num = 1484520867;
		int num2 = -141598394;
		class9_0 = new Class9(575);
		int num3 = 1;
		StackTrace stackTrace = new StackTrace(1, fNeedFileInfo: false);
		num3 = 0;
		StackFrame frame = stackTrace.GetFrame(0);
		int num4 = -1838559027;
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num4 ^= -(~(~(-(~(-(~(-(~((num ^ -1379048684) + num2)))))))));
		}
		Type type = methodBase?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			num4 ^= ((num + -1626118978) ^ num2) + num3;
			enum0_0 = (Enum0)4 | enum0_0;
		}
		else if ((object)type == null)
		{
			enum0_0 = (Enum0)1 | enum0_0;
			num4 ^= ~(-(-(~(~(-(~(-(~(-(~((1626082211 - num) | num2)))))))))));
		}
		else if ((object)type.Assembly != typeof(Class8).Assembly)
		{
			num4 ^= num + -901917044 - num2;
			enum0_0 = (Enum0)2 | enum0_0;
		}
		else
		{
			num4 ^= -(~(-(~(~(-(~(-(~(-(~(1626095223 - num + num2))))))))))) - num3;
			enum0_0 = (Enum0)16 | enum0_0;
		}
		int_2 += num4;
	}

	private static void smethod_0(byte[] byte_2, int int_3, byte[] byte_3)
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

	internal static string smethod_1(int int_3)
	{
		int num = -942221324;
		int num2 = 807459707;
		lock (class9_0)
		{
			byte[] array;
			int num11;
			string text;
			while (true)
			{
				text = class9_0.method_2(int_3);
				if (text == null)
				{
					int num6;
					if (class10_0 == null)
					{
						Assembly executingAssembly = Assembly.GetExecutingAssembly();
						Assembly callingAssembly = Assembly.GetCallingAssembly();
						int_0 |= -133151247 - num - num2;
						StringBuilder stringBuilder = new StringBuilder();
						int num3 = -671929207 ^ num ^ num2;
						stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
						num3 = -2008210543 + num - num2;
						stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
						num3 = num ^ -672060276 ^ num2;
						stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
						num3 = num + 671968405 + num2;
						stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
						num3 = num ^ -672060284 ^ num2;
						stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
						num3 = 1749689228 + num - num2;
						stringBuilder.Append((char)num3);
						Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
						int num4 = 1;
						StackTrace stackTrace = new StackTrace(1, fNeedFileInfo: false);
						int_0 ^= ((0x809EA3F ^ num) + num2) | 1;
						num4 = 0;
						StackFrame frame = stackTrace.GetFrame(0);
						MethodBase methodBase = frame?.GetMethod();
						int_0 ^= num4 + (-134761489 - num - num2);
						Type type = methodBase?.DeclaringType;
						if (frame == null)
						{
							int_0 ^= (num ^ 0x834AACC) + num2;
						}
						bool flag = (object)type == typeof(RuntimeMethodHandle);
						int_0 ^= num + 1749681191 - num2;
						if (!flag && (flag = (object)type == null))
						{
							int_0 ^= (-134587428 - num) ^ num2;
						}
						if (flag == (stackTrace != null))
						{
							int_0 ^= 32;
						}
						int_0 ^= ((0x809EA1F ^ num) + num2) | (num4 + 1);
						class10_0 = new Class10(manifestResourceStream);
						short num5 = (short)(class10_0.method_1() ^ (short)(~(-(-(~(~(-(~(-(~(-(~(1749701106 + num - num2)))))))))))));
						if (num5 == 0)
						{
							short_0 = (short)(class10_0.method_1() ^ (short)(-(~(-(~(-(~(~(-(~((-1749676989 - num) ^ num2)))))))))));
						}
						else
						{
							byte_0 = class10_0.method_6(num5);
						}
						callingAssembly = executingAssembly;
						AssemblyName assemblyName;
						try
						{
							assemblyName = callingAssembly.GetName();
						}
						catch
						{
							assemblyName = new AssemblyName(callingAssembly.FullName);
						}
						byte_1 = assemblyName.GetPublicKeyToken();
						if (byte_1 != null && byte_1.Length == 0)
						{
							byte_1 = null;
						}
						num6 = int_2;
						int_2 = 0;
						num6 ^= (num ^ -502893946) + num2;
						long num7 = Class12.smethod_0();
						num6 ^= (int)num7;
						num6 ^= (-1646899702 + num) ^ num2;
						num6 ^= ~(-(-(~(~(-(~(-(-(~(~((num ^ 0x7B80F4CF) + num2)))))))))));
						int_0 = (int_0 & ((num + 2013809685) ^ num2)) ^ ((-134864373 ^ num) - num2);
						int_1 = num6;
						if (((uint)enum0_0 & (uint)(-(~(~(-(~(-(-(~(~(-(~(134761599 + num + num2))))))))))))) == 0)
						{
							int_0 = (-134788939 - num) ^ num2;
						}
					}
					else
					{
						num6 = int_1;
					}
					if (int_0 != (0x80907CB ^ num) + num2)
					{
						int num8 = int_3 ^ (-927015451 - num - num2) ^ num6;
						num8 ^= (0x232E964F ^ num) + num2;
						class10_0.method_0().Position = num8;
						if (byte_0 != null)
						{
							array = byte_0;
						}
						else
						{
							short num9 = ((short_0 != -1) ? short_0 : ((short)(class10_0.method_1() ^ (num + 1749666093 - num2) ^ num8)));
							if (num9 == 0)
							{
								array = null;
							}
							else
							{
								array = class10_0.method_6(num9);
								for (int num10 = 0; num10 != array.Length; num10 = 1 + num10)
								{
									array[num10] ^= (byte)(int_1 >> ((3 & num10) << 3));
								}
							}
						}
						num11 = class10_0.method_2() ^ num8 ^ ~(-(-(~(~(-(~(-(~((-1436723163 - num) ^ num2))))))))) ^ num6;
						if (num11 != 134761615 + num + num2)
						{
							break;
						}
						byte[] array2 = class10_0.method_6(4);
						int_3 = ((num ^ -1699981350) - num2) ^ num6;
						int_3 = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -int_3;
						continue;
					}
					return new string(new char[3]
					{
						(char)(num + 1749681119 - num2),
						'0',
						(char)((0x809F329 ^ num) + num2)
					});
				}
				return text;
			}
			bool flag2 = (num11 & ((num ^ -1745482609) - num2)) != 0;
			bool flag3 = (num11 & (num + -2012722031 + num2)) != 0;
			bool flag4 = (num11 & ((938980207 - num) ^ num2)) != 0;
			num11 &= (129367160 - num) ^ num2;
			byte[] array3 = Class11.smethod_0(array, class10_0.method_6(num11));
			if (byte_1 != null != (int_0 != 1751288845 + num - num2))
			{
				for (int num12 = 0; num12 < num11; num12 = 1 + num12)
				{
					byte b = byte_1[num12 & 7];
					b = (byte)((b << 3) | (b >> 5));
					array3[num12] = (byte)(array3[num12] ^ b);
				}
			}
			int num13 = int_0 - 12;
			byte[] array4;
			int num14;
			if (!flag3)
			{
				array4 = array3;
				num14 = num11;
			}
			else
			{
				num14 = array3[2] | (array3[0] << 16) | (array3[3] << 8) | (array3[1] << 24);
				array4 = new byte[num14];
				smethod_0(array3, 4, array4);
			}
			if (flag4 && num13 == ((-133223691 - num) ^ num2))
			{
				char[] array5 = new char[num14];
				for (int i = 0; i < num14; i++)
				{
					array5[i] = (char)array4[i];
				}
				text = new string(array5);
			}
			else
			{
				text = Encoding.Unicode.GetString(array4, 0, array4.Length);
			}
			num13 += (num ^ -134870002) - num2 + (3 & num13) << 5;
			if (num13 != ((1751215085 + num) ^ num2))
			{
				int num15 = (int_3 + num11) ^ (-1748744463 - num + num2) ^ (num13 & ((num + 1749681794) ^ num2));
				StringBuilder stringBuilder = new StringBuilder();
				int num3 = -1749680943 - num + num2;
				stringBuilder.Append((char)(byte)num3);
				text = num15.ToString(stringBuilder.ToString());
			}
			if (!flag2)
			{
				text = string.Intern(text);
				class9_0.method_3(int_3, text);
				if (class9_0.method_0() == (-134869328 ^ num ^ num2))
				{
					class10_0.method_5();
					class10_0 = null;
					byte_0 = (byte_1 = null);
				}
			}
			return text;
		}
	}
}
