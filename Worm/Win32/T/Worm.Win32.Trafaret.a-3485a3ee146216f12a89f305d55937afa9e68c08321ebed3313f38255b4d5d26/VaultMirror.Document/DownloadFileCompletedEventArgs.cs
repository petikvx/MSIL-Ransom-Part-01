using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VaultMirror.Document;

[GeneratedCode("System.Web.Services", "2.0.50727.42")]
[DesignerCategory("code")]
[DebuggerStepThrough]
public class DownloadFileCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] results;

	public string Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (string)results[0];
		}
	}

	public byte[] fileContents
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (byte[])results[1];
		}
	}

	internal DownloadFileCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		: base(exception, cancelled, userState)
	{
		this.results = results;
	}
}
