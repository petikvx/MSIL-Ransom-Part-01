using System;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns1;

namespace ns0;

public class GClass0
{
	private struct Struct0
	{
		public long long_0;

		public long long_1;
	}

	private struct Struct1
	{
		public long long_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public long long_1;

		public string string_3;
	}

	private struct Struct2
	{
		public long long_0;

		public string[] string_0;
	}

	private byte[] byte_0;

	private string[] string_0;

	private Struct1[] struct1_0;

	private ushort ushort_0;

	private Enum0 enum0_0;

	internal ulong ulong_0;

	internal byte[] byte_1 = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };

	internal Struct2[] struct2_0;

	public GClass0(string string_1)
	{
		if (File.Exists(string_1))
		{
			FileSystem.FileOpen(1, string_1, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
			string s = Strings.Space((int)FileSystem.LOF(1));
			FileSystem.FileGet(1, ref s, -1L, false);
			FileSystem.FileClose(new int[1] { 1 });
			byte_0 = Encoding.Default.GetBytes(s);
			decimal num = new decimal(method_0(44, 4));
			enum0_0 = (Enum0)(int)num;
			ushort_0 = (ushort)method_0(16, 2);
			ulong num2 = (ulong_0 = method_0(56, 4));
			if (decimal.Compare(new decimal(ulong_0), 0m) == 0)
			{
				ulong_0 = 1uL;
			}
			method_7(100uL);
		}
	}

	private ulong method_0(int int_0, int int_1)
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
				array[num4] = (byte)(((byte)(byte_0[i] >> ((num2 - 1) & 7)) & (255 >> num2)) | (byte)(byte_0[i - 1] << (num3 & 7)));
				num2++;
				num4++;
				num3--;
			}
			else if (!flag)
			{
				array[num4] = (byte)((byte)(byte_0[i] >> ((num2 - 1) & 7)) & (255 >> num2));
			}
		}
		return BitConverter.ToInt64(array, 0);
	}

	public int RxCIoVq1wZGosw8AUPBXTRW0LG83uzOd5TFlkbvlImeGhAJE89KS9POglpZEPK7HlIqIyHr9GkZeCEi38FKtf1OrvrbGpDGsOsUufZap4JWCLnjbCeOwJyVPJfXg31GPhv4t()
	{
		return struct2_0.Length;
	}

	public string[] method_2()
	{
		string[] array = null;
		int num = 0;
		int num2 = struct1_0.Length - 1;
		for (int i = 0; i <= num2; i++)
		{
			if (struct1_0[i].string_0 == "table")
			{
				array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
				array[num] = struct1_0[i].string_1;
				num++;
			}
		}
		return array;
	}

	public string method_3(int int_0, int int_1)
	{
		if (int_0 >= struct2_0.Length)
		{
			return null;
		}
		if (int_1 >= struct2_0[int_0].string_0.Length)
		{
			return null;
		}
		return struct2_0[int_0].string_0[int_1];
	}

	public string method_4(int int_0, string string_1)
	{
		int num = -1;
		int num2 = string_0.Length - 1;
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
		return method_3(int_0, num);
	}

	private int method_5(int int_0)
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

	private bool method_6(long long_0)
	{
		return (long_0 & 1L) == 1L;
	}

	private void method_7(ulong ulong_1)
	{
		if (byte_0[(uint)ulong_1] == 13)
		{
			ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(method_0(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 3m)), 2)), 1m));
			int num2 = 0;
			if (struct1_0 != null)
			{
				num2 = struct1_0.Length;
				struct1_0 = (Struct1[])Utils.CopyArray((Array)struct1_0, (Array)new Struct1[struct1_0.Length + num + 1]);
			}
			else
			{
				struct1_0 = new Struct1[num + 1];
			}
			int num3 = num;
			for (int i = 0; i <= num3; i++)
			{
				ulong num4 = method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), 8m), new decimal(i * 2))), 2);
				if (decimal.Compare(new decimal(ulong_1), 100m) != 0)
				{
					num4 += ulong_1;
				}
				int num5 = method_5((int)num4);
				method_1((int)num4, num5);
				int num6 = method_5(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
				struct1_0[num2 + i].long_0 = method_1(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
				num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
				num5 = method_5((int)num4);
				num6 = num5;
				long value = method_1((int)num4, num5);
				long[] array = new long[5];
				int num7 = 0;
				do
				{
					num5 = num6 + 1;
					num6 = method_5(num5);
					array[num7] = method_1(num5, num6);
					if (array[num7] <= 9L)
					{
						array[num7] = byte_1[(int)array[num7]];
					}
					else if (method_6(array[num7]))
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
					struct1_0[num2 + i].string_0 = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				else if (decimal.Compare(new decimal(ulong_0), 2m) == 0)
				{
					struct1_0[num2 + i].string_0 = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				else if (decimal.Compare(new decimal(ulong_0), 3m) == 0)
				{
					struct1_0[num2 + i].string_0 = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(new decimal(num4), new decimal(value))), (int)array[0]);
				}
				if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
				{
					struct1_0[num2 + i].string_1 = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				else if (decimal.Compare(new decimal(ulong_0), 2m) == 0)
				{
					struct1_0[num2 + i].string_1 = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				else if (decimal.Compare(new decimal(ulong_0), 3m) == 0)
				{
					struct1_0[num2 + i].string_1 = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0]))), (int)array[1]);
				}
				struct1_0[num2 + i].long_1 = (long)method_0(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
				if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
				{
					struct1_0[num2 + i].string_3 = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
				else if (decimal.Compare(new decimal(ulong_0), 2m) == 0)
				{
					struct1_0[num2 + i].string_3 = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
				else if (decimal.Compare(new decimal(ulong_0), 3m) == 0)
				{
					struct1_0[num2 + i].string_3 = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num4), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
				}
			}
		}
		else
		{
			if (byte_0[(uint)ulong_1] != 5)
			{
				return;
			}
			int num8 = Convert.ToUInt16(decimal.Subtract(new decimal(method_0(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 3m)), 2)), 1m));
			for (int j = 0; j <= num8; j++)
			{
				ushort num9 = (ushort)method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), 12m), new decimal(j * 2))), 2);
				if (decimal.Compare(new decimal(ulong_1), 100m) == 0)
				{
					method_7(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_0(num9, 4)), 1m), new decimal(ushort_0))));
				}
				else
				{
					method_7(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_0((int)(ulong_1 + num9), 4)), 1m), new decimal(ushort_0))));
				}
			}
			method_7(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_0(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 8m)), 4)), 1m), new decimal(ushort_0))));
		}
	}

	public bool method_8(string string_1)
	{
		int num = -1;
		int num2 = struct1_0.Length - 1;
		for (int i = 0; i <= num2; i++)
		{
			if (struct1_0[i].string_1.ToLower().CompareTo(string_1.ToLower()) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return false;
		}
		string[] array = struct1_0[num].string_3.Substring(struct1_0[num].string_3.IndexOf("(") + 1).Split(new char[1] { ',' });
		int num3 = array.Length - 1;
		for (int j = 0; j <= num3; j++)
		{
			array[j] = array[j].TrimStart(new char[0]);
			int num4 = array[j].IndexOf(" ");
			if (num4 > 0)
			{
				array[j] = array[j].Substring(0, num4);
			}
			if (array[j].IndexOf("UNIQUE") == 0)
			{
				break;
			}
			string_0 = (string[])Utils.CopyArray((Array)string_0, (Array)new string[j + 1]);
			string_0[j] = array[j];
		}
		return method_9((ulong)((struct1_0[num].long_1 - 1L) * ushort_0));
	}

	private bool method_9(ulong ulong_1)
	{
		if (byte_0[(uint)ulong_1] == 13)
		{
			int num = Convert.ToInt32(decimal.Subtract(new decimal(method_0(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 3m)), 2)), 1m));
			int num2 = 0;
			if (struct2_0 == null)
			{
				Struct2[] array = (struct2_0 = new Struct2[num + 1]);
			}
			else
			{
				num2 = struct2_0.Length;
				Struct2[] array2 = (struct2_0 = (Struct2[])Utils.CopyArray((Array)struct2_0, (Array)new Struct2[struct2_0.Length + num + 1]));
			}
			int num3 = num;
			for (int i = 0; i <= num3; i++)
			{
				Struct0[] array3 = null;
				ulong num4 = method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), 8m), new decimal(i * 2))), 2);
				if (decimal.Compare(new decimal(ulong_1), 100m) != 0)
				{
					num4 += ulong_1;
				}
				int num5 = method_5((int)num4);
				method_1((int)num4, num5);
				int num6 = method_5(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)));
				struct2_0[num2 + i].long_0 = method_1(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num5), new decimal(num4))), 1m)), num6);
				num4 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num4), decimal.Subtract(new decimal(num6), new decimal(num4))), 1m));
				num5 = method_5((int)num4);
				num6 = num5;
				long num7 = method_1((int)num4, num5);
				long num8 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num4), new decimal(num5)), 1m));
				int num9 = 0;
				while (num8 < num7)
				{
					array3 = (Struct0[])Utils.CopyArray((Array)array3, (Array)new Struct0[num9 + 1]);
					num5 = num6 + 1;
					num6 = method_5(num5);
					array3[num9].long_1 = method_1(num5, num6);
					if (array3[num9].long_1 > 9L)
					{
						if (method_6(array3[num9].long_1))
						{
							array3[num9].long_0 = (long)Math.Round((double)(array3[num9].long_1 - 13L) / 2.0);
						}
						else
						{
							array3[num9].long_0 = (long)Math.Round((double)(array3[num9].long_1 - 12L) / 2.0);
						}
					}
					else
					{
						array3[num9].long_0 = byte_1[(int)array3[num9].long_1];
					}
					num8 = num8 + (num6 - num5) + 1L;
					num9++;
				}
				struct2_0[num2 + i].string_0 = new string[array3.Length - 1 + 1];
				int num10 = 0;
				int num11 = array3.Length - 1;
				for (int j = 0; j <= num11; j++)
				{
					if (array3[j].long_1 > 9L)
					{
						if (!method_6(array3[j].long_1))
						{
							if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
							{
								struct2_0[num2 + i].string_0[j] = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array3[j].long_0);
							}
							else if (decimal.Compare(new decimal(ulong_0), 2m) == 0)
							{
								struct2_0[num2 + i].string_0[j] = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array3[j].long_0);
							}
							else if (decimal.Compare(new decimal(ulong_0), 3m) == 0)
							{
								struct2_0[num2 + i].string_0[j] = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array3[j].long_0);
							}
						}
						else
						{
							struct2_0[num2 + i].string_0[j] = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array3[j].long_0);
						}
					}
					else
					{
						struct2_0[num2 + i].string_0[j] = Conversions.ToString(method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num4), new decimal(num7)), new decimal(num10))), (int)array3[j].long_0));
					}
					num10 += (int)array3[j].long_0;
				}
			}
		}
		else if (byte_0[(uint)ulong_1] == 5)
		{
			int num12 = Convert.ToUInt16(decimal.Subtract(new decimal(method_0(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 3m)), 2)), 1m));
			for (int k = 0; k <= num12; k++)
			{
				ushort num13 = (ushort)method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), 12m), new decimal(k * 2))), 2);
				method_9(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_0((int)(ulong_1 + num13), 4)), 1m), new decimal(ushort_0))));
			}
			method_9(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_0(Convert.ToInt32(decimal.Add(new decimal(ulong_1), 8m)), 4)), 1m), new decimal(ushort_0))));
		}
		return true;
	}
}
