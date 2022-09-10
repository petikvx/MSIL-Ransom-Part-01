using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VerificareSiuiFarmacie.SiuiWS;

[DesignerCategory("code")]
[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
[DebuggerStepThrough]
public class isPhysicianOnContractCompletedEventArgs : AsyncCompletedEventArgs
{
	private object[] object_0;

	public string Result
	{
		get
		{
			RaiseExceptionIfNecessary();
			return (string)object_0[0];
		}
	}

	internal isPhysicianOnContractCompletedEventArgs(object[] object_1, Exception exception_0, bool bool_0, object object_2)
		: base(exception_0, bool_0, object_2)
	{
		object_0 = object_1;
	}
}
