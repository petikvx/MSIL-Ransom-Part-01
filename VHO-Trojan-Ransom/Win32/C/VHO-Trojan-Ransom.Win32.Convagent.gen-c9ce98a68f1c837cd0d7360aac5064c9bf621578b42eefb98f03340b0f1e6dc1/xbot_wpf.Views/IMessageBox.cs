using System;

namespace xbot_wpf.Views;

public interface IMessageBox
{
	void ShowException(Exception exc);

	void Show(string message);
}
