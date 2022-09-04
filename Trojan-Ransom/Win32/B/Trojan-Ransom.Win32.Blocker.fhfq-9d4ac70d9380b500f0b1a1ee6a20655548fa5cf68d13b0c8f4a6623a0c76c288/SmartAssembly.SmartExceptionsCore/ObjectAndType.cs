using System;

namespace SmartAssembly.SmartExceptionsCore;

internal class ObjectAndType
{
	private readonly Type m_TypeToInterpret;

	private readonly object m_O;

	private readonly bool m_FirstLevel;

	public bool FirstLevel => m_FirstLevel;

	public ObjectAndType(object o, bool firstLevel)
		: this(o, o?.GetType(), firstLevel)
	{
	}

	public ObjectAndType(object o, Type t, bool firstLevel)
	{
		m_O = o;
		m_TypeToInterpret = t;
		m_FirstLevel = firstLevel;
	}

	public object GetObject()
	{
		return m_O;
	}

	public new Type GetType()
	{
		return m_TypeToInterpret;
	}
}
