using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PIMAGE_EXPORT_DIRECTORY : ManagedPtr<IMAGE_EXPORT_DIRECTORY>
{
	public PIMAGE_EXPORT_DIRECTORY(IntPtr address)
		: base(address)
	{
	}

	public PIMAGE_EXPORT_DIRECTORY(object value)
		: base(value, freeHandle: true)
	{
	}

	public static PIMAGE_EXPORT_DIRECTORY operator +(PIMAGE_EXPORT_DIRECTORY c1, int c2)
	{
		return new PIMAGE_EXPORT_DIRECTORY(c1.Address + c2 * c1.StructSize);
	}

	public static PIMAGE_EXPORT_DIRECTORY operator ++(PIMAGE_EXPORT_DIRECTORY a)
	{
		return a + 1;
	}

	public static explicit operator PIMAGE_EXPORT_DIRECTORY(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PIMAGE_EXPORT_DIRECTORY(ptr);
	}
}
