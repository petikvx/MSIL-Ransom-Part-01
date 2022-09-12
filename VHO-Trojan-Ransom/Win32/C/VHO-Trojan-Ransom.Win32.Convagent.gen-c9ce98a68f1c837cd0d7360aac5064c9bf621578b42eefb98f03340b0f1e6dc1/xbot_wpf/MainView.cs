using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Hardcodet.Wpf.TaskbarNotification;

namespace xbot_wpf;

public class MainView : Window, IComponentConnector
{
	internal MainView MainWindow;

	internal TaskbarIcon NotifyIcon;

	internal Button SteamTrader;

	internal Button Settings;

	internal Grid Screens;

	internal ContentControl ActiveItem;

	internal Grid footer;

	internal TextBlock License;

	private bool bool_0;

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!bool_0)
		{
			bool_0 = true;
			Uri uri = new Uri("/xtrades;component/views/mainview.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			bool_0 = true;
			break;
		case 1:
			MainWindow = (MainView)target;
			break;
		case 2:
			NotifyIcon = (TaskbarIcon)target;
			break;
		case 3:
			SteamTrader = (Button)target;
			break;
		case 4:
			Settings = (Button)target;
			break;
		case 5:
			Screens = (Grid)target;
			break;
		case 6:
			ActiveItem = (ContentControl)target;
			break;
		case 7:
			footer = (Grid)target;
			break;
		case 8:
			License = (TextBlock)target;
			break;
		}
	}

	public MainView()
	{
		Class24.nhQmSIPz7n4eU();
		((Window)this)._002Ector();
	}
}
