using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class FindFilesBySearchConditionsCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public File[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (File[])results[0];
		}
	}

	internal FindFilesBySearchConditionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
