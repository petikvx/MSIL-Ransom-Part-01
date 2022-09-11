using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns0;
using ns11;

namespace ns26;

internal sealed class Stream1 : Stream
{
	private string string_0;

	private EventWaitHandle eventWaitHandle_0;

	private EventWaitHandle eventWaitHandle_1;

	private EventWaitHandle eventWaitHandle_2;

	private EventWaitHandle eventWaitHandle_3;

	private EventWaitHandle eventWaitHandle_4;

	private Class130 class130_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3 = -1;

	private int int_4 = -1;

	[NonSerialized]
	internal static GetString getString_0;

	bool Stream.CanRead => true;

	bool Stream.CanSeek => false;

	bool Stream.CanWrite => true;

	long Stream.Length
	{
		get
		{
			throw new NotSupportedException(getString_0(107357455));
		}
	}

	long Stream.Position
	{
		get
		{
			throw new NotSupportedException(getString_0(107357350));
		}
		set
		{
		}
	}

	bool Stream.CanTimeout => true;

	int Stream.ReadTimeout
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
		}
	}

	int Stream.WriteTimeout
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
		}
	}

	public Stream1(string string_1)
	{
		string_0 = string_1;
	}

	public void method_0(uint uint_0)
	{
		method_1(uint_0);
		method_2();
	}

	void Stream.Close()
	{
		if (eventWaitHandle_4 == null)
		{
			return;
		}
		if (!eventWaitHandle_4.WaitOne(0))
		{
			eventWaitHandle_4.Set();
			eventWaitHandle_4.Close();
		}
		eventWaitHandle_4 = null;
		EventWaitHandle[] array = new EventWaitHandle[4] { eventWaitHandle_0, eventWaitHandle_1, eventWaitHandle_2, eventWaitHandle_3 };
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] != null)
			{
				array[i].Close();
			}
		}
		if (class130_0 != null)
		{
			class130_0.System_002EIDisposable_002EDispose();
			class130_0 = null;
		}
	}

	private void method_1(uint uint_0)
	{
		EventWaitHandle eventWaitHandle;
		try
		{
			eventWaitHandle = EventWaitHandle.OpenExisting(string_0 + getString_0(107357191));
		}
		catch (Exception)
		{
			string text = getString_0(107357198) + string_0;
			eventWaitHandle = EventWaitHandle.OpenExisting(text + getString_0(107357191));
			string_0 = text;
		}
		EventWaitHandle eventWaitHandle2 = EventWaitHandle.OpenExisting(string_0 + getString_0(107357153));
		using Class130 @class = new Class130(string_0 + getString_0(107357164), (IntPtr)4);
		if (!eventWaitHandle.Set())
		{
			throw new MySqlException(getString_0(107357143));
		}
		if (!eventWaitHandle2.WaitOne((int)(uint_0 * 1000), exitContext: false))
		{
			throw new MySqlException(getString_0(107357058));
		}
		int_2 = Marshal.ReadInt32(@class.View);
	}

	private void method_2()
	{
		string text = string_0 + getString_0(107409423) + int_2;
		class130_0 = new Class130(text + getString_0(107357021), (IntPtr)16004);
		eventWaitHandle_1 = EventWaitHandle.OpenExisting(text + getString_0(107357044));
		eventWaitHandle_0 = EventWaitHandle.OpenExisting(text + getString_0(107357503));
		eventWaitHandle_3 = EventWaitHandle.OpenExisting(text + getString_0(107357518));
		eventWaitHandle_2 = EventWaitHandle.OpenExisting(text + getString_0(107357497));
		eventWaitHandle_4 = EventWaitHandle.OpenExisting(text + getString_0(107357448));
		eventWaitHandle_0.Set();
	}

	void Stream.Flush()
	{
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		int num = int_3;
		WaitHandle[] array = new WaitHandle[2] { eventWaitHandle_1, eventWaitHandle_4 };
		Class126 @class = new Class126();
		int num3;
		while (true)
		{
			if (int_0 == 0)
			{
				@class.method_0();
				int num2 = WaitHandle.WaitAny(array, num);
				@class.method_1();
				if (num2 != 258)
				{
					if (array[num2] != eventWaitHandle_4)
					{
						if (int_3 != -1)
						{
							num = int_3 - (int)@class.ElapsedMilliseconds;
							if (num < 0)
							{
								throw new TimeoutException(getString_0(107357277));
							}
						}
						int_0 = Marshal.ReadInt32(class130_0.View);
						int_1 = 4;
						continue;
					}
					throw new MySqlException(getString_0(107356712), isFatal: true, null);
				}
				throw new TimeoutException(getString_0(107357277));
			}
			num3 = Math.Min(count, int_0);
			long num4 = class130_0.View.ToInt64() + int_1;
			int num5 = 0;
			while (num5 < num3)
			{
				buffer[offset + num5] = Marshal.ReadByte((IntPtr)(num4 + num5));
				num5++;
				int_1++;
			}
			int_0 -= num3;
			if (int_0 == 0)
			{
				eventWaitHandle_2.Set();
			}
			break;
		}
		return num3;
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException(getString_0(107356675));
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		int num = count;
		int num2 = offset;
		WaitHandle[] array = new WaitHandle[2] { eventWaitHandle_0, eventWaitHandle_4 };
		Class126 @class = new Class126();
		int num3 = int_4;
		do
		{
			if (num <= 0)
			{
				return;
			}
			@class.method_0();
			int num4 = WaitHandle.WaitAny(array, num3);
			@class.method_1();
			if (array[num4] != eventWaitHandle_4)
			{
				if (num4 != 258)
				{
					if (int_4 != -1)
					{
						num3 = int_4 - (int)@class.ElapsedMilliseconds;
						if (num3 < 0)
						{
							throw new TimeoutException(getString_0(107356614));
						}
					}
					int num5 = Math.Min(num, 16004);
					long num6 = class130_0.View.ToInt64() + 4L;
					Marshal.WriteInt32(class130_0.View, num5);
					Marshal.Copy(buffer, num2, (IntPtr)num6, num5);
					num2 += num5;
					num -= num5;
					continue;
				}
				throw new TimeoutException(getString_0(107357277));
			}
			throw new MySqlException(getString_0(107356712), isFatal: true, null);
		}
		while (eventWaitHandle_3.Set());
		throw new MySqlException(getString_0(107356593));
	}

	void Stream.SetLength(long value)
	{
		throw new NotSupportedException(getString_0(107356675));
	}

	static Stream1()
	{
		Strings.CreateGetStringDelegate(typeof(Stream1));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107398160), getString_0(107398155)).Replace(getString_0(107398118), getString_0(107398113)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107398108)))
		{
			throw new SecurityException(getString_0(107398083));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_1, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);
}
