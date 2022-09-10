using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class GetComponentPropertiesCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public CompPropInfo Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (CompPropInfo)results[0];
		}
	}

	internal GetComponentPropertiesCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
