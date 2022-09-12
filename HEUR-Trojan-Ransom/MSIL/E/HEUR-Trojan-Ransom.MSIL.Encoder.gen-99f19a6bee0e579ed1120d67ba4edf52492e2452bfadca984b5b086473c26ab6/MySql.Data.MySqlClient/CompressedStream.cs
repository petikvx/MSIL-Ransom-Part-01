using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using MySql.Data.Common;

namespace MySql.Data.MySqlClient;

internal class CompressedStream : Stream
{
	private Stream baseStream;

	private MemoryStream cache;

	private byte[] localByte;

	private byte[] inBuffer;

	private byte[] lengthBytes;

	private WeakReference inBufferRef;

	private int inPos;

	private int maxInPos;

	private DeflateStream compInStream;

	public override bool CanRead => baseStream.CanRead;

	public override bool CanWrite => baseStream.CanWrite;

	public override bool CanSeek => baseStream.CanSeek;

	public override long Length => baseStream.Length;

	public override long Position
	{
		get
		{
			return baseStream.Position;
		}
		set
		{
			baseStream.Position = value;
		}
	}

	public override bool CanTimeout => baseStream.CanTimeout;

	public override int ReadTimeout
	{
		get
		{
			return baseStream.ReadTimeout;
		}
		set
		{
			baseStream.ReadTimeout = value;
		}
	}

	public override int WriteTimeout
	{
		get
		{
			return baseStream.WriteTimeout;
		}
		set
		{
			baseStream.WriteTimeout = value;
		}
	}

	public CompressedStream(Stream baseStream)
	{
		this.baseStream = baseStream;
		localByte = new byte[1];
		lengthBytes = new byte[7];
		cache = new MemoryStream();
		inBufferRef = new WeakReference(inBuffer, trackResurrection: false);
	}

	public override void Close()
	{
		base.Close();
		baseStream.Close();
		cache.Dispose();
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException(Resources.CSNoSetLength);
	}

	public override int ReadByte()
	{
		try
		{
			Read(localByte, 0, 1);
			return localByte[0];
		}
		catch (EndOfStreamException)
		{
			return -1;
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer", Resources.BufferCannotBeNull);
		}
		if (offset >= 0 && offset < buffer.Length)
		{
			if (offset + count > buffer.Length)
			{
				throw new ArgumentException(Resources.BufferNotLargeEnough, "buffer");
			}
			if (inPos == maxInPos)
			{
				PrepareNextPacket();
			}
			int count2 = Math.Min(count, maxInPos - inPos);
			int num = ((compInStream == null) ? baseStream.Read(buffer, offset, count2) : compInStream.Read(buffer, offset, count2));
			inPos += num;
			if (inPos == maxInPos)
			{
				compInStream = null;
				if (!Platform.IsMono())
				{
					inBufferRef = new WeakReference(inBuffer, trackResurrection: false);
					inBuffer = null;
				}
			}
			return num;
		}
		throw new ArgumentOutOfRangeException("offset", Resources.OffsetMustBeValid);
	}

	private void PrepareNextPacket()
	{
		MySqlStream.ReadFully(baseStream, lengthBytes, 0, 7);
		int num = lengthBytes[0] + (lengthBytes[1] << 8) + (lengthBytes[2] << 16);
		int num2 = lengthBytes[4] + (lengthBytes[5] << 8) + (lengthBytes[6] << 16);
		if (num2 == 0)
		{
			num2 = num;
			compInStream = null;
		}
		else
		{
			ReadNextPacket(num);
			MemoryStream stream = new MemoryStream(inBuffer, 2, num - 2);
			compInStream = new DeflateStream(stream, CompressionMode.Decompress);
		}
		inPos = 0;
		maxInPos = num2;
	}

	private void ReadNextPacket(int len)
	{
		inBuffer = inBufferRef.Target as byte[];
		if (inBuffer == null || inBuffer.Length < len)
		{
			inBuffer = new byte[len];
		}
		MySqlStream.ReadFully(baseStream, inBuffer, 0, len);
	}

	private MemoryStream CompressCache()
	{
		if (cache.Length < 50L)
		{
			return null;
		}
		byte[] buffer = cache.GetBuffer();
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.WriteByte(120);
		memoryStream.WriteByte(156);
		DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress, leaveOpen: true);
		deflateStream.Write(buffer, 0, (int)cache.Length);
		deflateStream.Dispose();
		int value = IPAddress.HostToNetworkOrder(Adler32(buffer, 0, (int)cache.Length));
		memoryStream.Write(BitConverter.GetBytes(value), 0, 4);
		if (memoryStream.Length >= cache.Length)
		{
			return null;
		}
		return memoryStream;
	}

	private int Adler32(byte[] bytes, int index, int length)
	{
		uint num = 1u;
		uint num2 = 0u;
		for (int i = index; i < length; i++)
		{
			byte b = bytes[i];
			num = (num + b) % 65521u;
			num2 = (num2 + num) % 65521u;
		}
		return (int)((num2 << 16) + num);
	}

	private void CompressAndSendCache()
	{
		byte[] buffer = cache.GetBuffer();
		byte b = buffer[3];
		buffer[3] = 0;
		MemoryStream memoryStream = CompressCache();
		long length;
		long num;
		MemoryStream memoryStream2;
		if (memoryStream == null)
		{
			length = cache.Length;
			num = 0L;
			memoryStream2 = cache;
		}
		else
		{
			length = memoryStream.Length;
			num = cache.Length;
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
		baseStream.Write(buffer2, 0, num2);
		baseStream.Flush();
		cache.SetLength(0L);
		memoryStream?.Dispose();
	}

	public override void Flush()
	{
		if (InputDone())
		{
			CompressAndSendCache();
		}
	}

	private bool InputDone()
	{
		if (baseStream is TimedStream && ((TimedStream)baseStream).IsClosed)
		{
			return false;
		}
		if (cache.Length < 4L)
		{
			return false;
		}
		byte[] buffer = cache.GetBuffer();
		int num = buffer[0] + (buffer[1] << 8) + (buffer[2] << 16);
		if (cache.Length < num + 4)
		{
			return false;
		}
		return true;
	}

	public override void WriteByte(byte value)
	{
		cache.WriteByte(value);
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		cache.Write(buffer, offset, count);
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		return baseStream.Seek(offset, origin);
	}
}
