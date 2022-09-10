using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class DeleteFileVersionsUnconditionalCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public FileDelStatus[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FileDelStatus[])results[0];
		}
	}

	internal DeleteFileVersionsUnconditionalCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
