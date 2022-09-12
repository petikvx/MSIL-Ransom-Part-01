using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace xbot_wpf;

public class SettingsView : UserControl, IComponentConnector
{
	internal Button Save;

	internal Button OpenData;

	internal ScrollViewer Scroller1;

	internal TextBox Username;

	internal TextBox Password;

	internal TextBox ApiKeySteam;

	internal TextBox ApiKey;

	private bool bool_0;

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!bool_0)
		{
			bool_0 = true;
			Uri uri = new Uri("/xtrades;component/views/settingsview.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			bool_0 = true;
			break;
		case 1:
			Save = (Button)target;
			break;
		case 2:
			OpenData = (Button)target;
			break;
		case 3:
			Scroller1 = (ScrollViewer)target;
			break;
		case 4:
			Username = (TextBox)target;
			break;
		case 5:
			Password = (TextBox)target;
			break;
		case 6:
			ApiKeySteam = (TextBox)target;
			break;
		case 7:
			ApiKey = (TextBox)target;
			break;
		}
	}

	public SettingsView()
	{
		Class24.nhQmSIPz7n4eU();
		((UserControl)this)._002Ector();
	}
}
