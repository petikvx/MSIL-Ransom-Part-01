using System;
using System.Runtime.InteropServices;

namespace Gecko.Interop;

internal static class ExceptionTranslator
{
	internal static void AutotranslateComErrors(Action action)
	{
		try
		{
			action();
		}
		catch (COMException ex)
		{
			int errorCode = ex.ErrorCode;
			throw Lookup(errorCode);
		}
	}

	internal static GeckoException Lookup(int errorCode)
	{
		return Lookup((uint)errorCode);
	}

	internal static GeckoException Lookup(uint errorCode)
	{
		return new GeckoException(errorCode.ToString());
	}
}
