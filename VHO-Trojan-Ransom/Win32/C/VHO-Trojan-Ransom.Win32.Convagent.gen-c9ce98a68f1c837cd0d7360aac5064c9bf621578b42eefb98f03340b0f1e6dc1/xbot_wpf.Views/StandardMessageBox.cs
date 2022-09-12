using System;
using System.Windows;

namespace xbot_wpf.Views;

public class StandardMessageBox : IMessageBox
{
	public void ShowException(Exception exc)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(exc.ToString(), "Ошибка");
	}

	public void Show(string message)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(message, "Уведомление");
	}

	public StandardMessageBox()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
