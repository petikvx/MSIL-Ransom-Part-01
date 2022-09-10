using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Security;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class UpdateACLCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public ACL Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (ACL)results[0];
		}
	}

	internal UpdateACLCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
