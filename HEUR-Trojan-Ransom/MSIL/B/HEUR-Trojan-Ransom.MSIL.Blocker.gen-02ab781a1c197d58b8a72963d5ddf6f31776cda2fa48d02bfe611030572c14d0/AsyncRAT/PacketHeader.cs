namespace AsyncRAT;

internal enum PacketHeader
{
	identification,
	RemoteDesktopOpen,
	RemoteDesktopSend,
	ErrorMassages,
	ClientShutdown,
	ClientDelete,
	ClientUpdate,
	Reflection,
	MsgReceived,
	Ping
}
