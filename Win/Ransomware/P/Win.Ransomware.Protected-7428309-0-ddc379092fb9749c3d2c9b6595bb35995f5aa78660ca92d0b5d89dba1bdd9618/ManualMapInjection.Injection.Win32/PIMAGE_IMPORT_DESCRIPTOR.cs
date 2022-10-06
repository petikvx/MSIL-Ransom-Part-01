using System;
using ConversionBack;
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
		object[] array = new object[2] { c1, c2 };
		return (PIMAGE_IMPORT_DESCRIPTOR)ConvertBack.Runner(21008, 96, 37, array);
	}

	public static PIMAGE_IMPORT_DESCRIPTOR operator ++(PIMAGE_IMPORT_DESCRIPTOR a)
	{
		object[] array = new object[1] { a };
		return (PIMAGE_IMPORT_DESCRIPTOR)ConvertBack.Runner(21104, 64, 38, array);
	}

	public static explicit operator PIMAGE_IMPORT_DESCRIPTOR(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PIMAGE_IMPORT_DESCRIPTOR)ConvertBack.Runner(21168, 128, 39, array);
	}
}
