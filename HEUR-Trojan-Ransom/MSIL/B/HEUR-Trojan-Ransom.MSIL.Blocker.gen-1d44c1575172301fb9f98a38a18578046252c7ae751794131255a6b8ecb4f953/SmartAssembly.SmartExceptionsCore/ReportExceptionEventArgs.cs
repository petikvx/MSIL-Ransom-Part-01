using System;
using System.IO;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportExceptionEventArgs : EventArgs
{
	private Class13 class13_0;

	internal Exception exception_0;

	internal bool bool_0;

	internal bool bool_1 = true;

	internal bool bool_2 = true;

	internal bool bool_3;

	public Exception Exception => exception_0;

	public bool CanDebug => bool_0;

	public bool CanSendReport => bool_1;

	public bool ShowContinueCheckbox => bool_2;

	[Obsolete("Use ShowContinueCheckbox instead, as this is now also false when the builder has chosen not to show the checkbox.")]
	public bool CanContinue => bool_2;

	public bool TryToContinue
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool flag = (bool_3 = value);
		}
	}

	internal void method_0(bool bool_4)
	{
		bool flag = (bool_2 = bool_4);
	}

	internal void method_1()
	{
		bool_0 = true;
	}

	public void LaunchDebugger()
	{
		if (bool_0)
		{
			class13_0.method_19();
		}
	}

	public bool SaveEncryptedReport(string fileName)
	{
		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}
		return class13_0.method_20(fileName);
	}

	public byte[] GetReportRawData()
	{
		return class13_0.method_8();
	}

	public bool SendReport()
	{
		if (!bool_1)
		{
			return false;
		}
		return class13_0.method_15();
	}

	public void AddCustomProperty(string name, string value)
	{
		class13_0.method_13(name, value);
	}

	public void AttachFile(string name, string fileName)
	{
		class13_0.method_14(name, fileName);
	}

	internal ReportExceptionEventArgs(Class13 class13_1, Exception exception_1)
	{
		class13_0 = class13_1;
		Exception ex = (exception_0 = exception_1);
	}
}
