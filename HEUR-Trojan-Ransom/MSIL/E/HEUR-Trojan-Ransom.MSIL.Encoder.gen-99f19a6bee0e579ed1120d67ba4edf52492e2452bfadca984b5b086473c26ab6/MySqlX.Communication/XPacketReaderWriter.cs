using System;
using System.IO;
using Google.Protobuf;

namespace MySqlX.Communication;

internal class XPacketReaderWriter
{
	private Stream _stream;

	public XPacketReaderWriter(Stream stream)
	{
		_stream = stream;
	}

	public void Write(int id, IMessage message)
	{
		int value = message.CalculateSize() + 1;
		_stream.Write(BitConverter.GetBytes(value), 0, 4);
		_stream.WriteByte((byte)id);
		if (message.CalculateSize() > 0)
		{
			message.WriteTo(_stream);
		}
		_stream.Flush();
	}

	public void Write(ClientMessageId id, IMessage message)
	{
		Write((int)id, message);
	}

	public CommunicationPacket Read()
	{
		byte[] array = new byte[5];
		ReadFully(array, 0, 5);
		int num = BitConverter.ToInt32(array, 0);
		byte[] array2 = new byte[num - 1];
		ReadFully(array2, 0, num - 1);
		return new CommunicationPacket(array[4], num - 1, array2);
	}

	private void ReadFully(byte[] buffer, int offset, int count)
	{
		int num = 0;
		int num2 = count;
		while (true)
		{
			if (num2 > 0)
			{
				int num3 = _stream.Read(buffer, offset + num, num2);
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
