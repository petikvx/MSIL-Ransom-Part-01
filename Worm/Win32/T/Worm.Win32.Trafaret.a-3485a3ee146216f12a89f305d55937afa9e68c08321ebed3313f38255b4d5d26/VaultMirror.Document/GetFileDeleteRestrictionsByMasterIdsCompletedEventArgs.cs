using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class GetFileDeleteRestrictionsByMasterIdsCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public FileDelRestricArray[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FileDelRestricArray[])results[0];
		}
	}

	internal GetFileDeleteRestrictionsByMasterIdsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
