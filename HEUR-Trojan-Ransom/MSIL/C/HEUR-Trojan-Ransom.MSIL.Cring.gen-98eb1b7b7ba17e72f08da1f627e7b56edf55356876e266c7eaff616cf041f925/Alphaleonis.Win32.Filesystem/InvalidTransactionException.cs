using System;
using System.Runtime.Serialization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public class InvalidTransactionException : TransactionException
{
	public InvalidTransactionException()
	{
	}

	public InvalidTransactionException(string message)
		: base(message)
	{
	}

	public InvalidTransactionException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected InvalidTransactionException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
