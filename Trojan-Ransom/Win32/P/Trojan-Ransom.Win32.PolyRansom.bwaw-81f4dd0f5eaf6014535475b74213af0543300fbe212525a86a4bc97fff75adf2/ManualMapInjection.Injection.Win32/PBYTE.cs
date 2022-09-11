using System;
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
		return new PBYTE(c1.Address + c2 * c1.StructSize);
	}

	public static PBYTE operator ++(PBYTE a)
	{
		return a + 1;
	}

	public static explicit operator PBYTE(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PBYTE(ptr);
	}
}
