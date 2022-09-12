using System;
using System.Runtime.Serialization;

namespace Renci.SshNet.Common;

[Serializable]
public class SftpPermissionDeniedException : SshException
{
	public SftpPermissionDeniedException()
	{
	}

	public SftpPermissionDeniedException(string message)
		: base(message)
	{
	}

	public SftpPermissionDeniedException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected SftpPermissionDeniedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
