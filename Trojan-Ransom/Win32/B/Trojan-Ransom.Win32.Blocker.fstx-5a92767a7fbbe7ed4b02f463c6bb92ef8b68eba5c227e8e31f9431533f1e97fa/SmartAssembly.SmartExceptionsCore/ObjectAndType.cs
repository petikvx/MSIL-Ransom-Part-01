using System;

namespace SmartAssembly.SmartExceptionsCore;

internal class ObjectAndType
{
	private readonly Type m_TypeToInterpret;

	private readonly object m_O;

	private readonly bool m_FirstLevel;

	public bool FirstLevel => m_FirstLevel;

	public ObjectAndType(object object_0, bool bool_0)
		: this(object_0, object_0?.GetType(), bool_0)
	{
	}

	public ObjectAndType(object object_0, Type type_0, bool bool_0)
	{
		m_O = object_0;
		m_TypeToInterpret = type_0;
		m_FirstLevel = bool_0;
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
