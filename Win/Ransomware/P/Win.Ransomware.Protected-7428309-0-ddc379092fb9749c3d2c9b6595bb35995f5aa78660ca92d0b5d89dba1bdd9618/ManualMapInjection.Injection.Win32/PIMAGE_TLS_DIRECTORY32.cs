using System;
using ConversionBack;
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
		object[] array = new object[2] { c1, c2 };
		return (PIMAGE_TLS_DIRECTORY32)ConvertBack.Runner(23728, 96, 65, array);
	}

	public static PIMAGE_TLS_DIRECTORY32 operator ++(PIMAGE_TLS_DIRECTORY32 a)
	{
		object[] array = new object[1] { a };
		return (PIMAGE_TLS_DIRECTORY32)ConvertBack.Runner(23824, 64, 66, array);
	}

	public static explicit operator PIMAGE_TLS_DIRECTORY32(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PIMAGE_TLS_DIRECTORY32)ConvertBack.Runner(23888, 128, 67, array);
	}
}
