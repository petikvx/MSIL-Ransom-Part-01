using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using ns1;
using ns4;
using ns5;
using ns6;

namespace ns9;

internal sealed class Stream8 : Stream
{
	[Flags]
	private enum Enum13 : uint
	{
		flag_0 = 0u,
		flag_1 = 1u,
		flag_2 = 2u,
		flag_3 = uint.MaxValue
	}

	internal static readonly int int_0 = 4;

	internal int int_1;

	private bool bool_0;

	internal int int_2;

	internal int int_3;

	internal int int_4;

	internal int int_5;

	private volatile Exception exception_0;

	private bool bool_1;

	internal bool bool_2;

	internal Queue<int> queue_0;

	internal Queue<int> queue_1;

	internal List<Class36> list_0;

	private object object_0 = new object();

	private object object_1 = new object();

	private object object_2 = new object();

	internal AutoResetEvent autoResetEvent_0;

	private long long_0;

	internal long long_1;

	private bool bool_3;

	internal uint uint_0;

	internal Stream stream_0;

	internal Class31 class31_0;

	internal int int_6;

	private Enum13 enum13_0 = Enum13.flag_1 | Enum13.flag_2;

	bool Stream.CanRead => false;

	bool Stream.CanSeek => false;

	bool Stream.CanWrite
	{
		get
		{
			if (stream_0 == null)
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

	public Stream8(Stream stream_1, bool bool_4)
		: this(stream_1, Class35.int_2, bool_4)
	{
	}

	public Stream8(Stream stream_1, int int_7, bool bool_4)
	{
		if (int_7 >= Class35.int_1 && int_7 <= Class35.int_2)
		{
			stream_0 = stream_1;
			if (!stream_0.CanWrite)
			{
				throw new ArgumentException("The stream is not writable.", "output");
			}
			class31_0 = new Class31(stream_0);
			int_6 = int_7;
			bool_3 = bool_4;
			uint_0 = 0u;
			Class6.smethod_322(this, 16);
			Class6.smethod_183(this);
			return;
		}
		string message = $"blockSize={int_7} is out of range; must be between {Class35.int_1} and {Class35.int_2}";
		throw new ArgumentException(message, "blockSize");
	}

	void Stream.Close()
	{
		if (exception_0 != null)
		{
			bool_1 = true;
			Exception ex = exception_0;
			exception_0 = null;
			throw ex;
		}
		if (!bool_1 && stream_0 != null)
		{
			Stream stream = stream_0;
			try
			{
				Class6.smethod_105(bool_0: true, this);
			}
			finally
			{
				stream_0 = null;
				class31_0 = null;
			}
			if (!bool_3)
			{
				stream.Close();
			}
		}
	}

	void Stream.Flush()
	{
		if (stream_0 != null)
		{
			Class6.smethod_105(bool_0: false, this);
			Class6.smethod_304(class31_0);
			stream_0.Flush();
		}
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		bool flag = false;
		if (stream_0 == null)
		{
			throw new IOException("the stream is not open");
		}
		if (exception_0 != null)
		{
			bool_1 = true;
			Exception ex = exception_0;
			exception_0 = null;
			throw ex;
		}
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
		if (count == 0)
		{
			return;
		}
		if (!bool_0)
		{
			Class6.smethod_69(this);
			bool_0 = true;
		}
		int num = 0;
		int num2 = count;
		do
		{
			Class6.smethod_96(this, bool_0: false, flag);
			flag = false;
			int num3 = -1;
			if (int_5 < 0)
			{
				if (queue_1.Count == 0)
				{
					flag = true;
					continue;
				}
				num3 = queue_1.Dequeue();
				int_2++;
			}
			else
			{
				num3 = int_5;
			}
			Class36 @class = list_0[num3];
			@class.int_1 = int_2;
			int num4 = Class6.smethod_166(@class.method_0(), buffer, offset, num2);
			if (num4 != num2)
			{
				if (!ThreadPool.QueueUserWorkItem(method_0, @class))
				{
					throw new Exception("Cannot enqueue workitem");
				}
				int_5 = -1;
				offset += num4;
			}
			else
			{
				int_5 = num3;
			}
			num2 -= num4;
			num += num4;
		}
		while (num2 > 0);
		long_0 += num;
	}

	internal void method_0(object object_3)
	{
		Class36 @class = (Class36)object_3;
		try
		{
			Class6.smethod_162(@class.method_0());
			lock (object_0)
			{
				if (@class.int_1 > int_4)
				{
					int_4 = @class.int_1;
				}
			}
			lock (queue_0)
			{
				queue_0.Enqueue(@class.int_0);
			}
			autoResetEvent_0.Set();
		}
		catch (Exception ex)
		{
			lock (object_1)
			{
				if (exception_0 != null)
				{
					exception_0 = ex;
				}
			}
		}
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		throw new NotImplementedException();
	}

	void Stream.SetLength(long value)
	{
		throw new NotImplementedException();
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		throw new NotImplementedException();
	}
}
