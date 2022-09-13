using System;
using System.IO;
using System.Runtime.InteropServices;

[Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
[ComVisible(true)]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public class GClass12
{
	private uint uint_0;

	private long long_0;

	private bool bool_0;

	private uint[] uint_1;

	private const int int_0 = 8192;

	private uint uint_2 = uint.MaxValue;

	public long Int64_0 => long_0;

	public int Int32_0 => (int)(~uint_2);

	public int method_0(Stream stream_0)
	{
		return method_1(stream_0, null);
	}

	public int method_1(Stream stream_0, Stream stream_1)
	{
		if (stream_0 == null)
		{
			throw new Exception("The input stream must not be null.");
		}
		byte[] array = new byte[8192];
		int count = 8192;
		long_0 = 0L;
		int num = stream_0.Read(array, 0, 8192);
		stream_1?.Write(array, 0, num);
		long_0 += num;
		while (num > 0)
		{
			method_4(array, 0, num);
			num = stream_0.Read(array, 0, count);
			stream_1?.Write(array, 0, num);
			long_0 += num;
		}
		return (int)(~uint_2);
	}

	public int method_2(int int_1, byte byte_0)
	{
		return method_3((uint)int_1, byte_0);
	}

	internal int method_3(uint uint_3, byte byte_0)
	{
		return (int)(uint_1[(uint_3 ^ byte_0) & 0xFF] ^ (uint_3 >> 8));
	}

	public void method_4(byte[] byte_0, int int_1, int int_2)
	{
		if (byte_0 == null)
		{
			throw new Exception("The data buffer must not be null.");
		}
		for (int i = 0; i < int_2; i++)
		{
			int num = int_1 + i;
			byte b = byte_0[num];
			if (bool_0)
			{
				uint num2 = (uint_2 >> 24) ^ b;
				uint_2 = (uint_2 << 8) ^ uint_1[num2];
			}
			else
			{
				uint num3 = (uint_2 & 0xFFu) ^ b;
				uint_2 = (uint_2 >> 8) ^ uint_1[num3];
			}
		}
		long_0 += int_2;
	}

	public void method_5(byte byte_0)
	{
		if (bool_0)
		{
			uint num = (uint_2 >> 24) ^ byte_0;
			uint_2 = (uint_2 << 8) ^ uint_1[num];
		}
		else
		{
			uint num2 = (uint_2 & 0xFFu) ^ byte_0;
			uint_2 = (uint_2 >> 8) ^ uint_1[num2];
		}
	}

	public void method_6(byte byte_0, int int_1)
	{
		while (int_1-- > 0)
		{
			if (bool_0)
			{
				uint num = (uint_2 >> 24) ^ byte_0;
				uint_2 = (uint_2 << 8) ^ uint_1[num];
			}
			else
			{
				uint num2 = (uint_2 & 0xFFu) ^ byte_0;
				uint_2 = (uint_2 >> 8) ^ uint_1[num2];
			}
		}
	}

	private static uint smethod_0(uint uint_3)
	{
		uint num = uint_3;
		num = ((num & 0x55555555) << 1) | ((num >> 1) & 0x55555555u);
		num = ((num & 0x33333333) << 2) | ((num >> 2) & 0x33333333u);
		num = ((num & 0xF0F0F0F) << 4) | ((num >> 4) & 0xF0F0F0Fu);
		return (num << 24) | ((num & 0xFF00) << 8) | ((num >> 8) & 0xFF00u) | (num >> 24);
	}

	private static byte smethod_1(byte byte_0)
	{
		int num = byte_0 * 131586;
		uint num2 = (uint)num & 0x1044010u;
		uint num3 = (uint)(num << 2) & 0x2088020u;
		return (byte)(16781313 * (num2 + num3) >> 24);
	}

	private void method_7()
	{
		uint_1 = new uint[256];
		byte b = 0;
		do
		{
			uint num = b;
			for (byte b2 = 8; b2 > 0; b2 = (byte)(b2 - 1))
			{
				num = (((num & 1) != 1) ? (num >> 1) : ((num >> 1) ^ uint_0));
			}
			if (bool_0)
			{
				uint_1[smethod_1(b)] = smethod_0(num);
			}
			else
			{
				uint_1[b] = num;
			}
			b = (byte)(b + 1);
		}
		while (b != 0);
	}

	private uint method_8(uint[] uint_3, uint uint_4)
	{
		uint num = 0u;
		int num2 = 0;
		while (uint_4 != 0)
		{
			if ((uint_4 & 1) == 1)
			{
				num ^= uint_3[num2];
			}
			uint_4 >>= 1;
			num2++;
		}
		return num;
	}

	private void method_9(uint[] uint_3, uint[] uint_4)
	{
		for (int i = 0; i < 32; i++)
		{
			uint_3[i] = method_8(uint_4, uint_4[i]);
		}
	}

	public void method_10(int int_1, int int_2)
	{
		uint[] array = new uint[32];
		uint[] array2 = new uint[32];
		if (int_2 == 0)
		{
			return;
		}
		uint num = ~uint_2;
		array2[0] = uint_0;
		uint num2 = 1u;
		for (int i = 1; i < 32; i++)
		{
			array2[i] = num2;
			num2 <<= 1;
		}
		method_9(array, array2);
		method_9(array2, array);
		uint num3 = (uint)int_2;
		do
		{
			method_9(array, array2);
			if ((num3 & 1) == 1)
			{
				num = method_8(array, num);
			}
			num3 >>= 1;
			if (num3 == 0)
			{
				break;
			}
			method_9(array2, array);
			if ((num3 & 1) == 1)
			{
				num = method_8(array2, num);
			}
			num3 >>= 1;
		}
		while (num3 != 0);
		num ^= (uint)int_1;
		uint_2 = ~num;
	}

	public GClass12()
		: this(reverseBits: false)
	{
	}

	public GClass12(bool reverseBits)
		: this(-306674912, reverseBits)
	{
	}

	public GClass12(int polynomial, bool reverseBits)
	{
		bool_0 = reverseBits;
		uint_0 = (uint)polynomial;
		method_7();
	}

	public void method_11()
	{
		uint_2 = uint.MaxValue;
	}
}
