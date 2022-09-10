using System;
using System.Collections.Generic;

namespace Microsoft.InfoCards;

internal sealed class ExceptionList
{
	public static ExceptionList AllNonFatal = new ExceptionList();

	public static ExceptionList Empty = new ExceptionList();

	private Dictionary<Type, Type> m_list;

	private ExceptionList()
	{
		m_list = new Dictionary<Type, Type>(0);
	}

	public bool Contains(Type exceptionType)
	{
		return m_list.ContainsKey(exceptionType);
	}
}
