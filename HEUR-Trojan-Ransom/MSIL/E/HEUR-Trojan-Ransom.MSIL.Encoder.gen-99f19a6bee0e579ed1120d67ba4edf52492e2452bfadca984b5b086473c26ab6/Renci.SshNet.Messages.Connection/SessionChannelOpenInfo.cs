namespace Renci.SshNet.Messages.Connection;

internal class SessionChannelOpenInfo : ChannelOpenInfo
{
	public const string Name = "session";

	public override string ChannelType => "session";

	public SessionChannelOpenInfo()
	{
	}

	public SessionChannelOpenInfo(byte[] data)
	{
		Load(data);
	}
}
