using System;
using ConversionBack;
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
		object[] array = new object[2] { c1, c2 };
		return (PIMAGE_EXPORT_DIRECTORY)ConvertBack.Runner(21712, 96, 44, array);
	}

	public static PIMAGE_EXPORT_DIRECTORY operator ++(PIMAGE_EXPORT_DIRECTORY a)
	{
		object[] array = new object[1] { a };
		return (PIMAGE_EXPORT_DIRECTORY)ConvertBack.Runner(21808, 64, 45, array);
	}

	public static explicit operator PIMAGE_EXPORT_DIRECTORY(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PIMAGE_EXPORT_DIRECTORY)ConvertBack.Runner(21872, 128, 46, array);
	}
}
