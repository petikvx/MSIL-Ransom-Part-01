using System;
using System.Runtime.InteropServices;
using System.Text;
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
		return new PCHAR(c1.Address + c2 * c1.StructSize);
	}

	public static PCHAR operator ++(PCHAR a)
	{
		return a + 1;
	}

	public static explicit operator PCHAR(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PCHAR(ptr);
	}

	public override string ToString()
	{
		return Marshal.PtrToStringAnsi(base.Address) ?? string.Empty;
	}
}
