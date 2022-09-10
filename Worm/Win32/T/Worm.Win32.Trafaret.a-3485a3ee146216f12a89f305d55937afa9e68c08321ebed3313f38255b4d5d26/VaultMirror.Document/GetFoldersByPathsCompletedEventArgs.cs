using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class GetFoldersByPathsCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public Folder[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (Folder[])results[0];
		}
	}

	internal GetFoldersByPathsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
