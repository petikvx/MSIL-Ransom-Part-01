using System;
using System.IO;

namespace ns17;

internal class Class80
{
	public static string smethod_0(Stream stream_0, int int_0)
	{
		byte[] array = new byte[int_0];
		stream_0.Read(array, 0, int_0);
		return GClass15.smethod_1(array);
	}

	public static string smethod_1(Stream stream_0)
	{
		return smethod_2((byte)stream_0.ReadByte(), stream_0);
	}

	public static string smethod_2(byte byte_0, Stream stream_0)
	{
		byte[] array = null;
		int num = 0;
		if (byte_0 >= 160 && byte_0 <= 191)
		{
			num = byte_0 - 160;
		}
		else
		{
			switch (byte_0)
			{
			case 217:
				num = stream_0.ReadByte();
				break;
			case 218:
				array = new byte[2];
				stream_0.Read(array, 0, 2);
				array = GClass15.smethod_4(array);
				num = BitConverter.ToUInt16(array, 0);
				break;
			case 219:
				array = new byte[4];
				stream_0.Read(array, 0, 4);
				array = GClass15.smethod_4(array);
				num = BitConverter.ToInt32(array, 0);
				break;
			}
		}
		array = new byte[num];
		stream_0.Read(array, 0, num);
		return GClass15.smethod_1(array);
	}
}
