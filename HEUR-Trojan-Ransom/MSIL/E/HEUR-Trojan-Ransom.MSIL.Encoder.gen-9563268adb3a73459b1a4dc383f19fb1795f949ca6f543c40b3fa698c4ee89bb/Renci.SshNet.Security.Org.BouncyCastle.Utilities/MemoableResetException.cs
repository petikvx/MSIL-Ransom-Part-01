using System;

namespace Renci.SshNet.Security.Org.BouncyCastle.Utilities;

internal class MemoableResetException : InvalidCastException
{
	public MemoableResetException(string msg)
		: base(msg)
	{
	}
}
