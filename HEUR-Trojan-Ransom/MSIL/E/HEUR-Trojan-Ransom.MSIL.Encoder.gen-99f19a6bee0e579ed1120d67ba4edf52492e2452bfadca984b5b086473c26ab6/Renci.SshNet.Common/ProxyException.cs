using System;
using System.Runtime.Serialization;

namespace Renci.SshNet.Common;

[Serializable]
public class ProxyException : SshException
{
	public ProxyException()
	{
	}

	public ProxyException(string message)
		: base(message)
	{
	}

	public ProxyException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected ProxyException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
