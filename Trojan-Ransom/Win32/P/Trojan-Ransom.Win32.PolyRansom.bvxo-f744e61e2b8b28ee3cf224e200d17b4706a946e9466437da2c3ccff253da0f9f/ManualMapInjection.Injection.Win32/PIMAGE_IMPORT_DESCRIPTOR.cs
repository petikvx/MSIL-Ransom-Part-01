using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PIMAGE_IMPORT_DESCRIPTOR : ManagedPtr<IMAGE_IMPORT_DESCRIPTOR>
{
	public PIMAGE_IMPORT_DESCRIPTOR(IntPtr address)
		: base(address)
	{
	}

	public PIMAGE_IMPORT_DESCRIPTOR(object value)
		: base(value, freeHandle: true)
	{
	}

	public static PIMAGE_IMPORT_DESCRIPTOR operator +(PIMAGE_IMPORT_DESCRIPTOR c1, int c2)
	{
		return new PIMAGE_IMPORT_DESCRIPTOR(c1.Address + c2 * c1.StructSize);
	}

	public static PIMAGE_IMPORT_DESCRIPTOR operator ++(PIMAGE_IMPORT_DESCRIPTOR a)
	{
		return a + 1;
	}

	public static explicit operator PIMAGE_IMPORT_DESCRIPTOR(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PIMAGE_IMPORT_DESCRIPTOR(ptr);
	}
}
