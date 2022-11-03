using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PIMAGE_NT_HEADERS32 : ManagedPtr<IMAGE_NT_HEADERS32>
{
	public PIMAGE_NT_HEADERS32(IntPtr address)
		: base(address)
	{
	}

	public PIMAGE_NT_HEADERS32(object value)
		: base(value, freeHandle: true)
	{
	}

	public static explicit operator PIMAGE_NT_HEADERS32(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PIMAGE_NT_HEADERS32(ptr);
	}
}
