using System;

namespace Microsoft.InfoCards;

internal class SerializationIncompleteException : Exception
{
	private Type m_type;

	public Type ObjectType => m_type;

	public SerializationIncompleteException(Type type)
	{
		m_type = type;
	}
}
