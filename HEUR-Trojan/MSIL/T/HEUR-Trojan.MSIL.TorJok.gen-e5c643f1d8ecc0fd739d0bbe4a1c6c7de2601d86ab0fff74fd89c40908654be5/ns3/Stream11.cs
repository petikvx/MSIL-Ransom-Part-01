using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using ns0;
using ns11;
using ns14;
using ns5;

namespace ns3;

internal sealed class Stream11 : Stream
{
	[Flags]
	private enum Enum18 : uint
	{
		flag_0 = 0u,
		flag_1 = 1u,
		flag_2 = 2u,
		flag_3 = 4u,
		flag_4 = 8u,
		flag_5 = 0x10u,
		flag_6 = 0x20u,
		flag_7 = 0x3Au,
		flag_8 = 0x40u,
		flag_9 = 0x80u,
		flag_10 = 0x100u,
		flag_11 = 0x200u,
		flag_12 = 0x400u,
		flag_13 = 0x800u,
		flag_14 = 0x1000u,
		flag_15 = 0x2000u,
		flag_16 = 0x4000u,
		flag_17 = uint.MaxValue
	}

	private static readonly int int_0 = 65536;

	internal static readonly int int_1 = 4;

	internal List<Class45> list_0;

	private bool bool_0;

	internal bool bool_1;

	internal Stream stream_0;

	internal int int_2;

	internal int int_3 = int_0;

	internal AutoResetEvent autoResetEvent_0;

	private object object_0 = new object();

	internal bool bool_2;

	private bool bool_3;

	internal int int_4;

	internal int int_5;

	internal int int_6;

	internal int int_7;

	internal int int_8;

	internal GClass3 gclass3_0;

	private object object_1 = new object();

	internal Queue<int> queue_0;

	internal Queue<int> queue_1;

	internal long long_0;

	internal Enum20 enum20_0;

	private volatile Exception exception_0;

	private bool bool_4;

	private object object_2 = new object();

	private Enum18 enum18_0 = Enum18.flag_7 | Enum18.flag_3 | Enum18.flag_10 | Enum18.flag_13 | Enum18.flag_15 | Enum18.flag_16;

	[CompilerGenerated]
	private Enum21 enum21_0;

	bool Stream.CanSeek => false;

	bool Stream.CanRead => false;

	bool Stream.CanWrite => stream_0.CanWrite;

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

	public Stream11(Stream stream_1, Enum20 enum20_1, Enum21 enum21_1, bool bool_5)
	{
		stream_0 = stream_1;
		enum20_0 = enum20_1;
		method_1(enum21_1);
		bool_0 = bool_5;
		Class6.smethod_278(16, this);
	}

	[SpecialName]
	[CompilerGenerated]
	public Enum21 method_0()
	{
		return enum21_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(Enum21 enum21_1)
	{
		enum21_0 = enum21_1;
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		bool flag = false;
		if (bool_2)
		{
			throw new InvalidOperationException();
		}
		if (exception_0 != null)
		{
			bool_4 = true;
			Exception ex = exception_0;
			exception_0 = null;
			throw ex;
		}
		if (count == 0)
		{
			return;
		}
		if (!bool_3)
		{
			Class6.smethod_525(this);
			bool_3 = true;
		}
		while (true)
		{
			Class6.smethod_632(this, bool_0: false, flag);
			flag = false;
			int num = -1;
			if (int_4 < 0)
			{
				if (queue_1.Count == 0)
				{
					flag = true;
					goto IL_0127;
				}
				num = queue_1.Dequeue();
				int_5++;
			}
			else
			{
				num = int_4;
			}
			Class45 @class = list_0[num];
			int num2 = ((@class.byte_0.Length - @class.int_3 > count) ? count : (@class.byte_0.Length - @class.int_3));
			@class.int_2 = int_5;
			Buffer.BlockCopy(buffer, offset, @class.byte_0, @class.int_3, num2);
			count -= num2;
			offset += num2;
			@class.int_3 += num2;
			if (@class.int_3 == @class.byte_0.Length)
			{
				if (!ThreadPool.QueueUserWorkItem(method_4, @class))
				{
					break;
				}
				int_4 = -1;
			}
			else
			{
				int_4 = num;
			}
			goto IL_0127;
			IL_0127:
			if (count <= 0)
			{
				return;
			}
		}
		throw new Exception("Cannot enqueue workitem");
	}

	void Stream.Flush()
	{
		if (exception_0 != null)
		{
			bool_4 = true;
			Exception ex = exception_0;
			exception_0 = null;
			throw ex;
		}
		if (!bool_4)
		{
			Class6.smethod_259(this, bool_0: false);
		}
	}

	void Stream.Close()
	{
		if (exception_0 != null)
		{
			bool_4 = true;
			Exception ex = exception_0;
			exception_0 = null;
			throw ex;
		}
		if (!bool_4 && !bool_2)
		{
			Class6.smethod_259(this, bool_0: true);
			if (!bool_0)
			{
				stream_0.Close();
			}
			bool_2 = true;
		}
	}

	public void method_2()
	{
		Close();
		list_0 = null;
		Dispose(disposing: true);
	}

	void Stream.Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	public void method_3(Stream stream_1)
	{
		if (!bool_3)
		{
			return;
		}
		queue_0.Clear();
		queue_1.Clear();
		foreach (Class45 item in list_0)
		{
			queue_1.Enqueue(item.int_1);
			item.int_2 = -1;
		}
		bool_3 = false;
		long_0 = 0L;
		gclass3_0 = new GClass3();
		bool_2 = false;
		int_4 = -1;
		int_5 = -1;
		int_6 = -1;
		int_7 = -1;
		stream_0 = stream_1;
	}

	internal void method_4(object object_3)
	{
		Class45 @class = (Class45)object_3;
		try
		{
			GClass3 gClass = new GClass3();
			Class6.smethod_23(gClass, @class.byte_0, 0, @class.int_3);
			Class6.smethod_620(@class, this);
			@class.int_0 = (int)(~gClass.uint_2);
			lock (object_1)
			{
				if (@class.int_2 > int_7)
				{
					int_7 = @class.int_2;
				}
			}
			lock (queue_0)
			{
				queue_0.Enqueue(@class.int_1);
			}
			autoResetEvent_0.Set();
		}
		catch (Exception ex)
		{
			lock (object_2)
			{
				if (exception_0 != null)
				{
					exception_0 = ex;
				}
			}
		}
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	void Stream.SetLength(long value)
	{
		throw new NotSupportedException();
	}
}
