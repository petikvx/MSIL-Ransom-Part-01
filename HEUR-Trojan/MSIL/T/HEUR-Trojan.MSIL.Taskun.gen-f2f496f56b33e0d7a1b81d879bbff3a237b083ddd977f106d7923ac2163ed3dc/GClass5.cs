using System.Collections.Generic;
using Microsoft.VisualBasic;

public sealed class GClass5
{
	public enum GEnum0
	{

	}

	public enum GEnum1
	{

	}

	public int int_0;

	public List<GEnum0> list_0;

	public GClass5()
	{
		int_0 = 0;
		list_0 = new List<GEnum0>();
		method_0();
	}

	public void method_0()
	{
		int_0 = Class24.smethod_0(0, 3);
		int num = 0;
		do
		{
			int num2 = Class24.smethod_0(-5, 41);
			if (!list_0.Contains((GEnum0)num2) && num2 >= 0)
			{
				list_0.Add((GEnum0)num2);
			}
			num = checked(num + 1);
		}
		while (num <= 2);
	}

	public double method_1()
	{
		double num = default(double);
		return int_0 switch
		{
			0 => 0.8, 
			1 => 0.9, 
			2 => 1.0, 
			3 => 1.1, 
			_ => num, 
		};
	}

	public double method_2()
	{
		double num = default(double);
		return int_0 switch
		{
			0 => 0.8, 
			1 => 0.9, 
			2 => 1.0, 
			3 => 1.1, 
			_ => num, 
		};
	}

	public bool method_3()
	{
		if (list_0.Contains((GEnum0)39) && Class24.smethod_0(0, 1) == 0)
		{
			return true;
		}
		return false;
	}

	public double method_4()
	{
		double num = 0.0;
		switch (int_0)
		{
		case 0:
			num = 0.4;
			break;
		case 1:
			num = 0.2;
			break;
		case 2:
			num = 0.1;
			break;
		case 3:
			num = 0.0;
			break;
		}
		if (list_0.Contains((GEnum0)38))
		{
			num += 0.5;
		}
		double num2 = num * 2.0;
		return 1.0 + (num - (double)VBMath.Rnd() * num2);
	}

	public double method_5(int int_1)
	{
		double result = 5.0;
		double result2 = -3.0;
		if (list_0.Contains((GEnum0)41))
		{
			result = 999999999.9;
			result2 = -999999999.9;
		}
		switch (int_1)
		{
		default:
			return 1.0;
		case 0:
			if (list_0.Contains((GEnum0)24))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)31))
			{
				return result2;
			}
			return 1.0;
		case 1:
			if (list_0.Contains((GEnum0)25))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)32))
			{
				return result2;
			}
			return 1.0;
		case 2:
			if (list_0.Contains((GEnum0)3))
			{
				return 2.0;
			}
			if (list_0.Contains((GEnum0)7))
			{
				return 0.5;
			}
			return 1.0;
		case 3:
			if (list_0.Contains((GEnum0)26))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)33))
			{
				return result2;
			}
			return 1.0;
		case 4:
			if (list_0.Contains((GEnum0)27))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)34))
			{
				return result2;
			}
			return 1.0;
		case 5:
			if (list_0.Contains((GEnum0)28))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)35))
			{
				return result2;
			}
			return 1.0;
		case 6:
			if (list_0.Contains((GEnum0)37))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)30))
			{
				return result2;
			}
			return 1.0;
		case 7:
			if (list_0.Contains((GEnum0)36))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)29))
			{
				return result2;
			}
			return 1.0;
		}
	}

	public double method_6(int int_1)
	{
		double result = 2.0;
		double result2 = 0.5;
		double result3 = 0.2;
		if (list_0.Contains((GEnum0)41))
		{
			result = 999999999.9;
			result2 = -999999999.9;
			result3 = -999999999.9;
		}
		switch (int_1)
		{
		default:
			return 1.0;
		case 0:
			if (list_0.Contains((GEnum0)8))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)16))
			{
				return result2;
			}
			return 1.0;
		case 1:
			if (list_0.Contains((GEnum0)9))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)17))
			{
				return result2;
			}
			return 1.0;
		case 2:
			if (list_0.Contains((GEnum0)10))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)18))
			{
				return result2;
			}
			return 1.0;
		case 3:
			if (list_0.Contains((GEnum0)12))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)20))
			{
				return result3;
			}
			return 1.0;
		case 4:
			if (list_0.Contains((GEnum0)15))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)23))
			{
				return result2;
			}
			return 1.0;
		case 5:
			if (list_0.Contains((GEnum0)13))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)21))
			{
				return result3;
			}
			return 1.0;
		case 6:
			if (list_0.Contains((GEnum0)14))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)22))
			{
				return result2;
			}
			return 1.0;
		case 7:
			if (list_0.Contains((GEnum0)11))
			{
				return result;
			}
			if (list_0.Contains((GEnum0)19))
			{
				return result2;
			}
			return 1.0;
		}
	}

	public double method_7()
	{
		if (list_0.Contains((GEnum0)41))
		{
			return 999999999.9;
		}
		return 1.5;
	}

	public double method_8()
	{
		if (list_0.Contains((GEnum0)41))
		{
			return -1.0;
		}
		return 0.5;
	}

	public double method_9()
	{
		if (list_0.Contains((GEnum0)2))
		{
			return method_7();
		}
		if (list_0.Contains((GEnum0)6))
		{
			return method_8();
		}
		return 1.0;
	}

	public double method_10()
	{
		if (list_0.Contains((GEnum0)0))
		{
			return method_7();
		}
		if (list_0.Contains((GEnum0)4))
		{
			return method_8();
		}
		return 1.0;
	}

	public double method_11()
	{
		if (list_0.Contains((GEnum0)1))
		{
			return method_7();
		}
		if (list_0.Contains((GEnum0)5))
		{
			return method_8();
		}
		return 1.0;
	}

	public override string ToString()
	{
		string text = string.Empty;
		switch (int_0)
		{
		case 0:
			text += Class16.smethod_0(-561781483);
			break;
		case 1:
			text += Class16.smethod_0(-561781470);
			break;
		case 2:
			text += Class16.smethod_0(-561781456);
			break;
		case 3:
			text += Class16.smethod_0(-561781446);
			break;
		}
		if (list_0.Count > 0)
		{
			text += Class16.smethod_0(-561781432);
		}
		checked
		{
			int num = list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				switch (list_0[i])
				{
				case (GEnum0)0:
					text += Class16.smethod_0(-561781423);
					break;
				case (GEnum0)1:
					text += Class16.smethod_0(-561781409);
					break;
				case (GEnum0)2:
					text += Class16.smethod_0(-561781390);
					break;
				case (GEnum0)3:
					text += Class16.smethod_0(-561781377);
					break;
				case (GEnum0)4:
					text += Class16.smethod_0(-561781362);
					break;
				case (GEnum0)5:
					text += Class16.smethod_0(-561781350);
					break;
				case (GEnum0)6:
					text += Class16.smethod_0(-561781336);
					break;
				case (GEnum0)7:
					text += Class16.smethod_0(-561781319);
					break;
				case (GEnum0)8:
					text += Class16.smethod_0(-561781308);
					break;
				case (GEnum0)9:
					text += Class16.smethod_0(-561781294);
					break;
				case (GEnum0)10:
					text += Class16.smethod_0(-561781281);
					break;
				case (GEnum0)11:
					text += Class16.smethod_0(-561781262);
					break;
				case (GEnum0)12:
					text += Class16.smethod_0(-561781757);
					break;
				case (GEnum0)13:
					text += Class16.smethod_0(-561781739);
					break;
				case (GEnum0)14:
					text += Class16.smethod_0(-561781719);
					break;
				case (GEnum0)15:
					text += Class16.smethod_0(-561781703);
					break;
				case (GEnum0)16:
					text += Class16.smethod_0(-561781689);
					break;
				case (GEnum0)17:
					text += Class16.smethod_0(-561781672);
					break;
				case (GEnum0)18:
					text += Class16.smethod_0(-561781656);
					break;
				case (GEnum0)19:
					text += Class16.smethod_0(-561781640);
					break;
				case (GEnum0)20:
					text += Class16.smethod_0(-561781624);
					break;
				case (GEnum0)21:
					text += Class16.smethod_0(-561781608);
					break;
				case (GEnum0)22:
					text += Class16.smethod_0(-561781589);
					break;
				case (GEnum0)23:
					text += Class16.smethod_0(-561781571);
					break;
				case (GEnum0)24:
					text += Class16.smethod_0(-561781538);
					break;
				case (GEnum0)25:
					text += Class16.smethod_0(-561781555);
					break;
				case (GEnum0)26:
					text += Class16.smethod_0(-561781522);
					break;
				case (GEnum0)27:
					text += Class16.smethod_0(-561781511);
					break;
				case (GEnum0)28:
					text += Class16.smethod_0(-561780986);
					break;
				case (GEnum0)29:
					text += Class16.smethod_0(-561780971);
					break;
				case (GEnum0)30:
					text += Class16.smethod_0(-561780951);
					break;
				case (GEnum0)31:
					text += Class16.smethod_0(-561780923);
					break;
				case (GEnum0)32:
					text += Class16.smethod_0(-561780934);
					break;
				case (GEnum0)33:
					text += Class16.smethod_0(-561780908);
					break;
				case (GEnum0)34:
					text += Class16.smethod_0(-561780884);
					break;
				case (GEnum0)35:
					text += Class16.smethod_0(-561780870);
					break;
				case (GEnum0)36:
					text += Class16.smethod_0(-561780851);
					break;
				case (GEnum0)37:
					text += Class16.smethod_0(-561780839);
					break;
				case (GEnum0)38:
					text += Class16.smethod_0(-561780827);
					break;
				case (GEnum0)39:
					text += Class16.smethod_0(-561780811);
					break;
				case (GEnum0)40:
					text += Class16.smethod_0(-561780799);
					break;
				case (GEnum0)41:
					text += Class16.smethod_0(-561780781);
					break;
				case (GEnum0)42:
					text += Class16.smethod_0(-561780764);
					break;
				}
				if (i != list_0.Count - 1)
				{
					text += Class16.smethod_0(-561781432);
				}
			}
			return text;
		}
	}
}
