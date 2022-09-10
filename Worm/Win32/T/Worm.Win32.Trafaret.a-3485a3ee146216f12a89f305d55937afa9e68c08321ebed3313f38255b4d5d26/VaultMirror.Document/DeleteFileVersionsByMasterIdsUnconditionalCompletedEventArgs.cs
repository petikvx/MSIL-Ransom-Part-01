using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class DeleteFileVersionsByMasterIdsUnconditionalCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public FileDelStatus[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FileDelStatus[])results[0];
		}
	}

	internal DeleteFileVersionsByMasterIdsUnconditionalCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
