using System;
using System.Globalization;

namespace Microsoft.Tools.RegAsm;

internal class Abbrevs
{
	private string[] m_aOptions;

	private bool[] m_bRequiresValue;

	private bool[] m_bCanHaveValue;

	internal Abbrevs(string[] aOptions)
	{
		m_aOptions = new string[aOptions.Length];
		m_bRequiresValue = new bool[aOptions.Length];
		m_bCanHaveValue = new bool[aOptions.Length];
		for (int i = 0; i < aOptions.Length; i++)
		{
			string text = aOptions[i].ToLower(CultureInfo.InvariantCulture);
			if (text.StartsWith("*", StringComparison.Ordinal))
			{
				m_bRequiresValue[i] = true;
				m_bCanHaveValue[i] = true;
				text = text.Substring(1);
			}
			else if (text.StartsWith("+", StringComparison.Ordinal))
			{
				m_bRequiresValue[i] = false;
				m_bCanHaveValue[i] = true;
				text = text.Substring(1);
			}
			m_aOptions[i] = text;
		}
	}

	internal string Lookup(string strOpt, out bool bRequiresValue, out bool bCanHaveValue)
	{
		bool flag = false;
		int num = -1;
		int num2 = 0;
		while (true)
		{
			if (num2 < m_aOptions.Length)
			{
				if (strOpt.Equals(m_aOptions[num2], StringComparison.OrdinalIgnoreCase))
				{
					break;
				}
				if (m_aOptions[num2].StartsWith(strOpt, StringComparison.OrdinalIgnoreCase))
				{
					if (flag)
					{
						throw new ApplicationException(Resource.FormatString("Err_AmbigousOption", strOpt));
					}
					flag = true;
					num = num2;
				}
				num2++;
				continue;
			}
			if (flag)
			{
				bRequiresValue = m_bRequiresValue[num];
				bCanHaveValue = m_bCanHaveValue[num];
				return m_aOptions[num];
			}
			throw new ApplicationException(Resource.FormatString("Err_UnknownOption", strOpt));
		}
		bRequiresValue = m_bRequiresValue[num2];
		bCanHaveValue = m_bCanHaveValue[num2];
		return m_aOptions[num2];
	}
}
