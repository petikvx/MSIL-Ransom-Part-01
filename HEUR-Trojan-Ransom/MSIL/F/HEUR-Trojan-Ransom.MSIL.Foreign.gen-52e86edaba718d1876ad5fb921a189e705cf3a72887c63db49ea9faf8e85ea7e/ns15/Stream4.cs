using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.Win32.SafeHandles;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns0;
using ns21;

namespace ns15;

[SuppressUnmanagedCodeSecurity]
internal sealed class Stream4 : Stream
{
	private SafeFileHandle safeFileHandle_0;

	private Stream stream_0;

	private int int_0 = -1;

	private int int_1 = -1;

	[NonSerialized]
	internal static GetString getString_0;

	bool Stream.CanRead => stream_0.CanRead;

	bool Stream.CanWrite => stream_0.CanWrite;

	bool Stream.CanSeek
	{
		get
		{
			throw new NotSupportedException(Class121.NamedPipeNoSeek);
		}
	}

	long Stream.Length
	{
		get
		{
			throw new NotSupportedException(Class121.NamedPipeNoSeek);
		}
	}

	long Stream.Position
	{
		get
		{
			throw new NotSupportedException(Class121.NamedPipeNoSeek);
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
			return int_0;
		}
		set
		{
			int_0 = value;
		}
	}

	int Stream.WriteTimeout
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
		}
	}

	public Stream4(string string_0, FileAccess fileAccess_0, uint uint_0)
	{
		method_1(string_0, fileAccess_0, uint_0);
	}

	private void method_0()
	{
		if (!Class128.CancelIo(safeFileHandle_0.DangerousGetHandle()))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}

	public void method_1(string string_0, FileAccess fileAccess_0, uint uint_0)
	{
		IntPtr intPtr;
		while (true)
		{
			Class128.Class129 @class = new Class128.Class129();
			@class.bool_0 = true;
			@class.int_0 = Marshal.SizeOf(@class);
			intPtr = Class128.CreateFile(string_0, 3221225472u, 0u, @class, 3u, 1073741824u, 0u);
			if (intPtr != IntPtr.Zero)
			{
				break;
			}
			if (Marshal.GetLastWin32Error() == 231)
			{
				Class126 class2 = Class126.smethod_0();
				bool num = Class128.WaitNamedPipe(string_0, uint_0);
				class2.method_1();
				if (num)
				{
					uint_0 -= (uint)(int)class2.ElapsedMilliseconds;
					continue;
				}
				if (uint_0 >= class2.ElapsedMilliseconds && Marshal.GetLastWin32Error() != 121)
				{
					throw new Win32Exception(Marshal.GetLastWin32Error(), getString_0(107371177));
				}
				throw new TimeoutException(getString_0(107371186));
			}
			throw new Win32Exception(Marshal.GetLastWin32Error(), getString_0(107371211));
		}
		safeFileHandle_0 = new SafeFileHandle(intPtr, ownsHandle: true);
		stream_0 = new FileStream(safeFileHandle_0, fileAccess_0, 4096, isAsync: true);
	}

	void Stream.Flush()
	{
		stream_0.Flush();
	}

	int Stream.Read(byte[] buffer, int offset, int count)
	{
		if (int_0 == -1)
		{
			return stream_0.Read(buffer, offset, count);
		}
		IAsyncResult asyncResult = stream_0.BeginRead(buffer, offset, count, null, null);
		if (asyncResult.CompletedSynchronously)
		{
			return stream_0.EndRead(asyncResult);
		}
		if (!asyncResult.AsyncWaitHandle.WaitOne(int_0))
		{
			method_0();
			throw new TimeoutException(getString_0(107371144));
		}
		return stream_0.EndRead(asyncResult);
	}

	void Stream.Write(byte[] buffer, int offset, int count)
	{
		if (int_1 == -1)
		{
			stream_0.Write(buffer, offset, count);
			return;
		}
		IAsyncResult asyncResult = stream_0.BeginWrite(buffer, offset, count, null, null);
		if (asyncResult.CompletedSynchronously)
		{
			stream_0.EndWrite(asyncResult);
		}
		if (!asyncResult.AsyncWaitHandle.WaitOne(int_0))
		{
			method_0();
			throw new TimeoutException(getString_0(107371107));
		}
		stream_0.EndWrite(asyncResult);
	}

	void Stream.Close()
	{
		if (safeFileHandle_0 != null && !safeFileHandle_0.IsInvalid && !safeFileHandle_0.IsClosed)
		{
			stream_0.Close();
			try
			{
				safeFileHandle_0.Close();
			}
			catch (Exception)
			{
			}
		}
	}

	void Stream.SetLength(long value)
	{
		throw new NotSupportedException(Class121.NamedPipeNoSetLength);
	}

	long Stream.Seek(long offset, SeekOrigin origin)
	{
		throw new NotSupportedException(Class121.NamedPipeNoSeek);
	}

	internal static Stream smethod_0(string string_0, string string_1, uint uint_0)
	{
		string string_2 = ((string.Compare(string_1, getString_0(107411137), ignoreCase: true) != 0) ? string.Format(getString_0(107371025), string_1, string_0) : (getString_0(107371070) + string_0));
		return new Stream4(string_2, FileAccess.ReadWrite, uint_0);
	}

	static Stream4()
	{
		Strings.CreateGetStringDelegate(typeof(Stream4));
	}
}
