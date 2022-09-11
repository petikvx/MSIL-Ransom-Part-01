using System;
using System.Runtime.CompilerServices;

public class GClass1
{
	private char[] char_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	public GClass1(char[] char_1)
	{
		int num = 0;
		char_0 = char_1;
		int_0 = char_1.Length;
		for (int i = 0; i < 2; i++)
		{
			if (char_1[int_0 - i - 1] == '=')
			{
				num++;
			}
		}
		int_4 = num;
		int_3 = int_0 / 4;
		int_1 = int_3 * 3;
	}

	public byte[] method_0()
	{
		byte[] array = new byte[int_0];
		byte[] array2 = new byte[int_1];
		for (int i = 0; i < int_0; i++)
		{
			array[i] = method_1(char_0[i]);
		}
		for (int j = 0; j < int_3; j++)
		{
			byte b = array[j * 4];
			byte b2 = array[j * 4 + 1];
			byte b3 = array[j * 4 + 2];
			byte b4 = array[j * 4 + 3];
			byte b5 = (byte)(b << 2);
			byte b6 = (byte)((b2 & 0x30) >> 4);
			b6 = (byte)(b6 + b5);
			b5 = (byte)((b2 & 0xF) << 4);
			byte b7 = (byte)((b3 & 0x3C) >> 2);
			b7 = (byte)(b7 + b5);
			b5 = (byte)((b3 & 3) << 6);
			byte b8 = b4;
			b8 = (byte)(b8 + b5);
			array2[j * 3] = b6;
			array2[j * 3 + 1] = b7;
			array2[j * 3 + 2] = b8;
		}
		int_2 = int_1 - int_4;
		byte[] array3 = new byte[int_2];
		for (int k = 0; k < int_2; k++)
		{
			array3[k] = array2[k];
		}
		return array3;
	}

	private byte method_1(char char_1)
	{
		char[] array = new char[64];
		GClass1.smethod_0((Array)array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
		char[] array2 = array;
		if (char_1 != '=')
		{
			int num = 0;
			while (true)
			{
				if (num < 64)
				{
					if (array2[num] == char_1)
					{
						break;
					}
					num++;
					continue;
				}
				return 0;
			}
			return (byte)num;
		}
		return 0;
	}

	static void smethod_0(Array array_0, RuntimeFieldHandle runtimeFieldHandle_0)
	{
		RuntimeHelpers.InitializeArray(array_0, runtimeFieldHandle_0);
	}
}
