using System.IO;

public class GClass1
{
	private Stream stream_0;

	public uint uint_0;

	private uint uint_1;

	private uint uint_2;

	private uint uint_3 = 1u;

	private uint uint_4;

	private byte[] byte_0;

	public void method_0()
	{
		method_2();
		stream_0 = null;
	}

	public byte method_1(uint uint_5)
	{
		uint num = uint_1 - uint_5 - 1;
		if (num >= uint_4)
		{
			num += uint_4;
		}
		return byte_0[num];
	}

	public void method_2()
	{
		uint num = uint_1 - uint_2;
		if (num != 0)
		{
			stream_0.Write(byte_0, (int)uint_2, (int)num);
			if (uint_1 >= uint_4)
			{
				uint_1 = 0u;
			}
			uint_2 = uint_1;
		}
	}

	public void method_3(Stream stream_1, bool bool_0)
	{
		method_0();
		stream_0 = stream_1;
		if (!bool_0)
		{
			uint_2 = 0u;
			uint_1 = 0u;
			uint_0 = 0u;
		}
	}

	public void method_4(uint uint_5, uint uint_6)
	{
		uint num = uint_1 - uint_5 - 1;
		if (num >= uint_4)
		{
			num += uint_4;
		}
		while (uint_6 != 0)
		{
			if (num >= uint_4)
			{
				num = 0u;
			}
			byte_0[uint_1++] = byte_0[num++];
			if (uint_1 >= uint_4)
			{
				method_2();
			}
			uint_6--;
		}
	}

	public void method_5(byte byte_1)
	{
		byte_0[uint_1++] = byte_1;
		if (uint_1 >= uint_4)
		{
			method_2();
		}
	}

	public void method_6(uint uint_5)
	{
		if (uint_4 != uint_5)
		{
			byte_0 = new byte[uint_5];
		}
		uint_4 = uint_5;
		uint_1 = 0u;
		uint_2 = 0u;
	}
}
