using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DesignerCategory("code")]
public class GetPropertiesCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public PropInst[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (PropInst[])results[0];
		}
	}

	internal GetPropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
