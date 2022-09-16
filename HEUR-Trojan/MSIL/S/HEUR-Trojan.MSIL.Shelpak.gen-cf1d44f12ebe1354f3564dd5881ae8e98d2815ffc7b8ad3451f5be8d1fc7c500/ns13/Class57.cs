using System;
using System.IO;
using System.Text;

namespace ns13;

internal class Class57
{
	private struct Struct7
	{
		public long long_0;

		public long long_1;
	}

	private struct Struct8
	{
		public string[] string_0;
	}

	private struct Struct9
	{
		public string string_0;

		public long long_0;

		public string string_1;
	}

	private readonly byte[] byte_0 = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };

	private readonly ulong ulong_0;

	private readonly byte[] byte_1;

	private readonly ulong ulong_1;

	private string[] string_0;

	private Struct9[] struct9_0;

	private Struct8[] struct8_0;

	public Class57(string string_1)
	{
		byte_1 = File.ReadAllBytes(string_1);
		ulong_1 = method_5(16, 2);
		ulong_0 = method_5(56, 4);
		method_3(100L);
	}

	public string method_0(int int_0, int int_1)
	{
		try
		{
			if (int_0 >= struct8_0.Length)
			{
				return null;
			}
			return (int_1 >= struct8_0[int_0].string_0.Length) ? null : struct8_0[int_0].string_0[int_1];
		}
		catch
		{
			return "";
		}
	}

	public int method_1()
	{
		return struct8_0.Length;
	}

	private bool method_2(ulong ulong_2)
	{
		try
		{
			if (byte_1[ulong_2] == 13)
			{
				uint num = (uint)(method_5((int)ulong_2 + 3, 2) - 1L);
				int num2 = 0;
				if (struct8_0 != null)
				{
					num2 = struct8_0.Length;
					Array.Resize(ref struct8_0, struct8_0.Length + (int)num + 1);
				}
				else
				{
					struct8_0 = new Struct8[num + 1];
				}
				for (uint num3 = 0u; (int)num3 <= (int)num; num3++)
				{
					ulong num4 = method_5((int)ulong_2 + 8 + (int)(num3 * 2), 2);
					if (ulong_2 != 100L)
					{
						num4 += ulong_2;
					}
					int num5 = method_6((int)num4);
					method_7((int)num4, num5);
					int num6 = method_6((int)((long)num4 + ((long)num5 - (long)num4) + 1L));
					method_7((int)((long)num4 + ((long)num5 - (long)num4) + 1L), num6);
					ulong num7 = num4 + (ulong)((long)num6 - (long)num4 + 1L);
					int num8 = method_6((int)num7);
					int num9 = num8;
					long num10 = method_7((int)num7, num8);
					Struct7[] array = null;
					long num11 = (long)num7 - (long)num8 + 1L;
					int num12 = 0;
					while (num11 < num10)
					{
						Array.Resize(ref array, num12 + 1);
						int num13 = num9 + 1;
						num9 = method_6(num13);
						array[num12].long_1 = method_7(num13, num9);
						array[num12].long_0 = ((array[num12].long_1 <= 9L) ? byte_0[array[num12].long_1] : ((!smethod_0(array[num12].long_1)) ? ((array[num12].long_1 - 12L) / 2L) : ((array[num12].long_1 - 13L) / 2L)));
						num11 = num11 + (num9 - num13) + 1L;
						num12++;
					}
					if (array == null)
					{
						continue;
					}
					struct8_0[num2 + (int)num3].string_0 = new string[array.Length];
					int num14 = 0;
					for (int i = 0; i <= array.Length - 1; i++)
					{
						if (array[i].long_1 > 9L)
						{
							if (!smethod_0(array[i].long_1))
							{
								if (ulong_0 == 1L)
								{
									struct8_0[num2 + (int)num3].string_0[i] = Encoding.Default.GetString(byte_1, (int)((long)num7 + num10 + num14), (int)array[i].long_0);
								}
								else if (ulong_0 == 2L)
								{
									struct8_0[num2 + (int)num3].string_0[i] = Encoding.Unicode.GetString(byte_1, (int)((long)num7 + num10 + num14), (int)array[i].long_0);
								}
								else if (ulong_0 == 3L)
								{
									struct8_0[num2 + (int)num3].string_0[i] = Encoding.BigEndianUnicode.GetString(byte_1, (int)((long)num7 + num10 + num14), (int)array[i].long_0);
								}
							}
							else
							{
								struct8_0[num2 + (int)num3].string_0[i] = Encoding.Default.GetString(byte_1, (int)((long)num7 + num10 + num14), (int)array[i].long_0);
							}
						}
						else
						{
							struct8_0[num2 + (int)num3].string_0[i] = Convert.ToString(method_5((int)((long)num7 + num10 + num14), (int)array[i].long_0));
						}
						num14 += (int)array[i].long_0;
					}
				}
			}
			else if (byte_1[ulong_2] == 5)
			{
				uint num15 = (uint)(method_5((int)(ulong_2 + 3L), 2) - 1L);
				for (uint num16 = 0u; (int)num16 <= (int)num15; num16++)
				{
					uint num17 = (uint)method_5((int)ulong_2 + 12 + (int)(num16 * 2), 2);
					method_2((method_5((int)(ulong_2 + num17), 4) - 1L) * ulong_1);
				}
				method_2((method_5((int)(ulong_2 + 8L), 4) - 1L) * ulong_1);
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	private void method_3(long long_0)
	{
		try
		{
			switch (byte_1[long_0])
			{
			case 13:
			{
				ulong num3 = method_5((int)long_0 + 3, 2) - 1L;
				int num4 = 0;
				if (struct9_0 != null)
				{
					num4 = struct9_0.Length;
					Array.Resize(ref struct9_0, struct9_0.Length + (int)num3 + 1);
				}
				else
				{
					checked
					{
						struct9_0 = new Struct9[(ulong)unchecked((long)(num3 + 1L))];
					}
				}
				for (ulong num5 = 0uL; num5 <= num3; num5++)
				{
					ulong num6 = method_5((int)long_0 + 8 + (int)num5 * 2, 2);
					if (long_0 != 100L)
					{
						num6 += (ulong)long_0;
					}
					int num7 = method_6((int)num6);
					method_7((int)num6, num7);
					int num8 = method_6((int)((long)num6 + ((long)num7 - (long)num6) + 1L));
					method_7((int)((long)num6 + ((long)num7 - (long)num6) + 1L), num8);
					ulong num9 = num6 + (ulong)((long)num8 - (long)num6 + 1L);
					int num10 = method_6((int)num9);
					int num11 = num10;
					long num12 = method_7((int)num9, num10);
					long[] array = new long[5];
					for (int j = 0; j <= 4; j++)
					{
						int int_ = num11 + 1;
						num11 = method_6(int_);
						array[j] = method_7(int_, num11);
						array[j] = ((array[j] <= 9L) ? byte_0[array[j]] : ((!smethod_0(array[j])) ? ((array[j] - 12L) / 2L) : ((array[j] - 13L) / 2L)));
					}
					if (ulong_0 == 1L || ulong_0 == 2L)
					{
						if (ulong_0 == 1L)
						{
							struct9_0[num4 + (int)num5].string_0 = Encoding.Default.GetString(byte_1, (int)((long)num9 + num12 + array[0]), (int)array[1]);
						}
						else if (ulong_0 == 2L)
						{
							struct9_0[num4 + (int)num5].string_0 = Encoding.Unicode.GetString(byte_1, (int)((long)num9 + num12 + array[0]), (int)array[1]);
						}
						else if (ulong_0 == 3L)
						{
							struct9_0[num4 + (int)num5].string_0 = Encoding.BigEndianUnicode.GetString(byte_1, (int)((long)num9 + num12 + array[0]), (int)array[1]);
						}
					}
					struct9_0[num4 + (int)num5].long_0 = (long)method_5((int)((long)num9 + num12 + array[0] + array[1] + array[2]), (int)array[3]);
					if (ulong_0 == 1L)
					{
						struct9_0[num4 + (int)num5].string_1 = Encoding.Default.GetString(byte_1, (int)((long)num9 + num12 + array[0] + array[1] + array[2] + array[3]), (int)array[4]);
					}
					else if (ulong_0 == 2L)
					{
						struct9_0[num4 + (int)num5].string_1 = Encoding.Unicode.GetString(byte_1, (int)((long)num9 + num12 + array[0] + array[1] + array[2] + array[3]), (int)array[4]);
					}
					else if (ulong_0 == 3L)
					{
						struct9_0[num4 + (int)num5].string_1 = Encoding.BigEndianUnicode.GetString(byte_1, (int)((long)num9 + num12 + array[0] + array[1] + array[2] + array[3]), (int)array[4]);
					}
				}
				break;
			}
			case 5:
			{
				uint num = (uint)(method_5((int)long_0 + 3, 2) - 1L);
				for (int i = 0; i <= (int)num; i++)
				{
					uint num2 = (uint)method_5((int)long_0 + 12 + i * 2, 2);
					if (long_0 == 100L)
					{
						method_3((long)((method_5((int)num2, 4) - 1L) * ulong_1));
					}
					else
					{
						method_3((long)((method_5((int)(long_0 + num2), 4) - 1L) * ulong_1));
					}
				}
				method_3((long)((method_5((int)long_0 + 8, 4) - 1L) * ulong_1));
				break;
			}
			}
		}
		catch
		{
		}
	}

	public bool method_4(string string_1)
	{
		try
		{
			int num = -1;
			for (int i = 0; i <= struct9_0.Length; i++)
			{
				if (string.Compare(struct9_0[i].string_0.ToLower(), string_1.ToLower(), StringComparison.Ordinal) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return false;
			}
			string[] array = struct9_0[num].string_1.Substring(struct9_0[num].string_1.IndexOf("(", StringComparison.Ordinal) + 1).Split(new char[1] { ',' });
			for (int j = 0; j <= array.Length - 1; j++)
			{
				array[j] = array[j].TrimStart(new char[0]);
				int num2 = array[j].IndexOf(' ');
				if (num2 > 0)
				{
					array[j] = array[j].Substring(0, num2);
				}
				if (array[j].IndexOf("UNIQUE", StringComparison.Ordinal) != 0)
				{
					Array.Resize(ref string_0, j + 1);
					string_0[j] = array[j];
				}
			}
			return method_2((ulong)(struct9_0[num].long_0 - 1L) * ulong_1);
		}
		catch
		{
			return false;
		}
	}

	private ulong method_5(int int_0, int int_1)
	{
		try
		{
			if (int_1 > 8 || int_1 == 0)
			{
				return 0uL;
			}
			ulong num = 0uL;
			for (int i = 0; i <= int_1 - 1; i++)
			{
				num = (num << 8) | byte_1[int_0 + i];
			}
			return num;
		}
		catch
		{
			return 0uL;
		}
	}

	private int method_6(int int_0)
	{
		try
		{
			if (int_0 > byte_1.Length)
			{
				return 0;
			}
			int num = int_0;
			while (true)
			{
				if (num <= int_0 + 8)
				{
					if (num > byte_1.Length - 1)
					{
						break;
					}
					if ((byte_1[num] & 0x80) == 128)
					{
						num++;
						continue;
					}
					return num;
				}
				return int_0 + 8;
			}
			return 0;
		}
		catch
		{
			return 0;
		}
	}

	private long method_7(int int_0, int int_1)
	{
		try
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
				array[0] = (byte)(byte_1[int_0] & 0x7Fu);
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
				array[0] = byte_1[int_1 - 1];
				int_1--;
				num4 = 1;
			}
			for (int i = int_1 - 1; i >= int_0; i += -1)
			{
				if (i - 1 >= int_0)
				{
					array[num4] = (byte)(((byte_1[i] >> num2 - 1) & (255 >> num2)) | (byte_1[i - 1] << num3));
					num2++;
					num4++;
					num3--;
				}
				else if (!flag)
				{
					array[num4] = (byte)((byte_1[i] >> num2 - 1) & (255 >> num2));
				}
			}
			return BitConverter.ToInt64(array, 0);
		}
		catch
		{
			return 0L;
		}
	}

	private static bool smethod_0(long long_0)
	{
		return (long_0 & 1L) == 1L;
	}
}
