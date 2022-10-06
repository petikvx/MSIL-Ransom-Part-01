using System;
using ConversionBack;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PIMAGE_LOAD_CONFIG_DIRECTORY32 : ManagedPtr<IMAGE_LOAD_CONFIG_DIRECTORY32>
{
	public PIMAGE_LOAD_CONFIG_DIRECTORY32(IntPtr address)
		: base(address)
	{
	}

	public PIMAGE_LOAD_CONFIG_DIRECTORY32(object value)
		: base(value, freeHandle: true)
	{
	}

	public static PIMAGE_LOAD_CONFIG_DIRECTORY32 operator +(PIMAGE_LOAD_CONFIG_DIRECTORY32 c1, int c2)
	{
		object[] array = new object[2] { c1, c2 };
		return (PIMAGE_LOAD_CONFIG_DIRECTORY32)ConvertBack.Runner(24016, 96, 68, array);
	}

	public static PIMAGE_LOAD_CONFIG_DIRECTORY32 operator ++(PIMAGE_LOAD_CONFIG_DIRECTORY32 a)
	{
		object[] array = new object[1] { a };
		return (PIMAGE_LOAD_CONFIG_DIRECTORY32)ConvertBack.Runner(24112, 64, 69, array);
	}

	public static explicit operator PIMAGE_LOAD_CONFIG_DIRECTORY32(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PIMAGE_LOAD_CONFIG_DIRECTORY32)ConvertBack.Runner(24176, 128, 70, array);
	}
}
