using System;
using System.IO;
using System.Text;

namespace Google.Protobuf;

public sealed class CodedOutputStream : IDisposable
{
	public sealed class OutOfSpaceException : IOException
	{
		internal OutOfSpaceException()
			: base("CodedOutputStream was writing to a flat byte array and ran out of space.")
		{
		}
	}

	private const int LittleEndian64Size = 8;

	private const int LittleEndian32Size = 4;

	internal static readonly Encoding Utf8Encoding = Encoding.UTF8;

	public static readonly int DefaultBufferSize = 4096;

	private readonly bool leaveOpen;

	private readonly byte[] buffer;

	private readonly int limit;

	private int position;

	private readonly Stream output;

	public long Position
	{
		get
		{
			if (output != null)
			{
				return output.Position + position;
			}
			return position;
		}
	}

	public int SpaceLeft
	{
		get
		{
			if (output != null)
			{
				throw new InvalidOperationException("SpaceLeft can only be called on CodedOutputStreams that are writing to a flat array.");
			}
			return limit - position;
		}
	}

	public static int ComputeDoubleSize(double value)
	{
		return 8;
	}

	public static int ComputeFloatSize(float value)
	{
		return 4;
	}

	public static int ComputeUInt64Size(ulong value)
	{
		return ComputeRawVarint64Size(value);
	}

	public static int ComputeInt64Size(long value)
	{
		return ComputeRawVarint64Size((ulong)value);
	}

	public static int ComputeInt32Size(int value)
	{
		if (value >= 0)
		{
			return ComputeRawVarint32Size((uint)value);
		}
		return 10;
	}

	public static int ComputeFixed64Size(ulong value)
	{
		return 8;
	}

	public static int ComputeFixed32Size(uint value)
	{
		return 4;
	}

	public static int ComputeBoolSize(bool value)
	{
		return 1;
	}

	public static int ComputeStringSize(string value)
	{
		int byteCount = Utf8Encoding.GetByteCount(value);
		return ComputeLengthSize(byteCount) + byteCount;
	}

	public static int ComputeGroupSize(IMessage value)
	{
		return value.CalculateSize();
	}

	public static int ComputeMessageSize(IMessage value)
	{
		int num = value.CalculateSize();
		return ComputeLengthSize(num) + num;
	}

	public static int ComputeBytesSize(ByteString value)
	{
		return ComputeLengthSize(value.Length) + value.Length;
	}

	public static int ComputeUInt32Size(uint value)
	{
		return ComputeRawVarint32Size(value);
	}

	public static int ComputeEnumSize(int value)
	{
		return ComputeInt32Size(value);
	}

	public static int ComputeSFixed32Size(int value)
	{
		return 4;
	}

	public static int ComputeSFixed64Size(long value)
	{
		return 8;
	}

	public static int ComputeSInt32Size(int value)
	{
		return ComputeRawVarint32Size(EncodeZigZag32(value));
	}

	public static int ComputeSInt64Size(long value)
	{
		return ComputeRawVarint64Size(EncodeZigZag64(value));
	}

	public static int ComputeLengthSize(int length)
	{
		return ComputeRawVarint32Size((uint)length);
	}

	public static int ComputeRawVarint32Size(uint value)
	{
		if ((value & 0xFFFFFF80u) == 0)
		{
			return 1;
		}
		if ((value & 0xFFFFC000u) == 0)
		{
			return 2;
		}
		if ((value & 0xFFE00000u) == 0)
		{
			return 3;
		}
		if ((value & 0xF0000000u) == 0)
		{
			return 4;
		}
		return 5;
	}

	public static int ComputeRawVarint64Size(ulong value)
	{
		if ((value & 0xFFFFFFFFFFFFFF80uL) == 0L)
		{
			return 1;
		}
		if ((value & 0xFFFFFFFFFFFFC000uL) == 0L)
		{
			return 2;
		}
		if ((value & 0xFFFFFFFFFFE00000uL) == 0L)
		{
			return 3;
		}
		if ((value & 0xFFFFFFFFF0000000uL) == 0L)
		{
			return 4;
		}
		if ((value & 0xFFFFFFF800000000uL) == 0L)
		{
			return 5;
		}
		if ((value & 0xFFFFFC0000000000uL) == 0L)
		{
			return 6;
		}
		if ((value & 0xFFFE000000000000uL) == 0L)
		{
			return 7;
		}
		if ((value & 0xFF00000000000000uL) == 0L)
		{
			return 8;
		}
		if ((value & 0x8000000000000000uL) == 0L)
		{
			return 9;
		}
		return 10;
	}

	public static int ComputeTagSize(int fieldNumber)
	{
		return ComputeRawVarint32Size(WireFormat.MakeTag(fieldNumber, WireFormat.WireType.Varint));
	}

	public CodedOutputStream(byte[] flatArray)
		: this(flatArray, 0, flatArray.Length)
	{
	}

	private CodedOutputStream(byte[] buffer, int offset, int length)
	{
		output = null;
		this.buffer = buffer;
		position = offset;
		limit = offset + length;
		leaveOpen = true;
	}

	private CodedOutputStream(Stream output, byte[] buffer, bool leaveOpen)
	{
		this.output = ProtoPreconditions.CheckNotNull(output, "output");
		this.buffer = buffer;
		position = 0;
		limit = buffer.Length;
		this.leaveOpen = leaveOpen;
	}

	public CodedOutputStream(Stream output)
		: this(output, DefaultBufferSize, leaveOpen: false)
	{
	}

	public CodedOutputStream(Stream output, int bufferSize)
		: this(output, new byte[bufferSize], leaveOpen: false)
	{
	}

	public CodedOutputStream(Stream output, bool leaveOpen)
		: this(output, DefaultBufferSize, leaveOpen)
	{
	}

	public CodedOutputStream(Stream output, int bufferSize, bool leaveOpen)
		: this(output, new byte[bufferSize], leaveOpen)
	{
	}

	public void WriteDouble(double value)
	{
		WriteRawLittleEndian64((ulong)BitConverter.DoubleToInt64Bits(value));
	}

	public void WriteFloat(float value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		if (!BitConverter.IsLittleEndian)
		{
			ByteArray.Reverse(bytes);
		}
		if (limit - position >= 4)
		{
			buffer[position++] = bytes[0];
			buffer[position++] = bytes[1];
			buffer[position++] = bytes[2];
			buffer[position++] = bytes[3];
		}
		else
		{
			WriteRawBytes(bytes, 0, 4);
		}
	}

	public void WriteUInt64(ulong value)
	{
		WriteRawVarint64(value);
	}

	public void WriteInt64(long value)
	{
		WriteRawVarint64((ulong)value);
	}

	public void WriteInt32(int value)
	{
		if (value >= 0)
		{
			WriteRawVarint32((uint)value);
		}
		else
		{
			WriteRawVarint64((ulong)value);
		}
	}

	public void WriteFixed64(ulong value)
	{
		WriteRawLittleEndian64(value);
	}

	public void WriteFixed32(uint value)
	{
		WriteRawLittleEndian32(value);
	}

	public void WriteBool(bool value)
	{
		WriteRawByte((byte)(value ? 1 : 0));
	}

	public void WriteString(string value)
	{
		int byteCount = Utf8Encoding.GetByteCount(value);
		WriteLength(byteCount);
		if (limit - position >= byteCount)
		{
			if (byteCount == value.Length)
			{
				for (int i = 0; i < byteCount; i++)
				{
					buffer[position + i] = (byte)value[i];
				}
			}
			else
			{
				Utf8Encoding.GetBytes(value, 0, value.Length, buffer, position);
			}
			position += byteCount;
		}
		else
		{
			byte[] bytes = Utf8Encoding.GetBytes(value);
			WriteRawBytes(bytes);
		}
	}

	public void WriteMessage(IMessage value)
	{
		WriteLength(value.CalculateSize());
		value.WriteTo(this);
	}

	public void WriteBytes(ByteString value)
	{
		WriteLength(value.Length);
		value.WriteRawBytesTo(this);
	}

	public void WriteUInt32(uint value)
	{
		WriteRawVarint32(value);
	}

	public void WriteEnum(int value)
	{
		WriteInt32(value);
	}

	public void WriteSFixed32(int value)
	{
		WriteRawLittleEndian32((uint)value);
	}

	public void WriteSFixed64(long value)
	{
		WriteRawLittleEndian64((ulong)value);
	}

	public void WriteSInt32(int value)
	{
		WriteRawVarint32(EncodeZigZag32(value));
	}

	public void WriteSInt64(long value)
	{
		WriteRawVarint64(EncodeZigZag64(value));
	}

	public void WriteLength(int length)
	{
		WriteRawVarint32((uint)length);
	}

	public void WriteTag(int fieldNumber, WireFormat.WireType type)
	{
		WriteRawVarint32(WireFormat.MakeTag(fieldNumber, type));
	}

	public void WriteTag(uint tag)
	{
		WriteRawVarint32(tag);
	}

	public void WriteRawTag(byte b1)
	{
		WriteRawByte(b1);
	}

	public void WriteRawTag(byte b1, byte b2)
	{
		WriteRawByte(b1);
		WriteRawByte(b2);
	}

	public void WriteRawTag(byte b1, byte b2, byte b3)
	{
		WriteRawByte(b1);
		WriteRawByte(b2);
		WriteRawByte(b3);
	}

	public void WriteRawTag(byte b1, byte b2, byte b3, byte b4)
	{
		WriteRawByte(b1);
		WriteRawByte(b2);
		WriteRawByte(b3);
		WriteRawByte(b4);
	}

	public void WriteRawTag(byte b1, byte b2, byte b3, byte b4, byte b5)
	{
		WriteRawByte(b1);
		WriteRawByte(b2);
		WriteRawByte(b3);
		WriteRawByte(b4);
		WriteRawByte(b5);
	}

	internal void WriteRawVarint32(uint value)
	{
		if (value < 128 && position < limit)
		{
			buffer[position++] = (byte)value;
			return;
		}
		while (value > 127 && position < limit)
		{
			buffer[position++] = (byte)((value & 0x7Fu) | 0x80u);
			value >>= 7;
		}
		while (value > 127)
		{
			WriteRawByte((byte)((value & 0x7Fu) | 0x80u));
			value >>= 7;
		}
		if (position < limit)
		{
			buffer[position++] = (byte)value;
		}
		else
		{
			WriteRawByte((byte)value);
		}
	}

	internal void WriteRawVarint64(ulong value)
	{
		while (value > 127L && position < limit)
		{
			buffer[position++] = (byte)((value & 0x7FuL) | 0x80uL);
			value >>= 7;
		}
		while (value > 127L)
		{
			WriteRawByte((byte)((value & 0x7FuL) | 0x80uL));
			value >>= 7;
		}
		if (position < limit)
		{
			buffer[position++] = (byte)value;
		}
		else
		{
			WriteRawByte((byte)value);
		}
	}

	internal void WriteRawLittleEndian32(uint value)
	{
		if (position + 4 > limit)
		{
			WriteRawByte((byte)value);
			WriteRawByte((byte)(value >> 8));
			WriteRawByte((byte)(value >> 16));
			WriteRawByte((byte)(value >> 24));
		}
		else
		{
			buffer[position++] = (byte)value;
			buffer[position++] = (byte)(value >> 8);
			buffer[position++] = (byte)(value >> 16);
			buffer[position++] = (byte)(value >> 24);
		}
	}

	internal void WriteRawLittleEndian64(ulong value)
	{
		if (position + 8 > limit)
		{
			WriteRawByte((byte)value);
			WriteRawByte((byte)(value >> 8));
			WriteRawByte((byte)(value >> 16));
			WriteRawByte((byte)(value >> 24));
			WriteRawByte((byte)(value >> 32));
			WriteRawByte((byte)(value >> 40));
			WriteRawByte((byte)(value >> 48));
			WriteRawByte((byte)(value >> 56));
		}
		else
		{
			buffer[position++] = (byte)value;
			buffer[position++] = (byte)(value >> 8);
			buffer[position++] = (byte)(value >> 16);
			buffer[position++] = (byte)(value >> 24);
			buffer[position++] = (byte)(value >> 32);
			buffer[position++] = (byte)(value >> 40);
			buffer[position++] = (byte)(value >> 48);
			buffer[position++] = (byte)(value >> 56);
		}
	}

	internal void WriteRawByte(byte value)
	{
		if (position == limit)
		{
			RefreshBuffer();
		}
		buffer[position++] = value;
	}

	internal void WriteRawByte(uint value)
	{
		WriteRawByte((byte)value);
	}

	internal void WriteRawBytes(byte[] value)
	{
		WriteRawBytes(value, 0, value.Length);
	}

	internal void WriteRawBytes(byte[] value, int offset, int length)
	{
		if (limit - position >= length)
		{
			ByteArray.Copy(value, offset, buffer, position, length);
			position += length;
			return;
		}
		int num = limit - position;
		ByteArray.Copy(value, offset, buffer, position, num);
		offset += num;
		length -= num;
		position = limit;
		RefreshBuffer();
		if (length <= limit)
		{
			ByteArray.Copy(value, offset, buffer, 0, length);
			position = length;
		}
		else
		{
			output.Write(value, offset, length);
		}
	}

	internal static uint EncodeZigZag32(int n)
	{
		return (uint)((n << 1) ^ (n >> 31));
	}

	internal static ulong EncodeZigZag64(long n)
	{
		return (ulong)((n << 1) ^ (n >> 63));
	}

	private void RefreshBuffer()
	{
		if (output == null)
		{
			throw new OutOfSpaceException();
		}
		output.Write(buffer, 0, position);
		position = 0;
	}

	public void Dispose()
	{
		Flush();
		if (!leaveOpen)
		{
			output.Dispose();
		}
	}

	public void Flush()
	{
		if (output != null)
		{
			RefreshBuffer();
		}
	}

	public void CheckNoSpaceLeft()
	{
		if (SpaceLeft != 0)
		{
			throw new InvalidOperationException("Did not write as much data as expected.");
		}
	}
}
