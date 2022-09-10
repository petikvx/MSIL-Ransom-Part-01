using System.ServiceModel.Channels;

namespace System.ServiceModel.Activation;

internal class SocketSettings : ISocketListenerSettings
{
	public int BufferSize => 2500;

	public bool TeredoEnabled => ListenerConfig.NetTcp.TeredoEnabled;

	public int ListenBacklog => ListenerConfig.NetTcp.ListenBacklog;
}
