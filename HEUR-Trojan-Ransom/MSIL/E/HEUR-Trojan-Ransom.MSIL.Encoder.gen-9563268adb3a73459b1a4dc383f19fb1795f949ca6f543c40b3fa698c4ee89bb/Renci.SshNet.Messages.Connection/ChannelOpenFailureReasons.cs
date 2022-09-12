namespace Renci.SshNet.Messages.Connection;

internal enum ChannelOpenFailureReasons : uint
{
	AdministativelyProhibited = 1u,
	ConnectFailed,
	UnknownChannelType,
	ResourceShortage
}
