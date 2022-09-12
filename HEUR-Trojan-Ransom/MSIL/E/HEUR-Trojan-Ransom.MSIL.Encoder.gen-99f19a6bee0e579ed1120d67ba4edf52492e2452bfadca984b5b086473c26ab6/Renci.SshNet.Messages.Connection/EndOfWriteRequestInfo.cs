namespace Renci.SshNet.Messages.Connection;

public class EndOfWriteRequestInfo : RequestInfo
{
	public const string Name = "eow@openssh.com";

	public override string RequestName => "eow@openssh.com";

	public EndOfWriteRequestInfo()
	{
		base.WantReply = false;
	}
}
