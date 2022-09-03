using System;

namespace ns0;

internal class EventArgs2 : EventArgs
{
	private byte[] byte_0;

	private int int_0;

	private Class4.Enum1 enum1_0;

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

	public Class4.Enum1 Enum1_0
	{
		get
		{
			return enum1_0;
		}
		set
		{
			enum1_0 = value;
		}
	}

	public EventArgs2(byte[] data, int len, Class4.Enum1 header)
	{
		Byte_0 = data;
		Int32_0 = len;
		Enum1_0 = header;
	}
}
