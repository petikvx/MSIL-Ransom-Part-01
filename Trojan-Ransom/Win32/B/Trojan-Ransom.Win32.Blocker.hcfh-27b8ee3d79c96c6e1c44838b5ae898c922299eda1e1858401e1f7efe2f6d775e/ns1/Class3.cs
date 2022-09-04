using System;
using System.Runtime.CompilerServices;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace ns1;

internal sealed class Class3
{
	[SpecialName]
	public static string smethod_0()
	{
		try
		{
			return "Software\\Red Gate\\" + Class1.smethod_0();
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
			return "Software\\Wow6432Node\\Red Gate\\" + Class1.smethod_0();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
