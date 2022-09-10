using System;
using ManualMapInjection.Injection.Types;

namespace ManualMapInjection.Injection.Win32;

public class PPROCESS_BASIC_INFORMATION : ManagedPtr<PROCESS_BASIC_INFORMATION>
{
	public PPROCESS_BASIC_INFORMATION(IntPtr address)
		: base(address)
	{
	}

	public PPROCESS_BASIC_INFORMATION(object value)
		: base(value, freeHandle: true)
	{
	}

	public static explicit operator PPROCESS_BASIC_INFORMATION(IntPtr ptr)
	{
		if (ptr == IntPtr.Zero)
		{
			return null;
		}
		return new PPROCESS_BASIC_INFORMATION(ptr);
	}
}
