using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public sealed class GClass97 : IComparable
{
	public enum GEnum6
	{

	}

	public int int_0;

	public int int_1;

	public int int_2;

	public string string_0;

	public int int_3;

	public int int_4;

	public GClass9 gclass9_0;

	public GClass9 gclass9_1;

	public int int_5;

	public GClass3 gclass3_0;

	public int int_6;

	public bool bool_0;

	public List<GClass91> list_0;

	public int int_7;

	public List<GClass9> list_1;

	public int int_8;

	public int int_9;

	public int int_10;

	public List<int> list_2;

	public int[] int_11;

	public int int_12;

	public int int_13;

	public int int_14;

	public int int_15;

	public GClass97()
	{
		int_0 = 0;
		int_1 = 0;
		int_2 = -1;
		string_0 = string.Empty;
		int_3 = -1;
		int_4 = -1;
		gclass9_0 = null;
		gclass9_1 = null;
		int_5 = 0;
		gclass3_0 = null;
		int_6 = 0;
		bool_0 = false;
		list_0 = new List<GClass91>();
		int_7 = 0;
		list_1 = new List<GClass9>();
		int_8 = 0;
		int_9 = 0;
		int_10 = 0;
		list_2 = new List<int>();
		int_11 = new int[7];
		int_12 = 1;
		int_13 = 0;
		int_14 = 0;
		int_15 = 0;
	}

	public GClass97(int int_16, int int_17)
	{
		int_0 = 0;
		int_1 = 0;
		int_2 = -1;
		string_0 = string.Empty;
		int_3 = -1;
		int_4 = -1;
		gclass9_0 = null;
		gclass9_1 = null;
		int_5 = 0;
		gclass3_0 = null;
		int_6 = 0;
		bool_0 = false;
		list_0 = new List<GClass91>();
		int_7 = 0;
		list_1 = new List<GClass9>();
		int_8 = 0;
		int_9 = 0;
		int_10 = 0;
		list_2 = new List<int>();
		int_11 = new int[7];
		int_12 = 1;
		int_13 = 0;
		int_14 = 0;
		int_15 = 0;
		int_0 = int_16;
		int_1 = int_17;
		int num = Class24.smethod_0(1, 100);
		if (num <= 10)
		{
			int_6 = 2;
		}
		else if (num <= 20)
		{
			int_6 = 3;
		}
		else if (num <= 27)
		{
			int_6 = 1;
		}
		else if (num <= 32)
		{
			int_6 = 7;
		}
		else if (num <= 38)
		{
			int_6 = 5;
		}
		else if (num <= 44)
		{
			int_6 = 6;
		}
		else if (num <= 52)
		{
			int_6 = 4;
		}
		else
		{
			int_6 = 0;
		}
		gclass3_0 = new GClass3();
		method_1();
		((Control)gclass3_0).set_Name(Class16.smethod_0(-561794263));
		((Control)gclass3_0).set_Tag((object)(Conversions.ToString(int_16) + Class16.smethod_0(-561794250) + Conversions.ToString(int_17)));
		((Label)gclass3_0).set_TabStop(false);
		((Label)gclass3_0).set_TextAlign((ContentAlignment)32);
		((Label)gclass3_0).set_Text(Class16.smethod_0(-561794242));
		((Label)gclass3_0).set_BorderStyle((BorderStyle)1);
	}

	public void method_0(int int_16)
	{
		int_6 = int_16;
		method_1();
	}

	public void method_1()
	{
		((Control)gclass3_0).set_BackColor(Class24.color_5);
		Class24.smethod_0(1, 2);
	}

	public int method_2()
	{
		return list_0.Count;
	}

	public int method_3()
	{
		int num = method_2();
		checked
		{
			int num2 = list_1.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				GClass9 gClass = list_1[i];
				if (gClass.int_0 == 5)
				{
					num -= 10;
				}
				if (gClass.int_0 == 5)
				{
					num -= 5;
				}
				if (gClass.method_10(5))
				{
					num--;
				}
			}
			return num;
		}
	}

	public int method_4()
	{
		return list_1.Count;
	}

	public double method_5()
	{
		double num = 0.0;
		checked
		{
			int num2 = list_1.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				GClass9 gClass = list_1[i];
				num += gClass.method_21();
			}
			return num;
		}
	}

	public int method_6()
	{
		int num = 0;
		checked
		{
			int num2 = list_1.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				GClass9 gClass = list_1[i];
				num += gClass.int_5;
			}
			return num;
		}
	}

	public int method_7()
	{
		int num = 0;
		checked
		{
			int num2 = list_1.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				GClass9 gClass = list_1[i];
				num += gClass.method_7();
			}
			return num;
		}
	}

	public int method_8()
	{
		return checked(method_6() - method_7());
	}

	public int method_9(bool bool_1)
	{
		int num = 0;
		checked
		{
			int num2 = list_0.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				GClass91 gClass = list_0[i];
				if (gClass.gclass9_0 == null && !(bool_1 & gClass.method_30()))
				{
					num++;
				}
			}
			return num;
		}
	}

	public double method_10()
	{
		double num = 0.0;
		checked
		{
			int num2 = list_0.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				GClass91 gClass = list_0[i];
				if (gClass.gclass9_0 == null)
				{
					num = ((!gClass.method_30()) ? (num + 1.0) : (num + (double)gClass.int_1 / 16.0));
				}
			}
			return num;
		}
	}

	public int method_11(bool bool_1)
	{
		int num = 0;
		checked
		{
			int num2 = list_0.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				GClass91 gClass = list_0[i];
				if (gClass.gclass9_0 == null)
				{
					continue;
				}
				if (bool_1)
				{
					if (gClass.method_16())
					{
						num++;
					}
				}
				else
				{
					num++;
				}
			}
			return num;
		}
	}

	public double method_12()
	{
		return (double)int_14 * 0.02 + 1.0;
	}

	public int method_13(int int_16)
	{
		int num = 0;
		checked
		{
			int num2 = list_1.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				GClass9 gClass = list_1[i];
				if (gClass.int_0 == int_16)
				{
					num++;
				}
			}
			return num;
		}
	}

	public int method_14(int int_16)
	{
		int num = 0;
		checked
		{
			int num2 = list_1.Count - 1;
			for (int i = 0; i <= num2; i++)
			{
				GClass9 gClass = list_1[i];
				if (gClass.method_10(int_16))
				{
					num++;
				}
			}
			return num;
		}
	}

	public List<GClass9> method_15(int int_16)
	{
		List<GClass9> list = new List<GClass9>();
		checked
		{
			int num = list_1.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass9 gClass = list_1[i];
				if (gClass.int_0 == int_16)
				{
					list.Add(gClass);
				}
			}
			return list;
		}
	}

	public List<GClass9> method_16(int int_16)
	{
		List<GClass9> list = new List<GClass9>();
		checked
		{
			int num = list_1.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass9 gClass = list_1[i];
				if (gClass.method_10(int_16))
				{
					list.Add(gClass);
				}
			}
			return list;
		}
	}

	public string method_17()
	{
		return int_0 + Class16.smethod_0(-561794250) + int_1;
	}

	public string method_18()
	{
		if (string_0.Length > 0)
		{
			return string_0;
		}
		return checked(Class16.smethod_0(-561794234) + (int_0 + 1) + Class16.smethod_0(-561794250) + (int_1 + 1)) + Class16.smethod_0(-561794226);
	}

	public bool method_19()
	{
		return int_2 >= 0;
	}

	public bool method_20(int int_16)
	{
		return int_2 == int_16;
	}

	public void method_21(int int_16)
	{
		int_2 = int_16;
		GClass4 gclass4_ = Class24.gclass4_0;
		GClass97 gclass97_ = this;
		string_0 = gclass4_.method_3(ref gclass97_);
		GClass93 gClass = Class24.list_0[int_16];
		int_12 = gClass.method_5();
		if (gClass.list_2.Count > 0)
		{
			GClass53 gClass2 = (GClass53)gClass.list_2[0];
			GClass53 gClass3 = (GClass53)Class24.gclass6_0.method_3(34);
			method_22(gClass3, int_16, bool_1: false);
			gClass2.gclass53_0 = gClass3;
			gClass3.gclass53_0 = gClass2;
			gClass.list_2.Remove(gClass2);
			gClass.list_3.Remove(gClass2);
			gClass3.gclass97_0.method_25(2);
		}
	}

	public void method_22(GClass9 gclass9_2, int int_16, bool bool_1)
	{
		gclass9_2.gclass97_0 = this;
		gclass9_2.int_10 = int_16;
		list_1.Add(gclass9_2);
		if (bool_1)
		{
			gclass9_2.vmethod_20();
		}
		checked
		{
			int_8++;
			if (gclass9_2.gclass91_0 != null)
			{
				int_9++;
			}
		}
	}

	public void method_23()
	{
		checked
		{
			int_7++;
			if (int_7 > 4)
			{
				int_7 = 4;
			}
		}
	}

	public void method_24(GClass91 gclass91_0)
	{
		gclass91_0.gclass97_1 = this;
		list_0.Add(gclass91_0);
	}

	public void method_25(int int_16)
	{
		checked
		{
			int num = int_16 - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass91 gclass91_ = new GClass91(bool_0: true);
				method_24(gclass91_);
			}
		}
	}

	public int method_26(ref GClass97 gclass97_0)
	{
		return checked(Math.Abs(int_0 - gclass97_0.int_0) + Math.Abs(int_1 - gclass97_0.int_1));
	}

	public void method_27()
	{
		if (int_6 == 4)
		{
			bool_0 = false;
			return;
		}
		List<GClass97> list = method_40();
		checked
		{
			int num = list.Count - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					GClass97 gClass = list[num2];
					if (gClass.int_6 == 4)
					{
						break;
					}
					num2++;
					continue;
				}
				bool_0 = false;
				return;
			}
			bool_0 = true;
		}
	}

	public int method_28()
	{
		int num = 0;
		foreach (GClass91 item in list_0)
		{
			if (item.method_30())
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	public int method_29()
	{
		int num = 0;
		foreach (GClass91 item in list_0)
		{
			if (item.method_31())
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	public int method_30(int int_16, int int_17)
	{
		int num = 0;
		foreach (GClass91 item in list_0)
		{
			if (item.method_29(int_16, int_17))
			{
				num = checked(num + 1);
			}
		}
		return num;
	}

	public int method_31(bool bool_1)
	{
		int num = 0;
		int num2 = 0;
		checked
		{
			foreach (GClass91 item in list_0)
			{
				if (bool_1)
				{
					if (item.int_1 > num)
					{
						num = item.int_1;
					}
				}
				else
				{
					num += item.int_1;
					num2++;
				}
			}
			if (bool_1)
			{
				return num;
			}
			return (int)Math.Round(Class24.smethod_1(num, num2));
		}
	}

	public int method_32(int int_16)
	{
		int num = 0;
		checked
		{
			foreach (GClass9 item in list_1)
			{
				switch (int_16)
				{
				case -1:
					if (item.int_10 == Class24.gclass93_0.int_1)
					{
						num++;
					}
					break;
				case -2:
					if (item.int_10 != Class24.gclass93_0.int_1)
					{
						num++;
					}
					break;
				default:
					if (item.int_10 == int_16)
					{
						num++;
					}
					break;
				}
			}
			return num;
		}
	}

	public int method_33(int int_16)
	{
		int num = 0;
		foreach (GClass91 item in list_0)
		{
			num = checked(num + item.int_3[int_16]);
		}
		return num;
	}

	public int method_34()
	{
		int num = 0;
		int num2 = 0;
		checked
		{
			foreach (int item in list_2)
			{
				num += item;
				num2++;
			}
			return (int)Math.Round(Class24.smethod_1(num, num2));
		}
	}

	public int method_35(int int_16)
	{
		int num = 0;
		checked
		{
			foreach (GClass9 item in list_1)
			{
				switch (int_16)
				{
				case 35:
					num += item.int_18;
					break;
				case 36:
					num += item.int_19;
					break;
				case 37:
					num += item.int_20;
					break;
				case 38:
					num += item.int_21;
					break;
				}
			}
			return num;
		}
	}

	public int method_36(int int_16, bool bool_1)
	{
		int num = 0;
		int num2 = 0;
		checked
		{
			foreach (GClass91 item in list_0)
			{
				item.method_4();
				if (!bool_1 || !item.method_30())
				{
					num += item.method_1(int_16);
					num2++;
				}
			}
			return (int)Math.Round(Class24.smethod_1(num, num2));
		}
	}

	public void method_37(int int_16)
	{
		string text = string.Empty;
		if (method_19() || int_16 == 1)
		{
			if (int_2 >= 0)
			{
				((Control)gclass3_0).set_BackColor(Class24.list_0[int_2].color_0);
			}
			((Control)gclass3_0).set_Font(Class24.font_1);
			checked
			{
				switch (int_16)
				{
				case 0:
					text = method_2().ToString();
					break;
				case 1:
					((Control)gclass3_0).set_Font(Class24.font_2);
					text = int_1 + 1 + Class16.smethod_0(-561794250) + (int_0 + 1);
					break;
				case 2:
					text = int_12.ToString();
					break;
				case 3:
					((Control)gclass3_0).set_Font(Class24.font_2);
					text = Class24.smethod_5(int_6, bool_2: false);
					break;
				case 4:
					text = method_4().ToString();
					break;
				case 5:
					text = int_7.ToString();
					break;
				case 6:
					text = method_6().ToString();
					break;
				case 7:
					((Control)gclass3_0).set_Font(Class24.font_2);
					text = method_7() + Class16.smethod_0(-561781944) + method_6();
					break;
				case 8:
					((Control)gclass3_0).set_Font(Class24.font_2);
					text = method_8() + Class16.smethod_0(-561781944) + method_6();
					break;
				case 9:
					text = (method_9(bool_1: true) - method_8()).ToString();
					break;
				case 10:
					text = method_28().ToString();
					break;
				case 11:
					text = method_29().ToString();
					break;
				case 12:
					text = method_11(bool_1: false).ToString();
					break;
				case 13:
					text = method_11(bool_1: true).ToString();
					break;
				case 14:
					text = method_9(bool_1: true).ToString();
					break;
				case 15:
					text = method_9(bool_1: false).ToString();
					break;
				case 16:
					text = method_31(bool_1: false).ToString();
					break;
				case 17:
					text = method_34().ToString();
					break;
				case 18:
					text = method_31(bool_1: true).ToString();
					break;
				case 19:
					text = method_36(0, bool_1: false).ToString();
					break;
				case 20:
					text = method_36(1, bool_1: false).ToString();
					break;
				case 21:
					text = method_36(2, bool_1: false).ToString();
					break;
				case 22:
					text = method_36(3, bool_1: false).ToString();
					break;
				case 23:
					text = method_36(4, bool_1: false).ToString();
					break;
				case 24:
					text = method_36(5, bool_1: false).ToString();
					break;
				case 25:
					text = method_36(6, bool_1: false).ToString();
					break;
				case 26:
					text = method_36(7, bool_1: false).ToString();
					break;
				case 27:
					text = method_36(0, bool_1: true).ToString();
					break;
				case 28:
					text = method_36(1, bool_1: true).ToString();
					break;
				case 29:
					text = method_36(2, bool_1: true).ToString();
					break;
				case 30:
					text = method_36(3, bool_1: true).ToString();
					break;
				case 31:
					text = method_36(4, bool_1: true).ToString();
					break;
				case 32:
					text = method_36(5, bool_1: true).ToString();
					break;
				case 33:
					text = method_36(6, bool_1: true).ToString();
					break;
				case 34:
					text = method_36(7, bool_1: true).ToString();
					break;
				case 35:
					((Control)gclass3_0).set_Font(Class24.font_2);
					text = method_35(int_16).ToString();
					break;
				case 36:
					((Control)gclass3_0).set_Font(Class24.font_2);
					text = method_35(int_16).ToString();
					break;
				case 37:
					((Control)gclass3_0).set_Font(Class24.font_2);
					text = method_35(int_16).ToString();
					break;
				case 38:
					((Control)gclass3_0).set_Font(Class24.font_2);
					text = method_35(int_16).ToString();
					break;
				case 39:
					text = method_33(0).ToString();
					break;
				case 40:
					text = method_33(1).ToString();
					break;
				case 41:
					text = method_33(2).ToString();
					break;
				case 42:
					text = method_33(3).ToString();
					break;
				case 43:
					text = method_33(4).ToString();
					break;
				case 44:
					text = method_33(5).ToString();
					break;
				case 45:
					text = int_11[0].ToString();
					break;
				case 46:
					text = int_11[1].ToString();
					break;
				case 47:
					text = int_11[2].ToString();
					break;
				case 48:
					text = int_11[3].ToString();
					break;
				case 49:
					text = int_11[4].ToString();
					break;
				case 50:
					text = int_11[5].ToString();
					break;
				case 51:
					text = method_32(-1).ToString();
					break;
				case 52:
					text = method_32(-2).ToString();
					break;
				case 53:
					text = method_32(1).ToString();
					break;
				case 54:
					text = method_32(2).ToString();
					break;
				case 55:
					text = method_32(3).ToString();
					break;
				case 56:
					text = method_32(4).ToString();
					break;
				case 57:
					text = int_8.ToString();
					break;
				case 58:
					text = int_9.ToString();
					break;
				case 59:
					text = int_10.ToString();
					break;
				case 60:
					text = method_14(0).ToString();
					break;
				case 61:
					text = method_14(1).ToString();
					break;
				case 62:
					text = method_14(2).ToString();
					break;
				case 63:
					text = method_14(3).ToString();
					break;
				case 66:
					text = method_14(6).ToString();
					break;
				case 67:
					text = method_14(7).ToString();
					break;
				case 68:
					text = method_14(8).ToString();
					break;
				case 69:
					text = method_14(9).ToString();
					break;
				case 70:
					text = method_14(10).ToString();
					break;
				case 71:
					text = method_14(11).ToString();
					break;
				case 72:
					text = method_14(12).ToString();
					break;
				case 74:
					text = method_14(14).ToString();
					break;
				case 75:
					text = method_14(15).ToString();
					break;
				case 76:
					text = method_14(16).ToString();
					break;
				}
			}
		}
		((Label)gclass3_0).set_Text(text);
	}

	public string method_38()
	{
		return checked(Class16.smethod_0(-561794234) + (int_0 + 1) + Class16.smethod_0(-561794250) + (int_1 + 1)) + Class16.smethod_0(-561794226);
	}

	public override string ToString()
	{
		string text = string.Empty;
		string text2 = string.Empty;
		checked
		{
			int num = int_2 + 1;
			if (string.Compare(string_0, string.Empty) != 0)
			{
				text = text + Class16.smethod_0(-561794912) + string_0 + Class16.smethod_0(-561781492);
			}
			text = text + Class16.smethod_0(-561782601) + method_38() + Class16.smethod_0(-561781492);
			text += Class16.smethod_0(-561794218);
			text += Class24.smethod_5(int_6, bool_2: false);
			switch (int_6)
			{
			case 0:
				text2 = Class16.smethod_0(-561794202);
				break;
			case 1:
				text2 = Class16.smethod_0(-561794130);
				break;
			case 2:
				text2 = Class16.smethod_0(-561794529);
				break;
			case 3:
				text2 = Class16.smethod_0(-561794425);
				break;
			case 4:
				text2 = Class16.smethod_0(-561791725);
				break;
			case 5:
				text2 = Class16.smethod_0(-561791607);
				break;
			case 6:
				text2 = Class16.smethod_0(-561791826);
				break;
			case 7:
				text2 = Class16.smethod_0(-561791984);
				break;
			}
			if (bool_0)
			{
				text += Class16.smethod_0(-561791189);
			}
			text += Class16.smethod_0(-561781492);
			if (num == 0)
			{
				text = text + text2 + Class16.smethod_0(-561782215);
				text += Class16.smethod_0(-561791173);
			}
			else
			{
				text = text + Class16.smethod_0(-561791153) + num + Class16.smethod_0(-561781492);
				text = text + Class16.smethod_0(-561791132) + method_2() + Class16.smethod_0(-561781492);
				text = text + Class16.smethod_0(-561791113) + method_4() + Class16.smethod_0(-561781492);
				text = text + Class16.smethod_0(-561781957) + method_7() + Class16.smethod_0(-561781944) + method_6() + Class16.smethod_0(-561781492);
				text += Class16.smethod_0(-561791095);
				switch (int_7)
				{
				case 0:
					text += Class16.smethod_0(-561791072);
					break;
				case 1:
					text += Class16.smethod_0(-561791059);
					break;
				case 2:
					text += Class16.smethod_0(-561791046);
					break;
				case 3:
					text += Class16.smethod_0(-561791031);
					break;
				case 4:
					text += Class16.smethod_0(-561791017);
					break;
				}
				if (int_15 > 0)
				{
					text = text + Class16.smethod_0(-561791001) + int_15 + Class16.smethod_0(-561781492);
				}
				text += Class16.smethod_0(-561790981);
				int num2 = list_1.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					GClass9 gClass = list_1[i];
					text = text + gClass.vmethod_4() + Class16.smethod_0(-561793740) + gClass.method_7() + Class16.smethod_0(-561781944) + gClass.int_5 + Class16.smethod_0(-561781936) + gClass.int_6 + Class16.smethod_0(-561781492);
				}
			}
			return text;
		}
	}

	public int CompareTo(object obj)
	{
		if (!(obj is GClass97))
		{
			throw new ArgumentException();
		}
		GClass97 gClass = (GClass97)obj;
		checked
		{
			int num;
			int num2;
			if (Class24.int_2 == 0)
			{
				num = method_44();
				num2 = gClass.method_44();
			}
			else if (Class24.int_2 == 1)
			{
				num = method_2();
				num2 = gClass.method_2();
			}
			else if (Class24.int_2 == 3)
			{
				num = (int)Math.Round(0.0 - method_5());
				num2 = (int)Math.Round(0.0 - gClass.method_5());
			}
			else
			{
				num = -method_8();
				num2 = -gClass.method_8();
			}
			if (num < num2)
			{
				return -1;
			}
			if (num > num2)
			{
				return 1;
			}
			return 0;
		}
	}

	public bool method_39()
	{
		if ((int_0 >= 0) & (int_1 >= 0) & (int_0 <= 11) & (int_1 <= 11))
		{
			return true;
		}
		return false;
	}

	public List<GClass97> method_40()
	{
		List<GClass97> list = new List<GClass97>();
		checked
		{
			if (int_0 - 1 >= 0)
			{
				list.Add(Class24.gclass97_0[int_0 - 1, int_1]);
			}
			if (int_0 + 1 <= 11)
			{
				list.Add(Class24.gclass97_0[int_0 + 1, int_1]);
			}
			if (int_1 - 1 >= 0)
			{
				list.Add(Class24.gclass97_0[int_0, int_1 - 1]);
			}
			if (int_1 + 1 <= 11)
			{
				list.Add(Class24.gclass97_0[int_0, int_1 + 1]);
			}
			return list;
		}
	}

	public void method_41(ref List<GClass97> list_3, ref GClass9 gclass9_2)
	{
		List<GClass97> list = gclass9_2.vmethod_25();
		checked
		{
			int num = list.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass97 gClass = list[i];
				if (!list_3.Contains(gClass))
				{
					gClass.gclass9_0 = gclass9_2;
					list_3.Add(gClass);
				}
			}
		}
	}

	public List<GClass97> method_42()
	{
		List<GClass97> list_ = new List<GClass97>();
		List<GClass97> collection = method_40();
		list_.AddRange(collection);
		checked
		{
			int num = list_1.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass9 gclass9_ = list_1[i];
				if ((gclass9_.int_0 == 93) | (gclass9_.int_0 == 49) | (gclass9_.int_0 == 58) | (gclass9_.int_0 == 2) | (gclass9_.int_0 == 34))
				{
					method_41(ref list_, ref gclass9_);
				}
			}
			return list_;
		}
	}

	public void method_43(int int_16, ref List<GClass97> list_3)
	{
		list_3.Add(this);
		if (int_16 <= 0)
		{
			return;
		}
		List<GClass97> list = method_40();
		checked
		{
			int num = list.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (!list_3.Contains(list[i]))
				{
					list[i].method_43(int_16 - 1, ref list_3);
				}
			}
		}
	}

	public int method_44()
	{
		return int_5;
	}

	public string method_45()
	{
		string text = Class16.smethod_0(-561781054) + method_18() + Class16.smethod_0(-561791470);
		if (gclass9_1 == null)
		{
			text += Class16.smethod_0(-561791459);
		}
		else
		{
			switch (gclass9_1.int_0)
			{
			case 34:
				text += Class16.smethod_0(-561791405);
				break;
			case 2:
				text += Class16.smethod_0(-561791428);
				break;
			case 93:
				text += Class16.smethod_0(-561791416);
				break;
			case 58:
				text += Class16.smethod_0(-561791438);
				break;
			case 49:
				text += Class16.smethod_0(-561791449);
				break;
			}
		}
		return text + Class16.smethod_0(-561791384) + int_3;
	}

	public void method_46(ref GClass9 gclass9_2)
	{
		gclass9_1 = gclass9_2;
		gclass9_0 = gclass9_2;
	}

	public void method_47(ref GClass9 gclass9_2)
	{
		gclass9_0 = gclass9_2;
	}

	public void method_48(ref GClass91 gclass91_0)
	{
		gclass91_0.method_5(method_45());
		if (gclass9_1 != null)
		{
			gclass9_1.method_17(1);
		}
		GClass9 gclass9_ = null;
		method_46(ref gclass9_);
	}

	public void method_49()
	{
		int_3 = 0;
		int_4 = -1;
		int_5 = 0;
		gclass9_1 = null;
		gclass9_0 = null;
	}
}
