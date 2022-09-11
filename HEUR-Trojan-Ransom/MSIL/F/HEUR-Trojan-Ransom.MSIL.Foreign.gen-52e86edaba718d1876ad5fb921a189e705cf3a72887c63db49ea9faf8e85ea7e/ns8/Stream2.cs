using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns18;
using ns19;
using ns21;
using ns24;

namespace ns8;

internal sealed class Stream2 : Stream
{
	private Stream stream_0;

	private MemoryStream memoryStream_0;

	private byte[] byte_0;

	private byte[] byte_1;

	private byte[] byte_2;

	private WeakReference weakReference_0;

	private int int_0;

	private int int_1;

	private DeflateStream deflateStream_0;

	[NonSerialized]
	internal static GetString getString_0;

	bool Stream.CanRead => stream_0.CanRead;

	bool Stream.CanWrite => stream_0.CanWrite;

	bool Stream.CanSeek => stream_0.CanSeek;

	long Stream.Length => stream_0.Length;

	long Stream.Position
	{
		get
		{
			return stream_0.Position;
		}
		set
		{
			stream_0.Position = value;
		}
	}

	bool Stream.CanTimeout => stream_0.CanTimeout;

	int Stream.ReadTimeout
	{
		get
		{
			return stream_0.ReadTimeout;
		}
		set
		{
			stream_0.ReadTimeout = value;
		}
	}

	int Stream.WriteTimeout
	{
		get
		{
			return stream_0.WriteTimeout;
		}
		set
		{
			stream_0.WriteTimeout = value;
		}
	}

	public Stream2(Stream stream_1)
	{
		stream_0 = stream_1;
		byte_0 = new byte[1];
		byte_2 = new byte[7];
		memoryStream_0 = new MemoryStream();
		weakReference_0 = new WeakReference(byte_1, trackResurrection: false);
	}

	void Stream.Close()
	{
		base.Close();
		stream_0.Close();
		memoryStream_0.Dispose();
	}

	void Stream.SetLength(long value)
	{
		throw new NotSupportedException(Class121.CSNoSetLength);
	}

	int Stream.ReadByte()
	{
		try
		{
			Read(byte_0, 0, 1);
			return byte_0[0];
		}
		catch (EndOfStreamException)
		{
			return -1;
		}
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException(getString_0(107354192), Class121.BufferCannotBeNull);
		}
		if (offset >= 0 && offset < buffer.Length)
		{
			if (offset + count > buffer.Length)
			{
				throw new ArgumentException(Class121.BufferNotLargeEnough, getString_0(107354192));
			}
			if (int_0 == int_1)
			{
				method_0();
			}
			int count2 = Math.Min(count, int_1 - int_0);
			int num = ((deflateStream_0 == null) ? stream_0.Read(buffer, offset, count2) : deflateStream_0.Read(buffer, offset, count2));
			int_0 += num;
			if (int_0 == int_1)
			{
				deflateStream_0 = null;
				if (!Class131.smethod_1())
				{
					weakReference_0 = new WeakReference(byte_1, trackResurrection: false);
					byte_1 = null;
				}
			}
			return num;
		}
		throw new ArgumentOutOfRangeException(getString_0(107354183), Class121.OffsetMustBeValid);
	}

	private void method_0()
	{
		Class168.smethod_0(stream_0, byte_2, 0, 7);
		int num = byte_2[0] + (byte_2[1] << 8) + (byte_2[2] << 16);
		int num2 = byte_2[4] + (byte_2[5] << 8) + (byte_2[6] << 16);
		if (num2 == 0)
		{
			num2 = num;
			deflateStream_0 = null;
		}
		else
		{
			method_1(num);
			MemoryStream stream = new MemoryStream(byte_1, 2, num - 2);
			deflateStream_0 = new DeflateStream(stream, CompressionMode.Decompress);
		}
		int_0 = 0;
		int_1 = num2;
	}

	private void method_1(int int_2)
	{
		byte_1 = weakReference_0.Target as byte[];
		if (byte_1 == null || byte_1.Length < int_2)
		{
			byte_1 = new byte[int_2];
		}
		Class168.smethod_0(stream_0, byte_1, 0, int_2);
	}

	private MemoryStream method_2()
	{
		if (memoryStream_0.Length < 50L)
		{
			return null;
		}
		byte[] buffer = memoryStream_0.GetBuffer();
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.WriteByte(120);
		memoryStream.WriteByte(156);
		DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
		deflateStream.Write(buffer, 0, (int)memoryStream_0.Length);
		deflateStream.Dispose();
		int value = IPAddress.HostToNetworkOrder(method_3(buffer, 0, (int)memoryStream_0.Length));
		memoryStream.Write(BitConverter.GetBytes(value), 0, 4);
		if (memoryStream.Length >= memoryStream_0.Length)
		{
			return null;
		}
		return memoryStream;
	}

	private int method_3(byte[] byte_3, int int_2, int int_3)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = int_2; i < int_3; i++)
		{
			byte b = byte_3[i];
			num = (num + b) % 65521u;
			num2 = (num2 + num) % 65521u;
		}
		return (int)((num2 << 16) + num);
	}

	private void method_4()
	{
		byte[] buffer = memoryStream_0.GetBuffer();
		byte b = buffer[3];
		buffer[3] = 0;
		MemoryStream memoryStream = method_2();
		long length;
		long num;
		MemoryStream memoryStream2;
		if (memoryStream == null)
		{
			length = memoryStream_0.Length;
			num = 0L;
			memoryStream2 = memoryStream_0;
		}
		else
		{
			length = memoryStream.Length;
			num = memoryStream_0.Length;
			memoryStream2 = memoryStream;
		}
		long length2 = memoryStream2.Length;
		int num2 = (int)length2 + 7;
		memoryStream2.SetLength(num2);
		byte[] buffer2 = memoryStream2.GetBuffer();
		Array.Copy(buffer2, 0, buffer2, 7, (int)length2);
		buffer2[0] = (byte)((ulong)length & 0xFFuL);
		buffer2[1] = (byte)((ulong)(length >> 8) & 0xFFuL);
		buffer2[2] = (byte)((ulong)(length >> 16) & 0xFFuL);
		buffer2[3] = b;
		buffer2[4] = (byte)((ulong)num & 0xFFuL);
		buffer2[5] = (byte)((ulong)(num >> 8) & 0xFFuL);
		buffer2[6] = (byte)((ulong)(num >> 16) & 0xFFuL);
		stream_0.Write(buffer2, 0, num2);
		stream_0.Flush();
		memoryStream_0.SetLength(0L);
		memoryStream?.Dispose();
	}

	void Stream.Flush()
	{
		if (method_5())
		{
			method_4();
		}
	}

	private bool method_5()
	{
		if (stream_0 is Stream3 && ((Stream3)stream_0).IsClosed)
		{
			return false;
		}
		if (memoryStream_0.Length < 4L)
		{
			return false;
		}
		byte[] buffer = memoryStream_0.GetBuffer();
		int num = buffer[0] + (buffer[1] << 8) + (buffer[2] << 16);
		if (memoryStream_0.Length < num + 4)
		{
			return false;
		}
		return true;
	}

	void Stream.WriteByte(byte value)
	{
		memoryStream_0.WriteByte(value);
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		memoryStream_0.Write(buffer, offset, count);
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		return stream_0.Seek(offset, origin);
	}

	static Stream2()
	{
		Strings.CreateGetStringDelegate(typeof(Stream2));
	}
}
