using System;
using System.IO;
using Google.Protobuf;
using MySql.Data.X.Communication;
using Mysqlx;
using Mysqlx.Connection;

namespace MySqlX.Communication;

internal class XPacketReaderWriter
{
	private Stream _stream;

	public XCompressionController CompressionController { get; private set; }

	public XPacketReaderWriter(Stream stream)
	{
		_stream = stream;
	}

	public XPacketReaderWriter(Stream stream, XCompressionController compressionController)
		: this(stream)
	{
		CompressionController = compressionController;
	}

	public void Write(int id, IMessage message)
	{
		int num = message.CalculateSize();
		if (CompressionController != null && CompressionController.IsCompressionEnabled && num > 1000 && CompressionController.ClientSupportedCompressedMessages.Contains((ClientMessageId)id))
		{
			byte[] array = new byte[5];
			byte[] array2 = MessageExtensions.ToByteArray(message);
			byte[] array3 = new byte[array.Length + array2.Length];
			byte[] bytes = BitConverter.GetBytes(num + 1);
			Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
			array[4] = (byte)id;
			Buffer.BlockCopy(array, 0, array3, 0, array.Length);
			Buffer.BlockCopy(array2, 0, array3, array.Length, array2.Length);
			Compression compression = new Compression();
			compression.UncompressedSize = (ulong)(num + array.Length);
			compression.ClientMessages = (ClientMessages.Types.Type)id;
			compression.Payload = ByteString.CopyFrom(CompressionController.Compress(array3));
			_stream.Write(BitConverter.GetBytes(compression.CalculateSize() + 1), 0, 4);
			_stream.WriteByte(46);
			if (num > 0)
			{
				MessageExtensions.WriteTo((IMessage)(object)compression, _stream);
			}
		}
		else
		{
			_stream.Write(BitConverter.GetBytes(num + 1), 0, 4);
			_stream.WriteByte((byte)id);
			if (num > 0)
			{
				MessageExtensions.WriteTo(message, _stream);
			}
		}
		_stream.Flush();
	}

	public void Write(ClientMessageId id, IMessage message)
	{
		Write((int)id, message);
	}

	public CommunicationPacket Read()
	{
		bool flag;
		if ((flag = CompressionController != null && CompressionController.IsCompressionEnabled) && CompressionController.LastMessageContainsMultipleMessages)
		{
			return CompressionController.ReadNextBufferedMessageAsCommunicationPacket();
		}
		byte[] array = new byte[5];
		ReadFully(array, 0, 5);
		int num = BitConverter.ToInt32(array, 0);
		byte[] array2 = new byte[num - 1];
		ReadFully(array2, 0, num - 1);
		if (flag && array[4] == 19)
		{
			CommunicationPacket communicationPacket = new CommunicationPacket(array[4], num - 1, array2);
			Compression compression = Compression.Parser.ParseFrom(communicationPacket.Buffer);
			byte[] input = compression.Payload.ToByteArray();
			byte[] array3 = CompressionController.Decompress(input, (int)compression.UncompressedSize);
			array2 = new byte[array3.Length - 5];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = array3[i + 5];
			}
			return new CommunicationPacket(array3[4], BitConverter.ToInt32(array3, 0) - 1, array2);
		}
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
