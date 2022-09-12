using System;
using System.Runtime.Serialization;

namespace Renci.SshNet.Common;

[Serializable]
public class NetConfServerException : SshException
{
	public NetConfServerException()
	{
	}

	public NetConfServerException(string message)
		: base(message)
	{
	}

	public NetConfServerException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected NetConfServerException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
