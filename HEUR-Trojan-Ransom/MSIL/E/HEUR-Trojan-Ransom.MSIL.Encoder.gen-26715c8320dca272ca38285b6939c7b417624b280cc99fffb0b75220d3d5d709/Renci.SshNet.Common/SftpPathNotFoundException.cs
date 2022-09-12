using System;
using System.Runtime.Serialization;

namespace Renci.SshNet.Common;

[Serializable]
public class SftpPathNotFoundException : SshException
{
	public SftpPathNotFoundException()
	{
	}

	public SftpPathNotFoundException(string message)
		: base(message)
	{
	}

	public SftpPathNotFoundException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected SftpPathNotFoundException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
