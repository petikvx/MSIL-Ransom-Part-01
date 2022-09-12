using System;
using System.Runtime.Serialization;

namespace Alphaleonis.Win32.Filesystem;

[Serializable]
public class UnsupportedRemoteTransactionException : TransactionException
{
	public UnsupportedRemoteTransactionException()
	{
	}

	public UnsupportedRemoteTransactionException(string message)
		: base(message)
	{
	}

	public UnsupportedRemoteTransactionException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected UnsupportedRemoteTransactionException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
