using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DesignerCategory("code")]
[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
public class GetFileAssociationRestrictionsByIdCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public FileAssocRestric[] Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (FileAssocRestric[])results[0];
		}
	}

	internal GetFileAssociationRestrictionsByIdCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
