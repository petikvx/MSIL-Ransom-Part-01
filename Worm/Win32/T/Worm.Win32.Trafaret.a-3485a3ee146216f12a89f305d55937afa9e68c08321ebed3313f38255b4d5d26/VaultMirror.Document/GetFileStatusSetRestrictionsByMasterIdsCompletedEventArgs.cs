using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class GetFileStatusSetRestrictionsByMasterIdsCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public DocRestricArray[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (DocRestricArray[])results[0];
		}
	}

	internal GetFileStatusSetRestrictionsByMasterIdsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
