using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Dumortierite1;

internal class Tera1hms
{
	private static readonly Tera1hms Wes5ernizing = new Tera1hms();

	private Tera1hms()
	{
	}

	public static Tera1hms Granu5ate()
	{
		return Wes5ernizing;
	}

	public double Shelle1(string Dalto0s)
	{
		List<string> list = Mon8cian(Dalto0s);
		List<double> list2 = Sli5(Dalto0s);
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Contains("*") || list[i].Contains("/"))
			{
				string text = list[i];
				list.RemoveAt(i);
				if (text.Equals("*"))
				{
					double num = list2[i];
					list2.RemoveAt(i);
					double num2 = list2[i];
					list2.RemoveAt(i);
					double item = num * num2;
					list2.Insert(i, item);
				}
				if (text.Equals("/"))
				{
					double num3 = list2[i];
					list2.RemoveAt(i);
					double num4 = list2[i];
					list2.RemoveAt(i);
					double item2 = num3 / num4;
					list2.Insert(i, item2);
				}
				i--;
			}
		}
		while (list.Count != 0)
		{
			string text2 = list[0];
			list.RemoveAt(0);
			double num5 = list2[0];
			list2.RemoveAt(0);
			double num6 = list2[0];
			list2.RemoveAt(0);
			if (text2.Equals("+"))
			{
				double item3 = num5 + num6;
				list2.Insert(0, item3);
			}
			if (text2.Equals("-"))
			{
				double item4 = num5 - num6;
				list2.Insert(0, item4);
			}
		}
		return list2[0];
	}

	private List<double> Sli5(string Symphyse8l)
	{
		Symphyse8l = Swordpl2ys(Symphyse8l);
		List<double> list = new List<double>();
		string[] array = Regex.Split(Symphyse8l, "[\\+\\-\\*/]");
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i];
			if (text.Contains("@"))
			{
				text = "-" + text.Substring(1);
			}
			list.Add(double.Parse(text));
		}
		return list;
	}

	private string Swordpl2ys(string Midshi3s)
	{
		char[] array = Midshi3s.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			if (i == 0 && array[i] == '-')
			{
				Midshi3s = "@" + Midshi3s.Substring(i + 1);
			}
			if ((array[i] == '*' && array[i + 1] == '-') || (array[i] == '/' && array[i + 1] == '-'))
			{
				Midshi3s = Midshi3s.Substring(0, i + 1) + "@" + Midshi3s.Substring(i + 2);
			}
		}
		return Midshi3s;
	}

	private List<string> Mon8cian(string Fis5ula5e)
	{
		List<string> list = new List<string>();
		Fis5ula5e = Swordpl2ys(Fis5ula5e);
		string[] array = Regex.Split(Fis5ula5e, "[0-9\\.@]");
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].Contains("+") || array[i].Contains("-") || array[i].Contains("*") || array[i].Contains("/"))
			{
				list.Add(array[i]);
			}
		}
		return list;
	}
}
