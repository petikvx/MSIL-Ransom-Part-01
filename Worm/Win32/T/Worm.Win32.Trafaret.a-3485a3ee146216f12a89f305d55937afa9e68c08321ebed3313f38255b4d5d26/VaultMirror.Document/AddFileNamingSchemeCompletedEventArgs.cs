using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DebuggerStepThrough]
[DesignerCategory("code")]
public class AddFileNamingSchemeCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public FileNmngSchm Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FileNmngSchm)results[0];
		}
	}

	internal AddFileNamingSchemeCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
