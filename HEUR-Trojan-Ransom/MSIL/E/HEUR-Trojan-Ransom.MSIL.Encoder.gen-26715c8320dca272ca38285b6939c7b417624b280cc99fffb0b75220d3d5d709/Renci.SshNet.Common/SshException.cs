using System;
using System.Runtime.Serialization;

namespace Renci.SshNet.Common;

[Serializable]
public class SshException : Exception
{
	public SshException()
	{
	}

	public SshException(string message)
		: base(message)
	{
	}

	public SshException(string message, Exception inner)
		: base(message, inner)
	{
	}

	protected SshException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
