using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace xbot_wpf;

public class LoginView : Window, IComponentConnector
{
	internal LoginView LoginWindow;

	internal TextBox Login;

	internal TextBox Password;

	internal Button DoLogin;

	internal Button ForgotPassword;

	private bool bool_0;

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!bool_0)
		{
			bool_0 = true;
			Uri uri = new Uri("/xtrades;component/views/loginview.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			bool_0 = true;
			break;
		case 1:
			LoginWindow = (LoginView)target;
			break;
		case 2:
			Login = (TextBox)target;
			break;
		case 3:
			Password = (TextBox)target;
			break;
		case 4:
			DoLogin = (Button)target;
			break;
		case 5:
			ForgotPassword = (Button)target;
			break;
		}
	}

	public LoginView()
	{
		Class24.nhQmSIPz7n4eU();
		((Window)this)._002Ector();
	}
}
