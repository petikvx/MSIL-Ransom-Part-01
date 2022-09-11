using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PIMAGE_SECTION_HEADER : ManagedPtr<IMAGE_SECTION_HEADER>
{
	public PIMAGE_SECTION_HEADER(IntPtr address)
		: base(address)
	{
	}

	public PIMAGE_SECTION_HEADER(object value)
		: base(value, freeHandle: true)
	{
	}

	public static explicit operator PIMAGE_SECTION_HEADER(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PIMAGE_SECTION_HEADER(ptr);
	}
}
