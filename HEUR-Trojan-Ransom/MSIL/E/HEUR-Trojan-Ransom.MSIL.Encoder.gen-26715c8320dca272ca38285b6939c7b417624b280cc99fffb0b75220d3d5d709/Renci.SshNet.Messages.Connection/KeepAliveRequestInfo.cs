namespace Renci.SshNet.Messages.Connection;

public class KeepAliveRequestInfo : RequestInfo
{
	public const string Name = "keepalive@openssh.com";

	public override string RequestName => "keepalive@openssh.com";

	public KeepAliveRequestInfo()
	{
		base.WantReply = false;
	}
}
