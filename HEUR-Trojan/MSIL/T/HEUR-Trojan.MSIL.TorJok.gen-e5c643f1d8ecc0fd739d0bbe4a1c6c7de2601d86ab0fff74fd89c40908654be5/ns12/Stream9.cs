using System;
using System.IO;
using ns11;
using ns15;
using ns5;
using ns8;

namespace ns12;

internal sealed class Stream9 : Stream
{
	internal Stream12 stream12_0;

	internal Stream stream_0;

	internal bool bool_0;

	bool Stream.CanRead
	{
		get
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("DeflateStream");
			}
			return stream12_0.stream_0.CanRead;
		}
	}

	bool Stream.CanSeek => false;

	bool Stream.CanWrite
	{
		get
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("DeflateStream");
			}
			return stream12_0.stream_0.CanWrite;
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
			if (stream12_0.enum24_0 == Stream12.Enum24.const_0)
			{
				return stream12_0.gclass2_0.long_1;
			}
			if (stream12_0.enum24_0 == Stream12.Enum24.const_1)
			{
				return stream12_0.gclass2_0.long_0;
			}
			return 0L;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public Stream9(Stream stream_1, Enum22 enum22_0, bool bool_1)
		: this(stream_1, enum22_0, Enum20.const_8, bool_1)
	{
	}

	public Stream9(Stream stream_1, Enum22 enum22_0, Enum20 enum20_0, bool bool_1)
	{
		stream_0 = stream_1;
		stream12_0 = new Stream12(stream_1, enum22_0, enum20_0, Enum23.const_1, bool_1);
	}

	void Stream.Dispose(bool disposing)
	{
		try
		{
			if (!bool_0)
			{
				if (disposing && stream12_0 != null)
				{
					stream12_0.Close();
				}
				bool_0 = true;
			}
		}
		finally
		{
			base.Dispose(disposing);
		}
	}

	void Stream.Flush()
	{
		if (bool_0)
		{
			throw new ObjectDisposedException("DeflateStream");
		}
		stream12_0.Flush();
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		if (bool_0)
		{
			throw new ObjectDisposedException("DeflateStream");
		}
		return stream12_0.Read(buffer, offset, count);
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
		if (bool_0)
		{
			throw new ObjectDisposedException("DeflateStream");
		}
		stream12_0.Write(buffer, offset, count);
	}
}
