using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using Microsoft.VisualBasic.ApplicationServices;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;

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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static MyApplication()
	{
		DESCryptoIndirector.smethod_0();
	}
}
