using System;

namespace ns0;

internal class EventArgs2 : EventArgs
{
	private byte[] byte_0;

	private int int_0;

	private Class14.Enum3 enum3_0;

	public byte[] Byte_0
	{
		get
		{
			return byte_0;
		}
		set
		{
			byte_0 = value;
		}
	}

	public int Int32_0
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	public Class14.Enum3 Enum3_0
	{
		get
		{
			return enum3_0;
		}
		set
		{
			enum3_0 = value;
		}
	}

	public EventArgs2(byte[] data, int len, Class14.Enum3 header)
	{
		Byte_0 = data;
		Int32_0 = len;
		Enum3_0 = header;
	}
}
