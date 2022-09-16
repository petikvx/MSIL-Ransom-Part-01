using System;
using System.Collections.Generic;

public sealed class GClass2
{
	public List<GClass91> list_0;

	public List<GClass97> list_1;

	public List<GClass9> list_2;

	public List<GClass9> list_3;

	public List<GClass9> list_4;

	public int int_0;

	public List<GClass91> list_5;

	public List<GClass9> list_6;

	public bool bool_0;

	public bool bool_1;

	public bool bool_2;

	public int int_1;

	public GClass2(int int_2)
	{
		list_0 = new List<GClass91>();
		list_1 = new List<GClass97>();
		list_2 = new List<GClass9>();
		list_3 = new List<GClass9>();
		list_4 = new List<GClass9>();
		list_5 = new List<GClass91>();
		list_6 = new List<GClass9>();
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		int_1 = 0;
		if (int_2 < 10)
		{
			bool_0 = true;
			bool_2 = true;
		}
		if (int_2 < 15)
		{
			bool_1 = true;
		}
	}

	public void method_0()
	{
		method_10();
		method_9();
		method_1();
		method_2();
		method_5();
		method_7();
		method_6();
		method_8();
		method_14();
	}

	public void method_1()
	{
		checked
		{
			int num = list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass91 gClass = list_0[i];
				gClass.method_9();
			}
		}
	}

	public void method_2()
	{
		checked
		{
			int num = list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass91 gclass91_ = list_0[i];
				GClass97 gclass97_ = gclass91_.gclass97_1;
				double double_ = gclass91_.method_21(1);
				double double_2 = gclass91_.method_21(0);
				List<GClass97> list_ = new List<GClass97>();
				method_22(ref gclass97_, ref gclass91_, ref list_);
				int num2 = list_.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					GClass97 gclass97_2 = list_[j];
					if (gclass91_.method_27(ref gclass97_2))
					{
						gclass97_2.method_48(ref gclass91_);
						method_3(ref gclass91_, ref gclass97_2, double_2, double_);
					}
				}
				method_4(ref gclass91_, ref list_);
			}
		}
	}

	public void method_3(ref GClass91 gclass91_0, ref GClass97 gclass97_0, double double_0, double double_1)
	{
		if ((double)Class24.smethod_0(0, 200) < double_0)
		{
			gclass91_0.method_23(0, string.Empty);
		}
		checked
		{
			int num = gclass97_0.list_1.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if ((double)Class24.smethod_0(0, 200) < double_1)
				{
					gclass91_0.method_23(1, string.Empty);
				}
				GClass9 gClass = gclass97_0.list_1[i];
				gClass.vmethod_14(ref gclass91_0);
				gClass.vmethod_15(ref gclass91_0);
			}
			if (gclass91_0.gclass9_0 != null)
			{
				gclass91_0.gclass9_0.vmethod_14(ref gclass91_0);
			}
		}
	}

	public void method_4(ref GClass91 gclass91_0, ref List<GClass97> list_7)
	{
		GClass97 gclass97_ = gclass91_0.gclass97_1;
		if (!((list_7.Count > 0) & (Class24.smethod_0(0, 1) == 1)))
		{
			return;
		}
		int num = gclass97_.method_2();
		checked
		{
			if (!gclass91_0.method_15() & !gclass91_0.method_30() & (Class24.smethod_0(0, 30 + gclass91_0.method_1(5)) < 50 - num))
			{
				Class24.int_2 = 2;
			}
			else if (Class24.smethod_0(0, 80 + gclass91_0.method_1(5)) < 40 - num)
			{
				Class24.int_2 = 3;
			}
			else
			{
				Class24.int_2 = 1;
			}
			list_7.Sort();
			int index = Class24.smethod_0(0, (int)Math.Round(Class24.smethod_1(list_7.Count - 1, 3.0)));
			GClass97 gclass97_2 = list_7[index];
			if (!((gclass97_.int_0 == gclass97_2.int_0) & (gclass97_.int_1 == gclass97_2.int_1)) && (gclass97_2.method_20(Class24.gclass93_0.int_1) || !(bool_1 | (Class24.smethod_0(0, 100) < gclass91_0.method_1(0)))) && gclass91_0.method_26(ref gclass97_2))
			{
				gclass97_.list_0.Remove(gclass91_0);
				gclass97_2.method_24(gclass91_0);
				gclass91_0.gclass97_1 = gclass97_2;
				string text = gclass97_.method_18();
				string text2 = gclass97_2.method_18();
				gclass91_0.method_5(Class16.smethod_0(-561835566) + text + Class16.smethod_0(-561835548) + text2);
				if (gclass97_2.method_20(Class24.gclass93_0.int_1))
				{
					Class24.gclass90_0.gclass0_7.method_0(gclass91_0.string_0 + Class16.smethod_0(-561794923) + text + Class16.smethod_0(-561835537) + text2);
				}
				else
				{
					Class24.gclass90_0.gclass0_8.method_0(gclass91_0.string_0 + Class16.smethod_0(-561794923) + text + Class16.smethod_0(-561836032) + text2);
				}
			}
		}
	}

	public void method_5()
	{
		double num = Class24.gclass93_0.method_17();
		checked
		{
			int num2 = list_0.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				GClass91 gclass91_ = list_0[i];
				gclass91_.int_8 = 0;
				double num3 = method_20(ref gclass91_);
				double num4 = gclass91_.gclass97_1.method_12();
				double num5 = num * num3 * num4;
				if (gclass91_.method_10(num5))
				{
					GClass91 gClass = gclass91_.method_11();
					list_0.Add(gClass);
					GClass91 gClass2 = null;
					double num6 = 14.0 * num5;
					if ((double)Class24.smethod_0(0, 1000) < num6)
					{
						gClass2 = gclass91_.method_11();
						list_0.Add(gClass2);
					}
					if (gClass2 == null)
					{
						Class24.gclass90_0.gclass0_1.method_0(gclass91_.method_28() + Class16.smethod_0(-561836011) + gClass.string_0);
						continue;
					}
					Class24.gclass90_0.gclass0_2.method_0(gclass91_.method_28() + Class16.smethod_0(-561835989) + gClass.string_0 + Class16.smethod_0(-561835965) + gClass2.string_0);
				}
			}
		}
	}

	public void method_6()
	{
		if (bool_0)
		{
			return;
		}
		checked
		{
			int num = list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass91 gclass91_ = list_0[i];
				if (gclass91_.method_13(0) && !method_19(ref gclass91_, 0) && gclass91_.method_14(0))
				{
					list_5.Add(gclass91_);
				}
				else if (gclass91_.method_13(1) && !method_19(ref gclass91_, 1) && gclass91_.method_14(1))
				{
					list_5.Add(gclass91_);
				}
				else if (gclass91_.method_13(2) && !method_19(ref gclass91_, 2) && gclass91_.method_14(2))
				{
					list_5.Add(gclass91_);
				}
			}
			method_15();
		}
	}

	public void method_7()
	{
		if (bool_2)
		{
			return;
		}
		int int_ = Class24.gclass93_0.method_7();
		int count = list_0.Count;
		checked
		{
			int num = count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass91 gclass91_ = list_0[i];
				bool flag = false;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				if (gclass91_.method_22(2, 0) && !method_21(ref gclass91_, 2))
				{
					int num5 = Math.Max(1, Math.Min(gclass91_.method_1(7), Class24.gclass93_0.int_3));
					if (gclass91_.method_23(2, num5.ToString()))
					{
						flag = true;
						Class24.gclass93_0.int_3 -= num5;
						num2 += num5;
					}
				}
				if (gclass91_.method_22(3, int_))
				{
					GClass97 gclass97_ = gclass91_.gclass97_1;
					GClass9 gClass = gclass97_.list_1[Class24.smethod_0(0, gclass97_.list_1.Count - 1)];
					if (gClass.int_5 > 1 && !method_21(ref gclass91_, 3) && gclass91_.method_23(3, gClass.method_6()))
					{
						flag = true;
						gClass.vmethod_17(1);
						num3 = (int)Math.Round((double)num3 + Class24.smethod_1(gClass.vmethod_7(), 40.0));
					}
				}
				if (gclass91_.method_22(4, int_))
				{
					GClass97 gclass97_2 = gclass91_.gclass97_1;
					GClass9 gClass2 = gclass97_2.list_1[Class24.smethod_0(0, gclass97_2.list_1.Count - 1)];
					if (!method_21(ref gclass91_, 4) && gclass91_.method_23(4, gClass2.method_6()))
					{
						flag = true;
						list_6.Add(gClass2);
						num3 = (int)Math.Round((double)num3 + Class24.smethod_1(gClass2.vmethod_7(), 2.0));
					}
				}
				if (gclass91_.method_22(5, 0))
				{
					GClass97 gclass97_3 = gclass91_.gclass97_1;
					GClass91 gClass3 = gclass91_;
					while (gClass3.Equals(gclass91_))
					{
						gClass3 = gclass97_3.list_0[Class24.smethod_0(0, gclass97_3.list_0.Count - 1)];
					}
					if (!method_21(ref gclass91_, 5) && gClass3.method_14(5) && gclass91_.method_23(5, gClass3.method_28()))
					{
						flag = true;
						gClass3.method_14(3);
						list_5.Add(gClass3);
						num4 = (int)Math.Round((double)num4 + Class24.smethod_1(gClass3.method_1(2), 2.0));
					}
				}
				if (flag)
				{
					List<GClass9> list = gclass91_.gclass97_1.method_15(26);
					if (list.Count > 0)
					{
						int int_2 = (int)Math.Round(Class24.smethod_1(num2 + num3 + num4, 2.0));
						list[0].vmethod_31(int_2);
						list[0].method_17(1);
					}
				}
			}
			method_16();
			method_15();
		}
	}

	public void method_8()
	{
		int num = 5;
		int num2 = 2;
		int num3 = 3;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		checked
		{
			int num7 = list_0.Count - 1;
			for (int i = 0; i <= num7; i++)
			{
				GClass91 gClass = list_0[i];
				gClass.method_4();
				int num8 = 0;
				num8 = ((gClass.int_1 >= 16) ? (num8 + num) : (num8 + num2));
				if (gClass.gclass9_0 != null)
				{
					num8 += num3;
				}
				num6 += gClass.method_24();
				num5 += gClass.method_25();
				if (gClass.gclass97_1.int_6 == 6)
				{
					num8 = (int)Math.Floor((double)num8 * 0.8);
				}
				num4 += num8;
			}
			int num9 = list_2.Count - 1;
			for (int j = 0; j <= num9; j++)
			{
				GClass9 gClass2 = list_2[j];
				num4 += gClass2.vmethod_33();
				num5 += gClass2.vmethod_34();
			}
			double num10 = Class24.gclass93_0.method_18();
			num4 = (int)Math.Round((double)num4 * num10);
			int num11 = list_1.Count - 1;
			for (int k = 0; k <= num11; k++)
			{
				GClass97 gClass3 = list_1[k];
				num5 = ((gClass3.int_6 != 1) ? ((gClass3.int_6 != 5) ? (num5 + 10) : (num5 + 15)) : (num5 + 8));
			}
			if (Class24.gclass93_0.int_7 > 1)
			{
				double num12 = (double)Class24.gclass93_0.int_7 / 10.0;
				double num13 = (double)num4 * num12;
				if ((double)num5 > num13)
				{
					num5 = (int)Math.Round(num13);
				}
			}
			else
			{
				num5 = 0;
			}
			string text = Class16.smethod_0(-561835953);
			if (Class24.gclass93_0.int_0 == 2)
			{
				text = Class16.smethod_0(-561835943);
			}
			Class24.gclass90_0.gclass0_19.method_1(text + Class16.smethod_0(-561835932) + num4 + Class16.smethod_0(-561835913));
			if (num6 > 0)
			{
				Class24.gclass90_0.gclass0_19.method_1(text + Class16.smethod_0(-561835932) + num6 + Class16.smethod_0(-561835897));
			}
			if (num5 > 0)
			{
				Class24.gclass90_0.gclass0_19.method_1(text + Class16.smethod_0(-561835873) + num5 + Class16.smethod_0(-561835858));
			}
			Class24.gclass93_0.int_3 += num4 + num6 - num5;
		}
	}

	public void method_9()
	{
		checked
		{
			int num = list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass91 gClass = list_0[i];
				if (gClass.gclass9_0 != null)
				{
					gClass.gclass9_0.int_6 += gClass.method_1(2);
				}
			}
			int num2 = list_2.Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				GClass9 gClass2 = list_2[j];
				gClass2.vmethod_19(ref list_6);
				gClass2.vmethod_21();
				gClass2.vmethod_18();
			}
			method_16();
		}
	}

	public void method_10()
	{
		method_13();
		method_11();
		method_12();
	}

	public void method_11()
	{
		list_0.Clear();
		int num = 0;
		checked
		{
			do
			{
				int num2 = 0;
				do
				{
					if (Class24.gclass97_0[num, num2].method_20(Class24.gclass93_0.int_1))
					{
						int num3 = Class24.gclass97_0[num, num2].method_2();
						int num4 = num3 - 1;
						for (int i = 0; i <= num4; i++)
						{
							GClass91 gClass = Class24.gclass97_0[num, num2].list_0[i];
							gClass.string_2 = string.Empty;
							list_0.Add(gClass);
						}
					}
					num2++;
				}
				while (num2 <= 11);
				num++;
			}
			while (num <= 11);
		}
	}

	public void method_12()
	{
		list_1.Clear();
		int num = 0;
		checked
		{
			do
			{
				int num2 = 0;
				do
				{
					if (Class24.gclass97_0[num, num2].method_20(Class24.gclass93_0.int_1))
					{
						list_1.Add(Class24.gclass97_0[num, num2]);
					}
					num2++;
				}
				while (num2 <= 11);
				num++;
			}
			while (num <= 11);
		}
	}

	public void method_13()
	{
		int num = 0;
		checked
		{
			do
			{
				int num2 = 0;
				do
				{
					GClass97 gClass = Class24.gclass97_0[num, num2];
					int num3 = gClass.list_1.Count - 1;
					for (int i = 0; i <= num3; i++)
					{
						GClass9 gClass2 = gClass.list_1[i];
						if (gClass2.int_10 == Class24.gclass93_0.int_1)
						{
							gClass2.vmethod_27();
							list_2.Add(gClass2);
						}
						if (gClass2.list_0.Contains(10))
						{
							list_3.Add(gClass2);
						}
						if (gClass2.list_0.Contains(15))
						{
							list_4.Add(gClass2);
						}
					}
					num2++;
				}
				while (num2 <= 11);
				num++;
			}
			while (num <= 11);
		}
	}

	public void method_14()
	{
		method_18();
		method_17();
	}

	public void method_15()
	{
		checked
		{
			int num = list_5.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass91 item = list_5[i];
				list_0.Remove(item);
			}
			list_5.Clear();
		}
	}

	public void method_16()
	{
		checked
		{
			int num = list_6.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass9 gClass = list_6[i];
				gClass.vmethod_35();
			}
			list_6.Clear();
		}
	}

	public void method_17()
	{
		int num = 0;
		checked
		{
			do
			{
				int num2 = 0;
				do
				{
					GClass97 gClass = Class24.gclass97_0[num, num2];
					gClass.method_49();
					num2++;
				}
				while (num2 <= 11);
				num++;
			}
			while (num <= 11);
		}
	}

	public void method_18()
	{
		int num = 0;
		checked
		{
			do
			{
				int num2 = 0;
				do
				{
					GClass97 gClass = Class24.gclass97_0[num, num2];
					int num3 = gClass.list_1.Count - 1;
					for (int i = 0; i <= num3; i++)
					{
						if (gClass.list_1[i].int_10 == Class24.gclass93_0.int_1)
						{
							gClass.list_1[i].vmethod_28();
						}
					}
					num2++;
				}
				while (num2 <= 11);
				num++;
			}
			while (num <= 11);
		}
	}

	public bool method_19(ref GClass91 gclass91_0, int int_2)
	{
		checked
		{
			int num = list_3.Count - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (list_3[num2].vmethod_22(ref gclass91_0, int_2))
					{
						break;
					}
					num2++;
					continue;
				}
				return false;
			}
			Class24.gclass90_0.gclass0_3.method_0(list_3[num2].method_6() + Class16.smethod_0(-561835841) + gclass91_0.method_28());
			return true;
		}
	}

	public double method_20(ref GClass91 gclass91_0)
	{
		double num = 1.0;
		checked
		{
			int num2 = list_3.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				num *= list_3[i].vmethod_24(ref gclass91_0);
			}
			return num;
		}
	}

	public bool method_21(ref GClass91 gclass91_0, int int_2)
	{
		checked
		{
			int num = list_4.Count - 1;
			int num2 = 0;
			int num3;
			while (true)
			{
				if (num2 <= num)
				{
					num3 = list_4[num2].vmethod_23(ref gclass91_0, int_2);
					if (num3 != 0)
					{
						break;
					}
					num2++;
					continue;
				}
				return false;
			}
			string empty = string.Empty;
			empty = empty + gclass91_0.string_0 + Class16.smethod_0(-561834866) + Class24.smethod_4(int_2) + Class16.smethod_0(-561835815) + list_4[num2].vmethod_4();
			if (num3 == 2 && gclass91_0.method_14(4))
			{
				empty += Class16.smethod_0(-561835792);
				list_5.Add(gclass91_0);
			}
			Class24.gclass90_0.gclass0_13.method_0(empty);
			return true;
		}
	}

	public void method_22(ref GClass97 gclass97_0, ref GClass91 gclass91_0, ref List<GClass97> list_7)
	{
		method_17();
		int_1 = 0;
		method_23(ref gclass97_0, ref gclass91_0, gclass91_0.method_1(5));
		int num = 0;
		checked
		{
			do
			{
				int num2 = 0;
				do
				{
					GClass97 gClass = Class24.gclass97_0[num, num2];
					if (gClass.method_19() & (gClass.int_3 > 0))
					{
						list_7.Add(gClass);
					}
					num2++;
				}
				while (num2 <= 11);
				num++;
			}
			while (num <= 11);
			Class24.int_2 = 0;
			list_7.Sort();
		}
	}

	public void method_23(ref GClass97 gclass97_0, ref GClass91 gclass91_0, int int_2)
	{
		if ((gclass97_0.int_3 >= int_2) | !gclass97_0.method_19())
		{
			return;
		}
		gclass97_0.int_3 = int_2;
		gclass97_0.method_46(ref gclass97_0.gclass9_0);
		checked
		{
			int_1++;
			gclass97_0.int_5 = int_1;
			if (gclass97_0.int_4 < 0)
			{
				int num = 5 - Class24.smethod_0(0, gclass97_0.int_7);
				int num2 = 5 - Class24.smethod_0(0, gclass97_0.int_7);
				gclass97_0.int_4 = num * num2;
			}
			int_2 -= gclass97_0.int_4;
			int_2 -= gclass97_0.list_1.Count;
			int_2 = (int)Math.Round((double)int_2 - Class24.smethod_1(gclass97_0.list_0.Count, 4.0));
			if (gclass97_0.int_6 == 3)
			{
				int_2 -= 6;
			}
			int num3 = gclass97_0.list_1.Count - 1;
			for (int i = 0; i <= num3; i++)
			{
				gclass97_0.list_1[i].vmethod_26(ref int_2, ref gclass91_0);
			}
			if (int_2 >= 0)
			{
				List<GClass97> list = gclass97_0.method_42();
				int num4 = list.Count - 1;
				for (int j = 0; j <= num4; j++)
				{
					List<GClass97> list2;
					int index;
					GClass97 gclass97_ = (list2 = list)[index = j];
					method_23(ref gclass97_, ref gclass91_0, int_2);
					list2[index] = gclass97_;
				}
			}
		}
	}
}
