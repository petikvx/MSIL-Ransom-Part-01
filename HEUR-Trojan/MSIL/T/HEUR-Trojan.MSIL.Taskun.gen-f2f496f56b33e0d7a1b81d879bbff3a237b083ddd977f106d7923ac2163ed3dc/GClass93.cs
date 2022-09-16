using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

public sealed class GClass93
{
	public int int_0;

	public int int_1;

	public int int_2;

	public Color color_0;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public int int_10;

	public int int_11;

	public int[] int_12;

	public List<int> list_0;

	public List<GClass12> list_1;

	public List<GClass9> list_2;

	public List<GClass9> list_3;

	public int int_13;

	public int int_14;

	public int int_15;

	public int int_16;

	public int int_17;

	public int int_18;

	public GClass97 gclass97_0;

	public GClass5 gclass5_0;

	public GClass93(int int_19)
	{
		int_0 = 1;
		int_1 = 0;
		int_2 = 0;
		color_0 = Color.Black;
		int_3 = 0;
		int_4 = 0;
		int_5 = 0;
		int_6 = 0;
		int_7 = 0;
		int_8 = 0;
		int_9 = 0;
		int_10 = 100;
		int_11 = 0;
		int_12 = new int[107];
		list_0 = new List<int>();
		list_1 = new List<GClass12>();
		list_2 = new List<GClass9>();
		list_3 = new List<GClass9>();
		int_13 = 0;
		int_14 = 0;
		int_15 = 0;
		int_16 = 0;
		int_17 = 0;
		int_18 = 0;
		gclass97_0 = null;
		gclass5_0 = null;
		int_1 = int_19;
		int_2 = 0;
		int_3 = 110;
		int_0 = 1;
		checked
		{
			int num = int_12.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				int_12[i] = 0;
			}
		}
	}

	public void method_0()
	{
		if (int_0 == 2)
		{
			gclass5_0 = new GClass5();
		}
	}

	public string method_1()
	{
		string text = Class16.smethod_0(-561815507) + checked(int_1 + 1);
		if (int_0 != 1)
		{
			text = ((int_0 != 2) ? (text + Class16.smethod_0(-561834780)) : (text + Class16.smethod_0(-561834791)));
		}
		return text;
	}

	public List<GClass91> method_2()
	{
		List<GClass91> list = new List<GClass91>();
		int num = 0;
		checked
		{
			do
			{
				int num2 = 0;
				do
				{
					GClass97 gClass = Class24.gclass97_0[num, num2];
					if (gClass.method_20(int_1))
					{
						list.AddRange(gClass.list_0);
					}
					num2++;
				}
				while (num2 <= 11);
				num++;
			}
			while (num <= 11);
			return list;
		}
	}

	public int method_3()
	{
		int num = 0;
		int num2 = 0;
		checked
		{
			do
			{
				int num3 = 0;
				do
				{
					if (Class24.gclass97_0[num2, num3].method_20(int_1))
					{
						num += Class24.gclass97_0[num2, num3].method_2();
					}
					num3++;
				}
				while (num3 <= 11);
				num2++;
			}
			while (num2 <= 11);
			int_4 = num;
			return num;
		}
	}

	public List<GClass97> method_4()
	{
		List<GClass97> list = new List<GClass97>();
		int num = 0;
		checked
		{
			do
			{
				int num2 = 0;
				do
				{
					if (Class24.gclass97_0[num, num2].method_20(int_1))
					{
						list.Add(Class24.gclass97_0[num, num2]);
					}
					num2++;
				}
				while (num2 <= 11);
				num++;
			}
			while (num <= 11);
			return list;
		}
	}

	public int method_5()
	{
		int num = 0;
		int num2 = 0;
		checked
		{
			do
			{
				int num3 = 0;
				do
				{
					if (Class24.gclass97_0[num2, num3].method_20(int_1))
					{
						num++;
					}
					num3++;
				}
				while (num3 <= 11);
				num2++;
			}
			while (num2 <= 11);
			int_7 = num;
			return num;
		}
	}

	public List<GClass97> method_6()
	{
		List<GClass97> list = new List<GClass97>();
		int num = 0;
		checked
		{
			do
			{
				int num2 = 0;
				do
				{
					GClass97 gClass = Class24.gclass97_0[num, num2];
					if (!gClass.method_19() & (gClass.int_6 != 4))
					{
						List<GClass97> list2 = gClass.method_42();
						int num3 = list2.Count - 1;
						for (int i = 0; i <= num3; i++)
						{
							GClass97 gClass2 = list2[i];
							if (gClass2.method_20(int_1))
							{
								list.Add(gClass);
								break;
							}
						}
					}
					num2++;
				}
				while (num2 <= 11);
				num++;
			}
			while (num <= 11);
			return list;
		}
	}

	public int method_7()
	{
		int num = 0;
		int num2 = 0;
		checked
		{
			do
			{
				int num3 = 0;
				do
				{
					if (Class24.gclass97_0[num2, num3].method_20(int_1))
					{
						num += Class24.gclass97_0[num2, num3].method_4();
					}
					num3++;
				}
				while (num3 <= 11);
				num2++;
			}
			while (num2 <= 11);
			int_8 = num;
			return num;
		}
	}

	public int method_8()
	{
		int_7 = 0;
		int_4 = 0;
		int_8 = 0;
		int_6 = 0;
		int_5 = 0;
		int_9 = 0;
		IEnumerator enumerator = Class24.gclass97_0.GetEnumerator();
		checked
		{
			while (enumerator.MoveNext())
			{
				GClass97 gClass = (GClass97)enumerator.Current;
				if (!gClass.method_20(int_1))
				{
					continue;
				}
				int_7++;
				int_4 += gClass.method_2();
				int_8 += gClass.method_4();
				int_6 += gClass.method_7();
				int_5 += gClass.method_6();
				foreach (GClass91 item in gClass.list_0)
				{
					ref int reference = ref int_9;
					reference = (int)Math.Round((double)reference + item.method_32());
				}
			}
			ref int reference2 = ref int_9;
			reference2 = (int)Math.Round((double)reference2 + (double)int_8 * 4.0);
			ref int reference3 = ref int_9;
			reference3 = (int)Math.Round((double)reference3 + (double)int_7 * 12.0);
			ref int reference4 = ref int_9;
			reference4 = (int)Math.Round((double)reference4 + Class24.smethod_1(int_6, int_4) * (double)int_9 * 0.2);
			return int_9;
		}
	}

	public int method_9()
	{
		int num = 50;
		int num2 = 0;
		checked
		{
			do
			{
				int num3 = 0;
				do
				{
					GClass97 gClass = Class24.gclass97_0[num2, num3];
					if (gClass.method_20(int_1) && gClass.int_6 != 5)
					{
						num += 20;
					}
					num3++;
				}
				while (num3 <= 11);
				num2++;
			}
			while (num2 <= 11);
			return num;
		}
	}

	public int method_10()
	{
		return int_10;
	}

	public int method_11()
	{
		return int_11;
	}

	public void method_12()
	{
		checked
		{
			int_11 += 10 + int_13;
		}
	}

	public bool method_13(GClass97 gclass97_1)
	{
		if (gclass97_1.method_19() | (gclass97_1.int_6 == 4))
		{
			return false;
		}
		checked
		{
			int num = list_3.Count - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					if (list_3[num2].vmethod_29(ref gclass97_1))
					{
						break;
					}
					num2++;
					continue;
				}
				List<GClass97> list = gclass97_1.method_42();
				int num3 = list.Count - 1;
				int num4 = 0;
				while (true)
				{
					if (num4 <= num3)
					{
						GClass97 gClass = list[num4];
						if (gClass.method_20(int_1))
						{
							break;
						}
						num4++;
						continue;
					}
					return false;
				}
				return true;
			}
			return true;
		}
	}

	public bool method_14(GClass97 gclass97_1, ref int int_19)
	{
		if (!gclass97_1.method_19())
		{
			return false;
		}
		checked
		{
			if (!gclass97_1.method_20(int_1))
			{
				if (int_14 <= 0)
				{
					return false;
				}
				double num = 1.3 - (double)int_14 * 0.1;
				int_19 = (int)Math.Round((double)int_19 * num);
			}
			if (gclass97_1.method_13(22) > 0)
			{
				int_19 = (int)Math.Round((double)int_19 * 1.4);
			}
			return true;
		}
	}

	public int method_15()
	{
		int num = 1;
		checked
		{
			int num2 = int_16 - 1;
			for (int i = 0; i <= num2; i++)
			{
				if (Class24.smethod_0(0, 1) == 0)
				{
					num++;
				}
			}
			return num;
		}
	}

	public override string ToString()
	{
		string empty = string.Empty;
		empty = empty + method_1().ToString() + Class16.smethod_0(-561781492);
		empty = empty + Class16.smethod_0(-561814139) + int_3 + Class16.smethod_0(-561781492);
		empty = empty + Class16.smethod_0(-561834770) + int_4 + Class16.smethod_0(-561781492);
		empty = empty + Class16.smethod_0(-561781957) + int_6 + Class16.smethod_0(-561781944) + int_5 + Class16.smethod_0(-561781492);
		empty = empty + Class16.smethod_0(-561834758) + int_7 + Class16.smethod_0(-561781492);
		empty = empty + Class16.smethod_0(-561791113) + int_8 + Class16.smethod_0(-561781492);
		empty = empty + Class16.smethod_0(-561834228) + int_9 + Class16.smethod_0(-561781492);
		return empty + Class16.smethod_0(-561834214) + int_11;
	}

	public int method_16(ref GClass9[] gclass9_0)
	{
		if (gclass5_0.method_3())
		{
			return -1;
		}
		double num = 0.0;
		double num2 = 0.0;
		List<GClass91> list = method_2();
		List<GClass97> list2 = method_4();
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		checked
		{
			int num6 = list.Count - 1;
			for (int i = 0; i <= num6; i++)
			{
				GClass91 gClass = list[i];
				if (gClass.gclass9_0 == null)
				{
					num4++;
				}
				else
				{
					num3++;
				}
				GClass97 gclass97_ = gClass.gclass97_1;
				num5 += gclass97_.int_7;
			}
			num2 = 100.0 * Class24.smethod_1(num4, list.Count) * gclass5_0.method_10();
			double num7 = Class24.smethod_1(num5, list.Count);
			num = 100.0 * Class24.smethod_1(4.0 - num7, 4.0) * gclass5_0.method_9();
			double double_ = Class24.smethod_1(list.Count, list2.Count);
			Class24.smethod_1(double_, 20.0);
			gclass5_0.method_11();
			GClass97 gClass2 = null;
			double num8 = -1.0;
			GClass97 gClass3 = null;
			double num9 = -1.0;
			int num10 = list2.Count - 1;
			for (int j = 0; j <= num10; j++)
			{
				GClass97 gClass4 = list2[j];
				double num11 = gClass4.method_10() - (double)gClass4.method_8();
				num11 *= gclass5_0.method_4();
				if (num11 > num8)
				{
					num8 = num11;
					gClass2 = gClass4;
				}
				double num12 = (double)(4 - gClass4.int_7) / 4.0 * (double)gClass4.method_2();
				num12 *= gclass5_0.method_4();
				if (num12 > num9)
				{
					num9 = num12;
					gClass3 = gClass4;
				}
			}
			double[] array = new double[gclass9_0.Length - 1 + 1];
			double num13 = 0.0;
			int num14 = gclass9_0.Length - 1;
			for (int k = 0; k <= num14; k++)
			{
				GClass9 gClass5 = gclass9_0[k];
				if (gClass5 == null)
				{
					array[k] = -2.0;
					continue;
				}
				if (list_0.Contains(gClass5.int_0))
				{
					array[k] = -2.0;
				}
				else
				{
					array[k] = num2 * gClass5.method_22(ref gclass5_0);
				}
				num13 += array[k];
			}
			double num15 = Class24.smethod_1(num13, gclass9_0.Length);
			double item = num * num9 / 50.0;
			List<GClass97> list3 = method_6();
			int num16 = method_9();
			int num17 = num16;
			GClass97 gClass6 = null;
			double num18 = -1.0;
			int num19 = list3.Count - 1;
			for (int l = 0; l <= num19; l++)
			{
				GClass97 gClass7 = list3[l];
				int num20 = 0;
				List<GClass97> list4 = gClass7.method_42();
				int num21 = list4.Count - 1;
				for (int m = 0; m <= num21; m++)
				{
					GClass97 gClass8 = list4[m];
					if (gClass8.method_20(int_1))
					{
						num20 += gClass8.method_2();
					}
				}
				double num22 = (double)num20 / 2.0;
				double num23 = 0.0;
				double num24 = num16;
				switch (gClass7.int_6)
				{
				case 1:
					num24 -= 50.0;
					num22 *= 0.95;
					break;
				case 2:
					num22 *= 1.25;
					break;
				case 3:
					num23 = num15;
					num22 *= 0.85;
					break;
				case 5:
					num24 = 10.0;
					num22 *= 0.5;
					break;
				case 6:
					num22 *= 0.8;
					num23 += 2.0;
					break;
				case 7:
					num24 *= 0.5;
					num22 *= 0.75;
					break;
				}
				if (gClass7.bool_0)
				{
					num22 *= 1.05;
				}
				double num25 = num2 * num22 / num24 + num23;
				num25 *= gclass5_0.method_6(gClass7.int_6);
				if (gClass7.bool_0)
				{
					num25 *= gclass5_0.method_6(4);
				}
				num25 *= gclass5_0.method_4();
				if (num25 > num18)
				{
					num18 = num25;
					gClass6 = gClass7;
					num17 = ((gClass7.int_6 != 5) ? ((int)Math.Round(num24)) : 0);
				}
			}
			double item2 = num18;
			List<double> list5 = new List<double>();
			list5.AddRange(array);
			list5.Add(item);
			list5.Add(item2);
			double num26 = -1.0;
			int num27 = -1;
			int num28 = list5.Count - 1;
			for (int n = 0; n <= num28; n++)
			{
				if (gclass5_0.list_0.Contains((GClass5.GEnum0)40))
				{
					int num29 = 0;
					if (n <= 4)
					{
						if (gclass9_0[n] != null)
						{
							num29 = gclass9_0[n].vmethod_9();
						}
					}
					else
					{
						switch (n)
						{
						case 5:
							num29 = 50;
							break;
						case 6:
							num29 = num17;
							break;
						}
					}
					if (int_3 < num29)
					{
						continue;
					}
				}
				if (list5[n] > num26)
				{
					num26 = list5[n];
					num27 = n;
				}
			}
			if (num27 == -1)
			{
				gclass97_0 = null;
			}
			else if (num27 <= 4)
			{
				gclass97_0 = gClass2;
			}
			else
			{
				switch (num27)
				{
				case 5:
					gclass97_0 = gClass3;
					break;
				case 6:
					gclass97_0 = gClass6;
					break;
				default:
					gclass97_0 = null;
					break;
				}
			}
			if (gclass97_0 == null)
			{
				num27 = -1;
			}
			return num27;
		}
	}

	public double method_17()
	{
		if (int_0 == 2)
		{
			return gclass5_0.method_1();
		}
		return 1.0;
	}

	public double method_18()
	{
		if (int_0 == 2)
		{
			return gclass5_0.method_2();
		}
		return 1.0;
	}
}
