using System;
using System.Runtime.Serialization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public class TransactionException : SystemException
{
	public TransactionException()
	{
	}

	public TransactionException(string message)
		: base(message)
	{
	}

	public TransactionException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected TransactionException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
