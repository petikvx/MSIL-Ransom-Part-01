using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;

namespace ns0;

internal sealed class Class3
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 94)]
	private struct Struct0
	{
	}

	private IChannel ichannel_0;

	private byte byte_0;

	private const byte byte_1 = 1;

	private const byte byte_2 = 2;

	private static readonly object object_0;

	private static readonly object object_1 = new char[47];

	private static readonly object object_2;

	internal static byte byte_3/* Not supported: data(00) */;

	internal virtual IChannel IChannel_0 => ichannel_0;

	internal Class3(IChannel ichannel_1)
	{
		ichannel_0 = ichannel_1;
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

	static Class3()
	{
		char[] array = new char[8];
		array[6] = '⫭';
		array[7] = '➨';
		array[3] = 'ⶁ';
		array[4] = '⫋';
		array[1] = 'ݴ';
		array[2] = 'ᜨ';
		array[0] = '∠';
		array[5] = '㓡';
		object_2 = new string[8];
		object_0 = array;
	}
}
