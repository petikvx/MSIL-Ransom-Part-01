using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PIMAGE_BASE_RELOCATION : ManagedPtr<IMAGE_BASE_RELOCATION>
{
	public PIMAGE_BASE_RELOCATION(IntPtr address)
		: base(address)
	{
	}

	public PIMAGE_BASE_RELOCATION(object value)
		: base(value, freeHandle: true)
	{
	}

	public static PIMAGE_BASE_RELOCATION operator +(PIMAGE_BASE_RELOCATION c1, int c2)
	{
		return new PIMAGE_BASE_RELOCATION(c1.Address + c2 * c1.StructSize);
	}

	public static PIMAGE_BASE_RELOCATION operator ++(PIMAGE_BASE_RELOCATION a)
	{
		return a + 1;
	}

	public static explicit operator PIMAGE_BASE_RELOCATION(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PIMAGE_BASE_RELOCATION(ptr);
	}
}
