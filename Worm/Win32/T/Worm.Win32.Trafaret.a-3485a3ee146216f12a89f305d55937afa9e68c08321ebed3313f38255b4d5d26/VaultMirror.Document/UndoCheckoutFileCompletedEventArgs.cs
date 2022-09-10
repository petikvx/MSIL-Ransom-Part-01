using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class UndoCheckoutFileCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public File Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (File)results[0];
		}
	}

	public byte[] fileContents
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (byte[])results[1];
		}
	}

	internal UndoCheckoutFileCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
