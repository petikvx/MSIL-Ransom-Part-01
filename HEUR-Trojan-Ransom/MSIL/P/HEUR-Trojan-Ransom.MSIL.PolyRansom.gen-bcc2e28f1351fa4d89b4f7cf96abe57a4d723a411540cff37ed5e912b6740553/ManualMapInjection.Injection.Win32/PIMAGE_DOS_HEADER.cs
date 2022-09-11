using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PIMAGE_DOS_HEADER : ManagedPtr<IMAGE_DOS_HEADER>
{
	public PIMAGE_DOS_HEADER(IntPtr address)
		: base(address)
	{
	}

	public PIMAGE_DOS_HEADER(object value)
		: base(value, freeHandle: true)
	{
	}

	public static explicit operator PIMAGE_DOS_HEADER(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PIMAGE_DOS_HEADER(ptr);
	}
}
