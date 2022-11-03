using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PIMAGE_THUNK_DATA : ManagedPtr<IMAGE_THUNK_DATA>
{
	public PIMAGE_THUNK_DATA(IntPtr address)
		: base(address)
	{
	}

	public PIMAGE_THUNK_DATA(object value)
		: base(value, freeHandle: true)
	{
	}

	public static PIMAGE_THUNK_DATA operator +(PIMAGE_THUNK_DATA c1, int c2)
	{
		return new PIMAGE_THUNK_DATA(c1.Address + c2 * c1.StructSize);
	}

	public static PIMAGE_THUNK_DATA operator ++(PIMAGE_THUNK_DATA a)
	{
		return a + 1;
	}

	public static explicit operator PIMAGE_THUNK_DATA(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PIMAGE_THUNK_DATA(ptr);
	}
}
