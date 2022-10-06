using System;
using ConversionBack;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PIMAGE_NT_HEADERS32 : ManagedPtr<IMAGE_NT_HEADERS32>
{
	public PIMAGE_NT_HEADERS32(IntPtr address)
		: base(address)
	{
	}

	public PIMAGE_NT_HEADERS32(object value)
		: base(value, freeHandle: true)
	{
	}

	public static explicit operator PIMAGE_NT_HEADERS32(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PIMAGE_NT_HEADERS32)ConvertBack.Runner(20384, 128, 31, array);
	}
}
