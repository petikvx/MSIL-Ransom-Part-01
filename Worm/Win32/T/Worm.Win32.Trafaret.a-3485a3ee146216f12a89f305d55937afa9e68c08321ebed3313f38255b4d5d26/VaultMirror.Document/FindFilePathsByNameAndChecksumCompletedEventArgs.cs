using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class FindFilePathsByNameAndChecksumCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public FilePath[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FilePath[])results[0];
		}
	}

	internal FindFilePathsByNameAndChecksumCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
