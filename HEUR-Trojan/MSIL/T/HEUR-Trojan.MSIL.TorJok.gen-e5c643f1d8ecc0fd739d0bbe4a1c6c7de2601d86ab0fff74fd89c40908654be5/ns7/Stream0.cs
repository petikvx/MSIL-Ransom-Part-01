using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using ns0;
using ns1;
using ns3;
using ns5;
using ns6;

namespace ns7;

internal sealed class Stream0 : Stream
{
	internal string string_0;

	internal string string_1;

	internal Stream stream_0;

	internal GClass0 gclass0_0;

	internal Enum8 enum8_0;

	internal Dictionary<string, GClass0> dictionary_0;

	internal int int_0;

	internal Enum9 enum9_0;

	internal Encoding encoding_0;

	private bool bool_0;

	private bool bool_1;

	internal bool bool_2;

	internal bool bool_3;

	private bool bool_4;

	internal Stream4 stream4_0;

	internal Stream stream_1;

	internal Stream stream_2;

	internal Stream13 stream13_0;

	internal bool bool_5;

	private string string_2;

	internal Stream11 stream11_0;

	internal long long_0;

	internal int int_1;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private Enum21 enum21_0;

	bool Stream.CanRead => false;

	bool Stream.CanSeek => false;

	bool Stream.CanWrite => true;

	long Stream.Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	long Stream.Position
	{
		get
		{
			return stream_0.Position;
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	string object.ToString()
	{
		return $"ZipOutputStream::{string_2}(leaveOpen({bool_0})))";
	}

	[SpecialName]
	[CompilerGenerated]
	public int method_0()
	{
		return int_2;
	}

	[SpecialName]
	[CompilerGenerated]
	public Enum21 method_1()
	{
		return enum21_0;
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		if (bool_1)
		{
			bool_2 = true;
			throw new InvalidOperationException("The stream has been closed.");
		}
		if (buffer == null)
		{
			bool_2 = true;
			throw new ArgumentNullException("buffer");
		}
		if (gclass0_0 == null)
		{
			bool_2 = true;
			throw new InvalidOperationException("You must call PutNextEntry() before calling Write().");
		}
		if (gclass0_0.bool_4)
		{
			bool_2 = true;
			throw new InvalidOperationException("You cannot Write() data for an entry that is a directory.");
		}
		if (bool_5)
		{
			Class6.smethod_502(this, bool_0: false);
		}
		if (count != 0)
		{
			stream13_0.Write(buffer, offset, count);
		}
	}

	void Stream.Dispose(bool disposing)
	{
		if (bool_1)
		{
			return;
		}
		if (disposing && !bool_2)
		{
			Class6.smethod_382(this);
			Stream stream = stream_0;
			ICollection<GClass0> values = dictionary_0.Values;
			Enum8 @enum = enum8_0;
			string text = string_1;
			Class8 class8_ = new Class8(this);
			bool_4 = Class6.smethod_429(@enum, values, 1u, class8_, stream, text);
			Stream stream2 = null;
			if (stream_0 is Stream4 stream3)
			{
				stream2 = stream3.stream_0;
				stream3.Dispose();
			}
			else
			{
				stream2 = stream_0;
			}
			if (!bool_0)
			{
				stream2.Dispose();
			}
			stream_0 = null;
		}
		bool_1 = true;
	}

	void Stream.Flush()
	{
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException("Read");
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException("Seek");
	}

	void Stream.SetLength(long value)
	{
		throw new NotSupportedException();
	}
}
