using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;

namespace My;

[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("MyTemplate", "8.0.0.0")]
internal sealed class MyComputer : Computer
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MyComputer()
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

	static MyComputer()
	{
		DESCryptoIndirector.smethod_0();
	}
}
