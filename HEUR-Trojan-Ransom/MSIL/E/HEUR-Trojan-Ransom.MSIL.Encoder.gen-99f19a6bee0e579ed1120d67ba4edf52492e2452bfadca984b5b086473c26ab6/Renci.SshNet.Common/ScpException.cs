using System;
using System.Runtime.Serialization;

namespace Renci.SshNet.Common;

[Serializable]
public class ScpException : SshException
{
	public ScpException()
	{
	}

	public ScpException(string message)
		: base(message)
	{
	}

	public ScpException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected ScpException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
