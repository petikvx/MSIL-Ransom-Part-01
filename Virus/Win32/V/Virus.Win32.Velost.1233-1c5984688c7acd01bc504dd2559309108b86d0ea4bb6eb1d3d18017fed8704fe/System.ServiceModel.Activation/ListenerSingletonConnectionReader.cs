using System.ServiceModel.Channels;

namespace System.ServiceModel.Activation;

internal class ListenerSingletonConnectionReader : DupHandleConnectionReader
{
	private ServerSingletonDecoder decoder;

	public ListenerSingletonConnectionReader(IConnection connection, ItemDequeuedCallback connectionDequeuedCallback, TransportType transportType, long streamPosition, int offset, int size, ConnectionClosedCallback closedCallback, ViaDecodedCallback viaDecodedCallback)
		: base(connection, connectionDequeuedCallback, transportType, offset, size, closedCallback, viaDecodedCallback)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		decoder = new ServerSingletonDecoder(streamPosition, 2048, 256);
	}

	protected override bool CanDupHandle(out Uri via)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)decoder.get_CurrentState() == 2)
		{
			via = decoder.get_Via();
			return true;
		}
		via = null;
		return false;
	}

	protected override int Decode(byte[] buffer, int offset, int size)
	{
		return decoder.Decode(buffer, offset, size);
	}

	protected override Exception CreatePrematureEOFException()
	{
		return ((FramingDecoder)decoder).CreatePrematureEOFException();
	}
}
