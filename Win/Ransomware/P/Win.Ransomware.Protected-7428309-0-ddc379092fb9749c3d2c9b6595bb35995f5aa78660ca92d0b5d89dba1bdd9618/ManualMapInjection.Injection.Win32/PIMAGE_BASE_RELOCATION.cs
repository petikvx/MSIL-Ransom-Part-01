using System;
using ConversionBack;
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
		object[] array = new object[2] { c1, c2 };
		return (PIMAGE_BASE_RELOCATION)ConvertBack.Runner(23152, 96, 59, array);
	}

	public static PIMAGE_BASE_RELOCATION operator ++(PIMAGE_BASE_RELOCATION a)
	{
		object[] array = new object[1] { a };
		return (PIMAGE_BASE_RELOCATION)ConvertBack.Runner(23248, 64, 60, array);
	}

	public static explicit operator PIMAGE_BASE_RELOCATION(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PIMAGE_BASE_RELOCATION)ConvertBack.Runner(23312, 128, 61, array);
	}
}
