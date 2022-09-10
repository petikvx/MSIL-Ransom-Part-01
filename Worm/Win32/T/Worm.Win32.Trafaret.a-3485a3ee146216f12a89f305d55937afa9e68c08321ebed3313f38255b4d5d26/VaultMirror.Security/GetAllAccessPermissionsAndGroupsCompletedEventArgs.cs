using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Security;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class GetAllAccessPermissionsAndGroupsCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public AccessPermisAndGrp Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (AccessPermisAndGrp)results[0];
		}
	}

	internal GetAllAccessPermissionsAndGroupsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
