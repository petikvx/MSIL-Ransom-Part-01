using System;
using Renci.SshNet.Common;

namespace Renci.SshNet;

public abstract class AuthenticationMethod : IAuthenticationMethod
{
	public abstract string Name { get; }

	public string Username { get; private set; }

	public string[] AllowedAuthentications { get; protected set; }

	protected AuthenticationMethod(string username)
	{
		if (username.IsNullOrWhiteSpace())
		{
			throw new ArgumentException("username");
		}
		Username = username;
	}

	public abstract AuthenticationResult Authenticate(Session session);

	AuthenticationResult IAuthenticationMethod.Authenticate(ISession session)
	{
		return Authenticate((Session)session);
	}
}
