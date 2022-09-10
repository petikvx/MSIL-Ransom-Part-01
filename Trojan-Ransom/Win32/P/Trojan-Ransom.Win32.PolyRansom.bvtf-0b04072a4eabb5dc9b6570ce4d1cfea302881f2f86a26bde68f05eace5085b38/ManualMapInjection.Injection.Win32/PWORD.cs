using System;
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
		return new PWORD(c1.Address + c2 * c1.StructSize);
	}

	public static PWORD operator ++(PWORD a)
	{
		return a + 1;
	}

	public static explicit operator PWORD(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PWORD(ptr);
	}
}
