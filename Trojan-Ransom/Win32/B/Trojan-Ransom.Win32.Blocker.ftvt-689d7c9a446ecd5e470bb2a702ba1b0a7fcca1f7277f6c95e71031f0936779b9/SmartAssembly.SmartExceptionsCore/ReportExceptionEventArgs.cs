using System;
using System.IO;
using ns1;

namespace SmartAssembly.SmartExceptionsCore;

public sealed class ReportExceptionEventArgs : EventArgs
{
	private Class7 class7_0;

	private Exception exception_0;

	private bool bool_0;

	private bool bool_1 = true;

	private bool bool_2 = true;

	private bool bool_3;

	public Exception Exception => exception_0;

	public bool CanDebug => bool_0;

	public bool CanSendReport => bool_1;

	public bool ShowContinueCheckbox => bool_2;

	public bool TryToContinue
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
		}
	}

	internal void method_0(bool bool_4)
	{
		bool_2 = bool_4;
	}

	internal void method_1()
	{
		bool_0 = true;
	}

	public void LaunchDebugger()
	{
		if (bool_0)
		{
			class7_0.method_16();
		}
	}

	public bool SaveEncryptedReport(string string_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return class7_0.method_17(string_0);
	}

	public bool SendReport()
	{
		if (!bool_1)
		{
			return false;
		}
		return class7_0.method_12();
	}

	internal ReportExceptionEventArgs(Class7 class7_1, Exception exception_1)
	{
		class7_0 = class7_1;
		exception_0 = exception_1;
	}
}
