using System;
using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace ICSharpCode.SharpZipLib.Core;

public class NameFilter : IScanFilter
{
	private string DfeKEPHiBZRpmPsDFbBdNqVbMYHv;

	private ArrayList yyVXMDvNUiowFAuULtwOIZgDVidM;

	private ArrayList CNymGFCrlweBPwQEaVBEdvTLpWaP;

	public NameFilter(string filter)
	{
		DfeKEPHiBZRpmPsDFbBdNqVbMYHv = filter;
		yyVXMDvNUiowFAuULtwOIZgDVidM = new ArrayList();
		CNymGFCrlweBPwQEaVBEdvTLpWaP = new ArrayList();
		FtWKIBeOmYIdXctybqXjqIzvPZww();
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
					string pattern = ((array[i][0] == '+') ? array[i].Substring(1, array[i].Length - 1) : ((array[i][0] == '-') ? array[i].Substring(1, array[i].Length - 1) : array[i]));
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
				if (num < original.Length)
				{
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
					if (num >= original.Length)
					{
						throw new ArgumentException("Missing terminating escape character", "original");
					}
					stringBuilder.Append(original[num]);
				}
				else
				{
					arrayList.Add(stringBuilder.ToString());
				}
			}
		}
		return (string[])arrayList.ToArray(typeof(string));
	}

	public override string ToString()
	{
		return DfeKEPHiBZRpmPsDFbBdNqVbMYHv;
	}

	public bool IsIncluded(string name)
	{
		bool result = false;
		if (yyVXMDvNUiowFAuULtwOIZgDVidM.Count != 0)
		{
			foreach (Regex item in yyVXMDvNUiowFAuULtwOIZgDVidM)
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
		foreach (Regex item in CNymGFCrlweBPwQEaVBEdvTLpWaP)
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
		return IsIncluded(name) && !IsExcluded(name);
	}

	private void FtWKIBeOmYIdXctybqXjqIzvPZww()
	{
		if (DfeKEPHiBZRpmPsDFbBdNqVbMYHv == null)
		{
			return;
		}
		string[] array = SplitQuoted(DfeKEPHiBZRpmPsDFbBdNqVbMYHv);
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null && array[i].Length > 0)
			{
				bool flag = array[i][0] != '-';
				string pattern = ((array[i][0] == '+') ? array[i].Substring(1, array[i].Length - 1) : ((array[i][0] != '-') ? array[i] : array[i].Substring(1, array[i].Length - 1)));
				if (!flag)
				{
					CNymGFCrlweBPwQEaVBEdvTLpWaP.Add(new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline));
				}
				else
				{
					yyVXMDvNUiowFAuULtwOIZgDVidM.Add(new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Singleline));
				}
			}
		}
	}
}
