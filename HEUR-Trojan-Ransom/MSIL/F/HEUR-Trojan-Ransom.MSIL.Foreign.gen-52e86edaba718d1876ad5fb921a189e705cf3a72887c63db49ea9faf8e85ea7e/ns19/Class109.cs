using System;
using System.IO;
using Google.Protobuf;
using ns5;
using ns7;

namespace ns19;

internal sealed class Class109
{
	private Stream stream_0;

	public Class109(Stream stream_1)
	{
		stream_0 = stream_1;
	}

	public void method_0(int int_0, IMessage imessage_0)
	{
		int value = imessage_0.CalculateSize() + 1;
		stream_0.Write(BitConverter.GetBytes(value), 0, 4);
		stream_0.WriteByte((byte)int_0);
		if (imessage_0.CalculateSize() > 0)
		{
			imessage_0.WriteTo(stream_0);
		}
		stream_0.Flush();
	}

	public void method_1(Enum30 enum30_0, IMessage imessage_0)
	{
		method_0((int)enum30_0, imessage_0);
	}

	public Class108 method_2()
	{
		byte[] array = new byte[5];
		method_3(array, 0, 5);
		int num = BitConverter.ToInt32(array, 0);
		byte[] array2 = new byte[num - 1];
		method_3(array2, 0, num - 1);
		return new Class108(array[4], num - 1, array2);
	}

	private void method_3(byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		int num2 = int_1;
		while (true)
		{
			if (num2 > 0)
			{
				int num3 = stream_0.Read(byte_0, int_0 + num, num2);
				if (num3 == 0)
				{
					break;
				}
				num += num3;
				num2 -= num3;
				continue;
			}
			return;
		}
		throw new EndOfStreamException();
	}
}
