using System;
using System.IO;
using System.Security;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportExceptionEventArgs : EventArgs
{
	internal Class16 class16_0;

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
			class16_0.method_19();
		}
	}

	public bool SaveEncryptedReport(string fileName)
	{
		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}
		return class16_0.method_20(fileName);
	}

	public byte[] GetReportRawData()
	{
		return class16_0.method_8();
	}

	public bool SendReport()
	{
		if (!bool_1)
		{
			return false;
		}
		return class16_0.method_15();
	}

	public void AddCustomProperty(string name, string value)
	{
		class16_0.method_13(name, value);
	}

	public void AttachFile(string name, string fileName)
	{
		class16_0.method_14(name, fileName);
	}

	internal ReportExceptionEventArgs(Class16 class16_1, Exception exception_1)
	{
		Class16 @class = (class16_0 = class16_1);
		Exception ex = (exception_0 = exception_1);
	}

	[SecuritySafeCritical]
	static ReportExceptionEventArgs()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static int smethod_0(Version version_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 117:
				return version_0.Major;
			}
		}
	}

	[SecuritySafeCritical]
	internal static char[] smethod_1(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 89:
				return string_0.ToCharArray();
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type smethod_2(Type type_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 123:
				return type_0.GetElementType();
			case 124:
				return type_0.BaseType;
			}
		}
	}
}
