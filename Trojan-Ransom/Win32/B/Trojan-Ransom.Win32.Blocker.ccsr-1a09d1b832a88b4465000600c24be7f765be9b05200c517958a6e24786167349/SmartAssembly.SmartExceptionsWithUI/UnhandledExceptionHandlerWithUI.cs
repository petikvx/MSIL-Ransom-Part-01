using System;
using System.Drawing;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;
using ns0;

namespace SmartAssembly.SmartExceptionsWithUI;

public class UnhandledExceptionHandlerWithUI : UnhandledExceptionHandler
{
	protected override void OnSecurityException(SecurityExceptionEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Form1 form = new Form1(e);
		try
		{
			((Form)form).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)form)?.Dispose();
		}
	}

	protected override void OnReportException(ReportExceptionEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Form0 form = new Form0(this, e);
		try
		{
			((Form)form).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)form)?.Dispose();
		}
	}

	protected override void OnFatalException(FatalExceptionEventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(Win32.smethod_10(e.FatalException, 686, 728), string.Format("{0} Unexpected Error", "Nc0j6W1Ag"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static bool AttachApp()
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			UnhandledExceptionHandler.AttachExceptionHandler(new UnhandledExceptionHandlerWithUI());
			return true;
		}
		catch (SecurityException)
		{
			try
			{
				try
				{
					DoNotEncodeStringsAttribute.smethod_0(typeof(Application).TypeHandle, 188, 229).InvokeMember("EnableVisualStyles", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
				}
				catch (MissingMethodException)
				{
				}
				string securityMessage = string.Format("{0} cannot initialize itself because some permissions are not granted.\n\nYou probably try to launch {0} in a partial-trust situation. It's usually the case when the application is hosted on a network share.\n\nYou need to run {0} in full-trust, or at least grant it the UnmanagedCode security permission.\n\nTo grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.", "Nc0j6W1Ag");
				Form1 form = new Form1(new SecurityExceptionEventArgs(securityMessage, canContinue: false));
				((Form)form).set_ShowInTaskbar(true);
				((Form)form).ShowDialog();
			}
			catch (Exception exception_)
			{
				MessageBox.Show(Win32.smethod_10(exception_, 292, 338), string.Format("{0} Unexpected Error", "Nc0j6W1Ag"), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return false;
		}
	}

	static UnhandledExceptionHandlerWithUI()
	{
		DESCryptoIndirector.smethod_0();
	}

	internal static void smethod_1(Image image_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 16:
				image_0.Dispose();
				return;
			}
		}
	}

	internal static string smethod_2(ref long long_0, string string_1, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 44:
				return long_0.ToString(string_1);
			}
		}
	}

	internal static void smethod_3(Graphics graphics_0, IntPtr intptr_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 115:
				graphics_0.ReleaseHdc(intptr_0);
				return;
			}
		}
	}
}
