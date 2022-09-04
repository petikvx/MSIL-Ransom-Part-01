using System;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
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
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(e.FatalException.ToString(), string.Format("{0} Unexpected Error", "ybgcy1txEhE"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static bool AttachApp()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
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
					typeof(Application).InvokeMember("EnableVisualStyles", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
				}
				catch (MissingMethodException)
				{
				}
				string securityMessage = string.Format("{0} cannot initialize itself because some permissions are not granted.\n\nYou probably try to launch {0} in a partial-trust situation. It's usually the case when the application is hosted on a network share.\n\nYou need to run {0} in full-trust, or at least grant it the UnmanagedCode security permission.\n\nTo grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.", "ybgcy1txEhE");
				Form1 form = new Form1(new SecurityExceptionEventArgs(securityMessage, canContinue: false));
				((Form)form).set_ShowInTaskbar(true);
				((Form)form).ShowDialog();
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString(), string.Format("{0} Unexpected Error", "ybgcy1txEhE"), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return false;
		}
	}
}
