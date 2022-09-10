using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DebuggerStepThrough]
public class GetDWFPublishPreserveFolderHierarchyCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public bool Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (bool)results[0];
		}
	}

	internal GetDWFPublishPreserveFolderHierarchyCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
