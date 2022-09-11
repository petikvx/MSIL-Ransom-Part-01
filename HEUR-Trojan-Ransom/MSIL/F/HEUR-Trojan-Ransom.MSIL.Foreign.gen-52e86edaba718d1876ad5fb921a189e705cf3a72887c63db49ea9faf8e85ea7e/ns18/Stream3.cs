using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns0;

namespace ns18;

internal sealed class Stream3 : Stream
{
	private enum Enum48
	{
		const_0,
		const_1
	}

	private readonly Stream stream_0;

	private int int_0;

	private int int_1;

	private int int_2;

	private readonly Class126 class126_0;

	[CompilerGenerated]
	private bool bool_0;

	[NonSerialized]
	internal static GetString getString_0;

	internal bool IsClosed
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		private set
		{
			bool_0 = value;
		}
	}

	bool Stream.CanRead => stream_0.CanRead;

	bool Stream.CanSeek => stream_0.CanSeek;

	bool Stream.CanWrite => stream_0.CanWrite;

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

	public Stream3(Stream stream_1)
	{
		stream_0 = stream_1;
		int_0 = (stream_1.CanTimeout ? stream_1.ReadTimeout : (-1));
		IsClosed = false;
		class126_0 = new Class126();
	}

	private bool method_0(int int_3, int int_4)
	{
		if (!stream_0.CanTimeout)
		{
			return false;
		}
		if (int_4 == -1 && int_3 != int_4)
		{
			return true;
		}
		if (int_4 > int_3)
		{
			return true;
		}
		return int_3 >= int_4 + 100;
	}

	private void method_1(Enum48 enum48_0)
	{
		int num = ((int_0 != -1) ? (int_0 - (int)class126_0.ElapsedMilliseconds) : (-1));
		if (enum48_0 == Enum48.const_0)
		{
			if (method_0(int_1, num))
			{
				stream_0.ReadTimeout = num;
				int_1 = num;
			}
		}
		else if (method_0(int_2, num))
		{
			stream_0.WriteTimeout = num;
			int_2 = num;
		}
		if (int_0 != -1)
		{
			class126_0.method_0();
		}
	}

	private void method_2()
	{
		if (int_0 != -1)
		{
			class126_0.method_1();
			if (class126_0.ElapsedMilliseconds > int_0)
			{
				method_3(-1);
				throw new TimeoutException(getString_0(107371893));
			}
		}
	}

	void Stream.Flush()
	{
		try
		{
			method_1(Enum48.const_1);
			stream_0.Flush();
			method_2();
		}
		catch (Exception exception_)
		{
			method_4(exception_);
			throw;
		}
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		try
		{
			method_1(Enum48.const_0);
			int result = stream_0.Read(buffer, offset, count);
			method_2();
			return result;
		}
		catch (Exception exception_)
		{
			method_4(exception_);
			throw;
		}
	}

	int Stream.ReadByte()
	{
		try
		{
			method_1(Enum48.const_0);
			int result = stream_0.ReadByte();
			method_2();
			return result;
		}
		catch (Exception exception_)
		{
			method_4(exception_);
			throw;
		}
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		return stream_0.Seek(offset, origin);
	}

	void Stream.SetLength(long value)
	{
		stream_0.SetLength(value);
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		try
		{
			method_1(Enum48.const_1);
			stream_0.Write(buffer, offset, count);
			method_2();
		}
		catch (Exception exception_)
		{
			method_4(exception_);
			throw;
		}
	}

	void Stream.Close()
	{
		if (!IsClosed)
		{
			IsClosed = true;
			stream_0.Close();
			stream_0.Dispose();
		}
	}

	public void method_3(int int_3)
	{
		if (int_3 != -1 && int_3 != 0)
		{
			int_0 = int_3;
		}
		else
		{
			int_0 = -1;
		}
		class126_0.method_2();
	}

	private void method_4(Exception exception_0)
	{
		class126_0.method_1();
		method_3(-1);
	}

	static Stream3()
	{
		Strings.CreateGetStringDelegate(typeof(Stream3));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107399450), getString_0(107399445)).Replace(getString_0(107399408), getString_0(107399403)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107399398)))
		{
			throw new SecurityException(getString_0(107399373));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
}
