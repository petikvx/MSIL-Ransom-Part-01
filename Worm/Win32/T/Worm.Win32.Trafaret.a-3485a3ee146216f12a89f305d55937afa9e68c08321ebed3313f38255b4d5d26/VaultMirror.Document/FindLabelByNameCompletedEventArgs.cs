using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class FindLabelByNameCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public Label Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (Label)results[0];
		}
	}

	internal FindLabelByNameCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
