using System;
using System.IO;
using System.Text;
using ns5;

namespace ns9;

internal sealed class Stream10 : Stream
{
	public DateTime? nullable_0;

	private int int_0;

	internal Stream12 stream12_0;

	internal bool bool_0;

	private bool bool_1;

	internal string string_0;

	internal string string_1;

	private int int_1;

	internal static readonly DateTime dateTime_0 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	internal static readonly Encoding encoding_0 = Encoding.GetEncoding("iso-8859-1");

	bool Stream.CanRead
	{
		get
		{
			if (bool_0)
			{
				throw new ObjectDisposedException("GZipStream");
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
				throw new ObjectDisposedException("GZipStream");
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
				return stream12_0.gclass2_0.long_1 + int_0;
			}
			if (stream12_0.enum24_0 == Stream12.Enum24.const_1)
			{
				return stream12_0.gclass2_0.long_0 + stream12_0.int_1;
			}
			return 0L;
		}
		set
		{
			throw new NotImplementedException();
		}
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
					int_1 = Class6.smethod_68(stream12_0);
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
			throw new ObjectDisposedException("GZipStream");
		}
		stream12_0.Flush();
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		if (bool_0)
		{
			throw new ObjectDisposedException("GZipStream");
		}
		int result = stream12_0.Read(buffer, offset, count);
		if (!bool_1)
		{
			bool_1 = true;
			Class6.smethod_604(stream12_0.string_0, this);
			Class6.smethod_21(this, stream12_0.string_1);
		}
		return result;
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
			throw new ObjectDisposedException("GZipStream");
		}
		if (stream12_0.enum24_0 == Stream12.Enum24.const_2)
		{
			if (stream12_0.enum22_0 != 0)
			{
				throw new InvalidOperationException();
			}
			int_0 = Class6.smethod_193(this);
		}
		stream12_0.Write(buffer, offset, count);
	}
}
