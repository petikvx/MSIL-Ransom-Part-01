namespace Orcus.Commands.ReverseProxy.Args;

public class ReverseProxyDataReceivedEventArgs : ReverseProxyEventArgs
{
	public byte[] Data { get; }

	public ReverseProxyDataReceivedEventArgs(int connectionId, byte[] data)
		: base(connectionId)
	{
		Data = data;
	}
}
