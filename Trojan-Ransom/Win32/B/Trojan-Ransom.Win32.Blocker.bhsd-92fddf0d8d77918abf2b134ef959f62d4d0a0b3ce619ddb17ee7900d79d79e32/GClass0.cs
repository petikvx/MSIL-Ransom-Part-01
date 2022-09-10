using System.IO;

public class GClass0
{
	public byte[] byte_0;

	public uint uint_0;

	public uint uint_1;

	public uint uint_2;

	public uint uint_3;

	internal Stream stream_0;

	internal uint uint_4;

	internal bool bool_0;

	internal uint uint_5;

	internal uint uint_6;

	internal uint uint_7;

	internal uint uint_8;

	public virtual void vmethod_0()
	{
	}

	public virtual void vmethod_1()
	{
	}

	public void method_0()
	{
		vmethod_0();
		uint num = uint_0 + uint_2 - uint_6;
		uint num2 = uint_0 + uint_3 - num;
		for (uint num3 = 0u; num3 < num2; num3++)
		{
			byte_0[num3] = byte_0[num + num3];
		}
		uint_0 -= num;
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
			int num = (int)(0 - uint_0 + uint_1 - uint_3);
			if (num != 0)
			{
				int num2 = stream_0.Read(byte_0, (int)(uint_0 + uint_3), num);
				if (num2 == 0)
				{
					break;
				}
				uint_3 += (uint)num2;
				if (uint_3 >= uint_2 + uint_7)
				{
					uint num3 = (uint_4 = uint_3 - uint_7);
				}
				continue;
			}
			return;
		}
		uint num4 = (uint_4 = uint_3);
		uint num5 = uint_0 + uint_4;
		if (num5 > uint_5)
		{
			uint num6 = (uint_4 = uint_5 - uint_0);
		}
		bool_0 = true;
	}

	private void method_1()
	{
		byte_0 = null;
	}

	public void method_2(uint uint_9, uint uint_10, uint uint_11)
	{
		uint num = (uint_6 = uint_9);
		uint num2 = (uint_7 = uint_10);
		uint num3 = (uint_8 = uint_11);
		uint num4 = uint_9 + uint_10 + uint_11;
		if (byte_0 == null || uint_1 != num4)
		{
			method_1();
			uint_1 = num4;
			byte_0 = new byte[uint_1];
		}
		uint num5 = (uint_5 = uint_1 - uint_10);
	}

	public void method_3(Stream stream_1)
	{
		Stream stream = (stream_0 = stream_1);
		uint_0 = 0u;
		uint_2 = 0u;
		uint_3 = 0u;
		bool_0 = false;
		vmethod_2();
	}

	public void method_4()
	{
		Stream stream = (stream_0 = null);
	}

	public void method_5()
	{
		uint_2++;
		if (uint_2 > uint_4)
		{
			uint num = uint_0 + uint_2;
			if (num > uint_5)
			{
				method_0();
			}
			vmethod_2();
		}
	}

	public byte method_6(int int_0)
	{
		return byte_0[uint_0 + uint_2 + int_0];
	}

	public uint method_7(int int_0, uint uint_9, uint uint_10)
	{
		if (bool_0 && uint_2 + int_0 + uint_10 > uint_3)
		{
			uint_10 = uint_3 - (uint)(int)(uint_2 + int_0);
		}
		uint_9++;
		uint num = uint_0 + uint_2 + (uint)int_0;
		uint num2;
		for (num2 = 0u; num2 < uint_10 && byte_0[num + num2] == byte_0[num + num2 - uint_9]; num2++)
		{
		}
		return num2;
	}

	public uint method_8()
	{
		return uint_3 - uint_2;
	}

	public void method_9(int int_0)
	{
		uint_0 += (uint)int_0;
		uint_4 -= (uint)int_0;
		uint_2 -= (uint)int_0;
		uint_3 -= (uint)int_0;
	}
}
