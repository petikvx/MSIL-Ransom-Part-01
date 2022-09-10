using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class GetFileRenameRestrictionsByMasterIdCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public FileRenameRestric[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FileRenameRestric[])results[0];
		}
	}

	internal GetFileRenameRestrictionsByMasterIdCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
