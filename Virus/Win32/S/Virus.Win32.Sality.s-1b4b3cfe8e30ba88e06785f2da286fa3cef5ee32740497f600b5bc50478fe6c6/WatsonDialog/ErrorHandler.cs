using System;
using System.Windows.Forms;
using Microsoft.NetEnterpriseServers;

namespace WatsonDialog;

internal static class ErrorHandler
{
	internal static DialogResult Error(string message, string title, ExceptionMessageBoxButtons buttons, ExceptionMessageBoxSymbol icon, Exception ex)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		ApplicationException ex2 = ((ex != null) ? new ApplicationException(message, ex) : new ApplicationException(message));
		ex2.Source = title;
		ExceptionMessageBox val = new ExceptionMessageBox((Exception)ex2, buttons, icon);
		return val.Show((IWin32Window)(object)Form.get_ActiveForm());
	}

	internal static DialogResult Error(string message, string title, ExceptionMessageBoxButtons buttons, ExceptionMessageBoxSymbol icon)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return Error(message, title, buttons, icon, null);
	}

	internal static DialogResult Error(string message, ExceptionMessageBoxButtons buttons, Exception ex)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return Error(message, Constants.ERROR_MESSAGE_TITLE, buttons, (ExceptionMessageBoxSymbol)3, ex);
	}

	internal static DialogResult Error(string message, ExceptionMessageBoxButtons buttons)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		return Error(message, Constants.ERROR_MESSAGE_TITLE, buttons, (ExceptionMessageBoxSymbol)3, null);
	}

	internal static DialogResult Error(string message)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return Error(message, (ExceptionMessageBoxButtons)0);
	}
}
