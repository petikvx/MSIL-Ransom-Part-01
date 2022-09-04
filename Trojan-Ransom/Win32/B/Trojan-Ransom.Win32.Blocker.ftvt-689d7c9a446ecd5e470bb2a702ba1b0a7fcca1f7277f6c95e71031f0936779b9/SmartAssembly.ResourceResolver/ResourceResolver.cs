using System;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace SmartAssembly.ResourceResolver;

public sealed class ResourceResolver
{
	public static void AttachApp()
	{
		try
		{
			try
			{
				Class1.smethod_0();
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

	public ResourceResolver()
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
