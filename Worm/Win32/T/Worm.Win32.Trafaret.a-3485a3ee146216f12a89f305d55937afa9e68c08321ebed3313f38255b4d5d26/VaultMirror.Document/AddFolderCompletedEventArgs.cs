using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class AddFolderCompletedEventArgs : AsyncCompletedEventArgs
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

	internal AddFolderCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
