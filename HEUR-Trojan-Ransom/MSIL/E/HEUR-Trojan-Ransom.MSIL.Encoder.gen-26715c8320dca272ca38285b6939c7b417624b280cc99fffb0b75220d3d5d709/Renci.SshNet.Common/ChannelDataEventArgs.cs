namespace Renci.SshNet.Common;

internal class ChannelDataEventArgs : ChannelEventArgs
{
	public byte[] Data { get; private set; }

	public ChannelDataEventArgs(uint channelNumber, byte[] data)
		: base(channelNumber)
	{
		Data = data;
	}
}
