using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using Microsoft.VisualBasic.ApplicationServices;
using SmartAssembly.SmartExceptionsCore;

namespace My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyApplication : ApplicationBase
{
	public MyApplication()
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
