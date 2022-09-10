using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DebuggerStepThrough]
public class GetRequiredWorkingFolderLocationCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public string Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (string)results[0];
		}
	}

	internal GetRequiredWorkingFolderLocationCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
