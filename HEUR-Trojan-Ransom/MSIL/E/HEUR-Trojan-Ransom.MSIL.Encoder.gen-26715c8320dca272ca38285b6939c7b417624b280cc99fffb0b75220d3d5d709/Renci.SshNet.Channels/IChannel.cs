using System;
using Renci.SshNet.Common;

namespace Renci.SshNet.Channels;

internal interface IChannel : IDisposable
{
	uint LocalChannelNumber { get; }

	uint LocalPacketSize { get; }

	uint RemotePacketSize { get; }

	bool IsOpen { get; }

	event EventHandler<ChannelDataEventArgs> DataReceived;

	event EventHandler<ExceptionEventArgs> Exception;

	event EventHandler<ChannelExtendedDataEventArgs> ExtendedDataReceived;

	event EventHandler<ChannelRequestEventArgs> RequestReceived;

	event EventHandler<ChannelEventArgs> Closed;

	void SendData(byte[] data);

	void SendData(byte[] data, int offset, int size);

	void SendEof();
}
