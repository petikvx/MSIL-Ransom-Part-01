using System;
using ConversionBack;
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
		object[] array = new object[1] { ptr };
		return (PPROCESS_BASIC_INFORMATION)ConvertBack.Runner(20880, 128, 36, array);
	}
}
