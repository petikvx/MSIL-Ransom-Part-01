using System.Collections.Generic;
using System.Text;
using Ubiety.Dns.Core.Common;
using Ubiety.Dns.Core.Records;

namespace Ubiety.Dns.Core;

public class RecordReader
{
	private readonly byte[] _data;

	public int Position { get; set; }

	public RecordReader(byte[] data)
	{
		_data = data;
		Position = 0;
	}

	public RecordReader(byte[] data, int position)
	{
		_data = data;
		Position = position;
	}

	public byte ReadByte()
	{
		return (byte)((Position < _data.Length) ? _data[Position++] : 0);
	}

	public char ReadChar()
	{
		return (char)ReadByte();
	}

	public ushort ReadUInt16()
	{
		return (ushort)((ReadByte() << 8) | ReadByte());
	}

	public ushort ReadUInt16(int offset)
	{
		Position += offset;
		return ReadUInt16();
	}

	public uint ReadUInt32()
	{
		return (uint)((ReadUInt16() << 16) | ReadUInt16());
	}

	public string ReadDomainName()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num;
		while (true)
		{
			if ((num = ReadByte()) != 0)
			{
				if ((num & 0xC0) == 192)
				{
					break;
				}
				while (num > 0)
				{
					stringBuilder.Append(ReadChar());
					num--;
				}
				stringBuilder.Append('.');
				continue;
			}
			return (stringBuilder.Length == 0) ? "." : stringBuilder.ToString();
		}
		RecordReader recordReader = new RecordReader(_data, ((num & 0x3F) << 8) | ReadByte());
		stringBuilder.Append(recordReader.ReadDomainName());
		return stringBuilder.ToString();
	}

	public string ReadString()
	{
		short length = ReadByte();
		return Encoding.UTF8.GetString(ReadBytes(length));
	}

	public byte[] ReadBytes(int length)
	{
		List<byte> list = new List<byte>();
		for (int i = 0; i < length; i++)
		{
			list.Add(ReadByte());
		}
		return list.ToArray();
	}

	public Record ReadRecord(RecordType type)
	{
		return type.GetRecord(this);
	}
}
