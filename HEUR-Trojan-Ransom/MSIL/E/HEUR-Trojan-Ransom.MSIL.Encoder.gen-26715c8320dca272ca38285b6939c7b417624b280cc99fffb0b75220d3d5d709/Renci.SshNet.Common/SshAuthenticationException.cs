using System;
using System.Runtime.Serialization;

namespace Renci.SshNet.Common;

[Serializable]
public class SshAuthenticationException : SshException
{
	public SshAuthenticationException()
	{
	}

	public SshAuthenticationException(string message)
		: base(message)
	{
	}

	public SshAuthenticationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected SshAuthenticationException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
