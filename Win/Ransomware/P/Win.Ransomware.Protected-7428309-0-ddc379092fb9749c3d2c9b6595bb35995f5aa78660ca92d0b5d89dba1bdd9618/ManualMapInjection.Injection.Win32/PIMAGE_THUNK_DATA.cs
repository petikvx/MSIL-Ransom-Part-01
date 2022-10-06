using System;
using ConversionBack;
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
		object[] array = new object[2] { c1, c2 };
		return (PIMAGE_THUNK_DATA)ConvertBack.Runner(21424, 96, 41, array);
	}

	public static PIMAGE_THUNK_DATA operator ++(PIMAGE_THUNK_DATA a)
	{
		object[] array = new object[1] { a };
		return (PIMAGE_THUNK_DATA)ConvertBack.Runner(21520, 64, 42, array);
	}

	public static explicit operator PIMAGE_THUNK_DATA(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PIMAGE_THUNK_DATA)ConvertBack.Runner(21584, 128, 43, array);
	}
}
