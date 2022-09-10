using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace VerificareSiuiFarmacie.EPrescriptionWS;

[DebuggerStepThrough]
[GeneratedCode("System.Web.Services", "2.0.50727.5420")]
[DesignerCategory("code")]
public class downloadNotReportedPrescriptionsReportCompletedEventArgs : AsyncCompletedEventArgs
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

	internal downloadNotReportedPrescriptionsReportCompletedEventArgs(object[] object_1, Exception exception_0, bool bool_0, object object_2)
		: base(exception_0, bool_0, object_2)
	{
		object_0 = object_1;
	}
}
