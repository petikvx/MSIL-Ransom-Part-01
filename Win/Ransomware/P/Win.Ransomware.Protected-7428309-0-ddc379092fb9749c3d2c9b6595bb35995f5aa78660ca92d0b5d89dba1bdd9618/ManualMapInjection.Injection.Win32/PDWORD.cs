using System;
using ConversionBack;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PDWORD : ManagedPtr<uint>
{
	public PDWORD(IntPtr address)
		: base(address)
	{
	}

	public PDWORD(object value)
		: base(value, freeHandle: true)
	{
	}

	public static PDWORD operator +(PDWORD c1, int c2)
	{
		object[] array = new object[2] { c1, c2 };
		return (PDWORD)ConvertBack.Runner(22288, 96, 50, array);
	}

	public static PDWORD operator ++(PDWORD a)
	{
		object[] array = new object[1] { a };
		return (PDWORD)ConvertBack.Runner(22384, 64, 51, array);
	}

	public static explicit operator PDWORD(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PDWORD)ConvertBack.Runner(22448, 128, 52, array);
	}
}
