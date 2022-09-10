using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Security;

[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class GetACLUpdateRestrictionsCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public SecRestric[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (SecRestric[])results[0];
		}
	}

	internal GetACLUpdateRestrictionsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
