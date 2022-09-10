using System;
using System.IO;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportExceptionEventArgs : EventArgs
{
	private Class14 class14_0;

	private Exception exception_0;

	private bool bool_0;

	private bool bool_1;

	internal bool bool_2 = true;

	internal bool bool_3 = true;

	public Exception Exception => exception_0;

	public bool CanDebug => bool_0;

	public bool CanSendReport => bool_2;

	public bool ShowContinueCheckbox => bool_3;

	[Obsolete("Use ShowContinueCheckbox instead, as this is now also false when the builder has chosen not to show the checkbox.")]
	public bool CanContinue => bool_3;

	public bool TryToContinue
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
		}
	}

	internal void method_0(bool bool_4)
	{
		bool flag = (bool_3 = bool_4);
	}

	internal void method_1()
	{
		bool_0 = true;
	}

	public void LaunchDebugger()
	{
		if (bool_0)
		{
			class14_0.method_19();
		}
	}

	public bool SaveEncryptedReport(string fileName)
	{
		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}
		return class14_0.method_20(fileName);
	}

	public byte[] GetReportRawData()
	{
		return class14_0.method_8();
	}

	public bool SendReport()
	{
		if (!bool_2)
		{
			return false;
		}
		return class14_0.method_15();
	}

	public void AddCustomProperty(string name, string value)
	{
		class14_0.method_13(name, value);
	}

	public void AttachFile(string name, string fileName)
	{
		class14_0.method_14(name, fileName);
	}

	internal ReportExceptionEventArgs(Class14 class14_1, Exception exception_1)
	{
		class14_0 = class14_1;
		exception_0 = exception_1;
	}
}
