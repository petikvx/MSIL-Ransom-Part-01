using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal class Class14
{
	private struct Struct2
	{
		public long long_0;

		public long long_1;
	}

	private struct Struct3
	{
		public long long_0;

		public string[] string_0;
	}

	private struct Struct4
	{
		public long long_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public long long_1;

		public string string_3;
	}

	private byte[] byte_0;

	private ushort ushort_0;

	private ulong ulong_0;

	private Struct4[] struct4_0;

	private byte[] byte_1;

	private Struct3[] struct3_0;

	private string[] string_0;

	private int method_0(int int_0)
	{
		if (int_0 > byte_0.Length)
		{
			return 0;
		}
		int num = int_0 + 8;
		int num2 = int_0;
		while (true)
		{
			if (num2 <= num)
			{
				if (num2 <= byte_0.Length - 1)
				{
					if ((byte_0[num2] & 0x80) != 128)
					{
						break;
					}
					num2++;
					continue;
				}
				return 0;
			}
			return int_0 + 8;
		}
		return num2;
	}

	private long method_1(int int_0, int int_1)
	{
		int_1++;
		byte[] array = new byte[8];
		int num = int_1 - int_0;
		bool flag = false;
		if (num == 0 || num > 9)
		{
			return 0L;
		}
		switch (num)
		{
		case 1:
			array[0] = (byte)(byte_0[int_0] & 0x7Fu);
			return BitConverter.ToInt64(array, 0);
		case 9:
			flag = true;
			break;
		}
		int num2 = 1;
		int num3 = 7;
		int num4 = 0;
		if (flag)
		{
			array[0] = byte_0[int_1 - 1];
			int_1--;
			num4 = 1;
		}
		for (int i = int_1 - 1; i >= int_0; i += -1)
		{
			if (i - 1 >= int_0)
			{
				array[num4] = (byte)(((byte)((uint)byte_0[i] >> ((num2 - 1) & 7)) & (255 >> num2)) | (byte)(byte_0[i - 1] << (num3 & 7)));
				num2++;
				num4++;
				num3--;
			}
			else if (!flag)
			{
				array[num4] = (byte)((byte)((uint)byte_0[i] >> ((num2 - 1) & 7)) & (255 >> num2));
			}
		}
		return BitConverter.ToInt64(array, 0);
	}

	private bool method_2(long long_0)
	{
		return (long_0 & 1L) == 1L;
	}

	private ulong method_3(int int_0, int int_1)
	{
		if (int_1 > 8 || int_1 == 0)
		{
			return 0uL;
		}
		ulong num = 0uL;
		int num2 = int_1 - 1;
		for (int i = 0; i <= num2; i++)
		{
			num = (num << 8) | byte_0[int_0 + i];
		}
		return num;
	}

	private void method_4(ulong ulong_1)
	{
		if (byte_0[(uint)ulong_1] == 13)
		{
			ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(method_3(Convert.ToInt32(decimal.Add(new decimal(ulong_1), new decimal(3L))), 2)), 1m));
			int num2 = 0;
			if (struct4_0 != null)
			{
				num2 = struct4_0.Length;
				struct4_0 = (Struct4[])Utils.CopyArray((Array)struct4_0, (Array)new Struct4[struct4_0.Length + num + 1]);
			}
			else
			{
				struct4_0 = new Struct4[num + 1];
			}
			int num3 = num;
			for (int i = 0; i <= num3; i++)
			{
				ulong num4 = method_3(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), new decimal(8L)), new decimal(i * 2))), 2);
				if (decimal.Compare(new decimal(ulong_1), new decimal(100L)) != 0)
				{
					num4 += ulong_1;
				}
				int num5 = method_0((int)num4);
				method_1((int)num4, num5);
				int num6 = method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
				struct4_0[num2 + i].long_0 = method_1(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
				num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
				num5 = method_0((int)num4);
				num6 = num5;
				long value = method_1((int)num4, num5);
				long[] array = new long[5];
				int num7 = 0;
				do
				{
					num5 = num6 + 1;
					num6 = method_0(num5);
					array[num7] = method_1(num5, num6);
					if (array[num7] <= 9L)
					{
						array[num7] = byte_1[(int)array[num7]];
					}
					else if (method_2(array[num7]))
					{
						array[num7] = (long)Math.Round((double)(array[num7] - 13L) / 2.0);
					}
					else
					{
						array[num7] = (long)Math.Round((double)(array[num7] - 12L) / 2.0);
					}
					num7++;
				}
				while (num7 <= 4);
				if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
				{
					struct4_0[num2 + i].string_0 = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				else if (decimal.Compare(new decimal(ulong_0), new decimal(2L)) == 0)
				{
					struct4_0[num2 + i].string_0 = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				else if (decimal.Compare(new decimal(ulong_0), new decimal(3L)) == 0)
				{
					struct4_0[num2 + i].string_0 = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
				{
					struct4_0[num2 + i].string_1 = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				else if (decimal.Compare(new decimal(ulong_0), new decimal(2L)) == 0)
				{
					struct4_0[num2 + i].string_1 = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				else if (decimal.Compare(new decimal(ulong_0), new decimal(3L)) == 0)
				{
					struct4_0[num2 + i].string_1 = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				struct4_0[num2 + i].long_1 = (long)method_3(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
				if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
				{
					struct4_0[num2 + i].string_3 = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
				else if (decimal.Compare(new decimal(ulong_0), new decimal(2L)) == 0)
				{
					struct4_0[num2 + i].string_3 = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
				else if (decimal.Compare(new decimal(ulong_0), new decimal(3L)) == 0)
				{
					struct4_0[num2 + i].string_3 = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
			}
		}
		else
		{
			if (byte_0[(uint)ulong_1] != 5)
			{
				return;
			}
			ushort num8 = Convert.ToUInt16(decimal.Subtract(new decimal(method_3(Convert.ToInt32(decimal.Add(new decimal(ulong_1), new decimal(3L))), 2)), 1m));
			int num9 = num8;
			for (int j = 0; j <= num9; j++)
			{
				ushort num10 = (ushort)method_3(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), new decimal(12L)), new decimal(j * 2))), 2);
				if (decimal.Compare(new decimal(ulong_1), new decimal(100L)) == 0)
				{
					method_4(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_3(num10, 4)), 1m), new decimal(ushort_0))));
				}
				else
				{
					method_4(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_3((int)(ulong_1 + num10), 4)), 1m), new decimal(ushort_0))));
				}
			}
			method_4(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_3(Convert.ToInt32(decimal.Add(new decimal(ulong_1), new decimal(8L))), 4)), 1m), new decimal(ushort_0))));
		}
	}

	private bool method_5(ulong ulong_1)
	{
		if (byte_0[(uint)ulong_1] == 13)
		{
			ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(method_3(Convert.ToInt32(decimal.Add(new decimal(ulong_1), new decimal(3L))), 2)), 1m));
			int num2 = 0;
			if (struct3_0 != null)
			{
				num2 = struct3_0.Length;
				struct3_0 = (Struct3[])Utils.CopyArray((Array)struct3_0, (Array)new Struct3[struct3_0.Length + num + 1]);
			}
			else
			{
				struct3_0 = new Struct3[num + 1];
			}
			int num3 = num;
			Struct2[] array = default(Struct2[]);
			for (int i = 0; i <= num3; i++)
			{
				ulong num4 = method_3(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), new decimal(8L)), new decimal(i * 2))), 2);
				if (decimal.Compare(new decimal(ulong_1), new decimal(100L)) != 0)
				{
					num4 += ulong_1;
				}
				int num5 = method_0((int)num4);
				method_1((int)num4, num5);
				int num6 = method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
				struct3_0[num2 + i].long_0 = method_1(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
				num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
				num5 = method_0((int)num4);
				num6 = num5;
				long num7 = method_1((int)num4, num5);
				long num8 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(num5)), 1m));
				int num9 = 0;
				while (num8 < num7)
				{
					array = (Struct2[])Utils.CopyArray((Array)array, (Array)new Struct2[num9 + 1]);
					num5 = num6 + 1;
					num6 = method_0(num5);
					array[num9].long_1 = method_1(num5, num6);
					if (array[num9].long_1 > 9L)
					{
						if (method_2(array[num9].long_1))
						{
							array[num9].long_0 = (long)Math.Round((double)(array[num9].long_1 - 13L) / 2.0);
						}
						else
						{
							array[num9].long_0 = (long)Math.Round((double)(array[num9].long_1 - 12L) / 2.0);
						}
					}
					else
					{
						array[num9].long_0 = byte_1[(int)array[num9].long_1];
					}
					num8 = num8 + (num6 - num5) + 1L;
					num9++;
				}
				struct3_0[num2 + i].string_0 = new string[array.Length - 1 + 1];
				int num10 = 0;
				int num11 = array.Length - 1;
				for (int j = 0; j <= num11; j++)
				{
					if (array[j].long_1 > 9L)
					{
						if (!method_2(array[j].long_1))
						{
							if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
							{
								struct3_0[num2 + i].string_0[j] = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0);
							}
							else if (decimal.Compare(new decimal(ulong_0), new decimal(2L)) == 0)
							{
								struct3_0[num2 + i].string_0[j] = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0);
							}
							else if (decimal.Compare(new decimal(ulong_0), new decimal(3L)) == 0)
							{
								struct3_0[num2 + i].string_0[j] = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0);
							}
						}
						else
						{
							struct3_0[num2 + i].string_0[j] = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0);
						}
					}
					else
					{
						struct3_0[num2 + i].string_0[j] = Conversions.ToString(method_3(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array[j].long_0));
					}
					num10 = (int)(num10 + array[j].long_0);
				}
			}
		}
		else if (byte_0[(uint)ulong_1] == 5)
		{
			ushort num12 = Convert.ToUInt16(decimal.Subtract(new decimal(method_3(Convert.ToInt32(decimal.Add(new decimal(ulong_1), new decimal(3L))), 2)), 1m));
			int num13 = num12;
			for (int k = 0; k <= num13; k++)
			{
				ushort num14 = (ushort)method_3(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), new decimal(12L)), new decimal(k * 2))), 2);
				method_5(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_3((int)(ulong_1 + num14), 4)), 1m), new decimal(ushort_0))));
			}
			method_5(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_3(Convert.ToInt32(decimal.Add(new decimal(ulong_1), new decimal(8L))), 4)), 1m), new decimal(ushort_0))));
		}
		return true;
	}

	public bool method_6(string string_1)
	{
		int num = -1;
		int num2 = struct4_0.Length;
		for (int i = 0; i <= num2; i++)
		{
			if (struct4_0[i].string_1.ToLower().CompareTo(string_1.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return false;
		}
		string[] array = struct4_0[num].string_3.Substring(struct4_0[num].string_3.IndexOf("(") + 1).Split(new char[1] { ',' });
		int num3 = array.Length - 1;
		for (int j = 0; j <= num3; j++)
		{
			array[j] = Strings.LTrim(array[j]);
			int num4 = array[j].IndexOf(" ");
			if (num4 > 0)
			{
				array[j] = array[j].Substring(0, num4);
			}
			if (array[j].IndexOf(Class9.smethod_0("jaGntqx9Dw==", "False")) == 0)
			{
				break;
			}
			string_0 = (string[])Utils.CopyArray((Array)string_0, (Array)new string[j + 1]);
			string_0[j] = array[j];
		}
		return method_5((ulong)((struct4_0[num].long_1 - 1L) * ushort_0));
	}

	public int method_7()
	{
		return struct3_0.Length;
	}

	public string method_8(int int_0, int int_1)
	{
		if (int_0 >= struct3_0.Length)
		{
			return null;
		}
		if (int_1 >= struct3_0[int_0].string_0.Length)
		{
			return null;
		}
		return struct3_0[int_0].string_0[int_1];
	}

	public string method_9(int int_0, string string_1)
	{
		int num = -1;
		int num2 = string_0.Length;
		for (int i = 0; i <= num2; i++)
		{
			if (string_0[i].ToLower().CompareTo(string_1.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return null;
		}
		return method_8(int_0, num);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public Class14(string string_1)
	{
		byte_1 = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };
		if (File.Exists(string_1))
		{
			FileSystem.FileOpen(1, string_1, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
			string s = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref s, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			byte_0 = Encoding.Default.GetBytes(s);
			if (Encoding.Default.GetString(byte_0, 0, 15).CompareTo(Class9.smethod_0("k6yy1tOle8zc0a282o2SBg==", "False")) != 0)
			{
				throw new Exception(Class9.smethod_0("ks7ekcRk1cvdzKh/vcKvrdPPkZZko8vlxKbA3daDisjW1gY=", "False"));
			}
			if (byte_0[52] != 0)
			{
				throw new Exception(Class9.smethod_0("bbzGyHiiqLXOwJlntbq7jam+vmuQqMa6rY26t3m0n2fAyL9MusfJu5u5xr6vGg==", "False"));
			}
			if (decimal.Compare(new decimal(method_3(44, 4)), new decimal(4L)) >= 0)
			{
				throw new Exception(Class9.smethod_0("dLBsxrqWsbvFuYulbKaojqa5tGWSosW4t0antb+qU6e7xbKHtSI=", "False"));
			}
			ushort_0 = (ushort)method_3(16, 2);
			ulong_0 = method_3(56, 4);
			if (decimal.Compare(new decimal(ulong_0), 0m) == 0)
			{
				ulong_0 = 1uL;
			}
			method_4(100uL);
		}
	}
}
