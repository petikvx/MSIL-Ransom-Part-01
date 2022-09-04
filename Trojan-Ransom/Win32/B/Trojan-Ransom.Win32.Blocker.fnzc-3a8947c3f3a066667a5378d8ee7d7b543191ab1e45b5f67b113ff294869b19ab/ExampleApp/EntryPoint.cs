using System;
using System.Drawing;
using System.Security;
using System.Text;
using System.Windows.Forms;
using SmartAssembly.License;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsWithoutUI;
using SmartAssembly.SmartUsageCore;
using ns0;

namespace ExampleApp;

public class EntryPoint
{
	[STAThread]
	[SecuritySafeCritical]
	public static void Main(string[] args)
	{
		Class32.smethod_1();
		if (!License.Validate())
		{
			return;
		}
		Form1 form = default(Form1);
		try
		{
			if (UnhandledExceptionHandlerWithoutUI.AttachApp())
			{
				Class23.smethod_2("Now Executing Custom Application...", 881, 822);
				form = new Form1();
				UsageReportSender.smethod_5((Control)(object)form, bool_0: false, 778, 852);
				Win32.smethod_10((Form)(object)form, 304, 344);
			}
		}
		catch (Exception exception)
		{
			UnhandledExceptionHandler.EntryPointException(exception, new object[2] { form, args });
		}
	}

	[SecuritySafeCritical]
	static EntryPoint()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static Encoding smethod_0(int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 115:
				return Encoding.UTF8;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(Form form_0, Size size_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 46:
				form_0.set_ClientSize(size_0);
				return;
			case 47:
				form_0.set_AutoScaleBaseSize(size_0);
				return;
			}
		}
	}
}
