using System;
using System.Text;

public class GClass2
{
	private enum Enum0
	{
		QCLZ,
		VERSION,
		COMPSIZE,
		UNCOMPSIZE,
		COMPRESSIBLE,
		RESERVED1,
		RESERVED2,
		RESERVED3
	}

	private unsafe uint method_0(void* pVoid_0, uint uint_0)
	{
		uint result = 0u;
		if (BitConverter.IsLittleEndian)
		{
			result = *(uint*)pVoid_0;
		}
		else
		{
			switch (uint_0)
			{
			case 1u:
				result = *(byte*)pVoid_0;
				break;
			case 2u:
				result = (uint)(*(byte*)pVoid_0 | (((byte*)pVoid_0)[1] << 8));
				break;
			case 3u:
				result = (uint)(*(byte*)pVoid_0 | (((byte*)pVoid_0)[1] << 8) | (((byte*)pVoid_0)[2] << 16));
				break;
			case 4u:
				result = (uint)(*(byte*)pVoid_0 | (((byte*)pVoid_0)[1] << 8) | (((byte*)pVoid_0)[2] << 16) | (((byte*)pVoid_0)[3] << 24));
				break;
			}
		}
		return result;
	}

	private unsafe void method_1(uint uint_0, void* pVoid_0, uint uint_1)
	{
		if (BitConverter.IsLittleEndian)
		{
			switch (uint_1)
			{
			case 1u:
				*(byte*)pVoid_0 = (byte)uint_0;
				break;
			case 2u:
			case 3u:
			case 4u:
				*(uint*)pVoid_0 = uint_0;
				break;
			}
			return;
		}
		switch (uint_1)
		{
		case 1u:
			*(byte*)pVoid_0 = (byte)uint_0;
			break;
		case 2u:
			*(byte*)pVoid_0 = (byte)uint_0;
			((byte*)pVoid_0)[1] = (byte)(uint_0 >> 8);
			break;
		case 3u:
			*(byte*)pVoid_0 = (byte)uint_0;
			((byte*)pVoid_0)[1] = (byte)(uint_0 >> 8);
			((byte*)pVoid_0)[2] = (byte)(uint_0 >> 16);
			break;
		case 4u:
			*(byte*)pVoid_0 = (byte)uint_0;
			((byte*)pVoid_0)[1] = (byte)(uint_0 >> 8);
			((byte*)pVoid_0)[2] = (byte)(uint_0 >> 16);
			((byte*)pVoid_0)[3] = (byte)(uint_0 >> 24);
			break;
		}
	}

	private unsafe bool method_2(void* pVoid_0, void* pVoid_1, uint uint_0)
	{
		bool flag = true;
		uint num = 0u;
		while (flag && num < uint_0)
		{
			flag = ((byte*)pVoid_0)[(int)num] == ((byte*)pVoid_1)[(int)num];
			num++;
		}
		return flag;
	}

	private unsafe bool method_3(void* pVoid_0, string string_0)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		fixed (byte* pVoid_ = bytes)
		{
			return method_2(pVoid_0, pVoid_, (uint)bytes.Length);
		}
	}

	private unsafe void method_4(void* pVoid_0, byte byte_0, uint uint_0)
	{
		for (uint num = 0u; num < uint_0; num++)
		{
			((byte*)pVoid_0)[(int)num] = byte_0;
		}
	}

	private unsafe void method_5(void* pVoid_0, void* pVoid_1, uint uint_0)
	{
		for (uint num = 0u; num < uint_0; num++)
		{
			((byte*)pVoid_0)[(int)num] = ((byte*)pVoid_1)[(int)num];
		}
	}

	private unsafe void method_6(void* pVoid_0, string string_0)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		fixed (byte* pVoid_ = bytes)
		{
			method_5(pVoid_0, pVoid_, (uint)bytes.Length);
		}
	}

	private unsafe void method_7(byte* pByte_0, byte* pByte_1, uint uint_0)
	{
		if (BitConverter.IsLittleEndian)
		{
			if (uint_0 < 5)
			{
				*(int*)pByte_0 = *(int*)pByte_1;
				return;
			}
			byte* ptr = pByte_0 + (int)uint_0;
			while (pByte_0 < ptr)
			{
				*(int*)pByte_0 = *(int*)pByte_1;
				pByte_0 += 4;
				pByte_1 += 4;
			}
		}
		else if (uint_0 > 8 && pByte_1 + (int)uint_0 < pByte_0)
		{
			method_5(pByte_0, pByte_1, uint_0);
		}
		else
		{
			byte* ptr2 = pByte_0 + (int)uint_0;
			while (pByte_0 < ptr2)
			{
				*pByte_0 = *pByte_1;
				pByte_0++;
				pByte_1++;
			}
		}
	}

	private unsafe uint method_8(byte[] byte_0, uint uint_0, Enum0 enum0_0)
	{
		uint result = 0u;
		fixed (byte* ptr = byte_0)
		{
			if (method_3(ptr + (int)uint_0, "QCLZ"))
			{
				result = *(uint*)(ptr + (int)uint_0 + (nint)enum0_0 * (nint)4);
			}
		}
		return result;
	}

	public uint method_9(byte[] byte_0, uint uint_0)
	{
		return method_8(byte_0, uint_0, Enum0.UNCOMPSIZE);
	}

	private unsafe uint method_10(byte[] byte_0, uint uint_0, byte[] byte_1)
	{
		fixed (byte* ptr = byte_0)
		{
			fixed (byte* ptr4 = byte_1)
			{
				byte* ptr2 = ptr + (int)uint_0;
				uint num = 32u;
				byte* ptr3 = ptr2 + 32;
				byte* ptr5 = ptr4;
				uint* ptr6 = (uint*)ptr2;
				byte* ptr7 = ptr4 + (int)method_0(ptr6 + 3, 4u);
				uint num2 = 1u;
				uint[] array = new uint[16]
				{
					4u, 0u, 1u, 0u, 2u, 0u, 1u, 0u, 3u, 0u,
					1u, 0u, 2u, 0u, 1u, 0u
				};
				byte* ptr8 = ptr7 - 4;
				if (!method_3(ptr6, "QCLZ"))
				{
					return 0u;
				}
				if (method_0(ptr6 + 1, 4u) != 3)
				{
					return 0u;
				}
				if (!method_3(ptr2 + (int)method_0(ptr6 + 2, 4u) - 4, "QCLZ"))
				{
					return 0u;
				}
				if (method_0(ptr6 + 4, 4u) != 1)
				{
					method_5(ptr4, ptr2 + (int)num, method_0(ptr6 + 3, 4u));
					return method_0(ptr6 + 3, 4u);
				}
				if (ptr5 >= ptr8)
				{
					ptr3 += 4;
					while (ptr5 < ptr7)
					{
						*ptr5 = *ptr3;
						ptr5++;
						ptr3++;
					}
					return (uint)(ptr5 - ptr4);
				}
				while (true)
				{
					if (num2 == 1)
					{
						num2 = method_0(ptr3, 4u);
						ptr3 += 4;
					}
					uint num3 = method_0(ptr3, 4u);
					if ((num2 & 1) == 1)
					{
						num2 >>= 1;
						if ((num3 & 3) == 0)
						{
							uint num4 = (num3 & 0xFF) >> 2;
							method_7(ptr5, ptr5 - (int)num4, 3u);
							ptr5 += 3;
							ptr3++;
						}
						else if ((num3 & 2) == 0)
						{
							uint num4 = (num3 & 0xFFFF) >> 2;
							method_7(ptr5, ptr5 - (int)num4, 3u);
							ptr5 += 3;
							ptr3 += 2;
						}
						else if ((num3 & 1) == 0)
						{
							uint num4 = (num3 & 0xFFFF) >> 6;
							uint num5 = ((num3 >> 2) & 0xF) + 3;
							method_7(ptr5, ptr5 - (int)num4, num5);
							ptr5 += (int)num5;
							ptr3 += 2;
						}
						else if ((num3 & 4) == 0)
						{
							uint num4 = (num3 & 0xFFFFFF) >> 8;
							uint num5 = ((num3 >> 3) & 0x1F) + 3;
							method_7(ptr5, ptr5 - (int)num4, num5);
							ptr5 += (int)num5;
							ptr3 += 3;
						}
						else if ((num3 & 8) == 0)
						{
							uint num4 = num3 >> 15;
							uint num5 = ((num3 >> 4) & 0x7FF) + 3;
							method_7(ptr5, ptr5 - (int)num4, num5);
							ptr5 += (int)num5;
							ptr3 += 4;
						}
						else
						{
							byte byte_2 = (byte)(num3 >> 16);
							uint num5 = (num3 >> 4) & 0xFFFu;
							method_4(ptr5, byte_2, num5);
							ptr5 += (int)num5;
							ptr3 += 3;
						}
					}
					else
					{
						method_7(ptr5, ptr3, 4u);
						ptr5 += (int)array[num2 & 0xF];
						ptr3 += (int)array[num2 & 0xF];
						num2 >>= (int)(byte)array[num2 & 0xF];
						if (ptr5 >= ptr8)
						{
							break;
						}
					}
				}
				while (ptr5 < ptr7)
				{
					if (num2 == 1)
					{
						ptr3 += 4;
						num2 = 2147483648u;
					}
					*ptr5 = *ptr3;
					ptr5++;
					ptr3++;
					num2 >>= 1;
				}
				return (uint)(ptr5 - ptr4);
			}
		}
	}

	public byte[] method_11(byte[] byte_0)
	{
		uint num = method_9(byte_0, 0u);
		byte[] array = null;
		if (num != 0)
		{
			array = new byte[num];
			method_10(byte_0, 0u, array);
		}
		return array;
	}
}
