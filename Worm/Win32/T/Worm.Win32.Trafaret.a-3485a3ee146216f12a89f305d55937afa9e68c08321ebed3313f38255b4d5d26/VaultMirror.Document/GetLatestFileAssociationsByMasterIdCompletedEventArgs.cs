using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DebuggerStepThrough]
[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class GetLatestFileAssociationsByMasterIdCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public FileAssoc[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FileAssoc[])results[0];
		}
	}

	internal GetLatestFileAssociationsByMasterIdCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
