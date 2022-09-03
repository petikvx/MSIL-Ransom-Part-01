using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace SQLiteHandler;

public class SQLiteHandler
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
				return Delegate367.smethod_0(array, 0);
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
					array[num4] = (byte)unchecked(((byte)((uint)byte_0[i] >> (checked(num2 - 1) & 7)) & (255 >> num2)) | (byte)(byte_0[checked(i - 1)] << (num3 & 7)));
					num2++;
					num4++;
					num3--;
				}
				else if (!flag)
				{
					array[num4] = (byte)(unchecked((byte)((uint)byte_0[i] >> (checked(num2 - 1) & 7))) & (255 >> num2));
				}
			}
			return Delegate367.smethod_0(array, 0);
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
			for (int i = 0; i <= num2; i++)
			{
				num = (num << 8) | byte_0[int_0 + i];
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
				ushort num = Delegate373.smethod_0(Delegate370.smethod_1(Delegate368.smethod_0(Delegate372.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(ulong_1), Delegate369.smethod_0(3L))), 2)), 1m));
				int num2 = 0;
				if (struct8_0 != null)
				{
					num2 = struct8_0.Length;
					struct8_0 = (Struct8[])Delegate374.smethod_0(struct8_0, new Struct8[struct8_0.Length + unchecked((int)num) + 1]);
				}
				else
				{
					struct8_0 = new Struct8[unchecked((int)num) + 1];
				}
				int num3 = num;
				for (int i = 0; i <= num3; i++)
				{
					ulong num4 = Delegate372.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(ulong_1), Delegate369.smethod_0(8L)), Delegate375.smethod_0(i * 2))), 2);
					if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_1), Delegate369.smethod_0(100L)) != 0)
					{
						num4 += ulong_1;
					}
					int num5 = Delegate376.smethod_0(this, (int)num4);
					Delegate377.smethod_0(this, (int)num4, num5);
					int num6 = Delegate376.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate370.smethod_1(Delegate375.smethod_0(num5), Delegate368.smethod_0(num4))), 1m)));
					struct8_0[num2 + i].long_0 = Delegate377.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate370.smethod_1(Delegate375.smethod_0(num5), Delegate368.smethod_0(num4))), 1m)), num6);
					num4 = Delegate378.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate370.smethod_1(Delegate375.smethod_0(num6), Delegate368.smethod_0(num4))), 1m));
					num5 = Delegate376.smethod_0(this, (int)num4);
					num6 = num5;
					long long_ = Delegate377.smethod_0(this, (int)num4, num5);
					long[] array = new long[5];
					int num7 = 0;
					do
					{
						num5 = num6 + 1;
						num6 = Delegate376.smethod_0(this, num5);
						array[num7] = Delegate377.smethod_0(this, num5, num6);
						if (array[num7] <= 9L)
						{
							array[num7] = byte_1[(int)array[num7]];
						}
						else if (Delegate379.smethod_0(this, array[num7]))
						{
							array[num7] = (long)Delegate380.smethod_0((double)(array[num7] - 13L) / 2.0);
						}
						else
						{
							array[num7] = (long)Delegate380.smethod_0((double)(array[num7] - 12L) / 2.0);
						}
						num7++;
					}
					while (num7 <= 4);
					if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_0), 1m) == 0)
					{
						struct8_0[num2 + i].string_0 = Delegate381.smethod_0(Delegate100.smethod_1(), byte_0, Delegate371.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(long_))), (int)array[0]);
					}
					else if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_0), Delegate369.smethod_0(2L)) == 0)
					{
						struct8_0[num2 + i].string_0 = Delegate381.smethod_0(Delegate100.smethod_3(), byte_0, Delegate371.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(long_))), (int)array[0]);
					}
					else if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_0), Delegate369.smethod_0(3L)) == 0)
					{
						struct8_0[num2 + i].string_0 = Delegate381.smethod_0(Delegate100.smethod_4(), byte_0, Delegate371.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(long_))), (int)array[0]);
					}
					if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_0), 1m) == 0)
					{
						struct8_0[num2 + i].string_1 = Delegate381.smethod_0(Delegate100.smethod_1(), byte_0, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(long_)), Delegate369.smethod_0(array[0]))), (int)array[1]);
					}
					else if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_0), Delegate369.smethod_0(2L)) == 0)
					{
						struct8_0[num2 + i].string_1 = Delegate381.smethod_0(Delegate100.smethod_3(), byte_0, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(long_)), Delegate369.smethod_0(array[0]))), (int)array[1]);
					}
					else if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_0), Delegate369.smethod_0(3L)) == 0)
					{
						struct8_0[num2 + i].string_1 = Delegate381.smethod_0(Delegate100.smethod_4(), byte_0, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(long_)), Delegate369.smethod_0(array[0]))), (int)array[1]);
					}
					struct8_0[num2 + i].long_1 = (long)Delegate372.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(long_)), Delegate369.smethod_0(array[0])), Delegate369.smethod_0(array[1])), Delegate369.smethod_0(array[2]))), (int)array[3]);
					if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_0), 1m) == 0)
					{
						struct8_0[num2 + i].string_3 = Delegate381.smethod_0(Delegate100.smethod_1(), byte_0, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(long_)), Delegate369.smethod_0(array[0])), Delegate369.smethod_0(array[1])), Delegate369.smethod_0(array[2])), Delegate369.smethod_0(array[3]))), (int)array[4]);
					}
					else if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_0), Delegate369.smethod_0(2L)) == 0)
					{
						struct8_0[num2 + i].string_3 = Delegate381.smethod_0(Delegate100.smethod_3(), byte_0, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(long_)), Delegate369.smethod_0(array[0])), Delegate369.smethod_0(array[1])), Delegate369.smethod_0(array[2])), Delegate369.smethod_0(array[3]))), (int)array[4]);
					}
					else if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_0), Delegate369.smethod_0(3L)) == 0)
					{
						struct8_0[num2 + i].string_3 = Delegate381.smethod_0(Delegate100.smethod_4(), byte_0, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(long_)), Delegate369.smethod_0(array[0])), Delegate369.smethod_0(array[1])), Delegate369.smethod_0(array[2])), Delegate369.smethod_0(array[3]))), (int)array[4]);
					}
				}
			}
			else
			{
				if (byte_0[(int)ulong_1] != 5)
				{
					return;
				}
				ushort num8 = Delegate373.smethod_0(Delegate370.smethod_1(Delegate368.smethod_0(Delegate372.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(ulong_1), Delegate369.smethod_0(3L))), 2)), 1m));
				int num9 = num8;
				for (int j = 0; j <= num9; j++)
				{
					ushort num10 = (ushort)Delegate372.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(ulong_1), Delegate369.smethod_0(12L)), Delegate375.smethod_0(j * 2))), 2);
					if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_1), Delegate369.smethod_0(100L)) == 0)
					{
						Delegate382.smethod_0(this, Delegate378.smethod_0(Delegate370.smethod_2(Delegate370.smethod_1(Delegate368.smethod_0(Delegate372.smethod_0(this, num10, 4)), 1m), Delegate375.smethod_0(ushort_0))));
					}
					else
					{
						Delegate382.smethod_0(this, Delegate378.smethod_0(Delegate370.smethod_2(Delegate370.smethod_1(Delegate368.smethod_0(Delegate372.smethod_0(this, (int)(ulong_1 + num10), 4)), 1m), Delegate375.smethod_0(ushort_0))));
					}
				}
				Delegate382.smethod_0(this, Delegate378.smethod_0(Delegate370.smethod_2(Delegate370.smethod_1(Delegate368.smethod_0(Delegate372.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(ulong_1), Delegate369.smethod_0(8L))), 4)), 1m), Delegate375.smethod_0(ushort_0))));
			}
		}
	}

	private bool method_5(ulong ulong_1)
	{
		checked
		{
			if (byte_0[(int)ulong_1] == 13)
			{
				ushort num = Delegate373.smethod_0(Delegate370.smethod_1(Delegate368.smethod_0(Delegate372.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(ulong_1), Delegate369.smethod_0(3L))), 2)), 1m));
				int num2 = 0;
				if (struct7_0 != null)
				{
					num2 = struct7_0.Length;
					struct7_0 = (Struct7[])Delegate374.smethod_0(struct7_0, new Struct7[struct7_0.Length + unchecked((int)num) + 1]);
				}
				else
				{
					struct7_0 = new Struct7[unchecked((int)num) + 1];
				}
				int num3 = num;
				Struct6[] array = default(Struct6[]);
				for (int i = 0; i <= num3; i++)
				{
					ulong num4 = Delegate372.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(ulong_1), Delegate369.smethod_0(8L)), Delegate375.smethod_0(i * 2))), 2);
					if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_1), Delegate369.smethod_0(100L)) != 0)
					{
						num4 += ulong_1;
					}
					int num5 = Delegate376.smethod_0(this, (int)num4);
					Delegate377.smethod_0(this, (int)num4, num5);
					int num6 = Delegate376.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate370.smethod_1(Delegate375.smethod_0(num5), Delegate368.smethod_0(num4))), 1m)));
					struct7_0[num2 + i].long_0 = Delegate377.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate370.smethod_1(Delegate375.smethod_0(num5), Delegate368.smethod_0(num4))), 1m)), num6);
					num4 = Delegate378.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate370.smethod_1(Delegate375.smethod_0(num6), Delegate368.smethod_0(num4))), 1m));
					num5 = Delegate376.smethod_0(this, (int)num4);
					num6 = num5;
					long num7 = Delegate377.smethod_0(this, (int)num4, num5);
					long num8 = Delegate383.smethod_0(Delegate370.smethod_0(Delegate370.smethod_1(Delegate368.smethod_0(num4), Delegate375.smethod_0(num5)), 1m));
					int num9 = 0;
					while (num8 < num7)
					{
						array = (Struct6[])Delegate374.smethod_0(array, new Struct6[num9 + 1]);
						num5 = num6 + 1;
						num6 = Delegate376.smethod_0(this, num5);
						array[num9].long_1 = Delegate377.smethod_0(this, num5, num6);
						if (array[num9].long_1 > 9L)
						{
							if (Delegate379.smethod_0(this, array[num9].long_1))
							{
								array[num9].long_0 = (long)Delegate380.smethod_0((double)(array[num9].long_1 - 13L) / 2.0);
							}
							else
							{
								array[num9].long_0 = (long)Delegate380.smethod_0((double)(array[num9].long_1 - 12L) / 2.0);
							}
						}
						else
						{
							array[num9].long_0 = byte_1[(int)array[num9].long_1];
						}
						num8 = num8 + (num6 - num5) + 1L;
						num9++;
					}
					struct7_0[num2 + i].string_0 = new string[array.Length - 1 + 1];
					int num10 = 0;
					int num11 = array.Length - 1;
					for (int j = 0; j <= num11; j++)
					{
						if (array[j].long_1 > 9L)
						{
							if (!Delegate379.smethod_0(this, array[j].long_1))
							{
								if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_0), 1m) == 0)
								{
									struct7_0[num2 + i].string_0[j] = Delegate381.smethod_0(Delegate100.smethod_1(), byte_0, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(num7)), Delegate375.smethod_0(num10))), (int)array[j].long_0);
								}
								else if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_0), Delegate369.smethod_0(2L)) == 0)
								{
									struct7_0[num2 + i].string_0[j] = Delegate381.smethod_0(Delegate100.smethod_3(), byte_0, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(num7)), Delegate375.smethod_0(num10))), (int)array[j].long_0);
								}
								else if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_0), Delegate369.smethod_0(3L)) == 0)
								{
									struct7_0[num2 + i].string_0[j] = Delegate381.smethod_0(Delegate100.smethod_4(), byte_0, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(num7)), Delegate375.smethod_0(num10))), (int)array[j].long_0);
								}
							}
							else
							{
								struct7_0[num2 + i].string_0[j] = Delegate381.smethod_0(Delegate100.smethod_1(), byte_0, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(num7)), Delegate375.smethod_0(num10))), (int)array[j].long_0);
							}
						}
						else
						{
							struct7_0[num2 + i].string_0[j] = Delegate384.smethod_0(Delegate372.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(num4), Delegate369.smethod_0(num7)), Delegate375.smethod_0(num10))), (int)array[j].long_0));
						}
						num10 = (int)(num10 + array[j].long_0);
					}
				}
			}
			else if (byte_0[(int)ulong_1] == 5)
			{
				ushort num12 = Delegate373.smethod_0(Delegate370.smethod_1(Delegate368.smethod_0(Delegate372.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(ulong_1), Delegate369.smethod_0(3L))), 2)), 1m));
				int num13 = num12;
				for (int k = 0; k <= num13; k++)
				{
					ushort num14 = (ushort)Delegate372.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(ulong_1), Delegate369.smethod_0(12L)), Delegate375.smethod_0(k * 2))), 2);
					Delegate385.smethod_0(this, Delegate378.smethod_0(Delegate370.smethod_2(Delegate370.smethod_1(Delegate368.smethod_0(Delegate372.smethod_0(this, (int)(ulong_1 + num14), 4)), 1m), Delegate375.smethod_0(ushort_0))));
				}
				Delegate385.smethod_0(this, Delegate378.smethod_0(Delegate370.smethod_2(Delegate370.smethod_1(Delegate368.smethod_0(Delegate372.smethod_0(this, Delegate371.smethod_0(Delegate370.smethod_0(Delegate368.smethod_0(ulong_1), Delegate369.smethod_0(8L))), 4)), 1m), Delegate375.smethod_0(ushort_0))));
			}
			return true;
		}
	}

	public bool ReadTable(string string_1)
	{
		int num = -1;
		int num2 = struct8_0.Length;
		checked
		{
			for (int i = 0; i <= num2; i++)
			{
				if (Delegate386.smethod_0(Delegate133.smethod_1(struct8_0[i].string_1), Delegate133.smethod_1(string_1)) == 0)
				{
					num = i;
					break;
				}
			}
			if (num == -1)
			{
				return false;
			}
			string[] array = Delegate77.smethod_0(Delegate387.smethod_0(struct8_0[num].string_3, Delegate297.smethod_0(struct8_0[num].string_3, (string)_003CModule_003E.smethod_0(522493389u)) + 1), new char[1] { ',' });
			int num3 = array.Length - 1;
			for (int j = 0; j <= num3; j++)
			{
				array[j] = Delegate59.smethod_7(array[j]);
				int num4 = Delegate297.smethod_0(array[j], (string)_003CModule_003E.smethod_0(522488065u));
				if (num4 > 0)
				{
					array[j] = Delegate89.smethod_0(array[j], 0, num4);
				}
				if (Delegate297.smethod_0(array[j], (string)_003CModule_003E.smethod_0(522493383u)) == 0)
				{
					break;
				}
				string_0 = (string[])Delegate374.smethod_0(string_0, new string[j + 1]);
				string_0[j] = array[j];
			}
			return Delegate385.smethod_0(this, (ulong)((struct8_0[num].long_1 - 1L) * unchecked((long)ushort_0)));
		}
	}

	public int GetRowCount()
	{
		return struct7_0.Length;
	}

	public string GetValue(int int_0, int int_1)
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

	public string GetValue(int int_0, string string_1)
	{
		int num = -1;
		int num2 = string_0.Length;
		for (int i = 0; i <= num2; i = checked(i + 1))
		{
			if (Delegate386.smethod_0(Delegate133.smethod_1(string_0[i]), Delegate133.smethod_1(string_1)) == 0)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return null;
		}
		return Delegate388.smethod_0(this, int_0, num);
	}

	public string[] GetTableNames()
	{
		int num = 0;
		checked
		{
			int num2 = struct8_0.Length - 1;
			string[] array = default(string[]);
			for (int i = 0; i <= num2; i++)
			{
				if (Delegate389.smethod_0(struct8_0[i].string_0, (string)_003CModule_003E.smethod_0(1852868418u), bool_0: false) == 0)
				{
					array = (string[])Delegate374.smethod_0(array, new string[num + 1]);
					array[num] = struct8_0[i].string_1;
					num++;
				}
			}
			return array;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public SQLiteHandler(string string_1)
	{
		byte_1 = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };
		checked
		{
			if (Delegate175.smethod_1(string_1))
			{
				Delegate390.smethod_0(1, string_1, (OpenMode)32, (OpenAccess)1, (OpenShare)3, -1);
				string text = Delegate103.smethod_1((int)Delegate391.smethod_0(1));
				Delegate392.smethod_0(1, ref text, -1L, bool_0: false);
				Delegate393.smethod_0(new int[1] { 1 });
				byte_0 = Delegate101.smethod_0(Delegate100.smethod_1(), text);
				if (Delegate386.smethod_0(Delegate381.smethod_0(Delegate100.smethod_1(), byte_0, 0, 15), (string)_003CModule_003E.smethod_0(804253401u)) != 0)
				{
					throw Delegate394.smethod_0((string)_003CModule_003E.smethod_0(804253365u));
				}
				if (byte_0[52] != 0)
				{
					throw Delegate394.smethod_0((string)_003CModule_003E.smethod_0(804253342u));
				}
				if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(Delegate372.smethod_0(this, 44, 4)), Delegate369.smethod_0(4L)) >= 0)
				{
					throw Delegate394.smethod_0((string)_003CModule_003E.smethod_0(804253292u));
				}
				ushort_0 = (ushort)Delegate372.smethod_0(this, 16, 2);
				ulong_0 = Delegate372.smethod_0(this, 56, 4);
				if (㓯栽紬_2F78嬼勮䫚㹏.smethod_0(Delegate368.smethod_0(ulong_0), 0m) == 0)
				{
					ulong_0 = 1uL;
				}
				Delegate382.smethod_0(this, 100uL);
			}
		}
	}
}
