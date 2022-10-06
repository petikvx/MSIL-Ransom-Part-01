using System;
using ConversionBack;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PWORD : ManagedPtr<ushort>
{
	public PWORD(IntPtr address)
		: base(address)
	{
	}

	public PWORD(object value)
		: base(value, freeHandle: true)
	{
	}

	public static PWORD operator +(PWORD c1, int c2)
	{
		object[] array = new object[2] { c1, c2 };
		return (PWORD)ConvertBack.Runner(22000, 96, 47, array);
	}

	public static PWORD operator ++(PWORD a)
	{
		object[] array = new object[1] { a };
		return (PWORD)ConvertBack.Runner(22096, 64, 48, array);
	}

	public static explicit operator PWORD(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PWORD)ConvertBack.Runner(22160, 128, 49, array);
	}
}
