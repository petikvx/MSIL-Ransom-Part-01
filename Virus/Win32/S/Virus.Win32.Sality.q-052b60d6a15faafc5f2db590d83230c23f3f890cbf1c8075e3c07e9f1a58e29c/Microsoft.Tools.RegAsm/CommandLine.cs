using System;

namespace Microsoft.Tools.RegAsm;

internal class CommandLine
{
	private string[] m_aArgList;

	private Option[] m_aOptList;

	private int m_iArgCursor;

	private int m_iOptCursor;

	private Abbrevs m_sValidOptions;

	internal int NumArgs => m_aArgList.Length;

	internal int NumOpts => m_aOptList.Length;

	internal CommandLine(string[] aArgs, string[] aValidOpts)
	{
		m_sValidOptions = new Abbrevs(aValidOpts);
		string[] array = new string[aArgs.Length];
		Option[] array2 = new Option[aArgs.Length];
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < aArgs.Length; i++)
		{
			if (!aArgs[i].StartsWith("/", StringComparison.Ordinal) && !aArgs[i].StartsWith("-", StringComparison.Ordinal))
			{
				array[num++] = aArgs[i];
				continue;
			}
			string strValue = null;
			int num3 = aArgs[i].IndexOfAny(new char[2] { ':', '=' });
			string strOpt = ((num3 != -1) ? aArgs[i].Substring(1, num3 - 1) : aArgs[i].Substring(1));
			strOpt = m_sValidOptions.Lookup(strOpt, out var bRequiresValue, out var bCanHaveValue);
			if (bCanHaveValue || num3 == -1)
			{
				if (!bRequiresValue || num3 != -1)
				{
					if (bCanHaveValue && num3 != -1)
					{
						if (num3 == aArgs[i].Length - 1)
						{
							if (i + 1 == aArgs.Length)
							{
								throw new ApplicationException(Resource.FormatString("Err_ValueRequired", strOpt));
							}
							if (aArgs[i + 1].StartsWith("/", StringComparison.Ordinal) || aArgs[i + 1].StartsWith("-", StringComparison.Ordinal))
							{
								throw new ApplicationException(Resource.FormatString("Err_ValueRequired", strOpt));
							}
							strValue = aArgs[i + 1];
							i++;
						}
						else
						{
							strValue = aArgs[i].Substring(num3 + 1);
						}
					}
					array2[num2++] = new Option(strOpt, strValue);
					continue;
				}
				throw new ApplicationException(Resource.FormatString("Err_ValueRequired", strOpt));
			}
			throw new ApplicationException(Resource.FormatString("Err_NoValueRequired", strOpt));
		}
		m_aArgList = new string[num];
		m_aOptList = new Option[num2];
		Array.Copy(array, m_aArgList, num);
		Array.Copy(array2, m_aOptList, num2);
		m_iArgCursor = 0;
		m_iOptCursor = 0;
	}

	internal string GetNextArg()
	{
		if (m_iArgCursor >= m_aArgList.Length)
		{
			return null;
		}
		return m_aArgList[m_iArgCursor++];
	}

	internal Option GetNextOption()
	{
		if (m_iOptCursor >= m_aOptList.Length)
		{
			return null;
		}
		return m_aOptList[m_iOptCursor++];
	}
}
