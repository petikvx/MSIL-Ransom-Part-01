using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PIMAGE_TLS_DIRECTORY32 : ManagedPtr<IMAGE_TLS_DIRECTORY32>
{
	public PIMAGE_TLS_DIRECTORY32(IntPtr address)
		: base(address)
	{
	}

	public PIMAGE_TLS_DIRECTORY32(object value)
		: base(value, freeHandle: true)
	{
	}

	public static PIMAGE_TLS_DIRECTORY32 operator +(PIMAGE_TLS_DIRECTORY32 c1, int c2)
	{
		return new PIMAGE_TLS_DIRECTORY32(c1.Address + c2 * c1.StructSize);
	}

	public static PIMAGE_TLS_DIRECTORY32 operator ++(PIMAGE_TLS_DIRECTORY32 a)
	{
		return a + 1;
	}

	public static explicit operator PIMAGE_TLS_DIRECTORY32(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PIMAGE_TLS_DIRECTORY32(ptr);
	}
}
