using System;
using System.Runtime.CompilerServices;
using SmartAssembly.SmartExceptionsCore;
using ns1;

namespace ns2;

internal sealed class Class44
{
	[SpecialName]
	public static string smethod_0()
	{
		try
		{
			return "Software\\Red Gate\\" + Class42.smethod_0();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	[SpecialName]
	public static string smethod_1()
	{
		try
		{
			return "Software\\Wow6432Node\\Red Gate\\" + Class42.smethod_0();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
