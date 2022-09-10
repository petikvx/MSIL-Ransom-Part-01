using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class GetFoldersByFileMasterIdsCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public FolderArray[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FolderArray[])results[0];
		}
	}

	internal GetFoldersByFileMasterIdsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
