using Gecko.Interop;

namespace Gecko.Net;

public sealed class TraceableChannel
{
	private ComPtr<nsITraceableChannel> _traceableChannel;

	internal TraceableChannel(nsITraceableChannel traceableChannel)
	{
		_traceableChannel = new ComPtr<nsITraceableChannel>(traceableChannel);
	}

	public void SetNewListener(StreamListenerTee streamListener)
	{
		nsIStreamListener streamListener2 = _traceableChannel.Instance.SetNewListener(streamListener._streamListenerTee.Instance);
		streamListener.IntInit(streamListener2);
	}
}
