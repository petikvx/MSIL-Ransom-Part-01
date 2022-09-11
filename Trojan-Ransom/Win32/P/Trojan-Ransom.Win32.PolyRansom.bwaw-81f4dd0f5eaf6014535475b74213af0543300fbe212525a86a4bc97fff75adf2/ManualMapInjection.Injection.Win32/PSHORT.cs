using System;
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
		return new PSHORT(c1.Address + c2 * c1.StructSize);
	}

	public static PSHORT operator ++(PSHORT a)
	{
		return a + 1;
	}

	public static explicit operator PSHORT(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PSHORT(ptr);
	}
}
