using System;
using System.Runtime.Serialization;

namespace Renci.SshNet.Common;

[Serializable]
public class SshOperationTimeoutException : SshException
{
	public SshOperationTimeoutException()
	{
	}

	public SshOperationTimeoutException(string message)
		: base(message)
	{
	}

	public SshOperationTimeoutException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected SshOperationTimeoutException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
