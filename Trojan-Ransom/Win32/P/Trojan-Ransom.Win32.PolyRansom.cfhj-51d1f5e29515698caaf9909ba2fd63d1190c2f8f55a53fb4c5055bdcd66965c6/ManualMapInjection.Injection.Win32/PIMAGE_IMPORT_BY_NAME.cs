using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PIMAGE_IMPORT_BY_NAME : ManagedPtr<IMAGE_IMPORT_BY_NAME>
{
	public PIMAGE_IMPORT_BY_NAME(IntPtr address)
		: base(address)
	{
	}

	public PIMAGE_IMPORT_BY_NAME(object value)
		: base(value, freeHandle: true)
	{
	}

	public static PIMAGE_IMPORT_BY_NAME operator +(PIMAGE_IMPORT_BY_NAME c1, int c2)
	{
		return new PIMAGE_IMPORT_BY_NAME(c1.Address + c2 * c1.StructSize);
	}

	public static PIMAGE_IMPORT_BY_NAME operator ++(PIMAGE_IMPORT_BY_NAME a)
	{
		return a + 1;
	}

	public static explicit operator PIMAGE_IMPORT_BY_NAME(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PIMAGE_IMPORT_BY_NAME(ptr);
	}
}
