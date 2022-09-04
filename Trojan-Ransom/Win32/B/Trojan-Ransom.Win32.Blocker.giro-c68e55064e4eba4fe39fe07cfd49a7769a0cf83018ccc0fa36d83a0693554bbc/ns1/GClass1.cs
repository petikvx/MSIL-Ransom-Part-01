using System.IO;
using ns4;

namespace ns1;

public class GClass1
{
	private byte[] byte_0;

	private uint uint_0;

	private uint uint_1;

	private uint uint_2;

	private Stream stream_0;

	public void method_0(uint uint_3)
	{
		if (uint_1 != uint_3)
		{
			byte_0 = new byte[uint_3];
		}
		uint_1 = uint_3;
		uint_0 = 0u;
		uint_2 = 0u;
	}

	public void method_1(Stream stream_1, bool bool_0)
	{
		method_3();
		stream_0 = stream_1;
		if (!bool_0)
		{
			uint_2 = 0u;
			uint_0 = 0u;
		}
	}

	public void method_2(Stream stream_1)
	{
		method_1(stream_1, bool_0: false);
	}

	public void method_3()
	{
		method_4();
		stream_0 = null;
	}

	public void method_4()
	{
		uint num = uint_0 - uint_2;
		if (num != 0)
		{
			Class18.smethod_0(stream_0, byte_0, (int)uint_2, (int)num, 18525);
			if (uint_0 >= uint_1)
			{
				uint_0 = 0u;
			}
			uint_2 = uint_0;
		}
	}

	public void method_5(uint uint_3, uint uint_4)
	{
		uint num = uint_0 - uint_3 - 1;
		if (num >= uint_1)
		{
			num += uint_1;
		}
		while (uint_4 != 0)
		{
			if (num >= uint_1)
			{
				num = 0u;
			}
			byte_0[uint_0++] = byte_0[num++];
			if (uint_0 >= uint_1)
			{
				method_4();
			}
			uint_4--;
		}
	}

	public void method_6(byte byte_1)
	{
		byte_0[uint_0++] = byte_1;
		if (uint_0 >= uint_1)
		{
			method_4();
		}
	}

	public byte method_7(uint uint_3)
	{
		uint num = uint_0 - uint_3 - 1;
		if (num >= uint_1)
		{
			num += uint_1;
		}
		return byte_0[num];
	}
}
