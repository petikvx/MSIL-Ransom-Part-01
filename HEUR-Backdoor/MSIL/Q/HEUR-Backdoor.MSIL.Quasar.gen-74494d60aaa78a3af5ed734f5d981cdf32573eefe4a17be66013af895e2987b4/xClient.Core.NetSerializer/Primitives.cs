using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace xClient.Core.NetSerializer;

public static class Primitives
{
	private sealed class StringHelper
	{
		public const int BYTEBUFFERLEN = 256;

		public const int CHARBUFFERLEN = 128;

		private Encoder m_encoder;

		private Decoder m_decoder;

		private byte[] m_byteBuffer;

		private char[] m_charBuffer;

		public UTF8Encoding Encoding { get; private set; }

		public Encoder Encoder
		{
			get
			{
				if (m_encoder == null)
				{
					m_encoder = Encoding.GetEncoder();
				}
				return m_encoder;
			}
		}

		public Decoder Decoder
		{
			get
			{
				if (m_decoder == null)
				{
					m_decoder = Encoding.GetDecoder();
				}
				return m_decoder;
			}
		}

		public byte[] ByteBuffer
		{
			get
			{
				if (m_byteBuffer == null)
				{
					m_byteBuffer = new byte[256];
				}
				return m_byteBuffer;
			}
		}

		public char[] CharBuffer
		{
			get
			{
				if (m_charBuffer == null)
				{
					m_charBuffer = new char[128];
				}
				return m_charBuffer;
			}
		}

		public StringHelper()
		{
			Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);
		}
	}

	[ThreadStatic]
	private static StringHelper s_stringHelper;

	private static readonly byte[] s_emptyByteArray = new byte[0];

	public static MethodInfo GetWritePrimitive(Type type)
	{
		return typeof(Primitives).GetMethod("WritePrimitive", BindingFlags.Static | BindingFlags.Public | BindingFlags.ExactBinding, null, new Type[2]
		{
			typeof(Stream),
			type
		}, null);
	}

	public static MethodInfo GetReaderPrimitive(Type type)
	{
		return typeof(Primitives).GetMethod("ReadPrimitive", BindingFlags.Static | BindingFlags.Public | BindingFlags.ExactBinding, null, new Type[2]
		{
			typeof(Stream),
			type.MakeByRefType()
		}, null);
	}

	private static uint EncodeZigZag32(int n)
	{
		return (uint)((n << 1) ^ (n >> 31));
	}

	private static ulong EncodeZigZag64(long n)
	{
		return (ulong)((n << 1) ^ (n >> 63));
	}

	private static int DecodeZigZag32(uint n)
	{
		return (int)((n >> 1) ^ (0 - (n & 1)));
	}

	private static long DecodeZigZag64(ulong n)
	{
		return (long)((n >> 1) ^ (0L - (n & 1L)));
	}

	private static uint ReadVarint32(Stream stream)
	{
		int num = 0;
		int num2 = 0;
		while (true)
		{
			if (num2 < 32)
			{
				int num3 = stream.ReadByte();
				if (num3 != -1)
				{
					num |= (num3 & 0x7F) << num2;
					if ((num3 & 0x80) == 0)
					{
						break;
					}
					num2 += 7;
					continue;
				}
				throw new EndOfStreamException();
			}
			throw new InvalidDataException();
		}
		return (uint)num;
	}

	private static void WriteVarint32(Stream stream, uint value)
	{
		while (value >= 128)
		{
			stream.WriteByte((byte)(value | 0x80u));
			value >>= 7;
		}
		stream.WriteByte((byte)value);
	}

	private static ulong ReadVarint64(Stream stream)
	{
		long num = 0L;
		int num2 = 0;
		while (true)
		{
			if (num2 < 64)
			{
				int num3 = stream.ReadByte();
				if (num3 != -1)
				{
					num |= (long)(num3 & 0x7F) << num2;
					if ((num3 & 0x80) == 0)
					{
						break;
					}
					num2 += 7;
					continue;
				}
				throw new EndOfStreamException();
			}
			throw new InvalidDataException();
		}
		return (ulong)num;
	}

	private static void WriteVarint64(Stream stream, ulong value)
	{
		while (value >= 128L)
		{
			stream.WriteByte((byte)(value | 0x80uL));
			value >>= 7;
		}
		stream.WriteByte((byte)value);
	}

	public static void WritePrimitive(Stream stream, bool value)
	{
		stream.WriteByte((byte)(value ? 1 : 0));
	}

	public static void ReadPrimitive(Stream stream, out bool value)
	{
		int num = stream.ReadByte();
		value = num != 0;
	}

	public static void WritePrimitive(Stream stream, byte value)
	{
		stream.WriteByte(value);
	}

	public static void ReadPrimitive(Stream stream, out byte value)
	{
		value = (byte)stream.ReadByte();
	}

	public static void WritePrimitive(Stream stream, sbyte value)
	{
		stream.WriteByte((byte)value);
	}

	public static void ReadPrimitive(Stream stream, out sbyte value)
	{
		value = (sbyte)stream.ReadByte();
	}

	public static void WritePrimitive(Stream stream, char value)
	{
		WriteVarint32(stream, value);
	}

	public static void ReadPrimitive(Stream stream, out char value)
	{
		value = (char)ReadVarint32(stream);
	}

	public static void WritePrimitive(Stream stream, ushort value)
	{
		WriteVarint32(stream, value);
	}

	public static void ReadPrimitive(Stream stream, out ushort value)
	{
		value = (ushort)ReadVarint32(stream);
	}

	public static void WritePrimitive(Stream stream, short value)
	{
		WriteVarint32(stream, EncodeZigZag32(value));
	}

	public static void ReadPrimitive(Stream stream, out short value)
	{
		value = (short)DecodeZigZag32(ReadVarint32(stream));
	}

	public static void WritePrimitive(Stream stream, uint value)
	{
		WriteVarint32(stream, value);
	}

	public static void ReadPrimitive(Stream stream, out uint value)
	{
		value = ReadVarint32(stream);
	}

	public static void WritePrimitive(Stream stream, int value)
	{
		WriteVarint32(stream, EncodeZigZag32(value));
	}

	public static void ReadPrimitive(Stream stream, out int value)
	{
		value = DecodeZigZag32(ReadVarint32(stream));
	}

	public static void WritePrimitive(Stream stream, ulong value)
	{
		WriteVarint64(stream, value);
	}

	public static void ReadPrimitive(Stream stream, out ulong value)
	{
		value = ReadVarint64(stream);
	}

	public static void WritePrimitive(Stream stream, long value)
	{
		WriteVarint64(stream, EncodeZigZag64(value));
	}

	public static void ReadPrimitive(Stream stream, out long value)
	{
		value = DecodeZigZag64(ReadVarint64(stream));
	}

	public unsafe static void WritePrimitive(Stream stream, float value)
	{
		uint value2 = *(uint*)(&value);
		WriteVarint32(stream, value2);
	}

	public unsafe static void ReadPrimitive(Stream stream, out float value)
	{
		uint num = ReadVarint32(stream);
		value = *(float*)(&num);
	}

	public unsafe static void WritePrimitive(Stream stream, double value)
	{
		ulong value2 = *(ulong*)(&value);
		WriteVarint64(stream, value2);
	}

	public unsafe static void ReadPrimitive(Stream stream, out double value)
	{
		ulong num = ReadVarint64(stream);
		value = *(double*)(&num);
	}

	public static void WritePrimitive(Stream stream, DateTime value)
	{
		long value2 = value.ToBinary();
		WritePrimitive(stream, value2);
	}

	public static void ReadPrimitive(Stream stream, out DateTime value)
	{
		ReadPrimitive(stream, out long value2);
		value = DateTime.FromBinary(value2);
	}

	public unsafe static void WritePrimitive(Stream stream, string value)
	{
		if (value == null)
		{
			WritePrimitive(stream, 0u);
			return;
		}
		if (value.Length == 0)
		{
			WritePrimitive(stream, 1u);
			return;
		}
		StringHelper stringHelper = s_stringHelper;
		if (stringHelper == null)
		{
			stringHelper = (s_stringHelper = new StringHelper());
		}
		Encoder encoder = stringHelper.Encoder;
		byte[] byteBuffer = stringHelper.ByteBuffer;
		int length = value.Length;
		int byteCount;
		fixed (char* chars = value)
		{
			byteCount = encoder.GetByteCount(chars, length, flush: true);
		}
		WritePrimitive(stream, (uint)(byteCount + 1));
		WritePrimitive(stream, (uint)length);
		int num = 0;
		bool completed = false;
		while (!completed)
		{
			int charsUsed;
			int bytesUsed;
			fixed (char* ptr = value)
			{
				fixed (byte* bytes = byteBuffer)
				{
					encoder.Convert(ptr + num, length - num, bytes, byteBuffer.Length, flush: true, out charsUsed, out bytesUsed, out completed);
				}
			}
			stream.Write(byteBuffer, 0, bytesUsed);
			num += charsUsed;
		}
	}

	public static void ReadPrimitive(Stream stream, out string value)
	{
		ReadPrimitive(stream, out uint value2);
		switch (value2)
		{
		case 0u:
			value = null;
			return;
		case 1u:
			value = string.Empty;
			return;
		}
		value2--;
		ReadPrimitive(stream, out uint value3);
		StringHelper stringHelper = s_stringHelper;
		if (stringHelper == null)
		{
			stringHelper = (s_stringHelper = new StringHelper());
		}
		Decoder decoder = stringHelper.Decoder;
		byte[] byteBuffer = stringHelper.ByteBuffer;
		char[] array = ((value3 > 128) ? new char[value3] : stringHelper.CharBuffer);
		int num = (int)value2;
		int num2 = 0;
		while (num > 0)
		{
			int num3 = stream.Read(byteBuffer, 0, Math.Min(byteBuffer.Length, num));
			if (num3 != 0)
			{
				num -= num3;
				bool flush = ((num == 0) ? true : false);
				bool completed = false;
				int num4 = 0;
				while (!completed)
				{
					decoder.Convert(byteBuffer, num4, num3 - num4, array, num2, (int)value3 - num2, flush, out var bytesUsed, out var charsUsed, out completed);
					num4 += bytesUsed;
					num2 += charsUsed;
				}
				continue;
			}
			throw new EndOfStreamException();
		}
		value = new string(array, 0, (int)value3);
	}

	public static void WritePrimitive(Stream stream, byte[] value)
	{
		if (value == null)
		{
			WritePrimitive(stream, 0u);
			return;
		}
		WritePrimitive(stream, (uint)(value.Length + 1));
		stream.Write(value, 0, value.Length);
	}

	public static void ReadPrimitive(Stream stream, out byte[] value)
	{
		ReadPrimitive(stream, out uint value2);
		switch (value2)
		{
		case 0u:
			value = null;
			return;
		case 1u:
			value = s_emptyByteArray;
			return;
		}
		value2--;
		value = new byte[value2];
		int num = 0;
		while (true)
		{
			if (num < value2)
			{
				int num2 = stream.Read(value, num, (int)value2 - num);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				continue;
			}
			return;
		}
		throw new EndOfStreamException();
	}
}
