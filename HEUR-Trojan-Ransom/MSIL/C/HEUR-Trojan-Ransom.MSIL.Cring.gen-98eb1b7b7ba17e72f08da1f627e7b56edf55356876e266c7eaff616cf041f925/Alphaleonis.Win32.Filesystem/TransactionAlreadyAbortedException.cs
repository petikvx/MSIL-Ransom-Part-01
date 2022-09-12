using System;
using System.Runtime.Serialization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public class TransactionAlreadyAbortedException : TransactionException
{
	public TransactionAlreadyAbortedException()
	{
	}

	public TransactionAlreadyAbortedException(string message)
		: base(message)
	{
	}

	public TransactionAlreadyAbortedException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected TransactionAlreadyAbortedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
