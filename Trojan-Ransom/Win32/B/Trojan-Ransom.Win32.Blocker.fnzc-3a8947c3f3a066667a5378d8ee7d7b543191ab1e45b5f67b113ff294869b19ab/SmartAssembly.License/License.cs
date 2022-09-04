using System;
using System.Drawing;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.SmartExceptionsWithoutUI;
using SmartAssembly.SmartUsageCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.License;

public class License
{
	private static void smethod_0()
	{
		try
		{
			try
			{
				Class26.smethod_1(typeof(Application).TypeHandle, 153, 189).InvokeMember("EnableVisualStyles", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
			}
			catch (MissingMethodException)
			{
			}
			ReportSender.smethod_4(535, 591);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	public static bool Validate()
	{
		try
		{
			return smethod_1(bool_0: false);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	public static void ValidateDLL()
	{
		try
		{
			smethod_1(bool_0: true);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	private static bool smethod_1(bool bool_0)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		DateTime dateTime_ = default(DateTime);
		Form0 form = default(Form0);
		string name = default(string);
		string text = default(string);
		Form0 form2 = default(Form0);
		try
		{
			dateTime_ = SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_2("2014-09-14T03:35:51", 105, 124);
			if (!SmartAssembly.SmartExceptionsCore.ReportUsageAttribute.smethod_3(SimpleZip.Class6.smethod_0(557, 575), dateTime_, 915, 913) && !SimpleZip.Class12.smethod_0(SimpleZip.Class6.smethod_0(760, 746), UnhandledExceptionHandlerWithoutUI.smethod_2(ref dateTime_, -21.0, 608, 620), 921, 1019))
			{
				if (AppPathFinder.ReadInstalledSaPath() == null)
				{
					try
					{
						form = new Form0("This application has been built with an evaluation version of SmartAssembly, and therefore cannot be distributed. You can install SmartAssembly on this computer to be able to run this application.\n\nThis application will now quit.", "SmartAssembly Evaluation Version", "error");
						smethod_0();
						((Control)form).set_BackColor(Color.White);
						((Form)form).ShowDialog();
					}
					catch
					{
					}
					return false;
				}
				return true;
			}
			name = Class20.smethod_2(SmartAssembly.SmartUsageCore.DoNotPruneAttribute.smethod_3(716, 660), 163, 169).Name;
			text = smethod_3("This copy of '{0}' has expired and will no longer run. \nThis is because it was created using a version of Red Gate's SmartAssembly which is only licensed for testing software. \n\nYou should report this problem to the vendor who supplied '{0}'.", name, Class14.smethod_0(ref dateTime_, "D", 882, 886), 404, 510);
			if (bool_0)
			{
				throw new Exception(text);
			}
			form2 = new Form0(text, "Program has expired", "error");
			smethod_0();
			Win32.smethod_10((Form)(object)form2, 747, 643);
			return false;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, dateTime_, name, text, form2, form, bool_0);
			throw;
		}
	}

	[SecuritySafeCritical]
	static License()
	{
		Class32.smethod_1();
	}

	[SecuritySafeCritical]
	internal static void smethod_2(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0, int int_0, int int_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 123:
				containerControl_0.set_AutoScaleMode(autoScaleMode_0);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_3(string string_0, object object_0, object object_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 106:
				return string.Format(string_0, object_0, object_1);
			}
		}
	}
}
