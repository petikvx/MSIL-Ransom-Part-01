using System;
using System.IO;
using ns0;
using ns5;

namespace ns4;

internal sealed class Stream6 : Stream
{
	internal enum Enum11
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7
	}

	internal sealed class Class34
	{
		public readonly bool[] bool_0 = new bool[256];

		public readonly byte[] byte_0 = new byte[256];

		public readonly byte[] byte_1 = new byte[Class35.int_8];

		public readonly byte[] byte_2 = new byte[Class35.int_8];

		public readonly int[] int_0;

		public readonly int[][] int_1;

		public readonly int[][] int_2;

		public readonly int[][] int_3;

		public readonly int[] int_4;

		public readonly int[] int_5;

		public readonly byte[] byte_3;

		public readonly char[][] char_0;

		public readonly byte[] byte_4;

		public int[] int_6;

		public byte[] byte_5;

		public Class34(int int_7)
		{
			int_0 = new int[256];
			int_1 = Class35.smethod_0<int>(Class35.int_5, Class35.int_3);
			int_2 = Class35.smethod_0<int>(Class35.int_5, Class35.int_3);
			int_3 = Class35.smethod_0<int>(Class35.int_5, Class35.int_3);
			int_4 = new int[Class35.int_5];
			int_5 = new int[257];
			byte_3 = new byte[256];
			char_0 = Class35.smethod_0<char>(Class35.int_5, Class35.int_3);
			byte_4 = new byte[Class35.int_5];
			byte_5 = new byte[int_7 * Class35.int_0];
		}
	}

	private bool bool_0;

	private bool bool_1;

	private long long_0;

	internal int int_0;

	internal int int_1;

	internal int int_2;

	internal bool bool_2;

	internal int int_3;

	internal int int_4;

	internal readonly GClass3 gclass3_0 = new GClass3(bool_1: true);

	internal int int_5;

	internal Stream stream_0;

	internal int int_6 = -1;

	internal Enum11 enum11_0 = Enum11.const_1;

	internal uint uint_0;

	internal uint uint_1;

	internal uint uint_2;

	internal uint uint_3;

	internal int int_7;

	internal int int_8;

	internal int int_9;

	internal int int_10;

	internal int int_11;

	internal int int_12;

	internal int int_13;

	internal int int_14;

	internal char char_0;

	internal Class34 class34_0;

	bool Stream.CanRead
	{
		get
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("BZip2Stream");
			}
			return stream_0.CanRead;
		}
	}

	bool Stream.CanSeek => false;

	bool Stream.CanWrite
	{
		get
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("BZip2Stream");
			}
			return stream_0.CanWrite;
		}
	}

	long Stream.Length
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	long Stream.Position
	{
		get
		{
			return long_0;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public Stream6(Stream stream_1, bool bool_3)
	{
		stream_0 = stream_1;
		bool_1 = bool_3;
		Class6.smethod_131(this);
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		if (offset < 0)
		{
			throw new IndexOutOfRangeException($"offset ({offset}) must be > 0");
		}
		if (count < 0)
		{
			throw new IndexOutOfRangeException($"count ({count}) must be > 0");
		}
		if (offset + count > buffer.Length)
		{
			throw new IndexOutOfRangeException($"offset({offset}) count({count}) bLength({buffer.Length})");
		}
		if (stream_0 == null)
		{
			throw new IOException("the stream is not open");
		}
		int num = offset + count;
		int num2 = offset;
		int num3;
		while (num2 < num && (num3 = ReadByte()) >= 0)
		{
			buffer[num2++] = (byte)num3;
		}
		if (num2 != offset)
		{
			return num2 - offset;
		}
		return -1;
	}

	int Stream.ReadByte()
	{
		int result = int_6;
		long_0++;
		switch (enum11_0)
		{
		default:
			throw new IOException("bad state");
		case Enum11.const_0:
			return -1;
		case Enum11.const_1:
			throw new IOException("bad state");
		case Enum11.const_2:
			throw new IOException("bad state");
		case Enum11.const_3:
			Class6.smethod_516(this);
			break;
		case Enum11.const_4:
			Class6.smethod_329(this);
			break;
		case Enum11.const_5:
			throw new IOException("bad state");
		case Enum11.const_6:
			Class6.smethod_250(this);
			break;
		case Enum11.const_7:
			Class6.smethod_228(this);
			break;
		}
		return result;
	}

	void Stream.Flush()
	{
		if (bool_0)
		{
			throw new ObjectDisposedException("BZip2Stream");
		}
		stream_0.Flush();
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		throw new NotImplementedException();
	}

	void Stream.SetLength(long value)
	{
		throw new NotImplementedException();
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}

	void Stream.Dispose(bool disposing)
	{
		try
		{
			if (!bool_0)
			{
				if (disposing && stream_0 != null)
				{
					stream_0.Close();
				}
				bool_0 = true;
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	void Stream.Close()
	{
		Stream stream = stream_0;
		if (stream == null)
		{
			return;
		}
		try
		{
			if (!bool_1)
			{
				stream.Close();
			}
		}
		finally
		{
			class34_0 = null;
			stream_0 = null;
		}
	}
}
