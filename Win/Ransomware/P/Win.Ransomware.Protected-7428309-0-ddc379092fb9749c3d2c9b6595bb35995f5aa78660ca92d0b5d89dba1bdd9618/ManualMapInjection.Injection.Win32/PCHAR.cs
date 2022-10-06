using System;
using System.Text;
using ConversionBack;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PCHAR : ManagedPtr<char>
{
	public PCHAR(IntPtr address)
		: base(address)
	{
	}

	public PCHAR(object value)
		: base(value, freeHandle: true)
	{
	}

	public PCHAR(string value)
		: base((object)Encoding.UTF8.GetBytes(value), freeHandle: true)
	{
	}

	public static PCHAR operator +(PCHAR c1, int c2)
	{
		object[] array = new object[2] { c1, c2 };
		return (PCHAR)ConvertBack.Runner(20512, 96, 32, array);
	}

	public static PCHAR operator ++(PCHAR a)
	{
		object[] array = new object[1] { a };
		return (PCHAR)ConvertBack.Runner(20608, 64, 33, array);
	}

	public static explicit operator PCHAR(IntPtr ptr)
	{
		object[] array = new object[1] { ptr };
		return (PCHAR)ConvertBack.Runner(20672, 128, 34, array);
	}

	public override string ToString()
	{
		object[] array = new object[1] { this };
		return (string)ConvertBack.Runner(20800, 80, 35, array);
	}
}
