using System;
using System.Runtime.Serialization;

namespace Renci.SshNet.Common;

[Serializable]
public class SshPassPhraseNullOrEmptyException : SshException
{
	public SshPassPhraseNullOrEmptyException()
	{
	}

	public SshPassPhraseNullOrEmptyException(string message)
		: base(message)
	{
	}

	public SshPassPhraseNullOrEmptyException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected SshPassPhraseNullOrEmptyException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
