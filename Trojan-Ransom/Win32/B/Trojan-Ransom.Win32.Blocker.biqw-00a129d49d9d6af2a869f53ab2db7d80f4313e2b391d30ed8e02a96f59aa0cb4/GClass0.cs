using System.IO;

public class GClass0
{
	public byte[] byte_0;

	private Stream stream_0;

	private uint uint_0;

	private bool bool_0;

	private uint uint_1;

	public uint uint_2;

	public uint uint_3;

	public uint uint_4;

	private uint uint_5;

	private uint uint_6;

	private uint uint_7;

	public uint uint_8;

	public virtual void vmethod_0()
	{
	}

	public virtual void vmethod_1()
	{
	}

	public void method_0()
	{
		vmethod_0();
		uint num = uint_2 + uint_4 - uint_5;
		uint num2 = uint_2 + uint_8 - num;
		for (uint num3 = 0u; num3 < num2; num3++)
		{
			byte_0[num3] = byte_0[num + num3];
		}
		uint_2 -= num;
		vmethod_1();
	}

	public virtual void vmethod_2()
	{
		if (bool_0)
		{
			return;
		}
		while (true)
		{
			int num = (int)(0 - uint_2 + uint_3 - uint_8);
			if (num != 0)
			{
				int num2 = stream_0.Read(byte_0, (int)(uint_2 + uint_8), num);
				if (num2 == 0)
				{
					break;
				}
				uint_8 += (uint)num2;
				if (uint_8 >= uint_4 + uint_6)
				{
					uint_0 = uint_8 - uint_6;
				}
				continue;
			}
			return;
		}
		uint_0 = uint_8;
		uint num3 = uint_2 + uint_0;
		if (num3 > uint_1)
		{
			uint_0 = uint_1 - uint_2;
		}
		bool_0 = true;
	}

	private void method_1()
	{
		byte_0 = null;
	}

	public void method_2(uint uint_9, uint uint_10, uint uint_11)
	{
		uint_5 = uint_9;
		uint_6 = uint_10;
		uint_7 = uint_11;
		uint num = uint_9 + uint_10 + uint_11;
		if (byte_0 == null || uint_3 != num)
		{
			method_1();
			uint_3 = num;
			byte_0 = new byte[uint_3];
		}
		uint_1 = uint_3 - uint_10;
	}

	public void method_3(Stream stream_1)
	{
		stream_0 = stream_1;
		uint_2 = 0u;
		uint_4 = 0u;
		uint_8 = 0u;
		bool_0 = false;
		vmethod_2();
	}

	public void method_4()
	{
		stream_0 = null;
	}

	public void method_5()
	{
		uint_4++;
		if (uint_4 > uint_0)
		{
			uint num = uint_2 + uint_4;
			if (num > uint_1)
			{
				method_0();
			}
			vmethod_2();
		}
	}

	public byte method_6(int int_0)
	{
		return byte_0[uint_2 + uint_4 + int_0];
	}

	public uint method_7(int int_0, uint uint_9, uint uint_10)
	{
		if (bool_0 && uint_4 + int_0 + uint_10 > uint_8)
		{
			uint_10 = uint_8 - (uint)(int)(uint_4 + int_0);
		}
		uint_9++;
		uint num = uint_2 + uint_4 + (uint)int_0;
		uint num2;
		for (num2 = 0u; num2 < uint_10 && byte_0[num + num2] == byte_0[num + num2 - uint_9]; num2++)
		{
		}
		return num2;
	}

	public uint method_8()
	{
		return uint_8 - uint_4;
	}

	public void method_9(int int_0)
	{
		uint_2 += (uint)int_0;
		uint_0 -= (uint)int_0;
		uint_4 -= (uint)int_0;
		uint_8 -= (uint)int_0;
	}
}
