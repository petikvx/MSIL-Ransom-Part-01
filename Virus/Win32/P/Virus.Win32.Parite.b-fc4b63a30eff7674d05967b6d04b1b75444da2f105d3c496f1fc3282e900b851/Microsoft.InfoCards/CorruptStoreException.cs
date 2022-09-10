using System;
using System.Runtime.Serialization;

namespace Microsoft.InfoCards;

internal class CorruptStoreException : Exception
{
	public CorruptStoreException()
	{
	}

	public CorruptStoreException(string message)
	{
	}

	public CorruptStoreException(string message, Exception inner)
	{
	}

	protected CorruptStoreException(SerializationInfo si, StreamingContext sc)
	{
	}
}
