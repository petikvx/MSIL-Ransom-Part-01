using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DesignerCategory("code")]
public class FindFilesByFoldersNamesAndChecksumsCompletedEventArgs : AsyncCompletedEventArgs
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

	internal FindFilesByFoldersNamesAndChecksumsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
