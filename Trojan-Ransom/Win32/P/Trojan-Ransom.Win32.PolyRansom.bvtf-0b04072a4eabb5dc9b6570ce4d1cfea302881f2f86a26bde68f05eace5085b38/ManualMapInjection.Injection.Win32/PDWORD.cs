using System;
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
		return new PDWORD(c1.Address + c2 * c1.StructSize);
	}

	public static PDWORD operator ++(PDWORD a)
	{
		return a + 1;
	}

	public static explicit operator PDWORD(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PDWORD(ptr);
	}
}
