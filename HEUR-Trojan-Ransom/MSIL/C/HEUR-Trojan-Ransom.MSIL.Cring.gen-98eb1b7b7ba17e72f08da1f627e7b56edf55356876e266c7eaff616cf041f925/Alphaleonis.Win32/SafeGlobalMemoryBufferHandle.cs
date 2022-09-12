using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Alphaleonis.Win32;

internal sealed class SafeGlobalMemoryBufferHandle : SafeNativeMemoryBufferHandle
{
	public SafeGlobalMemoryBufferHandle()
		: base(callerHandle: true)
	{
	}

	public SafeGlobalMemoryBufferHandle(int capacity)
		: base(capacity)
	{
		SetHandle(Marshal.AllocHGlobal(capacity));
	}

	private SafeGlobalMemoryBufferHandle(IntPtr buffer, int capacity)
		: base(buffer, capacity)
	{
	}

	[SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
	public static SafeGlobalMemoryBufferHandle FromLong(long? value)
	{
		if (value.HasValue)
		{
			SafeGlobalMemoryBufferHandle safeGlobalMemoryBufferHandle = new SafeGlobalMemoryBufferHandle(Marshal.SizeOf(typeof(long)));
			Marshal.WriteInt64(safeGlobalMemoryBufferHandle.handle, value.Value);
			return safeGlobalMemoryBufferHandle;
		}
		return new SafeGlobalMemoryBufferHandle();
	}

	public static SafeGlobalMemoryBufferHandle FromStringUni(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return new SafeGlobalMemoryBufferHandle(Marshal.StringToHGlobalUni(str), str.Length * 2 + 2);
	}

	protected override bool ReleaseHandle()
	{
		Marshal.FreeHGlobal(handle);
		return true;
	}
}
