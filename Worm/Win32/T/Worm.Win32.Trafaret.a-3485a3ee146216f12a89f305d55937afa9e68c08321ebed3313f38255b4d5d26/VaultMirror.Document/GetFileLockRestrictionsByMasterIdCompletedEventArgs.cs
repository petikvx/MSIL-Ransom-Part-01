using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class GetFileLockRestrictionsByMasterIdCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public FileLockRestric[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FileLockRestric[])results[0];
		}
	}

	internal GetFileLockRestrictionsByMasterIdCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
