using System;
using System.IO;
using System.Text;
using MySql.Data.Common;

namespace MySql.Data.MySqlClient;

internal class MySqlPacket
{
	private byte[] _tempBuffer = new byte[256];

	private Encoding _encoding;

	private readonly MemoryStream _buffer = new MemoryStream(5);

	public Encoding Encoding
	{
		get
		{
			return _encoding;
		}
		set
		{
			_encoding = value;
		}
	}

	public bool HasMoreData => _buffer.Position < _buffer.Length;

	public int Position
	{
		get
		{
			return (int)_buffer.Position;
		}
		set
		{
			_buffer.Position = value;
		}
	}

	public int Length
	{
		get
		{
			return (int)_buffer.Length;
		}
		set
		{
			_buffer.SetLength(value);
		}
	}

	public bool IsLastPacket
	{
		get
		{
			if (_buffer.GetBuffer()[0] == 254)
			{
				return Length <= 5;
			}
			return false;
		}
	}

	public byte[] Buffer => _buffer.GetBuffer();

	public DBVersion Version { get; set; }

	private MySqlPacket()
	{
		Clear();
	}

	public MySqlPacket(Encoding enc)
		: this()
	{
		Encoding = enc;
	}

	public MySqlPacket(MemoryStream stream)
		: this()
	{
		_buffer = stream;
	}

	public void Clear()
	{
		Position = 4;
	}

	public byte ReadByte()
	{
		return (byte)_buffer.ReadByte();
	}

	public int Read(byte[] byteBuffer, int offset, int count)
	{
		return _buffer.Read(byteBuffer, offset, count);
	}

	public void WriteByte(byte b)
	{
		_buffer.WriteByte(b);
	}

	public void Write(byte[] bytesToWrite)
	{
		Write(bytesToWrite, 0, bytesToWrite.Length);
	}

	public void Write(byte[] bytesToWrite, int offset, int countToWrite)
	{
		_buffer.Write(bytesToWrite, offset, countToWrite);
	}

	public int ReadNBytes()
	{
		byte b = ReadByte();
		if (b < 1 || b > 4)
		{
			throw new MySqlException(Resources.IncorrectTransmission);
		}
		return ReadInteger(b);
	}

	public void SetByte(long position, byte value)
	{
		long position2 = _buffer.Position;
		_buffer.Position = position;
		_buffer.WriteByte(value);
		_buffer.Position = position2;
	}

	public long ReadFieldLength()
	{
		byte b = ReadByte();
		return b switch
		{
			251 => -1L, 
			252 => ReadInteger(2), 
			253 => ReadInteger(3), 
			254 => ReadLong(8), 
			_ => b, 
		};
	}

	public ulong ReadBitValue(int numbytes)
	{
		ulong num = 0uL;
		int num2 = (int)_buffer.Position;
		byte[] buffer = _buffer.GetBuffer();
		int num3 = 0;
		for (int i = 0; i < numbytes; i++)
		{
			num <<= num3;
			num |= buffer[num2++];
			num3 = 8;
		}
		_buffer.Position += numbytes;
		return num;
	}

	public long ReadLong(int numbytes)
	{
		byte[] buffer = _buffer.GetBuffer();
		int startIndex = (int)_buffer.Position;
		_buffer.Position += numbytes;
		return numbytes switch
		{
			8 => BitConverter.ToInt64(buffer, startIndex), 
			4 => BitConverter.ToUInt32(buffer, startIndex), 
			2 => BitConverter.ToUInt16(buffer, startIndex), 
			_ => throw new NotSupportedException("Only byte lengths of 2, 4, or 8 are supported"), 
		};
	}

	public ulong ReadULong(int numbytes)
	{
		byte[] buffer = _buffer.GetBuffer();
		int startIndex = (int)_buffer.Position;
		_buffer.Position += numbytes;
		return numbytes switch
		{
			8 => BitConverter.ToUInt64(buffer, startIndex), 
			4 => BitConverter.ToUInt32(buffer, startIndex), 
			2 => BitConverter.ToUInt16(buffer, startIndex), 
			_ => throw new NotSupportedException("Only byte lengths of 2, 4, or 8 are supported"), 
		};
	}

	public int Read3ByteInt()
	{
		int num = 0;
		int num2 = (int)_buffer.Position;
		byte[] buffer = _buffer.GetBuffer();
		int num3 = 0;
		for (int i = 0; i < 3; i++)
		{
			num |= buffer[num2++] << num3;
			num3 += 8;
		}
		_buffer.Position += 3L;
		return num;
	}

	public int ReadInteger(int numbytes)
	{
		if (numbytes == 3)
		{
			return Read3ByteInt();
		}
		return (int)ReadLong(numbytes);
	}

	public void WriteInteger(long v, int numbytes)
	{
		long num = v;
		for (int i = 0; i < numbytes; i++)
		{
			_tempBuffer[i] = (byte)((ulong)num & 0xFFuL);
			num >>= 8;
		}
		Write(_tempBuffer, 0, numbytes);
	}

	public int ReadPackedInteger()
	{
		byte b = ReadByte();
		return b switch
		{
			251 => -1, 
			252 => ReadInteger(2), 
			253 => ReadInteger(3), 
			254 => ReadInteger(4), 
			_ => b, 
		};
	}

	public void WriteLength(long length)
	{
		if (length < 251L)
		{
			WriteByte((byte)length);
		}
		else if (length < 65536L)
		{
			WriteByte(252);
			WriteInteger(length, 2);
		}
		else if (length < 16777216L)
		{
			WriteByte(253);
			WriteInteger(length, 3);
		}
		else
		{
			WriteByte(254);
			WriteInteger(length, 4);
		}
	}

	public void WriteLenString(string s)
	{
		byte[] bytes = _encoding.GetBytes(s);
		WriteLength(bytes.Length);
		Write(bytes, 0, bytes.Length);
	}

	public void WriteStringNoNull(string v)
	{
		byte[] bytes = _encoding.GetBytes(v);
		Write(bytes, 0, bytes.Length);
	}

	public void WriteString(string v)
	{
		WriteStringNoNull(v);
		WriteByte(0);
	}

	public string ReadLenString()
	{
		long length = ReadPackedInteger();
		return ReadString(length);
	}

	public string ReadAsciiString(long length)
	{
		if (length == 0L)
		{
			return string.Empty;
		}
		Read(_tempBuffer, 0, (int)length);
		return Encoding.GetEncoding("us-ascii").GetString(_tempBuffer, 0, (int)length);
	}

	public string ReadString(long length)
	{
		if (length == 0L)
		{
			return string.Empty;
		}
		if (_tempBuffer == null || length > _tempBuffer.Length)
		{
			_tempBuffer = new byte[length];
		}
		Read(_tempBuffer, 0, (int)length);
		return _encoding.GetString(_tempBuffer, 0, (int)length);
	}

	public string ReadString()
	{
		return ReadString(_encoding);
	}

	public string ReadString(Encoding theEncoding)
	{
		byte[] array = ReadStringAsBytes();
		return theEncoding.GetString(array, 0, array.Length);
	}

	public byte[] ReadStringAsBytes()
	{
		byte[] buffer = _buffer.GetBuffer();
		int i = (int)_buffer.Position;
		byte[] array;
		for (array = buffer; i < (int)_buffer.Length && array[i] != 0; i++)
		{
		}
		byte[] array2 = new byte[i - _buffer.Position];
		Array.Copy(array, (int)_buffer.Position, array2, 0, (int)(i - _buffer.Position));
		_buffer.Position = i + 1;
		return array2;
	}
}
