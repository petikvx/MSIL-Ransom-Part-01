using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class GetLatestAssociatedFilePathsByMasterIdsCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public FilePathArray[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FilePathArray[])results[0];
		}
	}

	internal GetLatestAssociatedFilePathsByMasterIdsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
