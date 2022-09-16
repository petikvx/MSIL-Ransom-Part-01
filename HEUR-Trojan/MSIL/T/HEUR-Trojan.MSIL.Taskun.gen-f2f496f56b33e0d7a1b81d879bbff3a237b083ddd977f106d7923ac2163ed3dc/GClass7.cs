using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.VisualBasic;

public sealed class GClass7
{
	public GForm4 gform4_0;

	private bool bool_0;

	private int int_0;

	private GClass97 gclass97_0;

	private int int_1;

	private int int_2;

	private int int_3;

	public int int_4;

	public GClass7()
	{
		gform4_0 = null;
		bool_0 = false;
		int_0 = -1;
		gclass97_0 = null;
		int_1 = -1;
		int_2 = -1;
		int_3 = 0;
		int_4 = 1;
	}

	public void method_0()
	{
		method_25();
		method_4();
		method_18();
		method_2();
		gform4_0.method_15(0, Class24.gclass90_0.ToString());
		gform4_0.method_10(0);
	}

	public void method_1()
	{
		method_3();
		method_0();
	}

	public void method_2()
	{
		gform4_0.method_29();
		if (Class24.gclass93_0.int_0 != 2)
		{
			return;
		}
		int num = 0;
		bool flag = false;
		do
		{
			int num2 = Class24.gclass93_0.method_16(ref Class24.gclass9_0);
			if (num2 != -1)
			{
				int_0 = num2;
				method_9(ref Class24.gclass93_0.gclass97_0);
				flag = method_17();
			}
			else
			{
				flag = false;
			}
			if (flag)
			{
				num = checked(num + 1);
				if (num2 >= 0 && num2 <= 4)
				{
					GClass9 gClass = gclass97_0.list_1[checked(gclass97_0.list_1.Count - 1)];
					Class24.gclass90_0.gclass1_1.method_0(Class24.gclass93_0.method_1() + Class16.smethod_0(-561814251) + gClass.method_6());
					continue;
				}
				switch (num2)
				{
				case 5:
					Class24.gclass90_0.gclass1_2.method_0(Class24.gclass93_0.method_1() + Class16.smethod_0(-561814234) + gclass97_0.method_18());
					break;
				case 6:
					Class24.gclass90_0.gclass1_0.method_0(Class24.gclass93_0.method_1() + Class16.smethod_0(-561814205) + gclass97_0.method_18() + Class16.smethod_0(-561782333) + gclass97_0.method_38());
					break;
				}
			}
			else if (num == 0)
			{
				Class24.gclass90_0.gclass1_0.method_0(Class24.gclass93_0.method_1() + Class16.smethod_0(-561814189));
			}
		}
		while (flag);
	}

	public void method_3()
	{
		checked
		{
			do
			{
				int num = Class24.gclass93_0.int_1 + 1;
				if (num == Class24.list_0.Count)
				{
					num = 0;
					int_4 += Class24.int_4;
					gform4_0.method_11();
					if (((Class24.int_0 == 4) & (int_4 >= Class24.int_1)) | bool_0)
					{
						method_32();
					}
				}
				GClass7 gclass7_ = Class24.gclass7_0;
				List<GClass93> list_;
				int index;
				GClass93 gclass93_ = (list_ = Class24.list_0)[index = num];
				gclass7_.method_5(ref gclass93_);
				list_[index] = gclass93_;
			}
			while (Class24.gclass93_0.int_0 == 0);
			Class24.gclass93_0.method_8();
		}
	}

	public void method_4()
	{
		GClass2 gClass = new GClass2(int_4);
		gClass.method_0();
	}

	public void method_5(ref GClass93 gclass93_0)
	{
		Class24.gclass93_0 = gclass93_0;
		gform4_0.method_53();
	}

	public void method_6(int int_5)
	{
		int_0 = int_5;
		if ((int_0 == 4) & (Class24.gclass9_0[4] == null))
		{
			int_0 = -1;
		}
	}

	public void method_7(int int_5)
	{
		int_1 = int_5;
		gform4_0.method_35(int_1);
	}

	public void method_8(int int_5)
	{
		int_2 = int_5;
		gform4_0.method_38(int_2);
	}

	public void method_9(ref GClass97 gclass97_1)
	{
		gclass97_0 = gclass97_1;
		gform4_0.method_15(1, gclass97_0.ToString());
	}

	public void method_10(int int_5)
	{
		int_3 = int_5;
		method_29();
	}

	public void method_11(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public int method_12()
	{
		return int_0;
	}

	public int method_13()
	{
		return int_1;
	}

	public int method_14()
	{
		return int_2;
	}

	public int method_15()
	{
		return int_3;
	}

	public GClass97 method_16()
	{
		return gclass97_0;
	}

	public bool method_17()
	{
		bool flag = false;
		int num = Class24.gclass93_0.int_3;
		int num2 = 0;
		if ((int_0 == 5) | (int_0 == 8))
		{
			num2 = 50;
		}
		else if (int_0 == 6)
		{
			num2 = ((gclass97_0.int_6 != 5) ? Class24.gclass93_0.method_9() : 0);
		}
		else if (int_0 == 7)
		{
			num2 = Class24.gclass93_0.method_10();
		}
		else
		{
			if (!((int_0 >= 0) & (int_0 < Class24.gclass9_0.Length)))
			{
				return false;
			}
			if (Class24.gclass9_0[int_0] == null)
			{
				return false;
			}
			num2 = Class24.gclass9_0[int_0].vmethod_9();
		}
		if (int_0 == 6)
		{
			if (!Class24.gclass93_0.method_13(gclass97_0))
			{
				return false;
			}
		}
		else if ((int_0 >= 0) & (int_0 < Class24.gclass9_0.Length))
		{
			if (!Class24.gclass93_0.method_14(gclass97_0, ref num2))
			{
				return false;
			}
		}
		else if (((int_0 == 5) | (int_0 == 8)) && (!gclass97_0.method_20(Class24.gclass93_0.int_1) | (gclass97_0.int_7 == 4)))
		{
			return false;
		}
		if (num2 > num)
		{
			return false;
		}
		checked
		{
			if (int_0 == 4)
			{
				Class24.gclass93_0.int_11 -= num2;
				Class24.gclass93_0.int_12[Class24.gclass9_0[int_0].int_0] += 50;
			}
			Class24.gclass93_0.int_3 -= num2;
			flag = true;
			if ((int_0 == 5) | (int_0 == 8))
			{
				gclass97_0.method_23();
			}
			else if (int_0 == 6)
			{
				gclass97_0.method_21(Class24.gclass93_0.int_1);
				if (gclass97_0.int_6 == 7)
				{
					ref int reference = ref Class24.gclass93_0.int_3;
					reference = (int)Math.Round((double)reference + Class24.smethod_1(num2, 2.0));
				}
				else if (gclass97_0.int_6 == 1)
				{
					gclass97_0.int_7 = 1;
				}
				else if (gclass97_0.int_6 == 3)
				{
					int num3 = Class24.smethod_0(0, 3);
					GClass9 gClass = Class24.gclass9_0[num3];
					gClass.int_3 = 0;
					gClass.gclass97_0 = gclass97_0;
					gclass97_0.method_22(gClass, Class24.gclass93_0.int_1, bool_1: true);
					method_8(gclass97_0.list_1.Count - 1);
					Class24.gclass9_0[num3] = null;
				}
				else if (gclass97_0.int_6 == 6)
				{
					int int_ = (int)Math.Round(Math.Min(10.0, Math.Floor(Class24.smethod_1(Class24.gclass93_0.method_3(), 15.0)) + 2.0));
					int num4 = Class24.smethod_0(2, int_);
					int num5 = num4 - 1;
					for (int i = 0; i <= num5; i++)
					{
						GClass91 gclass91_ = new GClass91(bool_0: true);
						gclass97_0.method_24(gclass91_);
					}
				}
			}
			else if ((int_0 >= 0) & (int_0 < Class24.gclass9_0.Length))
			{
				Class24.gclass9_0[int_0].int_3 = num2;
				gclass97_0.method_22(Class24.gclass9_0[int_0], Class24.gclass93_0.int_1, bool_1: true);
				method_8(gclass97_0.list_1.Count - 1);
				Class24.gclass9_0[int_0] = null;
			}
			else if (int_0 == 7)
			{
				int num6 = Class24.gclass9_0.Length - 1;
				for (int j = 0; j <= num6; j++)
				{
					Class24.gclass9_0[j] = null;
				}
				Class24.gclass93_0.int_10 = 105;
			}
			if (flag)
			{
				if (int_0 == 8)
				{
					method_17();
				}
				else if (int_0 == 7)
				{
					method_22();
				}
				method_18();
			}
			return true;
		}
	}

	public void method_18()
	{
		method_19();
		method_20(bool_1: true);
		int_0 = -1;
		gform4_0.method_30();
		gform4_0.method_9();
		if (gclass97_0 != null)
		{
			gform4_0.method_15(1, gclass97_0.ToString());
		}
	}

	public void method_19()
	{
		IEnumerator enumerator = Class24.gclass97_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			GClass97 gClass = (GClass97)enumerator.Current;
			gClass.method_37(int_3);
		}
	}

	public void method_20(bool bool_1)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (bool_1)
			{
				Class24.gclass93_0.int_10 -= 5;
				Class24.gclass93_0.method_12();
				gform4_0.method_54();
			}
			int num = Class24.gclass9_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass9 gClass = Class24.gclass9_0[i];
				if (gClass == null)
				{
					if (i != 4)
					{
						int num2 = -1;
						int num3 = Class24.gclass93_0.method_15();
						if ((num3 > 1) & (int_0 != 7) & (Class24.gclass93_0.int_0 == 1))
						{
							GForm2 gForm = new GForm2(num3);
							((Form)gForm).ShowDialog();
							num2 = gForm.int_0;
						}
						gClass = Class24.gclass6_0.method_3(num2);
						Class24.gclass9_0[i] = gClass;
					}
				}
				else
				{
					if (gClass.method_20(ref Class24.gclass93_0))
					{
						GClass9 gClass2 = Class24.gclass6_0.method_3(-1);
						Class24.gclass9_0[i] = gClass2;
					}
					if (bool_1)
					{
						gClass.method_18();
					}
				}
				string empty = string.Empty;
				if (gClass == null)
				{
					empty += Class16.smethod_0(-561814161);
					empty = empty + Class16.smethod_0(-561814139) + Class24.gclass93_0.method_11() + Class16.smethod_0(-561814131);
				}
				else
				{
					gClass.method_19(ref Class24.gclass93_0, i);
					empty = empty + gClass.vmethod_4() + Class16.smethod_0(-561781492);
					empty = empty + Class16.smethod_0(-561814139) + gClass.vmethod_9() + Class16.smethod_0(-561814118);
					empty = empty + gClass.int_5 + Class16.smethod_0(-561814108);
				}
				gform4_0.method_31(i, empty);
			}
			int num4 = Class24.gclass93_0.method_10();
			gform4_0.method_31(7, Class16.smethod_0(-561814139) + num4 + Class16.smethod_0(-561814096));
			gform4_0.method_31(5, Class16.smethod_0(-561814139) + 50 + Class16.smethod_0(-561814074));
			int num5 = Class24.gclass93_0.method_9();
			gform4_0.method_31(6, Class16.smethod_0(-561814139) + num5 + Class16.smethod_0(-561814060));
			gform4_0.method_29();
		}
	}

	public void method_21(int int_5, int int_6)
	{
		checked
		{
			Class24.list_0[int_5].int_3 += int_6;
			gform4_0.method_9();
		}
	}

	public void method_22()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Invalid comparison between Unknown and I4
		if (Class24.gclass93_0.int_0 != 1)
		{
			return;
		}
		checked
		{
			int num = Class24.gclass93_0.int_18 - 1;
			for (int i = 0; i <= num; i++)
			{
				method_20(bool_1: false);
				MsgBoxResult val = Interaction.MsgBox((object)Class16.smethod_0(-561814046), (MsgBoxStyle)4, (object)null);
				if (unchecked((int)val) == 6)
				{
					int num2 = Class24.gclass9_0.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						Class24.gclass9_0[j] = null;
					}
				}
				else if (unchecked((int)val) == 7)
				{
					break;
				}
			}
		}
	}

	public void method_23()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GForm5 gForm = new GForm5();
		((Form)gForm).ShowDialog();
		gclass97_0.string_0 = Class24.string_0;
		gform4_0.method_15(2, gclass97_0.ToString());
	}

	public void method_24()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected I4, but got Unknown
		GClass9 gClass = gclass97_0.list_1[int_2];
		int num = Math.Max(20, checked(gClass.vmethod_9() - gClass.int_7));
		string text = Class16.smethod_0(-561814512) + gClass.method_6() + Class16.smethod_0(-561814499) + num + Class16.smethod_0(-561814486);
		int num2 = (int)MessageBox.Show(text, Class16.smethod_0(-561814478), (MessageBoxButtons)4);
		checked
		{
			if (num2 == 6 && Class24.gclass93_0.int_3 >= num)
			{
				method_21(Class24.gclass93_0.int_1, -num);
				gClass.gclass97_0.int_10++;
				gClass.vmethod_35();
				method_27(bool_1: false, bool_2: true);
				method_27(bool_1: true, bool_2: true);
			}
		}
	}

	public void method_25()
	{
		if (gclass97_0 != null)
		{
			((Label)gclass97_0.gclass3_0).set_BorderStyle((BorderStyle)1);
		}
		int_0 = -1;
		Class24.gclass9_0[4] = null;
		gform4_0.method_30();
		gform4_0.method_13();
		Class24.gclass90_0.method_0();
		method_8(0);
		method_7(0);
		method_10(0);
	}

	public void method_26(bool bool_1, bool bool_2)
	{
		if (gclass97_0 == null)
		{
			return;
		}
		int num = gclass97_0.method_2();
		if (num == 0)
		{
			return;
		}
		int num2 = int_1;
		checked
		{
			num2 = ((!bool_1) ? (num2 - 1) : (num2 + 1));
			if (num2 < 0)
			{
				if (!bool_2)
				{
					return;
				}
				num2 = num - 1;
			}
			else if (num2 >= num)
			{
				if (!bool_2)
				{
					return;
				}
				num2 = 0;
			}
			method_7(num2);
		}
	}

	public void method_27(bool bool_1, bool bool_2)
	{
		if (gclass97_0 == null)
		{
			return;
		}
		int num = gclass97_0.method_4();
		if (num == 0)
		{
			method_8(0);
			return;
		}
		int num2 = int_2;
		checked
		{
			num2 = ((!bool_1) ? (num2 - 1) : (num2 + 1));
			if (num2 < 0)
			{
				if (!bool_2)
				{
					return;
				}
				num2 = num - 1;
			}
			else if (num2 >= num)
			{
				if (!bool_2)
				{
					return;
				}
				num2 = 0;
			}
			method_8(num2);
		}
	}

	public void method_28(bool bool_1, bool bool_2)
	{
		int num = int_3;
		checked
		{
			num = ((!bool_1) ? (num - 1) : (num + 1));
			if (num < 0)
			{
				if (!bool_2)
				{
					return;
				}
				num = int_3 - 1;
			}
			else if (num >= 78)
			{
				if (!bool_2)
				{
					return;
				}
				num = 0;
			}
			method_10(num);
		}
	}

	public void method_29()
	{
		gform4_0.vmethod_68().set_SelectedIndex(int_3);
		gform4_0.method_11();
		method_19();
	}

	public void method_30()
	{
		if (!((method_15() == 5) & (method_12() == 5)))
		{
			method_10(0);
		}
	}

	public string method_31()
	{
		string text = string.Empty;
		if ((int_0 > -1) & (int_0 <= 3))
		{
			text += Class24.gclass9_0[int_0].ToString();
		}
		else if (int_0 == 4)
		{
			if (Class24.gclass9_0[int_0] == null)
			{
				text += Class16.smethod_0(-561814457);
				text += Class16.smethod_0(-561814326);
				text += Class16.smethod_0(-561813685);
			}
			else
			{
				text += Class24.gclass9_0[int_0].ToString();
			}
		}
		else if (int_0 == 8)
		{
			text += Class16.smethod_0(-561813589);
		}
		else if (int_0 == 5)
		{
			text = text + Class16.smethod_0(-561813520) + 50;
		}
		else if (int_0 == 6)
		{
			text += Class16.smethod_0(-561813895);
		}
		else if (int_0 == 7)
		{
			text += Class16.smethod_0(-561813780);
			text += Class16.smethod_0(-561815170);
			text += Class16.smethod_0(-561815092);
		}
		return text;
	}

	public void method_32()
	{
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Invalid comparison between Unknown and I4
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Invalid comparison between Unknown and I4
		string text = string.Empty;
		string text2 = string.Empty;
		int num = 0;
		int num2 = 0;
		int num3 = -1;
		GForm3 gForm;
		checked
		{
			int num4 = Class24.list_0.Count - 1;
			for (int i = 0; i <= num4; i++)
			{
				GClass93 gClass = Class24.list_0[i];
				switch (Class24.int_0)
				{
				case 0:
					text = Class16.smethod_0(-561800335);
					num2 = gClass.method_8();
					break;
				case 1:
					text = Class16.smethod_0(-561800269);
					num2 = gClass.method_5();
					break;
				case 2:
					text = Class16.smethod_0(-561800304);
					num2 = gClass.method_3();
					break;
				case 3:
					text = Class16.smethod_0(-561815525);
					num2 = gClass.method_7();
					break;
				case 4:
					text = Class16.smethod_0(-561800335);
					num2 = gClass.method_8();
					break;
				}
				text2 = text2 + Class16.smethod_0(-561815507) + (i + 1) + Class16.smethod_0(-561781845) + text + Class16.smethod_0(-561793740) + num2 + Class16.smethod_0(-561781492);
				if (num2 > num)
				{
					num = num2;
					num3 = i + 1;
				}
			}
			text2 = text2 + Class16.smethod_0(-561815493) + num3 + Class16.smethod_0(-561781492);
			gForm = new GForm3(text2);
		}
		if ((int)((Form)gForm).ShowDialog() == 6)
		{
			gform4_0.method_1();
		}
		else if ((int)((Form)gForm).get_DialogResult() == 7)
		{
			((Form)gform4_0).set_DialogResult((DialogResult)7);
			((Form)gform4_0).Close();
		}
		else
		{
			bool_0 = false;
			Class24.int_0 = 5;
		}
	}
}
