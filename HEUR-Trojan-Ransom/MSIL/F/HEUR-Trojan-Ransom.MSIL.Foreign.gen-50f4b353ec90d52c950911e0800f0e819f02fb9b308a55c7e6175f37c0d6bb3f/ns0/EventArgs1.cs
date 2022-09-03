using System;

namespace ns0;

internal class EventArgs1 : EventArgs
{
	private byte[] byte_0;

	private int int_0;

	private Class3.Enum0 enum0_0;

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

	public Class3.Enum0 Enum0_0
	{
		get
		{
			return enum0_0;
		}
		set
		{
			enum0_0 = value;
		}
	}

	public EventArgs1(byte[] data, int len, Class3.Enum0 header)
	{
		Byte_0 = data;
		Int32_0 = len;
		Enum0_0 = header;
	}
}
