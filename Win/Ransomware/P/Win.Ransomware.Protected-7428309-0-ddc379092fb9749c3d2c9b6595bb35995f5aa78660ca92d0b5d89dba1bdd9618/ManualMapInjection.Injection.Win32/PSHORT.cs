using System;
using ConversionBack;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PSHORT : ManagedPtr<short>
{
	public PSHORT(IntPtr address)
		: base(address)
	{
	}

	public PSHORT(object value)
		: base(value, freeHandle: true)
	{
	}

	public static PSHORT operator +(PSHORT c1, int c2)
	{
		object[] array = new object[2] { c1, c2 };
		return (PSHORT)ConvertBack.Runner(23440, 96, 62, array);
	}

	public static PSHORT operator ++(PSHORT a)
	{
		object[] array = new object[1] { a };
		return (PSHORT)ConvertBack.Runner(23536, 64, 63, array);
	}

	public static explicit operator PSHORT(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PSHORT)ConvertBack.Runner(23600, 128, 64, array);
	}
}
