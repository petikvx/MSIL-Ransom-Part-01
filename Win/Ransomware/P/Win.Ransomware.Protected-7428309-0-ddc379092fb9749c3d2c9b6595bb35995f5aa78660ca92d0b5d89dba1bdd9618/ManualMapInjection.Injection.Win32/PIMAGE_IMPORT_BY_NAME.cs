using System;
using ConversionBack;
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
		object[] array = new object[2] { c1, c2 };
		return (PIMAGE_IMPORT_BY_NAME)ConvertBack.Runner(22576, 96, 53, array);
	}

	public static PIMAGE_IMPORT_BY_NAME operator ++(PIMAGE_IMPORT_BY_NAME a)
	{
		object[] array = new object[1] { a };
		return (PIMAGE_IMPORT_BY_NAME)ConvertBack.Runner(22672, 64, 54, array);
	}

	public static explicit operator PIMAGE_IMPORT_BY_NAME(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PIMAGE_IMPORT_BY_NAME)ConvertBack.Runner(22736, 128, 55, array);
	}
}
