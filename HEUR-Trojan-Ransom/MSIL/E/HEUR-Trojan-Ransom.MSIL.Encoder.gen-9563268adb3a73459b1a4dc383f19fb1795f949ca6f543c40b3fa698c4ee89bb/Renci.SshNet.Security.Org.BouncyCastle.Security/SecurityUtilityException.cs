using System;

namespace Renci.SshNet.Security.Org.BouncyCastle.Security;

[Serializable]
internal class SecurityUtilityException : Exception
{
	public SecurityUtilityException()
	{
	}

	public SecurityUtilityException(string message)
		: base(message)
	{
	}

	public SecurityUtilityException(string message, Exception exception)
		: base(message, exception)
	{
	}
}
