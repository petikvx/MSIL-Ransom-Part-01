using System;
using System.Runtime.CompilerServices;
using SmartAssembly.SmartExceptionsCore;

namespace ns1;

internal sealed class Class42
{
	[SpecialName]
	public static string smethod_0()
	{
		try
		{
			return smethod_2() + " " + smethod_1();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	[SpecialName]
	public static int smethod_1()
	{
		Version version = default(Version);
		try
		{
			version = new Version("6.7.0.103");
			return version.Major;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, version);
			throw;
		}
	}

	[SpecialName]
	public static string smethod_2()
	{
		try
		{
			return "SmartAssembly";
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}
}
