using System;

namespace Renci.SshNet.Common;

internal class ChannelEventArgs : EventArgs
{
	public uint ChannelNumber { get; private set; }

	public ChannelEventArgs(uint channelNumber)
	{
		ChannelNumber = channelNumber;
	}
}
