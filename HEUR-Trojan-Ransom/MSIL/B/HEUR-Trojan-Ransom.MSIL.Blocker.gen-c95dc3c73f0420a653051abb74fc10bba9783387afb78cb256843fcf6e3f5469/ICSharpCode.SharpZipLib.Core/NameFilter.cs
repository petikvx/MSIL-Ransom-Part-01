using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace ICSharpCode.SharpZipLib.Core;

public class NameFilter : IScanFilter
{
	private string KuusQqrfZyGBwcSaYrUUdkCeAnQy;

	private ArrayList vkFkQcNdUXEcLlyjAzRliyzMTUwi;

	private ArrayList LUkaZaqfrBjVZBpIdMjdHGSQfexH;

	public NameFilter(string filter)
	{
		KuusQqrfZyGBwcSaYrUUdkCeAnQy = filter;
		vkFkQcNdUXEcLlyjAzRliyzMTUwi = new ArrayList();
		LUkaZaqfrBjVZBpIdMjdHGSQfexH = new ArrayList();
		CGGcEyWJqzJaPMNFgSNUidsyFapP();
	}

	public static bool IsValidExpression(string expression)
	{
		bool result = true;
		try
		{
			new Regex(expression, RegexOptions.IgnoreCase | RegexOptions.Singleline);
			return result;
		}
		catch (ArgumentException)
		{
			return false;
		}
	}

	public static bool IsValidFilterExpression(string toTest)
	{
		if (toTest == null)
		{
			throw new ArgumentNullException("toTest");
		}
		bool result = true;
		try
		{
			string[] array = SplitQuoted(toTest);
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null && array[i].Length > 0)
				{
					string pattern = ((array[i][0] == '+') ? array[i].Substring(1, array[i].Length - 1) : ((array[i][0] != '-') ? array[i] : array[i].Substring(1, array[i].Length - 1)));
					new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Singleline);
				}
			}
			return result;
		}
		catch (ArgumentException)
		{
			return false;
		}
	}

	public static string[] SplitQuoted(string original)
	{
		char c = '\\';
		char[] array = new char[1] { ';' };
		ArrayList arrayList = new ArrayList();
		if (original != null && original.Length > 0)
		{
			int num = -1;
			StringBuilder stringBuilder = new StringBuilder();
			while (num < original.Length)
			{
				num++;
				if (num >= original.Length)
				{
					arrayList.Add(stringBuilder.ToString());
					continue;
				}
				if (original[num] != c)
				{
					if (Array.IndexOf(array, original[num]) < 0)
					{
						stringBuilder.Append(original[num]);
						continue;
					}
					arrayList.Add(stringBuilder.ToString());
					stringBuilder.Length = 0;
					continue;
				}
				num++;
				if (num < original.Length)
				{
					stringBuilder.Append(original[num]);
					continue;
				}
				throw new ArgumentException("Missing terminating escape character", "original");
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	public override string ToString()
	{
		return KuusQqrfZyGBwcSaYrUUdkCeAnQy;
	}

	public bool IsIncluded(string name)
	{
		bool result = false;
		if (vkFkQcNdUXEcLlyjAzRliyzMTUwi.Count != 0)
		{
			foreach (Regex item in vkFkQcNdUXEcLlyjAzRliyzMTUwi)
			{
				if (item.IsMatch(name))
				{
					return true;
				}
			}
			return result;
		}
		return true;
	}

	public bool IsExcluded(string name)
	{
		bool result = false;
		foreach (Regex item in LUkaZaqfrBjVZBpIdMjdHGSQfexH)
		{
			if (item.IsMatch(name))
			{
				return true;
			}
		}
		return result;
	}

	public bool IsMatch(string name)
	{
		if (IsIncluded(name))
		{
			return !IsExcluded(name);
		}
		return false;
	}

	private void CGGcEyWJqzJaPMNFgSNUidsyFapP()
	{
		if (KuusQqrfZyGBwcSaYrUUdkCeAnQy == null)
		{
			return;
		}
		string[] array = SplitQuoted(KuusQqrfZyGBwcSaYrUUdkCeAnQy);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null && array[i].Length > 0)
			{
				bool num = array[i][0] != '-';
				string pattern = ((array[i][0] == '+') ? array[i].Substring(1, array[i].Length - 1) : ((array[i][0] != '-') ? array[i] : array[i].Substring(1, array[i].Length - 1)));
				if (num)
				{
					vkFkQcNdUXEcLlyjAzRliyzMTUwi.Add(new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline));
				}
				else
				{
					LUkaZaqfrBjVZBpIdMjdHGSQfexH.Add(new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline));
				}
			}
		}
	}
}
