namespace Renci.SshNet.Common;

internal class ChannelOpenConfirmedEventArgs : ChannelEventArgs
{
	public uint InitialWindowSize { get; private set; }

	public uint MaximumPacketSize { get; private set; }

	public ChannelOpenConfirmedEventArgs(uint remoteChannelNumber, uint initialWindowSize, uint maximumPacketSize)
		: base(remoteChannelNumber)
	{
		InitialWindowSize = initialWindowSize;
		MaximumPacketSize = maximumPacketSize;
	}
}
