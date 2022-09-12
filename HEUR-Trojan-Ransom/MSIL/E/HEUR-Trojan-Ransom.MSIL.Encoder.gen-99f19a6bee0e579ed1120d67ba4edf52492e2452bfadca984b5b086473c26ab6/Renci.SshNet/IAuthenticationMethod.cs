namespace Renci.SshNet;

internal interface IAuthenticationMethod
{
	string[] AllowedAuthentications { get; }

	string Name { get; }

	AuthenticationResult Authenticate(ISession session);
}
