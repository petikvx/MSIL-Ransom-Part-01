using System;
using System.Runtime.Serialization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public class TransactionAlreadyCommittedException : TransactionException
{
	public TransactionAlreadyCommittedException()
	{
	}

	public TransactionAlreadyCommittedException(string message)
		: base(message)
	{
	}

	public TransactionAlreadyCommittedException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected TransactionAlreadyCommittedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
