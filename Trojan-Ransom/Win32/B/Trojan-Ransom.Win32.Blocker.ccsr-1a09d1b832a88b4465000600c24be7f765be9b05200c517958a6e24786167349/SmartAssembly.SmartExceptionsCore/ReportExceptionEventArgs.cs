using System;
using System.IO;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportExceptionEventArgs : EventArgs
{
	internal Class14 class14_0;

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
		if (!bool_1)
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
		Class14 @class = (class14_0 = class14_1);
		Exception ex = (exception_0 = exception_1);
	}

	static ReportExceptionEventArgs()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static string smethod_0(ref sbyte sbyte_0, string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 7:
				return sbyte_0.ToString(string_0);
			}
		}
	}

	internal static long smethod_1(Stream stream_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 52:
				return stream_0.Length;
			}
		}
	}

	internal static FileStream smethod_2(string string_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 40:
				return File.OpenWrite(string_0);
			}
		}
	}
}
