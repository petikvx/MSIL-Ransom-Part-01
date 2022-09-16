using System;
using System.Collections.Generic;

public sealed class GClass91
{
	public string string_0;

	public GClass9 gclass9_0;

	public GClass97 gclass97_0;

	public GClass97 gclass97_1;

	public string string_1;

	public List<string> list_0;

	public int[] int_0;

	public int int_1;

	public int int_2;

	public int[] int_3;

	public List<GClass9> list_1;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public string string_2;

	public int int_8;

	public GClass91()
	{
		string_0 = string.Empty;
		gclass9_0 = null;
		gclass97_0 = null;
		gclass97_1 = null;
		string_1 = Class16.smethod_0(-561793754);
		list_0 = new List<string>();
		int_0 = new int[8];
		int_1 = 1;
		int_2 = 0;
		int_3 = new int[7];
		list_1 = new List<GClass9>();
		int_4 = 0;
		int_5 = 0;
		int_6 = 0;
		int_7 = 0;
		string_2 = string.Empty;
		int_8 = 0;
		string_0 = Class24.gclass4_0.method_4();
		method_0(0, Class24.smethod_0(25, 35));
		method_0(1, Class24.smethod_0(40, 50));
		method_0(2, 0);
		method_0(3, Class24.smethod_0(3, 10));
		method_0(4, Class24.smethod_0(3, 10));
		method_0(5, Class24.smethod_0(0, 5));
		method_0(6, 0);
		method_0(7, Class24.smethod_0(0, 10));
		int_1 = 1;
	}

	public GClass91(bool bool_0)
	{
		string_0 = string.Empty;
		gclass9_0 = null;
		gclass97_0 = null;
		gclass97_1 = null;
		string_1 = Class16.smethod_0(-561793754);
		list_0 = new List<string>();
		int_0 = new int[8];
		int_1 = 1;
		int_2 = 0;
		int_3 = new int[7];
		list_1 = new List<GClass9>();
		int_4 = 0;
		int_5 = 0;
		int_6 = 0;
		int_7 = 0;
		string_2 = string.Empty;
		int_8 = 0;
		string_0 = Class24.gclass4_0.method_4();
		if (bool_0)
		{
			int_1 = Class24.smethod_0(20, 30);
			method_0(0, Class24.smethod_0(35, 45));
			method_0(1, Class24.smethod_0(45, 55));
			method_0(3, Class24.smethod_0(20, 30));
			method_0(4, Class24.smethod_0(20, 30));
			method_0(5, Class24.smethod_0(12, 25));
			method_0(2, Class24.smethod_0(10, 20));
			method_0(6, Class24.smethod_0(0, 5));
			method_0(7, Class24.smethod_0(0, 10));
		}
		else
		{
			int_1 = Class24.smethod_0(1, Class24.int_4);
			method_0(0, Class24.smethod_0(25, 35));
			method_0(1, Class24.smethod_0(40, 50));
			method_0(3, Class24.smethod_0(3, 10));
			method_0(4, Class24.smethod_0(3, 10));
			method_0(5, Class24.smethod_0(0, 5));
			method_0(2, 0);
			method_0(6, 0);
			method_0(7, Class24.smethod_0(0, 5));
		}
	}

	public GClass91(ref GClass91 gclass91_0)
	{
		string_0 = string.Empty;
		gclass9_0 = null;
		gclass97_0 = null;
		gclass97_1 = null;
		string_1 = Class16.smethod_0(-561793754);
		list_0 = new List<string>();
		int_0 = new int[8];
		int_1 = 1;
		int_2 = 0;
		int_3 = new int[7];
		list_1 = new List<GClass9>();
		int_4 = 0;
		int_5 = 0;
		int_6 = 0;
		int_7 = 0;
		string_2 = string.Empty;
		int_8 = 0;
		string_0 = Class24.gclass4_0.method_4();
		int_1 = 1;
		string_1 = gclass91_0.string_0;
		gclass91_0.list_0.Add(string_0);
		gclass97_0 = gclass91_0.gclass97_1;
		checked
		{
			method_0(0, (int)Math.Round((double)Class24.smethod_0(20, 30) + (double)gclass91_0.method_1(0) / 9.0));
			method_0(1, Class24.smethod_0(Math.Min(30, gclass91_0.method_1(1)), 50));
			method_0(2, 0);
			method_0(3, Class24.smethod_0(3, (int)Math.Round(8.0 + (double)gclass91_0.method_1(3) / 16.5)));
			method_0(4, Class24.smethod_0(3, (int)Math.Round(8.0 + (double)gclass91_0.method_1(4) / 16.5)));
			method_0(5, Class24.smethod_0(0, 5));
			method_0(6, Class24.smethod_0(0, Math.Max(12, gclass91_0.method_1(6))));
			method_0(7, Class24.smethod_0(0, (int)Math.Round(8.0 + (double)gclass91_0.method_1(7) / 6.0)));
		}
	}

	public void method_0(int int_9, int int_10)
	{
		int_0[int_9] = int_10;
	}

	public int method_1(int int_9)
	{
		return int_0[int_9];
	}

	public void method_2(int int_9, int int_10)
	{
		checked
		{
			int_0[int_9] += int_10;
		}
	}

	public void method_3(int int_9, int int_10, string string_3)
	{
		checked
		{
			int_0[int_9] += int_10;
			method_6(Class24.smethod_3(int_9) + Class16.smethod_0(-561793740) + string_3, int_10);
		}
	}

	public void method_4()
	{
		checked
		{
			int num = int_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (int_0[i] > 100)
				{
					int_0[i] = 100;
				}
				else if (int_0[i] < 0)
				{
					int_0[i] = 0;
				}
			}
		}
	}

	public void method_5(string string_3)
	{
		ref string reference = ref string_2;
		reference = reference + string_3 + Class16.smethod_0(-561781492);
	}

	public void method_6(string string_3, int int_9)
	{
		if (int_9 != 0)
		{
			if (int_9 > 0)
			{
				string_2 += Class16.smethod_0(-561793731);
			}
			ref string reference = ref string_2;
			reference = reference + int_9 + Class16.smethod_0(-561781845) + string_3 + Class16.smethod_0(-561781492);
		}
	}

	public void method_7(int int_9)
	{
		GClass9 gClass = Class24.gclass6_0.method_3(int_9);
		gClass.gclass91_0 = this;
		gClass.int_3 = 0;
		gclass97_1.method_22(gClass, gclass97_1.int_2, bool_1: true);
		list_1.Add(gClass);
		checked
		{
			int_4++;
			Class24.gclass90_0.gclass0_12.method_1(method_28() + Class16.smethod_0(-561793723) + gClass.vmethod_4());
			method_5(Class16.smethod_0(-561793705) + gClass.vmethod_4());
		}
	}

	public void method_8()
	{
		GClass63 gClass = new GClass63(-1, 0, 1);
		GClass91 gclass91_ = this;
		gClass.method_25(ref gclass91_);
		gclass91_ = this;
		gClass.method_12(ref gclass91_, bool_0: true);
	}

	public void method_9()
	{
		int num = 0;
		int num2 = gclass97_1.method_2();
		int num3 = gclass97_1.int_7;
		method_5(Class16.smethod_0(-561793688) + gclass97_1.method_18());
		checked
		{
			int_1 += Class24.int_4;
			if (int_1 <= 28)
			{
				method_2(1, 1);
			}
			if (int_1 >= 45)
			{
				double num4 = ((double)int_1 - 50.0) / 10.0;
				if (num4 < 0.0)
				{
					num4 = 0.0;
				}
				num = Class24.smethod_0((int)Math.Round(num4), (int)Math.Round(num4 + 2.0));
				method_3(1, -num, Class16.smethod_0(-561793670));
			}
			if (method_1(1) < 15)
			{
				method_3(1, -1, Class16.smethod_0(-561793658));
				if (method_1(2) == 0)
				{
					num = Class24.smethod_0(0, 3);
					method_3(4, num, Class16.smethod_0(-561793643));
				}
			}
			double num5 = default(double);
			if (method_1(0) >= 70)
			{
				num5 = ((double)method_1(0) - 60.0) / 10.0;
				num = Class24.smethod_0(0, (int)Math.Round(num5));
				method_3(1, num, Class16.smethod_0(-561793621));
			}
			else if (method_1(0) <= 10)
			{
				num = Class24.smethod_0(1, 3);
				method_3(1, -num, Class16.smethod_0(-561793609));
			}
			if (method_1(0) <= 15)
			{
				num = Class24.smethod_0(0, 2);
				method_3(7, num, Class16.smethod_0(-561793593));
			}
			if (method_15())
			{
				int_2 += Class24.int_4;
				if (method_16())
				{
					num = Class24.smethod_0(0, 1);
					method_3(0, num, Class16.smethod_0(-561793570));
				}
				num5 = (double)method_1(3) / 8.0 + (double)method_1(4) / 9.0;
				num = Class24.smethod_0(0, (int)Math.Round(num5));
				method_3(2, num, Class16.smethod_0(-561793550));
				num = Class24.smethod_0(0, 1);
				method_3(7, -num, Class16.smethod_0(-561794039));
			}
			else if (!method_30())
			{
				if (gclass97_1.method_13(103) > 0)
				{
					int_7 += 2;
					GClass9 gClass = gclass97_1.method_15(103)[0];
					gClass.vmethod_32(2);
					gClass.method_17(1);
				}
				else
				{
					num = Class24.smethod_0(0, 3);
					method_3(0, -num, Class16.smethod_0(-561794015));
					num = Class24.smethod_0(0, 3);
					method_3(1, -num, Class16.smethod_0(-561793984));
					num = Class24.smethod_0(0, 2);
					method_3(7, num, Class16.smethod_0(-561793948));
				}
			}
			if (method_1(2) > 50)
			{
				num5 = ((double)method_1(2) - 40.0) / 10.0;
				num = Class24.smethod_0(0, (int)Math.Round(num5));
				method_3(0, num, Class16.smethod_0(-561793917));
			}
			if (int_1 <= 35)
			{
				num = Class24.smethod_0(0, (int)Math.Round(Class24.smethod_1(method_1(3), 15.0)));
				method_3(3, num, Class16.smethod_0(-561793896));
				num = Class24.smethod_0(0, (int)Math.Round(Class24.smethod_1(method_1(4), 15.0)));
				method_3(4, num, Class16.smethod_0(-561793896));
			}
			if (int_1 <= 18)
			{
				num5 = Class24.smethod_0(0, (int)Math.Round((double)num2 / 8.0));
				num = Class24.smethod_0(0, (int)Math.Round(4.0 + num5));
				method_3(3, num, Class16.smethod_0(-561793875));
				num = Class24.smethod_0(0, (int)Math.Round(3.0 + num5));
				method_3(4, num, Class16.smethod_0(-561793875));
			}
			if ((int_1 >= 18) & (int_1 <= 25))
			{
				if ((double)method_1(3) >= 30.0 + (double)num2 / 5.0)
				{
					num = Class24.smethod_0(1, 4);
					method_3(3, num, Class16.smethod_0(-561793854));
					num = Class24.smethod_0(1, 4);
					method_3(4, num, Class16.smethod_0(-561793854));
				}
				else
				{
					num = Class24.smethod_0(0, 2);
					method_3(3, num, Class16.smethod_0(-561793830));
					num = Class24.smethod_0(0, 2);
					method_3(4, num, Class16.smethod_0(-561793830));
				}
			}
			num5 += (double)Class24.smethod_0((int)Math.Round((double)num3 / 2.0), num3);
			if (int_1 <= 19)
			{
				num = Class24.smethod_0(1, 3);
				method_3(5, num, Class16.smethod_0(-561793809));
			}
			else if (int_1 >= 50)
			{
				double num4 = ((double)int_1 - 40.0) / 8.5;
				num = Class24.smethod_0(0, (int)Math.Round(num4));
				method_3(5, -num, Class16.smethod_0(-561793794));
			}
			if (int_1 == 16)
			{
				num = Class24.smethod_0(3, 8);
				method_3(5, num, Class16.smethod_0(-561793266));
			}
			if (method_1(6) >= 10)
			{
				num5 = (double)method_1(6) / 10.0;
				num = Class24.smethod_0(0, (int)Math.Round(num5));
				method_3(6, num, Class16.smethod_0(-561793244));
			}
			if ((method_1(6) >= 2) & (method_1(6) <= 20) & (int_1 >= 10))
			{
				num = Class24.smethod_0(0, 2);
				method_3(0, num, Class16.smethod_0(-561793227));
			}
			if (method_1(6) >= 25)
			{
				double num4 = (double)method_1(6) / 13.0;
				num = Class24.smethod_0(0, (int)Math.Round(num4));
				method_3(1, -num, Class16.smethod_0(-561793203));
			}
			if (method_1(6) >= 30)
			{
				num = Class24.smethod_0(0, 2);
				method_3(0, num, Class16.smethod_0(-561793184));
			}
			if ((method_1(6) >= 40) & (method_1(1) <= 12) & (Class24.smethod_0(0, 100) <= 15))
			{
				method_3(6, -100, Class16.smethod_0(-561793156));
			}
			int num6 = gclass97_1.method_3();
			if (num6 >= 5)
			{
				int num7 = (int)Math.Floor(Class24.smethod_1(num6, 5.0));
				int num8 = num7 - 1;
				for (int i = 0; i <= num8; i++)
				{
					num5 = Class24.smethod_1(num6, 5.0);
					switch (Class24.smethod_0(0, 2))
					{
					case 0:
						num = Class24.smethod_0(0, (int)Math.Round(num5));
						method_3(7, num, Class16.smethod_0(-561793138));
						break;
					case 1:
						num = Class24.smethod_0(0, (int)Math.Round(num5));
						method_3(0, -num, Class16.smethod_0(-561793138));
						break;
					default:
						num = Class24.smethod_0(0, (int)Math.Round(num5));
						method_3(1, -num, Class16.smethod_0(-561793138));
						break;
					}
				}
			}
			switch (gclass97_1.int_6)
			{
			case 1:
				num = Class24.smethod_0(0, 2);
				method_3(4, -num, Class24.smethod_5(gclass97_1.int_6, bool_2: false) + Class16.smethod_0(-561793117));
				break;
			case 2:
				num = Class24.smethod_0(1, 3);
				method_3(0, num, Class24.smethod_5(gclass97_1.int_6, bool_2: false) + Class16.smethod_0(-561793117));
				num = Class24.smethod_0(1, 3);
				method_3(1, num, Class24.smethod_5(gclass97_1.int_6, bool_2: false) + Class16.smethod_0(-561793117));
				break;
			case 3:
				num = Class24.smethod_0(1, 3);
				method_3(4, num, Class24.smethod_5(gclass97_1.int_6, bool_2: false) + Class16.smethod_0(-561793117));
				num = Class24.smethod_0(0, 2);
				method_3(5, -num, Class24.smethod_5(gclass97_1.int_6, bool_2: false) + Class16.smethod_0(-561793117));
				break;
			case 5:
				num = Class24.smethod_0(2, 4);
				method_3(1, -num, Class24.smethod_5(gclass97_1.int_6, bool_2: false) + Class16.smethod_0(-561793117));
				break;
			case 7:
				num = Class24.smethod_0(1, 3);
				method_3(5, num, Class24.smethod_5(gclass97_1.int_6, bool_2: false) + Class16.smethod_0(-561793117));
				break;
			}
			if (gclass97_1.bool_0)
			{
				num = Class24.smethod_0(1, 2);
				method_3(0, num, Class16.smethod_0(-561793105));
			}
			method_4();
			if (method_30())
			{
				return;
			}
			if (Class24.smethod_0(1, 2000) < method_1(3))
			{
				method_7(-1);
			}
			if (!method_16())
			{
				int num9 = method_1(4);
				if (method_15())
				{
					num9 = (int)Math.Round((double)num9 * 2.0);
				}
				if (Class24.smethod_0(1, 1000) < num9)
				{
					method_8();
				}
			}
		}
	}

	public bool method_10(double double_0)
	{
		if ((int_1 >= 16) & (int_1 <= 49) & (method_1(1) > 15) & (method_1(1) > 10))
		{
			double num = 0.0;
			num += 25.0 - Math.Abs(25.0 - (double)int_1);
			num += (double)method_1(1) / 7.0;
			num += (double)method_1(0) / 10.0;
			num += Math.Min(5.0, (double)method_1(6) / 6.0);
			num += (double)method_1(2) / 20.0;
			num *= double_0;
			if ((double)Class24.smethod_0(0, 100) <= num)
			{
				return true;
			}
			return false;
		}
		bool result = default(bool);
		return result;
	}

	public GClass91 method_11()
	{
		GClass91 gclass91_ = this;
		GClass91 gClass = new GClass91(ref gclass91_);
		gClass.gclass97_0 = gclass97_1;
		gClass.gclass97_1 = gclass97_1;
		gclass97_1.list_0.Add(gClass);
		method_5(Class16.smethod_0(-561793086) + gClass.string_0);
		return gClass;
	}

	public double method_12(int int_9)
	{
		double num = 0.0;
		checked
		{
			switch (int_9)
			{
			case 0:
				_ = int_1 - Class24.list_0[gclass97_1.int_2].int_17;
				num += ((double)int_1 - 20.0) / 4.0;
				break;
			case 1:
				num = (32.0 - (double)method_1(1)) / 4.0;
				break;
			case 2:
			{
				GClass97 gClass = gclass97_1;
				num = 0.0;
				num += (double)method_1(5) / 10.0;
				num += (double)method_1(6) / 4.0;
				num += (double)gClass.method_2() / 5.0;
				num -= (double)gClass.int_7 * 2.5;
				if (int_1 < 15)
				{
					num /= 2.0;
				}
				break;
			}
			}
			return num;
		}
	}

	public bool method_13(int int_9)
	{
		if ((double)Class24.smethod_0(1, 100) < method_12(int_9))
		{
			return true;
		}
		return int_9 switch
		{
			_ => false, 
		};
	}

	public bool method_14(int int_9)
	{
		if (gclass9_0 != null)
		{
			gclass9_0.list_1.Remove(this);
		}
		gclass97_1.list_2.Add(int_1);
		checked
		{
			gclass97_1.int_11[int_9]++;
			gclass97_1.list_0.Remove(this);
			switch (int_9)
			{
			case 0:
				method_5(Class16.smethod_0(-561793503));
				Class24.gclass90_0.gclass0_4.method_0(method_28() + Class16.smethod_0(-561793043) + int_1 + Class16.smethod_0(-561793474));
				break;
			case 1:
				method_5(Class16.smethod_0(-561793065));
				Class24.gclass90_0.gclass0_5.method_0(method_28() + Class16.smethod_0(-561793043) + int_1 + Class16.smethod_0(-561793030));
				break;
			case 2:
				method_5(Class16.smethod_0(-561793443));
				Class24.gclass90_0.gclass0_6.method_0(method_28() + Class16.smethod_0(-561793043) + int_1 + Class16.smethod_0(-561793412));
				break;
			case 3:
				method_5(Class16.smethod_0(-561793518));
				break;
			case 4:
				method_5(Class16.smethod_0(-561793381));
				break;
			case 5:
				method_5(Class16.smethod_0(-561793353));
				break;
			case 6:
				method_5(Class16.smethod_0(-561793320));
				break;
			}
			return true;
		}
	}

	public bool method_15()
	{
		return gclass9_0 != null;
	}

	public bool method_16()
	{
		if (gclass9_0 == null)
		{
			return false;
		}
		return gclass9_0.int_0 == -2;
	}

	public bool method_17(ref GClass9 gclass9_1)
	{
		if (method_15())
		{
			if ((int_2 <= Class24.int_4) | (gclass9_1.vmethod_7() <= gclass9_0.vmethod_7()))
			{
				return false;
			}
			if (Class24.smethod_0(1, 100) <= 85)
			{
				return false;
			}
		}
		return true;
	}

	public void method_18()
	{
		int_2 = 0;
		method_2(2, 1);
		method_3(0, 3, Class16.smethod_0(-561793291));
		if (method_16())
		{
			method_5(gclass9_0.vmethod_5());
		}
		else
		{
			method_5(Class16.smethod_0(-561794813) + gclass9_0.method_6());
		}
		if (int_1 <= 16)
		{
			int int_ = Class24.smethod_0(3, 4);
			method_3(5, int_, Class16.smethod_0(-561794793));
		}
	}

	public void method_19()
	{
		method_5(Class16.smethod_0(-561794764) + method_28());
		if (Class24.smethod_0(0, 1) == 0)
		{
			method_3(0, -1, Class16.smethod_0(-561794725));
		}
		else
		{
			method_3(6, 1, Class16.smethod_0(-561794725));
		}
	}

	public void method_20()
	{
		if (gclass9_0 != null && !method_16())
		{
			gclass9_0.list_1.Remove(this);
			method_5(Class16.smethod_0(-561794697) + gclass9_0.method_6());
			gclass9_0 = null;
		}
	}

	public double method_21(int int_9)
	{
		double num = 0.0;
		checked
		{
			switch (int_9)
			{
			case 0:
				num += (double)method_1(7) / 10.0;
				break;
			case 1:
				num += (double)method_1(7) / 8.0;
				num += (double)method_1(6) / 4.0;
				num += (double)method_1(5) / 9.0;
				break;
			case 2:
				num += (double)method_1(7) / 3.0;
				num -= (double)method_1(2) / 5.0;
				break;
			case 3:
				num += (double)method_1(7) / 12.0;
				if (method_29(8, 22))
				{
					num += (double)gclass97_1.method_30(8, 22);
				}
				break;
			case 4:
				num += (double)method_1(7) / 8.0;
				num -= (double)(method_1(0) - 20) / 10.0;
				num += (double)(gclass97_1.method_4() - 2);
				break;
			case 5:
				num += (double)method_1(7) / 6.5;
				num += (double)method_1(6) / 9.0;
				break;
			}
			return num;
		}
	}

	public bool method_22(int int_9, int int_10)
	{
		int num = 16;
		int num2 = 100;
		switch (int_9)
		{
		case 1:
			num2 = 200;
			break;
		case 3:
			num = 8;
			if (gclass97_1.list_1.Count == 0)
			{
				return false;
			}
			break;
		case 4:
			if ((gclass97_1.list_1.Count == 0) | (Class24.smethod_0(0, 9) > int_10))
			{
				return false;
			}
			num2 = 150;
			break;
		case 5:
			if (gclass97_1.list_0.Count < 2)
			{
				return false;
			}
			break;
		}
		if (int_1 < num)
		{
			return false;
		}
		if ((double)Class24.smethod_0(1, num2) < method_21(int_9))
		{
			return true;
		}
		return false;
	}

	public bool method_23(int int_9, string string_3)
	{
		checked
		{
			int_3[int_9]++;
			switch (int_9)
			{
			case 0:
				int_6++;
				method_5(Class16.smethod_0(-561794675));
				break;
			case 1:
				int_6 += 2;
				method_5(Class16.smethod_0(-561794643));
				break;
			case 2:
				method_5(Class16.smethod_0(-561794611) + string_3);
				Class24.gclass90_0.gclass0_15.method_0(method_28() + Class16.smethod_0(-561794597) + string_3);
				break;
			case 3:
				method_5(Class16.smethod_0(-561794582) + string_3);
				Class24.gclass90_0.gclass0_17.method_0(string_0 + Class16.smethod_0(-561795072) + string_3);
				break;
			case 4:
				method_5(Class16.smethod_0(-561795049) + string_3);
				Class24.gclass90_0.gclass0_16.method_0(string_0 + Class16.smethod_0(-561795026) + string_3);
				break;
			case 5:
				method_5(Class16.smethod_0(-561795002) + string_3);
				Class24.gclass90_0.gclass0_18.method_0(string_0 + Class16.smethod_0(-561794988) + string_3);
				if (Class24.smethod_0(0, 2) == 0)
				{
					method_3(7, Class24.smethod_0(4, 10), Class16.smethod_0(-561794973));
				}
				else
				{
					method_2(7, Class24.smethod_0(0, 3));
				}
				break;
			case 6:
				method_5(Class16.smethod_0(-561794953));
				break;
			}
			return true;
		}
	}

	public int method_24()
	{
		int result = int_6;
		int_6 = 0;
		return result;
	}

	public int method_25()
	{
		int result = int_7;
		int_7 = 0;
		return result;
	}

	public bool method_26(ref GClass97 gclass97_2)
	{
		int num = 0;
		checked
		{
			if (gclass97_2.int_6 == 7)
			{
				num++;
			}
			num += gclass97_2.method_14(4);
			if (num == 0)
			{
				return true;
			}
			double num2 = Class24.smethod_1(100.0, num + 1);
			return (double)Class24.smethod_0(1, 100) < num2;
		}
	}

	public bool method_27(ref GClass97 gclass97_2)
	{
		int num = gclass97_2.method_14(4);
		double num2 = checked(100 - 10 * num);
		return (double)Class24.smethod_0(1, 100) < num2;
	}

	public string method_28()
	{
		return string_0.ToString() + Class16.smethod_0(-561794923) + gclass97_1.method_18();
	}

	public bool method_29(int int_9, int int_10)
	{
		return (int_9 <= int_1) & (int_1 <= int_10);
	}

	public bool method_30()
	{
		return int_1 < 16;
	}

	public bool method_31()
	{
		return int_1 >= 55;
	}

	public double method_32()
	{
		int num = 0;
		checked
		{
			num = (int)Math.Round(0.0);
			num++;
			num = (int)Math.Round((double)num + 3.6);
			num += 3;
			num += 4;
			num = (int)Math.Round((double)num + 2.5);
			num = (int)Math.Round((double)num - 14.0);
			num = (int)Math.Round((double)num - 7.800000000000001);
			num = (int)Math.Round(Class24.smethod_1(num, 180.0));
			if (num > 0)
			{
				num = (int)Math.Round(Math.Pow(num, 1.6));
			}
			double result = default(double);
			return result;
		}
	}

	public string method_33(int int_9)
	{
		return Class24.smethod_3(int_9) + Class16.smethod_0(-561793740) + method_1(int_9) + Class16.smethod_0(-561781492);
	}

	public string method_34(int int_9)
	{
		return Class24.smethod_4(int_9) + Class16.smethod_0(-561793740) + int_3[int_9] + Class16.smethod_0(-561781492);
	}

	public override string ToString()
	{
		string empty = string.Empty;
		empty = empty + Class16.smethod_0(-561794912) + string_0.ToString() + Class16.smethod_0(-561781492);
		if (gclass97_0 != null)
		{
			empty = empty + Class16.smethod_0(-561794899) + gclass97_0.method_18() + Class16.smethod_0(-561781492);
		}
		if (gclass97_1 != null)
		{
			empty = empty + Class16.smethod_0(-561794880) + gclass97_1.method_18() + Class16.smethod_0(-561781492);
		}
		empty = empty + Class16.smethod_0(-561782584) + int_1 + Class16.smethod_0(-561781492);
		checked
		{
			int num = int_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				empty += method_33(i);
			}
			empty += Class16.smethod_0(-561781492);
			string text = string.Empty;
			if (method_30())
			{
				text += Class16.smethod_0(-561794862);
			}
			if (gclass9_0 == null)
			{
				if (!method_30())
				{
					text += Class16.smethod_0(-561794847);
				}
			}
			else
			{
				text = text + gclass9_0.vmethod_5() + Class16.smethod_0(-561794817);
			}
			if (text.Length > 0)
			{
				empty = empty + text + Class16.smethod_0(-561781492);
			}
			if ((string_1.Length > 0) | (list_0.Count > 0))
			{
				if (string_1.Length > 0)
				{
					empty = empty + Class16.smethod_0(-561794295) + string_1 + Class16.smethod_0(-561781492);
				}
				if (list_0.Count > 0)
				{
					empty += Class16.smethod_0(-561794280);
					int num2 = list_0.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						empty += list_0[j];
						empty = ((j != list_0.Count - 1) ? (empty + Class16.smethod_0(-561781432)) : (empty + Class16.smethod_0(-561781492)));
					}
				}
				empty += Class16.smethod_0(-561781492);
			}
			string text2 = string.Empty;
			int num3 = 0;
			do
			{
				if (int_3[num3] > 0)
				{
					text2 += method_34(num3).ToString();
				}
				num3++;
			}
			while (num3 <= 6);
			if (text2.Length > 0)
			{
				empty = empty + text2 + Class16.smethod_0(-561781492);
			}
			if ((gclass97_1.method_13(31) > 0) | Class24.bool_0)
			{
				empty = empty + string_2 + Class16.smethod_0(-561781492);
			}
			return empty;
		}
	}
}
