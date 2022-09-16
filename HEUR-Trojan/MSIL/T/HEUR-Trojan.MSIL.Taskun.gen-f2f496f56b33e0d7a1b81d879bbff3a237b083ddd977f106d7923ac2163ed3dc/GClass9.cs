using System;
using System.Collections.Generic;

public class GClass9
{
	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public string string_0;

	public string string_1;

	public List<int> list_0;

	public string string_2;

	public int int_10;

	public GClass97 gclass97_0;

	public List<GClass91> list_1;

	public GClass91 gclass91_0;

	public List<GClass93> list_2;

	public int int_11;

	public int[] int_12;

	public int[] int_13;

	public int int_14;

	public int int_15;

	public int int_16;

	public int int_17;

	public int int_18;

	public int int_19;

	public int int_20;

	public int int_21;

	public GClass9()
	{
		int_0 = -1;
		int_1 = 0;
		int_2 = 0;
		int_3 = 0;
		int_4 = -1;
		int_5 = 0;
		int_6 = 0;
		int_7 = 0;
		int_8 = 0;
		int_9 = 1;
		string_0 = string.Empty;
		string_1 = string.Empty;
		list_0 = new List<int>();
		string_2 = Class16.smethod_0(-561782355);
		int_10 = -1;
		gclass97_0 = null;
		list_1 = new List<GClass91>();
		gclass91_0 = null;
		list_2 = new List<GClass93>();
		int_11 = 16;
		int_12 = new int[8];
		int_13 = new int[8];
		int_14 = 0;
		int_15 = 0;
		int_16 = 0;
		int_17 = 0;
		int_18 = 0;
		int_19 = 0;
		int_20 = 0;
		int_21 = 0;
	}

	public GClass9(int int_22, int int_23, int int_24, int int_25 = 16)
	{
		int_0 = -1;
		int_1 = 0;
		int_2 = 0;
		int_3 = 0;
		int_4 = -1;
		int_5 = 0;
		int_6 = 0;
		int_7 = 0;
		int_8 = 0;
		int_9 = 1;
		string_0 = string.Empty;
		string_1 = string.Empty;
		list_0 = new List<int>();
		string_2 = Class16.smethod_0(-561782355);
		int_10 = -1;
		gclass97_0 = null;
		list_1 = new List<GClass91>();
		gclass91_0 = null;
		list_2 = new List<GClass93>();
		int_11 = 16;
		int_12 = new int[8];
		int_13 = new int[8];
		int_14 = 0;
		int_15 = 0;
		int_16 = 0;
		int_17 = 0;
		int_18 = 0;
		int_19 = 0;
		int_20 = 0;
		int_21 = 0;
		int_0 = int_22;
		int_1 = int_23;
		int_11 = int_25;
		int_2 = int_1;
		int_3 = int_1;
		int_5 = int_24;
	}

	public void method_0(int int_22, int int_23, int int_24)
	{
		int_12[int_22] = int_23;
		int_13[int_22] = int_24;
	}

	public void method_1(int int_22)
	{
		int_8 = int_22;
	}

	public void method_2(string string_3)
	{
		string_0 = string_3 + Class16.smethod_0(-561781492);
	}

	public void method_3(int int_22)
	{
		int_11 = int_22;
	}

	public void method_4(string string_3)
	{
		string_1 = string_3 + Class16.smethod_0(-561781492);
	}

	public virtual void vmethod_0(int int_22, double double_0, bool bool_0)
	{
		checked
		{
			if (bool_0)
			{
				ref int reference = ref int_12[int_22];
				reference = (int)Math.Round((double)reference * double_0);
			}
			else
			{
				ref int reference2 = ref int_12[int_22];
				reference2 = (int)Math.Round((double)reference2 + double_0);
			}
		}
	}

	public virtual void vmethod_1(int int_22, double double_0, bool bool_0)
	{
		checked
		{
			if (bool_0)
			{
				ref int reference = ref int_13[int_22];
				reference = (int)Math.Round((double)reference * double_0);
			}
			else
			{
				ref int reference2 = ref int_13[int_22];
				reference2 = (int)Math.Round((double)reference2 + double_0);
			}
		}
	}

	public virtual void vmethod_2(double double_0, bool bool_0)
	{
		int num = 0;
		do
		{
			vmethod_0(num, double_0, bool_0);
			num = checked(num + 1);
		}
		while (num <= 7);
	}

	public virtual void vmethod_3(double double_0, bool bool_0)
	{
		int num = 0;
		do
		{
			vmethod_1(num, double_0, bool_0);
			num = checked(num + 1);
		}
		while (num <= 7);
	}

	public void method_5(int int_22)
	{
		int_2 = int_22;
		int_3 = int_22;
	}

	public virtual string vmethod_4()
	{
		return Class24.gclass6_0.method_0(int_0);
	}

	public string method_6()
	{
		return vmethod_4() + Class16.smethod_0(-561782333) + gclass97_0.method_18();
	}

	public virtual string vmethod_5()
	{
		return Class16.smethod_0(-561782322) + method_6();
	}

	public int method_7()
	{
		return list_1.Count;
	}

	public virtual string vmethod_6()
	{
		return string_1.Trim();
	}

	public virtual int vmethod_7()
	{
		return int_1;
	}

	public virtual int vmethod_8()
	{
		return int_2;
	}

	public virtual int vmethod_9()
	{
		return int_3;
	}

	public virtual int vmethod_10()
	{
		return int_8;
	}

	public virtual int vmethod_11(int int_22)
	{
		return int_12[int_22];
	}

	public virtual int vmethod_12(int int_22)
	{
		return int_13[int_22];
	}

	public void method_8(int int_22)
	{
		list_0.Add(int_22);
	}

	public void method_9(int int_22)
	{
		list_0.Remove(int_22);
	}

	public bool method_10(int int_22)
	{
		return list_0.Contains(int_22);
	}

	public int method_11(int int_22)
	{
		if (int_22 < 0)
		{
			return Class24.smethod_0(int_22, -1);
		}
		return Class24.smethod_0(1, int_22);
	}

	public virtual void vmethod_13(int int_22, ref GClass91 gclass91_1)
	{
		if (vmethod_11(int_22) > 0 && Class24.smethod_0(0, 100) <= vmethod_11(int_22))
		{
			int num = method_11(vmethod_12(int_22));
			gclass91_1.method_3(int_22, num, Class16.smethod_0(-561781054) + vmethod_4());
		}
	}

	public virtual void vmethod_14(ref GClass91 gclass91_1)
	{
		int num = 0;
		do
		{
			vmethod_13(num, ref gclass91_1);
			num = checked(num + 1);
		}
		while (num <= 7);
		vmethod_30(1);
	}

	public virtual bool vmethod_15(ref GClass91 gclass91_1)
	{
		if (method_7() >= int_5)
		{
			return false;
		}
		if (gclass91_1.int_1 < int_11)
		{
			return false;
		}
		GClass91 obj = gclass91_1;
		GClass9 gclass9_ = this;
		if (!obj.method_17(ref gclass9_))
		{
			return false;
		}
		if (gclass91_1.method_1(3) < 5)
		{
			return false;
		}
		double num = 20.0;
		num += (15.0 - Math.Abs((double)int_7 - 35.0)) / 5.0;
		num += (double)gclass91_1.method_1(1) / 9.0;
		num += (double)gclass91_1.method_1(0) / 15.0;
		num -= (double)gclass91_1.method_1(6) / 6.0;
		num -= (double)gclass91_1.method_1(7) / 5.0;
		num += (double)gclass91_1.method_1(3) / 4.5;
		num += (double)gclass91_1.method_1(4) / 5.5;
		num += (double)gclass91_1.method_1(5) / 15.0;
		if ((double)Class24.smethod_0(0, 100) <= num)
		{
			method_12(ref gclass91_1, bool_0: true);
			return true;
		}
		method_13(ref gclass91_1);
		return false;
	}

	public void method_12(ref GClass91 gclass91_1, bool bool_0)
	{
		if (method_7() >= int_5)
		{
			return;
		}
		if (bool_0)
		{
			if (int_0 == -2)
			{
				Class24.gclass90_0.gclass0_9.method_0(gclass91_1.method_28() + vmethod_5());
			}
			else
			{
				Class24.gclass90_0.gclass0_9.method_0(gclass91_1.method_28() + Class16.smethod_0(-561782299) + method_6());
			}
		}
		if (gclass91_1.gclass9_0 != null)
		{
			gclass91_1.gclass9_0.list_1.Remove(gclass91_1);
		}
		list_1.Add(gclass91_1);
		gclass91_1.gclass9_0 = this;
		gclass91_1.method_18();
	}

	public void method_13(ref GClass91 gclass91_1)
	{
		gclass91_1.method_19();
	}

	public void method_14(ref GClass9 gclass9_0)
	{
		List<GClass91> list = new List<GClass91>();
		checked
		{
			int num = gclass9_0.list_1.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				list.Add(gclass9_0.list_1[i]);
			}
			int num2 = list.Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				List<GClass91> list2;
				int index;
				GClass91 gclass91_ = (list2 = list)[index = j];
				method_12(ref gclass91_, bool_0: false);
				list2[index] = gclass91_;
			}
		}
	}

	public void method_15(int int_22)
	{
		List<GClass91> list = new List<GClass91>();
		checked
		{
			int num = list_1.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				list.Add(list_1[i]);
			}
			int num2 = list.Count - 1;
			for (int j = 0; j <= num2; j++)
			{
				list[j].method_14(int_22);
			}
		}
	}

	public virtual void vmethod_16(int int_22)
	{
		checked
		{
			int_5 += int_22;
		}
	}

	public virtual void vmethod_17(int int_22)
	{
		checked
		{
			int_5 -= int_22;
			while (list_1.Count > int_5)
			{
				list_1[0].method_20();
			}
		}
	}

	public virtual void vmethod_18()
	{
		if (method_7() == int_5)
		{
			double num = 0.0;
			num += Class24.smethod_1(int_6, 2.0);
			num += (double)gclass97_0.int_15;
			int num2 = checked(100 + 20 * int_5);
			if ((double)Class24.smethod_0(0, num2) <= num)
			{
				vmethod_16(int_9);
				Class24.gclass90_0.gclass0_0.method_0(method_6() + Class16.smethod_0(-561782273) + int_5);
			}
		}
	}

	public virtual void vmethod_19(ref List<GClass9> list_3)
	{
		checked
		{
			int_7 += Class24.int_4;
			int num = (int)Math.Round(Class24.smethod_1(int_7 - 50, Class24.int_4));
			if (Class24.smethod_0(1, 100) < num)
			{
				gclass97_0.int_10++;
				Class24.gclass90_0.gclass0_12.method_1(method_6() + Class16.smethod_0(-561782756) + int_7 + Class16.smethod_0(-561782735));
				list_3.Add(this);
			}
			int_6 = (int)Math.Round(Class24.smethod_1(int_6, int_5) + Class24.smethod_1(int_14, 10.0));
		}
	}

	public virtual void vmethod_20()
	{
		checked
		{
			int_7 = Class24.smethod_0(0, Class24.int_4 - 1);
			if (gclass97_0 == null)
			{
				return;
			}
			if (method_10(2))
			{
				Class24.list_0[int_10].int_13++;
			}
			if (method_10(3))
			{
				List<GClass9> list = gclass97_0.method_16(3);
				foreach (GClass9 item in list)
				{
					if (!item.Equals(this))
					{
						Class24.gclass90_0.gclass0_12.method_1(method_6() + Class16.smethod_0(-561782722) + item.vmethod_4() + Class16.smethod_0(-561782704) + item.list_1.Count + Class16.smethod_0(-561782686));
						item.method_15(3);
						item.vmethod_35();
					}
				}
			}
			if (method_10(6))
			{
				gclass97_0.int_14++;
				if (gclass97_0.method_13(36) > 0)
				{
					vmethod_1(1, 1.0, bool_0: false);
				}
				if (gclass97_0.method_13(76) > 0)
				{
					vmethod_1(1, 1.0, bool_0: false);
				}
			}
			if (method_10(8))
			{
				Class24.list_0[int_10].int_15++;
			}
			if (method_10(11) && gclass97_0.method_13(61) > 0)
			{
				vmethod_2(2.0, bool_0: true);
			}
			if (method_10(12))
			{
				gclass97_0.int_13++;
			}
			if (method_10(14))
			{
				Class24.list_0[int_10].int_17++;
			}
			foreach (GClass9 item2 in gclass97_0.list_1)
			{
				if (!item2.Equals(this))
				{
					item2.vmethod_21();
					if (item2.int_0 == 94)
					{
						int_5++;
						item2.method_17(1);
					}
					else if (item2.int_0 == 60)
					{
						GClass28 gClass = (GClass28)item2;
						GClass9 gclass9_ = this;
						gClass.method_24(ref gclass9_);
					}
					else if (item2.int_0 == 19 && method_10(4))
					{
						method_9(4);
						item2.method_17(1);
					}
				}
			}
			List<GClass97> list2 = gclass97_0.method_40();
			foreach (GClass97 item3 in list2)
			{
				foreach (GClass9 item4 in item3.list_1)
				{
					if (item4.int_0 == 102)
					{
						int_9++;
						item4.method_17(1);
					}
					else if (item4.int_0 == 60)
					{
						GClass28 gClass2 = (GClass28)item4;
						GClass9 gclass9_ = this;
						gClass2.method_24(ref gclass9_);
					}
				}
			}
		}
	}

	public virtual void vmethod_21()
	{
	}

	public virtual bool vmethod_22(ref GClass91 gclass91_1, int int_22)
	{
		return false;
	}

	public virtual int vmethod_23(ref GClass91 gclass91_1, int int_22)
	{
		return 0;
	}

	public virtual double vmethod_24(ref GClass91 gclass91_1)
	{
		return 1.0;
	}

	public bool method_16()
	{
		return gclass97_0.method_13(int_0) > 1;
	}

	public virtual List<GClass97> vmethod_25()
	{
		return new List<GClass97>();
	}

	public virtual void vmethod_26(ref int int_22, ref GClass91 gclass91_1)
	{
	}

	public virtual void vmethod_27()
	{
		int_14 = 0;
		int_16 = 0;
		int_18 = 0;
		int_20 = 0;
		int_6 = 0;
	}

	public virtual void vmethod_28()
	{
	}

	public virtual bool vmethod_29(ref GClass97 gclass97_1)
	{
		return false;
	}

	public virtual void vmethod_30(int int_22)
	{
		checked
		{
			int_14 += int_22;
			int_15 += int_22;
		}
	}

	public void method_17(int int_22)
	{
		checked
		{
			int_16 += int_22;
			int_17 += int_22;
		}
	}

	public virtual void vmethod_31(int int_22)
	{
		checked
		{
			int_18 += int_22;
			int_19 += int_22;
		}
	}

	public virtual void vmethod_32(int int_22)
	{
		checked
		{
			int_20 += int_22;
			int_21 += int_22;
		}
	}

	public virtual int vmethod_33()
	{
		vmethod_31(checked((int)Math.Round(Class24.smethod_1(int_14, 5.0))));
		return int_18;
	}

	public virtual int vmethod_34()
	{
		vmethod_32(checked((int)Math.Round(Class24.smethod_1(int_7, 10.0))));
		return int_20;
	}

	public void method_18()
	{
		int_2 = Math.Max(checked(int_2 - 5), 0);
		int_3 = int_2;
	}

	public void method_19(ref GClass93 gclass93_0, int int_22)
	{
		checked
		{
			if (method_10(8))
			{
				double num = 1.0 + (double)gclass93_0.int_15 * 0.05;
				ref int reference = ref int_3;
				reference = (int)Math.Round((double)reference * num);
			}
			foreach (GClass12 item in gclass93_0.list_1)
			{
				if (item.int_22 == int_22)
				{
					ref int reference2 = ref int_3;
					reference2 = (int)Math.Round((double)reference2 * Class24.smethod_1(100.0 - (double)item.int_23, 100.0));
				}
			}
		}
	}

	public bool method_20(ref GClass93 gclass93_0)
	{
		checked
		{
			if (vmethod_8() <= 0 && !list_2.Contains(gclass93_0))
			{
				list_2.Add(gclass93_0);
				int num = 0;
				int num2 = Class24.list_0.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (Class24.list_0[i].int_0 != 0)
					{
						num++;
					}
				}
				if (list_2.Count == num)
				{
					return true;
				}
			}
			return false;
		}
	}

	public virtual void vmethod_35()
	{
		checked
		{
			int num = list_1.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass91 gClass = list_1[i];
				gClass.gclass9_0 = null;
			}
			if (gclass91_0 != null)
			{
				gclass91_0.list_1.Remove(this);
			}
			if (method_10(2))
			{
				Class24.list_0[int_10].int_13--;
			}
			if (method_10(6))
			{
				gclass97_0.int_14--;
			}
			if (method_10(8))
			{
				Class24.list_0[int_10].int_15--;
			}
			if (method_10(14))
			{
				Class24.list_0[int_10].int_17--;
			}
			gclass97_0.list_1.Remove(this);
		}
	}

	public double method_21()
	{
		double num = 0.0;
		int num2 = 0;
		checked
		{
			do
			{
				num += (double)(int_12[num2] * int_13[num2]);
				num2++;
			}
			while (num2 <= 7);
			return num;
		}
	}

	public double method_22(ref GClass5 gclass5_0)
	{
		double num = 0.0;
		int num2 = 0;
		checked
		{
			do
			{
				num += (double)(int_12[num2] * int_13[num2]) / 200.0 * gclass5_0.method_5(num2);
				num2++;
			}
			while (num2 <= 7);
			num += (double)int_5 * gclass5_0.method_5(2);
			if (int_3 <= 0)
			{
				return 9999999.9;
			}
			return Class24.smethod_1(num, int_3);
		}
	}

	public string method_23(int int_22)
	{
		if (vmethod_11(int_22) > 0)
		{
			return vmethod_11(int_22) + Class16.smethod_0(-561782671) + Class24.smethod_3(int_22).ToString() + Class16.smethod_0(-561782646) + vmethod_12(int_22) + Class16.smethod_0(-561781492);
		}
		return string.Empty;
	}

	public override string ToString()
	{
		string empty = string.Empty;
		empty = empty + vmethod_4() + Class16.smethod_0(-561781492);
		checked
		{
			if (int_10 > 0)
			{
				empty = empty + Class16.smethod_0(-561782632) + (int_10 + 1) + Class16.smethod_0(-561781492);
				if (gclass91_0 != null)
				{
					empty = empty + Class16.smethod_0(-561782617) + gclass91_0.string_0 + Class16.smethod_0(-561781492);
				}
			}
			if (gclass97_0 != null)
			{
				empty = empty + Class16.smethod_0(-561782601) + gclass97_0.method_18() + Class16.smethod_0(-561781492);
				empty = empty + Class16.smethod_0(-561782584) + int_7 + Class16.smethod_0(-561781492);
			}
			empty = empty + Class16.smethod_0(-561782572) + vmethod_9() + Class16.smethod_0(-561782558) + vmethod_7() + Class16.smethod_0(-561782535);
			if (int_8 > 0)
			{
				empty = empty + Class16.smethod_0(-561782013) + vmethod_10() + Class16.smethod_0(-561781492);
			}
			if (int_9 > 1)
			{
				empty = empty + Class16.smethod_0(-561781999) + int_9 + Class16.smethod_0(-561781492);
			}
			empty = empty + Class16.smethod_0(-561781976) + int_11 + Class16.smethod_0(-561781492);
			empty = empty + Class16.smethod_0(-561781957) + method_7() + Class16.smethod_0(-561781944) + int_5 + Class16.smethod_0(-561781936) + int_6 + Class16.smethod_0(-561781492);
			if (list_1.Count > 0)
			{
				empty += Class16.smethod_0(-561781917);
				int num = list_1.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					GClass91 gClass = list_1[i];
					empty += gClass.string_0;
					empty = ((i == list_1.Count - 1) ? (empty + Class16.smethod_0(-561781492)) : (empty + Class16.smethod_0(-561781432)));
				}
			}
			empty += Class16.smethod_0(-561781492);
			if ((int_15 > 0) | (int_17 > 0) | (int_19 > 0) | (int_21 > 0))
			{
				if (int_15 > 0)
				{
					empty = empty + int_14 + Class16.smethod_0(-561781899);
					empty = empty + int_15 + Class16.smethod_0(-561781870);
				}
				if (int_17 > 0)
				{
					empty = empty + int_16 + Class16.smethod_0(-561781845) + string_2 + Class16.smethod_0(-561781837);
					empty = empty + int_17 + Class16.smethod_0(-561781845) + string_2 + Class16.smethod_0(-561781817);
				}
				if (int_19 > 0)
				{
					empty = empty + Class16.smethod_0(-561781801) + int_18 + Class16.smethod_0(-561781492);
					empty = empty + Class16.smethod_0(-561781774) + int_19 + Class16.smethod_0(-561781492);
				}
				if (int_21 > 0)
				{
					empty = empty + Class16.smethod_0(-561782263) + int_20 + Class16.smethod_0(-561781492);
					empty = empty + Class16.smethod_0(-561782237) + int_21 + Class16.smethod_0(-561781492);
				}
				empty += Class16.smethod_0(-561781492);
			}
			if (string_0.TrimEnd(new char[0]).Length > 0)
			{
				empty = empty + string_0 + Class16.smethod_0(-561781492);
			}
			if (vmethod_6().Length > 0)
			{
				empty = empty + vmethod_6() + Class16.smethod_0(-561782215);
			}
			if (list_0.Count > 0)
			{
				empty += Class16.smethod_0(-561782204);
				int num2 = list_0.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					empty += Class24.gclass6_0.method_1(list_0[j]);
					empty = ((j == list_0.Count - 1) ? (empty + Class16.smethod_0(-561781492)) : (empty + Class16.smethod_0(-561781432)));
				}
				empty += Class16.smethod_0(-561781492);
			}
			if (Class24.bool_0)
			{
				int num3 = 0;
				do
				{
					empty += method_23(num3);
					num3++;
				}
				while (num3 <= 7);
				empty += Class16.smethod_0(-561781492);
			}
			return empty;
		}
	}
}
