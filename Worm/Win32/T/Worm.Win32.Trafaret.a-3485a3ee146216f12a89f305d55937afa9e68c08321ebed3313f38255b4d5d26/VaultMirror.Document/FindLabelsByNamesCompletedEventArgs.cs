using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DebuggerStepThrough]
public class FindLabelsByNamesCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public Label[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (Label[])results[0];
		}
	}

	internal FindLabelsByNamesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
