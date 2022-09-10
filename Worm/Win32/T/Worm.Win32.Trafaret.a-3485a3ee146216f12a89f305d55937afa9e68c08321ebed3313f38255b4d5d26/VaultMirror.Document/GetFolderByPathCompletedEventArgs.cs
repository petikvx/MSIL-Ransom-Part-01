using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class GetFolderByPathCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public Folder Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (Folder)results[0];
		}
	}

	internal GetFolderByPathCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
