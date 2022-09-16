using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Os4illography;

internal class St7ure
{
	private static readonly St7ure Evu8ses = new St7ure();

	private St7ure()
	{
	}

	public static St7ure smethod_0()
	{
		return Evu8ses;
	}

	public double A2akenings(string Ca44ithump)
	{
		List<string> list = Myotome4(Ca44ithump);
		List<double> list2 = method_0(Ca44ithump);
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

	private List<double> method_0(string Thr6adworm)
	{
		Thr6adworm = Sp2eade2(Thr6adworm);
		List<double> list = new List<double>();
		string[] array = Regex.Split(Thr6adworm, "[\\+\\-\\*/]");
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

	private string Sp2eade2(string Commentar2)
	{
		char[] array = Commentar2.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			if (i == 0 && array[i] == '-')
			{
				Commentar2 = "@" + Commentar2.Substring(i + 1);
			}
			if ((array[i] == '*' && array[i + 1] == '-') || (array[i] == '/' && array[i + 1] == '-'))
			{
				Commentar2 = Commentar2.Substring(0, i + 1) + "@" + Commentar2.Substring(i + 2);
			}
		}
		return Commentar2;
	}

	private List<string> Myotome4(string Inter1or1zes)
	{
		List<string> list = new List<string>();
		Inter1or1zes = Sp2eade2(Inter1or1zes);
		string[] array = Regex.Split(Inter1or1zes, "[0-9\\.@]");
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
