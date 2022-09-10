using System.ServiceModel.Channels;

namespace System.ServiceModel.Activation;

internal class SocketSettings : ISocketListenerSettings
{
	public _003F BufferSize => 2500;

	public _003F TeredoEnabled => ((NetTcpSectionData)ListenerConfig.NetTcp).TeredoEnabled;

	public _003F ListenBacklog => ((NetTcpSectionData)ListenerConfig.NetTcp).ListenBacklog;

	public SocketSettings()
	{
		//Discarded unreachable code: IL_0006
		/*Error near IL_0001: Unexpected SignatureTypeCode: (0x30b).*/;
	}
}
