using System;
using System.Collections.Generic;
using System.Security;

namespace Microsoft.InfoCards;

internal sealed class ExceptionTranslationTable
{
	private Dictionary<Type, int> m_table;

	private static ExceptionTranslationTable s_thisTable;

	public static ExceptionTranslationTable Instance
	{
		get
		{
			if (s_thisTable == null)
			{
				s_thisTable = new ExceptionTranslationTable();
			}
			return s_thisTable;
		}
	}

	public int this[Type key] => m_table[key];

	private ExceptionTranslationTable()
	{
		m_table = new Dictionary<Type, int>();
		m_table.Add(typeof(ApplicationException), -2146232832);
		m_table.Add(typeof(InvalidOperationException), -1073413888);
		m_table.Add(typeof(NotImplementedException), -2147467263);
		m_table.Add(typeof(SecurityException), -2147024891);
	}

	public bool ContainsKey(Type key)
	{
		return m_table.ContainsKey(key);
	}
}
