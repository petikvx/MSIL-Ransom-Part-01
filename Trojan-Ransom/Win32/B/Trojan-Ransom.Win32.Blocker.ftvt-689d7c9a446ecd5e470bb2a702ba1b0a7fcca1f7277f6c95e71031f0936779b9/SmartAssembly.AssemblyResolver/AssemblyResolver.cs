using System;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace SmartAssembly.AssemblyResolver;

public sealed class AssemblyResolver
{
	public static void AttachApp()
	{
		try
		{
			try
			{
				Class2.smethod_0();
			}
			catch (Exception)
			{
			}
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException0(exception_);
			throw;
		}
	}

	public AssemblyResolver()
	{
		try
		{
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException1(exception_, this);
			throw;
		}
	}
}
