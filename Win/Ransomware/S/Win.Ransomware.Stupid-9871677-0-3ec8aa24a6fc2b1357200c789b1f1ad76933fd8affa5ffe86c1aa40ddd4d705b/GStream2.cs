using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Ionic.Zlib;

public class GStream2 : Stream
{
	[Flags]
	private enum Enum3 : uint
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

	private static readonly int int_1 = 4;

	private List<Class16> list_0;

	private bool bool_0;

	private bool bool_1;

	private Stream stream_0;

	private int int_2;

	private int int_3 = int_0;

	private AutoResetEvent autoResetEvent_0;

	private object object_0 = new object();

	private bool bool_2;

	private bool bool_3;

	private int int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private int int_8;

	private GClass12 gclass12_0;

	private object object_1 = new object();

	private Queue<int> queue_0;

	private Queue<int> queue_1;

	private long long_0;

	private CompressionLevel compressionLevel_0;

	private volatile Exception exception_0;

	private bool bool_4;

	private object object_2 = new object();

	private Enum3 enum3_0 = Enum3.flag_7 | Enum3.flag_3 | Enum3.flag_10 | Enum3.flag_13 | Enum3.flag_15 | Enum3.flag_16;

	[CompilerGenerated]
	private CompressionStrategy compressionStrategy_0;

	public CompressionStrategy CompressionStrategy_0
	{
		[CompilerGenerated]
		get
		{
			return compressionStrategy_0;
		}
		[CompilerGenerated]
		private set
		{
			compressionStrategy_0 = value;
		}
	}

	public int Int32_0
	{
		get
		{
			return int_2;
		}
		set
		{
			if (value < 4)
			{
				throw new ArgumentException("MaxBufferPairs", "Value must be 4 or greater.");
			}
			int_2 = value;
		}
	}

	public int Int32_1
	{
		get
		{
			return int_3;
		}
		set
		{
			if (value < 1024)
			{
				throw new ArgumentOutOfRangeException("BufferSize", "BufferSize must be greater than 1024 bytes");
			}
			int_3 = value;
		}
	}

	public int Int32_2 => int_8;

	public long Int64_0 => long_0;

	public override bool CanSeek => false;

	public override bool CanRead => false;

	public override bool CanWrite => stream_0.CanWrite;

	public override long Length
	{
		get
		{
			throw new NotSupportedException();
		}
	}

	public override long Position
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

	public GStream2(Stream stream)
		: this(stream, CompressionLevel.Default, CompressionStrategy.Default, leaveOpen: false)
	{
	}

	public GStream2(Stream stream, CompressionLevel level)
		: this(stream, level, CompressionStrategy.Default, leaveOpen: false)
	{
	}

	public GStream2(Stream stream, bool leaveOpen)
		: this(stream, CompressionLevel.Default, CompressionStrategy.Default, leaveOpen)
	{
	}

	public GStream2(Stream stream, CompressionLevel level, bool leaveOpen)
		: this(stream, CompressionLevel.Default, CompressionStrategy.Default, leaveOpen)
	{
	}

	public GStream2(Stream stream, CompressionLevel level, CompressionStrategy strategy, bool leaveOpen)
	{
		stream_0 = stream;
		compressionLevel_0 = level;
		CompressionStrategy_0 = strategy;
		bool_0 = leaveOpen;
		Int32_0 = 16;
	}

	private void method_0()
	{
		queue_0 = new Queue<int>();
		queue_1 = new Queue<int>();
		list_0 = new List<Class16>();
		int val = int_1 * Environment.ProcessorCount;
		val = Math.Min(val, int_2);
		for (int i = 0; i < val; i++)
		{
			list_0.Add(new Class16(int_3, compressionLevel_0, CompressionStrategy_0, i));
			queue_1.Enqueue(i);
		}
		autoResetEvent_0 = new AutoResetEvent(initialState: false);
		gclass12_0 = new GClass12();
		int_4 = -1;
		int_5 = -1;
		int_6 = -1;
		int_7 = -1;
	}

	public override void Write(byte[] buffer, int offset, int count)
	{
		bool bool_ = false;
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
			method_0();
			bool_3 = true;
		}
		while (true)
		{
			method_5(bool_5: false, bool_);
			bool_ = false;
			int num = -1;
			if (int_4 < 0)
			{
				if (queue_1.Count == 0)
				{
					bool_ = true;
					goto IL_0120;
				}
				num = queue_1.Dequeue();
				int_5++;
			}
			else
			{
				num = int_4;
			}
			Class16 @class = list_0[num];
			int num2 = ((@class.byte_0.Length - @class.int_3 > count) ? count : (@class.byte_0.Length - @class.int_3));
			@class.int_2 = int_5;
			Buffer.BlockCopy(buffer, offset, @class.byte_0, @class.int_3, num2);
			count -= num2;
			offset += num2;
			@class.int_3 += num2;
			if (@class.int_3 == @class.byte_0.Length)
			{
				if (!ThreadPool.QueueUserWorkItem(method_6, @class))
				{
					break;
				}
				int_4 = -1;
			}
			else
			{
				int_4 = num;
			}
			goto IL_0120;
			IL_0120:
			if (count <= 0)
			{
				return;
			}
		}
		throw new Exception("Cannot enqueue workitem");
	}

	private void method_1()
	{
		byte[] array = new byte[128];
		GClass5 gClass = new GClass5();
		int num = gClass.method_9(compressionLevel_0, bool_0: false);
		gClass.byte_0 = null;
		gClass.int_0 = 0;
		gClass.int_1 = 0;
		gClass.byte_1 = array;
		gClass.int_2 = 0;
		gClass.int_3 = array.Length;
		num = gClass.method_13(FlushType.Finish);
		if (num != 1 && num != 0)
		{
			throw new Exception("deflating: " + gClass.string_0);
		}
		if (array.Length - gClass.int_3 > 0)
		{
			stream_0.Write(array, 0, array.Length - gClass.int_3);
		}
		gClass.method_14();
		int_8 = gclass12_0.Int32_0;
	}

	private void method_2(bool bool_5)
	{
		if (bool_2)
		{
			throw new InvalidOperationException();
		}
		if (!bool_1)
		{
			if (int_4 >= 0)
			{
				Class16 object_ = list_0[int_4];
				method_6(object_);
				int_4 = -1;
			}
			if (bool_5)
			{
				method_5(bool_5: true, bool_6: false);
				method_1();
			}
			else
			{
				method_5(bool_5: false, bool_6: false);
			}
		}
	}

	public override void Flush()
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
			method_2(bool_5: false);
		}
	}

	public override void Close()
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
			method_2(bool_5: true);
			if (!bool_0)
			{
				stream_0.Close();
			}
			bool_2 = true;
		}
	}

	public void method_3()
	{
		Close();
		list_0 = null;
		Dispose(disposing: true);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	public void method_4(Stream stream_1)
	{
		if (!bool_3)
		{
			return;
		}
		queue_0.Clear();
		queue_1.Clear();
		foreach (Class16 item in list_0)
		{
			queue_1.Enqueue(item.int_1);
			item.int_2 = -1;
		}
		bool_3 = false;
		long_0 = 0L;
		gclass12_0 = new GClass12();
		bool_2 = false;
		int_4 = -1;
		int_5 = -1;
		int_6 = -1;
		int_7 = -1;
		stream_0 = stream_1;
	}

	private void method_5(bool bool_5, bool bool_6)
	{
		if (bool_1)
		{
			return;
		}
		bool_1 = true;
		if (bool_5 || bool_6)
		{
			autoResetEvent_0.WaitOne();
		}
		do
		{
			int num = -1;
			int num2 = (bool_5 ? 200 : (bool_6 ? (-1) : 0));
			int num3 = -1;
			do
			{
				if (!Monitor.TryEnter(queue_0, num2))
				{
					num3 = -1;
					continue;
				}
				num3 = -1;
				try
				{
					if (queue_0.Count > 0)
					{
						num3 = queue_0.Dequeue();
					}
				}
				finally
				{
					Monitor.Exit(queue_0);
				}
				if (num3 < 0)
				{
					continue;
				}
				Class16 @class = list_0[num3];
				if (@class.int_2 != int_6 + 1)
				{
					lock (queue_0)
					{
						queue_0.Enqueue(num3);
					}
					if (num == num3)
					{
						autoResetEvent_0.WaitOne();
						num = -1;
					}
					else if (num == -1)
					{
						num = num3;
					}
					continue;
				}
				num = -1;
				stream_0.Write(@class.byte_1, 0, @class.int_4);
				gclass12_0.method_10(@class.int_0, @class.int_3);
				long_0 += @class.int_3;
				@class.int_3 = 0;
				int_6 = @class.int_2;
				queue_1.Enqueue(@class.int_1);
				if (num2 == -1)
				{
					num2 = 0;
				}
			}
			while (num3 >= 0);
		}
		while (bool_5 && int_6 != int_7);
		bool_1 = false;
	}

	private void method_6(object object_3)
	{
		Class16 @class = (Class16)object_3;
		try
		{
			GClass12 gClass = new GClass12();
			gClass.method_4(@class.byte_0, 0, @class.int_3);
			method_7(@class);
			@class.int_0 = gClass.Int32_0;
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

	private bool method_7(Class16 class16_0)
	{
		GClass5 gclass5_ = class16_0.gclass5_0;
		gclass5_.method_15();
		gclass5_.int_0 = 0;
		gclass5_.int_1 = class16_0.int_3;
		gclass5_.int_2 = 0;
		gclass5_.int_3 = class16_0.byte_1.Length;
		do
		{
			gclass5_.method_13(FlushType.None);
		}
		while (gclass5_.int_1 > 0 || gclass5_.int_3 == 0);
		gclass5_.method_13(FlushType.Sync);
		class16_0.int_4 = (int)gclass5_.long_1;
		return true;
	}

	[Conditional("Trace")]
	private void method_8(Enum3 enum3_1, string string_0, params object[] object_3)
	{
		if ((enum3_1 & enum3_0) != 0)
		{
			lock (object_0)
			{
				int hashCode = Thread.CurrentThread.GetHashCode();
				Console.ForegroundColor = (ConsoleColor)(hashCode % 8 + 8);
				Console.Write("{0:000} PDOS ", hashCode);
				Console.WriteLine(string_0, object_3);
				Console.ResetColor();
			}
		}
	}

	public override int Read(byte[] buffer, int offset, int count)
	{
		throw new NotSupportedException();
	}

	public override long Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException();
	}

	public override void SetLength(long value)
	{
		throw new NotSupportedException();
	}
}
