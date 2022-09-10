using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class FindFileFoldersBySearchConditionsCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public FileFolder[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FileFolder[])results[0];
		}
	}

	internal FindFileFoldersBySearchConditionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
