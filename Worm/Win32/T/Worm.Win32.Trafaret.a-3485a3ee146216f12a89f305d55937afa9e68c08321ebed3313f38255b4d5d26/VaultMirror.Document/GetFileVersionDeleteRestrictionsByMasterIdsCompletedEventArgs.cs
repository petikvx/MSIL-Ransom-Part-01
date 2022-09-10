using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DebuggerStepThrough]
public class GetFileVersionDeleteRestrictionsByMasterIdsCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public FileDelRestricEx[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FileDelRestricEx[])results[0];
		}
	}

	internal GetFileVersionDeleteRestrictionsByMasterIdsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
