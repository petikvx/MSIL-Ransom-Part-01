using System;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartExceptionsWithUI;

public class UnhandledExceptionHandlerWithUI1 : UnhandledExceptionHandler1
{
	protected override void OnSecurityException(SecurityExceptionEventArgs1 e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		SecurityExceptionForm securityExceptionForm = new SecurityExceptionForm(e);
		try
		{
			((Form)securityExceptionForm).ShowDialog();
		}
		finally
		{
			((IDisposable)securityExceptionForm)?.Dispose();
		}
	}

	protected override void OnReportException(ReportExceptionEventArgs1 e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		ExceptionReportingForm exceptionReportingForm = new ExceptionReportingForm(this, e);
		try
		{
			((Form)exceptionReportingForm).ShowDialog();
		}
		finally
		{
			((IDisposable)exceptionReportingForm)?.Dispose();
		}
	}

	protected override void OnFatalException(FatalExceptionEventArgs1 e)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(e.FatalException.ToString(), string.Format("{0} Unexpected Error", "server2"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static bool AttachApp()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			UnhandledExceptionHandler1.AttachExceptionHandler(new UnhandledExceptionHandlerWithUI1());
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
				string securityMessage = string.Format("{0} cannot initialize itself because some permissions are not granted.\n\nYou probably try to launch {0} in a partial-trust situation. It's usually the case when the application is hosted on a network share.\n\nYou need to run {0} in full-trust, or at least grant it the UnmanagedCode security permission.\n\nTo grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.", "server2");
				SecurityExceptionForm securityExceptionForm = new SecurityExceptionForm(new SecurityExceptionEventArgs1(securityMessage, canContinue: false));
				((Form)securityExceptionForm).set_ShowInTaskbar(true);
				((Form)securityExceptionForm).ShowDialog();
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString(), string.Format("{0} Unexpected Error", "server2"), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return false;
		}
	}
}