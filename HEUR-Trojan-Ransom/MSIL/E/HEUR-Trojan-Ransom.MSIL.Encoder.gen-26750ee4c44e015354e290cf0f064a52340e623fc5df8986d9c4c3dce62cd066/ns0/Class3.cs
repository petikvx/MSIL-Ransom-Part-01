using System.Runtime.Remoting.Channels;

namespace ns0;

internal sealed class Class3
{
	private byte byte_0;

	private const byte byte_1 = 1;

	private const byte byte_2 = 2;

	internal IChannel ichannel_0;

	internal virtual IChannel IChannel_0 => ichannel_0;

	internal Class3(IChannel ichannel_1)
	{
		IChannel val = (ichannel_0 = ichannel_1);
		byte_0 = 0;
		if (ichannel_1 is IChannelSender)
		{
			byte_0 |= 1;
		}
		if (ichannel_1 is IChannelReceiver)
		{
			byte_0 |= 2;
		}
	}

	internal virtual bool vmethod_0()
	{
		return (byte_0 & 1) > 0;
	}

	internal virtual bool vmethod_1()
	{
		return (byte_0 & 2) > 0;
	}
}
