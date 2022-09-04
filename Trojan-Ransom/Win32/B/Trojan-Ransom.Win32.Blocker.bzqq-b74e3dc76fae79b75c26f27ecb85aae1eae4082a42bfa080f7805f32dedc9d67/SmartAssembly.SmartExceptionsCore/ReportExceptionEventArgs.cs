using System;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsCore;

public class ReportExceptionEventArgs : EventArgs
{
	internal Class17 class17_0;

	internal Exception exception_0;

	internal bool bool_0;

	internal bool bool_1;

	internal bool bool_2;

	internal bool bool_3;

	public Exception Exception
	{
		get
		{
			try
			{
				return exception_0;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
	}

	public bool CanDebug
	{
		get
		{
			try
			{
				return bool_0;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
	}

	public bool CanSendReport
	{
		get
		{
			try
			{
				return bool_1;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
	}

	public bool ShowContinueCheckbox
	{
		get
		{
			try
			{
				return bool_2;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
	}

	[Obsolete("Use ShowContinueCheckbox instead, as this is now also false when the builder has chosen not to show the checkbox.")]
	public bool CanContinue
	{
		get
		{
			try
			{
				return bool_2;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
	}

	public bool TryToContinue
	{
		get
		{
			try
			{
				return bool_3;
			}
			catch (Exception exception)
			{
				int num = default(int);
				StackFrameHelper.CreateException2(exception, num, this);
				throw;
			}
		}
		set
		{
			bool flag = default(bool);
			try
			{
				flag = (bool_3 = value);
			}
			catch (Exception exception)
			{
				StackFrameHelper.CreateException3(exception, flag, this, value);
				throw;
			}
		}
	}

	internal void method_0(bool bool_4)
	{
		bool flag = default(bool);
		try
		{
			flag = (bool_2 = bool_4);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, flag, this, bool_4);
			throw;
		}
	}

	internal void method_1()
	{
		bool flag = default(bool);
		try
		{
			flag = true;
			bool_0 = true;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, flag, this);
			throw;
		}
	}

	public void LaunchDebugger()
	{
		int num = default(int);
		try
		{
			num = 0;
			if (bool_0)
			{
				class17_0.method_19();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, num, this);
			throw;
		}
	}

	public bool SaveEncryptedReport(string fileName)
	{
		try
		{
			if (SimpleZip.smethod_2(fileName, 632, 596))
			{
				Class17.smethod_11(fileName, 48, 123);
			}
			return class17_0.method_20(fileName);
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException3(exception, num, this, fileName);
			throw;
		}
	}

	public byte[] GetReportRawData()
	{
		try
		{
			return class17_0.method_8();
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException2(exception, num, this);
			throw;
		}
	}

	public bool SendReport()
	{
		try
		{
			if (!bool_1)
			{
				return false;
			}
			return class17_0.method_15();
		}
		catch (Exception exception)
		{
			int num = default(int);
			StackFrameHelper.CreateException2(exception, num, this);
			throw;
		}
	}

	public void AddCustomProperty(string name, string value)
	{
		try
		{
			class17_0.method_13(name, value);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, name, value);
			throw;
		}
	}

	public void AttachFile(string name, string fileName)
	{
		try
		{
			class17_0.method_14(name, fileName);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, this, name, fileName);
			throw;
		}
	}

	internal ReportExceptionEventArgs(Class17 class17_1, Exception exception_1)
	{
		bool flag = true;
		bool_1 = true;
		bool flag2 = true;
		bool_2 = true;
		base._002Ector();
		Class17 o = default(Class17);
		Exception o2 = default(Exception);
		try
		{
			o = (class17_0 = class17_1);
			o2 = (exception_0 = exception_1);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, flag, flag2, o, o2, this, class17_1, exception_1);
			throw;
		}
	}

	static ReportExceptionEventArgs()
	{
		try
		{
			SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_8();
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	internal static void smethod_0(Stream stream_0, long long_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 0;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 14:
					stream_0.Position = long_0;
					return;
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, stream_0, long_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_1(Type type_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 114:
					return Marshal.SizeOf(type_0);
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, type_0, int_0, int_1);
			throw;
		}
	}
}
