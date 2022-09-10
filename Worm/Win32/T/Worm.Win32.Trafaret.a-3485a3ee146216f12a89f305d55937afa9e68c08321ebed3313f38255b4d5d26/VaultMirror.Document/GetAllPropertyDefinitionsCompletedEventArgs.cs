using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class GetAllPropertyDefinitionsCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public PropDef[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (PropDef[])results[0];
		}
	}

	internal GetAllPropertyDefinitionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
