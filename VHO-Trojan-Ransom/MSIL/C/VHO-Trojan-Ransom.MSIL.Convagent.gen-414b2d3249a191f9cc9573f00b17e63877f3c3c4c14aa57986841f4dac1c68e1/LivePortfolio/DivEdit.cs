using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using Microsoft.VisualBasic.CompilerServices;

namespace LivePortfolio;

[DesignerGenerated]
public class DivEdit : Window, IComponentConnector
{
	private bool _contentLoaded;

	[field: AccessedThroughProperty("AssetPrompt"), SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
	internal virtual TextBlock AssetPrompt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button cmdCommit
	{
		[CompilerGenerated]
		get
		{
			return _cmdCommit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			RoutedEventHandler val = new RoutedEventHandler(cmdCommit_Click);
			Button val2 = _cmdCommit;
			if (val2 != null)
			{
				((ButtonBase)val2).remove_Click(val);
			}
			_cmdCommit = value;
			val2 = _cmdCommit;
			if (val2 != null)
			{
				((ButtonBase)val2).add_Click(val);
			}
		}
	}

	[field: SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields"), AccessedThroughProperty("cmdClose")]
	internal virtual Button cmdClose
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public DivEdit(Dividend D)
	{
		((FrameworkElement)this).set_DataContext((object)new DivEditViewModel((ListDividend)D));
		InitializeComponent();
	}

	private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
	}

	private void CloseWindow(object sender, RoutedEventArgs e)
	{
		((Window)this).Close();
	}

	private void cmdCommit_Click(object sender, RoutedEventArgs e)
	{
		NewLateBinding.LateCall(((FrameworkElement)this).get_DataContext(), (Type)null, "commit", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		((Window)this).Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri uri = new Uri("/LivePortfolio;component/view/divedit.xaml", UriKind.Relative);
			Application.LoadComponent((object)this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	[DebuggerNonUserCode]
	[SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public void System_Windows_Markup_IComponentConnector_Connect(int connectionId, object target)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
			AssetPrompt = (TextBlock)target;
			break;
		case 2:
			cmdCommit = (Button)target;
			break;
		case 3:
			cmdClose = (Button)target;
			((ButtonBase)cmdClose).add_Click(new RoutedEventHandler(CloseWindow));
			break;
		default:
			_contentLoaded = true;
			break;
		}
	}
}
