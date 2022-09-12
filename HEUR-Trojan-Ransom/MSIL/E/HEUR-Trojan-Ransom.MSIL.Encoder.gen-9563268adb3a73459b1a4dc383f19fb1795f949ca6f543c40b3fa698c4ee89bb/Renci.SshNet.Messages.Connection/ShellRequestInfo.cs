namespace Renci.SshNet.Messages.Connection;

internal class ShellRequestInfo : RequestInfo
{
	public const string Name = "shell";

	public override string RequestName => "shell";

	public ShellRequestInfo()
	{
		base.WantReply = true;
	}
}
