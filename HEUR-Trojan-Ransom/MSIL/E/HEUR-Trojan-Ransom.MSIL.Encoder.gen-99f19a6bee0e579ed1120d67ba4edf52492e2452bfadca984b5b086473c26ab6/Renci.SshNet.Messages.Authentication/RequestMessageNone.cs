namespace Renci.SshNet.Messages.Authentication;

internal class RequestMessageNone : RequestMessage
{
	public RequestMessageNone(ServiceName serviceName, string username)
		: base(serviceName, username, "none")
	{
	}
}
