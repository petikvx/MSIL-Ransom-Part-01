using System;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using SmartAssembly.SmartExceptionsCore;

namespace SmartAssembly.SmartExceptionsWithUI;

public sealed class UnhandledExceptionHandlerWithUI : UnhandledExceptionHandler
{
	[NonSerialized]
	internal static GetString getString_1;

	static UnhandledExceptionHandlerWithUI()
	{
		Strings.CreateGetStringDelegate(typeof(UnhandledExceptionHandlerWithUI));
	}

	protected override void OnSecurityException(SecurityExceptionEventArgs securityExceptionEventArgs_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		SecurityExceptionForm securityExceptionForm = new SecurityExceptionForm(securityExceptionEventArgs_0);
		try
		{
			((Form)securityExceptionForm).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)securityExceptionForm)?.Dispose();
		}
	}

	protected override void OnReportException(ReportExceptionEventArgs reportExceptionEventArgs_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		ExceptionReportingForm exceptionReportingForm = new ExceptionReportingForm(this, reportExceptionEventArgs_0);
		try
		{
			((Form)exceptionReportingForm).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)exceptionReportingForm)?.Dispose();
		}
	}

	protected override void OnFatalException(FatalExceptionEventArgs fatalExceptionEventArgs_0)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(fatalExceptionEventArgs_0.FatalException.ToString(), string.Format(getString_1(5696), getString_1(4590)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static bool AttachApp()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
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
					typeof(Application).InvokeMember(getString_1(5725), BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
				}
				catch (MissingMethodException)
				{
				}
				string string_ = string.Format(getString_1(5750), getString_1(4590));
				SecurityExceptionForm securityExceptionForm = new SecurityExceptionForm(new SecurityExceptionEventArgs(string_, bool_3: false));
				((Form)securityExceptionForm).set_ShowInTaskbar(true);
				((Form)securityExceptionForm).ShowDialog();
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString(), string.Format(getString_1(5696), getString_1(4590)), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return false;
		}
	}
}
