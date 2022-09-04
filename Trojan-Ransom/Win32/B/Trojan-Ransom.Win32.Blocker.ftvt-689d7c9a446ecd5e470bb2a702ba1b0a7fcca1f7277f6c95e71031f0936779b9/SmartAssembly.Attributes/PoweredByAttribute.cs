using System;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.Attributes;

public sealed class PoweredByAttribute : Attribute
{
	public PoweredByAttribute(string s)
	{
		try
		{
		}
		catch (Exception exception_)
		{
			StackFrameHelper.CreateException2(exception_, this, s);
			throw;
		}
	}
}
