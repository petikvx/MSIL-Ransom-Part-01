using System;
using ConversionBack;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PIMAGE_DOS_HEADER : ManagedPtr<IMAGE_DOS_HEADER>
{
	public PIMAGE_DOS_HEADER(IntPtr address)
		: base(address)
	{
	}

	public PIMAGE_DOS_HEADER(object value)
		: base(value, freeHandle: true)
	{
	}

	public static explicit operator PIMAGE_DOS_HEADER(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PIMAGE_DOS_HEADER)ConvertBack.Runner(20256, 128, 30, array);
	}
}
