using System;
using ConversionBack;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PBYTE : ManagedPtr<byte>
{
	public PBYTE(IntPtr address)
		: base(address)
	{
	}

	public PBYTE(object value)
		: base(value, freeHandle: true)
	{
	}

	public static PBYTE operator +(PBYTE c1, int c2)
	{
		object[] array = new object[2] { c1, c2 };
		return (PBYTE)ConvertBack.Runner(22864, 96, 56, array);
	}

	public static PBYTE operator ++(PBYTE a)
	{
		object[] array = new object[1] { a };
		return (PBYTE)ConvertBack.Runner(22960, 64, 57, array);
	}

	public static explicit operator PBYTE(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PBYTE)ConvertBack.Runner(23024, 128, 58, array);
	}
}
