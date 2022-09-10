using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DebuggerStepThrough]
public class GetBOMByFileIdsCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public BOM[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (BOM[])results[0];
		}
	}

	internal GetBOMByFileIdsCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
