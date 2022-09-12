using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace xbot_wpf;

public class SteamTraderView : UserControl, IComponentConnector
{
	internal Button StartAll;

	internal ScrollViewer Scroller1;

	internal Button TradesAcceptCsgo;

	internal ScrollViewer Scroller;

	internal TextBlock OutputBlock;

	internal ScrollViewer Scroller2;

	internal Button TradesAcceptDota2;

	internal ScrollViewer ScrollerDota2;

	internal TextBlock OutputBlockDota2;

	private bool bool_0;

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!bool_0)
		{
			bool_0 = true;
			Uri uri = new Uri("/xtrades;component/views/steamtraderview.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		switch (connectionId)
		{
		default:
			bool_0 = true;
			break;
		case 1:
			StartAll = (Button)target;
			break;
		case 2:
			Scroller1 = (ScrollViewer)target;
			break;
		case 3:
			TradesAcceptCsgo = (Button)target;
			break;
		case 4:
			Scroller = (ScrollViewer)target;
			break;
		case 5:
			OutputBlock = (TextBlock)target;
			break;
		case 6:
			Scroller2 = (ScrollViewer)target;
			break;
		case 7:
			TradesAcceptDota2 = (Button)target;
			break;
		case 8:
			ScrollerDota2 = (ScrollViewer)target;
			break;
		case 9:
			OutputBlockDota2 = (TextBlock)target;
			break;
		}
	}

	public SteamTraderView()
	{
		Class24.nhQmSIPz7n4eU();
		((UserControl)this)._002Ector();
	}
}
