using System;
using System.Runtime.Serialization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public class TransactionalConflictException : TransactionException
{
	public TransactionalConflictException()
	{
	}

	public TransactionalConflictException(string message)
		: base(message)
	{
	}

	public TransactionalConflictException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected TransactionalConflictException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
