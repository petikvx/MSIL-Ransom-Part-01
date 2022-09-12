using System.IO;

public class GClass1
{
	private uint uint_0;

	private uint uint_1 = 1u;

	public uint uint_2;

	private uint uint_3;

	private Stream stream_0;

	private uint uint_4;

	private byte[] byte_0;

	public void method_0()
	{
		method_3();
		stream_0 = null;
	}

	public void method_1(uint uint_5, uint uint_6)
	{
		uint num = uint_3 - uint_5 - 1;
		if (num >= uint_0)
		{
			num += uint_0;
		}
		while (uint_6 != 0)
		{
			if (num >= uint_0)
			{
				num = 0u;
			}
			byte_0[uint_3++] = byte_0[num++];
			if (uint_3 >= uint_0)
			{
				method_3();
			}
			uint_6--;
		}
	}

	public void method_2(byte byte_1)
	{
		byte_0[uint_3++] = byte_1;
		if (uint_3 >= uint_0)
		{
			method_3();
		}
	}

	public void method_3()
	{
		uint num = uint_3 - uint_4;
		if (num != 0)
		{
			stream_0.Write(byte_0, (int)uint_4, (int)num);
			if (uint_3 >= uint_0)
			{
				uint_3 = 0u;
			}
			uint_4 = uint_3;
		}
	}

	public byte method_4(uint uint_5)
	{
		uint num = uint_3 - uint_5 - 1;
		if (num >= uint_0)
		{
			num += uint_0;
		}
		return byte_0[num];
	}

	public void method_5(Stream stream_1, bool bool_0)
	{
		method_0();
		stream_0 = stream_1;
		if (!bool_0)
		{
			uint_4 = 0u;
			uint_3 = 0u;
			uint_2 = 0u;
		}
	}

	public void method_6(uint uint_5)
	{
		if (uint_0 != uint_5)
		{
			byte_0 = new byte[uint_5];
		}
		uint_0 = uint_5;
		uint_3 = 0u;
		uint_4 = 0u;
	}
}
