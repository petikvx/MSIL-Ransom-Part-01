using System;
using System.IO;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public sealed class GClass3
{
	private struct Struct6
	{
		public long long_0;

		public long long_1;
	}

	private struct Struct7
	{
		public long long_0;

		public string[] string_0;
	}

	private struct Struct8
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

	private Struct8[] struct8_0;

	private byte[] byte_1;

	private Struct7[] struct7_0;

	private string[] string_0;

	public GClass3(string string_1)
	{
		byte_1 = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };
		checked
		{
			if (File.Exists(string_1))
			{
				FileSystem.FileOpen(1, string_1, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
				string s = Strings.Space((int)FileSystem.LOF(1));
				FileSystem.FileGet(1, ref s, -1L, false);
				FileSystem.FileClose(new int[1] { 1 });
				byte_0 = Encoding.Default.GetBytes(s);
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

	private int method_0(int int_0)
	{
		if (int_0 > byte_0.Length)
		{
			return 0;
		}
		checked
		{
			int num = int_0 + 8;
			int num2 = int_0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
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
	}

	private long method_1(int int_0, int int_1)
	{
		checked
		{
			int_1++;
			byte[] array = new byte[8];
			int num = int_1 - int_0;
			bool flag = false;
			if (unchecked(num == 0 || num > 9))
			{
				return 0L;
			}
			switch (num)
			{
			case 1:
				array[0] = (byte)(byte_0[int_0] & 0x7F);
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
			int num5 = int_1 - 1;
			while (true)
			{
				int num6 = num5;
				int num7 = int_0;
				if (num6 < num7)
				{
					break;
				}
				if (num5 - 1 >= int_0)
				{
					array[num4] = (byte)unchecked(((byte)((uint)byte_0[num5] >> (checked(num2 - 1) & 7)) & (255 >> num2)) | (byte)(byte_0[checked(num5 - 1)] << (num3 & 7)));
					num2++;
					num4++;
					num3--;
				}
				else if (!flag)
				{
					array[num4] = (byte)(unchecked((byte)((uint)byte_0[num5] >> (checked(num2 - 1) & 7))) & (255 >> num2));
				}
				num5 += -1;
			}
			return BitConverter.ToInt64(array, 0);
		}
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
		checked
		{
			int num2 = int_1 - 1;
			int num3 = 0;
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				num = (num << 8) | byte_0[int_0 + num3];
				num3++;
			}
			return num;
		}
	}

	private void method_4(ulong ulong_1)
	{
		checked
		{
			if (byte_0[(int)ulong_1] == 13)
			{
				ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(method_3(Convert.ToInt32(decimal.Add(new decimal(ulong_1), new decimal(3L))), 2)), 1m));
				int num2 = 0;
				if (struct8_0 != null)
				{
					num2 = struct8_0.Length;
					struct8_0 = (Struct8[])Utils.CopyArray((Array)struct8_0, (Array)new Struct8[struct8_0.Length + unchecked((int)num) + 1]);
				}
				else
				{
					struct8_0 = new Struct8[unchecked((int)num) + 1];
				}
				int num3 = num;
				int num4 = 0;
				while (true)
				{
					int num5 = num4;
					int num6 = num3;
					if (num5 > num6)
					{
						break;
					}
					ulong num7 = method_3(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), new decimal(8L)), new decimal(num4 * 2))), 2);
					if (decimal.Compare(new decimal(ulong_1), new decimal(100L)) != 0)
					{
						num7 += ulong_1;
					}
					int num8 = method_0((int)num7);
					method_1((int)num7, num8);
					int num9 = method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num7), decimal.Subtract(new decimal(num8), new decimal(num7))), 1m)));
					struct8_0[num2 + num4].long_0 = method_1(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num7), decimal.Subtract(new decimal(num8), new decimal(num7))), 1m)), num9);
					num7 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num7), decimal.Subtract(new decimal(num9), new decimal(num7))), 1m));
					num8 = method_0((int)num7);
					num9 = num8;
					long value = method_1((int)num7, num8);
					long[] array = new long[5];
					int num10 = 0;
					int num11;
					do
					{
						num8 = num9 + 1;
						num9 = method_0(num8);
						array[num10] = method_1(num8, num9);
						if (array[num10] <= 9L)
						{
							array[num10] = byte_1[(int)array[num10]];
						}
						else if (method_2(array[num10]))
						{
							array[num10] = (long)Math.Round((double)(array[num10] - 13L) / 2.0);
						}
						else
						{
							array[num10] = (long)Math.Round((double)(array[num10] - 12L) / 2.0);
						}
						num10++;
						num11 = num10;
						num6 = 4;
					}
					while (num11 <= 4);
					if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
					{
						struct8_0[num2 + num4].string_0 = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(new decimal(num7), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(ulong_0), new decimal(2L)) == 0)
					{
						struct8_0[num2 + num4].string_0 = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(new decimal(num7), new decimal(value))), (int)array[0]);
					}
					else if (decimal.Compare(new decimal(ulong_0), new decimal(3L)) == 0)
					{
						struct8_0[num2 + num4].string_0 = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(new decimal(num7), new decimal(value))), (int)array[0]);
					}
					if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
					{
						struct8_0[num2 + num4].string_1 = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num7), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(ulong_0), new decimal(2L)) == 0)
					{
						struct8_0[num2 + num4].string_1 = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num7), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					else if (decimal.Compare(new decimal(ulong_0), new decimal(3L)) == 0)
					{
						struct8_0[num2 + num4].string_1 = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num7), new decimal(value)), new decimal(array[0]))), (int)array[1]);
					}
					struct8_0[num2 + num4].long_1 = (long)method_3(Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num7), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2]))), (int)array[3]);
					if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
					{
						struct8_0[num2 + num4].string_3 = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num7), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(ulong_0), new decimal(2L)) == 0)
					{
						struct8_0[num2 + num4].string_3 = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num7), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					else if (decimal.Compare(new decimal(ulong_0), new decimal(3L)) == 0)
					{
						struct8_0[num2 + num4].string_3 = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(decimal.Add(decimal.Add(decimal.Add(new decimal(num7), new decimal(value)), new decimal(array[0])), new decimal(array[1])), new decimal(array[2])), new decimal(array[3]))), (int)array[4]);
					}
					num4++;
				}
			}
			else
			{
				if (byte_0[(int)ulong_1] != 5)
				{
					return;
				}
				ushort num12 = Convert.ToUInt16(decimal.Subtract(new decimal(method_3(Convert.ToInt32(decimal.Add(new decimal(ulong_1), new decimal(3L))), 2)), 1m));
				int num13 = num12;
				int num14 = 0;
				while (true)
				{
					int num15 = num14;
					int num6 = num13;
					if (num15 > num6)
					{
						break;
					}
					ushort num16 = (ushort)method_3(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), new decimal(12L)), new decimal(num14 * 2))), 2);
					if (decimal.Compare(new decimal(ulong_1), new decimal(100L)) == 0)
					{
						method_4(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_3(num16, 4)), 1m), new decimal(ushort_0))));
					}
					else
					{
						method_4(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_3((int)(ulong_1 + num16), 4)), 1m), new decimal(ushort_0))));
					}
					num14++;
				}
				method_4(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_3(Convert.ToInt32(decimal.Add(new decimal(ulong_1), new decimal(8L))), 4)), 1m), new decimal(ushort_0))));
			}
		}
	}

	private bool method_5(ulong ulong_1)
	{
		checked
		{
			if (byte_0[(int)ulong_1] == 13)
			{
				ushort num = Convert.ToUInt16(decimal.Subtract(new decimal(method_3(Convert.ToInt32(decimal.Add(new decimal(ulong_1), new decimal(3L))), 2)), 1m));
				int num2 = 0;
				if (struct7_0 != null)
				{
					num2 = struct7_0.Length;
					struct7_0 = (Struct7[])Utils.CopyArray((Array)struct7_0, (Array)new Struct7[struct7_0.Length + unchecked((int)num) + 1]);
				}
				else
				{
					struct7_0 = new Struct7[unchecked((int)num) + 1];
				}
				int num3 = num;
				int num4 = 0;
				Struct6[] array = default(Struct6[]);
				while (true)
				{
					int num5 = num4;
					int num6 = num3;
					if (num5 > num6)
					{
						break;
					}
					ulong num7 = method_3(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), new decimal(8L)), new decimal(num4 * 2))), 2);
					if (decimal.Compare(new decimal(ulong_1), new decimal(100L)) != 0)
					{
						num7 += ulong_1;
					}
					int num8 = method_0((int)num7);
					method_1((int)num7, num8);
					int num9 = method_0(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num7), decimal.Subtract(new decimal(num8), new decimal(num7))), 1m)));
					struct7_0[num2 + num4].long_0 = method_1(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num7), decimal.Subtract(new decimal(num8), new decimal(num7))), 1m)), num9);
					num7 = Convert.ToUInt64(decimal.Add(decimal.Add(new decimal(num7), decimal.Subtract(new decimal(num9), new decimal(num7))), 1m));
					num8 = method_0((int)num7);
					num9 = num8;
					long num10 = method_1((int)num7, num8);
					long num11 = Convert.ToInt64(decimal.Add(decimal.Subtract(new decimal(num7), new decimal(num8)), 1m));
					int num12 = 0;
					while (num11 < num10)
					{
						array = (Struct6[])Utils.CopyArray((Array)array, (Array)new Struct6[num12 + 1]);
						num8 = num9 + 1;
						num9 = method_0(num8);
						array[num12].long_1 = method_1(num8, num9);
						if (array[num12].long_1 > 9L)
						{
							if (method_2(array[num12].long_1))
							{
								array[num12].long_0 = (long)Math.Round((double)(array[num12].long_1 - 13L) / 2.0);
							}
							else
							{
								array[num12].long_0 = (long)Math.Round((double)(array[num12].long_1 - 12L) / 2.0);
							}
						}
						else
						{
							array[num12].long_0 = byte_1[(int)array[num12].long_1];
						}
						num11 = num11 + (num9 - num8) + 1L;
						num12++;
					}
					struct7_0[num2 + num4].string_0 = new string[array.Length - 1 + 1];
					int num13 = 0;
					int num14 = array.Length - 1;
					int num15 = 0;
					while (true)
					{
						int num16 = num15;
						num6 = num14;
						if (num16 > num6)
						{
							break;
						}
						if (array[num15].long_1 > 9L)
						{
							if (!method_2(array[num15].long_1))
							{
								if (decimal.Compare(new decimal(ulong_0), 1m) == 0)
								{
									struct7_0[num2 + num4].string_0[num15] = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num7), new decimal(num10)), new decimal(num13))), (int)array[num15].long_0);
								}
								else if (decimal.Compare(new decimal(ulong_0), new decimal(2L)) == 0)
								{
									struct7_0[num2 + num4].string_0[num15] = Encoding.Unicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num7), new decimal(num10)), new decimal(num13))), (int)array[num15].long_0);
								}
								else if (decimal.Compare(new decimal(ulong_0), new decimal(3L)) == 0)
								{
									struct7_0[num2 + num4].string_0[num15] = Encoding.BigEndianUnicode.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num7), new decimal(num10)), new decimal(num13))), (int)array[num15].long_0);
								}
							}
							else
							{
								struct7_0[num2 + num4].string_0[num15] = Encoding.Default.GetString(byte_0, Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num7), new decimal(num10)), new decimal(num13))), (int)array[num15].long_0);
							}
						}
						else
						{
							struct7_0[num2 + num4].string_0[num15] = Conversions.ToString(method_3(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(num7), new decimal(num10)), new decimal(num13))), (int)array[num15].long_0));
						}
						num13 = (int)(num13 + array[num15].long_0);
						num15++;
					}
					num4++;
				}
			}
			else if (byte_0[(int)ulong_1] == 5)
			{
				ushort num17 = Convert.ToUInt16(decimal.Subtract(new decimal(method_3(Convert.ToInt32(decimal.Add(new decimal(ulong_1), new decimal(3L))), 2)), 1m));
				int num18 = num17;
				int num19 = 0;
				while (true)
				{
					int num20 = num19;
					int num6 = num18;
					if (num20 > num6)
					{
						break;
					}
					ushort num21 = (ushort)method_3(Convert.ToInt32(decimal.Add(decimal.Add(new decimal(ulong_1), new decimal(12L)), new decimal(num19 * 2))), 2);
					method_5(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_3((int)(ulong_1 + num21), 4)), 1m), new decimal(ushort_0))));
					num19++;
				}
				method_5(Convert.ToUInt64(decimal.Multiply(decimal.Subtract(new decimal(method_3(Convert.ToInt32(decimal.Add(new decimal(ulong_1), new decimal(8L))), 4)), 1m), new decimal(ushort_0))));
			}
			return true;
		}
	}

	public bool method_6(string string_1)
	{
		int num = -1;
		int num2 = struct8_0.Length;
		int num3 = 0;
		checked
		{
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 <= num5)
				{
					if (struct8_0[num3].string_1.ToLower().CompareTo(string_1.ToLower()) != 0)
					{
						num3++;
						continue;
					}
					num = num3;
					break;
				}
				break;
			}
			if (num == -1)
			{
				return false;
			}
			string[] array = struct8_0[num].string_3.Substring(struct8_0[num].string_3.IndexOf("(") + 1).Split(new char[1] { ',' });
			int num6 = array.Length - 1;
			int num7 = 0;
			while (true)
			{
				int num8 = num7;
				int num5 = num6;
				if (num8 > num5)
				{
					break;
				}
				array[num7] = Strings.LTrim(array[num7]);
				int num9 = array[num7].IndexOf(" ");
				if (num9 > 0)
				{
					array[num7] = array[num7].Substring(0, num9);
				}
				if (array[num7].IndexOf("UNIQUE") == 0)
				{
					break;
				}
				string_0 = (string[])Utils.CopyArray((Array)string_0, (Array)new string[num7 + 1]);
				string_0[num7] = array[num7];
				num7++;
			}
			return method_5((ulong)((struct8_0[num].long_1 - 1L) * unchecked((long)ushort_0)));
		}
	}

	public int method_7()
	{
		return struct7_0.Length;
	}

	public string method_8(int int_0, int int_1)
	{
		if (int_0 >= struct7_0.Length)
		{
			return null;
		}
		if (int_1 >= struct7_0[int_0].string_0.Length)
		{
			return null;
		}
		return struct7_0[int_0].string_0[int_1];
	}

	public string method_9(int int_0, string string_1)
	{
		int num = -1;
		int num2 = string_0.Length;
		int num3 = 0;
		while (true)
		{
			int num4 = num3;
			int num5 = num2;
			if (num4 <= num5)
			{
				if (string_0[num3].ToLower().CompareTo(string_1.ToLower()) != 0)
				{
					num3 = checked(num3 + 1);
					continue;
				}
				num = num3;
				break;
			}
			break;
		}
		if (num == -1)
		{
			return null;
		}
		return method_8(int_0, num);
	}

	public string[] method_10()
	{
		int num = 0;
		checked
		{
			int num2 = struct8_0.Length - 1;
			int num3 = 0;
			string[] array = default(string[]);
			while (true)
			{
				int num4 = num3;
				int num5 = num2;
				if (num4 > num5)
				{
					break;
				}
				if (Operators.CompareString(struct8_0[num3].string_0, "table", false) == 0)
				{
					array = (string[])Utils.CopyArray((Array)array, (Array)new string[num + 1]);
					array[num] = struct8_0[num3].string_1;
					num++;
				}
				num3++;
			}
			return array;
		}
	}
}
