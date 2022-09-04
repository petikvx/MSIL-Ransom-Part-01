using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SmartAssembly.License;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace SmartAssembly.SmartExceptionsWithUI;

public class UnhandledExceptionHandlerWithUI : UnhandledExceptionHandler
{
	protected override void OnSecurityException(SecurityExceptionEventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Form1 form = default(Form1);
		int num = default(int);
		try
		{
			form = new Form1(e);
			try
			{
				SmartAssembly.License.License.smethod_2((Form)(object)form, 146, 233);
			}
			finally
			{
				num = 0;
				((IDisposable)(object)form)?.Dispose();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, form, num, this, e);
			throw;
		}
	}

	protected override void OnReportException(ReportExceptionEventArgs e)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		Form0 form = default(Form0);
		int num = default(int);
		try
		{
			form = new Form0(this, e);
			try
			{
				SmartAssembly.License.License.smethod_2((Form)(object)form, 834, 825);
			}
			finally
			{
				num = 1;
				((IDisposable)(object)form)?.Dispose();
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, form, num, this, e);
			throw;
		}
	}

	protected override void OnFatalException(FatalExceptionEventArgs e)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			MessageBox.Show(SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_1(e.FatalException, 936, 987), SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_0("{0} Unexpected Error", "server1", 286, 332), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException2(exception, this, e);
			throw;
		}
	}

	public static bool AttachApp()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		int num = default(int);
		bool flag = default(bool);
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		Form1 form = default(Form1);
		Exception ex3 = default(Exception);
		int num4 = default(int);
		int num5 = default(int);
		try
		{
			try
			{
				num = 0;
				UnhandledExceptionHandler.AttachExceptionHandler(new UnhandledExceptionHandlerWithUI());
				flag = true;
			}
			catch (SecurityException)
			{
				try
				{
					try
					{
						num2 = 0;
						SendingReportFeedbackEventArgs1.smethod_0(typeof(Application).TypeHandle, 38, 93).InvokeMember("EnableVisualStyles", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
					}
					catch (MissingMethodException)
					{
					}
					num3 = 6;
					text = SmartAssembly.SmartExceptionsCore.DoNotPruneAttribute.smethod_0("{0} cannot initialize itself because some permissions are not granted.\n\nYou probably try to launch {0} in a partial-trust situation. It's usually the case when the application is hosted on a network share.\n\nYou need to run {0} in full-trust, or at least grant it the UnmanagedCode security permission.\n\nTo grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.", "server1", 553, 635);
					num3 = 0;
					form = new Form1(new SecurityExceptionEventArgs(text, canContinue: false));
					Class21.smethod_2((Form)(object)form, bool_1: true, 62, 67);
					num3 = 3;
					SmartAssembly.License.License.smethod_2((Form)(object)form, 43, 80);
				}
				catch (Exception ex2)
				{
					ex3 = ex2;
					MessageBox.Show(SmartAssembly.SmartUsageCore.ReportUsageAttribute.smethod_1(ex3, 788, 871), string.Format("{0} Unexpected Error", "server1"), (MessageBoxButtons)0, (MessageBoxIcon)16);
				}
				num4 = 0;
				flag = false;
			}
			num5 = 3;
			return flag;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException9(exception, text, form, ex3, flag, num, num2, num3, num4, num5);
			throw;
		}
	}

	public UnhandledExceptionHandlerWithUI()
	{
		try
		{
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException1(exception, this);
			throw;
		}
	}

	static UnhandledExceptionHandlerWithUI()
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

	internal static char smethod_1(string string_1, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 23:
					return Conversions.ToChar(string_1);
				}
				num = 1;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, string_1, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_2(Control control_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 4;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 19:
					control_0.SuspendLayout();
					return;
				case 20:
					control_0.SuspendLayout();
					return;
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException5(exception, num, num2, control_0, int_0, int_1);
			throw;
		}
	}

	internal static Assembly smethod_3(byte[] byte_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 112:
					return Assembly.Load(byte_0);
				}
				num = 4;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, byte_0, int_0, int_1);
			throw;
		}
	}

	internal static FileStream smethod_4(string string_1, FileMode fileMode_0, FileAccess fileAccess_0, FileShare fileShare_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 92:
					return File.Open(string_1, fileMode_0, fileAccess_0, fileShare_0);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException7(exception, num, string_1, fileMode_0, fileAccess_0, fileShare_0, int_0, int_1);
			throw;
		}
	}

	internal static Font smethod_5(Control control_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 110:
					return control_0.get_Font();
				}
				num = 0;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, control_0, int_0, int_1);
			throw;
		}
	}

	internal static void smethod_6(AppDomain appDomain_0, UnhandledExceptionEventHandler unhandledExceptionEventHandler_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			num = 2;
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 54:
					appDomain_0.UnhandledException += unhandledExceptionEventHandler_0;
					return;
				}
				num = 2;
			}
		}
		catch (Exception exception)
		{
			int num2 = default(int);
			StackFrameHelper.CreateException6(exception, num, num2, appDomain_0, unhandledExceptionEventHandler_0, int_0, int_1);
			throw;
		}
	}

	internal static CultureInfo smethod_7(int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 69:
					return CultureInfo.CurrentCulture;
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException3(exception, num, int_0, int_1);
			throw;
		}
	}

	internal static string smethod_8(AssemblyName assemblyName_0, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 44:
					return assemblyName_0.Name;
				}
				num = 6;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException4(exception, num, assemblyName_0, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_9(string string_1, string string_2, int int_0, int int_1)
	{
		int num = default(int);
		try
		{
			while (true)
			{
				switch (int_1 ^ int_0)
				{
				case 28:
					return string_1.IndexOf(string_2);
				}
				num = 5;
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException5(exception, num, string_1, string_2, int_0, int_1);
			throw;
		}
	}

	internal static int smethod_10(Stream stream_0, byte[] byte_0, int int_0, int int_1, int int_2, int int_3)
	{
		try
		{
			while (true)
			{
				switch (int_3 ^ int_2)
				{
				case 51:
					return stream_0.Read(byte_0, int_0, int_1);
				}
			}
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, stream_0, byte_0, int_0, int_1, int_2, int_3);
			throw;
		}
	}
}
